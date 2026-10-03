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
    public partial class frmUserInformation : Form
    {
        private int _UserID;
        private int _PersonID;

        public frmUserInformation(int UserID, int PersonID)
        {
            InitializeComponent();

            _UserID = UserID;
            _PersonID = PersonID;
            _LoadData();
        }

        private void _LoadData()
        {
            usctrlLoginInformation1.LoadUserInfo(_UserID);
            usctrlPersonDetails1.LoadPersonInfo(_PersonID);

        }

        private void User_Information_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
