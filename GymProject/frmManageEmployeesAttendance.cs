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
    public partial class frmManageEmployeesAttendance : Form
    {
        public frmManageEmployeesAttendance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable _dtEmployeesAttendance;
        private void frmManageEmployeesAttendance_Load(object sender, EventArgs e)
        {
            RefreshDate();
        }


        void RefreshDate()
        {
            _dtEmployeesAttendance = clsEmployeeAttendance.GetAllEmployeeAttendance();

            dgvEmployeesAttendance.DataSource = _dtEmployeesAttendance;

            lblRecord.Text=dgvEmployeesAttendance.Rows.Count.ToString();    

        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None" && cmSelectTypeOfFiltering.Text != "Status"&& cmSelectTypeOfFiltering.Text != "Date");
            cmCheckType.Visible = cmSelectTypeOfFiltering.Text == "Status";
            dtpDate.Visible = cmSelectTypeOfFiltering.Text == "Date";

            txtFiltering.Clear();
            txtFiltering.Focus();
            _dtEmployeesAttendance.DefaultView.RowFilter = "";
            lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();


            if (cmSelectTypeOfFiltering.Text == "Name")
                txtFiltering.InputType = MyTextBox.TextType.Text;
            else
                txtFiltering.InputType = MyTextBox.TextType.Numeric;



        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployeeAttendance frm=new frmAddUpdateEmployeeAttendance();
            frm.ShowDialog();
            RefreshDate();
        }

        private void cmCheckType_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmCheckType.Text == "All")
            {

                _dtEmployeesAttendance.DefaultView.RowFilter = "";
                lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();
                return;

            }


            _dtEmployeesAttendance.DefaultView.RowFilter=$"[{cmCheckType.Text}] = [{true}]";

            lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();

        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {



            if(string.IsNullOrEmpty(txtFiltering.Text))
            {
                _dtEmployeesAttendance.DefaultView.RowFilter = "";
                lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();
                return;
            }

            
            if(txtFiltering.InputType == MyTextBox.TextType.Numeric)
                _dtEmployeesAttendance.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] = [{txtFiltering.Text}]";
            else
                _dtEmployeesAttendance.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] like [{txtFiltering.Text}]";


            lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedValue = dtpDate.Value;
            string timeString = selectedValue.ToString("yyyy/MM/dd");



            _dtEmployeesAttendance.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] = '{timeString}' ";

            lblRecord.Text = dgvEmployeesAttendance.Rows.Count.ToString();
        }

        private void EmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowEmployeeDetails((int)dgvEmployeesAttendance.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addEmployeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployeeAttendance frm = new frmAddUpdateEmployeeAttendance();
            frm.ShowDialog();
            RefreshDate();
        }

        private void updateEmployeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployeeAttendance frm = new frmAddUpdateEmployeeAttendance((int)dgvEmployeesAttendance.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshDate();
        }

        private void deleteEmployeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Index = (int)dgvEmployeesAttendance.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Employee Attendance record [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsEmployeeAttendance.DeleteEmployeeAttendance(Index))
                {
                    MessageBox.Show("Employee Attendance deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDate();
                }
                else
                    MessageBox.Show("Employee Attendance was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void CheckOuttoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clsEmployeeAttendance.SetCheckout((int)dgvEmployeesAttendance.CurrentRow.Cells[0].Value);
            RefreshDate();
        }

   
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(dgvEmployeesAttendance.CurrentRow.Cells[4].Value) == true)
                CheckOuttoolStripMenuItem2.Enabled = false;
            else
                CheckOuttoolStripMenuItem2.Enabled = true;
        }
    }
}
