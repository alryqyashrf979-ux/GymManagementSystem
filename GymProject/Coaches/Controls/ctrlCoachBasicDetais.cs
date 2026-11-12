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
        public clsCoaches CoachInfo { get; private set; } = null;
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
            CoachInfo = clsCoaches.FindByCoachID(CoachID);
            if (CoachInfo == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No coach with coach id : {CoachID}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAssignedMembers.Text = clsClassRegisteration.SelectAssignedMembers(CoachID).ToString();
            if (CoachInfo.EmployeeInfo.IsActive)
            {
                btnIsActive.Text = "Active";
                btnIsActive.FillColor = Color.LightGreen;
            }
            else
            {
                btnIsActive.Text = "Inactive";
                    Color.FromArgb(199, 123, 123);
            }
            lblHiredDate.Text = CoachInfo.EmployeeInfo.HiredDate.ToShortDateString();
            lblSpecialization.Text = CoachInfo.Speciality;
            lblTotalClasses.Text = clsCoaches.SelectTotalClassesForCoach(CoachID).ToString();
        }
    }
}
