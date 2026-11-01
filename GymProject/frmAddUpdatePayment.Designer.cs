namespace GymMangementSystem
{
    partial class frmAddUpdatePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePayment));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tcPayment = new System.Windows.Forms.TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberDetailsWithFiltering1 = new GymMangementSystem.ctrlMemberBasicDetailsWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.nudPaymentAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox6 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPaymentDetails1 = new GymMangementSystem.ctrlPaymentDetails();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tcPayment.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox6)).BeginInit();
            this.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(1708, 37);
            this.panel4.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(47, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 34);
            this.panel1.TabIndex = 109;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(49, 5);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(210, 26);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Add/Update Payment";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::GymMangementSystem.Properties.Resources.Classes;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // tcPayment
            // 
            this.tcPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPayment.Controls.Add(this.tpMemberInfo);
            this.tcPayment.Controls.Add(this.tpPaymentInfo);
            this.tcPayment.Location = new System.Drawing.Point(0, 30);
            this.tcPayment.Name = "tcPayment";
            this.tcPayment.SelectedIndex = 0;
            this.tcPayment.Size = new System.Drawing.Size(974, 586);
            this.tcPayment.TabIndex = 91;
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.Controls.Add(this.ctrlMemberDetailsWithFiltering1);
            this.tpMemberInfo.Controls.Add(this.btnNext);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 22);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(966, 560);
            this.tpMemberInfo.TabIndex = 0;
            this.tpMemberInfo.Text = "Member Info";
            this.tpMemberInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlMemberDetailsWithFiltering1
            // 
            this.ctrlMemberDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetailsWithFiltering1.EnableFiltering = true;
            this.ctrlMemberDetailsWithFiltering1.Location = new System.Drawing.Point(5, 5);
            this.ctrlMemberDetailsWithFiltering1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlMemberDetailsWithFiltering1.Name = "ctrlMemberDetailsWithFiltering1";
            this.ctrlMemberDetailsWithFiltering1.Size = new System.Drawing.Size(968, 509);
            this.ctrlMemberDetailsWithFiltering1.TabIndex = 21;
            this.ctrlMemberDetailsWithFiltering1.OnMemberSelected += new System.EventHandler<GymMangementSystem.ctrlMemberBasicDetailsWithFilter.MemberEventArgs>(this.ctrlMemberDetailsWithFiltering1_OnMemberSelected);
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNext.BorderRadius = 5;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnNext.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(823, 516);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 35);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.Controls.Add(this.nudPaymentAmount);
            this.tpPaymentInfo.Controls.Add(this.cmPaymentMethod);
            this.tpPaymentInfo.Controls.Add(this.guna2CirclePictureBox1);
            this.tpPaymentInfo.Controls.Add(this.label2);
            this.tpPaymentInfo.Controls.Add(this.guna2CirclePictureBox6);
            this.tpPaymentInfo.Controls.Add(this.label1);
            this.tpPaymentInfo.Controls.Add(this.ctrlPaymentDetails1);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentInfo.Size = new System.Drawing.Size(966, 560);
            this.tpPaymentInfo.TabIndex = 1;
            this.tpPaymentInfo.Text = "Payment Info";
            this.tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // nudPaymentAmount
            // 
            this.nudPaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.nudPaymentAmount.BorderRadius = 7;
            this.nudPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudPaymentAmount.Location = new System.Drawing.Point(198, 6);
            this.nudPaymentAmount.Name = "nudPaymentAmount";
            this.nudPaymentAmount.Size = new System.Drawing.Size(299, 36);
            this.nudPaymentAmount.TabIndex = 105;
            this.nudPaymentAmount.UpDownButtonFillColor = System.Drawing.Color.White;
            // 
            // cmPaymentMethod
            // 
            this.cmPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmPaymentMethod.BorderRadius = 7;
            this.cmPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cmPaymentMethod.ItemHeight = 30;
            this.cmPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmPaymentMethod.Location = new System.Drawing.Point(198, 59);
            this.cmPaymentMethod.Name = "cmPaymentMethod";
            this.cmPaymentMethod.Size = new System.Drawing.Size(299, 36);
            this.cmPaymentMethod.StartIndex = 0;
            this.cmPaymentMethod.TabIndex = 104;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::GymMangementSystem.Properties.Resources.Money;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-2, 52);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 48);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 103;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Payment Method :";
            // 
            // guna2CirclePictureBox6
            // 
            this.guna2CirclePictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox6.Image = global::GymMangementSystem.Properties.Resources.Money;
            this.guna2CirclePictureBox6.ImageRotate = 0F;
            this.guna2CirclePictureBox6.Location = new System.Drawing.Point(-2, -5);
            this.guna2CirclePictureBox6.Name = "guna2CirclePictureBox6";
            this.guna2CirclePictureBox6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox6.Size = new System.Drawing.Size(45, 48);
            this.guna2CirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox6.TabIndex = 101;
            this.guna2CirclePictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "Payment Amount :";
            // 
            // ctrlPaymentDetails1
            // 
            this.ctrlPaymentDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPaymentDetails1.Location = new System.Drawing.Point(503, 3);
            this.ctrlPaymentDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPaymentDetails1.Name = "ctrlPaymentDetails1";
            this.ctrlPaymentDetails1.Size = new System.Drawing.Size(458, 550);
            this.ctrlPaymentDetails1.TabIndex = 98;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(850, 621);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            // 
            // btnClose
            // 
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
            this.btnClose.Location = new System.Drawing.Point(699, 621);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 30);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 655);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcPayment);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdatePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddUpdatePayment_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tcPayment.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpPaymentInfo.ResumeLayout(false);
            this.tpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TabControl tcPayment;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cmPaymentMethod;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox6;
        private System.Windows.Forms.Label label1;
        private ctrlPaymentDetails ctrlPaymentDetails1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private ctrlMemberBasicDetailsWithFilter ctrlMemberDetailsWithFiltering1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPaymentAmount;
    }
}