using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace php
{
    static class Program
    {
        public const string NAME = "PHP Executer";
        public const string VERSION = "1.3.1.3";
        public const string AUTHOR = "Sektor";
        public const string Year = "2013";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((args.Length > 0) ? mainForm.GetInstance(args) : mainForm.GetInstance());
        }
    }
}
