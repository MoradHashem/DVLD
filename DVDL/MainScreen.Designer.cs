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
            this.Main = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Azure;
            this.Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.Main.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Main.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.applicationToolStripMenuItem,
            this.cToolStripMenuItem});
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(171, 654);
            this.Main.TabIndex = 1;
            this.Main.Text = "msMain";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(158, 84);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(158, 84);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(158, 84);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationToolStripMenuItem.Image")));
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(158, 84);
            this.applicationToolStripMenuItem.Text = "Applications";
            this.applicationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cToolStripMenuItem.Image")));
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(158, 84);
            this.cToolStripMenuItem.Text = "Account Settings";
            this.cToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(171, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1297, 654);
            this.pnlMain.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1468, 654);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Main;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DVDL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}

