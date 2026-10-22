namespace DVLDPresentationLayer.Test.Test_Types
{
    partial class frmManageTestTypes
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvListTestTypes = new System.Windows.Forms.DataGridView();
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.cmsManageTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.ptrManageTestTypesImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).BeginInit();
            this.cmsManageTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrManageTestTypesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(108, 714);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 18);
            this.lblCount.TabIndex = 29;
            this.lblCount.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(8, 714);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(94, 18);
            this.lblRecords.TabIndex = 28;
            this.lblRecords.Text = "# Records :";
            // 
            // dgvListTestTypes
            // 
            this.dgvListTestTypes.AllowUserToAddRows = false;
            this.dgvListTestTypes.AllowUserToDeleteRows = false;
            this.dgvListTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTestTypes.ContextMenuStrip = this.cmsManageTestTypes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTestTypes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListTestTypes.Location = new System.Drawing.Point(11, 283);
            this.dgvListTestTypes.MultiSelect = false;
            this.dgvListTestTypes.Name = "dgvListTestTypes";
            this.dgvListTestTypes.ReadOnly = true;
            this.dgvListTestTypes.RowHeadersWidth = 51;
            this.dgvListTestTypes.RowTemplate.Height = 26;
            this.dgvListTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTestTypes.Size = new System.Drawing.Size(776, 412);
            this.dgvListTestTypes.TabIndex = 26;
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApplicationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(227, 207);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(297, 38);
            this.lblManageApplicationTypes.TabIndex = 25;
            this.lblManageApplicationTypes.Text = "Manage Test Types";
            // 
            // cmsManageTestTypes
            // 
            this.cmsManageTestTypes.BackColor = System.Drawing.Color.White;
            this.cmsManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageTestTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditApplicationType});
            this.cmsManageTestTypes.Name = "cmsManagePeople";
            this.cmsManageTestTypes.Size = new System.Drawing.Size(186, 42);
            // 
            // tsmiEditApplicationType
            // 
            this.tsmiEditApplicationType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEditApplicationType.Image = global::DVLDPresentationLayer.Properties.Resources.edit_32;
            this.tsmiEditApplicationType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEditApplicationType.Name = "tsmiEditApplicationType";
            this.tsmiEditApplicationType.Size = new System.Drawing.Size(185, 38);
            this.tsmiEditApplicationType.Text = "Edit Test Type";
            this.tsmiEditApplicationType.Click += new System.EventHandler(this.tsmiEditTestType_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(664, 701);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptrManageTestTypesImage
            // 
            this.ptrManageTestTypesImage.Image = global::DVLDPresentationLayer.Properties.Resources.TestType_512;
            this.ptrManageTestTypesImage.Location = new System.Drawing.Point(278, 4);
            this.ptrManageTestTypesImage.Name = "ptrManageTestTypesImage";
            this.ptrManageTestTypesImage.Size = new System.Drawing.Size(208, 200);
            this.ptrManageTestTypesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrManageTestTypesImage.TabIndex = 24;
            this.ptrManageTestTypesImage.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 754);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListTestTypes);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.ptrManageTestTypesImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).EndInit();
            this.cmsManageTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrManageTestTypesImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListTestTypes;
        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.PictureBox ptrManageTestTypesImage;
        private System.Windows.Forms.ContextMenuStrip cmsManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplicationType;
    }
}