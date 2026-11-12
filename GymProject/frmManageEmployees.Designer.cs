namespace GymMangementSystem
{
    partial class frmManageEmployees
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.cmIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmSelectTypeOfFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmShiftType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFiltering = new GymMangementSystem.MyTextBox();
            this.btnAddNewPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.ColumnHeadersHeight = 30;
            this.dgvEmployees.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.GridColor = System.Drawing.Color.Black;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 276);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.Size = new System.Drawing.Size(1365, 426);
            this.dgvEmployees.TabIndex = 116;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployees.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvEmployees.ThemeStyle.ReadOnly = true;
            this.dgvEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 162);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.showDetailsToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.showٍSubscription_details_32x32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.addEmployeeToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.add_32x32;
            this.addEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.edit_32;
            this.updateEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.delete_icon_32x32;
            this.deleteEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(113, 721);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(38, 20);
            this.lblRecord.TabIndex = 118;
            this.lblRecord.Text = "N/A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 719);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "#Records:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(19, 741);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(130, 8);
            this.guna2Separator1.TabIndex = 120;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lblTitle2);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1736, 37);
            this.panel4.TabIndex = 122;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(47, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 31);
            this.panel1.TabIndex = 15;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(54, 5);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(239, 26);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Employees Management";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::GymMangementSystem.Properties.Resources.Employees;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // cmIsActive
            // 
            this.cmIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cmIsActive.BorderRadius = 5;
            this.cmIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmIsActive.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmIsActive.ForeColor = System.Drawing.Color.Black;
            this.cmIsActive.ItemHeight = 30;
            this.cmIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmIsActive.Location = new System.Drawing.Point(292, 238);
            this.cmIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.cmIsActive.Name = "cmIsActive";
            this.cmIsActive.Size = new System.Drawing.Size(186, 36);
            this.cmIsActive.StartIndex = 0;
            this.cmIsActive.TabIndex = 127;
            this.cmIsActive.Visible = false;
            this.cmIsActive.SelectedIndexChanged += new System.EventHandler(this.cmIsActive_SelectedIndexChanged);
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
            "Employee ID",
            "Name",
            "Title",
            "Salary",
            "Hired Date",
            "Is Active",
            "Shift Type"});
            this.cmSelectTypeOfFiltering.Location = new System.Drawing.Point(97, 235);
            this.cmSelectTypeOfFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.cmSelectTypeOfFiltering.Name = "cmSelectTypeOfFiltering";
            this.cmSelectTypeOfFiltering.Size = new System.Drawing.Size(179, 36);
            this.cmSelectTypeOfFiltering.StartIndex = 0;
            this.cmSelectTypeOfFiltering.TabIndex = 125;
            this.cmSelectTypeOfFiltering.SelectedIndexChanged += new System.EventHandler(this.cmSelectTypeOfFiltering_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 124;
            this.label9.Text = "Filter By:";
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dtpDate.BorderRadius = 5;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "dd:MM:yyyy";
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(281, 236);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(177, 29);
            this.dtpDate.TabIndex = 128;
            this.dtpDate.Value = new System.DateTime(2026, 10, 22, 5, 0, 0, 0);
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // cmShiftType
            // 
            this.cmShiftType.BackColor = System.Drawing.Color.Transparent;
            this.cmShiftType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmShiftType.BorderRadius = 5;
            this.cmShiftType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmShiftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmShiftType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmShiftType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmShiftType.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmShiftType.ForeColor = System.Drawing.Color.Black;
            this.cmShiftType.ItemHeight = 30;
            this.cmShiftType.Location = new System.Drawing.Point(292, 235);
            this.cmShiftType.Margin = new System.Windows.Forms.Padding(2);
            this.cmShiftType.Name = "cmShiftType";
            this.cmShiftType.Size = new System.Drawing.Size(198, 36);
            this.cmShiftType.TabIndex = 129;
            this.cmShiftType.Visible = false;
            this.cmShiftType.SelectedIndexChanged += new System.EventHandler(this.cmShiftType_SelectedIndexChanged);
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
            this.txtFiltering.IsRequired = false;
            this.txtFiltering.Location = new System.Drawing.Point(281, 235);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(225, 29);
            this.txtFiltering.TabIndex = 126;
            this.txtFiltering.Visible = false;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            this.txtFiltering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltering_KeyPress);
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPayment.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewPayment.BorderRadius = 5;
            this.btnAddNewPayment.BorderThickness = 1;
            this.btnAddNewPayment.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPayment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewPayment.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPayment.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewPayment.Image = global::GymMangementSystem.Properties.Resources.AddUser;
            this.btnAddNewPayment.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnAddNewPayment.ImageSize = new System.Drawing.Size(35, 30);
            this.btnAddNewPayment.Location = new System.Drawing.Point(1302, 240);
            this.btnAddNewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(66, 29);
            this.btnAddNewPayment.TabIndex = 130;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnClose.Image = global::GymMangementSystem.Properties.Resources.Close_32;
            this.btnClose.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(1234, 712);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 33);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GymMangementSystem.Properties.Resources.Employees;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1736, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 599);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.cmShiftType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmIsActive);
            this.Controls.Add(this.txtFiltering);
            this.Controls.Add(this.cmSelectTypeOfFiltering);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageEmployees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmIsActive;
        private MyTextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cmSelectTypeOfFiltering;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmShiftType;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPayment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
    }
}