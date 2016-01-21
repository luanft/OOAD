using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuLich.DAL;
using DataAccessLayer;
using System.IO;


namespace QuanLyDuLich.GUI
{
    public partial class Config : Form
    {
        dalObject dalobject = new dalObject();        
        public Config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_DatabaseName.Text==""||tb_ServerName.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");                                
            }
            else 
            {
                QuanLyDuLich.DAL.Config.server = tb_ServerName.Text;
                QuanLyDuLich.DAL.Config.database = tb_DatabaseName.Text;
                if (dalobject.Connect())
                {
                    using (StreamWriter sw = new StreamWriter("config.txt"))
                    {
                        sw.WriteLine(tb_ServerName.Text);
                        sw.WriteLine(tb_DatabaseName.Text);
                        sw.Close();
                    }
                    dalobject.Close();                                        
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chính xác thông tin về Server Name và DataBase Name");
                }
            }

        }
    }
}
