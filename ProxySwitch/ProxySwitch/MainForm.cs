using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProxySwitch
{
    public partial class MainForm : Form
    {
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
