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

       private void _RefreshData()
        {

            _dtCoaches = clsCoaches.GetAllCoaches();
            dgvCoaches.DataSource = _dtCoaches;
            lblRecord.Text = dgvCoaches.Rows.Count.ToString();

        }
        private void frmManageCoaches_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None");
            txtFiltering.Clear();
            txtFiltering.Focus();

            _dtCoaches.DefaultView.RowFilter = "";
            lblRecord.Text = dgvCoaches.Rows.Count.ToString();

            if (cmSelectTypeOfFiltering.Text == "Coach Name"|| cmSelectTypeOfFiltering.Text == "Speciality")
                txtFiltering.InputType = MyTextBox.TextType.Text;
            else
                txtFiltering.InputType = MyTextBox.TextType.Numeric;


        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {



            if(txtFiltering.Text =="")
            {
                _dtCoaches.DefaultView.RowFilter = "";
                lblRecord.Text = dgvCoaches.Rows.Count.ToString();

                return;
            }


            if (txtFiltering.InputType == MyTextBox.TextType.Text)
                _dtCoaches.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] like '[{txtFiltering.Text.Trim()}]%'";
            else
                _dtCoaches.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text}] = '[{txtFiltering.Text.Trim()}]'";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewCoach_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCoach();
            frm.ShowDialog();
            _RefreshData();
        }

        private void CoachDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCoachDetails((int)dgvCoaches.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCoach();
            frm.ShowDialog();
            _RefreshData();
        }

        private void updateCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCoach((int)dgvCoaches.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshData();
        }

        private void deleteCoachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Index = (int)dgvCoaches.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Coach [" + Index + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                if (clsCoaches.DeleteCoach(Index))
                {
                    MessageBox.Show("Coach deleted successfully.", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshData();
                }
                else
                    MessageBox.Show("Coach was not Deleted because it has data link to it", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
