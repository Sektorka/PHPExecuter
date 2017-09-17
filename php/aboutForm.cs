using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace php
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
            this.lblVersion.Text = "Version: " + Program.VERSION;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:sektor@sektor.hu");
            }
            catch (Exception) {
                Clipboard.SetText("sektor@sektor.hu");
                MessageBox.Show(this, "Unable to associate email address any program!\r\nE-mail address copyed to clipboard!", "Send email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
