namespace GymMangementSystem
{
    partial class ctrlSubscriptionsHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbExpired = new System.Windows.Forms.TabPage();
            this.tbFrozen = new System.Windows.Forms.TabPage();
            this.tbCancelled = new System.Windows.Forms.TabPage();
            this.tbChanged = new System.Windows.Forms.TabPage();
            this.lblExpiredRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrozenRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCancelledRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChangedRecord = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvExpiredSubscriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvFrozenSubscriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCancelledSubscriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvChangedSubscriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbExpired.SuspendLayout();
            this.tbFrozen.SuspendLayout();
            this.tbCancelled.SuspendLayout();
            this.tbChanged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrozenSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelledSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangedSubscriptions)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbExpired);
            this.tabControl1.Controls.Add(this.tbFrozen);
            this.tabControl1.Controls.Add(this.tbCancelled);
            this.tabControl1.Controls.Add(this.tbChanged);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 316);
            this.tabControl1.TabIndex = 1;
            // 
            // tbExpired
            // 
            this.tbExpired.Controls.Add(this.dgvExpiredSubscriptions);
            this.tbExpired.Controls.Add(this.lblExpiredRecord);
            this.tbExpired.Controls.Add(this.label2);
            this.tbExpired.Location = new System.Drawing.Point(4, 34);
            this.tbExpired.Name = "tbExpired";
            this.tbExpired.Size = new System.Drawing.Size(1161, 278);
            this.tbExpired.TabIndex = 4;
            this.tbExpired.Text = "Expired";
            this.tbExpired.UseVisualStyleBackColor = true;
            // 
            // tbFrozen
            // 
            this.tbFrozen.Controls.Add(this.dgvFrozenSubscriptions);
            this.tbFrozen.Controls.Add(this.lblFrozenRecord);
            this.tbFrozen.Controls.Add(this.label3);
            this.tbFrozen.Location = new System.Drawing.Point(4, 34);
            this.tbFrozen.Name = "tbFrozen";
            this.tbFrozen.Padding = new System.Windows.Forms.Padding(3);
            this.tbFrozen.Size = new System.Drawing.Size(1161, 278);
            this.tbFrozen.TabIndex = 1;
            this.tbFrozen.Text = "Frozen";
            this.tbFrozen.UseVisualStyleBackColor = true;
            // 
            // tbCancelled
            // 
            this.tbCancelled.Controls.Add(this.dgvCancelledSubscriptions);
            this.tbCancelled.Controls.Add(this.lblCancelledRecord);
            this.tbCancelled.Controls.Add(this.label4);
            this.tbCancelled.Location = new System.Drawing.Point(4, 34);
            this.tbCancelled.Name = "tbCancelled";
            this.tbCancelled.Size = new System.Drawing.Size(1161, 278);
            this.tbCancelled.TabIndex = 2;
            this.tbCancelled.Text = "Cancelled";
            this.tbCancelled.UseVisualStyleBackColor = true;
            // 
            // tbChanged
            // 
            this.tbChanged.Controls.Add(this.dgvChangedSubscriptions);
            this.tbChanged.Controls.Add(this.lblChangedRecord);
            this.tbChanged.Controls.Add(this.label6);
            this.tbChanged.Location = new System.Drawing.Point(4, 34);
            this.tbChanged.Name = "tbChanged";
            this.tbChanged.Size = new System.Drawing.Size(1161, 278);
            this.tbChanged.TabIndex = 3;
            this.tbChanged.Text = "Changed";
            this.tbChanged.UseVisualStyleBackColor = true;
            // 
            // lblExpiredRecord
            // 
            this.lblExpiredRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpiredRecord.AutoSize = true;
            this.lblExpiredRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredRecord.Location = new System.Drawing.Point(120, 247);
            this.lblExpiredRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiredRecord.Name = "lblExpiredRecord";
            this.lblExpiredRecord.Size = new System.Drawing.Size(49, 25);
            this.lblExpiredRecord.TabIndex = 101;
            this.lblExpiredRecord.Text = "N/A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "#Records:";
            // 
            // lblFrozenRecord
            // 
            this.lblFrozenRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFrozenRecord.AutoSize = true;
            this.lblFrozenRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrozenRecord.Location = new System.Drawing.Point(120, 247);
            this.lblFrozenRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrozenRecord.Name = "lblFrozenRecord";
            this.lblFrozenRecord.Size = new System.Drawing.Size(49, 25);
            this.lblFrozenRecord.TabIndex = 103;
            this.lblFrozenRecord.Text = "N/A";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 102;
            this.label3.Text = "#Records:";
            // 
            // lblCancelledRecord
            // 
            this.lblCancelledRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCancelledRecord.AutoSize = true;
            this.lblCancelledRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledRecord.Location = new System.Drawing.Point(119, 247);
            this.lblCancelledRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancelledRecord.Name = "lblCancelledRecord";
            this.lblCancelledRecord.Size = new System.Drawing.Size(49, 25);
            this.lblCancelledRecord.TabIndex = 105;
            this.lblCancelledRecord.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 104;
            this.label4.Text = "#Records:";
            // 
            // lblChangedRecord
            // 
            this.lblChangedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangedRecord.AutoSize = true;
            this.lblChangedRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangedRecord.Location = new System.Drawing.Point(120, 247);
            this.lblChangedRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangedRecord.Name = "lblChangedRecord";
            this.lblChangedRecord.Size = new System.Drawing.Size(49, 25);
            this.lblChangedRecord.TabIndex = 107;
            this.lblChangedRecord.Text = "N/A";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 106;
            this.label6.Text = "#Records:";
            // 
            // dgvExpiredSubscriptions
            // 
            this.dgvExpiredSubscriptions.AllowUserToAddRows = false;
            this.dgvExpiredSubscriptions.AllowUserToDeleteRows = false;
            this.dgvExpiredSubscriptions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvExpiredSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvExpiredSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpiredSubscriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvExpiredSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpiredSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvExpiredSubscriptions.ColumnHeadersHeight = 35;
            this.dgvExpiredSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpiredSubscriptions.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvExpiredSubscriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExpiredSubscriptions.Location = new System.Drawing.Point(8, 8);
            this.dgvExpiredSubscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpiredSubscriptions.Name = "dgvExpiredSubscriptions";
            this.dgvExpiredSubscriptions.ReadOnly = true;
            this.dgvExpiredSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpiredSubscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvExpiredSubscriptions.RowHeadersVisible = false;
            this.dgvExpiredSubscriptions.RowHeadersWidth = 65;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpiredSubscriptions.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvExpiredSubscriptions.RowTemplate.Height = 35;
            this.dgvExpiredSubscriptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpiredSubscriptions.Size = new System.Drawing.Size(1143, 229);
            this.dgvExpiredSubscriptions.TabIndex = 103;
            this.dgvExpiredSubscriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpiredSubscriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvExpiredSubscriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExpiredSubscriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpiredSubscriptions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvExpiredSubscriptions.ThemeStyle.ReadOnly = true;
            this.dgvExpiredSubscriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvExpiredSubscriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpiredSubscriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvExpiredSubscriptions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvExpiredSubscriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // dgvFrozenSubscriptions
            // 
            this.dgvFrozenSubscriptions.AllowUserToAddRows = false;
            this.dgvFrozenSubscriptions.AllowUserToDeleteRows = false;
            this.dgvFrozenSubscriptions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            this.dgvFrozenSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvFrozenSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFrozenSubscriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvFrozenSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrozenSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvFrozenSubscriptions.ColumnHeadersHeight = 35;
            this.dgvFrozenSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrozenSubscriptions.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvFrozenSubscriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFrozenSubscriptions.Location = new System.Drawing.Point(8, 9);
            this.dgvFrozenSubscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFrozenSubscriptions.Name = "dgvFrozenSubscriptions";
            this.dgvFrozenSubscriptions.ReadOnly = true;
            this.dgvFrozenSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrozenSubscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvFrozenSubscriptions.RowHeadersVisible = false;
            this.dgvFrozenSubscriptions.RowHeadersWidth = 65;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFrozenSubscriptions.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvFrozenSubscriptions.RowTemplate.Height = 35;
            this.dgvFrozenSubscriptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrozenSubscriptions.Size = new System.Drawing.Size(1145, 229);
            this.dgvFrozenSubscriptions.TabIndex = 104;
            this.dgvFrozenSubscriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFrozenSubscriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvFrozenSubscriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFrozenSubscriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFrozenSubscriptions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvFrozenSubscriptions.ThemeStyle.ReadOnly = true;
            this.dgvFrozenSubscriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvFrozenSubscriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFrozenSubscriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvFrozenSubscriptions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvFrozenSubscriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // dgvCancelledSubscriptions
            // 
            this.dgvCancelledSubscriptions.AllowUserToAddRows = false;
            this.dgvCancelledSubscriptions.AllowUserToDeleteRows = false;
            this.dgvCancelledSubscriptions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dgvCancelledSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvCancelledSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCancelledSubscriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCancelledSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelledSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvCancelledSubscriptions.ColumnHeadersHeight = 35;
            this.dgvCancelledSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancelledSubscriptions.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvCancelledSubscriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCancelledSubscriptions.Location = new System.Drawing.Point(6, 10);
            this.dgvCancelledSubscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCancelledSubscriptions.Name = "dgvCancelledSubscriptions";
            this.dgvCancelledSubscriptions.ReadOnly = true;
            this.dgvCancelledSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelledSubscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvCancelledSubscriptions.RowHeadersVisible = false;
            this.dgvCancelledSubscriptions.RowHeadersWidth = 65;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCancelledSubscriptions.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvCancelledSubscriptions.RowTemplate.Height = 35;
            this.dgvCancelledSubscriptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelledSubscriptions.Size = new System.Drawing.Size(1151, 229);
            this.dgvCancelledSubscriptions.TabIndex = 106;
            this.dgvCancelledSubscriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCancelledSubscriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvCancelledSubscriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCancelledSubscriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCancelledSubscriptions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCancelledSubscriptions.ThemeStyle.ReadOnly = true;
            this.dgvCancelledSubscriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCancelledSubscriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCancelledSubscriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvCancelledSubscriptions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCancelledSubscriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // dgvChangedSubscriptions
            // 
            this.dgvChangedSubscriptions.AllowUserToAddRows = false;
            this.dgvChangedSubscriptions.AllowUserToDeleteRows = false;
            this.dgvChangedSubscriptions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            this.dgvChangedSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvChangedSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChangedSubscriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvChangedSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChangedSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvChangedSubscriptions.ColumnHeadersHeight = 35;
            this.dgvChangedSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChangedSubscriptions.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvChangedSubscriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChangedSubscriptions.Location = new System.Drawing.Point(7, 9);
            this.dgvChangedSubscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChangedSubscriptions.Name = "dgvChangedSubscriptions";
            this.dgvChangedSubscriptions.ReadOnly = true;
            this.dgvChangedSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChangedSubscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvChangedSubscriptions.RowHeadersVisible = false;
            this.dgvChangedSubscriptions.RowHeadersWidth = 65;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChangedSubscriptions.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvChangedSubscriptions.RowTemplate.Height = 35;
            this.dgvChangedSubscriptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChangedSubscriptions.Size = new System.Drawing.Size(1147, 229);
            this.dgvChangedSubscriptions.TabIndex = 108;
            this.dgvChangedSubscriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChangedSubscriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvChangedSubscriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChangedSubscriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChangedSubscriptions.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvChangedSubscriptions.ThemeStyle.ReadOnly = true;
            this.dgvChangedSubscriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvChangedSubscriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChangedSubscriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvChangedSubscriptions.ThemeStyle.RowsStyle.Height = 35;
            this.dgvChangedSubscriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.tabControl1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1179, 370);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.pictureBox7);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1179, 44);
            this.guna2Panel3.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 27);
            this.label8.TabIndex = 54;
            this.label8.Text = "Subscriptions History";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GymMangementSystem.Properties.Resources.ManageSubscpritions;
            this.pictureBox7.Location = new System.Drawing.Point(4, 4);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            // 
            // ctrlSubscriptionsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlSubscriptionsHistory";
            this.Size = new System.Drawing.Size(1186, 381);
            this.Load += new System.EventHandler(this.ctrlSubscriptionsHistory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbExpired.ResumeLayout(false);
            this.tbExpired.PerformLayout();
            this.tbFrozen.ResumeLayout(false);
            this.tbFrozen.PerformLayout();
            this.tbCancelled.ResumeLayout(false);
            this.tbCancelled.PerformLayout();
            this.tbChanged.ResumeLayout(false);
            this.tbChanged.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrozenSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelledSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangedSubscriptions)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFrozen;
        private System.Windows.Forms.TabPage tbCancelled;
        private System.Windows.Forms.TabPage tbChanged;
        private System.Windows.Forms.TabPage tbExpired;
        private System.Windows.Forms.Label lblExpiredRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFrozenRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCancelledRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChangedRecord;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExpiredSubscriptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFrozenSubscriptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCancelledSubscriptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChangedSubscriptions;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}
