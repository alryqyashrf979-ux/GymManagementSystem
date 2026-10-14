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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
        }


        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;
        private int _PersonID=-1;



       public frmAddPerson(int PersonID)
        {
            this._PersonID= PersonID;   
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSelectedPhoto.ImageLocation = openFileDialog1.FileName;
                lnkRemoveImage.Visible = true;

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
