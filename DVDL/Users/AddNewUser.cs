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
    public partial class frmAddEditNewUser : Form
    {
        public frmAddEditNewUser()
        {
            InitializeComponent();
            
            usctrlFilter1.PersonFound += frmAddNewUser_PersonFound;
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewUser_PersonFound(object sender, int PersonID)
        {
            usctrlPersonDetails1.LoadPersonInfo(PersonID);
        }

        private void frmAddEditNewUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcAddNewUser.SelectedTab = tpLoginInfo;
        }
    }
}
