namespace GymMangementSystem
{
    partial class ctrlMemberDetailsWithFiltering
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
            this.ctrlMemebrDetails1 = new GymMangementSystem.ctrlMemebrDetails();
            this.grbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddNewMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmFilteringType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlMemebrDetails1
            // 
            this.ctrlMemebrDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemebrDetails1.Location = new System.Drawing.Point(4, 90);
            this.ctrlMemebrDetails1.Name = "ctrlMemebrDetails1";
            this.ctrlMemebrDetails1.Size = new System.Drawing.Size(1202, 713);
            this.ctrlMemebrDetails1.TabIndex = 0;
            // 
            // grbFilter
            // 
            this.grbFilter.BorderColor = System.Drawing.Color.Gainsboro;
            this.grbFilter.BorderRadius = 5;
            this.grbFilter.Controls.Add(this.btnAddNewMember);
            this.grbFilter.Controls.Add(this.btnFind);
            this.grbFilter.Controls.Add(this.txtFiltering);
            this.grbFilter.Controls.Add(this.cmFilteringType);
            this.grbFilter.Controls.Add(this.label9);
            this.grbFilter.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grbFilter.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.ForeColor = System.Drawing.Color.Black;
            this.grbFilter.Location = new System.Drawing.Point(4, 4);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1202, 81);
            this.grbFilter.TabIndex = 2;
            this.grbFilter.Text = "Filter";
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
            this.btnAddNewMember.Location = new System.Drawing.Point(960, 32);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(77, 36);
            this.btnAddNewMember.TabIndex = 89;
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
            this.btnFind.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.Image = global::GymMangementSystem.Properties.Resources.SearchPerson;
            this.btnFind.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnFind.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFind.Location = new System.Drawing.Point(861, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 36);
            this.btnFind.TabIndex = 88;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFiltering
            // 
            this.txtFiltering.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltering.BorderRadius = 5;
            this.txtFiltering.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltering.DefaultText = "";
            this.txtFiltering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFiltering.ForeColor = System.Drawing.Color.Black;
            this.txtFiltering.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltering.Location = new System.Drawing.Point(495, 32);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(320, 36);
            this.txtFiltering.TabIndex = 87;
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
            "Memebr ID"});
            this.cmFilteringType.Location = new System.Drawing.Point(226, 32);
            this.cmFilteringType.Name = "cmFilteringType";
            this.cmFilteringType.Size = new System.Drawing.Size(249, 36);
            this.cmFilteringType.StartIndex = 0;
            this.cmFilteringType.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "FindBy:";
            // 
            // ctrlMemberDetailsWithFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.ctrlMemebrDetails1);
            this.Name = "ctrlMemberDetailsWithFiltering";
            this.Size = new System.Drawing.Size(1210, 804);
            this.Load += new System.EventHandler(this.ctrlMemberDetailsWithFiltering_Load);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMemebrDetails ctrlMemebrDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox grbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewMember;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilteringType;
        private System.Windows.Forms.Label label9;
    }
}
