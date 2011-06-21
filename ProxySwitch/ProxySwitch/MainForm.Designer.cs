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
            this.psOnButton = new System.Windows.Forms.ToolStripMenuItem();
            this.psOffButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.psAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.psExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.psIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.psMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // psMenu
            // 
            this.psMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.psOnButton,
            this.psOffButton,
            this.toolStripSeparator1,
            this.psAboutButton,
            this.toolStripSeparator2,
            this.psExitButton});
            this.psMenu.Name = "psMenu";
            this.psMenu.Size = new System.Drawing.Size(194, 126);
            // 
            // psOnButton
            // 
            this.psOnButton.Name = "psOnButton";
            this.psOnButton.Size = new System.Drawing.Size(193, 22);
            this.psOnButton.Text = "Turn proxy settings on";
            this.psOnButton.Click += new System.EventHandler(this.psOnButton_Click);
            // 
            // psOffButton
            // 
            this.psOffButton.Name = "psOffButton";
            this.psOffButton.Size = new System.Drawing.Size(193, 22);
            this.psOffButton.Text = "Turn proxy settings off";
            this.psOffButton.Click += new System.EventHandler(this.psOffButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // psAboutButton
            // 
            this.psAboutButton.Name = "psAboutButton";
            this.psAboutButton.Size = new System.Drawing.Size(193, 22);
            this.psAboutButton.Text = "About ProxySwitch";
            this.psAboutButton.Click += new System.EventHandler(this.psAboutButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // psExitButton
            // 
            this.psExitButton.Name = "psExitButton";
            this.psExitButton.Size = new System.Drawing.Size(193, 22);
            this.psExitButton.Text = "Exit";
            this.psExitButton.Click += new System.EventHandler(this.psExitButton_Click);
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
        private System.Windows.Forms.ToolStripMenuItem psOnButton;
        private System.Windows.Forms.ToolStripMenuItem psOffButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem psAboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem psExitButton;
        private System.Windows.Forms.NotifyIcon psIcon;
    }
}

