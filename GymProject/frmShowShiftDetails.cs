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
    public partial class frmShowShiftDetails : Form
    {
        public frmShowShiftDetails(int ShiftID)
        {
            InitializeComponent();
            ctrlShiftDetails1.LoadShiftInformation(ShiftID);
        }
    }
}
