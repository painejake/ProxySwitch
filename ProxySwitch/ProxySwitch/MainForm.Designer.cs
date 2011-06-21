namespace ProxySwitch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.psMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnProxySettingsOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProxySwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.psIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.psMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // psMenu
            // 
            this.psMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.turnProxySettingsOffToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutProxySwitchToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.psMenu.Name = "psMenu";
            this.psMenu.Size = new System.Drawing.Size(194, 104);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Turn proxy settings on";
            // 
            // turnProxySettingsOffToolStripMenuItem
            // 
            this.turnProxySettingsOffToolStripMenuItem.Name = "turnProxySettingsOffToolStripMenuItem";
            this.turnProxySettingsOffToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.turnProxySettingsOffToolStripMenuItem.Text = "Turn proxy settings off";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // aboutProxySwitchToolStripMenuItem
            // 
            this.aboutProxySwitchToolStripMenuItem.Name = "aboutProxySwitchToolStripMenuItem";
            this.aboutProxySwitchToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutProxySwitchToolStripMenuItem.Text = "About ProxySwitch";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // psIcon
            // 
            this.psIcon.ContextMenuStrip = this.psMenu;
            this.psIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("psIcon.Icon")));
            this.psIcon.Text = "notifyIcon1";
            this.psIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(273, 93);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.psMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip psMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnProxySettingsOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutProxySwitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon psIcon;
    }
}

