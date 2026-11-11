using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmAddUpdateCoach : Form
    {

        public delegate void DataBackEventHandler(int CoachID);
        public event DataBackEventHandler DataBack;

        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;

        int _CoachID = -1;

        clsCoaches _CoachInfo;

        public frmAddUpdateCoach()
        {
            InitializeComponent();
        }
        public frmAddUpdateCoach(int CoachID )
        {
            InitializeComponent();
            this._CoachID = CoachID;
            _Mode = enMode.Update;
        }




        private void ctrlEmployeeDetailsWithFiltering1_OnEmployeeSelected(object sender, ctrlEmployeeDetailsWithFiltering.EmployeeEventArgs e)
        {
            if (e.EmployeeInfo == null)
                return;

            if(_Mode==enMode.Addnew)
            {

                if(ctrlEmployeeDetailsWithFiltering1.EmployeeInfo.IsCoach())
                {

                    MessageBox.Show($"This Employee is already Coach ,choose another one.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    pnlCoachInput.Enabled = false;
                    return;


                }

            }

            btnSave.Enabled = true;
            pnlCoachInput.Enabled = true;

        }

        void _LoadData()
        {
            lblTitle.Text = "Update Coach";
            this.Text = lblTitle.Text;


            _CoachInfo = clsCoaches.FindByCoachID(_CoachID);


            if (_CoachInfo == null)
            {

                MessageBox.Show($"Coach with ID {_CoachID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            ctrlEmployeeDetailsWithFiltering1.EnableFiltering = false;
            ctrlEmployeeDetailsWithFiltering1.LoadEmployeeInfo(_CoachInfo.EmployeeID);
            txtNote.Text = _CoachInfo.Note;
            txtSpeciality.Text = _CoachInfo.Speciality;
            lblCoachID.Text = _CoachInfo.CoachID.ToString();
            lblEmployeeID.Text=_CoachInfo.EmployeeID.ToString();
            pnlCoachInput.Enabled = true;
        }




        private void frmAddUpdateCoach_Load(object sender, EventArgs e)
        {
            lblCoachID.Text = "[????]";
            lblEmployeeID.Text = "[????]";
            lblTitle.Text = "Add Coach";
            this.Text = lblTitle.Text;
            pnlCoachInput.Enabled = false;


            _CoachInfo = new clsCoaches();

            if (_Mode == enMode.Update)
                _LoadData();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            _CoachInfo.Note=txtNote.Text;
            _CoachInfo.Speciality = txtSpeciality.Text;
            _CoachInfo.EmployeeID=ctrlEmployeeDetailsWithFiltering1.EmployeeInfo.EmployeeID;

            if(_CoachInfo.Save())
            {

                lblTitle.Text = "Update Coach";
                this.Text = lblTitle.Text;
                lblCoachID.Text=_CoachInfo.CoachID.ToString();
                _Mode = enMode.Update;
                DataBack?.Invoke(_CoachInfo.CoachID);
                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
