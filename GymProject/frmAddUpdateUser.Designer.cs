namespace GymMangementSystem
{
    partial class frmAddUpdateUser
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
            this.uctPersonDetailsWithFilter1 = new GymMangementSystem.uctPersonDetailsWithFilter();
            this.SuspendLayout();
            // 
            // uctPersonDetailsWithFilter1
            // 
            this.uctPersonDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.uctPersonDetailsWithFilter1.Location = new System.Drawing.Point(48, 39);
            this.uctPersonDetailsWithFilter1.Name = "uctPersonDetailsWithFilter1";
            this.uctPersonDetailsWithFilter1.Size = new System.Drawing.Size(900, 383);
            this.uctPersonDetailsWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.uctPersonDetailsWithFilter1);
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAddUpdateUser";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private uctPersonDetailsWithFilter uctPersonDetailsWithFilter1;
    }
}