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
    public partial class frmAddUpdateEmployeeAttendance : Form
    {
        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;

        int _AttendanceID = -1;
        clsEmployeeAttendance _AttendanceInfo;
        public frmAddUpdateEmployeeAttendance()
        {
            InitializeComponent();
        }
        public frmAddUpdateEmployeeAttendance(int AttendanceID)
        {
            InitializeComponent();
            this._AttendanceID = AttendanceID;
            _Mode = enMode.Update;
        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ctrlEmployeeDetailsWithFiltering1_OnEmployeeSelected(object sender, ctrlEmployeeDetailsWithFiltering.EmployeeEventArgs e)
        {
            btnSave.Enabled = false;
            pnlAttendanceInput.Enabled = false;

            if (e.EmployeeInfo == null)
                return;

           

            btnSave.Enabled = true;
            pnlAttendanceInput.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Are You Sure you want to save attendance settings for this employee ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {

                return;
            }

            _AttendanceInfo.IsCheckin = rdYesChechIn.Checked;
            _AttendanceInfo.IsCheckout=rdYesCheckOut.Checked;
            _AttendanceInfo.EmployeeID = ctrlEmployeeDetailsWithFiltering1.EmployeeInfo.EmployeeID;



            if (_AttendanceInfo.Save())
            {

                lblTitle.Text = "Update Eployee Attendance";
                this.Text = lblTitle.Text;
                lblEmployeeID.Text = _AttendanceInfo.EmployeeID.ToString();
                lblEmployeeAttendanceID.Text= _AttendanceInfo.AttendanceID.ToString();
                _Mode = enMode.Update;

                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);






        }


        void _LoadData()
        {

            lblTitle.Text = "Update Eployee Attendance";
            this.Text = lblTitle.Text;


            _AttendanceInfo = clsEmployeeAttendance.Find(_AttendanceID);


            if (_AttendanceInfo == null)
            {

                MessageBox.Show($"Employee attendance with ID {_AttendanceID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }


            lblEmployeeID.Text = _AttendanceInfo.EmployeeID.ToString();
            lblEmployeeAttendanceID.Text = _AttendanceInfo.AttendanceID.ToString();
            lblCheckinDate.Text = _AttendanceInfo.Date.ToString();
            rdYesChechIn.Checked = _AttendanceInfo.IsCheckin;
            rdYesCheckOut.Checked = _AttendanceInfo.IsCheckout;

            txtNote.Text = _AttendanceInfo.Note;

            pnlCheckin.Enabled = false;


        }


        private void frmAddUpdateEmployeeAttendance_Load(object sender, EventArgs e)
        {
            this.Text = "Add employee attendance";
            lblTitle.Text = this.Text;
            lblCheckinDate.Text = DateTime.Today.Date.ToString();


            _AttendanceInfo = new clsEmployeeAttendance();


            if (_Mode == enMode.Update)
                _LoadData();

        }
    }
}
