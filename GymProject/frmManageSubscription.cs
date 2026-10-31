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
    public partial class frmManageSubscription : Form
    {
        public frmManageSubscription()
        {
            InitializeComponent();
        }



        DataTable SubscriptionsList;

        private void frmManageSubscription_Load(object sender, EventArgs e)
        {
            _RefreshDataTable();
        }


        void _RefreshDataTable()
        {

            SubscriptionsList = clsSubscription.GetAllSubscriptions();
            dgvSubscriptionsList.DataSource = SubscriptionsList;

            lblRecord.Text=SubscriptionsList.Rows.Count.ToString();
        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None" && cmSelectTypeOfFiltering.Text != "Status" && cmSelectTypeOfFiltering.Text != "Plan Name");
            cmPlanNames.Visible = (cmSelectTypeOfFiltering.Text == "Plan Name");
            cmStatus.Visible = (cmSelectTypeOfFiltering.Text == "Status");

            txtFiltering.InputType = (cmSelectTypeOfFiltering.Text == "Subscription ID") ? MyTextBox.TextType.Numeric : MyTextBox.TextType.Text;

            SubscriptionsList.DefaultView.RowFilter = "";
            lblRecord.Text = SubscriptionsList.Rows.Count.ToString();


            if (txtFiltering.Visible)
                txtFiltering.Text = "";

            if (cmPlanNames.Visible)
            {
                cmPlanNames.DisplayMember = "Name";
                cmPlanNames.DataSource = clsSubscriptionPlans.GetAllAvailabilityPlanNames();
                cmPlanNames.SelectedIndex = -1;
            }


        }

        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {



            if(txtFiltering.Text == "")
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = SubscriptionsList.Rows.Count.ToString();
                return;
            }

            if (txtFiltering.InputType == MyTextBox.TextType.Numeric)
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] = '{txtFiltering.Text}'";
            else
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{txtFiltering.Text}%'";



            lblRecord.Text = SubscriptionsList.Rows.Count.ToString();

        }

        private void cmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if(cmStatus.Text=="All")
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = SubscriptionsList.Rows.Count.ToString();
                return; 
            }


                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{cmStatus.Text}'";



        }

        private void cmPlanNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmPlanNames.SelectedIndex==-1)
            {
                SubscriptionsList.DefaultView.RowFilter = "";
                lblRecord.Text = SubscriptionsList.Rows.Count.ToString();

                return;
            }

           
                SubscriptionsList.DefaultView.RowFilter = $"[{cmSelectTypeOfFiltering.Text.Trim()}] like '{cmPlanNames.Text}'";
                lblRecord.Text = SubscriptionsList.Rows.Count.ToString();
            

        }
    }
}
