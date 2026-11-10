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
    public partial class frmSelectCoach : Form
    {
        private clsCoaches _CoachInfo;
        public delegate void DataBackEventHandler(int CoachID);
        public event DataBackEventHandler DataBack;
        public frmSelectCoach()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlCoachDetailsWithFiltering1_OnCoachSelected(object sender, ctrlCoachDetailsWithFiltering.CoachInfoEventArgs e)
        {
            if (e.Coach == null)
            {
                btnSave.Enabled = false;
                return;
            }
            _CoachInfo = e.Coach;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(_CoachInfo.CoachID);
            MessageBox.Show($"Coach selected successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
