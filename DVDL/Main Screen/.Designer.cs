namespace DVLDPresentationLayer
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1460, 72);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.applicationsToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.peopleToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(138, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.driversToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(140, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usersToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(131, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserInfo,
            this.tsmiChangePassword,
            this.toolStripSeparator1,
            this.tsmiSignOut});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.accountSettingsToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(213, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // tsmiCurrentUserInfo
            // 
            this.tsmiCurrentUserInfo.Image = global::DVLDPresentationLayer.Properties.Resources.PersonDetails_321;
            this.tsmiCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            this.tsmiCurrentUserInfo.Size = new System.Drawing.Size(239, 38);
            this.tsmiCurrentUserInfo.Text = "Current User Info";
            this.tsmiCurrentUserInfo.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Image = global::DVLDPresentationLayer.Properties.Resources.Password_32;
            this.tsmiChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(239, 38);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.Image = global::DVLDPresentationLayer.Properties.Resources.sign_out_32__2;
            this.tsmiSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(239, 38);
            this.tsmiSignOut.Text = "Sign Out";
            this.tsmiSignOut.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 717);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainScreen";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
    }
}