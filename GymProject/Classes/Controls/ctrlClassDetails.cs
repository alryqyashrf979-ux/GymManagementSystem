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
    public partial class ctrlClassDetails : UserControl
    {
        public clsClasses ClassInfo { get; private set; }
        public int ClassID { get; private set; }


        public ctrlClassDetails()
        {
            InitializeComponent();
        }

        private void ResetDefaultValues()
        {
            lblCapacity.Text = "???";
            lblClassD.Text = "???";
            lblClassName.Text = "???";
            lblCoachName.Text = "???";
            lblDescription.Text = "???";
            lblNote.Text = "???";
            lblStartDay.Text = "???";
            lblEndDay.Text = "???";
            lblStartTime.Text = "???";
            lblEndTIme.Text = "???";
            lblIsActive.Text = "???";
        }
       
        public void LoadClassInfo(int ClassID)
        {
            ClassInfo = clsClasses.Find(ClassID);
            if (ClassInfo == null)
            {
                ResetDefaultValues();
                MessageBox.Show($"Class with class ID : {ClassID} not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ClassID = ClassID;
            lblCapacity.Text = ClassInfo.Maximum_Capacity.ToString();
            lblClassD.Text = ClassInfo.ClassID.ToString();
            lblClassName.Text = ClassInfo.className;
            lblCoachName.Text = ClassInfo.CoachInfo.CoachName;
            lblDescription.Text = ClassInfo.Description;
            lblNote.Text = ClassInfo.Note;
            lblStartDay.Text = ClassInfo.StartDay.ToString();
            lblEndDay.Text = ClassInfo.EndDay.ToString();
            lblStartTime.Text = ClassInfo.StartTime.ToString();
            lblEndTIme.Text = ClassInfo.EndTime.ToString();
            lblIsActive.Text = ClassInfo.IsActive.ToString();
        }
    }
}
