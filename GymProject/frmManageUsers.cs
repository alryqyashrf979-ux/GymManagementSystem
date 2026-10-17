using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DataBusinessLayer;

namespace GymMangementSystem
{
    public partial class frmManageUsers : Form
    {
      static  private DataTable _AllUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _AllUsers = clsUsers.GetAllUsers();
            dgvShowUserList.DataSource = _AllUsers;
            cbValue.SelectedIndex = 0;

            if (dgvShowUserList.Rows.Count > 0)
            {
                dgvShowUserList.Columns[0].HeaderText = "User ID";
                dgvShowUserList.Columns[0].Width = 70;

                dgvShowUserList.Columns[1].HeaderText = "Person ID";
                dgvShowUserList.Columns[1].Width = 90;

                dgvShowUserList.Columns[2].HeaderText = "Full Name";
                dgvShowUserList.Columns[2].Width = 300;

                dgvShowUserList.Columns[3].HeaderText = "User Name";
                dgvShowUserList.Columns[3].Width = 100;

                dgvShowUserList.Columns[4].HeaderText = "Is Active";
                dgvShowUserList.Columns[4].Width = 100;
            }

            lblRecord.Text = dgvShowUserList.Rows.Count.ToString() ;
            tbSearch.Visible = !(cbValue.Text == "None" || cbValue.Text == "Is Active");
            cbIsActive.Visible = (cbValue.Text == "Is Active");


        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Clear();
            tbSearch.Visible = !(cbValue.Text == "None"||cbValue.Text=="Is Active");
            cbIsActive.Visible = (cbValue.Text == "Is Active");

            if (cbValue.Visible)
            {
                tbSearch.Focus();
            }
            lblRecord.Text = dgvShowUserList.Rows.Count.ToString();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            StringBuilder Filtering = new StringBuilder();

            switch (cbValue.Text)
            {
                case "User ID":
                    Filtering.Append( "UserID");
                    break;

                case "Person ID":
                    Filtering.Append( "PersonID");
                    break;

                case "User Name":
                    Filtering.Append("UserName");
                    break;

                case "Full Name":
                    Filtering.Append("FullName");
                    break;

                case "Is Active":
                    Filtering.Append("IsActive");
                    break;
            }

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvShowUserList.Rows.Count.ToString();
                return;
            }

            if (cbValue.Text == "User ID" || cbValue.Text == "Person ID")
                _AllUsers.DefaultView.RowFilter = $"{Filtering}='{tbSearch.Text.Trim()}'";
            else
                _AllUsers.DefaultView.RowFilter = $"{Filtering} like '{tbSearch.Text.Trim()}%'";

            lblRecord.Text = dgvShowUserList.Rows.Count.ToString();



        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbValue.Text == "User ID" || cbValue.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.Text)
            {
                case "Yes":
                    _AllUsers.DefaultView.RowFilter = $"IsActive=1";
                    break;

                case "No":
                    _AllUsers.DefaultView.RowFilter = $"IsActive=0";
                    break;

                default:
                    _AllUsers.DefaultView.RowFilter = "";
                    break;
            }

            lblRecord.Text = dgvShowUserList.Rows.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }
    }
}
