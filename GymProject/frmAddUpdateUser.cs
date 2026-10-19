using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private clsUsers _User;
        private int _UserID = -1;

      
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _UserID = UserID;
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            uctPersonDetailsWithFilter1.FocusOnTbSearch();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddMode)
            {
                tpLoginInfo.Enabled = false;
                lblTitle.Text = "Add User";
                lblTitle2.Text = "Add User";
                _User = new clsUsers();
            }
            else
            {
                lblTitle.Text = "Update User";
                lblTitle2.Text = "Update User";
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            tbUserName.Text =string.Empty;
            tbPassword.Text = string.Empty;
            tbConfirmPassword.Text = string.Empty;
            lblPersonID.Text = "???";
            lblUserID.Text = "???";
            _SetCheckedValueForAllChkBox(false);
            rbActive.Checked = true;
            rbNo.Checked = true;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.UpdateMode)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
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
                    lblPersonID.Text = uctPersonDetailsWithFilter1.PersonID.ToString();
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uctPersonDetailsWithFilter1.FocusOnTbSearch();
            }

        }
        private void CheckPermission()
        {
            if (_User.Permission == -1)
            {
                rbNo.Checked = false;
                rbYes.Checked = true;
                return;
            }
            int perm = Convert.ToInt32(_User.Permission);

                chkManagePeople.Checked = ((perm & Convert.ToInt32(chkManagePeople.Tag))== Convert.ToInt32(chkManagePeople.Tag));
                chkManageUsers.Checked = ((perm & Convert.ToInt32(chkManageUsers.Tag)) == Convert.ToInt32(chkManageUsers.Tag));
                chkManagePayments.Checked = ((perm & Convert.ToInt32(chkManagePayments.Tag)) == Convert.ToInt32(chkManagePayments.Tag));
                chkManageEmployees.Checked = ((perm & Convert.ToInt32(chkManageEmployees.Tag)) == Convert.ToInt32(chkManageEmployees.Tag));
                chkManageMembers.Checked = ((perm & Convert.ToInt32(chkManageMembers.Tag)) == Convert.ToInt32(chkManageMembers.Tag));
                chkManageClasses.Checked = ((perm & Convert.ToInt32(chkManageClasses.Tag)) == Convert.ToInt32(chkManageClasses.Tag));
                chkManageTrainers.Checked = ((perm & Convert.ToInt32(chkManageTrainers.Tag)) == Convert.ToInt32(chkManageTrainers.Tag));
        }
        private void _LoadData()
        {
            _User = clsUsers.FindByUserID(_UserID);

            uctPersonDetailsWithFilter1.DisableFiltering();
            if (_User == null)
            {
                MessageBox.Show($"No User with user id = {_UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uctPersonDetailsWithFilter1.SetValueInTextbox(_User.PersonID);
            uctPersonDetailsWithFilter1.LoadPersonInfo(_User.PersonID);
            lblPersonID.Text = _User.PersonID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;

            if (_User.IsActive)
                rbActive.Checked = true;
            else
                rbDisactive.Checked = true;

            CheckPermission();


        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermission.Enabled = false;
        }

        private void _SetCheckedValueForAllChkBox(bool CheckedValue)
        {
            chkManageClasses.Checked = CheckedValue;
            chkManageEmployees.Checked = CheckedValue;
            chkManagePayments.Checked = CheckedValue;
            chkManageMembers.Checked = CheckedValue;
            chkManageTrainers.Checked = CheckedValue;
            chkManageUsers.Checked = CheckedValue;
            chkManagePeople.Checked = CheckedValue;
        }
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermission.Enabled = true;
            _SetCheckedValueForAllChkBox(false);

        }

        private void SetPermission(CheckBox _checkbox,int permissionNumber)
        {
            if (_checkbox.Checked)
                _Permission += permissionNumber;
            else
                _Permission -= permissionNumber;
                
        }

        private void SetCheckboxChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            SetPermission(checkbox, Convert.ToInt32(checkbox.Tag));
        }


        //private void chkManagePeople_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManagePeople, Convert.ToInt32(chkManagePeople.Tag));
        //}

        //private void chkManageUsers_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManageUsers, Convert.ToInt32(chkManageUsers.Tag));
        //}

        //private void chkManageMembers_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManageMembers, Convert.ToInt32(chkManageMembers.Tag));
        //}

        //private void chkManagePayments_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManagePayments, Convert.ToInt32(chkManagePayments.Tag));
        //}

        //private void chkManageEmployees_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManageEmployees, Convert.ToInt32(chkManageEmployees.Tag));
        //}

        //private void chkManageTrainers_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManageTrainers, Convert.ToInt32(chkManageTrainers.Tag));
        //}

        //private void chkManageClasses_CheckedChanged(object sender, EventArgs e)
        //{
        //    SetPermission(chkManageClasses, Convert.ToInt32(chkManageClasses.Tag));
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.UserName = tbUserName.Text.Trim();
            //if(clsHashing.Hashing(tbConfirmPassword.Text.Trim())!= clsHashing.Hashing(_User.Password))
            //_User.Password=clsHashing.Hashing(tbConfirmPassword.Text.Trim());

            _User.Password = tbConfirmPassword.Text.Trim();

            _User.Permission = Convert.ToSByte(_Permission);
            _User.IsActive = rbActive.Checked;
            _User.PersonID=Convert.ToInt32(lblPersonID.Text.Trim());

            if (_User.Save())
            {
                lblTitle.Text = "Update User";
                lblTitle2.Text = "Update User";
                _Mode = enMode.UpdateMode;
                lblUserID.Text = _User.UserID.ToString();
                MessageBox.Show("User saved successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error : User did not save successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
                errorProvider1.SetError(tbConfirmPassword, "ConfirmPassword does not match Password.");
            else
                errorProvider1.SetError(tbConfirmPassword, "");
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (clsUsers.IsUsernameExist(tbUserName.Text))
                errorProvider1.SetError(tbUserName, "this username already in user choose another one.");
            else
                errorProvider1.SetError(tbUserName, "");
        }
    }
}
