using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLDBusinessLayer;
using DVLDPresentationLayer.Properties;
using System.Runtime.ConstrainedExecution;

namespace DVLDPresentationLayer
{
    public partial class frmAddEditPersonInfo : Form
    {
        public enum enGendor { Male = 0, Female = 1 };

        public enum enMode { AddNew = 0, Update = 1};
        
        
        private enMode _Mode;
        private int _PersonID = -1;
        private clsPeople _Person;


        public delegate void DataBackEvenHandler(object sender, int PersonID);

        public event DataBackEvenHandler DataBack;




        public frmAddEditPersonInfo()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.Update;
            
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }
        }
            
        private void _LoadData()
        {

            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblID.Text = _PersonID.ToString();
            txtFirst.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.Gendor == 0)
            {
                rdbMale.Checked = true;
            }
            else
                rdbFemale.Checked = true;


            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                
            }


            lnkRemove.Visible = (pbPersonImage.Image != null);


        }

        private void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPeople();
            }
            else
                lblTitle.Text = "Update Person";
            

            lnkRemove.Visible = (pbPersonImage.Image != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);


            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");

            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFirst.Text = "";
            txtLast.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtSecond.Text = "";
            txtThird.Text = "";
            rdbMale.Checked = true;
            
            
            if (rdbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

        }

        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if(_Mode == enMode.Update)
                _LoadData();    
        }

        private void grbAllControls_Enter(object sender, EventArgs e)
        {

        }

        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                lnkRemove.Visible = true;
            }
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rdbFemale.Checked)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.Image = Resources.Male_512;

            lnkRemove.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;


            int NationalityCountryID = clsCountry.Find(cbCountry.Text).ID;

            _Person.FirstName = txtFirst.Text;
            _Person.SecondName = txtSecond.Text;
            _Person.ThirdName = txtThird.Text;
            _Person.LastName = txtLast.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.NationalityCountryID = NationalityCountryID;

            if (rdbFemale.Checked)
                _Person.Gendor = (byte)enGendor.Female;
            else
                _Person.Gendor = (byte)enGendor.Male;


            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                lblID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Update Person";
                DataBack?.Invoke(this, _Person.PersonID);

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool ValidateRequiredFields()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(txtFirst.Text))
            {
                erpMessage.SetError(txtFirst, "First name is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtFirst, "");
            }


            if (string.IsNullOrWhiteSpace(txtSecond.Text))
            {
                erpMessage.SetError(txtSecond, "Second name is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtSecond, "");
            }


            if (string.IsNullOrWhiteSpace(txtThird.Text))
            {
                erpMessage.SetError(txtThird, "Third name is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtThird, "");
            }


            if (string.IsNullOrWhiteSpace(txtLast.Text))
            {
                erpMessage.SetError(txtLast, "Last name is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtLast, "");
            }


            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                erpMessage.SetError(txtNationalNo, "National Number is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtNationalNo, "");
            }


            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                erpMessage.SetError(txtPhone, "Phone is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtPhone, "");
            }


            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                erpMessage.SetError(txtAddress, "Address is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(txtAddress, "");
            }


            if (string.IsNullOrWhiteSpace(cbCountry.Text))
            {
                erpMessage.SetError(cbCountry, "Country is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(cbCountry, "");
            }


            return IsValid;
        }

        private void ValidateTextBox(TextBox textBox, string Message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                erpMessage.SetError(textBox, Message);
            else
                erpMessage.SetError(textBox, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                erpMessage.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                erpMessage.SetError(txtEmail, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                erpMessage.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPeople.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                erpMessage.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                erpMessage.SetError(txtNationalNo, null);
            }
        }

        private bool _HandlePersonImage()
        {

            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirst_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtFirst, "First Name is required.");
        }

        private void txtSecond_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtSecond, "Second Name is required.");
        }

        private void txtLast_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtLast, "Last Name is required.");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtAddress, "Address is required.");
        }
    }
}
