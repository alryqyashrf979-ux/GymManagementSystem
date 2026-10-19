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
    public partial class frmAddUpdateMember : Form
    {
        public frmAddUpdateMember()
        {
            InitializeComponent();
        }



        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {




                return;
            }

            if(uctPersonDetailsWithFilter1.PersonID!=-1)
            {






            }
            else
            {
                MessageBox.Show("Please select a person or add a new person.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }







        }
    }
}
