namespace GymMangementSystem
{
    partial class ctrlPersonDetailsWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new GymMangementSystem.MyTextBox();
            this.cbOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.uctPersonDetails1 = new GymMangementSystem.ctrlPersonDetails();
            this.gbFilter.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNewMember);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbSearch);
            this.gbFilter.Controls.Add(this.cbOptions);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(7, 2);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(948, 65);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            this.btnAddNewMember.Location = new System.Drawing.Point(778, 24);
            this.btnAddNewMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(62, 29);
            this.btnAddNewMember.TabIndex = 91;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GymMangementSystem.Properties.Resources.SearchPerson;
            this.btnSearch.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(699, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 29);
            this.btnSearch.TabIndex = 90;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 5;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.ErrorMessage = "This Field is Required";
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.InputType = GymMangementSystem.MyTextBox.TextType.Numeric;
            this.tbSearch.IsRequired = true;
            this.tbSearch.Location = new System.Drawing.Point(438, 25);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(243, 29);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbOptions.BorderRadius = 5;
            this.cbOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbOptions.ForeColor = System.Drawing.Color.Black;
            this.cbOptions.ItemHeight = 30;
            this.cbOptions.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbOptions.Location = new System.Drawing.Point(220, 25);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(212, 36);
            this.cbOptions.StartIndex = 0;
            this.cbOptions.TabIndex = 6;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find By :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.gbFilter);
            this.guna2Panel1.Controls.Add(this.uctPersonDetails1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(962, 351);
            this.guna2Panel1.TabIndex = 7;
            // 
            // uctPersonDetails1
            // 
            this.uctPersonDetails1.BackColor = System.Drawing.Color.White;
            this.uctPersonDetails1.Location = new System.Drawing.Point(7, 71);
            this.uctPersonDetails1.Name = "uctPersonDetails1";
            this.uctPersonDetails1.Size = new System.Drawing.Size(948, 271);
            this.uctPersonDetails1.TabIndex = 6;
            // 
            // ctrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(967, 356);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private MyTextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbOptions;
        private System.Windows.Forms.Label label1;
        private ctrlPersonDetails uctPersonDetails1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewMember;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
