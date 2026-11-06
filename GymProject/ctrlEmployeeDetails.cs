using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlEmployeeDetails : UserControl
    {
        public ctrlEmployeeDetails()
        {
            InitializeComponent();
        }
        private void lnkShowPlanDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public clsEmployees _EmployeeInfo { private set; get; }


        private void _ResetEmployeeData()
        {

            lblEmployeeID.Text = "[????]";
            lblHiredDate.Text = "[yyyy/mm/dd]";
            d.Text = "[$$$$]";
            lblShiftID.Text = "[????]";
            lblTerminationDate.Text = "[yyyy/mm/dd]";
            lblTitle.Text = "[????]";
            txtNote.Text = string.Empty;
            lnkShowShiftInfo.Enabled = false;

        }

        private void _LoadData()
        {

            lblEmployeeID.Text = _EmployeeInfo.EmployeeID.ToString();
            lblHiredDate.Text = _EmployeeInfo.HiredDate.ToString();
            d.Text = _EmployeeInfo.Salary.ToString();
            lblShiftID.Text = _EmployeeInfo.ShiftID.ToString();
            lblTerminationDate.Text = _EmployeeInfo?.TerminationDate.ToString() ?? "[yyyy/mm/dd]";
            lblTitle.Text = _EmployeeInfo.Title.ToString();
            txtNote.Text = _EmployeeInfo.Notes;
            lnkShowShiftInfo.Enabled = true;
        }



        public void LoadEmployeeDataByNationalNu(string NationalNu)
        {
            _EmployeeInfo = clsEmployees.FindByNationalNu(NationalNu);

            if (_EmployeeInfo == null)
            {
                _ResetEmployeeData();
                MessageBox.Show("No Employee Found with National Nu. =" + NationalNu.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadData();

        }
        public void LoadEmployeeDataByEmployeeID(int EmployeeID)
        {
            _EmployeeInfo = clsEmployees.FindByEmployeeID(EmployeeID);

            if (_EmployeeInfo == null)
            {
                _ResetEmployeeData();
                MessageBox.Show("No Employee Found with Employee ID=" + EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadData();

        }



    }
}
