namespace GymMangementSystem
{
    partial class frmManagePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePayments));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.cbValue = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new GymMangementSystem.MyTextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
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
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1548, 46);
            this.panel4.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(59, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 39);
            this.panel1.TabIndex = 15;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(68, 6);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(275, 32);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Payment Management";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::GymMangementSystem.Properties.Resources.PaymentDetails;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 46);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // cbValue
            // 
            this.cbValue.BackColor = System.Drawing.Color.Transparent;
            this.cbValue.BorderRadius = 5;
            this.cbValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbValue.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.cbValue.ForeColor = System.Drawing.Color.Black;
            this.cbValue.ItemHeight = 30;
            this.cbValue.Items.AddRange(new object[] {
            "None",
            "Payment ID",
            "Subscription ID",
            "Member Name",
            "Method",
            "Date",
            "Username",
            "Status"});
            this.cbValue.Location = new System.Drawing.Point(125, 358);
            this.cbValue.Margin = new System.Windows.Forms.Padding(4);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(315, 36);
            this.cbValue.StartIndex = 0;
            this.cbValue.TabIndex = 118;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 117;
            this.label9.Text = "Filter By:";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.ColumnHeadersHeight = 30;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.SubscriptionID,
            this.Column1,
            this.PaymentAmount,
            this.ActualAmount,
            this.TotalRemaining,
            this.PaymentMethod,
            this.Date,
            this.Username,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.GridColor = System.Drawing.Color.Black;
            this.dgvPayment.Location = new System.Drawing.Point(8, 405);
            this.dgvPayment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayment.RowHeadersVisible = false;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.Size = new System.Drawing.Size(1534, 438);
            this.dgvPayment.TabIndex = 115;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvPayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvPayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayment.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPayment.ThemeStyle.ReadOnly = true;
            this.dgvPayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPayment.Click += new System.EventHandler(this.dgvPayment_Click);
            // 
            // PaymentID
            // 
            this.PaymentID.DataPropertyName = "Payment ID";
            this.PaymentID.FillWeight = 93.54671F;
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.MinimumWidth = 6;
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            // 
            // SubscriptionID
            // 
            this.SubscriptionID.DataPropertyName = "Subscription ID";
            this.SubscriptionID.FillWeight = 103.486F;
            this.SubscriptionID.HeaderText = "Subscription ID";
            this.SubscriptionID.MinimumWidth = 6;
            this.SubscriptionID.Name = "SubscriptionID";
            this.SubscriptionID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Member Name";
            this.Column1.HeaderText = "Member Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.DataPropertyName = "Payment Amount";
            this.PaymentAmount.FillWeight = 92.42361F;
            this.PaymentAmount.HeaderText = "Amount";
            this.PaymentAmount.MinimumWidth = 6;
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            // 
            // ActualAmount
            // 
            this.ActualAmount.DataPropertyName = "Actual Amount";
            this.ActualAmount.FillWeight = 117.28F;
            this.ActualAmount.HeaderText = "Actual Amount";
            this.ActualAmount.MinimumWidth = 6;
            this.ActualAmount.Name = "ActualAmount";
            this.ActualAmount.ReadOnly = true;
            // 
            // TotalRemaining
            // 
            this.TotalRemaining.DataPropertyName = "Total Remaining";
            this.TotalRemaining.FillWeight = 140.9879F;
            this.TotalRemaining.HeaderText = "Total Remaining";
            this.TotalRemaining.MinimumWidth = 6;
            this.TotalRemaining.Name = "TotalRemaining";
            this.TotalRemaining.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "Payment Method";
            this.PaymentMethod.FillWeight = 67.6385F;
            this.PaymentMethod.HeaderText = "Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 103.486F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 77.66496F;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 103.486F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(5, 914);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(203, 12);
            this.guna2Separator1.TabIndex = 121;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(132, 886);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(49, 25);
            this.lblRecord.TabIndex = 120;
            this.lblRecord.Text = "N/A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 885);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "#Records:";
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbMethod.BorderRadius = 5;
            this.cbMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethod.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.cbMethod.ForeColor = System.Drawing.Color.Black;
            this.cbMethod.ItemHeight = 30;
            this.cbMethod.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Card"});
            this.cbMethod.Location = new System.Drawing.Point(449, 352);
            this.cbMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(172, 36);
            this.cbMethod.StartIndex = 0;
            this.cbMethod.TabIndex = 123;
            this.cbMethod.Visible = false;
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dtpTime.BorderRadius = 5;
            this.dtpTime.BorderThickness = 1;
            this.dtpTime.Checked = true;
            this.dtpTime.CustomFormat = "yyyy/MM/dd";
            this.dtpTime.FillColor = System.Drawing.Color.White;
            this.dtpTime.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime.Location = new System.Drawing.Point(453, 358);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(208, 36);
            this.dtpTime.TabIndex = 124;
            this.dtpTime.Value = new System.DateTime(2026, 10, 22, 5, 0, 0, 0);
            this.dtpTime.Visible = false;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // cmStatus
            // 
            this.cmStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmStatus.BorderRadius = 5;
            this.cmStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmStatus.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.cmStatus.ForeColor = System.Drawing.Color.Black;
            this.cmStatus.ItemHeight = 30;
            this.cmStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed",
            "Refunded",
            "Partailly Refunded"});
            this.cmStatus.Location = new System.Drawing.Point(451, 357);
            this.cmStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmStatus.Name = "cmStatus";
            this.cmStatus.Size = new System.Drawing.Size(277, 36);
            this.cmStatus.StartIndex = 0;
            this.cmStatus.TabIndex = 126;
            this.cmStatus.Visible = false;
            this.cmStatus.SelectedIndexChanged += new System.EventHandler(this.cmStatus_SelectedIndexChanged);
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
            this.btnAddNewPayment.Image = global::GymMangementSystem.Properties.Resources.AddPyament;
            this.btnAddNewPayment.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnAddNewPayment.ImageSize = new System.Drawing.Size(42, 50);
            this.btnAddNewPayment.Location = new System.Drawing.Point(1455, 359);
            this.btnAddNewPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(83, 36);
            this.btnAddNewPayment.TabIndex = 127;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(1359, 886);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 37);
            this.btnClose.TabIndex = 125;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.ErrorMessage = "This Field is Required";
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.InputType = GymMangementSystem.MyTextBox.TextType.Text;
            this.txtSearch.IsRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(450, 358);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(317, 36);
            this.txtSearch.TabIndex = 140;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1548, 938);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.cmStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManagePayments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManagementPayment_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Guna.UI2.WinForms.Guna2ComboBox cbValue;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayment;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbMethod;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTime;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cmStatus;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MyTextBox txtSearch;
    }
}