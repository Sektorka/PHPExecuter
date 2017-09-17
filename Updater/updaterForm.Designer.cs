namespace Updater
{
    partial class updaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updaterForm));
            this.lblStatus = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.progressTotal = new Win7Progress.Windows7ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Downloading file:";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(16, 57);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(376, 23);
            this.progress.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: 0%";
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.AutoSize = true;
            this.lblDownloaded.Location = new System.Drawing.Point(13, 38);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(50, 13);
            this.lblDownloaded.TabIndex = 5;
            this.lblDownloaded.Text = "0 B / 0 B";
            // 
            // progressTotal
            // 
            this.progressTotal.ContainerControl = this;
            this.progressTotal.Location = new System.Drawing.Point(16, 115);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.ShowInTaskbar = true;
            this.progressTotal.Size = new System.Drawing.Size(376, 23);
            this.progressTotal.Step = 1;
            this.progressTotal.TabIndex = 4;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(97, 13);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(10, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "-";
            // 
            // updaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 150);
            this.Controls.Add(this.lblDownloaded);
            this.Controls.Add(this.progressTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "updaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Updater :: by Sektor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updaterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lblTotal;
        private Win7Progress.Windows7ProgressBar progressTotal;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label lblFile;
    }
}