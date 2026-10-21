using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinessLayer;
using System.Threading;

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
                dgvShowClasses.Columns[5].Width = 100;
            }

            lblRecord.Text = dgvShowClasses.Rows.Count.ToString();

        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsActive.Visible = (cbValue.Text == "Is Active" && cbValue.Text != "None");
            dtpTime.Visible = (cbValue.Text != "None" && (cbValue.Text == "Start Time" || cbValue.Text == "End Time"));
            txtSearch.Visible = (!dtpTime.Visible && !cbIsActive.Visible && cbValue.Text != "None");
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
         
            if ( txtSearch.Text == "")
            {
                _dtClasses.DefaultView.RowFilter = "";
                lblRecord.Text = dgvShowClasses.Rows.Count.ToString();
                return;
            }

            if(cbValue.Text=="Capacity"||cbValue.Text=="Class ID")
            {
                _dtClasses.DefaultView.RowFilter = $"[{cbValue.Text}]={Convert.ToInt32(txtSearch.Text)}";
            }
            else
                _dtClasses.DefaultView.RowFilter = $"[{cbValue.Text}] like '{txtSearch.Text}%'";

            lblRecord.Text = dgvShowClasses.Rows.Count.ToString();


        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.Text)
            {
                case "Yes":
                    _dtClasses.DefaultView.RowFilter = $"[{cbValue.Text}]={true}";
                    break;

                case "No":
                    _dtClasses.DefaultView.RowFilter = $"[{cbValue.Text}]={false}";
                    break;
            }

            if(cbIsActive.Text=="All")
                _dtClasses.DefaultView.RowFilter = "";

            lblRecord.Text = dgvShowClasses.Rows.Count.ToString();
        }

        private void DrawHeaderOfDgvClasses()
        {

            dgvShowClasses.Columns[0].HeaderText = "Class ID";
            dgvShowClasses.Columns[1].HeaderText = "Class Name";
            dgvShowClasses.Columns[2].HeaderText = "Coach Name";
            dgvShowClasses.Columns[3].HeaderText = "Start Time";
            dgvShowClasses.Columns[4].HeaderText = "End Time";
            dgvShowClasses.Columns[5].HeaderText = "Capacity";
            dgvShowClasses.Columns[5].HeaderText = "Is Active";

            dgvShowClasses.Columns[0].Width = 80;
            dgvShowClasses.Columns[1].Width = 150;
            dgvShowClasses.Columns[2].Width = 300;
            dgvShowClasses.Columns[3].Width = 100;
            dgvShowClasses.Columns[4].Width = 100;
            dgvShowClasses.Columns[5].Width = 100;
        }
        private async void dtpTime_ValueChanged(object sender, EventArgs e)
        {





          //  DateTime selectedValue = dtpTime.Value;
          //  TimeSpan timeSpan = selectedValue.TimeOfDay;
          //  string timeString = selectedValue.ToString("HH:mm:ss");

           
          ////  DataTable dtFilteringData= clsClasses.GetAllClassesByStartTime(timeString);

          //  if (dtFilteringData.Rows.Count > 0)
          //      dgvShowClasses.DataSource = dtFilteringData;
          //  else
          //  {
          //      _dtClasses.DefaultView.RowFilter = $"1=0";

          //  }
          // // _dtClasses.DefaultView.RowFilter = $"1=0";
        }

    }
}
