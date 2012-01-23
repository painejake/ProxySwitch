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
        string updateURL;
        string result;
        string updateAddress;
        string autoUpdates;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            psUpdateWorker.RunWorkerAsync();

            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        public UpdateForm()
        {
            InitializeComponent();
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

                    if (autoUpdates == "1")
                    {
                        // Do update
                    }
                    else
                    {
                        // Do nothing
                    }
                }
            }
            catch (System.Exception)
            {
                // do nothing
                // this stops the errors when proxy settings not active
            }
        }
    }
}
