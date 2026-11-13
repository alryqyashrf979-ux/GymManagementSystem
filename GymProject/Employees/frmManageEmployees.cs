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
            lblRecord.Text = dgvEmployees.Rows.Count.ToString();

        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            _RefreshData();
            cmShiftType.DisplayMember = "Shift Type";
            cmShiftType.ValueMember = "Shift ID";
            cmShiftType.DataSource = clsEmployeeShift.GetAllShiftType();
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

            if (txtFiltering.Visible)
            {
                txtFiltering.Clear();
                txtFiltering.Focus();
            }

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
            if (dgvEmployees.Rows.Count > 0)
            {
                _dtAllEmployees.DefaultView.RowFilter = $"[Shift Type] like '{cmShiftType.Text}'";
                lblRecord.Text = dgvEmployees.Rows.Count.ToString();
            }
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

        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmSelectTypeOfFiltering.Text == "Employee ID" || cmSelectTypeOfFiltering.Text == "Salary")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateEmployee();
            frm.ShowDialog();
            _RefreshData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowEmployeeDetails((int)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateEmployee();
            frm.ShowDialog();
            _RefreshData();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Index = (int)dgvEmployees.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Employee [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsEmployees.DeleteEmployee(Index))
                {
                    MessageBox.Show("Employee deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshData();
                }
                else
                    MessageBox.Show("Employee was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void terminateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Index = (int)dgvEmployees.CurrentRow.Cells[0].Value;
            clsEmployees EmployeeInfo = clsEmployees.FindByEmployeeID(Index);
            if (EmployeeInfo == null)
            {
                MessageBox.Show($"No Employee with employee id : {Index}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EmployeeInfo.TerminateEmployee())
            {
                MessageBox.Show("Terminated successfully", "Terminated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshData();
            }
        }
    }
}
