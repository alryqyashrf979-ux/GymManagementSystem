namespace GymMangementSystem
{
    partial class frmShowPaymentDetails
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPaymentDetails1 = new GymMangementSystem.ctrlPaymentDetails();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Image = global::GymMangementSystem.Properties.Resources.Close_32;
            this.btnClose.ImageOffset = new System.Drawing.Point(-10, 1);
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(594, 281);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 30);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Close";
            // 
            // ctrlPaymentDetails1
            // 
            this.ctrlPaymentDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlPaymentDetails1.Location = new System.Drawing.Point(1, 1);
            this.ctrlPaymentDetails1.Name = "ctrlPaymentDetails1";
            this.ctrlPaymentDetails1.Size = new System.Drawing.Size(718, 276);
            this.ctrlPaymentDetails1.SubscriptionID = 0;
            this.ctrlPaymentDetails1.TabIndex = 0;
            // 
            // frmShowPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 315);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPaymentDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPaymentDetails ctrlPaymentDetails1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}