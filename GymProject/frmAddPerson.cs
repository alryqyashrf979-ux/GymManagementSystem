using DataBusinessLayer;
using GymMangementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
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



        void _LoadData()
        {


            _Person = clsPeople.Find(_PersonID);


            if(_Person == null)
            {

                MessageBox.Show($"Person with ID {_PersonID} not Found !", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                return;
            }



            lblPersonID.Text = _Person.PersonID.ToString();

            txtFirstName.Text=_Person.FirstName;    
            txtLastName.Text=_Person.LastName;
            txtSecondName.Text=_Person.SecondName;
            txtEmail.Text=_Person.Email;
            txtAddress.Text = _Person.Address;
            txtPhoneNumber.Text = _Person.PhoneNumber;


            cmCountries.SelectedIndex = _Person.NationalityCountryID;





            if (_Person.Gender == (char)enGender.Male)
                rbMale.Checked=true;
            else
                rbFemale.Checked = true;


            //if (rbFemale.Checked)
            //    pbShowSelectedPicture.Image = Resources.Female_512;
            //else
            //    pbShowSelectedPicture.Image = Resources.Male_512;



            if (_Person.ImagePath != "")
                pbSelectedPhoto.ImageLocation = _Person.ImagePath;


            lnkRemoveImage.Visible = (pbSelectedPhoto.ImageLocation != null);




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

            rbMale.Checked = true;

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



        bool _HanldeImage()
        {


            if (_Person.ImagePath != pbSelectedPhoto.ImageLocation)
            {


                if (_Person.ImagePath != "")
                {
                    clsUtil.DeletePersonImage(_Person.ImagePath);
                }

                if (pbSelectedPhoto.ImageLocation != null)
                {


                    string SourceFile = pbSelectedPhoto.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceFile))
                    {

                        pbSelectedPhoto.ImageLocation = SourceFile;
                        return true;
                    }
                    else
                        return false;



                }

            }



            return false;
        }


        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if(this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!_HanldeImage())
                return;

            _Person.FirstName = txtFirstName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.Email= txtEmail.Text;
            _Person.Address= txtAddress.Text;
            _Person.DateOfBirth = dtDateOfBirth.Value;
            _Person.PhoneNumber= txtPhoneNumber.Text;

            if (rbMale.Checked)
                _Person.Gender = (char)enGender.Male;
            else
                _Person.Gender = (char)enGender.Female;



            if (pbSelectedPhoto.ImageLocation != null)
                _Person.ImagePath = pbSelectedPhoto.ImageLocation.ToString();
            else
                _Person.ImagePath = "";

            _Person.NationalityCountryID = (int)cmCountries.SelectedValue;
           


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";



                MessageBox.Show("Data saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Faild Save Data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lnkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbSelectedPhoto.ImageLocation = null;

            //if (rbFemale.Checked)
            //    pbShowSelectedPicture.Image = Resources.Female_512;
            //else
            //    pbShowSelectedPicture.Image = Resources.Male_512;

            lnkRemoveImage.Visible=false;

        }
    }
}
