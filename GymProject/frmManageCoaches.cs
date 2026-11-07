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
    public partial class frmManageCoaches : Form
    {
        public frmManageCoaches()
        {
            InitializeComponent();
        }


        DataTable _dtCoaches;

        void RefreshData()
        {

            _dtCoaches = clsCoaches.GetAllCoaches();
            dgvCoaches.DataSource = _dtCoaches;
            lblRecord.Text = dgvCoaches.Rows.Count.ToString();

        }
        private void frmManageCoaches_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
