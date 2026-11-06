namespace GymMangementSystem
{
    partial class ctrlEmployeeDetails
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
            this.uctPersonDetails1 = new GymMangementSystem.uctPersonDetails();
            this.SuspendLayout();
            // 
            // uctPersonDetails1
            // 
            this.uctPersonDetails1.BackColor = System.Drawing.Color.White;
            this.uctPersonDetails1.Location = new System.Drawing.Point(4, 3);
            this.uctPersonDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.uctPersonDetails1.Name = "uctPersonDetails1";
            this.uctPersonDetails1.Size = new System.Drawing.Size(1187, 339);
            this.uctPersonDetails1.TabIndex = 0;
            // 
            // ctrlEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uctPersonDetails1);
            this.Name = "ctrlEmployeeDetails";
            this.Size = new System.Drawing.Size(1193, 691);
            this.ResumeLayout(false);

        }

        #endregion

        private uctPersonDetails uctPersonDetails1;
    }
}
