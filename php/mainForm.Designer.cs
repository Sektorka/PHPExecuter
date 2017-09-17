namespace php
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tbPhpPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowsePhp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhpFile = new System.Windows.Forms.TextBox();
            this.btnBrowsePhpFile = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbArgs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUpTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMaxTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnClearResultBox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOPED = new System.Windows.Forms.Button();
            this.btnOPFD = new System.Windows.Forms.Button();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar = new Win7Progress.Windows7ProgressBar();
            this.menuStrip.SuspendLayout();
            this.notifyContext.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPhpPath
            // 
            this.tbPhpPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhpPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPhpPath.Location = new System.Drawing.Point(63, 31);
            this.tbPhpPath.Name = "tbPhpPath";
            this.tbPhpPath.ReadOnly = true;
            this.tbPhpPath.Size = new System.Drawing.Size(409, 20);
            this.tbPhpPath.TabIndex = 1;
            this.tbPhpPath.TabStop = false;
            this.tbPhpPath.TextChanged += new System.EventHandler(this.tbPhpPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHP.exe";
            // 
            // btnBrowsePhp
            // 
            this.btnBrowsePhp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePhp.Location = new System.Drawing.Point(478, 31);
            this.btnBrowsePhp.Name = "btnBrowsePhp";
            this.btnBrowsePhp.Size = new System.Drawing.Size(30, 20);
            this.btnBrowsePhp.TabIndex = 2;
            this.btnBrowsePhp.Text = "...";
            this.btnBrowsePhp.UseVisualStyleBackColor = true;
            this.btnBrowsePhp.Click += new System.EventHandler(this.btnBrowsePhp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PHP file";
            // 
            // tbPhpFile
            // 
            this.tbPhpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhpFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPhpFile.Location = new System.Drawing.Point(63, 59);
            this.tbPhpFile.Name = "tbPhpFile";
            this.tbPhpFile.ReadOnly = true;
            this.tbPhpFile.Size = new System.Drawing.Size(409, 20);
            this.tbPhpFile.TabIndex = 3;
            this.tbPhpFile.TabStop = false;
            this.tbPhpFile.TextChanged += new System.EventHandler(this.tbPhpFile_TextChanged);
            // 
            // btnBrowsePhpFile
            // 
            this.btnBrowsePhpFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePhpFile.Location = new System.Drawing.Point(478, 59);
            this.btnBrowsePhpFile.Name = "btnBrowsePhpFile";
            this.btnBrowsePhpFile.Size = new System.Drawing.Size(30, 20);
            this.btnBrowsePhpFile.TabIndex = 4;
            this.btnBrowsePhpFile.Text = "...";
            this.btnBrowsePhpFile.UseVisualStyleBackColor = true;
            this.btnBrowsePhpFile.Click += new System.EventHandler(this.btnBrowsePhpFile_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(414, 390);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 23);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run php file";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbArgs
            // 
            this.tbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbArgs.Location = new System.Drawing.Point(63, 88);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(481, 20);
            this.tbArgs.TabIndex = 5;
            this.tbArgs.TextChanged += new System.EventHandler(this.tbArgs_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Args";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "php";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbResult.HideSelection = false;
            this.tbResult.Location = new System.Drawing.Point(15, 143);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(529, 215);
            this.tbResult.TabIndex = 10;
            this.tbResult.Text = "";
            this.tbResult.SelectionChanged += new System.EventHandler(this.tbResult_SelectionChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(556, 24);
            this.menuStrip.TabIndex = 12;
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miExit});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "File";
            // 
            // miSave
            // 
            this.miSave.Image = global::php.Properties.Resources.disk;
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(170, 22);
            this.miSave.Text = "Save result";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miExit
            // 
            this.miExit.Image = global::php.Properties.Resources.cancel;
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miExit.Size = new System.Drawing.Size(170, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFind,
            this.miCopy});
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.szerkesztésToolStripMenuItem.Text = "Edit";
            // 
            // miFind
            // 
            this.miFind.Image = global::php.Properties.Resources.find;
            this.miFind.Name = "miFind";
            this.miFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFind.Size = new System.Drawing.Size(144, 22);
            this.miFind.Text = "Find";
            this.miFind.Click += new System.EventHandler(this.miFind_Click);
            // 
            // miCopy
            // 
            this.miCopy.Image = global::php.Properties.Resources.page_copy;
            this.miCopy.Name = "miCopy";
            this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miCopy.Size = new System.Drawing.Size(144, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSettings});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // miSettings
            // 
            this.miSettings.Image = global::php.Properties.Resources.cog_edit;
            this.miSettings.Name = "miSettings";
            this.miSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.miSettings.Size = new System.Drawing.Size(156, 22);
            this.miSettings.Text = "Settings";
            this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUpdate,
            this.miAbout});
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.súgóToolStripMenuItem.Text = "Help";
            // 
            // miUpdate
            // 
            this.miUpdate.Image = global::php.Properties.Resources.arrow_refresh;
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(145, 22);
            this.miUpdate.Text = "Update";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miAbout
            // 
            this.miAbout.Image = global::php.Properties.Resources.user_gray;
            this.miAbout.Name = "miAbout";
            this.miAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.miAbout.Size = new System.Drawing.Size(145, 22);
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyContext;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Tag = "";
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // notifyContext
            // 
            this.notifyContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiExit});
            this.notifyContext.Name = "notifyContext";
            this.notifyContext.Size = new System.Drawing.Size(93, 26);
            this.notifyContext.Tag = "";
            // 
            // cmiExit
            // 
            this.cmiExit.Image = global::php.Properties.Resources.cancel;
            this.cmiExit.Name = "cmiExit";
            this.cmiExit.Size = new System.Drawing.Size(92, 22);
            this.cmiExit.Text = "Exit";
            this.cmiExit.Click += new System.EventHandler(this.cmiExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatusText,
            this.tssStatus,
            this.tssRunTime,
            this.tssUpTime,
            this.tssMaxTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(556, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssStatusText
            // 
            this.tssStatusText.Name = "tssStatusText";
            this.tssStatusText.Size = new System.Drawing.Size(54, 17);
            this.tssStatusText.Text = "    Status:";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(26, 17);
            this.tssStatus.Text = "Idle";
            // 
            // tssRunTime
            // 
            this.tssRunTime.Name = "tssRunTime";
            this.tssRunTime.Size = new System.Drawing.Size(97, 17);
            this.tssRunTime.Text = "|  Execution time:";
            // 
            // tssUpTime
            // 
            this.tssUpTime.Name = "tssUpTime";
            this.tssUpTime.Size = new System.Drawing.Size(49, 17);
            this.tssUpTime.Text = "00:00:00";
            // 
            // tssMaxTime
            // 
            this.tssMaxTime.Name = "tssMaxTime";
            this.tssMaxTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save result";
            // 
            // btnClearResultBox
            // 
            this.btnClearResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResultBox.Location = new System.Drawing.Point(427, 114);
            this.btnClearResultBox.Name = "btnClearResultBox";
            this.btnClearResultBox.Size = new System.Drawing.Size(117, 23);
            this.btnClearResultBox.TabIndex = 22;
            this.btnClearResultBox.Text = "Clear PHP result box";
            this.btnClearResultBox.UseVisualStyleBackColor = true;
            this.btnClearResultBox.Click += new System.EventHandler(this.btnClearResultBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "PHP result box:";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(70, 364);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(474, 20);
            this.tbInput.TabIndex = 24;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Std input:";
            // 
            // btnOPED
            // 
            this.btnOPED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOPED.Image = global::php.Properties.Resources.folder_go;
            this.btnOPED.Location = new System.Drawing.Point(514, 31);
            this.btnOPED.Name = "btnOPED";
            this.btnOPED.Size = new System.Drawing.Size(30, 20);
            this.btnOPED.TabIndex = 26;
            this.btnOPED.UseVisualStyleBackColor = true;
            this.btnOPED.Click += new System.EventHandler(this.btnOPED_Click);
            // 
            // btnOPFD
            // 
            this.btnOPFD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOPFD.Image = global::php.Properties.Resources.folder_go;
            this.btnOPFD.Location = new System.Drawing.Point(514, 59);
            this.btnOPFD.Name = "btnOPFD";
            this.btnOPFD.Size = new System.Drawing.Size(30, 20);
            this.btnOPFD.TabIndex = 27;
            this.btnOPFD.UseVisualStyleBackColor = true;
            this.btnOPFD.Click += new System.EventHandler(this.btnOPFD_Click);
            // 
            // cbEncoding
            // 
            this.cbEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "Default",
            "ANSI",
            "UTF-8"});
            this.cbEncoding.Location = new System.Drawing.Point(365, 115);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(56, 21);
            this.cbEncoding.TabIndex = 28;
            this.cbEncoding.SelectedIndexChanged += new System.EventHandler(this.cbEncoding_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Flush encoding:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ContainerControl = this;
            this.progressBar.Location = new System.Drawing.Point(15, 390);
            this.progressBar.MarqueeAnimationSpeed = 16;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(393, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEncoding);
            this.Controls.Add(this.btnOPFD);
            this.Controls.Add(this.btnOPED);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearResultBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tbArgs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowsePhpFile);
            this.Controls.Add(this.tbPhpFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowsePhp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPhpPath);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(572, 488);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP Executer :: v1.1 :: by Sektor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainForm_DragEnter);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.notifyContext.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhpPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowsePhp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhpFile;
        private System.Windows.Forms.Button btnBrowsePhpFile;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbArgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Win7Progress.Windows7ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFind;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssRunTime;
        private System.Windows.Forms.ToolStripStatusLabel tssUpTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel tssStatusText;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ContextMenuStrip notifyContext;
        private System.Windows.Forms.ToolStripMenuItem cmiExit;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearResultBox;
        private System.Windows.Forms.ToolStripStatusLabel tssMaxTime;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOPED;
        private System.Windows.Forms.Button btnOPFD;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.Label label6;
    }
}

