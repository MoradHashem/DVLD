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
    public partial class frmAddEditLocalDrivingLicense : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        public frmAddEditLocalDrivingLicense()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditLocalDrivingLicense(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillLicenseClassInComboBox()
        {
            DataTable dtLicenseClass = clsLicenseClass.ListLicenseClass();

            foreach (DataRow Row in dtLicenseClass.Rows)
            {
                cbLicenseClass.Items.Add(Row["ClassName"]);
            }

        }

        private void _ResetDefualtValues()
        {

            _FillLicenseClassInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Drining License Application";
                this.Text = "New Local Drining License Application";
                _LocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                tpApplicationInfo.Enabled = false;
                usctrlPersonDetailsWithFilter1.FilterFocus();
                cbLicenseClass.SelectedIndex = 2;
                lblApplicationFeesValue.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
                lblApplicationDateValiue.Text = DateTime.Now.ToShortDateString();
                lblCreateByValue.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblTitle.Text = "Update Local Drining License Application";
                this.Text = "Update Local Drining License Application";

                tpApplicationInfo.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void _LoadData()
        {

            usctrlPersonDetailsWithFilter1.FilterEnabled = false;

            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID);
            
            if (_LocalDrivingLicenseApplications == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            usctrlPersonDetailsWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplications.ApplicantPersonID);
            lblApplicationDateValiue.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplications.ApplicationDate);
            lblApplicationIDValue.Text = _LocalDrivingLicenseApplications.ApplicationID.ToString();
            lblApplicationFeesValue.Text = _LocalDrivingLicenseApplications.PaidFees.ToString();
            lblCreateByValue.Text = clsUsers.FindByUserID(_LocalDrivingLicenseApplications.CreatedByUserID).UserName;
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplications.LicenseClassID).LicenseName);
        }

        private void frmAddEditLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            _SelectedPersonID = PersonID;
            usctrlPersonDetailsWithFilter1.LoadPersonInfo(PersonID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            int LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplications.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);


            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }


            //check if user already have issued license of the same driving  class.
            //if (clsLicense.IsLicenseExistByPersonID(ctrlPersonCardWithFilter1.PersonID, LicenseClassID))
            //{

            //    MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            _LocalDrivingLicenseApplications.ApplicantPersonID = usctrlPersonDetailsWithFilter1.PersonID;
            _LocalDrivingLicenseApplications.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplications.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplications.PaidFees = Convert.ToDouble(lblApplicationFeesValue.Text);
            _LocalDrivingLicenseApplications.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplications.ApplicationStatus = clsApplications.enApplicationStatus.New;
            _LocalDrivingLicenseApplications.LicenseClassID = LicenseClassID;
            _LocalDrivingLicenseApplications.ApplicationTypeID = 1;


            if (_LocalDrivingLicenseApplications.Save())
            {
                lblTitle.Text = "Update Local Drining License Application";
                this.Text = "Update Local Drining License Application";

                _Mode = enMode.Update;
                lblApplicationIDValue.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();

                MessageBox.Show("Data save successfully.");
            }
            else
                MessageBox.Show("Error : Data is not saved succcessfully.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;

                tcNewLocalDrivingLicenseApplication.SelectedTab = tpApplicationInfo;
                return;
            }


            if (usctrlPersonDetailsWithFilter1.PersonID != -1)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcNewLocalDrivingLicenseApplication.SelectedTab = tcNewLocalDrivingLicenseApplication.TabPages["tpApplicationInfo"];

            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usctrlPersonDetailsWithFilter1.FilterFocus();

            }
        }

        private void usctrlPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;

        }

        private void frmAddEditLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            usctrlPersonDetailsWithFilter1.FilterFocus();
        }
    }
}
