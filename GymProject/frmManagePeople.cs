using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDataTable();
        }
        DataTable dtPeople = new DataTable();

        void _RefreshDataTable()
        {
            dtPeople = clsPeople.GetAllPeople();

            dgvShowPeopleList.DataSource = dtPeople;
        }

        private void dgvShowPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None");

            dtPeople.DefaultView.RowFilter = "";

            if (txtFiltering.Visible)
            {
                txtFiltering.Focus();
            }
            lblRecord.Text = dtPeople.Rows.Count.ToString();

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

            StringBuilder FilteringName=new StringBuilder();
            FilteringName.Clear();
            //FilteringName.Append("");

            switch (cmSelectTypeOfFiltering.Text)
            {
                
                case "Full Name":
                    FilteringName.Append("FullName");
                    break;
                case "Phone":
                    FilteringName.Append("PhoneNumber");
                    break;
                case "Email":
                    FilteringName.Append("Email");
                    break;

                case "Person ID":
                    FilteringName.Append("ID");
                    break;
                case "Nationality":
                    FilteringName.Append("Country");
                    break;

                case "National No.":
                    FilteringName.Append("NationalID");
                    break;

                case "Address":
                    FilteringName.Append("Address");
                    break;

                case "Gender":
                    FilteringName.Append("Gender");
                    break;

             

            }


            if(txtFiltering.Text=="")
            {
                dtPeople.DefaultView.RowFilter = "";
                lblRecord.Text = dtPeople.Rows.Count.ToString();

                return;
            }


            if (cmSelectTypeOfFiltering.Text == "Person ID")
                dtPeople.DefaultView.RowFilter = $"{FilteringName.ToString()} = '{txtFiltering.Text}'";
            else
                dtPeople.DefaultView.RowFilter = $"{FilteringName.ToString()} Like '{txtFiltering.Text}%'";

            lblRecord.Text = dtPeople.DefaultView.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
