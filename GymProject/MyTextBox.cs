using Guna.UI2.WinForms;
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
    public partial class MyTextBox : Guna.UI2.WinForms.Guna2TextBox
    {
        public MyTextBox()
        {
            InitializeComponent();
            this.KeyPress += MyTextBox_KeyPress;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

       

        public enum TextType
        {
            Numeric = 1,
            Text = 2
        }

        private TextType _inputType = TextType.Text;

        [Category("Behavior")]
        [Description("Determines the type of input allowed in the TextBox.")]
        public TextType InputType
        {
            get => _inputType;
            set => _inputType = value;
        }

        private bool _IsRequired = false;

        [Category("Validation")]
        [Description("Determines whether the field is required.")]
        public bool IsRequired
        {
            get => _IsRequired;
            set => _IsRequired = value;
        }

        private string _ErrorMessage = "This Field is Required";

        [Category("Validation")]
        [Description("Message displayed when the required field is empty.")]
        public string ErrorMessage
        {
            get => _ErrorMessage;
            set => _ErrorMessage = value;
        }
    


        private ErrorProvider _errorProvider = new ErrorProvider();

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            if (IsRequired)
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    _errorProvider.SetError(this, _ErrorMessage);
                    e.Cancel = true;
                }
                else
                {
                    _errorProvider.SetError(this, "");
                }
            }
        }
        private void MyTextBox_KeyPress(object sender,KeyPressEventArgs e)
        {

            if (_inputType == TextType.Numeric)
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            }


        }




    }
}
