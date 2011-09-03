using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProxySwitch
{
    // Used for displaying the Git head info in
    // the application for debugging purposes.
    [AttributeUsage(AttributeTargets.Assembly)]
    public class AssemblyGitBuild : Attribute
    {
        public string gitBuild { get; private set; }
        public AssemblyGitBuild(string txt) { gitBuild = txt; }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
