namespace GymMangementSystem
{
    partial class frmShowClassDetails
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnActive = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlClassDetails1 = new GymMangementSystem.ctrlClassDetails();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.guna2Panel1.Controls.Add(this.btnActive);
            this.guna2Panel1.Controls.Add(this.lblDescription);
            this.guna2Panel1.Controls.Add(this.lblClassName);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(677, 55);
            this.guna2Panel1.TabIndex = 4;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.White;
            this.lblClassName.Location = new System.Drawing.Point(57, 2);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(121, 23);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "Class Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymMangementSystem.Properties.Resources.CapacityCircle;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(81, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Transparent;
            this.btnActive.BorderRadius = 13;
            this.btnActive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.btnActive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActive.ForeColor = System.Drawing.Color.Black;
            this.btnActive.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.btnActive.Location = new System.Drawing.Point(578, 12);
            this.btnActive.Name = "btnActive";
            this.btnActive.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.btnActive.Size = new System.Drawing.Size(87, 25);
            this.btnActive.TabIndex = 18;
            this.btnActive.Text = "Active";
            // 
            // ctrlClassDetails1
            // 
            this.ctrlClassDetails1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlClassDetails1.Location = new System.Drawing.Point(0, 52);
            this.ctrlClassDetails1.Name = "ctrlClassDetails1";
            this.ctrlClassDetails1.Size = new System.Drawing.Size(677, 393);
            this.ctrlClassDetails1.TabIndex = 0;
            // 
            // frmShowClassDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 445);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrlClassDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowClassDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowClassDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClassDetails ctrlClassDetails1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnActive;
    }
}