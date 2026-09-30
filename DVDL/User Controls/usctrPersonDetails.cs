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
using DVLDPresentationLayer.Properties;

namespace DVLDPresentationLayer
{
    public partial class usctrlPersonDetails : UserControl
    {
        public usctrlPersonDetails()
        {
            InitializeComponent();
        }

        public int PersonID;
        private clsPeople _Person;



        public void LoadPersonInfo(int PersonID)
        {
            this.PersonID = PersonID;
            _LoadDate();
        }


        private void _LoadDate()
        {
            

            _Person = clsPeople.FindPersonByID(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because no Person with " + PersonID);
                this.FindForm().Close();

                return;
            }


            lblID.Text = PersonID.ToString();
            lblFullName.Text = _Person.FirstName.ToString() + " " + _Person.SecondName.ToString() + " " + _Person.ThirdName.ToString() + " " + _Person.LastName.ToString();
            lblNationalNum.Text = _Person.NationalNo;
            lblEmails.Text = _Person.Email;
            lblAddresss.Text = _Person.Address;
            lblPhones.Text = _Person.Phone;
            lblDateOfBirth1.Text = _Person.DateOfBirth.ToString();
            lblCountries.Text = clsCountry.FindCountryByID(_Person.Country).CountryName;

            if (_Person.Gendor == 0)
            {
                lblGendors.Text = "Male";
            }
            else
                lblGendors.Text = "Female";


            if (!string.IsNullOrEmpty(_Person.ImagePath))
                ptrImage.Load(_Person.ImagePath);

            else
                ptrImage.Image = Resources.Male_512;


        }

       
        private void UserControl1_Load(object sender, EventArgs e)
        {
            ptrImage.Image = Resources.Male_512;

            if (PersonID <= 0)
                return;

            _LoadDate();
        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form frm = new frmAddEditPersonInfo(PersonID);

            frm.ShowDialog();
            _LoadDate();
            
        }

        private void ptrImage_Click(object sender, EventArgs e)
        {

        }

        private void gbPersonInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
