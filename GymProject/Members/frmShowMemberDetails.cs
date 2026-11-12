using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmShowMemberDetails : Form
    {
        int MemberID = -1;
        public frmShowMemberDetails(int MemberID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }

        private void frmAddSubscription_Load(object sender, EventArgs e)
        {
            ctrlMemebrDetails1.LoadMemberInfoByMemberID(MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
