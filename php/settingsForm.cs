using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace php
{
    public partial class settingsForm : Form
    {
        private RegistryKey RK;

        public settingsForm()
        {
            InitializeComponent();
            init();
        }

        private void init() {
            Settings.Update();
            tbSavePath.Text = Settings.tbSavePath;
            chbPrintRes.Checked = Settings.chbPrintRes;
            chbSaveRes.Checked = Settings.chbSaveRes;
            chbSplit.Checked = Settings.chbSplit;
            try
            {
                nudSplit.Value = Settings.nudSplit;
            }
            catch (Exception e)
            {
                nudSplit.Value = 1;
            }
            cbUnits.SelectedIndex = Settings.cbUnits;
            chbMinimizeToTray.Checked = Settings.chbMinimizeToTray;
            updateInterval.Value = Settings.updateInterval;
            maxChar.Value = Settings.maxChar;
            chbRunAtstartup.Checked = Settings.chbRunAtstartup;
            chbSavePHP.Checked = Settings.chbSavePHP;
            chbRunOnStartup.Checked = Settings.chbRunOnStartup;
            nudDay.Value = Settings.nudDay;
            nudHour.Value = Settings.nudHour;
            nudMinute.Value = Settings.nudMinute;
            nudSecond.Value = Settings.nudSecond;
            nudWarningLength.Value = Settings.nudWarningLength;
            chbTimeStamp.Checked = Settings.chbTimeStamp;
            chbCheckUpdatesAtStartUp.Checked = Settings.chbCheckUpdatesAtStartUp;
            chbShowPopupDialog.Checked = Settings.chbShowPopupDialog;
            tbTSF.Text = (Settings.tbTSF.Equals("") ? "%Y-%M-%D_%h-%m-%s" : Settings.tbTSF);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            setFile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool SaveChanges() {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings",true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
            }

            try
            {
                RK.SetValue("tbSavePath", tbSavePath.Text);
                RK.SetValue("tbTSF", tbTSF.Text);
                RK.SetValue("chbPrintRes", (chbPrintRes.Checked ? "true" : "false"));
                RK.SetValue("chbSaveRes", (chbSaveRes.Checked ? "true" : "false"));
                RK.SetValue("chbSplit", (chbSplit.Checked ? "true" : "false"));
                RK.SetValue("nudSplit", nudSplit.Value.ToString());
                RK.SetValue("cbUnits", cbUnits.SelectedIndex.ToString());
                RK.SetValue("chbMinimizeToTray", (chbMinimizeToTray.Checked ? "true" : "false"));
                RK.SetValue("updateInterval", updateInterval.Value.ToString());
                RK.SetValue("maxChar", maxChar.Value.ToString());
                RK.SetValue("chbSavePHP", (chbSavePHP.Checked ? "true" : "false"));
                RK.SetValue("chbRunOnStartup", (chbRunOnStartup.Checked ? "true" : "false"));
                RK.SetValue("chbTimeStamp", (chbTimeStamp.Checked ? "true" : "false"));
                RK.SetValue("chbCheckUpdatesAtStartUp", (chbCheckUpdatesAtStartUp.Checked ? "true" : "false"));
                RK.SetValue("chbShowPopupDialog", (chbShowPopupDialog.Checked ? "true" : "false"));
                RK.SetValue("nudDay", nudDay.Value.ToString());
                RK.SetValue("nudHour", nudHour.Value.ToString());
                RK.SetValue("nudMinute", nudMinute.Value.ToString());
                RK.SetValue("nudSecond", nudSecond.Value.ToString());
                RK.SetValue("nudWarningLength", nudWarningLength.Value.ToString());

                RK.Close();

                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (rkApp != null)
                {
                    if(chbRunAtstartup.Checked)
                        rkApp.SetValue("PHPExecuter", Application.ExecutablePath.ToString());
                    else
                        rkApp.DeleteValue("PHPExecuter", false);
                    rkApp.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save settings!\r\n" + ex.Message, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                Settings.Update();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbSavePath_EnabledChanged(object sender, EventArgs e)
        {
            if (tbSavePath.Enabled && tbSavePath.Text == "")
            {
                setFile();
            }
        }

        private void setFile() {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSavePath.Text = saveFileDialog.FileName;
            }
            else
            {
                this.chbSaveRes.Checked = false;
            }
        }

        private void CheckedEnableDisable() {
            if (chbSaveRes.Checked)
            {
                tbSavePath.Enabled = true;
                btnBrowse.Enabled = true;
                chbSplit.Enabled = true;
                chbTimeStamp.Enabled = true;

                if (chbSplit.Checked)
                {
                    nudSplit.Enabled = true;
                    cbUnits.Enabled = true;
                }
                else
                {
                    nudSplit.Enabled = false;
                    cbUnits.Enabled = false;
                }

                if (chbTimeStamp.Checked)
                {
                    tbTSF.Enabled = true;
                }
                else
                {
                    tbTSF.Enabled = false;
                }

            }
            else
            {
                tbSavePath.Enabled = false;
                btnBrowse.Enabled = false;
                chbSplit.Enabled = false;
                nudSplit.Enabled = false;
                cbUnits.Enabled = false;
                chbTimeStamp.Enabled = false;
                tbTSF.Enabled = false;
            }
        }

        private void CheckedTimeStampEnableDisable()
        {
            if (chbTimeStamp.Checked && chbTimeStamp.Enabled)
            {
                tbTSF.Enabled = true;
            }
            else
            {
                tbTSF.Enabled = false;
            }
        }

        private void CheckedSplitEnableDisable()
        {
            if (chbSplit.Checked && chbSplit.Enabled)
            {
                nudSplit.Enabled = true;
                cbUnits.Enabled = true;
            }
            else
            {
                nudSplit.Enabled = false;
                cbUnits.Enabled = false;
            }
        }

        private void CheckedPrintEnableDisable()
        {
            if (chbPrintRes.Checked)
            {
                updateInterval.Enabled = true;
                maxChar.Enabled = true;
            }
            else
            {
                updateInterval.Enabled = false;
                maxChar.Enabled = false;
            }
        }

        private void chbSaveRes_CheckStateChanged(object sender, EventArgs e)
        {
            CheckedEnableDisable();
        }

        private void chbSplit_CheckStateChanged(object sender, EventArgs e)
        {
            CheckedSplitEnableDisable();
        }

        private void chbPrintRes_CheckStateChanged(object sender, EventArgs e)
        {
            CheckedPrintEnableDisable();
        }

        private void chbRunOnStartup_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbRunOnStartup.Checked)
                nudWarningLength.Enabled = true;
            else
                nudWarningLength.Enabled = false;
        }

        private void chbTimeStamp_CheckStateChanged(object sender, EventArgs e)
        {
            CheckedTimeStampEnableDisable();
        }
    }
}
