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
    public partial class usctrlLoginInformation : UserControl
    {
        public int UserID = -1;
        private clsUsers _User;



        public void LoadUserInfo(int UserID)
        {
            this.UserID = UserID;

            _LoadData();
        }

        public usctrlLoginInformation()
        {
            InitializeComponent();
        }


        private void _LoadData()
        {
            _User = clsUsers.FindUserByID(UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because no User with " + UserID);
                this.FindForm().Close();

                return;
            }


            lblUserIDValue.Text = _User.UserID.ToString();
            lblUserNameValue.Text = _User.UserName;
            lblIsActiveValue.Text = _User.IsActive.ToString();

        }

        private void usctrlLoginInformation_Load(object sender, EventArgs e)
        {
            if (UserID <= 0)
                return;

            _LoadData();
        }
    }
}
