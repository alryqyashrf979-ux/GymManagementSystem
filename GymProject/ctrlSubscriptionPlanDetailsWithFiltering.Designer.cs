namespace GymMangementSystem
{
    partial class ctrlSubscriptionPlanDetailsWithFiltering
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
            this.ctrlSubscriptionPlanDetails1 = new GymMangementSystem.ctrlSubscriptionPlanDetails();
            this.gbFiltering = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmFilteringType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.gbFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ctrlSubscriptionPlanDetails1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(691, 560);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ctrlSubscriptionPlanDetails1
            // 
            this.ctrlSubscriptionPlanDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlSubscriptionPlanDetails1.Location = new System.Drawing.Point(5, 88);
            this.ctrlSubscriptionPlanDetails1.Name = "ctrlSubscriptionPlanDetails1";
            this.ctrlSubscriptionPlanDetails1.Size = new System.Drawing.Size(678, 461);
            this.ctrlSubscriptionPlanDetails1.TabIndex = 0;
            // 
            // gbFiltering
            // 
            this.gbFiltering.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbFiltering.BorderRadius = 5;
            this.gbFiltering.Controls.Add(this.cmFilteringType);
            this.gbFiltering.Controls.Add(this.label9);
            this.gbFiltering.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbFiltering.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltering.ForeColor = System.Drawing.Color.Black;
            this.gbFiltering.Location = new System.Drawing.Point(12, 6);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Size = new System.Drawing.Size(670, 84);
            this.gbFiltering.TabIndex = 3;
            this.gbFiltering.Text = "Filter";
            // 
            // cmFilteringType
            // 
            this.cmFilteringType.BackColor = System.Drawing.Color.Transparent;
            this.cmFilteringType.BorderRadius = 5;
            this.cmFilteringType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFilteringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilteringType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmFilteringType.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmFilteringType.ForeColor = System.Drawing.Color.Black;
            this.cmFilteringType.ItemHeight = 30;
            this.cmFilteringType.Items.AddRange(new object[] {
            "National No.",
            "Member ID"});
            this.cmFilteringType.Location = new System.Drawing.Point(218, 33);
            this.cmFilteringType.Name = "cmFilteringType";
            this.cmFilteringType.Size = new System.Drawing.Size(355, 36);
            this.cmFilteringType.StartIndex = 0;
            this.cmFilteringType.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "Select Plan :";
            // 
            // ctrlSubscriptionPlanDetailsWithFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFiltering);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlSubscriptionPlanDetailsWithFiltering";
            this.Size = new System.Drawing.Size(697, 568);
            this.guna2Panel1.ResumeLayout(false);
            this.gbFiltering.ResumeLayout(false);
            this.gbFiltering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ctrlSubscriptionPlanDetails ctrlSubscriptionPlanDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilteringType;
        private System.Windows.Forms.Label label9;
    }
}
