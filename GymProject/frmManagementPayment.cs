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
    public partial class frmManagementPayment : Form
    {
        public frmManagementPayment()
        {
            InitializeComponent();
        }

        private void frmManagementPayment_Load(object sender, EventArgs e)
        {
            dgvPayment.DataSource = clsPayments.GetAllPayments();
            lblRecord.Text = dgvPayment.Rows.Count.ToString();
        }
    }
}
