﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuUi());
            //Application.Run(new CategoryUi());
            //Application.Run(new CompanyUi());
<<<<<<< HEAD
            
=======
            //Application.Run(new ItemUi());
            //Application.Run(new StockInUi());
            //Application.Run(new StockOut());
            //Application.Run(new SearchandViewItemsSummary());
            //Application.Run(new ViewBetweenTwoDatesReport());
>>>>>>> 19f8a0e1443de35af659c3b38201f0f6f34242f0
        }
    }
}
