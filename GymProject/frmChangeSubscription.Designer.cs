namespace GymMangementSystem
{
    partial class frmChangeSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeSubscription));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tbChangeSubscription = new System.Windows.Forms.TabControl();
            this.tbMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlMemberBasicDetailsWithFilter1 = new GymMangementSystem.ctrlMemberBasicDetailsWithFilter();
            this.tbChange = new System.Windows.Forms.TabPage();
            this.ctrlSubscriptionPlanDetailsWithFiltering1 = new GymMangementSystem.ctrlSubscriptionPlanDetailsWithFiltering();
            this.ctrlSubscriptionDetails1 = new GymMangementSystem.ctrlSubscriptionDetails();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tbChangeSubscription.SuspendLayout();
            this.tbMemberInfo.SuspendLayout();
            this.tbChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1239, 49);
            this.panel4.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(61, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Change Subscription";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = global::GymMangementSystem.Properties.Resources.change;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 49);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // tbChangeSubscription
            // 
            this.tbChangeSubscription.Controls.Add(this.tbMemberInfo);
            this.tbChangeSubscription.Controls.Add(this.tbChange);
            this.tbChangeSubscription.ItemSize = new System.Drawing.Size(1, 1);
            this.tbChangeSubscription.Location = new System.Drawing.Point(12, 56);
            this.tbChangeSubscription.Name = "tbChangeSubscription";
            this.tbChangeSubscription.SelectedIndex = 0;
            this.tbChangeSubscription.Size = new System.Drawing.Size(1218, 813);
            this.tbChangeSubscription.TabIndex = 16;
            // 
            // tbMemberInfo
            // 
            this.tbMemberInfo.Controls.Add(this.btnNext);
            this.tbMemberInfo.Controls.Add(this.ctrlMemberBasicDetailsWithFilter1);
            this.tbMemberInfo.Location = new System.Drawing.Point(4, 5);
            this.tbMemberInfo.Name = "tbMemberInfo";
            this.tbMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMemberInfo.Size = new System.Drawing.Size(1210, 804);
            this.tbMemberInfo.TabIndex = 0;
            this.tbMemberInfo.UseVisualStyleBackColor = true;
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
            this.btnNext.Location = new System.Drawing.Point(1046, 754);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 45);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // ctrlMemberBasicDetailsWithFilter1
            // 
            this.ctrlMemberBasicDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberBasicDetailsWithFilter1.EnableFiltering = true;
            this.ctrlMemberBasicDetailsWithFilter1.Location = new System.Drawing.Point(8, 13);
            this.ctrlMemberBasicDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlMemberBasicDetailsWithFilter1.Name = "ctrlMemberBasicDetailsWithFilter1";
            this.ctrlMemberBasicDetailsWithFilter1.Size = new System.Drawing.Size(1195, 632);
            this.ctrlMemberBasicDetailsWithFilter1.TabIndex = 0;
            this.ctrlMemberBasicDetailsWithFilter1.OnMemberSelected += new System.EventHandler<GymMangementSystem.ctrlMemberBasicDetailsWithFilter.MemberEventArgs>(this.ctrlMemberBasicDetailsWithFilter1_OnMemberSelected);
            // 
            // tbChange
            // 
            this.tbChange.Controls.Add(this.ctrlSubscriptionPlanDetailsWithFiltering1);
            this.tbChange.Controls.Add(this.ctrlSubscriptionDetails1);
            this.tbChange.Controls.Add(this.pictureBox1);
            this.tbChange.Controls.Add(this.guna2Button1);
            this.tbChange.Location = new System.Drawing.Point(4, 5);
            this.tbChange.Name = "tbChange";
            this.tbChange.Padding = new System.Windows.Forms.Padding(3);
            this.tbChange.Size = new System.Drawing.Size(1210, 804);
            this.tbChange.TabIndex = 1;
            this.tbChange.UseVisualStyleBackColor = true;
            // 
            // ctrlSubscriptionPlanDetailsWithFiltering1
            // 
            this.ctrlSubscriptionPlanDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlSubscriptionPlanDetailsWithFiltering1.EnableFiltering = true;
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Location = new System.Drawing.Point(351, 7);
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Name = "ctrlSubscriptionPlanDetailsWithFiltering1";
            this.ctrlSubscriptionPlanDetailsWithFiltering1.Size = new System.Drawing.Size(856, 456);
            this.ctrlSubscriptionPlanDetailsWithFiltering1.TabIndex = 23;
            // 
            // ctrlSubscriptionDetails1
            // 
            this.ctrlSubscriptionDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlSubscriptionDetails1.EnableStartDate = false;
            this.ctrlSubscriptionDetails1.Location = new System.Drawing.Point(120, 460);
            this.ctrlSubscriptionDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlSubscriptionDetails1.Name = "ctrlSubscriptionDetails1";
            this.ctrlSubscriptionDetails1.Size = new System.Drawing.Size(1085, 345);
            this.ctrlSubscriptionDetails1.StartDate = new System.DateTime(2008, 7, 20, 0, 0, 0, 0);
            this.ctrlSubscriptionDetails1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GymMangementSystem.Properties.Resources.change;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
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
            this.guna2Button1.Location = new System.Drawing.Point(3, 761);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 38);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Back";
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
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::GymMangementSystem.Properties.Resources.Save_32;
            this.btnSave.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(1075, 875);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 40);
            this.btnSave.TabIndex = 148;
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
            this.btnClose.Image = global::GymMangementSystem.Properties.Resources.Close_32;
            this.btnClose.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(907, 875);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 40);
            this.btnClose.TabIndex = 147;
            this.btnClose.Text = "Close";
            // 
            // frmChangeSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 923);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbChangeSubscription);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmChangeSubscription";
            this.Text = "Change Subscription";
            this.Load += new System.EventHandler(this.frmChangeSubscription_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tbChangeSubscription.ResumeLayout(false);
            this.tbMemberInfo.ResumeLayout(false);
            this.tbChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TabControl tbChangeSubscription;
        private System.Windows.Forms.TabPage tbMemberInfo;
        private System.Windows.Forms.TabPage tbChange;
        private ctrlMemberBasicDetailsWithFilter ctrlMemberBasicDetailsWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ctrlSubscriptionPlanDetailsWithFiltering ctrlSubscriptionPlanDetailsWithFiltering1;
        private ctrlSubscriptionDetails ctrlSubscriptionDetails1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}