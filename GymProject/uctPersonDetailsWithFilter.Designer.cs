namespace GymMangementSystem
{
    partial class uctPersonDetailsWithFilter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tbSearch = new GymMangementSystem.MyTextBox();
            this.cbOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uctPersonDetails1 = new GymMangementSystem.uctPersonDetails();
            this.panel1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbFilter);
            this.panel1.Controls.Add(this.uctPersonDetails1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 376);
            this.panel1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.guna2CircleButton1);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbSearch);
            this.gbFilter.Controls.Add(this.cbOptions);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(5, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(882, 64);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::GymMangementSystem.Properties.Resources.AddUser;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.Location = new System.Drawing.Point(771, 20);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(46, 36);
            this.guna2CircleButton1.TabIndex = 9;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GymMangementSystem.Properties.Resources.SearchPerson;
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(709, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.Size = new System.Drawing.Size(51, 36);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 15;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.ErrorMessage = "This Field is Required";
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.InputType = GymMangementSystem.MyTextBox.TextType.Numeric;
            this.tbSearch.IsRequired = false;
            this.tbSearch.Location = new System.Drawing.Point(461, 20);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(241, 36);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbOptions.BorderRadius = 10;
            this.cbOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOptions.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbOptions.ForeColor = System.Drawing.Color.Black;
            this.cbOptions.ItemHeight = 30;
            this.cbOptions.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbOptions.Location = new System.Drawing.Point(244, 20);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(199, 36);
            this.cbOptions.StartIndex = 0;
            this.cbOptions.TabIndex = 6;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find By :";
            // 
            // uctPersonDetails1
            // 
            this.uctPersonDetails1.BackColor = System.Drawing.Color.White;
            this.uctPersonDetails1.Location = new System.Drawing.Point(5, 69);
            this.uctPersonDetails1.Name = "uctPersonDetails1";
            this.uctPersonDetails1.Size = new System.Drawing.Size(882, 302);
            this.uctPersonDetails1.TabIndex = 2;
            // 
            // uctPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "uctPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(900, 383);
            this.panel1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private uctPersonDetails uctPersonDetails1;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private MyTextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbOptions;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
