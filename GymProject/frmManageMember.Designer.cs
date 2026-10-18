namespace GymMangementSystem
{
    partial class frmManageMember
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltering = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmSelectTypeOfFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMembersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyContactInfoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackgroundImage = global::GymMangementSystem.Properties.Resources.AddUser;
            this.btnAddMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMember.Location = new System.Drawing.Point(1644, 372);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(57, 44);
            this.btnAddMember.TabIndex = 116;
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 2;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Image = global::GymMangementSystem.Properties.Resources.Close_321;
            this.btnClose.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(1531, 885);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 34);
            this.btnClose.TabIndex = 115;
            this.btnClose.Text = "Close";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(113, 871);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(49, 25);
            this.lblRecord.TabIndex = 114;
            this.lblRecord.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 869);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "#Records:";
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
            this.txtFiltering.Location = new System.Drawing.Point(325, 382);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(230, 29);
            this.txtFiltering.TabIndex = 112;
            this.txtFiltering.Visible = false;
            // 
            // cmSelectTypeOfFiltering
            // 
            this.cmSelectTypeOfFiltering.BackColor = System.Drawing.Color.Transparent;
            this.cmSelectTypeOfFiltering.BorderRadius = 5;
            this.cmSelectTypeOfFiltering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmSelectTypeOfFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSelectTypeOfFiltering.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmSelectTypeOfFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmSelectTypeOfFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmSelectTypeOfFiltering.ForeColor = System.Drawing.Color.Black;
            this.cmSelectTypeOfFiltering.ItemHeight = 30;
            this.cmSelectTypeOfFiltering.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "Full Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email",
            "Address"});
            this.cmSelectTypeOfFiltering.Location = new System.Drawing.Point(109, 378);
            this.cmSelectTypeOfFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.cmSelectTypeOfFiltering.Name = "cmSelectTypeOfFiltering";
            this.cmSelectTypeOfFiltering.Size = new System.Drawing.Size(209, 36);
            this.cmSelectTypeOfFiltering.StartIndex = 0;
            this.cmSelectTypeOfFiltering.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 110;
            this.label9.Text = "Filter By:";
            // 
            // dgvMembersList
            // 
            this.dgvMembersList.AllowUserToAddRows = false;
            this.dgvMembersList.AllowUserToDeleteRows = false;
            this.dgvMembersList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMembersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvMembersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembersList.ColumnHeadersHeight = 35;
            this.dgvMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMembersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName,
            this.clnID,
            this.CurrencyName,
            this.Column4,
            this.ImagePath,
            this.Column5,
            this.Column3,
            this.Address,
            this.EmergencyContactInfoID,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMembersList.Location = new System.Drawing.Point(2, 427);
            this.dgvMembersList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMembersList.Name = "dgvMembersList";
            this.dgvMembersList.ReadOnly = true;
            this.dgvMembersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembersList.RowHeadersVisible = false;
            this.dgvMembersList.RowHeadersWidth = 65;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMembersList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembersList.RowTemplate.Height = 35;
            this.dgvMembersList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembersList.Size = new System.Drawing.Size(1697, 417);
            this.dgvMembersList.TabIndex = 109;
            this.dgvMembersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMembersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvMembersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMembersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembersList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMembersList.ThemeStyle.ReadOnly = true;
            this.dgvMembersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvMembersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembersList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMembersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(2, 899);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(152, 10);
            this.guna2Separator1.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 59);
            this.label1.TabIndex = 118;
            this.label1.Text = "Manage Members";
            // 
            // CountryName
            // 
            this.CountryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CountryName.DataPropertyName = "MemberID";
            this.CountryName.HeaderText = "Member ID";
            this.CountryName.MinimumWidth = 6;
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            this.CountryName.Width = 150;
            // 
            // clnID
            // 
            this.clnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnID.DataPropertyName = "ID";
            this.clnID.HeaderText = "PersonID";
            this.clnID.MinimumWidth = 3;
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Width = 150;
            // 
            // CurrencyName
            // 
            this.CurrencyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurrencyName.DataPropertyName = "FullName";
            this.CurrencyName.HeaderText = "Full Name";
            this.CurrencyName.MinimumWidth = 6;
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.ReadOnly = true;
            this.CurrencyName.Width = 400;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // ImagePath
            // 
            this.ImagePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImagePath.DataPropertyName = "PhoneNumber";
            this.ImagePath.HeaderText = "Phone Number";
            this.ImagePath.MinimumWidth = 6;
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Width = 250;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "CountryName";
            this.Column3.HeaderText = "Country";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.DataPropertyName = "LastSubscriptionDate";
            this.Address.HeaderText = "Last Subscription Date";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // EmergencyContactInfoID
            // 
            this.EmergencyContactInfoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmergencyContactInfoID.DataPropertyName = "EmergencyContactID";
            this.EmergencyContactInfoID.HeaderText = "EmergencyContactID";
            this.EmergencyContactInfoID.MinimumWidth = 6;
            this.EmergencyContactInfoID.Name = "EmergencyContactInfoID";
            this.EmergencyContactInfoID.ReadOnly = true;
            this.EmergencyContactInfoID.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "IsActive";
            this.Column1.HeaderText = "IsActive";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // frmManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 935);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltering);
            this.Controls.Add(this.cmSelectTypeOfFiltering);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvMembersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manage Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cmSelectTypeOfFiltering;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMembersList;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyContactInfoID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}