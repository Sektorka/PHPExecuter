using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Management;

namespace php
{
    public partial class updateForm : Form
    {
        private Thread thread = null;
        private delegate void CloseFormDelegate();
        private delegate void StartUpdaterDelegate();
        private bool Showed = false;
        private mainForm mf = null;

        public updateForm(mainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        public void StartUpdate()
        {
            thread = new Thread(new ThreadStart(this.Update));
            thread.Start();
        }


        private void CloseForm()
        {
            this.Close();
            this.Dispose();
        }

        private void StartUpdater()
        {
            try
            {
                Process.Start("Updater.exe", Program.VERSION);
                mf.Exit();
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "Failed to start Updater!\n" + e.Message, "Updater", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CloseForm();
            }
        }

        private void Update()
        {
            bool updatable = false;
            XmlDocument XMLDoc = new XmlDocument();
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://php.sektor.hu/");
            try
            {
                string json = "{";
                
                //MachineName
                json += "\"machinename\":\"" + System.Environment.MachineName + "\",";

                //OS
                json += "\"os\":\"" + System.Environment.OSVersion + "\",";

                //UserName
                json += "\"username\":\"" + System.Environment.UserName + "\",";

                //CPU
                ManagementObjectSearcher oCpu = new ManagementObjectSearcher("select * from Win32_Processor");
                json += "\"cpu\":[";
                foreach (ManagementObject objCpu in oCpu.Get())
                {
                    json += "{\"name\":\"" + objCpu.Properties["Name"].Value + "\",\"numberofcores\":\"" + objCpu.Properties["NumberOfCores"].Value + "\",\"numberoflogicalprocessors\":\"" + objCpu.Properties["NumberOfLogicalProcessors"].Value + "\",\"datawidth\":\"" + objCpu.Properties["DataWidth"].Value + "\"},";
                }
                json = json.Substring(0,json.Length-1) + "],";

                //RAM
                json += "\"ram\":[";
                ManagementObjectSearcher oRam = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
                foreach (ManagementObject objRam in oRam.Get())
                {
                    json += "{\"name\":\"" + objRam.Properties["Caption"].Value + "\",\"capacity\":\"" + objRam.Properties["Capacity"].Value + "\",\"speed\":\"" + objRam.Properties["Speed"].Value + "\",\"datawidth\":\"" + objRam.Properties["DataWidth"].Value + "\"},";
                }
                /*json = json.Substring(0, json.Length - 1) + "],";

                //DataStorage
                json += "\"ds\":[";
                ManagementObjectSearcher oDS = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                foreach (ManagementObject objDS in oDS.Get())
                {
                    json += "{\"name\":\"" + objDS.Properties["Caption"].Value + "\",\"size\":\"" + objDS.Properties["Size"].Value + "\",\"interfacetype\":\"" + objDS.Properties["InterfaceType"].Value + "\"},";
                }
                json = json.Substring(0, json.Length - 1) + "],";

                //LogicalDisk
                json += "\"ld\":[";
                ManagementObjectSearcher oLD = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
                foreach (ManagementObject objLD in oLD.Get())
                {
                    json += "{\"caption\":\"" + objLD.Properties["Caption"].Value + "\",\"volumename\":\"" + objLD.Properties["VolumeName"].Value + "\",\"size\":\"" + objLD.Properties["Size"].Value + "\",\"freespace\":\"" + objLD.Properties["FreeSpace"].Value + "\",\"filesystem\":\"" + objLD.Properties["FileSystem"].Value + "\",\"description\":\"" + objLD.Properties["Description"].Value + "\"},";
                }*/
                json = json.Substring(0, json.Length - 1) + "]}";
                json = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(json));

                XMLDoc.LoadXml(this.SendPost("http://php.sektor.hu/?version=" + Program.VERSION, "jsonb64=" + json));
            }
            catch (Exception)
            {
                if (Showed)
                {
                    //MessageBox.Show(null, "Failed check updates!", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    MessageBox.Show(null, "No updates available now!", "PHP Executer :: Updater*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        this.Invoke(new CloseFormDelegate(CloseForm));
                    }
                    catch (Exception) { }
                }
                return;
            }
            XmlElement doc = XMLDoc.DocumentElement;

            string newVersion = "";

            foreach (XmlElement el in doc.ChildNodes)
            {
                if (el.Name == "latestversion")
                {
                    newVersion = el.InnerText;
                }
                if (el.Name == "updateavailable" && el.InnerText == "true")
                {
                    updatable = true;
                }
            }

            if (updatable)
            {

                if (MessageBox.Show(null, "New version available now!\nYour version: v" + Program.VERSION + "\nNew version: v" + newVersion + "\n\nDo you want update now?\n(This program will be closed while updating!)", "PHP Executer :: Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (Showed)
                        this.Invoke(new StartUpdaterDelegate(StartUpdater));
                    else
                        this.StartUpdater();
                }
                else
                {
                    if (Showed)
                        this.Invoke(new CloseFormDelegate(CloseForm));
                }
            }
            else
            {

                if (Showed)
                {
                    MessageBox.Show(null, "No updates available now!", "PHP Executer :: Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //progressBar.ShowInTaskbar = false;
                    this.Invoke(new CloseFormDelegate(CloseForm));
                }
            }
        }


        private void updateForm_Shown(object sender, EventArgs e)
        {
            Showed = true;
            //progressBar.ShowInTaskbar = true;
            StartUpdate();
        }

        private void updateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        private string SendPost(string url, string postData)
        {
            string webpageContent = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                using (Stream webpageStream = webRequest.GetRequestStream())
                {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        webpageContent = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw or return an appropriate response/exception
            }

            return webpageContent;
        }
    }
}
