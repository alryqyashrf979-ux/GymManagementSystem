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
                uctPersonDetails1.LoadPersonInfo(Convert.ToInt32(tbSearch.Text));
            else
                uctPersonDetails1.LoadPersonInfo(tbSearch.Text);
        }

        public void FocusOnTbSearch()
        {
            tbSearch.Clear();
            tbSearch.Focus();
        }
    }
}
