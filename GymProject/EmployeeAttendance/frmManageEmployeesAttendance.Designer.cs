namespace GymMangementSystem
{
    partial class frmManageEmployeesAttendance
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvEmployeesAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CheckOuttoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCheckType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmSelectTypeOfFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPayment = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFiltering = new GymMangementSystem.MyTextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesAttendance)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lblTitle2);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1370, 37);
            this.panel4.TabIndex = 124;
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
            this.lblTitle2.Location = new System.Drawing.Point(51, 8);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(351, 26);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Employees Attendance Management";
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GymMangementSystem.Properties.Resources.Employees;
            this.pictureBox1.Location = new System.Drawing.Point(-302, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2010, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // dgvEmployeesAttendance
            // 
            this.dgvEmployeesAttendance.AllowUserToAddRows = false;
            this.dgvEmployeesAttendance.AllowUserToDeleteRows = false;
            this.dgvEmployeesAttendance.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployeesAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeesAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeesAttendance.ColumnHeadersHeight = 30;
            this.dgvEmployeesAttendance.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeesAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeesAttendance.GridColor = System.Drawing.Color.Black;
            this.dgvEmployeesAttendance.Location = new System.Drawing.Point(0, 295);
            this.dgvEmployeesAttendance.Name = "dgvEmployeesAttendance";
            this.dgvEmployeesAttendance.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeesAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeesAttendance.RowHeadersVisible = false;
            this.dgvEmployeesAttendance.RowHeadersWidth = 51;
            this.dgvEmployeesAttendance.Size = new System.Drawing.Size(1448, 408);
            this.dgvEmployeesAttendance.TabIndex = 126;
            this.dgvEmployeesAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployeesAttendance.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvEmployeesAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvEmployeesAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployeesAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeesAttendance.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvEmployeesAttendance.ThemeStyle.ReadOnly = true;
            this.dgvEmployeesAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployeesAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeesAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvEmployeesAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CheckOuttoolStripMenuItem2,
            this.addEmployeeAttendanceToolStripMenuItem,
            this.updateEmployeeAttendanceToolStripMenuItem,
            this.deleteEmployeeAttendanceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(255, 222);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // EmployeeDetailsToolStripMenuItem
            // 
            this.EmployeeDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.EmployeeDetailsToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.showٍSubscription_details_32x32;
            this.EmployeeDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem";
            this.EmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.EmployeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.EmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.EmployeeDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 6);
            // 
            // CheckOuttoolStripMenuItem2
            // 
            this.CheckOuttoolStripMenuItem2.Image = global::GymMangementSystem.Properties.Resources.Check_Out_Employee_32x32;
            this.CheckOuttoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CheckOuttoolStripMenuItem2.Name = "CheckOuttoolStripMenuItem2";
            this.CheckOuttoolStripMenuItem2.Size = new System.Drawing.Size(254, 38);
            this.CheckOuttoolStripMenuItem2.Text = "Check Out";
            this.CheckOuttoolStripMenuItem2.Click += new System.EventHandler(this.CheckOuttoolStripMenuItem2_Click);
            // 
            // addEmployeeAttendanceToolStripMenuItem
            // 
            this.addEmployeeAttendanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.addEmployeeAttendanceToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.add_32x32;
            this.addEmployeeAttendanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployeeAttendanceToolStripMenuItem.Name = "addEmployeeAttendanceToolStripMenuItem";
            this.addEmployeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.addEmployeeAttendanceToolStripMenuItem.Text = "Add Employee Attendance";
            this.addEmployeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeAttendanceToolStripMenuItem_Click);
            // 
            // updateEmployeeAttendanceToolStripMenuItem
            // 
            this.updateEmployeeAttendanceToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.edit_32;
            this.updateEmployeeAttendanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeAttendanceToolStripMenuItem.Name = "updateEmployeeAttendanceToolStripMenuItem";
            this.updateEmployeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.updateEmployeeAttendanceToolStripMenuItem.Text = "Update Employee Attendance";
            this.updateEmployeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeAttendanceToolStripMenuItem_Click);
            // 
            // deleteEmployeeAttendanceToolStripMenuItem
            // 
            this.deleteEmployeeAttendanceToolStripMenuItem.Image = global::GymMangementSystem.Properties.Resources.delete_icon_32x32;
            this.deleteEmployeeAttendanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeAttendanceToolStripMenuItem.Name = "deleteEmployeeAttendanceToolStripMenuItem";
            this.deleteEmployeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.deleteEmployeeAttendanceToolStripMenuItem.Text = "Delete Employee Attendance";
            this.deleteEmployeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeAttendanceToolStripMenuItem_Click);
            // 
            // cmCheckType
            // 
            this.cmCheckType.BackColor = System.Drawing.Color.Transparent;
            this.cmCheckType.BorderRadius = 5;
            this.cmCheckType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmCheckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCheckType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmCheckType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmCheckType.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmCheckType.ForeColor = System.Drawing.Color.Black;
            this.cmCheckType.ItemHeight = 30;
            this.cmCheckType.Items.AddRange(new object[] {
            "All",
            "Is Checkin",
            "Is Checkout"});
            this.cmCheckType.Location = new System.Drawing.Point(270, 253);
            this.cmCheckType.Margin = new System.Windows.Forms.Padding(2);
            this.cmCheckType.Name = "cmCheckType";
            this.cmCheckType.Size = new System.Drawing.Size(187, 36);
            this.cmCheckType.TabIndex = 133;
            this.cmCheckType.Visible = false;
            this.cmCheckType.SelectedIndexChanged += new System.EventHandler(this.cmCheckType_SelectedIndexChanged);
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
            "Attendance ID",
            "Name",
            "Status",
            "Date"});
            this.cmSelectTypeOfFiltering.Location = new System.Drawing.Point(86, 254);
            this.cmSelectTypeOfFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.cmSelectTypeOfFiltering.Name = "cmSelectTypeOfFiltering";
            this.cmSelectTypeOfFiltering.Size = new System.Drawing.Size(179, 36);
            this.cmSelectTypeOfFiltering.StartIndex = 0;
            this.cmSelectTypeOfFiltering.TabIndex = 132;
            this.cmSelectTypeOfFiltering.SelectedIndexChanged += new System.EventHandler(this.cmSelectTypeOfFiltering_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 131;
            this.label9.Text = "Filter By:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(7, 740);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(130, 8);
            this.guna2Separator1.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 717);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "#Records:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(101, 719);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(38, 20);
            this.lblRecord.TabIndex = 134;
            this.lblRecord.Text = "N/A";
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
            this.btnClose.Location = new System.Drawing.Point(1236, 713);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 33);
            this.btnClose.TabIndex = 137;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAddNewPayment.Location = new System.Drawing.Point(1299, 253);
            this.btnAddNewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(66, 29);
            this.btnAddNewPayment.TabIndex = 138;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
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
            this.dtpDate.Location = new System.Drawing.Point(270, 253);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(214, 29);
            this.dtpDate.TabIndex = 140;
            this.dtpDate.Value = new System.DateTime(2026, 10, 22, 5, 0, 0, 0);
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            this.txtFiltering.Location = new System.Drawing.Point(270, 254);
            this.txtFiltering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.PlaceholderText = "Search...";
            this.txtFiltering.SelectedText = "";
            this.txtFiltering.Size = new System.Drawing.Size(225, 29);
            this.txtFiltering.TabIndex = 139;
            this.txtFiltering.Visible = false;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            // 
            // frmManageEmployeesAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtFiltering);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.cmCheckType);
            this.Controls.Add(this.cmSelectTypeOfFiltering);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvEmployeesAttendance);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageEmployeesAttendance";
            this.Text = "frmManageEmployeesAttendance";
            this.Load += new System.EventHandler(this.frmManageEmployeesAttendance_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesAttendance)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployeesAttendance;
        private Guna.UI2.WinForms.Guna2ComboBox cmCheckType;
        private Guna.UI2.WinForms.Guna2ComboBox cmSelectTypeOfFiltering;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPayment;
        private MyTextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckOuttoolStripMenuItem2;
    }
}