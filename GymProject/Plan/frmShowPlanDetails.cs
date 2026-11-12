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
    public partial class frmShowPlanDetails : Form
    {
        private int _PlanID = -1;
        public frmShowPlanDetails(int PlanID)
        {
            InitializeComponent();
            _PlanID = PlanID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPlanDetails_Load(object sender, EventArgs e)
        {
            ctrlSubscriptionPlanDetails1.LoadPlanDataByPlanID(_PlanID);
        }
    }
}
