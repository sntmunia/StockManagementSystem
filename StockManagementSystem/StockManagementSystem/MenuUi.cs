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

    }
}
