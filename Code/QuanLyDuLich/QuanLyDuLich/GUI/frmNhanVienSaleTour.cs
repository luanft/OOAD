﻿using BLL;
using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    public partial class frmNhanVienSaleTour : Form
    {

        private NVSale nhanVienSale = new NVSale();
        public frmNhanVienSaleTour()
        {
            InitializeComponent();
        }

        public frmNhanVienSaleTour(int manv)
        {
            this.maNhanVien = manv;
            InitializeComponent();
        }

        private diagThemLichTrinh diagThemLt = new diagThemLichTrinh();
        private diagChiTietLichTrinh diagCTLT = new diagChiTietLichTrinh();
        private KhachHang bll_KhachHang = new KhachHang();
        private void frmNhanVienSaleTour_Load(object sender, EventArgs e)
        {
            this.ThietLapForm();            
            //khi dang nhap duoc se doi ham nay lai
            dG_DanhSachKhachHang.AutoGenerateColumns = false;
            dG_DanhSachKhachHang.DataSource = bll_KhachHang.layDanhSachKhachHang();
            loadDanhSachKhachHang();
        }

        private void loadDanhSachKhachHang() 
        {            
            dG_DanhSachKhachHang.DataSource = bll_KhachHang.layDanhSachKhachHang();
        }
        private void tb_SoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8);
        }
        private void tb_SoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8);
        }
        private void bt_ThemKH_Click(object sender, EventArgs e)
        {
            bt_XoaKH.Enabled = false;
            bt_ThemKH.Enabled = false;
            bt_CapNhatKhachHang.Enabled = false;
            bt_LuuKH.Enabled = true;
            enable_Control();
            tb_MaKhachHang.Text = dG_DanhSachKhachHang.RowCount.ToString();            
        }

        private void bt_CapNhatKhachHang_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(tb_MaKhachHang.Text.ToString());
            int songuoi = int.Parse(tb_SoNguoi.Text.ToString());            
            bll_KhachHang = new KhachHang(makh, 1, tb_TenDonVi.Text, tb_NguoiDaiDien.Text, cb_GioiTinh.Text, tb_Email.Text, tb_SoDT.Text, songuoi, tb_DiaChi.Text, cb_LoaiKhachHang.Text);            
            bll_KhachHang.CapNhat();
            loadDanhSachKhachHang();
        }

        private void bt_XoaKH_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(tb_MaKhachHang.Text.ToString());
            bll_KhachHang.Xoa(makh);
            loadDanhSachKhachHang();
        }

        private void bt_LuuKH_Click(object sender, EventArgs e)
        {
            if (!check_data_KH())
                return;                       
            int songuoi = int.Parse(tb_SoNguoi.Text.ToString());            
            bll_KhachHang = new KhachHang(1, 1,tb_TenDonVi.Text, tb_NguoiDaiDien.Text, cb_GioiTinh.Text, tb_Email.Text, tb_SoDT.Text, songuoi, tb_DiaChi.Text, cb_LoaiKhachHang.Text);
            bll_KhachHang.Luu();
            loadDanhSachKhachHang();
            disable_Control();
            bt_XoaKH.Enabled = true;
            bt_ThemKH.Enabled = true;
            bt_CapNhatKhachHang.Enabled = true;
            bt_LuuKH.Enabled = false;
        }

        private void bt_HuyKH_Click(object sender, EventArgs e)
        {
            disable_Control();
            bt_LuuKH.Enabled = false;
        }

        private void bt_ThemDiemDL_Click(object sender, EventArgs e)
        {

        }

        private void bt_CapNhatDDL_Click(object sender, EventArgs e)
        {

        }
        private void disable_Control()
        {
            foreach (Control i in gb_KH.Controls)
            {
                if (i.GetType() == typeof(TextBox) || i.GetType() == typeof(ComboBox))
                {
                    i.Text = "";                    
                    i.Enabled = false;
                }
                if (i.GetType() == typeof(ComboBox))
                {
                    (i as ComboBox).ResetText();
                }
            }
        }
        private void enable_Control()
        {
            foreach (Control i in gb_KH.Controls)
            {
                if (i.Name != "tb_MaKhachHang" && (i.GetType() == typeof(TextBox) || i.GetType() == typeof(ComboBox)))
                {
                    i.Text = "";
                    i.Enabled = true;
                }
            }
        }
        private bool check_data_KH()
        {
            if (tb_DiaChi.Text == "" || tb_Email.Text == "" || tb_NguoiDaiDien.Text == "" || tb_SoDT.Text == "" || tb_SoNguoi.Text == "" || tb_TenDonVi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }

        private void dG_DanhSachKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            int index = dG_DanhSachKhachHang.CurrentCell.RowIndex;
            int makh = int.Parse(dG_DanhSachKhachHang.Rows[index].Cells[1].Value.ToString());
            bindingdata(makh);

        }
        private void bindingdata(int makh) 
        {
            dtoKhachHang kh = bll_KhachHang.layKhachHang(makh);

            tb_MaKhachHang.Text = kh.MAKHACHHANG.ToString();
            tb_DiaChi.Text = kh.DIACHI;
            tb_Email.Text = kh.EMAIL;
            tb_MaNhanVien.Text = kh.MANHANVIEN.ToString();
            tb_NguoiDaiDien.Text = kh.NGUOIDAIDIEN;
            tb_SoDT.Text = kh.DIENTHOAI;
            tb_SoNguoi.Text = kh.SONGUOI.ToString();
            tb_TenDonVi.Text = kh.TENDONVI;
            if (kh.GIOITINH == "Nam")            
                cb_GioiTinh.SelectedIndex = 0;            
            else
                cb_GioiTinh.SelectedIndex = 1;
            if (kh.LOAIKHACHHANG == "ĐOÀN")
                cb_LoaiKhachHang.SelectedIndex = 0;
            else
                cb_LoaiKhachHang.SelectedIndex = 1;

        }
        
        








    }
}
