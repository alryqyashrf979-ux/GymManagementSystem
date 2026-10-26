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
        public clsClasses Class { get; private set; }
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
            lblCoachID.Text = "???";
            lblDescription.Text = "???";
            lblNote.Text = "???";
            lblStartDay.Text = "???";
            lblEndDay.Text = "???";
            lblStartTime.Text = "???";
            lblEndTIme.Text = "???";
            lblIsActive.Text = "???";
        }
        private void ctrlClassDetails_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadClassInfo(int ClassID)
        {
            Class = clsClasses.Find(ClassID);
            if (Class == null)
            {
                ResetDefaultValues();
                MessageBox.Show($"Class with class ID : {ClassID} not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ClassID = ClassID;
            lblCapacity.Text = Class.Maximum_Capacity.ToString();
            lblClassD.Text = Class.ClassID.ToString();
            lblClassName.Text = Class.className;
            lblCoachID.Text = Class.CoachID.ToString();
            lblDescription.Text = Class.Description;
            lblNote.Text = Class.Note;
            lblStartDay.Text = Class.StartDay.ToString();
            lblEndDay.Text = Class.EndDay.ToString();
            lblStartTime.Text = Class.StartTime.ToString();
            lblEndTIme.Text = Class.EndTime.ToString();
            lblIsActive.Text = Class.IsActive.ToString();
        }
    }
}
