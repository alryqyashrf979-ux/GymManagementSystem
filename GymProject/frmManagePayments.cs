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
    public partial class frmManagePayments : Form
    {
        static public DataTable _dtAllPayments;
        public frmManagePayments()
        {
            InitializeComponent();
        }

        private void frmManagementPayment_Load(object sender, EventArgs e)
        {
            _dtAllPayments= clsPayments.GetAllPayments();
            dgvPayment.DataSource = _dtAllPayments;
            lblRecord.Text = dgvPayment.Rows.Count.ToString();

        }

        private void dgvPayment_Click(object sender, EventArgs e)
        {
            ctrlPaymentDetails1.LoadPaymentInfo((int)dgvPayment.CurrentRow.Cells[0].Value);
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMethod.Visible = (cbValue.Text == "Method");
            txtSearch.Visible = !(cbValue.Text.Trim() == "None"||cbValue.Text=="Method"|| cbValue.Text == "Date");
            dtpTime.Visible = (cbValue.Text == "Date");
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPayment.Rows.Count.ToString();

                return;
            }

            if (cbValue.Text == "Username")
                _dtAllPayments.DefaultView.RowFilter = $"[{cbValue.Text}] like '{txtSearch.Text.Trim()}%'";
            else if (cbValue.Text == "Subscription ID" || cbValue.Text == "Payment ID")
                _dtAllPayments.DefaultView.RowFilter = $"[{cbValue.Text}] = {txtSearch.Text.Trim()}";

            lblRecord.Text = dgvPayment.Rows.Count.ToString();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbValue.Text == "Subscription ID" || cbValue.Text == "Payment ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethod.Text == "All")
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPayment.Rows.Count.ToString();

                return;
            }

            if(cbMethod.Text.Trim()== "Cash")
                _dtAllPayments.DefaultView.RowFilter = $"[Payment {cbValue.Text}] like 'Cash%'";
            else
                _dtAllPayments.DefaultView.RowFilter = $"[Payment {cbValue.Text}] like 'Card%'";

            lblRecord.Text = dgvPayment.Rows.Count.ToString();

        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedValue = dtpTime.Value;
            TimeSpan timeSpan = selectedValue.TimeOfDay;
            string timeString = selectedValue.ToString("yyyy/MM/dd");



            _dtAllPayments.DefaultView.RowFilter = $"[{cbValue.Text.Trim()}] = '{timeString}' ";

            lblRecord.Text = dgvPayment.Rows.Count.ToString();
        }
    }
}
