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
        public frmShowClassDetails(int ClassID)
        {
            InitializeComponent();
            LoadClassInformation(ClassID);
        }

    public void LoadClassInformation(int ClassID)
        {
            ctrlClassDetails1.LoadClassInfo(ClassID);
            lblClassName.Text = ctrlClassDetails1.Class?.className ?? "Class Name";
            lblDescription.Text = ctrlClassDetails1.Class?.Description ?? "Description";
            bool IsActive = ctrlClassDetails1.Class?.IsActive ?? false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
