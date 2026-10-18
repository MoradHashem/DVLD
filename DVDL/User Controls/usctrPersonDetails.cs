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
using System.IO;


namespace DVLDPresentationLayer
{
    public partial class usctrlPersonDetails : UserControl
    {
        public usctrlPersonDetails()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;
        private clsPeople _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }


        public clsPeople SelectedPersonInfo
        {
            get { return _Person; }
        }


        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblID.Text = "[????]";
            lblNationalNum.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendors.Text = "[????]";
            lblEmails.Text = "[????]";
            lblPhones.Text = "[????]";
            lblDateOfBirth1.Text = "[????]";
            lblCountries.Text = "[????]";
            lblAddresss.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;
        }


        private void _FillPersonInfo()
        {
            lnkEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblID.Text = _PersonID.ToString();
            lblNationalNum.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FullName;
            lblGendors.Text = _Person.Gendor == 0 ? "Male" : "Femal";
            lblEmails.Text = _Person.Email;
            lblPhones.Text = _Person.Phone;
            lblDateOfBirth1.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountries.Text = _Person.CountryInfo.CountryName;
            lblAddresss.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

            _LoadPersonImage();
        }


        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }


        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }


        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;


            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form frm = new frmAddEditPersonInfo(_PersonID);

            frm.ShowDialog();

            LoadPersonInfo(_PersonID);            
        }

    }
}
