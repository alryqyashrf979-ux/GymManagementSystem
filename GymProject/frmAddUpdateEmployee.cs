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
        private int _EmployeeID = -1;
        private clsEmployees _EmployeeInfo;
        public enum enMode { AddMode,UpdateMode}
        private enMode _Mode = enMode.AddMode;
        public frmAddUpdateEmployee()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateEmployee(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
            _Mode = enMode.UpdateMode;
        }

        private void _LoadData()
        {
            _EmployeeInfo = clsEmployees.FindByEmployeeID(_EmployeeID);
            if (_EmployeeInfo == null)
            {

                MessageBox.Show($"Employee with Employee ID: {_EmployeeID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            uctPersonDetailsWithFilter1.EnableFiltering = false;
            uctPersonDetailsWithFilter1.LoadPersonInfo(_EmployeeInfo.PersonID);
            cmTitle.SelectedValue = _EmployeeInfo.TitleID ;
            cmShift.SelectedValue = _EmployeeInfo.ShiftID ;
            txtSalary.Text = _EmployeeInfo.Salary.ToString();
            txtNote.Text = _EmployeeInfo.Notes;
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

            cmTitle.DataSource = clsTitles.GetAllTitles();
            cmTitle.DisplayMember = "TitleName";
            cmTitle.ValueMember = "TitleID";

            cmShift.DataSource = clsEmployeeShift.GetAllShiftType();
            cmShift.DisplayMember = "Shift Type";
            cmShift.ValueMember = "Shift ID";

            txtSalary.Text = "0";
            gtsIsActive.Checked = true;
        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.UpdateMode)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _EmployeeInfo.TitleID =(int) cmTitle.SelectedValue;
            if (string.IsNullOrEmpty(txtSalary.Text))
                txtSalary.Text = "0";

            _EmployeeInfo.Salary = Convert.ToDouble(txtSalary.Text);
            _EmployeeInfo.Notes = txtNote.Text;
            _EmployeeInfo.ShiftID =(int) cmShift.SelectedValue;
            _EmployeeInfo.IsActive = gtsIsActive.Checked;
            _EmployeeInfo.PersonID = uctPersonDetailsWithFilter1.PersonID;
    
            if (_EmployeeInfo.Save())
            {
                lblTitle2.Text = "Update Employee";
                _Mode = enMode.UpdateMode;
                lblEmployeeID.Text = _EmployeeInfo.EmployeeID.ToString();
                MessageBox.Show("Data Saved Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error : Data Failed", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void uctPersonDetailsWithFilter1_OnPersonSelected(object sender, uctPersonDetailsWithFilter.PersonEventArg e)
        {
            if (e.PersonInfo == null)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
