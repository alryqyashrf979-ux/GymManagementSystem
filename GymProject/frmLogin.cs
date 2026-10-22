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
    public partial class frmLogin : Form
    {
        private clsUsers _User;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            chkRememberMe.Checked = false;

            string username = string.Empty;
            string Password = string.Empty;


            if (clsGlobal.ReadFromWindowsRegistery(ref username, ref Password))
            {
                if(username!=""&&Password!="")
                {
                    txtUserName.Text = username;
                    txtPassword.Text = Password;
                    chkRememberMe.Checked = true;
                }
                
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = clsUsers.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (_User==null)
            {
                MessageBox.Show("Invalid Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }


            if(!_User.IsActive)
            {
                txtUserName.Focus();
                MessageBox.Show("Your Account is not Active , contact Admin", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chkRememberMe.Checked)
                clsGlobal.WriteInWindowsRegister(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            else
                clsGlobal.WriteInWindowsRegister("", "");
            


            clsGlobal.CurrentUserInfo = _User;
            Form frm = new frmDashboard(this);
            this.Hide();
            frm.ShowDialog();
        }

   
    }
}
