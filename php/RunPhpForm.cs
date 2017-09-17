using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace php
{
    public partial class RunPhpForm : Form
    {
        private bool cancelled = false;
        private int seconds = Settings.nudWarningLength;

        public RunPhpForm()
        {
            InitializeComponent();
            lblPHPFile.Text = Settings.phpfile;
            lblPHPArgs.Text = Settings.phpargs;
            lblSeconds.Text = Settings.nudWarningLength.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cancelled = true;
            this.DialogResult = DialogResult.Cancel;
        }

        public bool Cancelled()
        {
            return this.cancelled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            lblSeconds.Text = seconds.ToString();
            if (seconds <= 0)
            {
                timer.Enabled = false;
                this.DialogResult = DialogResult.OK;
            }

        }

    }
}
