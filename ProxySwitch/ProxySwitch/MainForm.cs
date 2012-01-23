using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ProxySwitch
{
    public partial class MainForm : Form
    {
        // Import wininet.dll to allow us to refresh Internet Settings
        // without exiting the web browser.
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        string proxyAddress;
        string proxyPort;
        string proxyException;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Keep the MainForm hidden
            if (FormWindowState.Minimized == WindowState)
                Hide();

            // Automatic updates
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void psOnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Config.xml"))
                {
                    // Load the XML configuration
                    XmlDocument loadDoc = new XmlDocument();
                    loadDoc.Load(Application.StartupPath + "\\Config.xml");

                    // Required XML Settings to strings
                    proxyAddress = loadDoc.SelectSingleNode("/configuration/address").Attributes["url"].InnerText;
                    proxyPort = loadDoc.SelectSingleNode("/configuration/port").Attributes["value"].InnerText;
                    proxyException = loadDoc.SelectSingleNode("/configuration/exceptions").Attributes["value"].InnerText;

                    {
                        // Open registry keys needed
                        RegistryKey internetSettings = Registry.CurrentUser.OpenSubKey
                            ("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

                        // Write settings to the registry
                        internetSettings.SetValue("ProxyEnable", 1);
                        internetSettings.SetValue("ProxyServer", (proxyAddress) + ":" + (proxyPort));
                        internetSettings.SetValue("ProxyOverride", (proxyException));

                        // Close the registry keys used
                        internetSettings.Close();

                        // Refresh the internet settings using Wininet.dll
                        // This allows the proxy change to register
                        InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                        InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    }

                    MessageBox.Show("The proxy settings have now been turned on!", "Successful!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Here is the hacky part...
                    // For some reason when we refresh the internet settings it will only refresh once
                    // Therefore we restart the whole application silently
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("The configuration file could not be found! Please contact the system administrator", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SystemException errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void psOffButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Config.xml"))
                {
                    {
                        // Open registry keys needed
                        RegistryKey internetSettings = Registry.CurrentUser.OpenSubKey
                            ("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

                        // Write settings to the registry
                        internetSettings.SetValue("ProxyEnable", 0);

                        // Close the registry keys used
                        internetSettings.Close();

                        // Refresh the internet settings using Wininet.dll
                        // This allows the proxy change to register
                        InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                        InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    }

                    MessageBox.Show("The proxy settings have now been turned off!", "Successful!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Here is the hacky part...
                    // For some reason when we refresh the internet settings it will only refresh once
                    // Therefore we restart the whole application silently
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("The configuration file could not be found! Please contact the system administrator", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SystemException errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void psAboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void psExitButton_Click(object sender, EventArgs e)
        {
            // Close ProxySwitch
            Application.Exit();
        }
    }
}
