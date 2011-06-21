using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

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

        private void psOnButton_Click(object sender, EventArgs e)
        {

        }

        private void psOffButton_Click(object sender, EventArgs e)
        {

        }

        private void psAboutButton_Click(object sender, EventArgs e)
        {
            // Show AboutForm
        }

        private void psExitButton_Click(object sender, EventArgs e)
        {
            // Close ProxySwitch
            Application.Exit();
        }
    }
}
