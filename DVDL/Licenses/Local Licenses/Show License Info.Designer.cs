namespace DVLDPresentationLayer.Licenses.Local_Licenses
{
    partial class frmShowLicenseInfo
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
            this.usctrlDriverLicenseInfo1 = new DVLDPresentationLayer.User_Controls.usctrlDriverLicenseInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTilte = new System.Windows.Forms.PictureBox();
            this.brnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTilte)).BeginInit();
            this.SuspendLayout();
            // 
            // usctrlDriverLicenseInfo1
            // 
            this.usctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlDriverLicenseInfo1.Location = new System.Drawing.Point(8, 205);
            this.usctrlDriverLicenseInfo1.Name = "usctrlDriverLicenseInfo1";
            this.usctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1024, 451);
            this.usctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(392, 167);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Driver License Info";
            // 
            // pbTilte
            // 
            this.pbTilte.Image = global::DVLDPresentationLayer.Properties.Resources.LicenseView_400;
            this.pbTilte.Location = new System.Drawing.Point(451, 0);
            this.pbTilte.Name = "pbTilte";
            this.pbTilte.Size = new System.Drawing.Size(178, 164);
            this.pbTilte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTilte.TabIndex = 2;
            this.pbTilte.TabStop = false;
            // 
            // brnClose
            // 
            this.brnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.brnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnClose.Location = new System.Drawing.Point(867, 662);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(162, 42);
            this.brnClose.TabIndex = 86;
            this.brnClose.Text = "Close";
            this.brnClose.UseVisualStyleBackColor = true;
            // 
            // frmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 714);
            this.Controls.Add(this.brnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbTilte);
            this.Controls.Add(this.usctrlDriverLicenseInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicenseInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbTilte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.usctrlDriverLicenseInfo usctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTilte;
        private System.Windows.Forms.Button brnClose;
    }
}