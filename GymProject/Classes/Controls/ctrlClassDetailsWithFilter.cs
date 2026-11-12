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
        public int SelectClassID { set { cbClasses.SelectedValue = value; } }
        public bool EnableFiltering
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }
        public event EventHandler<clsClasses> OnClassSelected;


        protected virtual void selectedClass(clsClasses clsClasses)
        {

            OnClassSelected?.Invoke(this,clsClasses);

        }


        public clsClasses SelectedClass { get => ctrlClassDetails1.ClassInfo; }


        public ctrlClassDetailsWithFilter()
        {
            InitializeComponent();
        }

        private bool IsCbClassesFilled = false;
        public void FillCbClasses()
        {

            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "ClassID";
            cbClasses.DataSource = clsClasses.GetAllActiveClassesNameAndID();
            cbClasses.StartIndex = 0;
            IsCbClassesFilled = true;

        }

      

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCbClassesFilled)
            {

                ctrlClassDetails1.LoadClassInfo((int)cbClasses.SelectedValue);
                ClassID = (int)cbClasses.SelectedValue;

                if (ctrlClassDetails1.ClassInfo != null)
                    selectedClass(ctrlClassDetails1.ClassInfo);


            }
        }

        private void ctrlClassDetailsWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
