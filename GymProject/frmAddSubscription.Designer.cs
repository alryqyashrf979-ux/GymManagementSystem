namespace GymMangementSystem
{
    partial class frmAddSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSubscription));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tcSubscriptionInfo = new System.Windows.Forms.TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlMemberDetailsWithFiltering1 = new GymMangementSystem.ctrlMemberDetailsWithFiltering();
            this.tpSubscriptionInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlSubscriptionPlanDetailsWithFiltering1 = new GymMangementSystem.ctrlSubscriptionPlanDetailsWithFiltering();
            this.ctrlSubscriptionDetails1 = new GymMangementSystem.ctrlSubscriptionDetails();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tcSubscriptionInfo.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpSubscriptionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.lblTitle2);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1226, 41);
            this.panel4.TabIndex = 14;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(62, 2);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(212, 32);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Add Subscription";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // tcSubscriptionInfo
            // 
            this.tcSubscriptionInfo.Controls.Add(this.tpMemberInfo);
            this.tcSubscriptionInfo.Controls.Add(this.tpSubscriptionInfo);
            this.tcSubscriptionInfo.ItemSize = new System.Drawing.Size(1, 1);
            this.tcSubscriptionInfo.Location = new System.Drawing.Point(5, 40);
            this.tcSubscriptionInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcSubscriptionInfo.Multiline = true;
            this.tcSubscriptionInfo.Name = "tcSubscriptionInfo";
            this.tcSubscriptionInfo.RightToLeftLayout = true;
            this.tcSubscriptionInfo.SelectedIndex = 0;
            this.tcSubscriptionInfo.Size = new System.Drawing.Size(1225, 831);
            this.tcSubscriptionInfo.TabIndex = 15;
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.BackColor = System.Drawing.Color.White;
            this.tpMemberInfo.Controls.Add(this.btnNext);
            this.tpMemberInfo.Controls.Add(this.ctrlMemberDetailsWithFiltering1);
            this.tpMemberInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 5);
            this.tpMemberInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpMemberInfo.Size = new System.Drawing.Size(1217, 822);
            this.tpMemberInfo.TabIndex = 0;
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
            this.btnNext.Location = new System.Drawing.Point(1045, 775);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 45);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMemberDetailsWithFiltering1
            // 
            this.ctrlMemberDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetailsWithFiltering1.EnableFiltering = true;
            this.ctrlMemberDetailsWithFiltering1.Location = new System.Drawing.Point(2, -5);
            this.ctrlMemberDetailsWithFiltering1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlMemberDetailsWithFiltering1.Name = "ctrlMemberDetailsWithFiltering1";
            this.ctrlMemberDetailsWithFiltering1.Size = new System.Drawing.Size(1208, 776);
            this.ctrlMemberDetailsWithFiltering1.TabIndex = 13;
            this.ctrlMemberDetailsWithFiltering1.OnMemberSelected += new System.EventHandler<GymMangementSystem.ctrlMemberDetailsWithFiltering.MemberEventArgs>(this.ctrlMemberDetailsWithFiltering1_OnMemberSelected);
            // 
            // tpSubscriptionInfo
            // 
            this.tpSubscriptionInfo.BackColor = System.Drawing.Color.White;
            this.tpSubscriptionInfo.Controls.Add(this.pictureBox1);
            this.tpSubscriptionInfo.Controls.Add(this.guna2Button1);
            this.tpSubscriptionInfo.Controls.Add(this.ctrlSubscriptionPlanDetailsWithFiltering1);
            this.tpSubscriptionInfo.Controls.Add(this.ctrlSubscriptionDetails1);
            this.tpSubscriptionInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tpSubscriptionInfo.Location = new System.Drawing.Point(4, 5);
            this.tpSubscriptionInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSubscriptionInfo.Name = "tpSubscriptionInfo";
            this.tpSubscriptionInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSubscriptionInfo.Size = new System.Drawing.Size(1217, 822);
            this.tpSubscriptionInfo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GymMangementSystem.Properties.Resources.Add_Subscription_Icon2;
            this.pictureBox1.Location = new System.Drawing.Point(-22, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::GymMangementSystem.Properties.Resources.Back;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-5, 1);
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(2, 778);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(131, 38);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ctrlSubscriptionPlanDetailsWithFiltering1
            // 
            this.ctrlSubscriptionPlanDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = true;
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Location = new System.Drawing.Point(361, 18);
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Name = "ctrlSubscriptionPlanDetailsWithFiltering1";
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Size = new System.Drawing.Size(854, 456);
            this.ctrlSubscriptionPlanDetailsWithFiltering1.TabIndex = 2;
            // 
            // ctrlSubscriptionDetails1
            // 
            this.ctrlSubscriptionDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlSubscriptionDetails1.EnableStartDate = true;
            this.ctrlSubscriptionDetails1.Location = new System.Drawing.Point(132, 474);
            this.ctrlSubscriptionDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlSubscriptionDetails1.Name = "ctrlSubscriptionDetails1";
            this.ctrlSubscriptionDetails1.Size = new System.Drawing.Size(1079, 342);
            this.ctrlSubscriptionDetails1.StartDate = new System.DateTime(2008, 7, 20, 0, 0, 0, 0);
            this.ctrlSubscriptionDetails1.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(1069, 874);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(891, 874);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 38);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 922);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcSubscriptionInfo);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddSubscription";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subscription";
            this.Load += new System.EventHandler(this.frmAddSubscription_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tcSubscriptionInfo.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpSubscriptionInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TabControl tcSubscriptionInfo;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private System.Windows.Forms.TabPage tpSubscriptionInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private ctrlSubscriptionDetails ctrlSubscriptionDetails1;
        private ctrlSubscriptionPlanDetailsWithFiltering ctrlSubscriptionPlanDetailsWithFiltering1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public ctrlMemberDetailsWithFiltering ctrlMemberDetailsWithFiltering1;
    }
}