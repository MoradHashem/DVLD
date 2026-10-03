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

        private DataTable _dtPeople;


        public frmManagePeople()
        {
            InitializeComponent();

            _RefrashPeopleList();
        }


        private void _RefrashPeopleList()
        {
            _dtPeople = clsPeople.ListPeople();

            dgvListPeople.DataSource = _dtPeople;
            dgvListPeople.Columns["NationalityCountryID"].HeaderText = "Nationality";

            lblCount.Text = dgvListPeople.RowCount.ToString();
        }


        private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();
            
            frm.ShowDialog();
            _RefrashPeopleList();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefrashPeopleList();

            txtFilter.Visible = false;
            combFilterBy.SelectedItem = "None";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combFilterBy.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                _RefrashPeopleList();
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            //    string FilterValue = txtFilter.Text.Trim();

            //    switch (combFilterBy.Text)
            //    {

            //        case "PersonID":

            //            if (int.TryParse(FilterValue, out int PersonID))
            //            {
            //                dgvListPeople.DataSource = clsPeople.FindPeopleByPersonID(PersonID);
            //            }

            //            break;


            //        case "NationalNo":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByNationalNo(FilterValue);

            //            break;


            //        case "First Name":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByFirstName(FilterValue);

            //            break;


            //        case "Second Name":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleBySecondName(FilterValue);

            //            break;


            //        case "Third Name":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByThirdName(FilterValue);

            //            break;


            //        case "Last Name":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByLastName(FilterValue);

            //            break;


            //        case "Nationality":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByNationality(clsCountry.FindCountryByCountryName(FilterValue).CountryID);


            //            break;


            //        case "Gendor":

            //            if (FilterValue.Equals("Male", StringComparison.OrdinalIgnoreCase))
            //            {
            //                dgvListPeople.DataSource = clsPeople.FindPeopleByGendor(0);
            //            }
            //            else if (FilterValue.Equals("Female", StringComparison.OrdinalIgnoreCase))
            //            {
            //                dgvListPeople.DataSource = clsPeople.FindPeopleByGendor(1);
            //            }
            //            else
            //            {
            //                dgvListPeople.DataSource = null;
            //            }

            //            break;


            //        case "Phone":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByPhone(FilterValue);

            //            break;


            //        case "Email":

            //            dgvListPeople.DataSource = clsPeople.FindPeopleByEmail(FilterValue);

            //            break;

            //        default :

            //            dgvListPeople.DataSource = null;

            //            break;
            //    }

            //    lblCount.Text = dgvListPeople.RowCount.ToString();


            string FilterValue = txtFilter.Text.Trim();

            if (_dtPeople == null)
                return;

            DataView dvPeople = _dtPeople.DefaultView;

            switch (combFilterBy.Text)
            {
                case "PersonID":

                    if (int.TryParse(FilterValue, out int PersonID))
                        dvPeople.RowFilter = $"PersonID = {PersonID}";

                    break;

                case "NationalNo":

                    dvPeople.RowFilter = $"NationalNo LIKE '{FilterValue}%'";

                    break;

                case "First Name":

                    dvPeople.RowFilter = $"FirstName LIKE '{FilterValue}%'";

                    break;

                case "Second Name":

                    dvPeople.RowFilter = $"SecondName LIKE '{FilterValue}%'";

                    break;

                case "Third Name":

                    dvPeople.RowFilter = $"ThirdName LIKE '{FilterValue}%'";

                    break;

                case "Last Name":

                    dvPeople.RowFilter = $"LastName LIKE '{FilterValue}%'";

                    break;

                case "Nationality":

                    dvPeople.RowFilter = $"NationalityCountryID  LIKE '{FilterValue}%'";

                    break;

                case "Gendor":

                    dvPeople.RowFilter = $"Gendor LIKE '{FilterValue}%'";

                    break;

                case "Phone":

                    dvPeople.RowFilter = $"Phone LIKE '{FilterValue}%'";

                    break;

                case "Email":

                    dvPeople.RowFilter = $"Email LIKE '{FilterValue}%'";

                    break;

                default:

                    dvPeople.RowFilter = "";

                    break;
            }

            dgvListPeople.DataSource = dvPeople;

            lblCount.Text = dgvListPeople.RowCount.ToString();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (combFilterBy.SelectedIndex == 1)
            {
                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells["PersonID"].Value);

            Form frm = new frmAddEditPersonInfo(PersonID);

            frm.ShowDialog();
            _RefrashPeopleList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells["PersonID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete person [{PersonID}]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(clsPeople.DeletePerson(PersonID))
                    MessageBox.Show("Person Deleted Successfully.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _RefrashPeopleList();
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersonInfo();

            frm.ShowDialog();
            _RefrashPeopleList();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells["PersonID"].Value);

            Form frm = new frmPersonDetails(PersonID);

            frm.ShowDialog();
            _RefrashPeopleList();
        }

        private void ptrManagePeopleImage_Click(object sender, EventArgs e)
        {

        }
    }
}
