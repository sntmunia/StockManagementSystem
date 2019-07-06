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
<<<<<<< HEAD
=======
            this.itemSetupLabel = new System.Windows.Forms.Label();
            this.stockInLabel = new System.Windows.Forms.Label();
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
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
<<<<<<< HEAD
=======
            // itemSetupLabel
            // 
            this.itemSetupLabel.AutoSize = true;
            this.itemSetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSetupLabel.Location = new System.Drawing.Point(177, 155);
            this.itemSetupLabel.Name = "itemSetupLabel";
            this.itemSetupLabel.Size = new System.Drawing.Size(71, 16);
            this.itemSetupLabel.TabIndex = 16;
            this.itemSetupLabel.Text = "Item Setup";
            this.itemSetupLabel.Click += new System.EventHandler(this.itemSetupLabel_Click);
            // 
            // stockInLabel
            // 
            this.stockInLabel.AutoSize = true;
            this.stockInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInLabel.Location = new System.Drawing.Point(177, 211);
            this.stockInLabel.Name = "stockInLabel";
            this.stockInLabel.Size = new System.Drawing.Size(55, 16);
            this.stockInLabel.TabIndex = 17;
            this.stockInLabel.Text = "Stock In";
            this.stockInLabel.Click += new System.EventHandler(this.stockInLabel_Click);
            // 
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
            // MenuUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(599, 470);
=======
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(599, 470);
            this.Controls.Add(this.stockInLabel);
            this.Controls.Add(this.itemSetupLabel);
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
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
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label itemSetupLabel;
        private System.Windows.Forms.Label stockInLabel;
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
    }
}