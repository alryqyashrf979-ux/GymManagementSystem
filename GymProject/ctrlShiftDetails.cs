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
    public partial class ctrlShiftDetails : UserControl
    {
        private clsEmployeeShift _Shift;
        public ctrlShiftDetails()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblEndTime.Text = "???";
            lblShiftID.Text = "???";
            lblStarTime.Text = "???";
            lblShiftType.Text = "???";
        }
        public void LoadShiftInformation(int ShiftID)
        {
            _Shift = clsEmployeeShift.Find(ShiftID);
            if (_Shift == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No shift with shift id : {ShiftID}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblEndTime.Text = _Shift.EndTime.ToString();
            lblShiftID.Text = _Shift.ShiftID.ToString();
            lblStarTime.Text = _Shift.StartTime.ToString();
            lblShiftType.Text =_Shift.ShiftType;
        }
    }
}
