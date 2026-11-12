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
    public partial class frmShowSubscriptionDetails : Form
    {
        private int _SubscriptionID = -1;
        public frmShowSubscriptionDetails(int SubscriptionID)
        {
            InitializeComponent();
            _SubscriptionID = SubscriptionID;
        }

        private void frmShowSubscriptionDetails_Load(object sender, EventArgs e)
        {
            ctrlSubscriptionDetails2.LoadSubscriptionDetails(_SubscriptionID);
            ctrlSubscriptionDetails1.EnableStartDate = false;
        }

        private void ctrlSubscriptionDetails1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
