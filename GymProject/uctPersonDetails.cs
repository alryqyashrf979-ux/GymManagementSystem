using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DataBusinessLayer;
namespace GymMangementSystem
{
    public partial class uctPersonDetails : UserControl
    {
        private int _PersonID;
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

        private void _ResetPersonInformation()
        {
            lbAddress.Text = "???";
            lbCountry.Text = "???";
            lbDateOfBirth.Text = "???";
            lbEmail.Text = "???";
            lbGender.Text = "???";
            lbName.Text = "???";
            lbNationalNo.Text = "???";
            lbPersonID.Text = "???";
            lbPhone.Text = "???";

        }

        private void _FillPersonInfo()
        {
            lbAddress.Text = _PersonInfo.Address;
            lbCountry.Text = clsCountries.Find(_PersonInfo.NationalityCountryID).CountryName;
            lbDateOfBirth.Text = _PersonInfo.DateOfBirth.ToString();
            lbEmail.Text = _PersonInfo.Email.ToString();
            lbGender.Text = _PersonInfo.Gender == 0 ? "Male" : "Female";
            lbName.Text = _PersonInfo.FullName;
            lbNationalNo.Text = _PersonInfo.NationalNo.ToString();
            lbPersonID.Text = _PersonInfo.PersonID.ToString();
            lbPhone.Text = _PersonInfo.PhoneNumber;
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
    }
}