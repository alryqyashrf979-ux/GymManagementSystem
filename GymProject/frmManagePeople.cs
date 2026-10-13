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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDataTable();
        }
        DataTable dtPeople = new DataTable();

        void _RefreshDataTable()
        {
            dtPeople = clsPeople.GetAllPeople();

            dgvShowPeopleList.DataSource = dtPeople;
        }

        private void dgvShowPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
