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
    public partial class uctPersonDetailsWithFilter : UserControl
    {
        public int PersonID
        {
            get { return uctPersonDetails1.PersonID; }
        }
        public clsPeople PersonInfo
        {
            get => uctPersonDetails1.PersonInfo;
        }

      
        public uctPersonDetailsWithFilter()
        {
            InitializeComponent();
        }
        private void FIndNow()
        {
            if (tbSearch.Text.Trim() == "")
            {
                ((MyTextBox)tbSearch).IsRequired = true;
                return;
            }
            if (cbOptions.Text == "Person ID")
            {
                uctPersonDetails1.LoadPersonInfo(Convert.ToInt32(tbSearch.Text));
            }
            else
            {
                uctPersonDetails1.LoadPersonInfo(tbSearch.Text);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FIndNow();

        }

        public void FocusOnTbSearch()
        {
            tbSearch.Focus();
        }

        public void DisableFiltering()
        {
      
            gbFilter.Enabled = false;
        }

      
        public void LoadPersonInfo(int PersonID)
        {
            uctPersonDetails1.LoadPersonInfo(PersonID);
            tbSearch.Text = PersonID.ToString();
        }

     

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void DataBackEvent(int PersonID)
        {
            cbOptions.SelectedIndex = 0;
            tbSearch.Text = PersonID.ToString();
            uctPersonDetails1.LoadPersonInfo(PersonID);
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Clear();
            tbSearch.Focus();

            if (cbOptions.Text == "Person ID")
            {
                tbSearch.InputType = MyTextBox.TextType.Numeric;
            }
            else
            {
                tbSearch.InputType = MyTextBox.TextType.Text;
            }
        }
    }
}
