namespace GymMangementSystem
{
    partial class frmAddUpdateCoach
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
            this.ctrlEmployeeDetailsWithFiltering1 = new GymMangementSystem.ctrlEmployeeDetailsWithFiltering();
            this.SuspendLayout();
            // 
            // ctrlEmployeeDetailsWithFiltering1
            // 
            this.ctrlEmployeeDetailsWithFiltering1.BackColor = System.Drawing.Color.White;
            this.ctrlEmployeeDetailsWithFiltering1.Location = new System.Drawing.Point(1, 81);
            this.ctrlEmployeeDetailsWithFiltering1.Name = "ctrlEmployeeDetailsWithFiltering1";
            this.ctrlEmployeeDetailsWithFiltering1.Size = new System.Drawing.Size(1193, 657);
            this.ctrlEmployeeDetailsWithFiltering1.TabIndex = 0;
            // 
            // frmAddUpdateCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 774);
            this.Controls.Add(this.ctrlEmployeeDetailsWithFiltering1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdateCoach";
            this.Text = "Add/Update Coach";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlEmployeeDetailsWithFiltering ctrlEmployeeDetailsWithFiltering1;
    }
}