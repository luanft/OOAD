using BLL;
using QuanLyDuLich.BLL;
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
                    if (nv.DangNhap(txtEmail.Text, txtMatKhau.Text))
                    {
                        this.Hide();
                        switch (nv.LayLoaiNV())
                        {
                            case LoaiNhanVien.GiamDoc:
                                frmGiamDoc frmGD = new frmGiamDoc(nv.pMaNhanVien);
                                frmGD.ShowDialog();
                                break;
                            case LoaiNhanVien.NhanVienDieuHanh:
                                frmNhanVienDieuHanh frmDH = new frmNhanVienDieuHanh(nv.pMaNhanVien);
                                frmDH.ShowDialog();
                                break;
                            case LoaiNhanVien.NhanVienSale:
                                frmNhanVienSaleTour frmS = new frmNhanVienSaleTour(nv.pMaNhanVien);
                                frmS.ShowDialog();
                                break;
                            default:
                                break;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email hoặc mật khẩu không đúng!", "Thông báo");
                    }
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
