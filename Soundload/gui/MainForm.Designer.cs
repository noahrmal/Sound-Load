
namespace SoundCloudDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_sstMain = new System.Windows.Forms.StatusStrip();
            this.m_tslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_pnlContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.comboBxSavePlaylists = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.labelCurrentTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelTotalTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chkBxKeepTracks = new System.Windows.Forms.CheckBox();
            this.lablTrackPosition = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lablTitle = new System.Windows.Forms.Label();
            this.chkBxSelectAll = new System.Windows.Forms.CheckBox();
            this.m_lbxEntries = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBxSkip = new System.Windows.Forms.CheckBox();
            this.chkBxImageTags = new System.Windows.Forms.CheckBox();
            this.chkBxArtistTag = new System.Windows.Forms.CheckBox();
            this.chkBxOpenFolder = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lablDefaultPath = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtBxPath = new System.Windows.Forms.TextBox();
            this.chkBxDownloadPath = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbxErrorLog = new System.Windows.Forms.ListBox();
            this.lablDownloadedBytes = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnVolume = new System.Windows.Forms.ToolStripButton();
            this.btnRandomTrack = new System.Windows.Forms.ToolStripButton();
            this.btnLoop = new System.Windows.Forms.ToolStripButton();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.txtBxUrl = new SoundCloudDownloader.PlaceholderTextBox();
            this.m_sstMain.SuspendLayout();
            this.m_pnlContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_sstMain
            // 
            this.m_sstMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.m_sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tslInfo});
            this.m_sstMain.Location = new System.Drawing.Point(0, 462);
            this.m_sstMain.Name = "m_sstMain";
            this.m_sstMain.Size = new System.Drawing.Size(624, 22);
            this.m_sstMain.TabIndex = 12;
            this.m_sstMain.Text = "statusStrip1";
            // 
            // m_tslInfo
            // 
            this.m_tslInfo.Name = "m_tslInfo";
            this.m_tslInfo.Size = new System.Drawing.Size(609, 17);
            this.m_tslInfo.Spring = true;
            // 
            // m_pnlContent
            // 
            this.m_pnlContent.Controls.Add(this.btnSearch);
            this.m_pnlContent.Controls.Add(this.txtBxUrl);
            this.m_pnlContent.Controls.Add(this.tabControl1);
            this.m_pnlContent.Controls.Add(this.lablDownloadedBytes);
            this.m_pnlContent.Controls.Add(this.progressBar1);
            this.m_pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnlContent.Location = new System.Drawing.Point(0, 0);
            this.m_pnlContent.Name = "m_pnlContent";
            this.m_pnlContent.Size = new System.Drawing.Size(624, 462);
            this.m_pnlContent.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 355);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.chkBxKeepTracks);
            this.tabPage1.Controls.Add(this.lablTrackPosition);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.lablTitle);
            this.tabPage1.Controls.Add(this.chkBxSelectAll);
            this.tabPage1.Controls.Add(this.m_lbxEntries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Downloader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBxSavePlaylists,
            this.btnOpen,
            this.btnSave});
            this.toolStrip3.Location = new System.Drawing.Point(370, 13);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(181, 25);
            this.toolStrip3.TabIndex = 29;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // comboBxSavePlaylists
            // 
            this.comboBxSavePlaylists.BackColor = System.Drawing.Color.White;
            this.comboBxSavePlaylists.Name = "comboBxSavePlaylists";
            this.comboBxSavePlaylists.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCurrentTime,
            this.toolStripLabel1,
            this.labelTotalTime,
            this.btnVolume,
            this.btnRandomTrack,
            this.btnLoop,
            this.btnDownload});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(376, 300);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(206, 25);
            this.toolStrip2.TabIndex = 28;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(34, 22);
            this.labelCurrentTime.Text = "00:00";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel1.Text = "/";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(34, 22);
            this.labelTotalTime.Text = "00:00";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnPlay,
            this.btnForward,
            this.btnStop});
            this.toolStrip1.Location = new System.Drawing.Point(12, 300);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip";
            // 
            // chkBxKeepTracks
            // 
            this.chkBxKeepTracks.AutoSize = true;
            this.chkBxKeepTracks.Location = new System.Drawing.Point(122, 271);
            this.chkBxKeepTracks.Name = "chkBxKeepTracks";
            this.chkBxKeepTracks.Size = new System.Drawing.Size(109, 17);
            this.chkBxKeepTracks.TabIndex = 26;
            this.chkBxKeepTracks.Text = "Keep tracks in list";
            this.chkBxKeepTracks.UseVisualStyleBackColor = true;
            // 
            // lablTrackPosition
            // 
            this.lablTrackPosition.AutoSize = true;
            this.lablTrackPosition.Location = new System.Drawing.Point(183, 300);
            this.lablTrackPosition.Name = "lablTrackPosition";
            this.lablTrackPosition.Size = new System.Drawing.Size(0, 13);
            this.lablTrackPosition.TabIndex = 22;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Location = new System.Drawing.Point(122, 301);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(251, 25);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.Location = new System.Drawing.Point(12, 17);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(0, 13);
            this.lablTitle.TabIndex = 10;
            // 
            // chkBxSelectAll
            // 
            this.chkBxSelectAll.AutoSize = true;
            this.chkBxSelectAll.Location = new System.Drawing.Point(15, 271);
            this.chkBxSelectAll.Name = "chkBxSelectAll";
            this.chkBxSelectAll.Size = new System.Drawing.Size(68, 17);
            this.chkBxSelectAll.TabIndex = 8;
            this.chkBxSelectAll.Text = "Select Al";
            this.chkBxSelectAll.UseVisualStyleBackColor = true;
            this.chkBxSelectAll.CheckedChanged += new System.EventHandler(this.chkBxSelectAll_CheckedChanged);
            // 
            // m_lbxEntries
            // 
            this.m_lbxEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lbxEntries.FormattingEnabled = true;
            this.m_lbxEntries.Location = new System.Drawing.Point(15, 41);
            this.m_lbxEntries.Name = "m_lbxEntries";
            this.m_lbxEntries.Size = new System.Drawing.Size(536, 199);
            this.m_lbxEntries.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBxSkip);
            this.groupBox2.Controls.Add(this.chkBxImageTags);
            this.groupBox2.Controls.Add(this.chkBxArtistTag);
            this.groupBox2.Controls.Add(this.chkBxOpenFolder);
            this.groupBox2.Location = new System.Drawing.Point(25, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkBxSkip
            // 
            this.chkBxSkip.AutoSize = true;
            this.chkBxSkip.Location = new System.Drawing.Point(145, 57);
            this.chkBxSkip.Name = "chkBxSkip";
            this.chkBxSkip.Size = new System.Drawing.Size(105, 17);
            this.chkBxSkip.TabIndex = 3;
            this.chkBxSkip.Text = "Skip when exists";
            this.chkBxSkip.UseVisualStyleBackColor = true;
            // 
            // chkBxImageTags
            // 
            this.chkBxImageTags.AutoSize = true;
            this.chkBxImageTags.Location = new System.Drawing.Point(16, 57);
            this.chkBxImageTags.Name = "chkBxImageTags";
            this.chkBxImageTags.Size = new System.Drawing.Size(101, 17);
            this.chkBxImageTags.TabIndex = 2;
            this.chkBxImageTags.Text = "Set Image Tags";
            this.chkBxImageTags.UseVisualStyleBackColor = true;
            // 
            // chkBxArtistTag
            // 
            this.chkBxArtistTag.AutoSize = true;
            this.chkBxArtistTag.Location = new System.Drawing.Point(16, 19);
            this.chkBxArtistTag.Name = "chkBxArtistTag";
            this.chkBxArtistTag.Size = new System.Drawing.Size(95, 17);
            this.chkBxArtistTag.TabIndex = 1;
            this.chkBxArtistTag.Text = "Set Artist Tags";
            this.chkBxArtistTag.UseVisualStyleBackColor = true;
            // 
            // chkBxOpenFolder
            // 
            this.chkBxOpenFolder.AutoSize = true;
            this.chkBxOpenFolder.Location = new System.Drawing.Point(145, 19);
            this.chkBxOpenFolder.Name = "chkBxOpenFolder";
            this.chkBxOpenFolder.Size = new System.Drawing.Size(203, 17);
            this.chkBxOpenFolder.TabIndex = 0;
            this.chkBxOpenFolder.Text = "Open Download-Folder when finished";
            this.chkBxOpenFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lablDefaultPath);
            this.groupBox1.Controls.Add(this.btnChoosePath);
            this.groupBox1.Controls.Add(this.txtBxPath);
            this.groupBox1.Controls.Add(this.chkBxDownloadPath);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lablDefaultPath
            // 
            this.lablDefaultPath.AutoSize = true;
            this.lablDefaultPath.Location = new System.Drawing.Point(13, 83);
            this.lablDefaultPath.Name = "lablDefaultPath";
            this.lablDefaultPath.Size = new System.Drawing.Size(175, 13);
            this.lablDefaultPath.TabIndex = 3;
            this.lablDefaultPath.Text = "Default Path: User Libraries / Music";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Enabled = false;
            this.btnChoosePath.Location = new System.Drawing.Point(270, 39);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(78, 23);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "Choose";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtBxPath
            // 
            this.txtBxPath.Enabled = false;
            this.txtBxPath.Location = new System.Drawing.Point(16, 42);
            this.txtBxPath.Name = "txtBxPath";
            this.txtBxPath.Size = new System.Drawing.Size(235, 20);
            this.txtBxPath.TabIndex = 1;
            // 
            // chkBxDownloadPath
            // 
            this.chkBxDownloadPath.AutoSize = true;
            this.chkBxDownloadPath.Location = new System.Drawing.Point(16, 19);
            this.chkBxDownloadPath.Name = "chkBxDownloadPath";
            this.chkBxDownloadPath.Size = new System.Drawing.Size(118, 17);
            this.chkBxDownloadPath.TabIndex = 0;
            this.chkBxDownloadPath.Text = "Set Download Path";
            this.chkBxDownloadPath.UseVisualStyleBackColor = true;
            this.chkBxDownloadPath.CheckedChanged += new System.EventHandler(this.chkBxDownloadPath_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbxErrorLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(567, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Error Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbxErrorLog
            // 
            this.lbxErrorLog.FormattingEnabled = true;
            this.lbxErrorLog.Location = new System.Drawing.Point(15, 14);
            this.lbxErrorLog.Name = "lbxErrorLog";
            this.lbxErrorLog.Size = new System.Drawing.Size(537, 212);
            this.lbxErrorLog.TabIndex = 0;
            // 
            // lablDownloadedBytes
            // 
            this.lablDownloadedBytes.AutoSize = true;
            this.lablDownloadedBytes.Location = new System.Drawing.Point(256, 437);
            this.lablDownloadedBytes.Name = "lablDownloadedBytes";
            this.lablDownloadedBytes.Size = new System.Drawing.Size(10, 13);
            this.lablDownloadedBytes.TabIndex = 13;
            this.lablDownloadedBytes.Text = " ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(624, 459);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 484);
            this.toolStripContainer1.TabIndex = 23;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::SoundCloudDownloader.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(562, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 22);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Open List";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save List";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVolume.Image = global::SoundCloudDownloader.Properties.Resources.Volume;
            this.btnVolume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(23, 22);
            this.btnVolume.Text = "Volume";
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnRandomTrack
            // 
            this.btnRandomTrack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRandomTrack.Image = global::SoundCloudDownloader.Properties.Resources.Random;
            this.btnRandomTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRandomTrack.Name = "btnRandomTrack";
            this.btnRandomTrack.Size = new System.Drawing.Size(23, 22);
            this.btnRandomTrack.Text = "Play Random Tracks";
            this.btnRandomTrack.Click += new System.EventHandler(this.btnRandomTrack_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoop.Image = ((System.Drawing.Image)(resources.GetObject("btnLoop.Image")));
            this.btnLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(23, 22);
            this.btnLoop.Text = "Repeat Track";
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDownload.Image = global::SoundCloudDownloader.Properties.Resources.Download;
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(23, 22);
            this.btnDownload.Text = "Download all selected Tracks";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::SoundCloudDownloader.Properties.Resources.Back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Open File";
            this.btnBack.ToolTipText = "Back";
            this.btnBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = global::SoundCloudDownloader.Properties.Resources.Play;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "Play";
            this.btnPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = global::SoundCloudDownloader.Properties.Resources.Forward;
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.Text = "toolStripButton2";
            this.btnForward.ToolTipText = "Forward";
            this.btnForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::SoundCloudDownloader.Properties.Resources.Stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.Location = new System.Drawing.Point(24, 12);
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.Placeholder = "Put your Soundcloud playlist or track link here!";
            this.txtBxUrl.Size = new System.Drawing.Size(513, 20);
            this.txtBxUrl.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 484);
            this.Controls.Add(this.m_pnlContent);
            this.Controls.Add(this.m_sstMain);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(636, 467);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soundload";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.m_sstMain.ResumeLayout(false);
            this.m_sstMain.PerformLayout();
            this.m_pnlContent.ResumeLayout(false);
            this.m_pnlContent.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.StatusStrip m_sstMain;
        private System.Windows.Forms.ToolStripStatusLabel m_tslInfo;
        private System.Windows.Forms.Panel m_pnlContent;
        private System.Windows.Forms.CheckedListBox m_lbxEntries;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lablDownloadedBytes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxPath;
        private System.Windows.Forms.CheckBox chkBxDownloadPath;
        private System.Windows.Forms.CheckBox chkBxSelectAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBxImageTags;
        private System.Windows.Forms.CheckBox chkBxArtistTag;
        private System.Windows.Forms.CheckBox chkBxOpenFolder;
        private System.Windows.Forms.Label lablDefaultPath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.CheckBox chkBxSkip;
        private PlaceholderTextBox txtBxUrl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbxErrorLog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lablTitle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lablTrackPosition;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.CheckBox chkBxKeepTracks;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripComboBox comboBxSavePlaylists;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel labelCurrentTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel labelTotalTime;
        private System.Windows.Forms.ToolStripButton btnVolume;
        private System.Windows.Forms.ToolStripButton btnRandomTrack;
        private System.Windows.Forms.ToolStripButton btnLoop;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnDownload;
    }
}
