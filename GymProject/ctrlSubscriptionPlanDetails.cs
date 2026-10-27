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
    public partial class ctrlSubscriptionPlanDetails : UserControl
    {
        public ctrlSubscriptionPlanDetails()
        {
            InitializeComponent();
        }


        clsSubscriptionPlans _PlanInfo;


       void _ResetData()
        {

            lblPlanID.Text = "[????]";
            lblPlanName.Text = "[????]";
            lblPrice.Text = "[$$$]";
            tgschIsAvailable.Checked= true;
            txtDescription.Text = string.Empty;
            txtNotes.Text = string.Empty;

        }




        public void LoadPlanDataByPlanName(string PlanName)
        {
            _PlanInfo = clsSubscriptionPlans.Find(PlanName);





        }
















    }
}
