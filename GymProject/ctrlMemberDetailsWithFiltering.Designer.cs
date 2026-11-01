namespace GymMangementSystem
{
    partial class ctrlMemberDetailsWithFiltering
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlEmergencyContactDetails1 = new GymMangementSystem.ctrlEmergencyContactDetails();
            this.ctrlMemberBasicDetailsWithFilter1 = new GymMangementSystem.ctrlMemberBasicDetailsWithFilter();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ctrlEmergencyContactDetails1);
            this.guna2Panel1.Controls.Add(this.ctrlMemberBasicDetailsWithFilter1);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1199, 821);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlEmergencyContactDetails1
            // 
            this.ctrlEmergencyContactDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlEmergencyContactDetails1.Location = new System.Drawing.Point(9, 640);
            this.ctrlEmergencyContactDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlEmergencyContactDetails1.Name = "ctrlEmergencyContactDetails1";
            this.ctrlEmergencyContactDetails1.Size = new System.Drawing.Size(1177, 171);
            this.ctrlEmergencyContactDetails1.TabIndex = 1;
            // 
            // ctrlMemberBasicDetailsWithFilter1
            // 
            this.ctrlMemberBasicDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberBasicDetailsWithFilter1.EnableFiltering = true;
            this.ctrlMemberBasicDetailsWithFilter1.Location = new System.Drawing.Point(2, 2);
            this.ctrlMemberBasicDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlMemberBasicDetailsWithFilter1.Name = "ctrlMemberBasicDetailsWithFilter1";
            this.ctrlMemberBasicDetailsWithFilter1.Size = new System.Drawing.Size(1195, 636);
            this.ctrlMemberBasicDetailsWithFilter1.TabIndex = 0;
            this.ctrlMemberBasicDetailsWithFilter1.OnMemberSelected += new System.EventHandler<GymMangementSystem.ctrlMemberBasicDetailsWithFilter.MemberEventArgs>(this.ctrlMemberBasicDetailsWithFilter1_OnMemberSelected);
            // 
            // ctrlMemberDetailsWithFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlMemberDetailsWithFiltering";
            this.Size = new System.Drawing.Size(1207, 830);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ctrlEmergencyContactDetails ctrlEmergencyContactDetails1;
        private ctrlMemberBasicDetailsWithFilter ctrlMemberBasicDetailsWithFilter1;
    }
}
