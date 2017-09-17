using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace php
{
    public partial class mainForm : Form
    {
        private RegistryKey RK;
        private ProcessCaller processCaller;
        private DateTime startTime, LastMsg;
        private String msg = "";
        private searchForm sf;
        private aboutForm af;
        private settingsForm setf;
        private int searchIndex = 0;
        private Regex regex;
        private Match match;
        private bool popupAbort = true;
        private bool notFound = false;
        private bool maximized;
        private string status;
        private Log log;
        private int countErrors;
        private bool gotArgs = false;

        private static mainForm mainform = null;

        public static mainForm GetInstance(string[] args){
            if(mainform == null){
                mainform = new mainForm(args);
            }
            return mainform;
        }

        public static mainForm GetInstance()
        {
            if (mainform == null)
            {
                mainform = new mainForm();
            }
            return mainform;
        }

        private mainForm(string[] args): this(true)
        {
            tbPhpFile.Text = args[0];
            Run();
        }

        private mainForm(bool gotArgs)
        {
            this.gotArgs = gotArgs;

            InitializeComponent();
            Settings.Update();
            init();

            if (Settings.chbCheckUpdatesAtStartUp)
            {
                updateForm uf = new updateForm(this);
                uf.StartUpdate();
            }
        }

        private mainForm()
            : this(false)
        {
        }

        private void init() 
        {
            this.Text = Program.NAME + " :: v" + Program.VERSION + " :: by " + Program.AUTHOR;

            btnBrowsePhpFile.Select();
            status = "Idle";
            notifyIcon.Text = Program.NAME + " v" + Program.VERSION + "\nStatus: " + status;

            if (File.Exists(Settings.phpexe))
            {
                tbPhpPath.Text = Settings.phpexe;
            }

            if (Settings.chbSavePHP && File.Exists(Settings.phpfile))
            {
                tbPhpFile.Text = Settings.phpfile;
                tbArgs.Text = Settings.phpargs;
            }

            this.cbEncoding.Text = Settings.enconding;

            if (!gotArgs && Settings.chbRunOnStartup && File.Exists(tbPhpFile.Text))
            {
                RunPhpForm rpf = new RunPhpForm();
                if (rpf.ShowDialog() == DialogResult.OK)
                {
                    Run();
                }
            }

            if (Settings.GetMaxTime() > 0)
                tssMaxTime.Text = "/  " + formatSeconds(Settings.GetMaxTime());
            else
                tssMaxTime.Text = "";

            if (Settings.bMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
            
        }

        private void EnableItem(bool enable) 
        {
            btnRun.Enabled = true;
            btnRun.Text = (enable ? "Run php file" : "Abort executing!");
            
            tbPhpPath.Enabled = enable;
            tbPhpFile.Enabled = enable;
            tbArgs.Enabled = enable;
            btnBrowsePhp.Enabled = enable;
            btnBrowsePhpFile.Enabled = enable;
        }

        public static string formatSeconds(long secs) {
            int days, hours, mins;
            days = (int)(secs / 86400);
            secs %= 86400;
            hours = (int)(secs / 3600);
            secs %= 3600;
            mins = (int)(secs / 60);
            secs %= 60;
            return (days > 0 ? days.ToString() + " day" + (days > 1 ? "s" : "") + " - " : "") + 
                   (hours < 10 ? "0" + hours.ToString() : hours.ToString()) + ":" +
                   (mins < 10 ? "0" + mins.ToString() : mins.ToString()) + ":" +
                   (secs < 10 ? "0" + secs.ToString() : secs.ToString());
        }

        /// <summary>
        /// Events
        /// </summary>

        private void Run()
        {
            if (processCaller != null && processCaller.IsRunning())
            {
                btnRun.Enabled = false;
                btnRun.Text = "Aborting...";

                processCaller.Cancel();
                return;
            }

            if (!File.Exists(tbPhpPath.Text))
            {
                MessageBox.Show(this, "PHP client not setted! (php.exe)", "PHP Runner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPHPExe();
                return;
            }

            if (!File.Exists(tbPhpFile.Text))
            {
                MessageBox.Show(this, "PHP file not setted! (*.php)", "PHP Runner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenPHP();
                return;
            }

            this.EnableItem(false);

            msg = "";

            processCaller = new ProcessCaller(this);
            processCaller.FileName = "\"" + @tbPhpPath.Text + "\"";
            processCaller.Arguments = " -f \"" + tbPhpFile.Text + "\" " + tbArgs.Text;
            processCaller.BytesErrReceived += new BytesReceivedHandler(writeStreamInfo);
            processCaller.BytesOutReceived += new BytesReceivedHandler(writeStreamInfo);
            processCaller.Completed += new EventHandler(processCompleted);
            processCaller.Cancelled += new EventHandler(processCanceled);
            processCaller.WorkingDirectory = tbPhpFile.Text.Substring(0, tbPhpFile.Text.LastIndexOf('\\'));

            progressBar.ShowInTaskbar = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            startTime = DateTime.Now;
            LastMsg = DateTime.Now;
            tbResult.Clear();

            processCaller.Start();
            tbInput.Enabled = true;
            tbInput.Focus();

            status = "Running";
            tssStatus.Text = status;
            tssUpTime.Text = "00:00:00";
            if (Settings.GetMaxTime() > 0)
                tssMaxTime.Text = "/  " + formatSeconds(Settings.GetMaxTime());
            else
                tssMaxTime.Text = "";
            timer.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void writeStreamInfo(object sender, BytesReceivedEventArgs e)
        {
            if (Settings.chbSaveRes && Settings.tbSavePath != "")
            {
                if (log == null)
                    log = new Log();
                try
                {
                    log.Write(e.Text, e.Length);
                    countErrors = 0;
                }
                catch (Exception ex)
                {
                    countErrors++;
                    if (countErrors > 1)
                    {
                        Settings.chbSaveRes = false;
                    }
                    MessageBox.Show(this, ex.Message + "\r\n" + ex.StackTrace, "Result saver*", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Settings.chbPrintRes)
            {
                if (Settings.updateInterval == 0)
                {
                    tbResult.AppendText(Settings.enconding.Equals("UTF-8") ? Encoding.UTF8.GetString(e.Text, 0, e.Length) : (Settings.enconding.Equals("ASCII") ? Encoding.ASCII.GetString(e.Text, 0, e.Length) : Encoding.Default.GetString(e.Text, 0, e.Length)));
                }
                else
                {
                    msg += Settings.enconding.Equals("UTF-8") ? Encoding.UTF8.GetString(e.Text, 0, e.Length) : (Settings.enconding.Equals("ASCII") ? Encoding.ASCII.GetString(e.Text, 0, e.Length) : Encoding.Default.GetString(e.Text, 0, e.Length));
                }

                if ((long)(DateTime.Now - LastMsg).TotalMilliseconds > Settings.updateInterval)
                {
                    LastMsg = DateTime.Now;

                    tbResult.AppendText(msg);

                    msg = "";
                }

                if (Settings.maxChar != 0 && tbResult.Text.Length > Settings.maxChar)
                {
                    tbResult.Clear();
                }
            }
        }

        private void processCompleted(object sender, EventArgs e)
        {
            tbResult.AppendText(msg);
            msg = "";

            progressBar.ShowInTaskbar = false;
            progressBar.Style = ProgressBarStyle.Continuous;

            status = "Finished";
            tssStatus.Text = status;
            timer.Enabled = false;
            tbInput.Enabled = false;
            if (notifyIcon.Visible)
            {
                notifyIcon.BalloonTipTitle = status;
                notifyIcon.BalloonTipText = "PHP execution finished!";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(10);
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                if(Settings.chbShowPopupDialog)
                    MessageBox.Show(this, "PHP execution finished!", "PHP Runner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Settings.GetMaxTime() > 0)
                tssMaxTime.Text = "/  " + formatSeconds(Settings.GetMaxTime());
            else
                tssMaxTime.Text = "";

            if (log != null)
            {
                log.Close();
                log = new Log();
            }
            this.EnableItem(true);
        }

        private void processCanceled(object sender, EventArgs e)
        {
            tbResult.AppendText(msg);
            msg = "";

            progressBar.ShowInTaskbar = false;
            progressBar.Style = ProgressBarStyle.Continuous;

            timer.Enabled = false;
            tbInput.Enabled = false;
            status = "Aborted";
            tssStatus.Text = status;

            if (popupAbort && Settings.chbShowPopupDialog)
                MessageBox.Show(this, "PHP execution aborted!", "PHP Runner", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (Settings.GetMaxTime() > 0)
                tssMaxTime.Text = "/  " + formatSeconds(Settings.GetMaxTime());
            else
                tssMaxTime.Text = "";

            if (log != null)
            {
                log.Close();
                log = new Log();
            }
            this.EnableItem(true);
        }

        public void FindText(string text, bool bCapital, bool bRegex, bool bWholeWord, bool bWildcards)
        {
            regex = GetRegExpression(text, bWholeWord, bCapital, bWildcards, bRegex);
            match = regex.Match(tbResult.Text, searchIndex + tbResult.SelectionLength);


            if (match.Success)
            {
                tbResult.SelectionStart = match.Index;
                tbResult.SelectionLength = match.Length;
            }
            else
            {
                if (!notFound && MessageBox.Show(this, "Next occurence of \"" + text + "\" not found.\nContinue search from the start of content?", "Search", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    searchIndex = 0;
                    notFound = true;
                    FindText(text, bCapital, bRegex, bWholeWord, bWildcards);
                }
                else
                {
                    notFound = false;
                }
            }
        }

        private void btnBrowsePhpFile_Click(object sender, EventArgs e)
        {
            OpenPHP();
        }

        private void OpenPHP()
        {
            openFileDialog.Title = "Set php file!";
            openFileDialog.Filter = "Php file (*.php)|*.php|All files (*.*)|*.*";

            if (tbPhpFile.Text.Contains("\\") && Directory.Exists(tbPhpFile.Text.Substring(0, tbPhpFile.Text.LastIndexOf("\\"))))
            {
                openFileDialog.InitialDirectory = tbPhpFile.Text.Substring(0, tbPhpFile.Text.LastIndexOf("\\"));
                openFileDialog.FileName = tbPhpFile.Text.Substring(tbPhpFile.Text.LastIndexOf("\\") + 1);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPhpFile.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowsePhp_Click(object sender, EventArgs e)
        {
            OpenPHPExe();
        }

        private void OpenPHPExe()
        {
            openFileDialog.Title = "Set php.exe file!";
            openFileDialog.Filter = "php.exe|php.exe|exe files (*.exe)|*.exe";

            if (tbPhpPath.Text.Contains("\\") && Directory.Exists(tbPhpPath.Text.Substring(0, tbPhpPath.Text.LastIndexOf("\\"))))
            {
                openFileDialog.InitialDirectory = tbPhpPath.Text.Substring(0, tbPhpPath.Text.LastIndexOf("\\"));
                openFileDialog.FileName = tbPhpPath.Text.Substring(tbPhpPath.Text.LastIndexOf("\\") + 1);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPhpPath.Text = openFileDialog.FileName;
            }
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter");
            }

            try
            {
                RK.SetValue("php.exe", tbPhpPath.Text);
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save php.exe to registry!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (processCaller != null && processCaller.IsRunning())
            {
                e.Cancel = true;

                CloseApp();

                e.Cancel = false;
            }
        }

        private void CloseApp()
        {
            popupAbort = false;
            btnRun.Enabled = false;
            btnRun.Text = "Aborting...";
            processCaller.CancelAndWait();
        }

        private void miFind_Click(object sender, EventArgs e)
        {
            if (sf == null || sf.IsDisposed)
            {
                sf = new searchForm(this);
            }

            sf.ShowDialog();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            long elapsedTime = (long)(DateTime.Now - startTime).TotalSeconds;
            long maxtime = Settings.GetMaxTime();
            tssUpTime.Text = formatSeconds(elapsedTime);
            if (maxtime > 0)
            {
                tssMaxTime.Text = "/  " + formatSeconds(maxtime) + "  (Left: " + formatSeconds((long)(maxtime - elapsedTime)) + ")";
            }
            if (maxtime > 0 && elapsedTime >= maxtime)
            {
                btnRun.Enabled = false;
                btnRun.Text = "Aborting...";

                processCaller.Cancel();
                return;
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized && Settings.chbMinimizeToTray)
            {
                notifyIcon.Visible = true;
                progressBar.ShowInTaskbar = false;
                this.Hide();
            }
            else
            {
                if (processCaller != null && processCaller.IsRunning())
                    progressBar.ShowInTaskbar = true;
            }

            if(WindowState == FormWindowState.Maximized)
            {
                this.maximized = true;

                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings", true)) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
                }

                try
                {
                    RK.SetValue("bMaximized", "true");
                    RK.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed save maximized status!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (WindowState == FormWindowState.Normal)
            {
                this.maximized = false;

                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings", true)) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
                }

                try
                {
                    RK.SetValue("bMaximized", "false");
                    RK.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed save maximized status!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
            WindowState = (this.maximized ? FormWindowState.Maximized : FormWindowState.Normal);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            if (af == null || af.IsDisposed)
            {
                af = new aboutForm();
            }

            af.ShowDialog();
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            if(tbResult.SelectedText.Length>0)
                Clipboard.SetText(tbResult.SelectedText);
        }

        private void cmiExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon.Visible = false;
                Show();
                WindowState = (this.maximized ? FormWindowState.Maximized : FormWindowState.Normal);
            }
            
        }

        public void Exit()
        {
            if (processCaller != null && processCaller.IsRunning())
            {
                CloseApp();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }


        private Regex GetRegExpression(string text,bool bMatchWholeWord, bool bMatchCase, bool bUseWildcards, bool bUseRegularExp)
        {
            Regex result;
            String regExString;

            
            regExString = text;

            if (bUseRegularExp)
            {}
            else if (bUseWildcards)
            {
                regExString = regExString.Replace("*", @"\w*");     
                regExString = regExString.Replace("?", @"\w");      

                regExString = String.Format("{0}{1}{0}", @"\b", regExString);
            }
            else
            {
                regExString = Regex.Escape(regExString);
            }

            if (bMatchWholeWord)
            {
                regExString = String.Format("{0}{1}{0}", @"\b", regExString);
            }

            if (bMatchCase)
            {
                result = new Regex(regExString );
            }
            else
            {
                result = new Regex(regExString, RegexOptions.IgnoreCase);
            }

            return result;
        }

        private void tbResult_SelectionChanged(object sender, EventArgs e)
        {
            searchIndex = tbResult.SelectionStart;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Equals(""))
            {
                MessageBox.Show(this, "Result box is empty!", "PHP Runner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveFileDialog.FileName = "PHP_Execution_result.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, tbResult.Text, Encoding.UTF8);
                }
            }
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            setf = new settingsForm();
            
            if (setf.ShowDialog() == DialogResult.OK)
            {
                if(Settings.GetMaxTime() > 0)
                    tssMaxTime.Text = "/  " + formatSeconds(Settings.GetMaxTime());
                else
                    tssMaxTime.Text = "";
            }
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon.Text = Program.NAME + " v" + Program.VERSION + "\nStatus: " + status + (status == "Running" ? " - " + formatSeconds((long)(DateTime.Now - startTime).TotalSeconds) : "");
        }

        private void btnClearResultBox_Click(object sender, EventArgs e)
        {
            this.tbResult.Clear();
        }

        private void tbPhpFile_TextChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings",true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
            }

            try
            {
                RK.SetValue("phpfile", tbPhpFile.Text);
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save php file!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbArgs_TextChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
            }

            try
            {
                RK.SetValue("phpargs", tbArgs.Text);
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save php arguments!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPhpPath_TextChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
            }

            try
            {
                RK.SetValue("phpexe", tbPhpPath.Text);
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save php file!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miUpdate_Click(object sender, EventArgs e)
        {
            UpdateCheck();
        }

        public void UpdateCheck()
        {
            updateForm uf = new updateForm(this);
            uf.ShowDialog();

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.processCaller.Write(tbInput.Text + "\n");
                tbResult.AppendText(tbInput.Text + "\n");
                tbInput.Text = "";
            }
        }

        private void btnOPED_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + tbPhpPath.Text);
        }

        private void btnOPFD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + tbPhpFile.Text);
        }

        private void mainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainForm_DragDrop(object sender, DragEventArgs e)
        {
            Array arrFiles = (Array)e.Data.GetData(DataFormats.FileDrop);

            if(arrFiles.Length == 1){
                if(!( (File.GetAttributes(arrFiles.GetValue(0).ToString()) & FileAttributes.Directory) == FileAttributes.Directory))
                    tbPhpFile.Text = arrFiles.GetValue(0).ToString();
                else
                    MessageBox.Show(this, "Directory not allowed to drop! Please drop php file.", "PHP Executer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                MessageBox.Show(this, "Maximum one file drop allowed to program!", "PHP Executer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.enconding = cbEncoding.Text;
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
            }

            try
            {
                RK.SetValue("enconding", Settings.enconding);
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save flush encode!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
