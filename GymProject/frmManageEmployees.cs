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
            lblRecord.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
