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
using System.Windows.Forms.VisualStyles;

namespace GymMangementSystem
{
    public partial class frmSelectMember : Form
    {
        private int _MemberID;
        public delegate void DataBackEventHandler(int MemberID);
        public event DataBackEventHandler DataBack;

        public frmSelectMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlMemberBasicDetailsWithFilter1_OnMemberSelected(object sender, ctrlMemberBasicDetailsWithFilter.MemberEventArgs e)
        {
            if(e.MemberInfo==null)
            {
                btnSave.Enabled = false;
                return;
            } 
            
            _MemberID = e.MemberInfo.MemberID;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(_MemberID);
            MessageBox.Show("Member selected successfully", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
