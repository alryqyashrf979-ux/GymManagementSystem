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
            this.uctPersonDetails1 = new GymMangementSystem.uctPersonDetails();
            this.ctrlMemberBasicDetails1 = new GymMangementSystem.ctrlMemberBasicDetails();
            this.ctrlEmergencyContactDetails1 = new GymMangementSystem.ctrlEmergencyContactDetails();
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
            this.guna2Panel2.Controls.Add(this.uctPersonDetails1);
            this.guna2Panel2.Controls.Add(this.ctrlMemberBasicDetails1);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1199, 731);
            this.guna2Panel2.TabIndex = 2;
            // 
            // uctPersonDetails1
            // 
            this.uctPersonDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.uctPersonDetails1.Location = new System.Drawing.Point(5, 2);
            this.uctPersonDetails1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uctPersonDetails1.Name = "uctPersonDetails1";
            this.uctPersonDetails1.Size = new System.Drawing.Size(1188, 342);
            this.uctPersonDetails1.TabIndex = 117;
            // 
            // ctrlMemberBasicDetails1
            // 
            this.ctrlMemberBasicDetails1.Location = new System.Drawing.Point(5, 341);
            this.ctrlMemberBasicDetails1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlMemberBasicDetails1.Name = "ctrlMemberBasicDetails1";
            this.ctrlMemberBasicDetails1.Size = new System.Drawing.Size(1185, 203);
            this.ctrlMemberBasicDetails1.TabIndex = 118;
            // 
            // ctrlEmergencyContactDetails1
            // 
            this.ctrlEmergencyContactDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlEmergencyContactDetails1.Location = new System.Drawing.Point(6, 549);
            this.ctrlEmergencyContactDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlEmergencyContactDetails1.Name = "ctrlEmergencyContactDetails1";
            this.ctrlEmergencyContactDetails1.Size = new System.Drawing.Size(1185, 171);
            this.ctrlEmergencyContactDetails1.TabIndex = 119;
            // 
            // ctrlMemebrDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlMemebrDetails";
            this.Size = new System.Drawing.Size(1202, 737);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private uctPersonDetails uctPersonDetails1;
        private ctrlMemberBasicDetails ctrlMemberBasicDetails1;
        private ctrlEmergencyContactDetails ctrlEmergencyContactDetails1;
    }
}
