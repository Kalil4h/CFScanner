﻿namespace WinCFScan
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timerBase = new System.Windows.Forms.Timer(this.components);
            this.prgOveral = new System.Windows.Forms.ProgressBar();
            this.prgCurRange = new System.Windows.Forms.ProgressBar();
            this.btnSkipCurRange = new System.Windows.Forms.Button();
            this.labelLastIPChecked = new System.Windows.Forms.Label();
            this.lblLastIPRange = new System.Windows.Forms.Label();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDebugMode = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.btnCopyFastestIP = new System.Windows.Forms.Button();
            this.txtFastestIP = new System.Windows.Forms.TextBox();
            this.lblFastestIP = new System.Windows.Forms.Label();
            this.comboConcurrent = new System.Windows.Forms.ComboBox();
            this.lblConcurrent = new System.Windows.Forms.Label();
            this.lblTotalWorkingIPs = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboResults = new System.Windows.Forms.ComboBox();
            this.btnScanInPrevResults = new System.Windows.Forms.Button();
            this.btnLoadIPRanges = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListView();
            this.hdrDelay = new System.Windows.Forms.ColumnHeader();
            this.hdrIP = new System.Windows.Forms.ColumnHeader();
            this.mnuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuListViewCopyIP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListViewTestThisIPAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCFRanges = new System.Windows.Forms.TabPage();
            this.lblCFIPListStatus = new System.Windows.Forms.Label();
            this.btnSelectNoneIPRanges = new System.Windows.Forms.Button();
            this.btnSelectAllIPRanges = new System.Windows.Forms.Button();
            this.listCFIPList = new System.Windows.Forms.ListView();
            this.headIPRange = new System.Windows.Forms.ColumnHeader();
            this.headTotalIPs = new System.Windows.Forms.ColumnHeader();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.lblPrevListTotalIPs = new System.Windows.Forms.Label();
            this.lblPrevResults = new System.Windows.Forms.Label();
            this.btnResultsActions = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCustomIPRangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importScanResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportScanResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanASingleIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mnuResultsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.mnuListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCFRanges.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.mnuResultsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(685, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Scan";
            this.toolTip1.SetToolTip(this.btnStart, "Scan in selected IP ranges of Cloudflare");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(780, 185);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "Welcome to Cloudflare IP Scanner.\r\n";
            // 
            // timerBase
            // 
            this.timerBase.Enabled = true;
            this.timerBase.Interval = 1500;
            this.timerBase.Tick += new System.EventHandler(this.timerBase_Tick);
            // 
            // prgOveral
            // 
            this.prgOveral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgOveral.Location = new System.Drawing.Point(274, 47);
            this.prgOveral.Name = "prgOveral";
            this.prgOveral.Size = new System.Drawing.Size(260, 20);
            this.prgOveral.TabIndex = 5;
            this.toolTip1.SetToolTip(this.prgOveral, "Overal progress");
            // 
            // prgCurRange
            // 
            this.prgCurRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgCurRange.Location = new System.Drawing.Point(274, 20);
            this.prgCurRange.Name = "prgCurRange";
            this.prgCurRange.Size = new System.Drawing.Size(260, 20);
            this.prgCurRange.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCurRange.TabIndex = 4;
            this.toolTip1.SetToolTip(this.prgCurRange, "Current IP range progress");
            // 
            // btnSkipCurRange
            // 
            this.btnSkipCurRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkipCurRange.Enabled = false;
            this.btnSkipCurRange.Location = new System.Drawing.Point(545, 19);
            this.btnSkipCurRange.Name = "btnSkipCurRange";
            this.btnSkipCurRange.Size = new System.Drawing.Size(131, 23);
            this.btnSkipCurRange.TabIndex = 3;
            this.btnSkipCurRange.Text = "Skip curent IP range";
            this.btnSkipCurRange.UseVisualStyleBackColor = true;
            this.btnSkipCurRange.Click += new System.EventHandler(this.btnSkipCurRange_Click);
            // 
            // labelLastIPChecked
            // 
            this.labelLastIPChecked.AutoSize = true;
            this.labelLastIPChecked.Location = new System.Drawing.Point(11, 22);
            this.labelLastIPChecked.Name = "labelLastIPChecked";
            this.labelLastIPChecked.Size = new System.Drawing.Size(91, 15);
            this.labelLastIPChecked.TabIndex = 1;
            this.labelLastIPChecked.Text = "Last checked IP:";
            // 
            // lblLastIPRange
            // 
            this.lblLastIPRange.AutoSize = true;
            this.lblLastIPRange.Location = new System.Drawing.Point(11, 43);
            this.lblLastIPRange.Name = "lblLastIPRange";
            this.lblLastIPRange.Size = new System.Drawing.Size(99, 15);
            this.lblLastIPRange.TabIndex = 0;
            this.lblLastIPRange.Text = "Current IP Range:";
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 300;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDebugMode);
            this.groupBox1.Controls.Add(this.linkGithub);
            this.groupBox1.Controls.Add(this.btnCopyFastestIP);
            this.groupBox1.Controls.Add(this.txtFastestIP);
            this.groupBox1.Controls.Add(this.lblFastestIP);
            this.groupBox1.Controls.Add(this.comboConcurrent);
            this.groupBox1.Controls.Add(this.lblConcurrent);
            this.groupBox1.Controls.Add(this.lblTotalWorkingIPs);
            this.groupBox1.Controls.Add(this.labelLastIPChecked);
            this.groupBox1.Controls.Add(this.prgOveral);
            this.groupBox1.Controls.Add(this.lblLastIPRange);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.prgCurRange);
            this.groupBox1.Controls.Add(this.btnSkipCurRange);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblDebugMode
            // 
            this.lblDebugMode.AutoSize = true;
            this.lblDebugMode.BackColor = System.Drawing.Color.White;
            this.lblDebugMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDebugMode.ForeColor = System.Drawing.Color.Red;
            this.lblDebugMode.Location = new System.Drawing.Point(272, 69);
            this.lblDebugMode.Name = "lblDebugMode";
            this.lblDebugMode.Size = new System.Drawing.Size(143, 15);
            this.lblDebugMode.TabIndex = 13;
            this.lblDebugMode.Text = "DEBUG MODE is Enabled";
            this.toolTip1.SetToolTip(this.lblDebugMode, "To exit debug mode delete \'enable-debug\' file in the app directory.\r\nIn debug mod" +
        "e you can not set concurrent processes.");
            this.lblDebugMode.Visible = false;
            // 
            // linkGithub
            // 
            this.linkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGithub.Image = global::WinCFScan.Properties.Resources.github_mark24;
            this.linkGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkGithub.Location = new System.Drawing.Point(694, 85);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(71, 23);
            this.linkGithub.TabIndex = 12;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "GitHub";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.linkGithub, "Visit us on GitHub.com");
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // btnCopyFastestIP
            // 
            this.btnCopyFastestIP.Location = new System.Drawing.Point(545, 85);
            this.btnCopyFastestIP.Name = "btnCopyFastestIP";
            this.btnCopyFastestIP.Size = new System.Drawing.Size(131, 25);
            this.btnCopyFastestIP.TabIndex = 11;
            this.btnCopyFastestIP.Text = "Copy fastest IP";
            this.btnCopyFastestIP.UseVisualStyleBackColor = true;
            this.btnCopyFastestIP.Click += new System.EventHandler(this.btnCopyFastestIP_Click);
            // 
            // txtFastestIP
            // 
            this.txtFastestIP.BackColor = System.Drawing.Color.White;
            this.txtFastestIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFastestIP.ForeColor = System.Drawing.Color.Green;
            this.txtFastestIP.Location = new System.Drawing.Point(274, 85);
            this.txtFastestIP.Name = "txtFastestIP";
            this.txtFastestIP.ReadOnly = true;
            this.txtFastestIP.Size = new System.Drawing.Size(260, 23);
            this.txtFastestIP.TabIndex = 10;
            // 
            // lblFastestIP
            // 
            this.lblFastestIP.AutoSize = true;
            this.lblFastestIP.Location = new System.Drawing.Point(11, 88);
            this.lblFastestIP.Name = "lblFastestIP";
            this.lblFastestIP.Size = new System.Drawing.Size(94, 15);
            this.lblFastestIP.TabIndex = 9;
            this.lblFastestIP.Text = "Fastest IP found:";
            // 
            // comboConcurrent
            // 
            this.comboConcurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboConcurrent.FormattingEnabled = true;
            this.comboConcurrent.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.comboConcurrent.Location = new System.Drawing.Point(621, 48);
            this.comboConcurrent.Name = "comboConcurrent";
            this.comboConcurrent.Size = new System.Drawing.Size(55, 23);
            this.comboConcurrent.TabIndex = 8;
            this.comboConcurrent.Text = "4";
            this.toolTip1.SetToolTip(this.comboConcurrent, "Number of parallel scan processes");
            this.comboConcurrent.TextChanged += new System.EventHandler(this.comboConcurrent_TextChanged);
            // 
            // lblConcurrent
            // 
            this.lblConcurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConcurrent.AutoSize = true;
            this.lblConcurrent.Location = new System.Drawing.Point(545, 52);
            this.lblConcurrent.Name = "lblConcurrent";
            this.lblConcurrent.Size = new System.Drawing.Size(70, 15);
            this.lblConcurrent.TabIndex = 7;
            this.lblConcurrent.Text = "Concurrent:";
            // 
            // lblTotalWorkingIPs
            // 
            this.lblTotalWorkingIPs.AutoSize = true;
            this.lblTotalWorkingIPs.Location = new System.Drawing.Point(11, 64);
            this.lblTotalWorkingIPs.Name = "lblTotalWorkingIPs";
            this.lblTotalWorkingIPs.Size = new System.Drawing.Size(108, 15);
            this.lblTotalWorkingIPs.TabIndex = 6;
            this.lblTotalWorkingIPs.Text = "Total working IPs: 0";
            // 
            // comboResults
            // 
            this.comboResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResults.FormattingEnabled = true;
            this.comboResults.Location = new System.Drawing.Point(128, 10);
            this.comboResults.Name = "comboResults";
            this.comboResults.Size = new System.Drawing.Size(215, 23);
            this.comboResults.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboResults, "List of last scan results");
            this.comboResults.SelectedIndexChanged += new System.EventHandler(this.comboResults_SelectedIndexChanged);
            // 
            // btnScanInPrevResults
            // 
            this.btnScanInPrevResults.Location = new System.Drawing.Point(396, 10);
            this.btnScanInPrevResults.Name = "btnScanInPrevResults";
            this.btnScanInPrevResults.Size = new System.Drawing.Size(131, 24);
            this.btnScanInPrevResults.TabIndex = 6;
            this.btnScanInPrevResults.Text = "Scan in results";
            this.toolTip1.SetToolTip(this.btnScanInPrevResults, "Scan again in this ip results");
            this.btnScanInPrevResults.UseVisualStyleBackColor = true;
            this.btnScanInPrevResults.Click += new System.EventHandler(this.btnScanInPrevResults_Click);
            // 
            // btnLoadIPRanges
            // 
            this.btnLoadIPRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadIPRanges.Location = new System.Drawing.Point(481, 8);
            this.btnLoadIPRanges.Name = "btnLoadIPRanges";
            this.btnLoadIPRanges.Size = new System.Drawing.Size(94, 23);
            this.btnLoadIPRanges.TabIndex = 4;
            this.btnLoadIPRanges.Text = "Load IP ranges";
            this.toolTip1.SetToolTip(this.btnLoadIPRanges, "Load your custom IP ranges");
            this.btnLoadIPRanges.UseVisualStyleBackColor = true;
            this.btnLoadIPRanges.Click += new System.EventHandler(this.btnLoadIPRanges_Click);
            // 
            // listResults
            // 
            this.listResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrDelay,
            this.hdrIP});
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.Location = new System.Drawing.Point(0, 40);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(772, 188);
            this.listResults.TabIndex = 4;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            this.listResults.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listResults_ColumnClick);
            this.listResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listResults_MouseClick);
            this.listResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listResults_MouseDoubleClick);
            // 
            // hdrDelay
            // 
            this.hdrDelay.Text = "Delay";
            this.hdrDelay.Width = 90;
            // 
            // hdrIP
            // 
            this.hdrIP.Text = "IP Address";
            this.hdrIP.Width = 160;
            // 
            // mnuListView
            // 
            this.mnuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListViewCopyIP,
            this.mnuListViewTestThisIPAddress});
            this.mnuListView.Name = "mnuListView";
            this.mnuListView.Size = new System.Drawing.Size(173, 48);
            // 
            // mnuListViewCopyIP
            // 
            this.mnuListViewCopyIP.Name = "mnuListViewCopyIP";
            this.mnuListViewCopyIP.Size = new System.Drawing.Size(172, 22);
            this.mnuListViewCopyIP.Text = "Copy IP address";
            this.mnuListViewCopyIP.Click += new System.EventHandler(this.mnuListViewCopyIP_Click);
            // 
            // mnuListViewTestThisIPAddress
            // 
            this.mnuListViewTestThisIPAddress.Name = "mnuListViewTestThisIPAddress";
            this.mnuListViewTestThisIPAddress.Size = new System.Drawing.Size(172, 22);
            this.mnuListViewTestThisIPAddress.Text = "Test this IP address";
            this.mnuListViewTestThisIPAddress.Click += new System.EventHandler(this.mnuListViewTestThisIPAddress_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 146);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(780, 445);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCFRanges);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 256);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageCFRanges
            // 
            this.tabPageCFRanges.Controls.Add(this.btnLoadIPRanges);
            this.tabPageCFRanges.Controls.Add(this.lblCFIPListStatus);
            this.tabPageCFRanges.Controls.Add(this.btnSelectNoneIPRanges);
            this.tabPageCFRanges.Controls.Add(this.btnSelectAllIPRanges);
            this.tabPageCFRanges.Controls.Add(this.listCFIPList);
            this.tabPageCFRanges.Location = new System.Drawing.Point(4, 24);
            this.tabPageCFRanges.Name = "tabPageCFRanges";
            this.tabPageCFRanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCFRanges.Size = new System.Drawing.Size(772, 228);
            this.tabPageCFRanges.TabIndex = 1;
            this.tabPageCFRanges.Text = "Cloudflare IP ranges";
            this.tabPageCFRanges.UseVisualStyleBackColor = true;
            // 
            // lblCFIPListStatus
            // 
            this.lblCFIPListStatus.AutoSize = true;
            this.lblCFIPListStatus.Location = new System.Drawing.Point(6, 12);
            this.lblCFIPListStatus.Name = "lblCFIPListStatus";
            this.lblCFIPListStatus.Size = new System.Drawing.Size(110, 15);
            this.lblCFIPListStatus.TabIndex = 3;
            this.lblCFIPListStatus.Text = "Loading IP ranges...";
            // 
            // btnSelectNoneIPRanges
            // 
            this.btnSelectNoneIPRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNoneIPRanges.Location = new System.Drawing.Point(581, 9);
            this.btnSelectNoneIPRanges.Name = "btnSelectNoneIPRanges";
            this.btnSelectNoneIPRanges.Size = new System.Drawing.Size(88, 23);
            this.btnSelectNoneIPRanges.TabIndex = 2;
            this.btnSelectNoneIPRanges.Text = "Select None";
            this.btnSelectNoneIPRanges.UseVisualStyleBackColor = true;
            this.btnSelectNoneIPRanges.Click += new System.EventHandler(this.btnSelectNoneIPRanges_Click);
            // 
            // btnSelectAllIPRanges
            // 
            this.btnSelectAllIPRanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAllIPRanges.Location = new System.Drawing.Point(678, 9);
            this.btnSelectAllIPRanges.Name = "btnSelectAllIPRanges";
            this.btnSelectAllIPRanges.Size = new System.Drawing.Size(88, 23);
            this.btnSelectAllIPRanges.TabIndex = 1;
            this.btnSelectAllIPRanges.Text = "Select All";
            this.btnSelectAllIPRanges.UseVisualStyleBackColor = true;
            this.btnSelectAllIPRanges.Click += new System.EventHandler(this.btnSelectAllIPRanges_Click);
            // 
            // listCFIPList
            // 
            this.listCFIPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCFIPList.CheckBoxes = true;
            this.listCFIPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headIPRange,
            this.headTotalIPs});
            this.listCFIPList.Location = new System.Drawing.Point(0, 38);
            this.listCFIPList.Name = "listCFIPList";
            this.listCFIPList.Size = new System.Drawing.Size(772, 190);
            this.listCFIPList.TabIndex = 0;
            this.listCFIPList.UseCompatibleStateImageBehavior = false;
            this.listCFIPList.View = System.Windows.Forms.View.Details;
            this.listCFIPList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listCFIPList_ColumnClick);
            this.listCFIPList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listCFIPList_ItemChecked);
            // 
            // headIPRange
            // 
            this.headIPRange.Text = "IP Range";
            this.headIPRange.Width = 120;
            // 
            // headTotalIPs
            // 
            this.headTotalIPs.Text = "Total IPs";
            this.headTotalIPs.Width = 90;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.lblPrevListTotalIPs);
            this.tabPageResults.Controls.Add(this.lblPrevResults);
            this.tabPageResults.Controls.Add(this.btnResultsActions);
            this.tabPageResults.Controls.Add(this.comboResults);
            this.tabPageResults.Controls.Add(this.btnScanInPrevResults);
            this.tabPageResults.Controls.Add(this.listResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 24);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(772, 228);
            this.tabPageResults.TabIndex = 0;
            this.tabPageResults.Text = "Scan Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // lblPrevListTotalIPs
            // 
            this.lblPrevListTotalIPs.Location = new System.Drawing.Point(343, 14);
            this.lblPrevListTotalIPs.Name = "lblPrevListTotalIPs";
            this.lblPrevListTotalIPs.Size = new System.Drawing.Size(53, 19);
            this.lblPrevListTotalIPs.TabIndex = 9;
            this.lblPrevListTotalIPs.Text = "0 IPs";
            this.lblPrevListTotalIPs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrevResults
            // 
            this.lblPrevResults.AutoSize = true;
            this.lblPrevResults.Location = new System.Drawing.Point(6, 13);
            this.lblPrevResults.Name = "lblPrevResults";
            this.lblPrevResults.Size = new System.Drawing.Size(119, 15);
            this.lblPrevResults.TabIndex = 7;
            this.lblPrevResults.Text = "Previous scan results:";
            // 
            // btnResultsActions
            // 
            this.btnResultsActions.Location = new System.Drawing.Point(538, 11);
            this.btnResultsActions.Name = "btnResultsActions";
            this.btnResultsActions.Size = new System.Drawing.Size(131, 23);
            this.btnResultsActions.TabIndex = 8;
            this.btnResultsActions.Text = "Actions";
            this.btnResultsActions.UseVisualStyleBackColor = true;
            this.btnResultsActions.Click += new System.EventHandler(this.btnResultsActions_Click);
            this.btnResultsActions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnResultsActions_MouseClick);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(804, 24);
            this.mnuMain.TabIndex = 8;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCustomIPRangesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importScanResultsToolStripMenuItem,
            this.exportScanResultsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCustomIPRangesToolStripMenuItem
            // 
            this.loadCustomIPRangesToolStripMenuItem.Name = "loadCustomIPRangesToolStripMenuItem";
            this.loadCustomIPRangesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.loadCustomIPRangesToolStripMenuItem.Text = "Load custom IP ranges";
            this.loadCustomIPRangesToolStripMenuItem.Click += new System.EventHandler(this.loadCustomIPRangesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // importScanResultsToolStripMenuItem
            // 
            this.importScanResultsToolStripMenuItem.Name = "importScanResultsToolStripMenuItem";
            this.importScanResultsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importScanResultsToolStripMenuItem.Text = "Import scan results";
            this.importScanResultsToolStripMenuItem.Click += new System.EventHandler(this.importScanResultsToolStripMenuItem_Click);
            // 
            // exportScanResultsToolStripMenuItem
            // 
            this.exportScanResultsToolStripMenuItem.Name = "exportScanResultsToolStripMenuItem";
            this.exportScanResultsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportScanResultsToolStripMenuItem.Text = "Export scan results";
            this.exportScanResultsToolStripMenuItem.Click += new System.EventHandler(this.exportScanResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanASingleIPAddressToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // scanASingleIPAddressToolStripMenuItem
            // 
            this.scanASingleIPAddressToolStripMenuItem.Name = "scanASingleIPAddressToolStripMenuItem";
            this.scanASingleIPAddressToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.scanASingleIPAddressToolStripMenuItem.Text = "Test a single IP address";
            this.scanASingleIPAddressToolStripMenuItem.Click += new System.EventHandler(this.scanASingleIPAddressToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // mnuResultsActions
            // 
            this.mnuResultsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportResultsToolStripMenuItem,
            this.importResultsToolStripMenuItem,
            this.deleteResultsToolStripMenuItem});
            this.mnuResultsActions.Name = "mnuResultsActions";
            this.mnuResultsActions.Size = new System.Drawing.Size(148, 70);
            this.mnuResultsActions.Text = "Actions";
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportResultsToolStripMenuItem.Text = "Export results";
            this.exportResultsToolStripMenuItem.Click += new System.EventHandler(this.exportResultsToolStripMenuItem_Click);
            // 
            // importResultsToolStripMenuItem
            // 
            this.importResultsToolStripMenuItem.Name = "importResultsToolStripMenuItem";
            this.importResultsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.importResultsToolStripMenuItem.Text = "Import results";
            this.importResultsToolStripMenuItem.Click += new System.EventHandler(this.importResultsToolStripMenuItem_Click);
            // 
            // deleteResultsToolStripMenuItem
            // 
            this.deleteResultsToolStripMenuItem.Name = "deleteResultsToolStripMenuItem";
            this.deleteResultsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteResultsToolStripMenuItem.Text = "Delete results";
            this.deleteResultsToolStripMenuItem.Click += new System.EventHandler(this.deleteResultsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 599);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(820, 480);
            this.Name = "frmMain";
            this.Text = "Cloudflare Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuListView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCFRanges.ResumeLayout(false);
            this.tabPageCFRanges.PerformLayout();
            this.tabPageResults.ResumeLayout(false);
            this.tabPageResults.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuResultsActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private TextBox txtLog;
        private System.Windows.Forms.Timer timerBase;
        private Label lblLastIPRange;
        private System.Windows.Forms.Timer timerProgress;
        private Label labelLastIPChecked;
        private Button btnSkipCurRange;
        private ProgressBar prgOveral;
        private ProgressBar prgCurRange;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private ListView listResults;
        private ColumnHeader hdrDelay;
        private ColumnHeader hdrIP;
        private ComboBox comboResults;
        private Label lblTotalWorkingIPs;
        private Button btnScanInPrevResults;
        private SplitContainer splitContainer1;
        private Label lblPrevResults;
        private ComboBox comboConcurrent;
        private Label lblConcurrent;
        private Button btnResultsActions;
        private TextBox txtFastestIP;
        private Label lblFastestIP;
        private Button btnCopyFastestIP;
        private ContextMenuStrip mnuListView;
        private ToolStripMenuItem mnuListViewCopyIP;
        private ToolStripMenuItem mnuListViewTestThisIPAddress;
        private TabControl tabControl1;
        private TabPage tabPageResults;
        private TabPage tabPageCFRanges;
        private ListView listCFIPList;
        private ColumnHeader headIPRange;
        private ColumnHeader headTotalIPs;
        private Button btnSelectNoneIPRanges;
        private Button btnSelectAllIPRanges;
        private Label lblCFIPListStatus;
        private Label lblPrevListTotalIPs;
        private LinkLabel linkGithub;
        private MenuStrip mnuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem scanASingleIPAddressToolStripMenuItem;
        private Label lblDebugMode;
        private Button btnLoadIPRanges;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem loadCustomIPRangesToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem exportScanResultsToolStripMenuItem;
        private ContextMenuStrip mnuResultsActions;
        private ToolStripMenuItem exportResultsToolStripMenuItem;
        private ToolStripMenuItem importResultsToolStripMenuItem;
        private ToolStripMenuItem deleteResultsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem importScanResultsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
    }
}