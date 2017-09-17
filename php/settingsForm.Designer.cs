namespace php
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.chbShowPopupDialog = new System.Windows.Forms.CheckBox();
            this.chbCheckUpdatesAtStartUp = new System.Windows.Forms.CheckBox();
            this.nudWarningLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSep = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.lblday = new System.Windows.Forms.Label();
            this.lblMaxRuntime = new System.Windows.Forms.Label();
            this.chbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.chbSavePHP = new System.Windows.Forms.CheckBox();
            this.chbRunAtstartup = new System.Windows.Forms.CheckBox();
            this.chbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbTSF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbTimeStamp = new System.Windows.Forms.CheckBox();
            this.maxChar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateInterval = new System.Windows.Forms.NumericUpDown();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.nudSplit = new System.Windows.Forms.NumericUpDown();
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.chbSplit = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.chbSaveRes = new System.Windows.Forms.CheckBox();
            this.chbPrintRes = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabResult);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(508, 209);
            this.tabControl.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.chbShowPopupDialog);
            this.tabResult.Controls.Add(this.chbCheckUpdatesAtStartUp);
            this.tabResult.Controls.Add(this.nudWarningLength);
            this.tabResult.Controls.Add(this.label3);
            this.tabResult.Controls.Add(this.label2);
            this.tabResult.Controls.Add(this.labSep);
            this.tabResult.Controls.Add(this.nudSecond);
            this.tabResult.Controls.Add(this.nudMinute);
            this.tabResult.Controls.Add(this.nudHour);
            this.tabResult.Controls.Add(this.nudDay);
            this.tabResult.Controls.Add(this.lblday);
            this.tabResult.Controls.Add(this.lblMaxRuntime);
            this.tabResult.Controls.Add(this.chbRunOnStartup);
            this.tabResult.Controls.Add(this.chbSavePHP);
            this.tabResult.Controls.Add(this.chbRunAtstartup);
            this.tabResult.Controls.Add(this.chbMinimizeToTray);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(500, 183);
            this.tabResult.TabIndex = 0;
            this.tabResult.Text = "General settings";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // chbShowPopupDialog
            // 
            this.chbShowPopupDialog.AutoSize = true;
            this.chbShowPopupDialog.Location = new System.Drawing.Point(6, 96);
            this.chbShowPopupDialog.Name = "chbShowPopupDialog";
            this.chbShowPopupDialog.Size = new System.Drawing.Size(159, 17);
            this.chbShowPopupDialog.TabIndex = 37;
            this.chbShowPopupDialog.Text = "Popup at the end of php run";
            this.chbShowPopupDialog.UseVisualStyleBackColor = true;
            // 
            // chbCheckUpdatesAtStartUp
            // 
            this.chbCheckUpdatesAtStartUp.AutoSize = true;
            this.chbCheckUpdatesAtStartUp.Location = new System.Drawing.Point(6, 75);
            this.chbCheckUpdatesAtStartUp.Name = "chbCheckUpdatesAtStartUp";
            this.chbCheckUpdatesAtStartUp.Size = new System.Drawing.Size(145, 17);
            this.chbCheckUpdatesAtStartUp.TabIndex = 36;
            this.chbCheckUpdatesAtStartUp.Text = "Check updates at startup";
            this.chbCheckUpdatesAtStartUp.UseVisualStyleBackColor = true;
            // 
            // nudWarningLength
            // 
            this.nudWarningLength.Enabled = false;
            this.nudWarningLength.Location = new System.Drawing.Point(322, 118);
            this.nudWarningLength.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudWarningLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWarningLength.Name = "nudWarningLength";
            this.nudWarningLength.Size = new System.Drawing.Size(35, 20);
            this.nudWarningLength.TabIndex = 34;
            this.nudWarningLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "PHP Execution warning length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(300, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = " : ";
            // 
            // labSep
            // 
            this.labSep.AutoSize = true;
            this.labSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSep.Location = new System.Drawing.Point(237, 143);
            this.labSep.Name = "labSep";
            this.labSep.Size = new System.Drawing.Size(19, 13);
            this.labSep.TabIndex = 31;
            this.labSep.Text = " : ";
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(322, 141);
            this.nudSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(35, 20);
            this.nudSecond.TabIndex = 30;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(259, 141);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(35, 20);
            this.nudMinute.TabIndex = 29;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(196, 141);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(35, 20);
            this.nudHour.TabIndex = 28;
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(83, 141);
            this.nudDay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(63, 20);
            this.nudDay.TabIndex = 27;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(152, 143);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(38, 13);
            this.lblday.TabIndex = 26;
            this.lblday.Text = "days - ";
            // 
            // lblMaxRuntime
            // 
            this.lblMaxRuntime.AutoSize = true;
            this.lblMaxRuntime.Location = new System.Drawing.Point(3, 143);
            this.lblMaxRuntime.Name = "lblMaxRuntime";
            this.lblMaxRuntime.Size = new System.Drawing.Size(70, 13);
            this.lblMaxRuntime.TabIndex = 25;
            this.lblMaxRuntime.Text = "Max runtime: ";
            // 
            // chbRunOnStartup
            // 
            this.chbRunOnStartup.AutoSize = true;
            this.chbRunOnStartup.Location = new System.Drawing.Point(6, 119);
            this.chbRunOnStartup.Name = "chbRunOnStartup";
            this.chbRunOnStartup.Size = new System.Drawing.Size(133, 17);
            this.chbRunOnStartup.TabIndex = 24;
            this.chbRunOnStartup.Text = "Run php file on startup";
            this.chbRunOnStartup.UseVisualStyleBackColor = true;
            this.chbRunOnStartup.CheckStateChanged += new System.EventHandler(this.chbRunOnStartup_CheckStateChanged);
            // 
            // chbSavePHP
            // 
            this.chbSavePHP.AutoSize = true;
            this.chbSavePHP.Location = new System.Drawing.Point(6, 52);
            this.chbSavePHP.Name = "chbSavePHP";
            this.chbSavePHP.Size = new System.Drawing.Size(146, 17);
            this.chbSavePHP.TabIndex = 23;
            this.chbSavePHP.Text = "Note latest setted php file";
            this.chbSavePHP.UseVisualStyleBackColor = true;
            // 
            // chbRunAtstartup
            // 
            this.chbRunAtstartup.AutoSize = true;
            this.chbRunAtstartup.Location = new System.Drawing.Point(6, 29);
            this.chbRunAtstartup.Name = "chbRunAtstartup";
            this.chbRunAtstartup.Size = new System.Drawing.Size(140, 17);
            this.chbRunAtstartup.TabIndex = 22;
            this.chbRunAtstartup.Text = "Run at Windows startup";
            this.chbRunAtstartup.UseVisualStyleBackColor = true;
            // 
            // chbMinimizeToTray
            // 
            this.chbMinimizeToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMinimizeToTray.AutoSize = true;
            this.chbMinimizeToTray.Location = new System.Drawing.Point(6, 6);
            this.chbMinimizeToTray.Name = "chbMinimizeToTray";
            this.chbMinimizeToTray.Size = new System.Drawing.Size(133, 17);
            this.chbMinimizeToTray.TabIndex = 21;
            this.chbMinimizeToTray.Text = "Minimize to system tray";
            this.chbMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbTSF);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chbTimeStamp);
            this.tabPage2.Controls.Add(this.maxChar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.updateInterval);
            this.tabPage2.Controls.Add(this.lblUpdate);
            this.tabPage2.Controls.Add(this.nudSplit);
            this.tabPage2.Controls.Add(this.cbUnits);
            this.tabPage2.Controls.Add(this.chbSplit);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbSavePath);
            this.tabPage2.Controls.Add(this.chbSaveRes);
            this.tabPage2.Controls.Add(this.chbPrintRes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Result settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbTSF
            // 
            this.tbTSF.Enabled = false;
            this.tbTSF.Location = new System.Drawing.Point(106, 160);
            this.tbTSF.Name = "tbTSF";
            this.tbTSF.Size = new System.Drawing.Size(147, 20);
            this.tbTSF.TabIndex = 27;
            this.tbTSF.Text = "%Y-%M-%D_%h-%m-%s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Time stamp format:";
            // 
            // chbTimeStamp
            // 
            this.chbTimeStamp.AutoSize = true;
            this.chbTimeStamp.Enabled = false;
            this.chbTimeStamp.Location = new System.Drawing.Point(7, 143);
            this.chbTimeStamp.Name = "chbTimeStamp";
            this.chbTimeStamp.Size = new System.Drawing.Size(144, 17);
            this.chbTimeStamp.TabIndex = 25;
            this.chbTimeStamp.Text = "Append time stamp to file";
            this.chbTimeStamp.UseVisualStyleBackColor = true;
            this.chbTimeStamp.CheckStateChanged += new System.EventHandler(this.chbTimeStamp_CheckStateChanged);
            // 
            // maxChar
            // 
            this.maxChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxChar.Location = new System.Drawing.Point(99, 28);
            this.maxChar.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxChar.Name = "maxChar";
            this.maxChar.Size = new System.Drawing.Size(126, 20);
            this.maxChar.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Max char in result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ms";
            // 
            // updateInterval
            // 
            this.updateInterval.Location = new System.Drawing.Point(356, 27);
            this.updateInterval.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.updateInterval.Name = "updateInterval";
            this.updateInterval.Size = new System.Drawing.Size(108, 20);
            this.updateInterval.TabIndex = 17;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(272, 30);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(82, 13);
            this.lblUpdate.TabIndex = 21;
            this.lblUpdate.Text = "Update interval:";
            // 
            // nudSplit
            // 
            this.nudSplit.Enabled = false;
            this.nudSplit.Location = new System.Drawing.Point(106, 119);
            this.nudSplit.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudSplit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSplit.Name = "nudSplit";
            this.nudSplit.Size = new System.Drawing.Size(78, 20);
            this.nudSplit.TabIndex = 7;
            this.nudSplit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbUnits
            // 
            this.cbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnits.Enabled = false;
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.cbUnits.Location = new System.Drawing.Point(190, 118);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(63, 21);
            this.cbUnits.TabIndex = 6;
            // 
            // chbSplit
            // 
            this.chbSplit.AutoSize = true;
            this.chbSplit.Enabled = false;
            this.chbSplit.Location = new System.Drawing.Point(7, 120);
            this.chbSplit.Name = "chbSplit";
            this.chbSplit.Size = new System.Drawing.Size(93, 17);
            this.chbSplit.TabIndex = 5;
            this.chbSplit.Text = "Split result file:";
            this.chbSplit.UseVisualStyleBackColor = true;
            this.chbSplit.CheckStateChanged += new System.EventHandler(this.chbSplit_CheckStateChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(420, 92);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Set file";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result file:";
            // 
            // tbSavePath
            // 
            this.tbSavePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSavePath.Enabled = false;
            this.tbSavePath.Location = new System.Drawing.Point(70, 94);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(344, 20);
            this.tbSavePath.TabIndex = 2;
            this.tbSavePath.EnabledChanged += new System.EventHandler(this.tbSavePath_EnabledChanged);
            // 
            // chbSaveRes
            // 
            this.chbSaveRes.AutoSize = true;
            this.chbSaveRes.Location = new System.Drawing.Point(7, 71);
            this.chbSaveRes.Name = "chbSaveRes";
            this.chbSaveRes.Size = new System.Drawing.Size(115, 17);
            this.chbSaveRes.TabIndex = 1;
            this.chbSaveRes.Text = "Save result into file";
            this.chbSaveRes.UseVisualStyleBackColor = true;
            this.chbSaveRes.CheckStateChanged += new System.EventHandler(this.chbSaveRes_CheckStateChanged);
            // 
            // chbPrintRes
            // 
            this.chbPrintRes.AutoSize = true;
            this.chbPrintRes.Location = new System.Drawing.Point(6, 6);
            this.chbPrintRes.Name = "chbPrintRes";
            this.chbPrintRes.Size = new System.Drawing.Size(160, 17);
            this.chbPrintRes.TabIndex = 0;
            this.chbPrintRes.Text = "Print result to PHP result box";
            this.chbPrintRes.UseVisualStyleBackColor = true;
            this.chbPrintRes.CheckStateChanged += new System.EventHandler(this.chbPrintRes_CheckStateChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(364, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save result";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 262);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.CheckBox chbSplit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.CheckBox chbSaveRes;
        private System.Windows.Forms.CheckBox chbPrintRes;
        private System.Windows.Forms.NumericUpDown nudSplit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown maxChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updateInterval;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.CheckBox chbMinimizeToTray;
        private System.Windows.Forms.CheckBox chbRunAtstartup;
        private System.Windows.Forms.CheckBox chbSavePHP;
        private System.Windows.Forms.CheckBox chbRunOnStartup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSep;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblMaxRuntime;
        private System.Windows.Forms.NumericUpDown nudWarningLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTSF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbTimeStamp;
        private System.Windows.Forms.CheckBox chbCheckUpdatesAtStartUp;
        private System.Windows.Forms.CheckBox chbShowPopupDialog;
    }
}