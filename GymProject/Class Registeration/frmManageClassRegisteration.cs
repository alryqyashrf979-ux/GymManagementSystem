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
        private void _RefreshData()
        {
            _dtAllClassRegisteration = clsClassRegisteration.GetAllClassRegisterationInfo();
            dgvClassRegisteration.DataSource = _dtAllClassRegisteration;
        }
        private void frmManageClassRegisteration_Load(object sender, EventArgs e)
        {
            cbValue.SelectedIndex = 0;
            _RefreshData();
            lblRecord.Text = dgvClassRegisteration.Rows.Count.ToString();
        }

     

     

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          

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

        private void MemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowMemberDetails(clsClassRegisteration.Find((int)dgvClassRegisteration.CurrentRow.Cells[0].Value).MemberID);
            frm.ShowDialog();
        }

        private void CoachDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCoachDetails(clsClassRegisteration.Find((int)dgvClassRegisteration.CurrentRow.Cells[0].Value).ClassInfo.CoachID);
            frm.ShowDialog();
        }

        private void ClassDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowClassDetails(clsClassRegisteration.Find((int)dgvClassRegisteration.CurrentRow.Cells[0].Value).ClassID);
            frm.ShowDialog();
        }

        private void UserDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserDetails(clsClassRegisteration.Find((int)dgvClassRegisteration.CurrentRow.Cells[0].Value).RegisteredByUserID);
            frm.ShowDialog();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClassRegistration();
            frm.ShowDialog();
            _RefreshData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClassRegistration((int)dgvClassRegisteration.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }

        private void btnAddClassRegisteration_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateClassRegistration();
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Index = (int)dgvClassRegisteration.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Class registeration [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsClassRegisteration.Delete(Index))
                {
                    MessageBox.Show("Record deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshData();
                }
                else
                    MessageBox.Show("Class Registeration was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
