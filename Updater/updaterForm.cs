using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;

namespace Updater
{
    public partial class updaterForm : Form
    {
        private readonly string VERSION;
        private Thread thread;
        private delegate void UpdateProgressDelegate(int percent);
        private delegate void SetProgressMaxDelegate(int max);
        private delegate void SetFileNameDelegate(string filename);
        private delegate void UpdateTotalProgressDelegate(int percent);
        private delegate void SetTotalProgressMaxDelegate(int max);
        private int total = 0;
        private int currFileSize = 0;
        private AutoResetEvent evt = new AutoResetEvent(false);
        private bool Done = false;

        public updaterForm(string[] args)
        {
            this.VERSION = args[0];
            InitializeComponent();
            thread = new Thread(new ThreadStart(this.Update));
            thread.Start();
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            total += currFileSize;
            evt.Set();
        }

        private void UpdateProgress(int downloaded)
        {
            progress.Value = downloaded;
            lblDownloaded.Text = FormatBytes(downloaded) + " / " + FormatBytes(progress.Maximum);
        }

        private void SetProgressMax(int max)
        {
            progress.Maximum = max;
        }

        private void UpdateTotalProgress(int downloaded)
        {
            progressTotal.Value = total + downloaded;
            lblTotal.Text = "Total: " + (int)((double)progressTotal.Value / progressTotal.Maximum * 100) + " %";
        }

        private void SetTotalProgressMax(int max)
        {
            progressTotal.Maximum = max;
        }

        private void SetFileName(string filename)
        {
            this.lblFile.Text = filename;
        }

        private void OnDownload(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                this.Invoke(new UpdateProgressDelegate(UpdateProgress), new object[] { (int)e.BytesReceived });
                this.Invoke(new UpdateTotalProgressDelegate(UpdateTotalProgress), new object[] { (int)e.BytesReceived });
            }
            catch (Exception) { }
        }

        private void OnCopy(long TotalCopyed, ref bool Cancel)
        {
            try
            {
                this.Invoke(new UpdateProgressDelegate(UpdateProgress), new object[] { (int)TotalCopyed });
                this.Invoke(new UpdateTotalProgressDelegate(UpdateTotalProgress), new object[] { (int)TotalCopyed });
            }
            catch (Exception) { }
        }

        private void OnCopyCompleted()
        {
            total += currFileSize;
            evt.Set();
        }

        private void Update()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load("http://php.sektor.hu/?version=" + VERSION);
            XmlElement doc = XMLDoc.DocumentElement;

            bool updatable = false;
            List<UFile> files = new List<UFile>();
            int totalFileSize = 0;

            foreach (XmlElement el in doc.ChildNodes)
            {
                if (el.Name == "updateavailable" && el.InnerText == "true")
                {
                    updatable = true;
                }

                if (el.Name == "files" && el.HasChildNodes)
                {
                    foreach (XmlElement fe in el.ChildNodes)
                    {
                        UFile file = new UFile(fe.InnerText, int.Parse(fe.Attributes["size"].Value));
                        totalFileSize += int.Parse(fe.Attributes["size"].Value);
                        files.Add(file);
                    }
                }
            }

            if (updatable)
            {
                this.Invoke(new SetTotalProgressMaxDelegate(SetTotalProgressMax), new object[] { totalFileSize * 2 });

                if (!File.Exists(Path.GetTempPath() + "\\PHPExecuter") || (File.GetAttributes(Path.GetTempPath() + "\\PHPExecuter") & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    Directory.CreateDirectory(Path.GetTempPath() + "\\PHPExecuter");
                }

                foreach (UFile file in files)
                {
                    this.Invoke(new SetFileNameDelegate(SetFileName), new object[] { file.fileName });
                    this.Invoke(new SetProgressMaxDelegate(SetProgressMax), new object[] { file.fileSize });

                    currFileSize = file.fileSize;

                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnDownload);
                    webClient.DownloadFileAsync(new Uri(file.filePath), Path.GetTempPath() + "\\PHPExecuter\\" + file.fileName);
                    evt.WaitOne();
                }

                foreach (UFile file in files)
                {

                    this.Invoke(new SetFileNameDelegate(SetFileName), new object[] { file.fileName });
                    this.Invoke(new SetProgressMaxDelegate(SetProgressMax), new object[] { file.fileSize });

                    currFileSize = file.fileSize;

                    if (File.Exists(file.fileName))
                    {
                        File.Delete(file.fileName);
                    }

                    Copy copy = new Copy(Path.GetTempPath() + "\\PHPExecuter\\" + file.fileName, file.fileName);
                    copy.OnProgressChanged += new ProgressChangeDelegate(OnCopy);
                    copy.OnComplete += new Completedelegate(OnCopyCompleted);
                    copy.StartCopy();
                    evt.WaitOne();
                }

                Done = true;

                if (MessageBox.Show(null, "Update was success! Open PHP Executer?", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Process.Start("PHPExecuter.exe");
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }


            }
            else
            {
                MessageBox.Show(null, "No updates available now!\nUpdater will close!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }

        }

        private void updaterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Done)
            {
                if (MessageBox.Show(this, "Are you sure you want to cancel the update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    thread.Abort();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.00} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 B";
        }

    }
}
