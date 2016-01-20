using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuLich.GUI;
using System.IO;
namespace QuanLyDuLich
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
            if (!File.Exists("rememberme.txt"))
            {
                File.Create("rememberme.txt");
            }            
            Application.Run(new frmDangNhap());
        }
    }
}
