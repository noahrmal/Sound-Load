namespace SoundCloudDownloader
{
    partial class VolumeControl
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
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnMuteUnmute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(12, 12);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 186);
            this.tbVolume.TabIndex = 4;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // btnMuteUnmute
            // 
            this.btnMuteUnmute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMuteUnmute.Image = global::SoundCloudDownloader.Properties.Resources.Volume;
            this.btnMuteUnmute.Location = new System.Drawing.Point(8, 203);
            this.btnMuteUnmute.Name = "btnMuteUnmute";
            this.btnMuteUnmute.Size = new System.Drawing.Size(28, 28);
            this.btnMuteUnmute.TabIndex = 5;
            this.btnMuteUnmute.UseVisualStyleBackColor = true;
            this.btnMuteUnmute.Click += new System.EventHandler(this.btnMuteUnmute_Click);
            // 
            // VolumeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(48, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnMuteUnmute);
            this.Controls.Add(this.tbVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VolumeControl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Deactivate += new System.EventHandler(this.VolumeControl_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnMuteUnmute;
    }
}