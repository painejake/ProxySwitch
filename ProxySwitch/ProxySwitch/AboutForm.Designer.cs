namespace ProxySwitch
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.desLabel = new System.Windows.Forms.Label();
            this.psSourceLink = new System.Windows.Forms.LinkLabel();
            this.psLicenceLink = new System.Windows.Forms.LinkLabel();
            this.psIssueLink = new System.Windows.Forms.LinkLabel();
            this.buildInfo = new System.Windows.Forms.Label();
            this.aboutLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Location = new System.Drawing.Point(6, 76);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(296, 130);
            this.desLabel.TabIndex = 1;
            this.desLabel.Text = resources.GetString("desLabel.Text");
            // 
            // psSourceLink
            // 
            this.psSourceLink.AutoSize = true;
            this.psSourceLink.Location = new System.Drawing.Point(6, 238);
            this.psSourceLink.Name = "psSourceLink";
            this.psSourceLink.Size = new System.Drawing.Size(69, 13);
            this.psSourceLink.TabIndex = 2;
            this.psSourceLink.TabStop = true;
            this.psSourceLink.Text = "Source Code";
            this.psSourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.psSourceLink_LinkClicked);
            // 
            // psLicenceLink
            // 
            this.psLicenceLink.AutoSize = true;
            this.psLicenceLink.Location = new System.Drawing.Point(110, 238);
            this.psLicenceLink.Name = "psLicenceLink";
            this.psLicenceLink.Size = new System.Drawing.Size(80, 13);
            this.psLicenceLink.TabIndex = 3;
            this.psLicenceLink.TabStop = true;
            this.psLicenceLink.Text = "Licence Details";
            this.psLicenceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.psLicenceLink_LinkClicked);
            // 
            // psIssueLink
            // 
            this.psIssueLink.AutoSize = true;
            this.psIssueLink.Location = new System.Drawing.Point(222, 238);
            this.psIssueLink.Name = "psIssueLink";
            this.psIssueLink.Size = new System.Drawing.Size(72, 13);
            this.psIssueLink.TabIndex = 4;
            this.psIssueLink.TabStop = true;
            this.psIssueLink.Text = "Issue Tracker";
            this.psIssueLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.psIssueLink_LinkClicked);
            // 
            // buildInfo
            // 
            this.buildInfo.AutoSize = true;
            this.buildInfo.Location = new System.Drawing.Point(6, 216);
            this.buildInfo.Name = "buildInfo";
            this.buildInfo.Size = new System.Drawing.Size(47, 13);
            this.buildInfo.TabIndex = 5;
            this.buildInfo.Text = "buildInfo";
            // 
            // aboutLogo
            // 
            this.aboutLogo.BackgroundImage = global::ProxySwitch.Properties.Resources.ProxySwitchLogo;
            this.aboutLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutLogo.Location = new System.Drawing.Point(0, 0);
            this.aboutLogo.Name = "aboutLogo";
            this.aboutLogo.Size = new System.Drawing.Size(305, 75);
            this.aboutLogo.TabIndex = 6;
            this.aboutLogo.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 263);
            this.Controls.Add(this.aboutLogo);
            this.Controls.Add(this.buildInfo);
            this.Controls.Add(this.psIssueLink);
            this.Controls.Add(this.psLicenceLink);
            this.Controls.Add(this.psSourceLink);
            this.Controls.Add(this.desLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ProxySwitch";
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.LinkLabel psSourceLink;
        private System.Windows.Forms.LinkLabel psLicenceLink;
        private System.Windows.Forms.LinkLabel psIssueLink;
        private System.Windows.Forms.Label buildInfo;
        private System.Windows.Forms.PictureBox aboutLogo;
    }
}