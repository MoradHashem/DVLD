using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class frmAddEditPersonInfo : Form
    {
        public enum _Mode { AddNew = 0, Update = 1};
        private _Mode Mode;

        private int _PersonID = -1;


        public delegate void DataBackEvenHandler(object sender, int PersonID);

        public event DataBackEvenHandler DataBack;


        public int GetPersonID()
        {
            return _PersonID;
        }


        private void _MakeMode(int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
                Mode = _Mode.AddNew;
            else
                Mode = _Mode.Update;

            if (Mode == _Mode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                usctrlAddEditPersonInfo1.PersonID = -1;
            }
            else
            {
                lblTitle.Text = "Edit Person Info";
                lblID.Text = PersonID.ToString();
                usctrlAddEditPersonInfo1.PersonID = _PersonID;
            }
        }


        public frmAddEditPersonInfo()
        {
            InitializeComponent();

            _MakeMode(-1);
        }

        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();


            _MakeMode(PersonID);
            
        }

        private void frmAddEditPersonInfo_DataBack(object sender, int PersonID)
        {
            lblID.Text = PersonID.ToString();
            lblTitle.Text = "Edit Person Info";
            DataBack?.Invoke(this, PersonID);
        }

        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            usctrlAddEditPersonInfo1.DataBack += frmAddEditPersonInfo_DataBack;
        }

     
    }
}
