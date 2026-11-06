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
    public partial class ctrlEmployeeDetailsWithFiltering : UserControl
    {
        public ctrlEmployeeDetailsWithFiltering()
        {
            InitializeComponent();
        }


        void Find()
        {


            if (txtFiltering.InputType == MyTextBox.TextType.Numeric)
            {
                ctrlEmployeeDetails1.LoadEmployeeDataByEmployeeID(Convert.ToInt32(txtFiltering.Text.Trim()));
            }
            else
                ctrlEmployeeDetails1.LoadEmployeeDataByNationalNu(txtFiltering.Text.Trim());

        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void cmFilteringType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmFilteringType.Text == "Employee ID")
                txtFiltering.InputType = MyTextBox.TextType.Numeric;
            else
                txtFiltering.InputType = MyTextBox.TextType.Text;
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }
    }
}
