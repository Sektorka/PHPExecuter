namespace php
{
    partial class RunPhpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunPhpForm));
            this.lblphpwarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPHPFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPHPArgs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblphpwarning
            // 
            this.lblphpwarning.AutoSize = true;
            this.lblphpwarning.Font = new System.Drawing.Font("Arial", 24.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblphpwarning.Location = new System.Drawing.Point(168, 13);
            this.lblphpwarning.Name = "lblphpwarning";
            this.lblphpwarning.Size = new System.Drawing.Size(375, 38);
            this.lblphpwarning.TabIndex = 2;
            this.lblphpwarning.Text = "PHP Exection warning!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::php.Properties.Resources.alert;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHP file:";
            // 
            // lblPHPFile
            // 
            this.lblPHPFile.AutoSize = true;
            this.lblPHPFile.Location = new System.Drawing.Point(236, 55);
            this.lblPHPFile.Name = "lblPHPFile";
            this.lblPHPFile.Size = new System.Drawing.Size(16, 13);
            this.lblPHPFile.TabIndex = 5;
            this.lblPHPFile.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PHP args:";
            // 
            // lblPHPArgs
            // 
            this.lblPHPArgs.AutoSize = true;
            this.lblPHPArgs.Location = new System.Drawing.Point(236, 68);
            this.lblPHPArgs.Name = "lblPHPArgs";
            this.lblPHPArgs.Size = new System.Drawing.Size(16, 13);
            this.lblPHPArgs.TabIndex = 7;
            this.lblPHPArgs.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(171, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Execution will start in:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSeconds.ForeColor = System.Drawing.Color.Red;
            this.lblSeconds.Location = new System.Drawing.Point(351, 107);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(18, 19);
            this.lblSeconds.TabIndex = 9;
            this.lblSeconds.Text = "3";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(398, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel execution";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RunPhpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPHPArgs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPHPFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblphpwarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunPhpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP Execution warning!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblphpwarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPHPFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPHPArgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer;
    }
}