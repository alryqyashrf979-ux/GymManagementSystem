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
    public partial class ctrlSubscriptionPlanDetailsWithFiltering : UserControl
    {
        public ctrlSubscriptionPlanDetailsWithFiltering()
        {
            InitializeComponent();
        }

        public clsSubscriptionPlans SelectedPlan
        {
            get => ctrlSubscriptionPlanDetails1.PlanInfo;
        }

        public bool EnableFiltering
        {
            get => cmFiltering.Enabled;
            set=>cmFiltering.Enabled = value;
        }

        private void cmFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

            ctrlSubscriptionPlanDetails1.LoadPlanDataByPlanName(cmFiltering.Text);

        }

        private void ctrlSubscriptionPlanDetailsWithFiltering_Load(object sender, EventArgs e)
        {
            cmFiltering.DataSource = clsSubscriptionPlans.GetAllSubscriptionPlans();
        }
    }
}
