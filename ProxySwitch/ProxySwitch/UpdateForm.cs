using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Xml;

namespace ProxySwitch
{
    public partial class UpdateForm : Form
    {
        string updateAddress;
        string autoUpdates;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        public UpdateForm()
        {
            InitializeComponent();

            psUpdateWorker.RunWorkerAsync();
        }

        private void psUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (File.Exists("Config.xml"))
                {
                    // Load the XML configuration
                    XmlDocument loadDoc = new XmlDocument();
                    loadDoc.Load(Application.StartupPath + "\\Config.xml");

                    // Required XML Settings to strings
                    updateAddress = loadDoc.SelectSingleNode("/configuration/update").Attributes["url"].InnerText;
                    autoUpdates = loadDoc.SelectSingleNode("/configuration/autoupdates").Attributes["value"].InnerText;

                    string updateFile = updateAddress + "update.exe";

                    if (autoUpdates == "1")
                    {
                        // Check version of local file and current supported version
                        string versionURL = updateAddress + "update/version.txt";

                        WebClient vClient = new WebClient();
                        string result = vClient.DownloadString(versionURL);

                        if (result.Contains("ProxySwitch_v1.2"))
                        {
                            // Do nothing
                        }
                        else
                        {
                            // Update local version to server version
                            // A better way of doing this silently needs to be used
                            DialogResult updateResult = MessageBox.Show("A update for Proxy Switch avaliable! Would you like to download the latest version?", "Update Avaliable!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (updateResult == DialogResult.Yes)
                            {
                                Application.Exit();

                                WebClient client = new WebClient();
                                client.DownloadFileCompleted +=
                                    new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                                client.DownloadFileAsync(new Uri(updateFile), @"update.exe");
                            }
                            else if (updateResult == DialogResult.No)
                            {
                                // Do nothing
                            }
                        }
                    }
                    else
                    {
                        // Do nothing
                    }
                }
            }
            catch (System.Exception)
            {
                // Do nothing
                // this stops the errors when proxy settings not active
            }
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"update.exe");

            System.Diagnostics.Process.Start(@"ProxySwitch.exe");

            MessageBox.Show("ProxySwitch has been updated!", "Complete!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
