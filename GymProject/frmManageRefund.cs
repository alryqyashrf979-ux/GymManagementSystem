using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinessLayer;

namespace GymMangementSystem
{
    public partial class frmManageRefund : Form
    {
        static private DataTable _dtAllRefund;
        public frmManageRefund()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            _dtAllRefund = clsRefund.GetAllRefund();
            dgvRefund.DataSource = _dtAllRefund;
            lblRecord.Text = dgvRefund.Rows.Count.ToString();
        }
        private void frmManageRefund_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnAddNewRefund_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRefund();
            frm.ShowDialog();
        }
    }
}
