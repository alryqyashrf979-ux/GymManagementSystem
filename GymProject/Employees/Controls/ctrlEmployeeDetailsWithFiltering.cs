using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlEmployeeDetailsWithFiltering : UserControl
    {
        public ctrlEmployeeDetailsWithFiltering()
        {
            InitializeComponent();
        }

        public clsEmployees EmployeeInfo { get => ctrlEmployeeDetails1.EmployeeInfo; }

        public bool EnableFiltering
        {
            set { gbFiltering.Enabled = value; }
        }

        public class EmployeeEventArgs : EventArgs
        {
            public clsEmployees EmployeeInfo { get; }

            public EmployeeEventArgs(clsEmployees Employee)
            {
                EmployeeInfo = Employee;
            }
        }



        public event EventHandler<EmployeeEventArgs> OnEmployeeSelected;


        protected virtual void SelectedEmployee(object sender, EmployeeEventArgs Employee)
        {

            OnEmployeeSelected?.Invoke(sender, Employee);

        }
     
        void Find()
        {


            if (txtFiltering.InputType == MyTextBox.TextType.Numeric)
            {
                ctrlEmployeeDetails1.LoadEmployeeDataByEmployeeID(Convert.ToInt32(txtFiltering.Text.Trim()));
            }
            else
                ctrlEmployeeDetails1.LoadEmployeeDataByNationalNu(txtFiltering.Text.Trim());

            if (ctrlEmployeeDetails1.EmployeeInfo != null)
                SelectedEmployee(this, new EmployeeEventArgs(ctrlEmployeeDetails1.EmployeeInfo));

        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        public void LoadEmployeeInfo(int EmployeeID)
        {
            txtFiltering.Text = EmployeeID.ToString();
            cmFilteringType.Text = "Employee ID";
            Find();
        }

        private void cmFilteringType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmFilteringType.Text == "Employee ID")
                txtFiltering.InputType = MyTextBox.TextType.Numeric;
            else
                txtFiltering.InputType = MyTextBox.TextType.Text;



        }


        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.DataBack += _LoadEmployeeData;
            frm.ShowDialog();

        }

     
       private void _LoadEmployeeData(int EmployeeID)
        {
            LoadEmployeeInfo(EmployeeID);
        }
    }
}
