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
        private DataTable _AllUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _AllUsers = clsUsers.GetAllUsers();
            dgvShowUserList.DataSource = _AllUsers;


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
        }
    }
}
