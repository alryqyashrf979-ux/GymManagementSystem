using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class frmManageMember : Form
    {
        public frmManageMember()
        {
            InitializeComponent();
        }
        StringBuilder FilteringName = new StringBuilder();

        DataTable dtMembers = new DataTable();
        void _RefreshDataTable()
        {
            dtMembers = clsMembers.GetAllMembers();

            dgvMembersList.DataSource = dtMembers;
        }
        private void txtFiltering_TextChanged(object sender, EventArgs e)
        {

            FilteringName.Clear();

            //FilteringName.Append("");

            switch (cmSelectTypeOfFiltering.Text)
            {

                case "Full Name":
                    FilteringName.Append("FullName");
                    break;
                case "Phone":
                    FilteringName.Append("PhoneNumber");
                    txtFiltering.InputType = MyTextBox.TextType.Numeric;
                    break;
                case "Email":
                    FilteringName.Append("Email");
                    break;
                case "Person ID":
                    FilteringName.Append("PersonID");
                    txtFiltering.InputType = MyTextBox.TextType.Numeric;

                    break;
                case "Member ID":
                    FilteringName.Append("MemberID");
                    txtFiltering.InputType = MyTextBox.TextType.Numeric;

                    break;
                case "Emergency Contact ID":
                    FilteringName.Append("EmergencyContactInfoID");
                    txtFiltering.InputType = MyTextBox.TextType.Numeric;

                    break;
                case "Country Name":
                    FilteringName.Append("CountryName");
                    break;

                case "Gender":
                    FilteringName.Append("Gender");
                    break;



            }


            if (txtFiltering.Text == "")
            {
                dtMembers.DefaultView.RowFilter = "";
                lblRecord.Text = dtMembers.Rows.Count.ToString();

                return;
            }


            if (txtFiltering.InputType==MyTextBox.TextType.Numeric)
                dtMembers.DefaultView.RowFilter = $"{FilteringName.ToString()} = '{txtFiltering.Text}'";
            else
                dtMembers.DefaultView.RowFilter = $"{FilteringName.ToString()} Like '{txtFiltering.Text}%'";

            lblRecord.Text = dtMembers.DefaultView.Count.ToString();
        }

        private void frmManageMember_Load(object sender, EventArgs e)
        {
            _RefreshDataTable();
        }

        private void cmSelectTypeOfFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFiltering.InputType = MyTextBox.TextType.Text;

            txtFiltering.Visible = (cmSelectTypeOfFiltering.Text != "None");

            cmIsActive.Visible = (cmSelectTypeOfFiltering.Text == "IsActive");


            if (cmIsActive.Visible)
            {
                txtFiltering.Visible = false;
                cmIsActive.SelectedIndex = cmIsActive.FindString("All");
                cmIsActive.Focus();
            }
            else
            {
                txtFiltering.Focus();
                txtFiltering.Text = "";
            }


            dtMembers.DefaultView.RowFilter = "";

            lblRecord.Text = dtMembers.Rows.Count.ToString();
        }

        StringBuilder FilterColumn = new StringBuilder();
        StringBuilder FilterValue=new StringBuilder();  
        private void cmIsActiveOrno_SelectedIndexChanged(object sender, EventArgs e)
        {

            FilterColumn.Clear();
            FilterValue.Clear();
            FilterColumn.Append("IsActive");



            switch (cmIsActive.Text)
            {
                case "All":
                    FilterValue.Append("All");
                    break;

                case "Yes":
                    FilterValue.Append("True");
                    break;

                case "No":
                    FilterValue.Append("False");
                    break;

            }


            if (FilterValue.ToString() == "All")
                dtMembers.DefaultView.RowFilter = "";
            else
                dtMembers.DefaultView.RowFilter = $"{FilterColumn.ToString()} = '{FilterValue.ToString()}'";


            lblRecord.Text = dgvMembersList.Rows.Count.ToString();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm=new frmAddUpdateMember();
            frm.ShowDialog();
            _RefreshDataTable();
        }
    }
}
