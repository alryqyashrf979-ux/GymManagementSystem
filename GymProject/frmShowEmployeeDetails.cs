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
    public partial class frmShowEmployeeDetails : Form
    {
        public frmShowEmployeeDetails(int EmployeeID)
        {
            InitializeComponent();
            ctrlEmployeeDetails1.LoadEmployeeDataByEmployeeID(EmployeeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
