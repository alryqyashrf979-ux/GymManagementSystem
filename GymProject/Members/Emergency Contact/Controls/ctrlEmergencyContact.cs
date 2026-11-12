using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlEmergencyContactDetails : UserControl
    {
        public clsEmergencyContacts EmergencyContactInfo { get; private set; }
        public ctrlEmergencyContactDetails()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            lblRelationship.Text = EmergencyContactInfo.Relationship;
            lblEmergencyContactID.Text = EmergencyContactInfo.ContactID.ToString();
            lblEmergencyContactPersonName.Text = EmergencyContactInfo.EmergencyContactPersonName;
            lblEmergencyContactPhone.Text = EmergencyContactInfo.EmergencyContactPhoneNumber;
        }

        public void ResetEmergencyContactData()
        {
            lblEmergencyContactID.Text = "[????]";
            lblEmergencyContactPhone.Text = "[????]";

            lblRelationship.Text = "[????]";
            lblEmergencyContactPersonName.Text = "[????]";
        }

     
        public void LoadEmergencyContactInfo(int ContactID)
        {
            EmergencyContactInfo = clsEmergencyContacts.Find(ContactID);

            if (EmergencyContactInfo == null)
            {
                ResetEmergencyContactData();
                MessageBox.Show("No emergency contact with contact ID=" + ContactID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }
       
    }
}
