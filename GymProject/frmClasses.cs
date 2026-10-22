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


     
        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {



            DataTable dtFilteringData;

            DateTime selectedValue = dtpTime.Value;
            TimeSpan timeSpan = selectedValue.TimeOfDay;
            string timeString = selectedValue.ToString("HH:mm:ss");


            if(cbValue.Text=="Start Time")
               dtFilteringData= clsClasses.GetAllClassesByStartTime(timeString);
            else
               dtFilteringData= clsClasses.GetAllClassesByEndTime(timeString);


            //if (dtFilteringData.Rows.Count > 0)
            //    dgvShowClasses.DataSource = dtFilteringData;
            //else
            //{
            //    dgvShowClasses.DataSource = null;
            //    DrawHeaderOfDgvClasses();
         

            //}
         
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbValue.Text == "Class ID" || cbValue.Text == "Capacity")
                e.Handled = !char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar);
        }
    }
}
