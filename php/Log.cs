using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace php
{
    class Log
    {
        private string currentFileName;
        private FileStream fs;
        private BinaryWriter sw;

        private void SetCurrentFile()
        {
            DateTime dt = DateTime.Now;
            string dts = Settings.tbTSF.Replace("%Y", dt.Year.ToString());
            dts = dts.Replace("%M", (dt.Month < 10 ? "0" + dt.Month.ToString() : dt.Month.ToString()));
            dts = dts.Replace("%D", (dt.Day < 10 ? "0" + dt.Day.ToString() : dt.Day.ToString()));
            dts = dts.Replace("%h", (dt.Hour < 10 ? "0" + dt.Hour.ToString() : dt.Hour.ToString()));
            dts = dts.Replace("%m", (dt.Minute < 10 ? "0" + dt.Minute.ToString() : dt.Minute.ToString()));
            dts = dts.Replace("%s", (dt.Second < 10 ? "0" + dt.Second.ToString() : dt.Second.ToString()));

            int dotPos = -1;
            if (Settings.chbTimeStamp)
            {
                if ((dotPos = Settings.tbSavePath.LastIndexOf('.')) != -1)
                {
                    this.currentFileName = Settings.tbSavePath.Substring(0, dotPos) + "_" + dts +
                        Settings.tbSavePath.Substring(dotPos);
                }
                else
                {
                    this.currentFileName = Settings.tbSavePath + "_" + dts;
                }
            }
            else
            {
                this.currentFileName = Settings.tbSavePath;
            }
        }

        private void OpenFile()
        {
            this.SetCurrentFile();
            this.fs = new FileStream(this.currentFileName, FileMode.OpenOrCreate, FileAccess.Write);
            this.sw = new BinaryWriter(this.fs);
        }

        public void Write(byte[] bytes, int length)
        {

            try
            {
                this.CheckFileSize();
                this.sw.Write(bytes,0,length);
                this.sw.Flush();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Close()
        {
            if (this.sw != null)
            {
                this.sw.Close();
            }
            if(this.fs != null)
                this.fs.Close();
        }

        private void CheckFileSize()
        {
            try
            {
                
                if (File.Exists(this.currentFileName) )
                {
                    FileInfo fi = new FileInfo(this.currentFileName);
                    double maxfs = Settings.nudSplit * Math.Pow(2, (Settings.cbUnits * 10));
                    if (Settings.chbSplit && maxfs > 0 && fi.Length > maxfs)
                    {
                        this.OpenFile();
                    }
                }
                else if (!File.Exists(this.currentFileName))
                {
                    this.OpenFile();
                } 
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
