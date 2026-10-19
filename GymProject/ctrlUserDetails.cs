using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinessLayer;

namespace GymMangementSystem
{
    public partial class ctrlUserDetails : UserControl
    {
       private clsUsers _User;
        public ctrlUserDetails()
        {
            InitializeComponent();
          
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                MessageBox.Show($"No user with user id = {UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uctPersonDetails1.LoadPersonInfo(_User.PersonID);
            lblUsername.Text = _User.UserName;
            lblUserID.Text = UserID.ToString();
            if (_User.IsActive)
                lblsActive.Text = "Yes";
            else
                lblsActive.Text = "No";
        }
        private void ctrlUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
