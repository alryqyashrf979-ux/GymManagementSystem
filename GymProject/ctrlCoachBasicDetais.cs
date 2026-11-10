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
    public partial class ctrlCoachBasicDetais : UserControl
    {
        private clsCoaches _CoachInfo;
        public ctrlCoachBasicDetais()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblAssignedMembers.Text = "???";
            lblHiredDate.Text = "???";
            lblSpecialization.Text = "???";
            lblTotalClasses.Text = "???";
        }
        public void LoadCoachInformation(int CoachID)
        {
            _CoachInfo = clsCoaches.FindByCoachID(CoachID);
            if (_CoachInfo == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No coach with coach id : {CoachID}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAssignedMembers.Text = "???";
            lblHiredDate.Text =_CoachInfo.HiredDate.ToShortDateString();
            lblSpecialization.Text = _CoachInfo.Speciality;
            lblTotalClasses.Text = clsCoaches.SelectTotalClassesForCoach(CoachID).ToString();
        }
    }
}
