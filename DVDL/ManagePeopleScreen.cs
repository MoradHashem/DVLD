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
    public partial class ManagePeopleScreen : Form
    {
        public ManagePeopleScreen()
        {
            InitializeComponent();
        }


        private void _RefrashPeopleList()
        {
            dgvListPeople.DataSource = clsPeople.ListPeople();

            lblCount.Text = dgvListPeople.RowCount.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _RefrashPeopleList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            
        }
    }
}
