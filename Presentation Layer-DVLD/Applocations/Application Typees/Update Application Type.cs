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
    public partial class frmUpdateApplicationType : Form
    {
        private clsApplicationTypes _ApplicationType;
        private int _ApplicationTypeID;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
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

            return IsValid;
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();
            _ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
                txtFees.Text = _ApplicationType.ApplicationFees.ToString();
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplicationType.ApplicationTypeTitle = txtTitle.Text;
            _ApplicationType.ApplicationFees = Convert.ToDouble(txtFees.Text);

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            };
        }
    }
}
