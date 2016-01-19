using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtMatKhau.Text != "")
            {
                if (kiemTraEmailHopLe(txtEmail.Text))
                {
                    NhanVien nv = new NhanVien();
                    nv.DangNhap(txtEmail.Text, txtMatKhau.Text);
                }
                else
                    MessageBox.Show("Email không hợp lệ!", "Thông báo");
            }            
            else
                MessageBox.Show("Vui lòng nhập email và mật khẩu để đăng nhập!", "Thông báo");
        }

        private bool kiemTraEmailHopLe(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
