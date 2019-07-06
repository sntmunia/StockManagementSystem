using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class MenuUi : Form
    {
        public MenuUi()
        {
            InitializeComponent();
        }        

        private void categorySetupLabel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Show();
        }

        private void companySetupLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyUi companyUi = new CompanyUi();
            companyUi.Show();
        }

<<<<<<< HEAD
=======
        private void itemSetupLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemUi itemUi = new ItemUi();
            itemUi.Show();            
        }

        private void stockInLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInUi stockInUi = new StockInUi();
            stockInUi.Show();
            
        }

       


       
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
    }
}
