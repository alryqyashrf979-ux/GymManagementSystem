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
    public partial class frmAddUpdateClassRegistration : Form
    {
        public frmAddUpdateClassRegistration()
        {
            InitializeComponent();
        }

        private void txtClassRegistrationID_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void myTextBox1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
