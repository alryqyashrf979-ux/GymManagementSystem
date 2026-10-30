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
    public partial class frmManageClassRegisteration : Form
    {
        static private DataTable _dtAllClassRegisteration;
        public frmManageClassRegisteration()
        {
            InitializeComponent();
        }

        private void frmManageClassRegisteration_Load(object sender, EventArgs e)
        {
            cbValue.SelectedIndex = 0;
            _dtAllClassRegisteration = clsClassRegisteration.GetAllClassRegisterationInfo();
            dgvClassRegisteration.DataSource = _dtAllClassRegisteration;
            lblRecord.Text = dgvClassRegisteration.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClassRegistration();
            frm.ShowDialog();
            frmManageClassRegisteration_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClassRegistration((int)dgvClassRegisteration.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageClassRegisteration_Load(null, null);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            StringBuilder ColumnName = new StringBuilder();
            switch (cbValue.Text)
            {
                //case "Class Registeration ID":
                //    ColumnName.Append("Class Registeration ID");
                //    break;

                //case "Member Name":
                //    ColumnName.Append("Member Name");
                //    break;

                //case "Class Name":
                //    ColumnName.Append("Class Name");
                //    break;

                case "Start Time":
                    ColumnName.Append("StartTime");
                    break;

                case "Registeration Date":
                    ColumnName.Append("RegisterationDate");
                    break;
            }

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                _dtAllClassRegisteration.DefaultView.RowFilter = "";
                lblRecord.Text = dgvClassRegisteration.Rows.Count.ToString();
                return;
            }

            if (cbValue.Text == "Class Name" || cbValue.Text == "Member Name")
                _dtAllClassRegisteration.DefaultView.RowFilter = $"[{cbValue.Text}] like '{txtSearch.Text}%'";
            else if(cbValue.Text == "Class Registeration ID")
                _dtAllClassRegisteration.DefaultView.RowFilter = $"[{cbValue.Text}] = '{txtSearch.Text}'";

        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cbValue.Text.Trim() != "None");
            _dtAllClassRegisteration.DefaultView.RowFilter = "";
            lblRecord.Text = dgvClassRegisteration.Rows.Count.ToString();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbValue.Text == "Class Registeration ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
