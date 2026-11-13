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

        public clsUsers UserInfo
        {
            get;private set;
        }

        public ctrlUserDetails()
        {
            InitializeComponent();
          
        }

        public void LoadUserInfo(int UserID)
        {
            UserInfo = clsUsers.FindByUserID(UserID);
            if (UserInfo == null)
            {
                MessageBox.Show($"No user with user id = {UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uctPersonDetails1.LoadPersonInfo(UserInfo.PersonID);
            lblUsername.Text = UserInfo.UserName;
            lblUserID.Text = UserID.ToString();
            if (UserInfo.IsActive)
            {
                lblsActive.Text = "Yes";
                lblsActive.BackColor=Color.FromArgb(220, 252, 231);
            }
            else
            {
                lblsActive.Text = "No";
                lblsActive.BackColor = Color.FromArgb(199,123,123);
            }
        }
    
    }
}
