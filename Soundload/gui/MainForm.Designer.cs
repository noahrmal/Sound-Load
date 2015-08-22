
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_sstMain = new System.Windows.Forms.StatusStrip();
            this.m_tslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_pnlContent = new System.Windows.Forms.Panel();
            this.txtBxUrl = new SoundCloudDownloader.PlaceholderTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkBxSelectAll = new System.Windows.Forms.CheckBox();
            this.m_lbxEntries = new System.Windows.Forms.CheckedListBox();
            this.m_btnDownloadSelected = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.m_sstMain.SuspendLayout();
            this.m_pnlContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_sstMain
            // 
            this.m_sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tslInfo});
            this.m_sstMain.Location = new System.Drawing.Point(0, 420);
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
            this.m_pnlContent.Controls.Add(this.txtBxUrl);
            this.m_pnlContent.Controls.Add(this.tabControl1);
            this.m_pnlContent.Controls.Add(this.label1);
            this.m_pnlContent.Controls.Add(this.progressBar1);
            this.m_pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnlContent.Location = new System.Drawing.Point(0, 0);
            this.m_pnlContent.Name = "m_pnlContent";
            this.m_pnlContent.Size = new System.Drawing.Size(624, 420);
            this.m_pnlContent.TabIndex = 13;
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.Location = new System.Drawing.Point(24, 12);
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.Placeholder = "Put your Soundcloud playlist or track link here!";
            this.txtBxUrl.Size = new System.Drawing.Size(571, 20);
            this.txtBxUrl.TabIndex = 15;
            this.txtBxUrl.TextChanged += new System.EventHandler(this.m_tbxPage_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 290);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.chkBxSelectAll);
            this.tabPage1.Controls.Add(this.m_lbxEntries);
            this.tabPage1.Controls.Add(this.m_btnDownloadSelected);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Downloader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(354, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkBxSelectAll
            // 
            this.chkBxSelectAll.AutoSize = true;
            this.chkBxSelectAll.Location = new System.Drawing.Point(15, 239);
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
            this.m_lbxEntries.Location = new System.Drawing.Point(15, 15);
            this.m_lbxEntries.Name = "m_lbxEntries";
            this.m_lbxEntries.Size = new System.Drawing.Size(536, 214);
            this.m_lbxEntries.TabIndex = 7;
            // 
            // m_btnDownloadSelected
            // 
            this.m_btnDownloadSelected.Location = new System.Drawing.Point(459, 235);
            this.m_btnDownloadSelected.Name = "m_btnDownloadSelected";
            this.m_btnDownloadSelected.Size = new System.Drawing.Size(92, 23);
            this.m_btnDownloadSelected.TabIndex = 9;
            this.m_btnDownloadSelected.Text = "Download";
            this.m_btnDownloadSelected.UseVisualStyleBackColor = true;
            this.m_btnDownloadSelected.Click += new System.EventHandler(this.btnDownloadSelectedClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 264);
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
            this.tabPage3.Size = new System.Drawing.Size(567, 264);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = " ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.m_pnlContent);
            this.Controls.Add(this.m_sstMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound-Load";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.m_sstMain.ResumeLayout(false);
            this.m_sstMain.PerformLayout();
            this.m_pnlContent.ResumeLayout(false);
            this.m_pnlContent.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.StatusStrip m_sstMain;
        private System.Windows.Forms.ToolStripStatusLabel m_tslInfo;
        private System.Windows.Forms.Button m_btnDownloadSelected;
        private System.Windows.Forms.Panel m_pnlContent;
        private System.Windows.Forms.CheckedListBox m_lbxEntries;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxPath;
        private System.Windows.Forms.CheckBox chkBxDownloadPath;
        private System.Windows.Forms.Button btnClear;
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
    }
}
