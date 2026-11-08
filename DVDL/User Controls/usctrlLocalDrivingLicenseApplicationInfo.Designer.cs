namespace DVLDPresentationLayer.User_Controls
{
    partial class usctrlLocalDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDrivingLicenseApplicationID = new System.Windows.Forms.Label();
            this.lblDLAID = new System.Windows.Forms.Label();
            this.lblAppliedForLicense = new System.Windows.Forms.Label();
            this.lblAppliedForLicenseValue = new System.Windows.Forms.Label();
            this.lblPassed = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.lnkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbDrivingLIcenseApplicationInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptrID = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptAppliedForLicense = new System.Windows.Forms.PictureBox();
            this.usctrlApplicationBasicInfo1 = new DVLDPresentationLayer.User_Controls.usctrlApplicationBasicInfo();
            this.gbDrivingLIcenseApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAppliedForLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDrivingLicenseApplicationID
            // 
            this.lblDrivingLicenseApplicationID.AutoSize = true;
            this.lblDrivingLicenseApplicationID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLicenseApplicationID.Location = new System.Drawing.Point(11, 34);
            this.lblDrivingLicenseApplicationID.Name = "lblDrivingLicenseApplicationID";
            this.lblDrivingLicenseApplicationID.Size = new System.Drawing.Size(97, 18);
            this.lblDrivingLicenseApplicationID.TabIndex = 19;
            this.lblDrivingLicenseApplicationID.Text = "D.L.App ID :";
            // 
            // lblDLAID
            // 
            this.lblDLAID.AutoSize = true;
            this.lblDLAID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAID.Location = new System.Drawing.Point(171, 34);
            this.lblDLAID.Name = "lblDLAID";
            this.lblDLAID.Size = new System.Drawing.Size(18, 18);
            this.lblDLAID.TabIndex = 21;
            this.lblDLAID.Text = "0";
            // 
            // lblAppliedForLicense
            // 
            this.lblAppliedForLicense.AutoSize = true;
            this.lblAppliedForLicense.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedForLicense.Location = new System.Drawing.Point(335, 34);
            this.lblAppliedForLicense.Name = "lblAppliedForLicense";
            this.lblAppliedForLicense.Size = new System.Drawing.Size(163, 18);
            this.lblAppliedForLicense.TabIndex = 22;
            this.lblAppliedForLicense.Text = "Applied For License :";
            // 
            // lblAppliedForLicenseValue
            // 
            this.lblAppliedForLicenseValue.AutoSize = true;
            this.lblAppliedForLicenseValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedForLicenseValue.Location = new System.Drawing.Point(564, 34);
            this.lblAppliedForLicenseValue.Name = "lblAppliedForLicenseValue";
            this.lblAppliedForLicenseValue.Size = new System.Drawing.Size(49, 18);
            this.lblAppliedForLicenseValue.TabIndex = 24;
            this.lblAppliedForLicenseValue.Text = "[???]";
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassed.Location = new System.Drawing.Point(384, 85);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(114, 18);
            this.lblPassed.TabIndex = 25;
            this.lblPassed.Text = "Passed Tests :";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTests.Location = new System.Drawing.Point(564, 85);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(49, 18);
            this.lblPassedTests.TabIndex = 26;
            this.lblPassedTests.Text = "[???]";
            // 
            // lnkShowLicenseInfo
            // 
            this.lnkShowLicenseInfo.AutoSize = true;
            this.lnkShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowLicenseInfo.Location = new System.Drawing.Point(174, 90);
            this.lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            this.lnkShowLicenseInfo.Size = new System.Drawing.Size(126, 18);
            this.lnkShowLicenseInfo.TabIndex = 29;
            this.lnkShowLicenseInfo.TabStop = true;
            this.lnkShowLicenseInfo.Text = "Show License Info";
            this.lnkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseInfo_LinkClicked);
            // 
            // gbDrivingLIcenseApplicationInfo
            // 
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblDLAID);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lnkShowLicenseInfo);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblDrivingLicenseApplicationID);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.pictureBox2);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.ptrID);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.pictureBox1);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblAppliedForLicense);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblPassedTests);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.ptAppliedForLicense);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblPassed);
            this.gbDrivingLIcenseApplicationInfo.Controls.Add(this.lblAppliedForLicenseValue);
            this.gbDrivingLIcenseApplicationInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrivingLIcenseApplicationInfo.Location = new System.Drawing.Point(3, 3);
            this.gbDrivingLIcenseApplicationInfo.Name = "gbDrivingLIcenseApplicationInfo";
            this.gbDrivingLIcenseApplicationInfo.Size = new System.Drawing.Size(898, 136);
            this.gbDrivingLIcenseApplicationInfo.TabIndex = 30;
            this.gbDrivingLIcenseApplicationInfo.TabStop = false;
            this.gbDrivingLIcenseApplicationInfo.Text = "Driving LIcense Application Info";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDPresentationLayer.Properties.Resources.License_View_32;
            this.pictureBox2.Location = new System.Drawing.Point(128, 85);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // ptrID
            // 
            this.ptrID.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrID.Location = new System.Drawing.Point(128, 34);
            this.ptrID.Margin = new System.Windows.Forms.Padding(4);
            this.ptrID.Name = "ptrID";
            this.ptrID.Size = new System.Drawing.Size(22, 23);
            this.ptrID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrID.TabIndex = 20;
            this.ptrID.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDPresentationLayer.Properties.Resources.PassedTests_32;
            this.pictureBox1.Location = new System.Drawing.Point(518, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // ptAppliedForLicense
            // 
            this.ptAppliedForLicense.Image = global::DVLDPresentationLayer.Properties.Resources.Lost_Driving_License_32;
            this.ptAppliedForLicense.Location = new System.Drawing.Point(518, 34);
            this.ptAppliedForLicense.Margin = new System.Windows.Forms.Padding(4);
            this.ptAppliedForLicense.Name = "ptAppliedForLicense";
            this.ptAppliedForLicense.Size = new System.Drawing.Size(22, 23);
            this.ptAppliedForLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptAppliedForLicense.TabIndex = 23;
            this.ptAppliedForLicense.TabStop = false;
            // 
            // usctrlApplicationBasicInfo1
            // 
            this.usctrlApplicationBasicInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlApplicationBasicInfo1.Location = new System.Drawing.Point(0, 142);
            this.usctrlApplicationBasicInfo1.Name = "usctrlApplicationBasicInfo1";
            this.usctrlApplicationBasicInfo1.Size = new System.Drawing.Size(906, 261);
            this.usctrlApplicationBasicInfo1.TabIndex = 31;
            // 
            // usctrlLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usctrlApplicationBasicInfo1);
            this.Controls.Add(this.gbDrivingLIcenseApplicationInfo);
            this.Name = "usctrlLocalDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(904, 405);
            this.gbDrivingLIcenseApplicationInfo.ResumeLayout(false);
            this.gbDrivingLIcenseApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptAppliedForLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrID;
        private System.Windows.Forms.Label lblDrivingLicenseApplicationID;
        private System.Windows.Forms.Label lblDLAID;
        private System.Windows.Forms.Label lblAppliedForLicense;
        private System.Windows.Forms.PictureBox ptAppliedForLicense;
        private System.Windows.Forms.Label lblAppliedForLicenseValue;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnkShowLicenseInfo;
        private System.Windows.Forms.GroupBox gbDrivingLIcenseApplicationInfo;
        private usctrlApplicationBasicInfo usctrlApplicationBasicInfo1;
    }
}
