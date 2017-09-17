using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Updater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length != 1)
            {
                MessageBox.Show(null, "Start Updater from PHP Executer program!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Application.Run(new updaterForm(args));
            }
        }
    }
}
