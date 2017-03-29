using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
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
            Application.Run(new QUANLY());
            //Application.Run(new Form1());
            //Application.Run(new DIEM2());
          //Application.Run(new LOP());
            //Application.Run(new KHOA());
            //Application.Run(new SINHVIEN());
         
        }
    }
}
