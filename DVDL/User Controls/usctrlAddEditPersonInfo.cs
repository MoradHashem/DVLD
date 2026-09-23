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

namespace DVLDPresentationLayer
{
    public partial class usctrlAddEditPersonInfo : UserControl
    {
        public enum _enMode { AddNew = 0, Update = 1 };
        private _enMode _Mode;


        public int PersonID;
        private string _Title;
        private string _SelectedImagePath = "";
        private clsPeople _Person;


        public delegate void DataBackEventHandler(object sender, int PersonID, string Title);

        public event DataBackEventHandler DataBack;




        public usctrlAddEditPersonInfo()
        {
            InitializeComponent();

            
        }


        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.ListCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                combCountry.Items.Add(Row["CountryName"]);
            }

            combCountry.SelectedIndex = 190;
        }


        private void _LoadData()
        {

            if (DesignMode)
                return;

            if (PersonID == -1)
                _Mode = _enMode.AddNew;
            else
                _Mode = _enMode.Update;


            _FillCountriesInComboBox();

            rdbMale.Checked = true;
            ptrImage.Image = Resources.Male_512;

            if (_Mode == _enMode.AddNew)
            {
                _Person = new clsPeople();
                lnkRemove.Visible = false;

                return;
            }

            _Person = clsPeople.FindPersonByID(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because no Person with " + PersonID);
                this.FindForm().Close();

                return;
            }


            txtFirst.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            combCountry.SelectedIndex = clsCountry.FindCountryByID(_Person.Country).CountryID - 1;

            if (_Person.Gendor == 0)
            {
                rdbMale.Checked = true;
            }
            else
                rdbFemale.Checked = true;


            if (_Person.ImagePath != "")
            {
                ptrImage.Load(_Person.ImagePath);
                lnkRemove.Visible = true;
            }
            else
                lnkRemove.Visible = false;

            _Person.Mode = (clsPeople._enMode)_Mode;

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


            if (string.IsNullOrWhiteSpace(combCountry.Text))
            {
                erpMessage.SetError(combCountry, "Country is required.");
                IsValid = false;
            }
            else
            {
                erpMessage.SetError(combCountry, "");
            }


            return IsValid;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                MessageBox.Show("There is a Filed is not inputed, Please fill it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            int Country = clsCountry.FindCountryByCountryName(combCountry.Text).CountryID;

            _Person.FirstName = txtFirst.Text;
            _Person.SecondName = txtSecond.Text;
            _Person.ThirdName = txtThird.Text;
            _Person.LastName = txtLast.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Country = Country;

            if (rdbFemale.Checked)
            {
                _Person.Gendor = 1;
            }
            else
                _Person.Gendor = 0;


            string ImagesFolder = @"D:\Programming\C#\Level 19#\DVDL\People Images";


            if (!Directory.Exists(ImagesFolder))
                Directory.CreateDirectory(ImagesFolder);


            if (_SelectedImagePath != "")
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    if (File.Exists(_Person.ImagePath))
                        File.Delete(_Person.ImagePath);
                }


                string FileName = Path.GetFileName(_SelectedImagePath);

                string NewImagePath = Path.Combine(ImagesFolder, FileName);

                File.Copy(_SelectedImagePath, NewImagePath, true);

                _Person.ImagePath = NewImagePath;
            }


            if (_Person.Save())
            {
                MessageBox.Show("Data save successfully.");
            }
            else
                MessageBox.Show("Error : Data is not saved succcessfully.");


            PersonID = _Person.PersonID;
            _Title = "Edit Person Info";

            _Mode = _enMode.Update;

            DataBack?.Invoke(this, PersonID, _Title);
        }

        private void usctrlAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            _LoadData();

            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (ptrImage.Image == null)
                ptrImage.Image = Resources.Female_512;
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (ptrImage.Image == null)
                ptrImage.Image = Resources.Male_512;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();   
        }


        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                erpMessage.SetError(txtEmail, "");
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@gmail\.com$"))
            {
                erpMessage.SetError(txtEmail, "Invalid Email Format.");
            }
            else if (clsPeople.FindPersonByEmail(txtEmail.Text) != null)
            {
                erpMessage.SetError(txtEmail, "This Email is used for another person!");
            }
            else
            {
                erpMessage.SetError(txtEmail, "");
            }


        }



        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();

            OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                _SelectedImagePath = OpenFile.FileName;

                ptrImage.Load(_SelectedImagePath);

            }


            lnkRemove.Visible = true;

        }



        private void ValidateTextBox(TextBox textBox, string Message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                erpMessage.SetError(textBox, Message);
            else
                erpMessage.SetError(textBox, "");
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

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
                erpMessage.SetError(txtNationalNo, "National Number is required.");

            else if (clsPeople.FindPersonByNationalNo(txtNationalNo.Text) != null)
                erpMessage.SetError(txtNationalNo, "National Number is used for another person!");

            else
                erpMessage.SetError(txtNationalNo, "");
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ptrImage.Image = null;

            rdbMale.Checked = true;
            ptrImage.Image = Resources.Male_512;  
            
            lnkRemove.Visible = false;
        }

        private void grbAllControls_Enter(object sender, EventArgs e)
        {

        }
    }
}
