namespace DVLDPresentationLayer
{
    partial class frmAddEditNewUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcAddNewUser = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.usctrlFilter1 = new DVLDPresentationLayer.usctrlFilter();
            this.usctrlPersonDetails1 = new DVLDPresentationLayer.usctrlPersonDetails();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.ptrUserID = new System.Windows.Forms.PictureBox();
            this.ptrUserName = new System.Windows.Forms.PictureBox();
            this.ptrPassword = new System.Windows.Forms.PictureBox();
            this.ptrConfirmPassword = new System.Windows.Forms.PictureBox();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ckIsActive = new System.Windows.Forms.CheckBox();
            this.tcAddNewUser.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(366, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(624, 659);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 36);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDPresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(781, 659);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 36);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tcAddNewUser
            // 
            this.tcAddNewUser.Controls.Add(this.tpPersonalInfo);
            this.tcAddNewUser.Controls.Add(this.tpLoginInfo);
            this.tcAddNewUser.Location = new System.Drawing.Point(12, 93);
            this.tcAddNewUser.Name = "tcAddNewUser";
            this.tcAddNewUser.SelectedIndex = 0;
            this.tcAddNewUser.Size = new System.Drawing.Size(927, 559);
            this.tcAddNewUser.TabIndex = 42;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.usctrlFilter1);
            this.tpPersonalInfo.Controls.Add(this.usctrlPersonDetails1);
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(919, 530);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // usctrlFilter1
            // 
            this.usctrlFilter1.BackColor = System.Drawing.Color.White;
            this.usctrlFilter1.Location = new System.Drawing.Point(20, 75);
            this.usctrlFilter1.Name = "usctrlFilter1";
            this.usctrlFilter1.Size = new System.Drawing.Size(890, 83);
            this.usctrlFilter1.TabIndex = 43;
            // 
            // usctrlPersonDetails1
            // 
            this.usctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.usctrlPersonDetails1.Location = new System.Drawing.Point(14, 160);
            this.usctrlPersonDetails1.Name = "usctrlPersonDetails1";
            this.usctrlPersonDetails1.Size = new System.Drawing.Size(899, 320);
            this.usctrlPersonDetails1.TabIndex = 44;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLDPresentationLayer.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(752, 482);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(149, 36);
            this.btnNext.TabIndex = 45;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
            this.tpLoginInfo.Controls.Add(this.ckIsActive);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.lblUserIDValue);
            this.tpLoginInfo.Controls.Add(this.ptrConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.ptrPassword);
            this.tpLoginInfo.Controls.Add(this.ptrUserName);
            this.tpLoginInfo.Controls.Add(this.ptrUserID);
            this.tpLoginInfo.Controls.Add(this.lblConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.lblPassword);
            this.tpLoginInfo.Controls.Add(this.lblUserName);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(919, 530);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(116, 68);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(74, 18);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(91, 112);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(100, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(37, 195);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(153, 18);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // ptrUserID
            // 
            this.ptrUserID.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrUserID.Location = new System.Drawing.Point(211, 68);
            this.ptrUserID.Margin = new System.Windows.Forms.Padding(4);
            this.ptrUserID.Name = "ptrUserID";
            this.ptrUserID.Size = new System.Drawing.Size(22, 23);
            this.ptrUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrUserID.TabIndex = 19;
            this.ptrUserID.TabStop = false;
            // 
            // ptrUserName
            // 
            this.ptrUserName.Image = global::DVLDPresentationLayer.Properties.Resources.Person_32;
            this.ptrUserName.Location = new System.Drawing.Point(211, 112);
            this.ptrUserName.Margin = new System.Windows.Forms.Padding(4);
            this.ptrUserName.Name = "ptrUserName";
            this.ptrUserName.Size = new System.Drawing.Size(22, 23);
            this.ptrUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrUserName.TabIndex = 21;
            this.ptrUserName.TabStop = false;
            // 
            // ptrPassword
            // 
            this.ptrPassword.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrPassword.Location = new System.Drawing.Point(211, 154);
            this.ptrPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptrPassword.Name = "ptrPassword";
            this.ptrPassword.Size = new System.Drawing.Size(22, 23);
            this.ptrPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrPassword.TabIndex = 22;
            this.ptrPassword.TabStop = false;
            // 
            // ptrConfirmPassword
            // 
            this.ptrConfirmPassword.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrConfirmPassword.Location = new System.Drawing.Point(211, 195);
            this.ptrConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptrConfirmPassword.Name = "ptrConfirmPassword";
            this.ptrConfirmPassword.Size = new System.Drawing.Size(22, 23);
            this.ptrConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrConfirmPassword.TabIndex = 23;
            this.ptrConfirmPassword.TabStop = false;
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.Location = new System.Drawing.Point(262, 70);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(35, 16);
            this.lblUserIDValue.TabIndex = 24;
            this.lblUserIDValue.Text = "????";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(265, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 24);
            this.txtUserName.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(265, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 24);
            this.txtPassword.TabIndex = 26;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(265, 194);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(150, 24);
            this.txtConfirmPassword.TabIndex = 27;
            // 
            // ckIsActive
            // 
            this.ckIsActive.AutoSize = true;
            this.ckIsActive.Location = new System.Drawing.Point(265, 250);
            this.ckIsActive.Name = "ckIsActive";
            this.ckIsActive.Size = new System.Drawing.Size(81, 21);
            this.ckIsActive.TabIndex = 28;
            this.ckIsActive.Text = "Is Active";
            this.ckIsActive.UseVisualStyleBackColor = true;
            // 
            // frmAddEditNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 713);
            this.Controls.Add(this.tcAddNewUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit NewUser";
            this.Load += new System.EventHandler(this.frmAddEditNewUser_Load);
            this.tcAddNewUser.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcAddNewUser;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnNext;
        private usctrlPersonDetails usctrlPersonDetails1;
        private usctrlFilter usctrlFilter1;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox ptrUserID;
        private System.Windows.Forms.PictureBox ptrConfirmPassword;
        private System.Windows.Forms.PictureBox ptrPassword;
        private System.Windows.Forms.PictureBox ptrUserName;
        private System.Windows.Forms.CheckBox ckIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserIDValue;
    }
}