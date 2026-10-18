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
    }
}
