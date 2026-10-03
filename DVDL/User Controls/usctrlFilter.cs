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
    public partial class usctrlFilter : UserControl
    {
        public clsPeople Person;


        public delegate void PersonFoundEventHandler(object sender, int PersonID);

        public event PersonFoundEventHandler PersonFound;



        public void SetPersonIDIntxtFind(int PersonID)
        {
            txtFind.Text = PersonID.ToString();
        }

        public usctrlFilter()
        {
            InitializeComponent();
        }

        private bool SearchForPerson(string FilterValue)
        {

            if (string.IsNullOrWhiteSpace(FilterValue))
                return false;


            if ((Person = clsPeople.FindPersonByID(Convert.ToInt32(FilterValue))) == null)
            {

                MessageBox.Show($"No Person with ID = {FilterValue}");
                return false;
            }

            return true;

        }


        private void FillPersonDetails_DataBack(object sender, int PersonID)
        {
            txtFind.Text = PersonID.ToString();

            

        }


        private void usctrlFilter_Load(object sender, EventArgs e)
        {
            cmbFindBy.SelectedIndex = 0;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo(-1);

            frm.DataBack += FillPersonDetails_DataBack;

            frm.ShowDialog();
            PersonFound?.Invoke(this, Convert.ToInt32(txtFind.Text));
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        { 


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchForPerson(txtFind.Text.Trim()))
                PersonFound?.Invoke(this, Person.PersonID);
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
