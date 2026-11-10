namespace GymMangementSystem
{
    partial class ctrlCoachDetails
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
            this.ctrlPersonDetails1 = new GymMangementSystem.ctrlPersonDetails();
            this.ctrlCoachBasicDetais1 = new GymMangementSystem.ctrlCoachBasicDetais();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ctrlCoachBasicDetais1);
            this.guna2Panel1.Controls.Add(this.ctrlPersonDetails1);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(957, 469);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(950, 271);
            this.ctrlPersonDetails1.TabIndex = 20;
            // 
            // ctrlCoachBasicDetais1
            // 
            this.ctrlCoachBasicDetais1.BackColor = System.Drawing.Color.White;
            this.ctrlCoachBasicDetais1.Location = new System.Drawing.Point(1, 276);
            this.ctrlCoachBasicDetais1.Name = "ctrlCoachBasicDetais1";
            this.ctrlCoachBasicDetais1.Size = new System.Drawing.Size(958, 188);
            this.ctrlCoachBasicDetais1.TabIndex = 21;
            // 
            // ctrlCoachDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlCoachDetails";
            this.Size = new System.Drawing.Size(965, 477);
            this.Load += new System.EventHandler(this.ctrlCoachDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlCoachBasicDetais ctrlCoachBasicDetais1;
    }
}
