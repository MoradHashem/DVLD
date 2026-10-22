using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDPresentationLayer.Test.Test_Types
{
    public partial class frmManageTestTypes : Form
    {

        private DataTable _AllTestTypes;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _AllTestTypes = clsTestTypes.GetAllTestTypes();
            dgvListTestTypes.DataSource = _AllTestTypes;
            lblCount.Text = dgvListTestTypes.Rows.Count.ToString();

            if (dgvListTestTypes.Rows.Count > 0)
            {
                dgvListTestTypes.Columns[0].HeaderText = "ID";
                dgvListTestTypes.Columns[0].Width = 70;

                dgvListTestTypes.Columns[1].HeaderText = "Title";
                dgvListTestTypes.Columns[1].Width = 170;

                dgvListTestTypes.Columns[2].HeaderText = "Description";
                dgvListTestTypes.Columns[2].Width = 300;

                dgvListTestTypes.Columns[3].HeaderText = "Fees";
                dgvListTestTypes.Columns[3].Width = 72;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditTestType_Click(object sender, EventArgs e)
        {
            clsTestTypes.enTestType TestTypeID = (clsTestTypes.enTestType)dgvListTestTypes.CurrentRow.Cells["TestTypeID"].Value;

            Form frm = new frmUpdateTestTypes(TestTypeID);

            frm.ShowDialog();
            frmManageTestTypes_Load(null, null);
        }
    }
}
