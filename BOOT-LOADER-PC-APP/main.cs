using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;


namespace HexBootLoaderV1._
{
    public partial class Form1 : Form
    {
        int RetryVariable = 0;
        int RetryNumber = 0;
        String Path = "";
        Int32 LineCount = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BautRateBoxSelector.Text = "256000";

            ComBoxSelector.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                string cleaned = Regex.Match(port, @"COM\d+").Value;
                ComBoxSelector.Items.Add(cleaned);
            }
            if (ComBoxSelector.Items.Count > 0)
                ComBoxSelector.SelectedIndex = 0;

            if (ComBoxSelector.Items.Count > 0) ComBoxSelector.SelectedIndex = 0;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //TempReceived = System.Convert.ToChar(serialPort1.ReadExisting()[0]);
        }

        private void BrowseAndUploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Reset();
                openFileDialog1.Filter = "Hex files (*.hex)|*.hex";
                openFileDialog1.ShowReadOnly = true;
                openFileDialog1.ShowDialog();
                Path = openFileDialog1.FileName;
                if (Path.Length != 0)
                {
                    serialPort1.PortName = ComBoxSelector.Text;
                    serialPort1.BaudRate = System.Convert.ToInt32(BautRateBoxSelector.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.ReceivedBytesThreshold = 8;
                    serialPort1.WriteBufferSize = 256;
                    serialPort1.ReadBufferSize = 256;
                    serialPort1.ReadTimeout = -1;
                    serialPort1.WriteTimeout = -1;
                    serialPort1.DtrEnable = true;
                    serialPort1.RtsEnable = true;
                    serialPort1.Open();
                    RetryVariable = 0;
                    LogBox.Items.Add("Try to enter in write mode: 1");
                    RetryEnterInWriteModeTimmer.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show(this, "Can not open selected com port.", "Error on open comm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetryEnterInWriteModeTimmer_Tick(object sender, EventArgs e)
        {
            RetryEnterInWriteModeTimmer.Enabled = false;
            String A = " ";
            int itemsPerPage = 0;
            Boolean ErrorEEpFileNotFound = false;
            if (serialPort1.BytesToRead != 0)
            {
                A = serialPort1.ReadExisting();
            }
            if (A[A.Length-1] == 'k')
            {
                LogBox.Items.Add("Entered in bootloader succesful");//A.Substring(0,A.Length-2));
                itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                LogBox.Items.Add("***Morgoth HexBootLoader V1.2 Started***");//A.Substring(0,A.Length-2));
                itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;

                FlashEEPromListBox.Items.Clear();
                FlashEEPromListBox.Items.Add("FlashW");
                using (StreamReader sr = File.OpenText(Path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        FlashEEPromListBox.Items.Add(s);
                    }
                }
                LogBox.Items.Add("Hex file imported succesfuly");
                itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                if (EEPromUploadCheckBox.Checked == true)
                {
                    String B = System.IO.Path.GetFileNameWithoutExtension(Path);
                    String C = System.IO.Path.GetDirectoryName(Path) + "/";
                    if (File.Exists(C + B + ".eep"))
                    {
                        FlashEEPromListBox.Items.Add("EEPromW");
                        using (StreamReader sr = File.OpenText(C + B + ".eep"))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                                FlashEEPromListBox.Items.Add(s);
                            }
                        }
                        LogBox.Items.Add("Eep file imported succesfuly");
                        itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                        LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                    }
                    else
                    {
                        if (ErrIfEepFileNotExist.Checked == true)
                        {
                            LogBox.Items.Add("Error EEProm file not found");
                            itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                            LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                            serialPort1.Close();
                            ErrorEEpFileNotFound = true;
                        }
                        else
                        {
                            LogBox.Items.Add("EEProm file not found");
                            itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                            LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                        }
                    }
                }
                if (ErrorEEpFileNotFound == false)
                {
                    FlashEEPromListBox.Items.Add("Exit");
                    LineCount = 0;
                    EnteredInWriteModeTimmer.Enabled = true;
                }
            }
            else
            {
                if (RetryVariable < System.Convert.ToUInt16(NumberOfretryesForEnterInWrite.Value))
                {
                    serialPort1.ReadExisting();
                    serialPort1.Write("BootInit\r");
                    RetryVariable++;
                    LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    String Z = LogBox.Text.Substring(0, 27) + System.Convert.ToString(RetryVariable);
                    LogBox.Items.RemoveAt(LogBox.Items.Count - 1);
                    LogBox.Items.Add(Z);
                    LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                    LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                    RetryEnterInWriteModeTimmer.Enabled = true;
                }
                else
                {
                    serialPort1.Close();
                    MessageBox.Show("Timed out");
                }
            }
        }

        private void EnteredInWriteModeTimmer_Tick(object sender, EventArgs e)
        {
            EnteredInWriteModeTimmer.Enabled = false;
            String Temp = "";
            int itemsPerPage = 0;
            progressBar1.Maximum = FlashEEPromListBox.Items.Count;
            progressBar1.Minimum = 0;
            int BarGraphValue = 0;
            serialPort1.ReadExisting();
            UInt32 TimeOutResponse = 0;
            for (Int32 X = 0; X < FlashEEPromListBox.Items.Count; X++)
            {
                BarGraphValue++;
                progressBar1.Value = BarGraphValue;
                progressBar1.Refresh();
                FlashEEPromListBox.SelectedIndex = X;
                if (FlashEEPromListBox.Text == "FlashW")
                {
                    LogBox.Items.Add("Writing Flash line:  ");
                    itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                    LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                    LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    LineCount = 0;
                }
                if (FlashEEPromListBox.Text == "EEPromW")
                {
                    LogBox.Items.Add("Writing EEProm line: ");
                    itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                    LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                    LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    LineCount = 0;
                }
                LineCount++;
                String Z = LogBox.Text.Substring(0, 20) + System.Convert.ToString(LineCount);
                LogBox.Items.RemoveAt(LogBox.Items.Count - 1);
                LogBox.Items.Add(Z);
                LogBox.SelectedIndex = LogBox.Items.Count - 1;
                itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                TimeOutResponse = 0;
                serialPort1.Write(FlashEEPromListBox.Text + '\r');
                while (serialPort1.BytesToRead == 0) 
                {
                    Thread.Sleep(1);
                    if (TimeOutResponse == 2000) break;
                    TimeOutResponse++;
                }
                if (TimeOutResponse == 2000) break;
                Temp = System.Convert.ToString(serialPort1.ReadExisting()[0]);
                //textBox1.Text = Temp;
                //textBox1.Refresh();
                if (Temp.Length != 0)
                {
                    if (Temp == "a")
                    {
                        LogBox.Items.Add("Line definition error");
                        break;
                    }
                    if (Temp == "b")
                    {
                        LogBox.Items.Add("Second hex char not found");
                        break;
                    }
                    if (Temp == "c")
                    {
                        LogBox.Items.Add("Checksum line error");
                        break;
                    }
                    if (Temp == "d")
                    {
                        LogBox.Items.Add("Line mismach");
                        break;
                    }
                    if (Temp == "e")
                    {
                        LogBox.Items.Add("Attempt to write to non selected memory");
                        break;
                    }
                    if (Temp != "k")
                    {
                        if (Temp != "f")
                        {
                            LogBox.Items.Add("Uncnown error");
                            break;
                        }
                    }
                }
                //LogBox.Refresh();
                //SelectionTab.Refresh();
                //BautRateBoxSelector.Refresh();
                //ComBoxSelector.Refresh();
                //BrowseAndUploadButton.Refresh();
                //StopRetryButton.Refresh();
                //ClearLogButton.Refresh();
            }
            if (Temp == "f")
            {
                LogBox.Items.Add("Upload succesful");
                serialPort1.Close();
            }
            else
            {
                RetryNumber++;
                if (RetryNumber <= System.Convert.ToUInt16(NumberOfRetryesIfTransmisionIsCorupted.Value))
                {
                    LogBox.Items.Add("Retry transmission corupted: " + RetryNumber);
                    itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
                    LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
                    EnteredInWriteModeTimmer.Enabled = true;
                }
                else
                {
                    serialPort1.Close();
                }
            }
            itemsPerPage = (int)(LogBox.Height / LogBox.ItemHeight);
            LogBox.TopIndex = LogBox.Items.Count - itemsPerPage;
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogBox.Items.Clear();
        }

        private void StopRetryButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                RetryEnterInWriteModeTimmer.Enabled = false;
            }
            catch
            { }
        }

        private void ComBoxSelector_DropDown(object sender, EventArgs e)
        {
            ComBoxSelector.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                string cleaned = Regex.Match(port, @"COM\d+").Value;
                ComBoxSelector.Items.Add(cleaned);
            }
            if (ComBoxSelector.Items.Count > 0)
                ComBoxSelector.SelectedIndex = 0;
        }

        private void linkLabel_VisitPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://morgothdisk.com:30001/explore/projects");
        }

        private void linkLabel_GoToMySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://morgothdisk.com:30001");
        }
    }
}