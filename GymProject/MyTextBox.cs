using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMangementSystem
{
    public partial class MyTextBox :TextBox
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }



        private bool _IsRequired = false;

        public bool IsRequired
        {
            get => _IsRequired;
            set=> _IsRequired = value;
        }

        private string _ErrorMessage = "This Field is Required";
        public string ErrorMessage
        {
            get=> _ErrorMessage;
            set => _ErrorMessage = value;
        }

        private ErrorProvider Validating = new ErrorProvider();

        public override 





    }
}
