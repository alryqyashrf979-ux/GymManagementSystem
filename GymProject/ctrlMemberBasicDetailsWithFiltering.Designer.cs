namespace GymMangementSystem
{
    partial class ctrlMemberBasicDetailsWithFilter
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
            this.gbFiltering = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFiltering = new GymMangementSystem.MyTextBox();
            this.btnAddNewMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.cmFilteringType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlMemberBasicDetails1 = new GymMangementSystem.ctrlMemberBasicDetails();
            this.gbFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltering
            // 
            this.gbFiltering.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbFiltering.BorderRadius = 5;
            this.gbFiltering.Controls.Add(this.txtFiltering);
            this.gbFiltering.Controls.Add(this.btnAddNewMember);
            this.gbFiltering.Controls.Add(this.btnFind);
            this.gbFiltering.Controls.Add(this.cmFilteringType);
            this.gbFiltering.Controls.Add(this.label9);
            this.gbFiltering.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltering.ForeColor = System.Drawing.Color.Black;
            this.gbFiltering.Location = new System.Drawing.Point(3, 2);
            this.gbFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Size = new System.Drawing.Size(946, 53);
            this.gbFiltering.TabIndex = 2;
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
            this.txtFiltering.InputType = GymMangementSystem.MyTextBox.TextType.Text;
            this.txtFiltering.IsRequired = true;
            this.txtFiltering.Location = new System.Drawing.Point(388, 14);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(233, 28);
            this.txtFiltering.TabIndex = 90;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            this.txtFiltering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltering_KeyPress);
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewMember.BorderRadius = 5;
            this.btnAddNewMember.BorderThickness = 1;
            this.btnAddNewMember.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewMember.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewMember.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewMember.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewMember.Image = global::GymMangementSystem.Properties.Resources.AddUser;
            this.btnAddNewMember.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnAddNewMember.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewMember.Location = new System.Drawing.Point(752, 13);
            this.btnAddNewMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(62, 29);
            this.btnAddNewMember.TabIndex = 89;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
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
            this.btnFind.Location = new System.Drawing.Point(673, 13);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(62, 29);
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
            "National No.",
            "Member ID"});
            this.cmFilteringType.Location = new System.Drawing.Point(181, 13);
            this.cmFilteringType.Margin = new System.Windows.Forms.Padding(2);
            this.cmFilteringType.Name = "cmFilteringType";
            this.cmFilteringType.Size = new System.Drawing.Size(200, 36);
            this.cmFilteringType.StartIndex = 0;
            this.cmFilteringType.TabIndex = 86;
            this.cmFilteringType.SelectedIndexChanged += new System.EventHandler(this.cmFilteringType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "FindBy:";
            // 
            // ctrlMemberBasicDetails1
            // 
            this.ctrlMemberBasicDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberBasicDetails1.Location = new System.Drawing.Point(3, 55);
            this.ctrlMemberBasicDetails1.Name = "ctrlMemberBasicDetails1";
            this.ctrlMemberBasicDetails1.Size = new System.Drawing.Size(950, 446);
            this.ctrlMemberBasicDetails1.TabIndex = 3;
            // 
            // ctrlMemberBasicDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlMemberBasicDetails1);
            this.Controls.Add(this.gbFiltering);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlMemberBasicDetailsWithFilter";
            this.Size = new System.Drawing.Size(956, 506);
            this.gbFiltering.ResumeLayout(false);
            this.gbFiltering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbFiltering;
        private Guna.UI2.WinForms.Guna2Button btnAddNewMember;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilteringType;
        private System.Windows.Forms.Label label9;
        private MyTextBox txtFiltering;
        private ctrlMemberBasicDetails ctrlMemberBasicDetails1;
    }
}
