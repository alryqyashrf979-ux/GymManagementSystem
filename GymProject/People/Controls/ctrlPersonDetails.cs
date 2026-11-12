using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinessLayer;
namespace GymMangementSystem
{
    public partial class ctrlPersonDetails : UserControl
    {
        public int PersonID
        {
            get;private set;
        }
       

        public clsPeople PersonInfo
        {
            get;private set;
        }
        public void SetHeaderColor(int part1,int part2,int part3)
        {
            pnlHeaderColor.FillColor =Color.FromArgb(part1,part2,part3);
            lblTitle.ForeColor = Color.White;
        }
        public ctrlPersonDetails()
        {
            InitializeComponent();
        }
        private enum enGender { Male = 0, Female = 1 };

     
        public void ResetData()
        {
            _ResetPersonInformation();
        }
        private void _ResetPersonInformation()
        {
            lnkEditPersonInfo.Enabled = false;  
            lbAdress.Text = "[????]";
            lbCountry.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbEmail.Text = "[????]";
            lbGender.Text = "[????]";
            lblName.Text = "[????]";
            lbNationalNo.Text = "[????]";
            lbPersonID.Text = "[????]";
            lbPhone.Text = "[????]";
            PersonID = -1;
            picPersonalImage.Image = Properties.Resources.Male;
        }

        private void _LoadPersonImage()
        {
            picPersonalImage.Image = PersonInfo.Gender == (byte)enGender.Male ? Properties.Resources.Male : Properties.Resources.Female;

            if (PersonInfo.ImagePath == "" || PersonInfo.ImagePath == null)
                return;

            string ImagePath = PersonInfo.ImagePath;
            if (File.Exists(ImagePath))
            {
                picPersonalImage.ImageLocation = ImagePath;
            }
        }

        private void _LoadData()
        {
            lnkEditPersonInfo.Enabled = true;
            lbAdress.Text = PersonInfo.Address;
            lbCountry.Text =PersonInfo.CountryInfo .CountryName;
            lbDateOfBirth.Text = PersonInfo.DateOfBirth.ToString();
            lbEmail.Text = PersonInfo.Email.ToString();
            lbGender.Text = PersonInfo.Gender == 0 ? "Male" : "Female";
            lblName.Text = PersonInfo.FullName;
            lbNationalNo.Text = PersonInfo.NationalNo.ToString();
            lbPersonID.Text = PersonInfo.PersonID.ToString();
            lbPhone.Text = PersonInfo.PhoneNumber;

            _LoadPersonImage();
            PersonID = PersonInfo.PersonID;

        }

        public void LoadPersonInfo(int PersonID)
        {
            PersonInfo = clsPeople.Find(PersonID);
            if (PersonInfo == null)
            {
                _ResetPersonInformation();
                MessageBox.Show("No Person with Person ID=" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            PersonInfo = clsPeople.Find(NationalNo);
            if (PersonInfo == null)
            {
                _ResetPersonInformation();
                MessageBox.Show("No Person with National No =" + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }

      
        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson(PersonInfo.PersonID);
            frm.ShowDialog();
            LoadPersonInfo(PersonInfo.PersonID);


        }
    }
}