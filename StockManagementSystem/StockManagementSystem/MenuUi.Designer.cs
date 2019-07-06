namespace StockManagementSystem
{
    partial class MenuUi
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
            this.categorySetupLabel = new System.Windows.Forms.Label();
            this.companySetupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categorySetupLabel
            // 
            this.categorySetupLabel.AutoSize = true;
            this.categorySetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySetupLabel.Location = new System.Drawing.Point(177, 48);
            this.categorySetupLabel.Name = "categorySetupLabel";
            this.categorySetupLabel.Size = new System.Drawing.Size(101, 16);
            this.categorySetupLabel.TabIndex = 14;
            this.categorySetupLabel.Text = "Category Setup";
            this.categorySetupLabel.Click += new System.EventHandler(this.categorySetupLabel_Click);
            // 
            // companySetupLabel
            // 
            this.companySetupLabel.AutoSize = true;
            this.companySetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySetupLabel.Location = new System.Drawing.Point(177, 101);
            this.companySetupLabel.Name = "companySetupLabel";
            this.companySetupLabel.Size = new System.Drawing.Size(104, 16);
            this.companySetupLabel.TabIndex = 15;
            this.companySetupLabel.Text = "Company Setup";
            this.companySetupLabel.Click += new System.EventHandler(this.companySetupLabel_Click);
            // 
            // MenuUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 470);
            this.Controls.Add(this.companySetupLabel);
            this.Controls.Add(this.categorySetupLabel);
            this.Name = "MenuUi";
            this.Text = "Menu List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorySetupLabel;
        private System.Windows.Forms.Label companySetupLabel;
    }
}