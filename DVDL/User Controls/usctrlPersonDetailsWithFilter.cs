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
    public partial class usctrlPersonDetailsWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }

            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }


        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }

            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _PersonID = -1;
        public int PersonID
        { 
            get { return usctrlPersonDetails1.PersonID; }
        }


        public clsPeople SelectedPerson
        {
            get { return usctrlPersonDetails1.SelectedPersonInfo; }
        }


        public usctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int PersonID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();

            FindNow();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterValue.Text = NationalNo;

            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilters.Text)
            {
                case "Person ID":
                    usctrlPersonDetails1.LoadPersonInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "National No":
                    usctrlPersonDetails1.LoadPersonInfo(txtFilterValue.Text);

                    break;


                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(usctrlPersonDetails1.PersonID);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo();

            frm.DataBack += DataBackEvent;

            frm.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            usctrlPersonDetails1.LoadPersonInfo(PersonID);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                errorProvider1.SetError(txtFilterValue, "This field is required!");
                return false;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
                return true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!ValidateRequiredFields())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void usctrlPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                errorProvider1.SetError(txtFilterValue, "This field is required!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            if (cbFilters.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}