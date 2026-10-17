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
        public uctPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbOptions.Text == "Person ID")
            {
                uctPersonDetails1.LoadPersonInfo(Convert.ToInt32(tbSearch.Text));
            }
            else
            {
                uctPersonDetails1.LoadPersonInfo(tbSearch.Text);
            }

        }

        public void FocusOnTbSearch()
        {
            tbSearch.Focus();
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

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }
    }
}
