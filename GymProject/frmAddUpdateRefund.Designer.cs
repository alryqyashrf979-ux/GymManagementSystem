namespace GymMangementSystem
{
    partial class frmAddUpdateRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateRefund));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tcPayment = new System.Windows.Forms.TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberDetailsWithFiltering1 = new GymMangementSystem.ctrlMemberBasicDetailsWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.txtPaymentAmount = new GymMangementSystem.MyTextBox();
            this.cmPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPaymentDetails1 = new GymMangementSystem.ctrlPaymentDetails();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox6 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tcPayment.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox6)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(964, 41);
            this.panel4.TabIndex = 91;
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
            this.lblTitle2.Location = new System.Drawing.Point(49, 7);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(196, 26);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Add/Update Refund";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::GymMangementSystem.Properties.Resources.RefundWhite;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 41);
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
            this.tcPayment.Location = new System.Drawing.Point(-2, 40);
            this.tcPayment.Name = "tcPayment";
            this.tcPayment.SelectedIndex = 0;
            this.tcPayment.Size = new System.Drawing.Size(966, 581);
            this.tcPayment.TabIndex = 92;
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.Controls.Add(this.ctrlMemberDetailsWithFiltering1);
            this.tpMemberInfo.Controls.Add(this.btnNext);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 22);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(958, 555);
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
            this.ctrlMemberDetailsWithFiltering1.Size = new System.Drawing.Size(968, 505);
            this.ctrlMemberDetailsWithFiltering1.TabIndex = 21;
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
            this.btnNext.Location = new System.Drawing.Point(810, 512);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 35);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.Controls.Add(this.btnBack);
            this.tpPaymentInfo.Controls.Add(this.txtPaymentAmount);
            this.tpPaymentInfo.Controls.Add(this.cmPaymentMethod);
            this.tpPaymentInfo.Controls.Add(this.label2);
            this.tpPaymentInfo.Controls.Add(this.label1);
            this.tpPaymentInfo.Controls.Add(this.ctrlPaymentDetails1);
            this.tpPaymentInfo.Controls.Add(this.guna2CirclePictureBox1);
            this.tpPaymentInfo.Controls.Add(this.guna2CirclePictureBox6);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentInfo.Size = new System.Drawing.Size(958, 555);
            this.tpPaymentInfo.TabIndex = 1;
            this.tpPaymentInfo.Text = "Payment Info";
            this.tpPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBack.BorderRadius = 5;
            this.btnBack.BorderThickness = 1;
            this.btnBack.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::GymMangementSystem.Properties.Resources.Back;
            this.btnBack.ImageOffset = new System.Drawing.Point(-5, 1);
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(-11, 525);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 30);
            this.btnBack.TabIndex = 108;
            this.btnBack.Text = "Back";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BorderRadius = 7;
            this.txtPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentAmount.DefaultText = "";
            this.txtPaymentAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentAmount.ErrorMessage = "This Field is Required";
            this.txtPaymentAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaymentAmount.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentAmount.InputType = GymMangementSystem.MyTextBox.TextType.Numeric;
            this.txtPaymentAmount.IsRequired = true;
            this.txtPaymentAmount.Location = new System.Drawing.Point(198, 10);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PlaceholderText = "";
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.Size = new System.Drawing.Size(299, 36);
            this.txtPaymentAmount.TabIndex = 107;
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
            this.ctrlPaymentDetails1.Location = new System.Drawing.Point(506, 3);
            this.ctrlPaymentDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPaymentDetails1.Name = "ctrlPaymentDetails1";
            this.ctrlPaymentDetails1.Size = new System.Drawing.Size(448, 545);
            this.ctrlPaymentDetails1.SubscriptionID = 0;
            this.ctrlPaymentDetails1.TabIndex = 98;
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
            this.btnSave.Location = new System.Drawing.Point(836, 626);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 30);
            this.btnSave.TabIndex = 94;
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
            this.btnClose.Location = new System.Drawing.Point(685, 626);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 30);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            // 
            // frmAddUpdateRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcPayment);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tcPayment.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpPaymentInfo.ResumeLayout(false);
            this.tpPaymentInfo.PerformLayout();
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
        private ctrlMemberBasicDetailsWithFilter ctrlMemberDetailsWithFiltering1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private MyTextBox txtPaymentAmount;
        private Guna.UI2.WinForms.Guna2ComboBox cmPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ctrlPaymentDetails ctrlPaymentDetails1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}