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

        private void _RefreshData()
        {
            _dtAllPayments = clsPayments.GetAllPayments();
            dgvPayment.DataSource = _dtAllPayments;
            lblRecord.Text = dgvPayment.Rows.Count.ToString();
        }
        private void frmManagementPayment_Load(object sender, EventArgs e)
        {
            _RefreshData();

        }

        private void dgvPayment_Click(object sender, EventArgs e)
        {
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMethod.Visible = (cbValue.Text == "Method");
            txtSearch.Visible = !(cbValue.Text.Trim() == "None"||cbValue.Text=="Method"|| cbValue.Text == "Date"|| cbValue.Text == "Status");
            dtpTime.Visible = (cbValue.Text == "Date");
            cmStatus.Visible = (cbValue.Text == "Status");

            if (cbValue.Text == "Username" || cbValue.Text == "Member Name")
                txtSearch.InputType = MyTextBox.TextType.Text;
            else
                txtSearch.InputType = MyTextBox.TextType.Numeric;



                txtSearch.Clear();
            txtSearch.Focus();


            _dtAllPayments.DefaultView.RowFilter = "";
            lblRecord.Text = dgvPayment.Rows.Count.ToString();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPayment.Rows.Count.ToString();

                return;
            }

            if (txtSearch.InputType==MyTextBox.TextType.Text)
                _dtAllPayments.DefaultView.RowFilter = $"[{cbValue.Text}] like '{txtSearch.Text.Trim()}%'";
            else 
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
           
            _dtAllPayments.DefaultView.RowFilter = $"[{cbValue.Text.Trim()}] = '{dtpTime.Value.Date}' ";

            lblRecord.Text = dgvPayment.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmStatus.Text == "All")
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblRecord.Text = dgvPayment.Rows.Count.ToString();

                return;
            }

            _dtAllPayments.DefaultView.RowFilter = $"{cbValue.Text} like '{cmStatus.Text.Trim()}%'";
            lblRecord.Text = dgvPayment.Rows.Count.ToString();


        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePayment();
            frm.ShowDialog();
            _RefreshData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPaymentDetails((int)dgvPayment.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePayment();
            frm.ShowDialog();
            _RefreshData();
        }
    }
}
