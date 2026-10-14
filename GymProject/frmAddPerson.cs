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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
        }


        enum enMode { Addnew = 1, Update = 2 };
        enMode _Mode = enMode.Addnew;
        private int _PersonID=-1;

        private enum enGender { Male = 0, Female = 1 };


        public frmAddPerson(int PersonID)
        {
            this._PersonID = PersonID;
            this._Mode = enMode.Update;

        }

        clsPeople _Person;

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





        void _ResetDefualtValues()
        {



            if(_Mode==enMode.Addnew)
            {
                lblTitle.Text = "Add Person";
                this.Text = "Add Person";
                _Person = new clsPeople();

            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
                
            }


            txtFirstName.Text = string.Empty;
            txtLastName.Text= string.Empty;
            txtSecondName.Text = string.Empty;
            txtNationalNo.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;

            rbMake.Checked = true;

            //pbSelectedPhoto.Image = Properties.Resources.no_image;



            cmCountries.DataSource = clsCountries.GetAlllCountries();
            cmCountries.DisplayMember = "CountryName";
            cmCountries.ValueMember = "CountryID";


            cmCountries.SelectedIndex=cmCountries.FindStringExact("Yemen");

            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-100);


        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
        }
    }
}
