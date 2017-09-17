using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace php
{
    public partial class searchForm : Form
    {
        private mainForm mf;
        private RegistryKey RK;

        public searchForm(mainForm mf)
        {
            InitializeComponent();
            this.mf = mf;

            try
            {
                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search")) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
                }
                if (RK.GetValue("wholeword") != null)
                    chbWholeWord.Checked = (RK.GetValue("wholeword").ToString().Equals("true") ? true : false);

                RK.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search")) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
                }
                if (RK.GetValue("casesensitive") != null)
                    chbCaseSensitive.Checked = (RK.GetValue("casesensitive").ToString().Equals("true") ? true : false);

                RK.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search")) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
                }
                if (RK.GetValue("wildcards") != null)
                    chbUseWildcards.Checked = (RK.GetValue("wildcards").ToString().Equals("true") ? true : false);

                RK.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search")) == null)
                {
                    RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
                }
                if (RK.GetValue("regexp") != null)
                    chbRegexp.Checked = (RK.GetValue("regexp").ToString().Equals("true") ? true : false);

                RK.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search()
        {
            this.Hide();
            mf.FindText(tbSearch.Text, chbCaseSensitive.Checked, chbRegexp.Checked, chbWholeWord.Checked, chbUseWildcards.Checked);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void searchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void chbWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
            }

            try
            {
                RK.SetValue("wholeword", (chbWholeWord.Checked ? "true" : "false"));
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save whole word option to registry!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void chbCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
            }

            try
            {
                RK.SetValue("casesensitive", (chbCaseSensitive.Checked ? "true" : "false"));
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save case sensitive option to registry!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void chbUseWildcards_CheckedChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
            }

            try
            {
                RK.SetValue("wildcards", (chbUseWildcards.Checked ? "true" : "false"));
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save wildcards option to registry!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void chbRegexp_CheckedChanged(object sender, EventArgs e)
        {
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Search", true)) == null)
            {
                RK = Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Search");
            }

            try
            {
                RK.SetValue("regexp", (chbRegexp.Checked ? "true" : "false"));
                RK.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed save regular expression option to registry!\r\n" + ex.Message, "Registry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
