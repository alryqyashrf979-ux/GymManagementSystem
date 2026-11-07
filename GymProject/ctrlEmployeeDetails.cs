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

        public clsEmployees EmployeeInfo { private set; get; }


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

            lblEmployeeID.Text = EmployeeInfo.EmployeeID.ToString();
            lblHiredDate.Text = EmployeeInfo.HiredDate.ToString();
            d.Text = EmployeeInfo.Salary.ToString();
            lblShiftID.Text = EmployeeInfo.ShiftID.ToString();
            lblTerminationDate.Text = EmployeeInfo?.TerminationDate.ToString() ?? "[yyyy/mm/dd]";
            lblTitle.Text =clsTitles.Find(EmployeeInfo.TitleID).TitleName;
            txtNote.Text = EmployeeInfo.Notes;
            lnkShowShiftInfo.Enabled = true;
        }



        public void LoadEmployeeDataByNationalNu(string NationalNu)
        {
            EmployeeInfo = clsEmployees.FindByNationalNu(NationalNu);

            if (EmployeeInfo == null)
            {
                _ResetEmployeeData();
                MessageBox.Show("No Employee Found with National Nu. =" + NationalNu.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadData();

        }
        public void LoadEmployeeDataByEmployeeID(int EmployeeID)
        {
            EmployeeInfo = clsEmployees.FindByEmployeeID(EmployeeID);

            if (EmployeeInfo == null)
            {
                _ResetEmployeeData();
                MessageBox.Show("No Employee Found with Employee ID=" + EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadData();

        }



    }
}
