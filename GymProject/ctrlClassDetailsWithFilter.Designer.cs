namespace GymMangementSystem
{
    partial class ctrlClassDetailsWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctrlClassDetails1 = new GymMangementSystem.ctrlClassDetails();
            this.guna2Panel1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.gbFilter);
            this.guna2Panel1.Controls.Add(this.ctrlClassDetails1);
            this.guna2Panel1.Location = new System.Drawing.Point(4, 11);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(928, 587);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbClasses);
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.pictureBox2);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(27, 2);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Size = new System.Drawing.Size(876, 84);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // cbClasses
            // 
            this.cbClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbClasses.BorderRadius = 7;
            this.cbClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClasses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasses.ForeColor = System.Drawing.Color.Black;
            this.cbClasses.ItemHeight = 30;
            this.cbClasses.Location = new System.Drawing.Point(304, 30);
            this.cbClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(517, 36);
            this.cbClasses.TabIndex = 156;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(147, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 27);
            this.label6.TabIndex = 154;
            this.label6.Text = "Select Class :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GymMangementSystem.Properties.Resources.Classes;
            this.pictureBox2.Location = new System.Drawing.Point(69, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 155;
            this.pictureBox2.TabStop = false;
            // 
            // ctrlClassDetails1
            // 
            this.ctrlClassDetails1.Location = new System.Drawing.Point(9, 91);
            this.ctrlClassDetails1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlClassDetails1.Name = "ctrlClassDetails1";
            this.ctrlClassDetails1.Size = new System.Drawing.Size(915, 486);
            this.ctrlClassDetails1.TabIndex = 2;
            // 
            // ctrlClassDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrlClassDetailsWithFilter";
            this.Size = new System.Drawing.Size(937, 602);
            this.guna2Panel1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbClasses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ctrlClassDetails ctrlClassDetails1;
    }
}
