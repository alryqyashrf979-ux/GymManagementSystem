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
       private DataTable _dtPeople = new DataTable();

        void _RefreshDataTable()
        {
            _dtPeople = clsPeople.GetAllPeople();

            dgvShowPeopleList.DataSource = _dtPeople;
            lblRecord.Text = dgvShowPeopleList.Rows.Count.ToString();
        }

      
        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = !(cmSelectTypeOfFiltering.Text == "None"||cmSelectTypeOfFiltering.Text=="Gender");
            cmGender.Visible = cmSelectTypeOfFiltering.Text == "Gender";

            _dtPeople.DefaultView.RowFilter = "";

            if (txtFiltering.Visible)
            {
                txtFiltering.Focus();
            }
            lblRecord.Text = _dtPeople.Rows.Count.ToString();

        }
        StringBuilder FilteringName = new StringBuilder();

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

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

             

             

            }


            if(txtFiltering.Text=="")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecord.Text = _dtPeople.Rows.Count.ToString();

                return;
            }


            if (cmSelectTypeOfFiltering.Text == "Person ID")
                _dtPeople.DefaultView.RowFilter = $"{FilteringName.ToString()} = '{txtFiltering.Text}'";
            else
                _dtPeople.DefaultView.RowFilter = $"{FilteringName.ToString()} Like '{txtFiltering.Text}%'";

            lblRecord.Text = _dtPeople.DefaultView.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmSelectTypeOfFiltering.Text=="Person ID" || cmSelectTypeOfFiltering.Text == "Phone")
            {

                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
               
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshDataTable();

        }

        private void PersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dgvShowPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshDataTable();
        }

        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Index =(int) dgvShowPeopleList.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Person [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsPeople.DeletePerson(Index))
            {
                MessageBox.Show("Person deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataTable();
            }
            else
                    MessageBox.Show("Person was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvShowPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDataTable();
        }

        private void cmGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmGender.Text =="All")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecord.Text = dgvShowPeopleList.Rows.Count.ToString();
                return;
            }

                _dtPeople.DefaultView.RowFilter = $"{cmSelectTypeOfFiltering.Text} like '{cmGender.Text}%'";
            lblRecord.Text = dgvShowPeopleList.Rows.Count.ToString();

        }
    }
}
