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

namespace DVLDPresentationLayer.Applocations.Local_Driving_License
{
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;


        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicense();

            frm.ShowDialog();
            frmManageLocalDrivingLicenseApplications_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplication();
            dgvListLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;
            lblCount.Text = dgvListLocalDrivingLicenseApplications.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if(dgvListLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvListLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.LAppID";
                dgvListLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvListLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvListLocalDrivingLicenseApplications.Columns[1].Width = 215;

                dgvListLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
                dgvListLocalDrivingLicenseApplications.Columns[2].Width = 120;

                dgvListLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvListLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvListLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvListLocalDrivingLicenseApplications.Columns[4].Width = 160;

                dgvListLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Test";
                dgvListLocalDrivingLicenseApplications.Columns[5].Width = 100;

                dgvListLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvListLocalDrivingLicenseApplications.Columns[6].Width = 100;   
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;

                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "";
                    break;
            }


            if (FilterColumn == "None" || txtFilter.Text.Trim() == "")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblCount.Text = dgvListLocalDrivingLicenseApplications.Rows.Count.ToString();

                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text = dgvListLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.LAppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilterBy.Text != "None");
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvListLocalDrivingLicenseApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value;

            Form frm = new frmLocalDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID);

            frm.ShowDialog();
        }

        
    }
}
