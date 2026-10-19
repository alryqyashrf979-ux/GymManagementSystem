using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusinessLayer;

namespace GymMangementSystem
{
    public partial class ctrlUserDetails : UserControl
    {
       
        public ctrlUserDetails()
        {
            InitializeComponent();
          
        }

        public void LoadUserInfo(int UserID)
        {
            uctPersonDetails1.LoadPersonInfo();
        }
        private void ctrlUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
