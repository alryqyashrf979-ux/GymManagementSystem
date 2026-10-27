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
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberDetailsWithFiltering1 = new GymMangementSystem.ctrlMemberDetailsWithFiltering();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tcUserInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.lblTitle2);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1219, 46);
            this.panel4.TabIndex = 14;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(63, 6);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(165, 32);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Add Member";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(56, 46);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tpLoginInfo);
            this.tcUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcUserInfo.Location = new System.Drawing.Point(0, 46);
            this.tcUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1219, 947);
            this.tcUserInfo.TabIndex = 15;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.ctrlMemberDetailsWithFiltering1);
            this.tpPersonalInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1211, 918);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
            this.tpLoginInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tpLoginInfo.Size = new System.Drawing.Size(1211, 918);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // ctrlMemberDetailsWithFiltering1
            // 
            this.ctrlMemberDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetailsWithFiltering1.EnableFiltering = true;
            this.ctrlMemberDetailsWithFiltering1.Location = new System.Drawing.Point(1, 2);
            this.ctrlMemberDetailsWithFiltering1.Name = "ctrlMemberDetailsWithFiltering1";
            this.ctrlMemberDetailsWithFiltering1.Size = new System.Drawing.Size(1207, 851);
            this.ctrlMemberDetailsWithFiltering1.TabIndex = 13;
            // 
            // frmAddSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 1047);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddSubscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subscription";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tcUserInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private ctrlMemberDetailsWithFiltering ctrlMemberDetailsWithFiltering1;
    }
}