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
    public partial class frmAddUpdateClassRegistration : Form
    {
        private clsClassRegisteration _ClassRegisteration;
        enum enMode { AddMode,UpdateMode}
        private enMode _Mode = enMode.AddMode;
        private int _ClassRegisterationID = -1;
        public frmAddUpdateClassRegistration()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }
        public frmAddUpdateClassRegistration(int ClassRegisterationID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _ClassRegisterationID = ClassRegisterationID;
        }
        private void _ResetDefaultValues()
        {
            ctrlClassDetailsWithFilter1.FillCbClasses();
            // because it is not connect with frmLogin so CurrentUserInfo = null.
            lblRegisteredBy.Text = "1";
            //  lblRegisteredBy.Text = clsGlobal.CurrentUserInfo.UserName;



            if (_Mode == enMode.AddMode)
            {
                lblTitle2.Text = "Add Class Registeration";
                _ClassRegisteration = new clsClassRegisteration();
            }

            lblClassRegistrationID.Text = "???";
            lblMemberID.Text = "???";
            lblRegistrationDate.Text = DateTime.Now.ToString();
           
        }

        private void _LoadData()
        {
            _ClassRegisteration = clsClassRegisteration.Find(_ClassRegisterationID);
            if (_ClassRegisteration == null)
            {
                MessageBox.Show($"Class registeration with id : {_ClassRegisterationID} not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblClassRegistrationID.Text = _ClassRegisteration.ClassRegisterationID.ToString();
            lblMemberID.Text = _ClassRegisteration.MemberID.ToString();
            lblRegisteredBy.Text = _ClassRegisteration.RegisteredByUserID.ToString();
            lblRegistrationDate.Text =_ClassRegisteration.RegisterationDate.ToString();
          //  ctrlClassDetailsWithFilter1.EnableFilter = false;
            ctrlClassDetailsWithFilter1.SetClassIDInCbClasses = _ClassRegisteration.ClassID;
        }
        private void frmAddUpdateClassRegistration_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.UpdateMode)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMemberID.Text = "2";//for demo because member screen is not ready.
            if (lblMemberID.Text == "???")
            {
                MessageBox.Show("Error : You have to select a member first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ClassRegisteration.RegisteredByUserID=Convert.ToInt32(lblRegisteredBy.Text);
            _ClassRegisteration.RegisterationDate =Convert.ToDateTime(lblRegistrationDate.Text);
            _ClassRegisteration.MemberID=Convert.ToInt32(lblMemberID.Text);
            _ClassRegisteration.ClassID = ctrlClassDetailsWithFilter1.ClassID;

            if (_ClassRegisteration.Save())
            {
                lblTitle2.Text = "Update Class Registeration";
                lblClassRegistrationID.Text = _ClassRegisteration.ClassRegisterationID.ToString();
                _Mode = enMode.UpdateMode;

                MessageBox.Show("Recored saved successfully .", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error :recored didn't save successfully .", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
