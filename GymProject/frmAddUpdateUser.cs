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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddMode,UpdateMode}
        enMode _Mode = enMode.AddMode;
        private int _Permission=0;
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            uctPersonDetailsWithFilter1.FocusOnTbSearch();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            tpLoginInfo.Enabled = false;
            rbNo.Checked = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];

            }

            if (uctPersonDetailsWithFilter1.PersonID != -1)
            {
                if (clsUsers.isUserExistByPersonID(uctPersonDetailsWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uctPersonDetailsWithFilter1.FocusOnTbSearch();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uctPersonDetailsWithFilter1.FocusOnTbSearch();
            }

        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermission.Enabled = false;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermission.Enabled = true;
            chkManageClasses.Checked = false;
            chkManageEmployees.Checked = false ;
            chkManagePayments.Checked = false;
            chkManageMembers.Checked = false;
            chkManageTrainers.Checked = false;
            chkManageUsers.Checked = false;
            chkManagePeople.Checked = false;

        }

        private void SetPermission(CheckBox _checkbox,int permissionNumber)
        {
            if (_checkbox.Checked)
                _Permission += permissionNumber;
            else
                _Permission -= permissionNumber;
                
        }
        private void chkManagePeople_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManagePeople, Convert.ToInt32(chkManagePeople.Tag));
        }

        private void chkManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManageUsers, Convert.ToInt32(chkManageUsers.Tag));
        }

        private void chkManageMembers_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManageMembers, Convert.ToInt32(chkManageMembers.Tag));
        }

        private void chkManagePayments_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManagePayments, Convert.ToInt32(chkManagePayments.Tag));
        }

        private void chkManageEmployees_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManageEmployees, Convert.ToInt32(chkManageEmployees.Tag));
        }

        private void chkManageTrainers_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManageTrainers, Convert.ToInt32(chkManageTrainers.Tag));
        }

        private void chkManageClasses_CheckedChanged(object sender, EventArgs e)
        {
            SetPermission(chkManageClasses, Convert.ToInt32(chkManageClasses.Tag));
        }
    }
}
