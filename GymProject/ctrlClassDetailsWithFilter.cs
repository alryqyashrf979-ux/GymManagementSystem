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
    public partial class ctrlClassDetailsWithFilter : UserControl
    {
        public int ClassID { get; private set; }
        public int SetClassIDInCbClasses { set { cbClasses.SelectedValue = value; } }
        public bool EnableFilter
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }

        public ctrlClassDetailsWithFilter()
        {
            InitializeComponent();
        }

        private bool IsCbClassesFilled = false;
        public void FillCbClasses()
        {
            cbClasses.DataSource = clsClasses.GetAllActiveClassesNamesAndIDs();
            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "ClassID";
            cbClasses.StartIndex = -1;
            IsCbClassesFilled = true;

        }

      

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCbClassesFilled)
            {
                ctrlClassDetails1.LoadClassInfo((int)cbClasses.SelectedValue);
                ClassID = (int)cbClasses.SelectedValue;
            }
        }
    }
}
