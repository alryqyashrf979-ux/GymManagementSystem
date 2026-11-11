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
    public partial class ctrlSubscriptionsHistory : UserControl
    {

        clsMembers _MemberInfo;
        public ctrlSubscriptionsHistory()
        {
            InitializeComponent();
        }


        void _LoadSubscriptionsHistroy()
        {












        }





        public void LoadMemberSubscriptionsHistory(int MemberID)
        {

            _MemberInfo = clsMembers.FindMemberUsingMemberID(MemberID);

            if (_MemberInfo == null)
            {
                MessageBox.Show($"Member with ID {MemberID} not found ", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadSubscriptionsHistroy();


        }


        private void ctrlSubscriptionsHistory_Load(object sender, EventArgs e)
        {

        }




    }
}
