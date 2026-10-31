using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlMemberBasicDetails : UserControl
    {
        public clsMembers MemberInfo { get; private set; }

        public ctrlMemberBasicDetails()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            lblLastSubscriptionID.Text = MemberInfo.LastSubscriptionID.ToString();
            lblMemberID.Text = MemberInfo.MemberID.ToString();
            tgschIsActive.Checked = MemberInfo.IsActive;
            txtInActivationReason.Text = MemberInfo.InActivationReason;
            lnkShowLastSubscriptionInfo.Enabled = (MemberInfo.LastSubscriptionID != -1);

        }
        private void _ResetMemberData()
        {
            txtInActivationReason.Text = string.Empty;
            lblLastSubscriptionID.Text = "[????]";
            lblMemberID.Text = "[????]";
            tgschIsActive.Checked = true;
        }

        public void LoadMemberInfoByMemberID(int MemberID)
        {
            MemberInfo = clsMembers.FindMemberUsingMemberID(MemberID);

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Member ID=" + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }


        public void LoadMemberInfoByPersonID(int PersonID)
        {
            MemberInfo = clsMembers.FindMemberUsingPersonID(PersonID);

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with Person ID=" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
        public void LoadMemberInfoByNationalNu(string NationalNu)
        {
            MemberInfo = clsMembers.FindMemberUsingNationalNu(NationalNu);

            if (MemberInfo == null)
            {
                _ResetMemberData();
                MessageBox.Show("No Member with National Nu=" + NationalNu.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
    }
}
