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
    public partial class ctrlMemberDetailsWithFiltering : UserControl
    {
        public ctrlMemberDetailsWithFiltering()
        {
            InitializeComponent();
        }

        private void ctrlMemberDetailsWithFiltering_Load(object sender, EventArgs e)
        {

        }


        public void LoadMemberDetalsByMemberID(int MemberID)
        {





        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
