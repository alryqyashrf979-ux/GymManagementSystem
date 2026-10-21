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
    public partial class frmManageClasses : Form
    {
       static DataTable _dtClassTypes = clsClasses.GetAllClasses();
        public frmManageClasses()
        {
            InitializeComponent();
        }

        private void frmManageClasses_Load(object sender, EventArgs e)
        {
            dgvShowClassesTypes.DataSource = _dtClassTypes;
        }
    }
}
