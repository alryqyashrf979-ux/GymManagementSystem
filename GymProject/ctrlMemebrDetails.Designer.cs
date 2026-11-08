namespace GymMangementSystem
{
    partial class ctrlMemebrDetails
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlEmergencyContactDetails1 = new GymMangementSystem.ctrlEmergencyContactDetails();
            this.ctrlMemberBasicDetails1 = new GymMangementSystem.ctrlMemberBasicDetails();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.ctrlEmergencyContactDetails1);
            this.guna2Panel2.Controls.Add(this.ctrlMemberBasicDetails1);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(959, 601);
            this.guna2Panel2.TabIndex = 2;
            // 
            // ctrlEmergencyContactDetails1
            // 
            this.ctrlEmergencyContactDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlEmergencyContactDetails1.Location = new System.Drawing.Point(11, 453);
            this.ctrlEmergencyContactDetails1.Name = "ctrlEmergencyContactDetails1";
            this.ctrlEmergencyContactDetails1.Size = new System.Drawing.Size(942, 137);
            this.ctrlEmergencyContactDetails1.TabIndex = 119;
            // 
            // ctrlMemberBasicDetails1
            // 
            this.ctrlMemberBasicDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberBasicDetails1.Location = new System.Drawing.Point(5, 3);
            this.ctrlMemberBasicDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlMemberBasicDetails1.Name = "ctrlMemberBasicDetails1";
            this.ctrlMemberBasicDetails1.Size = new System.Drawing.Size(952, 455);
            this.ctrlMemberBasicDetails1.TabIndex = 118;
            this.ctrlMemberBasicDetails1.Load += new System.EventHandler(this.ctrlMemberBasicDetails1_Load);
            // 
            // ctrlMemebrDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlMemebrDetails";
            this.Size = new System.Drawing.Size(962, 601);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private ctrlMemberBasicDetails ctrlMemberBasicDetails1;
        private ctrlEmergencyContactDetails ctrlEmergencyContactDetails1;
    }
}
