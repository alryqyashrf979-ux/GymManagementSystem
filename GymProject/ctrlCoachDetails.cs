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
    public partial class ctrlCoachDetails : UserControl
    {
        public ctrlCoachDetails()
        {
            InitializeComponent();
        }

        private void ctrlCoachDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonDetails1.SetHeaderColor(56, 56, 56);
        }
    }
}
