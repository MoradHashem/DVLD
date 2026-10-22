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
    public partial class frmUpdateTestTypes : Form
    {

        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private clsTestTypes _TestType;


        public frmUpdateTestTypes(clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private bool ValidateRequiredFields()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                erpMessage.SetError(txtTitle, "Title is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtTitle, "");
            }

            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                erpMessage.SetError(txtFees, "Fees is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtFees, "");
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                erpMessage.SetError(txtDescription, "Description is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtDescription, "");
            }

            return IsValid;
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypes.Find(_TestTypeID);

            if (_TestType != null)
            {
                lblTestTypeID.Text = _TestTypeID.ToString();
                txtTitle.Text = _TestType.TestTypeTitle;
                txtDescription.Text = _TestType.TestTypeDescription;
                txtFees.Text = _TestType.TestTypeFees.ToString();
            }
            else
            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToDouble(txtFees.Text);

            
            if(_TestType.Save())
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                erpMessage.SetError(txtTitle, "Title is required.");
                
            }
            else
            {
                erpMessage.SetError(txtTitle, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                erpMessage.SetError(txtDescription, "Description is required.");
                
            }
            else
            {
                erpMessage.SetError(txtDescription, "");
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                erpMessage.SetError(txtFees, "Fees is required.");
            }
            else
            {
                erpMessage.SetError(txtFees, "");
            }

            if (!clsValidatoin.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                erpMessage.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                erpMessage.SetError(txtFees, null);
            }
        }
    }
}
