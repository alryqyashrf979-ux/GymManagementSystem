using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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


        public clsSubscriptionPlans PlanInfo
        {
            get => _PlanInfo;
        }


       void _ResetPlanData()
        {

            lblPlanID.Text = "[????]";
            lblPlanName.Text = "[????]";
            lblPrice.Text = "[$$$]";
            tgschIsAvailable.Checked= true;
            txtDescription.Text = string.Empty;
            txtNotes.Text = string.Empty;

        }


        void _LoadData()
        {

            lblPlanID.Text = _PlanInfo.PlanID.ToString();
            lblPlanName.Text=_PlanInfo.PlanName.ToString();
            lblPrice.Text=_PlanInfo.PlanPrice.ToString();
            tgschIsAvailable.Checked = _PlanInfo.IsAvailable;
            txtNotes.Text = _PlanInfo.Note;
            txtDescription.Text = _PlanInfo.PlanDescription;


        }

        public void LoadPlanDataByPlanName(string PlanName)
        {
            _PlanInfo = clsSubscriptionPlans.Find(PlanName);

            if (_PlanInfo == null)
            {
                _ResetPlanData();
                MessageBox.Show("No Member with Person ID=" + PlanName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
















    }
}
