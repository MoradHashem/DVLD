namespace DVLDPresentationLayer
{
    partial class frmChangePassword
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
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.ptrCurrentPassword = new System.Windows.Forms.PictureBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.ptrNewPassword = new System.Windows.Forms.PictureBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ptrConfirmPassword = new System.Windows.Forms.PictureBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.usctrlPersonDetails1 = new DVLDPresentationLayer.usctrlPersonDetails();
            this.usctrlLoginInformation1 = new DVLDPresentationLayer.usctrlLoginInformation();
            this.erpMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptrCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(38, 469);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(151, 18);
            this.lblCurrentPassword.TabIndex = 11;
            this.lblCurrentPassword.Text = "Current Password :";
            // 
            // ptrCurrentPassword
            // 
            this.ptrCurrentPassword.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrCurrentPassword.Location = new System.Drawing.Point(215, 469);
            this.ptrCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptrCurrentPassword.Name = "ptrCurrentPassword";
            this.ptrCurrentPassword.Size = new System.Drawing.Size(22, 23);
            this.ptrCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrCurrentPassword.TabIndex = 20;
            this.ptrCurrentPassword.TabStop = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(253, 469);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(171, 24);
            this.txtCurrentPassword.TabIndex = 21;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(253, 511);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(171, 24);
            this.txtNewPassword.TabIndex = 24;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // ptrNewPassword
            // 
            this.ptrNewPassword.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrNewPassword.Location = new System.Drawing.Point(215, 511);
            this.ptrNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptrNewPassword.Name = "ptrNewPassword";
            this.ptrNewPassword.Size = new System.Drawing.Size(22, 23);
            this.ptrNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrNewPassword.TabIndex = 23;
            this.ptrNewPassword.TabStop = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(61, 516);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(128, 18);
            this.lblNewPassword.TabIndex = 22;
            this.lblNewPassword.Text = "New Password :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(253, 556);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(171, 24);
            this.txtConfirmPassword.TabIndex = 27;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // ptrConfirmPassword
            // 
            this.ptrConfirmPassword.Image = global::DVLDPresentationLayer.Properties.Resources.Number_32;
            this.ptrConfirmPassword.Location = new System.Drawing.Point(215, 556);
            this.ptrConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptrConfirmPassword.Name = "ptrConfirmPassword";
            this.ptrConfirmPassword.Size = new System.Drawing.Size(22, 23);
            this.ptrConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrConfirmPassword.TabIndex = 26;
            this.ptrConfirmPassword.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(36, 556);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(153, 18);
            this.lblConfirmPassword.TabIndex = 25;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDPresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(745, 669);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 36);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(588, 669);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 36);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // usctrlPersonDetails1
            // 
            this.usctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.usctrlPersonDetails1.Location = new System.Drawing.Point(12, 12);
            this.usctrlPersonDetails1.Name = "usctrlPersonDetails1";
            this.usctrlPersonDetails1.Size = new System.Drawing.Size(899, 320);
            this.usctrlPersonDetails1.TabIndex = 3;
            // 
            // usctrlLoginInformation1
            // 
            this.usctrlLoginInformation1.BackColor = System.Drawing.Color.White;
            this.usctrlLoginInformation1.Location = new System.Drawing.Point(20, 325);
            this.usctrlLoginInformation1.Name = "usctrlLoginInformation1";
            this.usctrlLoginInformation1.Size = new System.Drawing.Size(891, 92);
            this.usctrlLoginInformation1.TabIndex = 2;
            // 
            // erpMessage
            // 
            this.erpMessage.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 732);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.ptrConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.ptrNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.ptrCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.usctrlPersonDetails1);
            this.Controls.Add(this.usctrlLoginInformation1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usctrlPersonDetails usctrlPersonDetails1;
        private usctrlLoginInformation usctrlLoginInformation1;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.PictureBox ptrCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox ptrNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox ptrConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider erpMessage;
    }
}