namespace DVLDPresentationLayer
{
    partial class frmManageUsers
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
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.ptrManagePeopleImage = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.combFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cmbFilterIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrManagePeopleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageUsers.Location = new System.Drawing.Point(348, 215);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(224, 38);
            this.lblManageUsers.TabIndex = 2;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // ptrManagePeopleImage
            // 
            this.ptrManagePeopleImage.Image = global::DVLDPresentationLayer.Properties.Resources.Users_2_400;
            this.ptrManagePeopleImage.Location = new System.Drawing.Point(355, 12);
            this.ptrManagePeopleImage.Name = "ptrManagePeopleImage";
            this.ptrManagePeopleImage.Size = new System.Drawing.Size(208, 200);
            this.ptrManagePeopleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrManagePeopleImage.TabIndex = 1;
            this.ptrManagePeopleImage.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(334, 262);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(222, 24);
            this.txtFilter.TabIndex = 12;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // combFilterBy
            // 
            this.combFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFilterBy.FormattingEnabled = true;
            this.combFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.combFilterBy.Location = new System.Drawing.Point(126, 262);
            this.combFilterBy.Name = "combFilterBy";
            this.combFilterBy.Size = new System.Drawing.Size(199, 24);
            this.combFilterBy.TabIndex = 11;
            this.combFilterBy.SelectedIndexChanged += new System.EventHandler(this.combFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(39, 263);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(81, 18);
            this.lblFilterBy.TabIndex = 10;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(42, 300);
            this.dgvListUsers.MultiSelect = false;
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersWidth = 51;
            this.dgvListUsers.RowTemplate.Height = 26;
            this.dgvListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUsers.Size = new System.Drawing.Size(821, 412);
            this.dgvListUsers.TabIndex = 13;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLDPresentationLayer.Properties.Resources.AddPerson_32;
            this.btnAddUser.Location = new System.Drawing.Point(794, 237);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(69, 49);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 718);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(139, 731);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 18);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(39, 731);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 18);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "# Records :";
            // 
            // cmbFilterIsActive
            // 
            this.cmbFilterIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterIsActive.FormattingEnabled = true;
            this.cmbFilterIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbFilterIsActive.Location = new System.Drawing.Point(334, 262);
            this.cmbFilterIsActive.Name = "cmbFilterIsActive";
            this.cmbFilterIsActive.Size = new System.Drawing.Size(142, 24);
            this.cmbFilterIsActive.TabIndex = 18;
            this.cmbFilterIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbFilterIsActive_SelectedIndexChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 774);
            this.Controls.Add(this.cmbFilterIsActive);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.combFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.ptrManagePeopleImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrManagePeopleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrManagePeopleImage;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox combFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ComboBox cmbFilterIsActive;
    }
}