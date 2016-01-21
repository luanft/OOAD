using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuLich.GUI;
using System.IO;
using QuanLyDuLich.DAL;
using DataAccessLayer;
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
            dalObject dalobject=new dalObject();
            if (File.Exists("config.txt"))
            {
                using (StreamReader sr = new StreamReader("config.txt"))
                {
                    QuanLyDuLich.DAL.Config.server = sr.ReadLine();
                    QuanLyDuLich.DAL.Config.database = sr.ReadLine();
                }
            }
            else
            {
                Application.Run(new QuanLyDuLich.GUI.Config());
                MessageBox.Show("Đã thiết lập tạo kết nối đến cơ sở dữ liệu!");
                Application.Exit();
            }
            
            if (dalobject.Connect())
            {
                dalobject.Close();
                if (!File.Exists("rememberme.txt"))
                {
                    File.Create("rememberme.txt");
                }
                Application.Run(new frmDangNhap());
            }
            
        }
    }
}
