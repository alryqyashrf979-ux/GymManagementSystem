namespace GymMangementSystem
{
    partial class frmShowUserDetails
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
            this.ctrlUserDetails1 = new GymMangementSystem.ctrlUserDetails();
            this.SuspendLayout();
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUserDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(887, 420);
            this.ctrlUserDetails1.TabIndex = 0;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 420);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Name = "frmShowUserDetails";
            this.Text = "frmShowUserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserDetails ctrlUserDetails1;
    }
}