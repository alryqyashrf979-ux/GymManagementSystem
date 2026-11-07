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
    }
}
