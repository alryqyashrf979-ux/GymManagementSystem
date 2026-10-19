using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ctrlUserDetails1.LoadUserInfo(UserID);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
           
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsHashing.Hashing(txtCurrentPassword.Text) != ctrlUserDetails1.UserInfo.Password)
                errorProvider1.SetError(txtCurrentPassword, "Current password is not correct !");
            else
                errorProvider1.SetError(txtCurrentPassword, "");
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
                errorProvider1.SetError(txtConfirmPassword, "Confirm password does not match new password !");
            else
                errorProvider1.SetError(txtConfirmPassword, "");
        }

        private void _ResetDefaultValues()
        {
            txtNewPassword.Clear();
            txtCurrentPassword.Clear();
            txtConfirmPassword.Clear();
            txtCurrentPassword.Focus();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUsers.ChangePassword(_UserID, clsHashing.Hashing(txtConfirmPassword.Text)))
            {
                _ResetDefaultValues();
                MessageBox.Show("Password changed successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Faild to change Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void frmChangePassword_Activated(object sender, EventArgs e)
        {
            txtCurrentPassword.Focus();

        }
    }
}
