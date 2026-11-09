namespace GymMangementSystem
{
    partial class ctrlEmployeeDetailsWithFiltering
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlEmployeeDetails1 = new GymMangementSystem.ctrlEmployeeDetails();
            this.gbFiltering = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFiltering = new GymMangementSystem.MyTextBox();
            this.btnAddNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.cmFilteringType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlEmployeeDetails1
            // 
            this.ctrlEmployeeDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlEmployeeDetails1.Location = new System.Drawing.Point(0, 59);
            this.ctrlEmployeeDetails1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlEmployeeDetails1.Name = "ctrlEmployeeDetails1";
            this.ctrlEmployeeDetails1.Size = new System.Drawing.Size(895, 498);
            this.ctrlEmployeeDetails1.TabIndex = 0;
            // 
            // gbFiltering
            // 
            this.gbFiltering.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbFiltering.BorderRadius = 5;
            this.gbFiltering.Controls.Add(this.txtFiltering);
            this.gbFiltering.Controls.Add(this.btnAddNewEmployee);
            this.gbFiltering.Controls.Add(this.btnFind);
            this.gbFiltering.Controls.Add(this.cmFilteringType);
            this.gbFiltering.Controls.Add(this.label9);
            this.gbFiltering.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltering.ForeColor = System.Drawing.Color.Black;
            this.gbFiltering.Location = new System.Drawing.Point(4, 4);
            this.gbFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Size = new System.Drawing.Size(886, 54);
            this.gbFiltering.TabIndex = 3;
            this.gbFiltering.Text = "Filter";
            // 
            // txtFiltering
            // 
            this.txtFiltering.BorderRadius = 5;
            this.txtFiltering.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltering.DefaultText = "";
            this.txtFiltering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.ErrorMessage = "This Field is Required";
            this.txtFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFiltering.ForeColor = System.Drawing.Color.Black;
            this.txtFiltering.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.InputType = GymMangementSystem.MyTextBox.TextType.Numeric;
            this.txtFiltering.IsRequired = true;
            this.txtFiltering.Location = new System.Drawing.Point(364, 15);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(218, 28);
            this.txtFiltering.TabIndex = 90;
            this.txtFiltering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltering_KeyPress);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewEmployee.BorderRadius = 5;
            this.btnAddNewEmployee.BorderThickness = 1;
            this.btnAddNewEmployee.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewEmployee.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewEmployee.Image = global::GymMangementSystem.Properties.Resources.AddUser;
            this.btnAddNewEmployee.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnAddNewEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewEmployee.Location = new System.Drawing.Point(705, 13);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(58, 29);
            this.btnAddNewEmployee.TabIndex = 89;
            // 
            // btnFind
            // 
            this.btnFind.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFind.BorderRadius = 5;
            this.btnFind.BorderThickness = 1;
            this.btnFind.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFind.Image = global::GymMangementSystem.Properties.Resources.SearchPerson;
            this.btnFind.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnFind.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFind.Location = new System.Drawing.Point(631, 13);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(58, 29);
            this.btnFind.TabIndex = 88;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmFilteringType
            // 
            this.cmFilteringType.BackColor = System.Drawing.Color.Transparent;
            this.cmFilteringType.BorderRadius = 5;
            this.cmFilteringType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFilteringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilteringType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmFilteringType.ForeColor = System.Drawing.Color.Black;
            this.cmFilteringType.ItemHeight = 30;
            this.cmFilteringType.Items.AddRange(new object[] {
            "Employee ID",
            "National Nu"});
            this.cmFilteringType.Location = new System.Drawing.Point(170, 13);
            this.cmFilteringType.Margin = new System.Windows.Forms.Padding(2);
            this.cmFilteringType.Name = "cmFilteringType";
            this.cmFilteringType.Size = new System.Drawing.Size(188, 36);
            this.cmFilteringType.StartIndex = 0;
            this.cmFilteringType.TabIndex = 86;
            this.cmFilteringType.SelectedIndexChanged += new System.EventHandler(this.cmFilteringType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "FindBy:";
            // 
            // ctrlEmployeeDetailsWithFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFiltering);
            this.Controls.Add(this.ctrlEmployeeDetails1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ctrlEmployeeDetailsWithFiltering";
            this.Size = new System.Drawing.Size(896, 558);
            this.gbFiltering.ResumeLayout(false);
            this.gbFiltering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlEmployeeDetails ctrlEmployeeDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFiltering;
        private MyTextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2Button btnAddNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilteringType;
        private System.Windows.Forms.Label label9;
    }
}
