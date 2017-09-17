using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace php
{
    static class Settings
    {
        public static int cbUnits;
        public static bool chbPrintRes;
        public static bool chbSaveRes;
        public static bool chbSplit;
        public static int nudSplit;
        public static string tbSavePath = string.Empty;
        public static int updateInterval;
        public static int maxChar;
        public static bool chbMinimizeToTray;
        public static bool chbRunAtstartup;
        public static bool chbSavePHP;
        public static bool chbRunOnStartup;
        public static string phpexe = string.Empty;
        public static string phpfile = string.Empty;
        public static string phpargs = string.Empty;
        public static int nudDay;
        public static int nudHour;
        public static int nudMinute;
        public static int nudSecond;
        public static int nudWarningLength;
        public static bool bMaximized;
        public static bool chbTimeStamp;
        public static string tbTSF = string.Empty;
        public static bool chbCheckUpdatesAtStartUp;
        public static string enconding = "Default";
        public static bool chbShowPopupDialog;

        public static long GetMaxTime()
        {
            return nudDay * 86400 + nudHour * 3600 + nudMinute * 60 + nudSecond;
        }

        public static void Update()
        {
            RegistryKey RK;
            if ((RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings")) == null)
            {
                Registry.CurrentUser.CreateSubKey("Software\\PHPExecuter\\Settings");
                RK = Registry.CurrentUser.OpenSubKey("Software\\PHPExecuter\\Settings");
            }

            //chbPrintRes
            if (RK.GetValue("chbPrintRes") != null)
            {
                try
                {
                    chbPrintRes = bool.Parse(RK.GetValue("chbPrintRes").ToString());
                }
                catch (Exception)
                {
                    chbPrintRes = true;
                }
            }
            else
                chbPrintRes = true;

            //chbSaveRes
            if (RK.GetValue("chbSaveRes") != null)
            {
                try
                {
                    chbSaveRes = bool.Parse(RK.GetValue("chbSaveRes").ToString());
                }
                catch (Exception)
                {
                    chbSaveRes = false;
                }
            }
            else
                chbSaveRes = false;

            
            //chbMinimizeToTray
            if (RK.GetValue("chbMinimizeToTray") != null)
            {
                try
                {
                    chbMinimizeToTray = bool.Parse(RK.GetValue("chbMinimizeToTray").ToString());
                }
                catch (Exception)
                {
                    chbMinimizeToTray = false;
                }
            }
            else
                chbMinimizeToTray = false;

            //chbCheckUpdatesAtStartUp
            if (RK.GetValue("chbCheckUpdatesAtStartUp") != null)
            {
                try
                {
                    chbCheckUpdatesAtStartUp = bool.Parse(RK.GetValue("chbCheckUpdatesAtStartUp").ToString());
                }
                catch (Exception)
                {
                    chbCheckUpdatesAtStartUp  = true;
                }
            }
            else
                chbCheckUpdatesAtStartUp = true;

            //chbShowPopupDialog
            if (RK.GetValue("chbShowPopupDialog") != null)
            {
                try
                {
                    chbShowPopupDialog = bool.Parse(RK.GetValue("chbShowPopupDialog").ToString());
                }
                catch (Exception)
                {
                    chbShowPopupDialog = true;
                }
            }
            else
                chbShowPopupDialog = true;

            //tbSavePath
            if (RK.GetValue("tbSavePath") != null)
            {
                tbSavePath = RK.GetValue("tbSavePath").ToString();
            }

            //tbTSF
            if (RK.GetValue("tbTSF") != null)
            {
                tbTSF = RK.GetValue("tbTSF").ToString();
            }

            //chbSplit
            if (RK.GetValue("chbSplit") != null)
            {
                try
                {
                    chbSplit = bool.Parse(RK.GetValue("chbSplit").ToString());
                }
                catch (Exception)
                {
                    chbSplit = false;
                }
            }
            else
                chbSplit = false;

            //nudSplit
            if (RK.GetValue("nudSplit") != null)
            {
                try
                {
                    nudSplit = int.Parse(RK.GetValue("nudSplit").ToString());
                }
                catch (Exception)
                {
                    nudSplit = 100;
                }
            }
            else
                nudSplit = 100;

            //updateInterval
            if (RK.GetValue("updateInterval") != null)
            {
                try
                {
                    updateInterval = int.Parse(RK.GetValue("updateInterval").ToString());
                }
                catch (Exception)
                {
                    updateInterval = 0;
                }
            }
            else
                updateInterval = 0;

            //maxChar
            if (RK.GetValue("maxChar") != null)
            {
                try
                {
                    maxChar = int.Parse(RK.GetValue("maxChar").ToString());
                }
                catch (Exception)
                {
                    maxChar = 0;
                }
            }
            else
                maxChar = 0;

            //chbSavePHP
            if (RK.GetValue("chbSavePHP") != null)
                try
                {
                    chbSavePHP = bool.Parse(RK.GetValue("chbSavePHP").ToString());
                }
                catch (Exception)
                {
                    chbSavePHP = true;
                }
            else
                chbSavePHP = true;

            //chbSplit
            if (RK.GetValue("chbRunOnStartup") != null)
            {
                try
                {
                    chbRunOnStartup = bool.Parse(RK.GetValue("chbRunOnStartup").ToString());
                }
                catch (Exception)
                {
                    chbRunOnStartup = false;
                }
            }
            else
                chbRunOnStartup = false;

            //chbSplit
            if (RK.GetValue("chbSplit") != null)
            {
                try
                {
                    chbSplit = bool.Parse(RK.GetValue("chbSplit").ToString());
                }
                catch (Exception)
                {
                    chbSplit = false;
                }
            }
            else
                chbSplit = false;
            
            //chbTimeStamp
            if (RK.GetValue("chbTimeStamp") != null)
            {
                try
                {
                    chbTimeStamp = bool.Parse(RK.GetValue("chbTimeStamp").ToString());
                }
                catch (Exception)
                {
                    chbTimeStamp = false;
                }
            }
            else
                chbTimeStamp = false;

            //cbUnits
            if (RK.GetValue("cbUnits") != null)
            {
                try
                {
                    cbUnits = int.Parse(RK.GetValue("cbUnits").ToString());
                }
                catch (Exception)
                {
                    cbUnits = 2;
                }
            }
            else
                cbUnits = 2;

            //phpexe
            if (RK.GetValue("phpexe") != null)
            {
                phpexe = RK.GetValue("phpexe").ToString();
            }

            //enconding
            if (RK.GetValue("enconding") != null)
            {
                enconding = RK.GetValue("enconding").ToString();
            }

            //phpfile
            if (RK.GetValue("phpfile") != null)
            {
                phpfile = RK.GetValue("phpfile").ToString();
            }

            //phpargs
            if (RK.GetValue("phpargs") != null)
            {
                phpargs = RK.GetValue("phpargs").ToString();
            }

            //nudDay
            if (RK.GetValue("nudDay") != null)
            {
                try
                {
                    nudDay = int.Parse(RK.GetValue("nudDay").ToString());
                }
                catch (Exception)
                {
                    nudDay = 0;
                }
            }
            else
                nudDay = 0;

            //nudHour
            if (RK.GetValue("nudHour") != null)
            {
                try
                {
                    nudHour = int.Parse(RK.GetValue("nudHour").ToString());
                }
                catch (Exception)
                {
                    nudHour = 0;
                }
            }
            else
                nudHour = 0;

            //nudMinute
            if (RK.GetValue("nudMinute") != null)
            {
                try
                {
                    nudMinute = int.Parse(RK.GetValue("nudMinute").ToString());
                }
                catch (Exception)
                {
                    nudMinute = 0;
                }
            }
            else
                nudMinute = 0;

            //nudSecond
            if (RK.GetValue("nudSecond") != null)
            {
                try
                {
                    nudSecond = int.Parse(RK.GetValue("nudSecond").ToString());
                }
                catch (Exception)
                {
                    nudSecond = 0;
                }
            }
            else
                nudSecond = 0;

            //nudWarningLength
            if (RK.GetValue("nudWarningLength") != null)
            {
                try
                {
                    nudWarningLength = int.Parse(RK.GetValue("nudWarningLength").ToString());
                }
                catch (Exception)
                {
                    nudWarningLength = 3;
                }
            }
            else
                nudWarningLength = 3;
            
            //bMaximized
            if (RK.GetValue("bMaximized") != null)
            {
                try
                {
                    bMaximized = bool.Parse(RK.GetValue("bMaximized").ToString());
                }
                catch (Exception)
                {
                    bMaximized = false;
                }
            }
            else
                bMaximized = false;

            RK.Close();

            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp != null)
            {
                if (rkApp.GetValue("PHPExecuter") == null)
                    chbRunAtstartup = false;
                else
                    chbRunAtstartup = true;

                rkApp.Close();
            }
            else
            {
                chbRunAtstartup = false;
            }
        }
    }
}
