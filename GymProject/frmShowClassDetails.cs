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
    public partial class frmShowClassDetails : Form
    {
        public frmShowClassDetails()
        {
            InitializeComponent();
        }

        private void frmShowClassDetails_Load(object sender, EventArgs e)
        {
            ctrlClassDetails1.LoadClassInfo(2);
            lblClassName.Text = ctrlClassDetails1.Class?.className ?? "Class Name";
            lblDescription.Text = ctrlClassDetails1.Class?.Description ?? "Description";
            bool IsActive = ctrlClassDetails1.Class?.IsActive??false;
            if (IsActive)
            {
                btnActive.Text = "Active";
                btnActive.FillColor = Color.FromArgb(220, 252, 231);
            }
            else
            {
                btnActive.Text = "Inactive";
                btnActive.FillColor = Color.FromArgb(199, 123, 123);
            }
        }
    }
}
