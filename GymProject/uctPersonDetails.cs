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
    public partial class uctPersonDetails : UserControl
    {
        private int _PersonID=-1;
        public int PersonID
        {
            get { return _PersonID; }
        }
       
        private clsPeople _PersonInfo;

        public clsPeople PersonInfo
        {
            get { return _PersonInfo; }
        }

        public uctPersonDetails()
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
            t.Text = "[????]";
            lbNationalNo.Text = "[????]";
            lbPersonID.Text = "[????]";
            lbPhone.Text = "[????]";
            _PersonID = -1;
            picPersonalImage.Image = Properties.Resources.Male;
        }

        private void _LoadPersonImage()
        {
            picPersonalImage.Image = _PersonInfo.Gender == (byte)enGender.Male ? Properties.Resources.Male : Properties.Resources.Female;

            if (_PersonInfo.ImagePath == "" || _PersonInfo.ImagePath == null)
                return;

            string ImagePath = _PersonInfo.ImagePath;
            if (File.Exists(ImagePath))
            {
                picPersonalImage.ImageLocation = ImagePath;
            }
        }

        private void _FillPersonInfo()
        {
            lnkEditPersonInfo.Enabled = true;
            lbAdress.Text = _PersonInfo.Address;
            lbCountry.Text =PersonInfo.CountryInfo .CountryName;
            lbDateOfBirth.Text = _PersonInfo.DateOfBirth.ToString();
            lbAdress.Text = _PersonInfo.Email.ToString();
            lbGender.Text = _PersonInfo.Gender == 0 ? "Male" : "Female";
            t.Text = _PersonInfo.FullName;
            lbNationalNo.Text = _PersonInfo.NationalNo.ToString();
            lbPersonID.Text = _PersonInfo.PersonID.ToString();
            lbPhone.Text = _PersonInfo.PhoneNumber;

            _LoadPersonImage();
            _PersonID = _PersonInfo.PersonID;
        }

        public void LoadPersonInfo(int PersonID)
        {
            _PersonInfo = clsPeople.Find(PersonID);
            if (_PersonInfo == null)
            {
                _ResetPersonInformation();
                MessageBox.Show("No Person with Person ID=" + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _PersonInfo = clsPeople.Find(NationalNo);
            if (_PersonInfo == null)
            {
                _ResetPersonInformation();
                MessageBox.Show("No Person with National No =" + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddPerson frm=new frmAddPerson(PersonInfo.PersonID);
            frm.ShowDialog();
            LoadPersonInfo(PersonInfo.PersonID);


        }

        private void lnkEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}