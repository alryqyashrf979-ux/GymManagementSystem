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
            this.ctrlMemebrDetails1 = new GymMangementSystem.ctrlMemebrDetails();
            this.SuspendLayout();
            // 
            // ctrlMemebrDetails1
            // 
            this.ctrlMemebrDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ctrlMemebrDetails1.Location = new System.Drawing.Point(4, 3);
            this.ctrlMemebrDetails1.Name = "ctrlMemebrDetails1";
            this.ctrlMemebrDetails1.Size = new System.Drawing.Size(1202, 625);
            this.ctrlMemebrDetails1.TabIndex = 0;
            // 
            // frmAddSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 645);
            this.Controls.Add(this.ctrlMemebrDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddSubscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSubscription";
            this.Load += new System.EventHandler(this.frmAddSubscription_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMemebrDetails ctrlMemebrDetails1;
    }
}