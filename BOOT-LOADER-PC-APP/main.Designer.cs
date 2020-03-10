namespace HexBootLoaderV1._
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComBoxSelector = new System.Windows.Forms.ComboBox();
            this.BrowseAndUploadButton = new System.Windows.Forms.Button();
            this.BautRateBoxSelector = new System.Windows.Forms.ComboBox();
            this.SelectionTab = new System.Windows.Forms.TabControl();
            this.BootLoaderTab = new System.Windows.Forms.TabPage();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.StopRetryButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ErrIfEepFileNotExist = new System.Windows.Forms.CheckBox();
            this.EEPromUploadCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfRetryesIfTransmisionIsCorupted = new System.Windows.Forms.NumericUpDown();
            this.NumberOfretryesForEnterInWrite = new System.Windows.Forms.NumericUpDown();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.FlashEEPromListBox = new System.Windows.Forms.ListBox();
            this.linkLabel_GoToMySite = new System.Windows.Forms.LinkLabel();
            this.linkLabel_VisitPage = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RetryEnterInWriteModeTimmer = new System.Windows.Forms.Timer(this.components);
            this.EnteredInWriteModeTimmer = new System.Windows.Forms.Timer(this.components);
            this.SelectionTab.SuspendLayout();
            this.BootLoaderTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRetryesIfTransmisionIsCorupted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfretryesForEnterInWrite)).BeginInit();
            this.AboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBoxSelector
            // 
            this.ComBoxSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComBoxSelector.FormattingEnabled = true;
            this.ComBoxSelector.Location = new System.Drawing.Point(6, 33);
            this.ComBoxSelector.Name = "ComBoxSelector";
            this.ComBoxSelector.Size = new System.Drawing.Size(104, 21);
            this.ComBoxSelector.TabIndex = 0;
            this.ComBoxSelector.DropDown += new System.EventHandler(this.ComBoxSelector_DropDown);
            // 
            // BrowseAndUploadButton
            // 
            this.BrowseAndUploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseAndUploadButton.Location = new System.Drawing.Point(6, 60);
            this.BrowseAndUploadButton.Name = "BrowseAndUploadButton";
            this.BrowseAndUploadButton.Size = new System.Drawing.Size(104, 21);
            this.BrowseAndUploadButton.TabIndex = 1;
            this.BrowseAndUploadButton.Text = "Upload";
            this.BrowseAndUploadButton.UseVisualStyleBackColor = true;
            this.BrowseAndUploadButton.Click += new System.EventHandler(this.BrowseAndUploadButton_Click);
            // 
            // BautRateBoxSelector
            // 
            this.BautRateBoxSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BautRateBoxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BautRateBoxSelector.FormattingEnabled = true;
            this.BautRateBoxSelector.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "250000",
            "256000",
            "500000",
            "1000000"});
            this.BautRateBoxSelector.Location = new System.Drawing.Point(6, 6);
            this.BautRateBoxSelector.Name = "BautRateBoxSelector";
            this.BautRateBoxSelector.Size = new System.Drawing.Size(104, 21);
            this.BautRateBoxSelector.TabIndex = 2;
            // 
            // SelectionTab
            // 
            this.SelectionTab.Controls.Add(this.BootLoaderTab);
            this.SelectionTab.Controls.Add(this.tabPage1);
            this.SelectionTab.Controls.Add(this.AboutTab);
            this.SelectionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectionTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionTab.Location = new System.Drawing.Point(12, 12);
            this.SelectionTab.Name = "SelectionTab";
            this.SelectionTab.SelectedIndex = 0;
            this.SelectionTab.Size = new System.Drawing.Size(512, 188);
            this.SelectionTab.TabIndex = 4;
            // 
            // BootLoaderTab
            // 
            this.BootLoaderTab.Controls.Add(this.ClearLogButton);
            this.BootLoaderTab.Controls.Add(this.StopRetryButton);
            this.BootLoaderTab.Controls.Add(this.LogBox);
            this.BootLoaderTab.Controls.Add(this.progressBar1);
            this.BootLoaderTab.Controls.Add(this.BautRateBoxSelector);
            this.BootLoaderTab.Controls.Add(this.ComBoxSelector);
            this.BootLoaderTab.Controls.Add(this.BrowseAndUploadButton);
            this.BootLoaderTab.Location = new System.Drawing.Point(4, 22);
            this.BootLoaderTab.Name = "BootLoaderTab";
            this.BootLoaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.BootLoaderTab.Size = new System.Drawing.Size(504, 162);
            this.BootLoaderTab.TabIndex = 0;
            this.BootLoaderTab.Text = "Boot loader tab";
            this.BootLoaderTab.UseVisualStyleBackColor = true;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLogButton.Location = new System.Drawing.Point(6, 114);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(104, 21);
            this.ClearLogButton.TabIndex = 7;
            this.ClearLogButton.Text = "Clear log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // StopRetryButton
            // 
            this.StopRetryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopRetryButton.Location = new System.Drawing.Point(6, 87);
            this.StopRetryButton.Name = "StopRetryButton";
            this.StopRetryButton.Size = new System.Drawing.Size(104, 21);
            this.StopRetryButton.TabIndex = 6;
            this.StopRetryButton.Text = "Stop from retry";
            this.StopRetryButton.UseVisualStyleBackColor = true;
            this.StopRetryButton.Click += new System.EventHandler(this.StopRetryButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(116, 6);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(382, 121);
            this.LogBox.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 15);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ErrIfEepFileNotExist);
            this.tabPage1.Controls.Add(this.EEPromUploadCheckBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NumberOfRetryesIfTransmisionIsCorupted);
            this.tabPage1.Controls.Add(this.NumberOfretryesForEnterInWrite);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 162);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ErrIfEepFileNotExist
            // 
            this.ErrIfEepFileNotExist.AutoSize = true;
            this.ErrIfEepFileNotExist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ErrIfEepFileNotExist.Location = new System.Drawing.Point(147, 58);
            this.ErrIfEepFileNotExist.Name = "ErrIfEepFileNotExist";
            this.ErrIfEepFileNotExist.Size = new System.Drawing.Size(182, 17);
            this.ErrIfEepFileNotExist.TabIndex = 5;
            this.ErrIfEepFileNotExist.Text = "Error if eeprom file not exist";
            this.ErrIfEepFileNotExist.UseVisualStyleBackColor = true;
            // 
            // EEPromUploadCheckBox
            // 
            this.EEPromUploadCheckBox.AutoSize = true;
            this.EEPromUploadCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EEPromUploadCheckBox.Location = new System.Drawing.Point(6, 58);
            this.EEPromUploadCheckBox.Name = "EEPromUploadCheckBox";
            this.EEPromUploadCheckBox.Size = new System.Drawing.Size(135, 17);
            this.EEPromUploadCheckBox.TabIndex = 4;
            this.EEPromUploadCheckBox.Text = "Upload EEProm file";
            this.EEPromUploadCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of retryes if error occurred (1 to 10)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of retryes to enter in write mode(1 to 10000)";
            // 
            // NumberOfRetryesIfTransmisionIsCorupted
            // 
            this.NumberOfRetryesIfTransmisionIsCorupted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberOfRetryesIfTransmisionIsCorupted.Location = new System.Drawing.Point(6, 32);
            this.NumberOfRetryesIfTransmisionIsCorupted.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfRetryesIfTransmisionIsCorupted.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfRetryesIfTransmisionIsCorupted.Name = "NumberOfRetryesIfTransmisionIsCorupted";
            this.NumberOfRetryesIfTransmisionIsCorupted.Size = new System.Drawing.Size(72, 20);
            this.NumberOfRetryesIfTransmisionIsCorupted.TabIndex = 1;
            this.NumberOfRetryesIfTransmisionIsCorupted.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberOfretryesForEnterInWrite
            // 
            this.NumberOfretryesForEnterInWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberOfretryesForEnterInWrite.Location = new System.Drawing.Point(6, 6);
            this.NumberOfretryesForEnterInWrite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfretryesForEnterInWrite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfretryesForEnterInWrite.Name = "NumberOfretryesForEnterInWrite";
            this.NumberOfretryesForEnterInWrite.Size = new System.Drawing.Size(72, 20);
            this.NumberOfretryesForEnterInWrite.TabIndex = 0;
            this.NumberOfretryesForEnterInWrite.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.FlashEEPromListBox);
            this.AboutTab.Controls.Add(this.linkLabel_GoToMySite);
            this.AboutTab.Controls.Add(this.linkLabel_VisitPage);
            this.AboutTab.Controls.Add(this.pictureBox1);
            this.AboutTab.Controls.Add(this.richTextBox1);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(504, 162);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // FlashEEPromListBox
            // 
            this.FlashEEPromListBox.FormattingEnabled = true;
            this.FlashEEPromListBox.Location = new System.Drawing.Point(468, 129);
            this.FlashEEPromListBox.Name = "FlashEEPromListBox";
            this.FlashEEPromListBox.Size = new System.Drawing.Size(30, 30);
            this.FlashEEPromListBox.TabIndex = 8;
            this.FlashEEPromListBox.Visible = false;
            // 
            // linkLabel_GoToMySite
            // 
            this.linkLabel_GoToMySite.AutoSize = true;
            this.linkLabel_GoToMySite.Location = new System.Drawing.Point(6, 137);
            this.linkLabel_GoToMySite.Name = "linkLabel_GoToMySite";
            this.linkLabel_GoToMySite.Size = new System.Drawing.Size(130, 13);
            this.linkLabel_GoToMySite.TabIndex = 3;
            this.linkLabel_GoToMySite.TabStop = true;
            this.linkLabel_GoToMySite.Text = "Go to my projects site";
            this.linkLabel_GoToMySite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GoToMySite_LinkClicked);
            // 
            // linkLabel_VisitPage
            // 
            this.linkLabel_VisitPage.AutoSize = true;
            this.linkLabel_VisitPage.Location = new System.Drawing.Point(6, 117);
            this.linkLabel_VisitPage.Name = "linkLabel_VisitPage";
            this.linkLabel_VisitPage.Size = new System.Drawing.Size(288, 13);
            this.linkLabel_VisitPage.TabIndex = 2;
            this.linkLabel_VisitPage.TabStop = true;
            this.linkLabel_VisitPage.Text = "For more information please visit description page";
            this.linkLabel_VisitPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_VisitPage_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HexBootLoaderV1._0.Properties.Resources.Logo_Brain;
            this.pictureBox1.Location = new System.Drawing.Point(385, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(373, 108);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "ATmega Hex Boot Loader  V1.2";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RetryEnterInWriteModeTimmer
            // 
            this.RetryEnterInWriteModeTimmer.Interval = 200;
            this.RetryEnterInWriteModeTimmer.Tick += new System.EventHandler(this.RetryEnterInWriteModeTimmer_Tick);
            // 
            // EnteredInWriteModeTimmer
            // 
            this.EnteredInWriteModeTimmer.Interval = 1;
            this.EnteredInWriteModeTimmer.Tick += new System.EventHandler(this.EnteredInWriteModeTimmer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(536, 212);
            this.Controls.Add(this.SelectionTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ATmega Hex Boot Loader V1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectionTab.ResumeLayout(false);
            this.BootLoaderTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRetryesIfTransmisionIsCorupted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfretryesForEnterInWrite)).EndInit();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBoxSelector;
        private System.Windows.Forms.Button BrowseAndUploadButton;
        private System.Windows.Forms.ComboBox BautRateBoxSelector;
        private System.Windows.Forms.TabControl SelectionTab;
        private System.Windows.Forms.TabPage BootLoaderTab;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Timer RetryEnterInWriteModeTimmer;
        private System.Windows.Forms.Timer EnteredInWriteModeTimmer;
        private System.Windows.Forms.Button StopRetryButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumberOfRetryesIfTransmisionIsCorupted;
        private System.Windows.Forms.NumericUpDown NumberOfretryesForEnterInWrite;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel_VisitPage;
        private System.Windows.Forms.LinkLabel linkLabel_GoToMySite;
        private System.Windows.Forms.ListBox FlashEEPromListBox;
        private System.Windows.Forms.CheckBox EEPromUploadCheckBox;
        private System.Windows.Forms.CheckBox ErrIfEepFileNotExist;
    }
}

