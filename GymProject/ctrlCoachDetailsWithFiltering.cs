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
    public partial class ctrlCoachDetailsWithFiltering : UserControl
    {

        public class CoachInfoEventArgs : EventArgs
        {
            public clsCoaches Coach { get; }
            public CoachInfoEventArgs(clsCoaches Coach)
            {
                this.Coach = Coach;
            }
        }

        public event EventHandler<CoachInfoEventArgs> OnCoachSelected;

        protected virtual void _SelectCoach(object sender, CoachInfoEventArgs e)
        {
            OnCoachSelected?.Invoke(sender, e);
        }

        public ctrlCoachDetailsWithFiltering()
        {
            InitializeComponent();
        }

        private void _FindNow()
        {
            if (txtFiltering.InputType == MyTextBox.TextType.Numeric)
                ctrlCoachDetails1.LoadCoachInformation(Convert.ToInt32(txtFiltering.Text.Trim()));
            else
                ctrlCoachDetails1.LoadCoachInformationByNationalNu(txtFiltering.Text.Trim());

            _SelectCoach(this, new CoachInfoEventArgs(ctrlCoachDetails1.CoachInfo));
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();
        }

       
        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        private void cmFilteringType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmFilteringType.Text == "Coach ID")
                txtFiltering.InputType = MyTextBox.TextType.Numeric;
            else
                txtFiltering.InputType = MyTextBox.TextType.Text;

            txtFiltering.Clear();
            txtFiltering.Focus();
        }
    }
}
