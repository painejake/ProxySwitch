using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProxySwitch
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            // Get current git hash to a string for identifying builds
            string gitBuild = "unknown";
            try
            {
                gitBuild = typeof(AssemblyGitBuild).Assembly.GetCustomAttributes(typeof(AssemblyGitBuild), false).Cast<AssemblyGitBuild>().First().gitBuild;
            }
            catch (Exception errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();
            string cpuArchType;
            Version buildVersion = new Version(Application.ProductVersion);
            cpuArchType = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            buildInfo.Text = ("Build Info: ProxySwitch" + "_v" + buildVersion.Major + "." + buildVersion.Minor + "_Win_" + cpuArchType + "_hash:" + gitBuild);
        }

        private void psSourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/painejake/ProxySwitch");
            }
            catch (SystemException errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void psLicenceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/painejake/ProxySwitch/blob/master/LICENCE.md");
            }
            catch (SystemException errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void psIssueLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/painejake/ProxySwitch/issues");
            }
            catch (SystemException errorCode)
            {
                MessageBox.Show(errorCode.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
