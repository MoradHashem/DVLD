namespace DVLDPresentationLayer.Test
{
    partial class frmListTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.dgvListAppointments = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usctrlLocalDrivingLicenseApplicationInfo1 = new DVLDPresentationLayer.User_Controls.usctrlLocalDrivingLicenseApplicationInfo();
            this.cmsListTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddAppointments = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ptTitle = new System.Windows.Forms.PictureBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).BeginInit();
            this.cmsListTestAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(259, 142);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 38);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(12, 596);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(119, 18);
            this.lblAppointments.TabIndex = 35;
            this.lblAppointments.Text = "Appointments :";
            // 
            // dgvListAppointments
            // 
            this.dgvListAppointments.AllowUserToAddRows = false;
            this.dgvListAppointments.AllowUserToDeleteRows = false;
            this.dgvListAppointments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAppointments.ContextMenuStrip = this.cmsListTestAppointments;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListAppointments.Location = new System.Drawing.Point(12, 632);
            this.dgvListAppointments.MultiSelect = false;
            this.dgvListAppointments.Name = "dgvListAppointments";
            this.dgvListAppointments.ReadOnly = true;
            this.dgvListAppointments.RowHeadersWidth = 51;
            this.dgvListAppointments.RowTemplate.Height = 26;
            this.dgvListAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAppointments.Size = new System.Drawing.Size(904, 194);
            this.dgvListAppointments.TabIndex = 36;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(-392, 849);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 18);
            this.lblCount.TabIndex = 39;
            this.lblCount.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(-492, 849);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 18);
            this.lblRecords.TabIndex = 38;
            this.lblRecords.Text = "# Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 848);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 848);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "# Records :";
            // 
            // usctrlLocalDrivingLicenseApplicationInfo1
            // 
            this.usctrlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 179);
            this.usctrlLocalDrivingLicenseApplicationInfo1.Name = "usctrlLocalDrivingLicenseApplicationInfo1";
            this.usctrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(904, 410);
            this.usctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 43;
            // 
            // cmsListTestAppointments
            // 
            this.cmsListTestAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsListTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsListTestAppointments.Name = "cmsListTestAppointments";
            this.cmsListTestAppointments.Size = new System.Drawing.Size(227, 108);
            // 
            // btnAddAppointments
            // 
            this.btnAddAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointments.Image = global::DVLDPresentationLayer.Properties.Resources.AddAppointment_32;
            this.btnAddAppointments.Location = new System.Drawing.Point(855, 582);
            this.btnAddAppointments.Name = "btnAddAppointments";
            this.btnAddAppointments.Size = new System.Drawing.Size(61, 46);
            this.btnAddAppointments.TabIndex = 44;
            this.btnAddAppointments.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(795, 835);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ptTitle
            // 
            this.ptTitle.Image = global::DVLDPresentationLayer.Properties.Resources.Vision_512;
            this.ptTitle.Location = new System.Drawing.Point(374, 0);
            this.ptTitle.Name = "ptTitle";
            this.ptTitle.Size = new System.Drawing.Size(146, 132);
            this.ptTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptTitle.TabIndex = 21;
            this.ptTitle.TabStop = false;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLDPresentationLayer.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 889);
            this.Controls.Add(this.btnAddAppointments);
            this.Controls.Add(this.usctrlLocalDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListAppointments);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.ptTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Test Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).EndInit();
            this.cmsListTestAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.DataGridView dgvListAppointments;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private User_Controls.usctrlLocalDrivingLicenseApplicationInfo usctrlLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnAddAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsListTestAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}