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
    public partial class frmAddUpdateClass : Form
    {
        enum enMode { AddMode,UpdateMode}
        enMode _Mode = enMode.AddMode;
        private int _ClassID=-1;
        private clsClasses _Class;

        int _CoachID = -1;
        public frmAddUpdateClass()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateClass(int ClassID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _ClassID = ClassID;
        }

        private void LoadData()
        {
            _Class = clsClasses.Find(_ClassID);
            if (_Class == null)
            {
                MessageBox.Show($"Class with class id : {_ClassID} not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTitle2.Text = "Update Class";
            lblClassID.Text = _ClassID.ToString();
            txtClassName.Text = _Class.className;
            txtNote.Text = _Class.Note ?? string.Empty;
            txtDescription.Text = _Class.Description ?? string.Empty;
            dtpStartTime.Value =DateTime.Today.Add(_Class.StartTime);
            dtpEndTime.Value = DateTime.Today.Add(_Class.EndTime);
            cbStartDay.SelectedIndex = cbStartDay.FindString(_Class.StartDay);
            cbEndDay.SelectedIndex = cbEndDay.FindString(_Class.EndDay);
            lblCoachID.Text = _Class.CoachID.ToString();
            nudCapacity.Value = _Class.Maximum_Capacity;
            tgschIsActive.Checked = _Class.IsActive;

        }

        private void ResetDefaultValues()
        {
            if (_Mode == enMode.AddMode)
            {
                _Class = new clsClasses();
                lblTitle2.Text = "Add Class";

            }
            lblClassID.Text = "???";
            lblCoachID.Text = "???";
            txtClassName.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cbStartDay.SelectedIndex = 0;
            cbEndDay.SelectedIndex = 6;
            tgschIsActive.Checked = true;
            nudCapacity.Value = 20;
            dtpStartTime.Value = DateTime.Today.Add(new TimeSpan(04,0,0));
            dtpEndTime.Value = DateTime.Today.Add(new TimeSpan(05, 30, 0));
        }
        private void frmAddUpdateClass_Load(object sender, EventArgs e)
        {
            ResetDefaultValues();

            if (_Mode == enMode.UpdateMode)
                LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //for demo and when coach management is ready we will link it with it.
            lblCoachID.Text = "1";

            if (_CoachID==-1)
            {
                MessageBox.Show("Coach ID is required !", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Class.className = txtClassName.Text;
            _Class.StartTime = dtpStartTime.Value.TimeOfDay;
            _Class.EndTime = dtpEndTime.Value.TimeOfDay;
            _Class.StartDay = cbStartDay.Text;
            _Class.EndDay = cbEndDay.Text;
            _Class.Note = txtNote.Text;
            _Class.Description = txtDescription.Text;
            _Class.CoachID = _CoachID;
            _Class.Maximum_Capacity =Convert.ToByte(nudCapacity.Value) ;
            _Class.IsActive = tgschIsActive.Checked;

            if (_Class.Save())
            {
                _Mode = enMode.UpdateMode;
                lblTitle2.Text = "Update Class";
                lblClassID.Text = _Class.ClassID.ToString();
                MessageBox.Show("Class saved successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error : Class didn't save successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
