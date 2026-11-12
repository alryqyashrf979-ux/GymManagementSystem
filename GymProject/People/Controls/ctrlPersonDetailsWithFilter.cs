using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        public int PersonID
        {
            get=>  uctPersonDetails1.PersonID; 
        }
        public clsPeople PersonInfo
        {
            get => uctPersonDetails1.PersonInfo;
        }
        public bool EnableFiltering
        {
            set
            {
                gbFilter.Enabled = value;
            }
           
        }
      
        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        public class PersonEventArg : EventArgs
        {
            public clsPeople PersonInfo { get; }

            public PersonEventArg(clsPeople PersonInfo)
            {
                this.PersonInfo = PersonInfo;
            }
        }

        public event EventHandler<PersonEventArg> OnPersonSelected;

        protected virtual void SelectPerson(object sender, PersonEventArg PersonInfo)
        {
            OnPersonSelected?.Invoke(sender, PersonInfo);
        }

        private void FIndNow()
        {
           
            if (cbOptions.Text == "Person ID")
            {
                uctPersonDetails1.LoadPersonInfo(Convert.ToInt32(tbSearch.Text));
            }
            else
            {
                uctPersonDetails1.LoadPersonInfo(tbSearch.Text);
            }

            SelectPerson(this, new PersonEventArg(PersonInfo));

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

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
    }
}
