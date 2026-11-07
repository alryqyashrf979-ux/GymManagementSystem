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
    public partial class frmAddUpdateEmployee : Form
    {
        private int _PersonID = -1;
        private clsEmployees _EmployeeInfo;
        public enum enMode { AddMode,UpdateMode}
        private enMode _Mode = enMode.AddMode;
        public frmAddUpdateEmployee()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateEmployee(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.UpdateMode;
        }

        private void _LoadData()
        {
            _EmployeeInfo = clsEmployees.FindByPersonID(_PersonID);
            if (_EmployeeInfo == null)
            {

                MessageBox.Show($"Employee with Person ID {_PersonID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            uctPersonDetailsWithFilter1.EnableFiltering = false;
            uctPersonDetailsWithFilter1.LoadPersonInfo(_PersonID);
            cmTitle.SelectedValue = _EmployeeInfo.TitleID ;
            cmShift.SelectedValue = _EmployeeInfo.ShiftID ;
            txtSalary.Text = _EmployeeInfo.Salary.ToString();
            txtNote.Text = _EmployeeInfo.Notes;
            dtpHiredDate.Value = _EmployeeInfo.HiredDate;
            gtsIsActive.Checked = _EmployeeInfo.IsActive;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddMode)
            {
                lblTitle2.Text = "Add Employee";
                _EmployeeInfo = new clsEmployees();
            }
            else
                lblTitle2.Text = "Update Employee";

          
        }
    }
}
