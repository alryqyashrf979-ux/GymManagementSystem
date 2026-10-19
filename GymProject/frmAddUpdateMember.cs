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

                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpLoginInfo"];
                return;
            }

            if(uctPersonDetailsWithFilter1.PersonID!=-1)
            {


                if (clsMembers.DoesMemberExistByPersonID(uctPersonDetailsWithFilter1.PersonID))
                {

                    MessageBox.Show("This person is already a member,Select another Person", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    tpLoginInfo.Enabled = false;
                    uctPersonDetailsWithFilter1.FocusOnTbSearch();


                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpLoginInfo"];
                    lblPersonID.Text= uctPersonDetailsWithFilter1.PersonID.ToString();

                }




            }
            else
            {
                MessageBox.Show("Please select a person or add a new person.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }







        }
    }
}
