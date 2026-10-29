using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlMemberDetailsWithFiltering : UserControl
    {
        public ctrlMemberDetailsWithFiltering()
        {
            InitializeComponent();
        }

        private void ctrlMemberDetailsWithFiltering_Load(object sender, EventArgs e)
        {
            txtFiltering.Focus();
        }

        public class MemberEventArgs : EventArgs
        {
            public clsMembers MemberInfo { get; }

            public MemberEventArgs(clsMembers memberInfo)   
            {
                MemberInfo = memberInfo;
            }
        }


        public event EventHandler<MemberEventArgs> OnMemberSelected;


        protected virtual void SelectedMember(object sender , MemberEventArgs Member)
        {

            OnMemberSelected?.Invoke(sender,Member);

        }


        public clsMembers MemberInfo
        {
            get => ctrlMemebrDetails1.MemberInfo;
        }

        public int MemberID
        {
            get => ctrlMemebrDetails1.MemberID;
        }

        public bool EnableFiltering 
        {

            set
            {
                gbFiltering.Enabled = value;
            }

            get
            {
                return gbFiltering.Enabled;
            }
        
        }

        public new void  Focus()
        {
            txtFiltering.Focus();
        }


        public void LoadMemberInfoByMemberID(int MemberID)
        {
            cmFilteringType.Text = "Member ID";
            txtFiltering.Text = MemberID.ToString();
            Find();

        }



        void Find()
        {

            if(cmFilteringType.Text=="Member ID")
            {
                ctrlMemebrDetails1.LoadMemberInfoByMemberID(Convert.ToInt32(txtFiltering.Text));
            }
            else
            {
                ctrlMemebrDetails1.LoadMemberInfoByNationalNu(txtFiltering.Text);
            }

            if (ctrlMemebrDetails1.MemberInfo != null)
                SelectedMember(this, new MemberEventArgs(ctrlMemebrDetails1.MemberInfo));
        }

        private void ShowDataBack(object sender ,int MemberID )
        {
            LoadMemberInfoByMemberID(MemberID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Focus();
                return;
            }

            Find();

        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.DataBack += ShowDataBack;
            frm.ShowDialog();

        }

        private void cmFilteringType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltering.Clear();
            txtFiltering.Focus();
            txtFiltering.InputType = (cmFilteringType.Text == "Member ID") ? MyTextBox.TextType.Numeric : MyTextBox.TextType.Text;
        }

        private void txtFiltering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }
    }
}
