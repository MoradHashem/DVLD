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

namespace DVLDPresentationLayer
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _dtAllPeople = clsPeople.ListPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

        public frmManagePeople()
        {
            InitializeComponent();

        }


        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPeople.ListPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvListPeople.DataSource = _dtPeople;

            lblCount.Text = dgvListPeople.RowCount.ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();
            
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvListPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblCount.Text = dgvListPeople.Rows.Count.ToString();
            txtFilter.Visible = false;

            if(dgvListPeople.Rows.Count > 0)
            {

                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[0].Width = 80;
                   
                dgvListPeople.Columns[1].HeaderText = "National No.";
                dgvListPeople.Columns[1].Width = 120;
                   
                   
                dgvListPeople.Columns[2].HeaderText = "First Name";
                dgvListPeople.Columns[2].Width = 100;
                   
                dgvListPeople.Columns[3].HeaderText = "Second Name";
                dgvListPeople.Columns[3].Width = 100;
                   
                   
                dgvListPeople.Columns[4].HeaderText = "Third Name";
                dgvListPeople.Columns[4].Width = 100;
                   
                dgvListPeople.Columns[5].HeaderText = "Last Name";
                dgvListPeople.Columns[5].Width = 100;
                   
                dgvListPeople.Columns[6].HeaderText = "Gendor";
                dgvListPeople.Columns[6].Width = 50;
                   
                dgvListPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvListPeople.Columns[7].Width = 140;
                   
                dgvListPeople.Columns[8].HeaderText = "Nationality";
                dgvListPeople.Columns[8].Width = 90;
                   
                   
                dgvListPeople.Columns[9].HeaderText = "Phone";
                dgvListPeople.Columns[9].Width = 90;
                   
                   
                dgvListPeople.Columns[10].HeaderText = "Email";
                dgvListPeople.Columns[10].Width = 140;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (txtFilter.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblCount.Text = _dtPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());


            lblCount.Text = _dtPeople.Rows.Count.ToString();

            

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
            {
                 if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;

            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells["PersonID"].Value;

            Form frm = new frmAddEditPersonInfo(PersonID);

            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells["PersonID"].Value;

            if (MessageBox.Show($"Are you sure you want to delete person [{PersonID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsPeople.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();

            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells["PersonID"].Value;

            Form frm = new frmPersonDetails(PersonID);

            frm.ShowDialog();
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvListPeople_DoubleClick(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells["PersonID"].Value;

            Form frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }
    }
}
