namespace DVLDPresentationLayer
{
    partial class frmManageApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvListAplicationTypes = new System.Windows.Forms.DataGridView();
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ptrManageApplicationTypesImage = new System.Windows.Forms.PictureBox();
            this.cmsManageApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrManageApplicationTypesImage)).BeginInit();
            this.cmsManageApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(109, 723);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 18);
            this.lblCount.TabIndex = 23;
            this.lblCount.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(9, 723);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 18);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "# Records :";
            // 
            // dgvListAplicationTypes
            // 
            this.dgvListAplicationTypes.AllowUserToAddRows = false;
            this.dgvListAplicationTypes.AllowUserToDeleteRows = false;
            this.dgvListAplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListAplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListAplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListAplicationTypes.Location = new System.Drawing.Point(12, 292);
            this.dgvListAplicationTypes.MultiSelect = false;
            this.dgvListAplicationTypes.Name = "dgvListAplicationTypes";
            this.dgvListAplicationTypes.ReadOnly = true;
            this.dgvListAplicationTypes.RowHeadersWidth = 51;
            this.dgvListAplicationTypes.RowTemplate.Height = 26;
            this.dgvListAplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAplicationTypes.Size = new System.Drawing.Size(776, 412);
            this.dgvListAplicationTypes.TabIndex = 20;
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApplicationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(193, 216);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(402, 38);
            this.lblManageApplicationTypes.TabIndex = 19;
            this.lblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(665, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptrManageApplicationTypesImage
            // 
            this.ptrManageApplicationTypesImage.Image = global::DVLDPresentationLayer.Properties.Resources.Application_Types_512;
            this.ptrManageApplicationTypesImage.Location = new System.Drawing.Point(279, 13);
            this.ptrManageApplicationTypesImage.Name = "ptrManageApplicationTypesImage";
            this.ptrManageApplicationTypesImage.Size = new System.Drawing.Size(208, 200);
            this.ptrManageApplicationTypesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrManageApplicationTypesImage.TabIndex = 18;
            this.ptrManageApplicationTypesImage.TabStop = false;
            // 
            // cmsManageApplicationTypes
            // 
            this.cmsManageApplicationTypes.BackColor = System.Drawing.Color.White;
            this.cmsManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditApplicationType});
            this.cmsManageApplicationTypes.Name = "cmsManagePeople";
            this.cmsManageApplicationTypes.Size = new System.Drawing.Size(237, 70);
            // 
            // tsmiEditApplicationType
            // 
            this.tsmiEditApplicationType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEditApplicationType.Image = global::DVLDPresentationLayer.Properties.Resources.edit_32;
            this.tsmiEditApplicationType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditApplicationType.Name = "tsmiEditApplicationType";
            this.tsmiEditApplicationType.Size = new System.Drawing.Size(236, 38);
            this.tsmiEditApplicationType.Text = "Edit Application Type";
            this.tsmiEditApplicationType.Click += new System.EventHandler(this.tsmiEditApplicationType_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.ContextMenuStrip = this.cmsManageApplicationTypes;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListAplicationTypes);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.ptrManageApplicationTypesImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrManageApplicationTypesImage)).EndInit();
            this.cmsManageApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListAplicationTypes;
        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.PictureBox ptrManageApplicationTypesImage;
        private System.Windows.Forms.ContextMenuStrip cmsManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplicationType;
    }
}