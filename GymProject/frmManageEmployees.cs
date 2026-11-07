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
    public partial class frmManageEmployees : Form
    {
        static private DataTable _dtAllEmployees;
        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            _dtAllEmployees= clsEmployees.GetAllEmployees();
            dgvEmployees.DataSource = _dtAllEmployees;
        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            _RefreshData();
            cmShiftType.DataSource = clsEmployeeShift.GetAllShiftType();
            cmShiftType.DisplayMember = "Shift Type";
            cmShiftType.ValueMember = "Shift ID";
            lblRecord.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None"&&cmSelectTypeOfFiltering.Text!="Is Active"&&cmSelectTypeOfFiltering.Text!="Hired Date"&&cmSelectTypeOfFiltering.Text!="Shift Type");
            cmIsActive.Visible = cmSelectTypeOfFiltering.Text == "Is Active";
            dtpDate.Visible = cmSelectTypeOfFiltering.Text == "Hired Date";
            cmShiftType.Visible = cmSelectTypeOfFiltering.Text == "Shift Type";
            txtFiltering.Clear();
            txtFiltering.Focus();
            _dtAllEmployees.DefaultView.RowFilter = "";
            lblRecord.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFiltering.Text))
            {
                _dtAllEmployees.DefaultView.RowFilter = "";
                lblRecord.Text = dgvEmployees.Rows.Count.ToString();
                return;
            }

            if (cmSelectTypeOfFiltering.Text == "Employee ID"||cmSelectTypeOfFiltering.Text=="Salary")
                _dtAllEmployees.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}]={txtFiltering.Text.Trim()}";
            else
                _dtAllEmployees.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] like '{txtFiltering.Text.Trim()}%'";

            lblRecord.Text = dgvEmployees.Rows.Count.ToString();

        }

        private void cmShiftType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtAllEmployees.DefaultView.RowFilter = $"[Shift Type] like '{cmShiftType.Text}'";
            lblRecord.Text = dgvEmployees.Rows.Count.ToString();

        }

        private void cmIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmIsActive.Text =="All")
            {
                _dtAllEmployees.DefaultView.RowFilter = "";
                lblRecord.Text = dgvEmployees.Rows.Count.ToString();
                return;
            }

            if(cmIsActive.Text=="Yes")
                _dtAllEmployees.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] =1";
            else
                _dtAllEmployees.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] =0";

            lblRecord.Text = dgvEmployees.Rows.Count.ToString();

        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedValue = dtpDate.Value;
            string timeString = selectedValue.ToString("yyyy/MM/dd");



            _dtAllEmployees.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] = '{timeString}' ";

            lblRecord.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateEmployee();
            frm.ShowDialog();
            _RefreshData();
        }
    }
}
