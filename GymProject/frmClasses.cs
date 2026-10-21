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
    public partial class frmClasses : Form
    {
       static DataTable _dtClasses = clsClasses.GetAllClasses();
        public frmClasses()
        {
            InitializeComponent();
        }

        private void frmManageClasses_Load(object sender, EventArgs e)
        {
            dgvShowClasses.DataSource = _dtClasses;

            if (dgvShowClasses.Rows.Count > 0)
            {
                dgvShowClasses.Columns[0].Width = 80;
                dgvShowClasses.Columns[1].Width = 150;
                dgvShowClasses.Columns[2].Width = 300;
                dgvShowClasses.Columns[3].Width = 100;
                dgvShowClasses.Columns[4].Width = 100;
                dgvShowClasses.Columns[5].HeaderText = "Capacity";
                dgvShowClasses.Columns[5].Width = 100;
            }

            lblRecord.Text = dgvShowClasses.Rows.Count.ToString();
        }
    }
}
