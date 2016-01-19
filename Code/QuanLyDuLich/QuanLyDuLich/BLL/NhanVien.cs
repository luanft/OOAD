﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace BLL
{
    using DataAccessLayer;
    using DataTranferObject;
    using QuanLyDuLich.BLL;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NhanVien
    {
        protected int MaPhong;
        public int pMaPhong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        protected string HoTen;
        public string pHoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        protected int MaNhanVien;
        public int pMaNhanVien
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }
        protected string SoDT;
        public string pSoDT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }
        protected string DiaChi;
        public string pDiaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        protected string QueQuan;
        public string pQueQuan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }
        protected string CMND;
        public string pCMND
        {
            get { return CMND; }
            set { CMND = value; }
        }
        protected string Email;
        public string pEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        protected DateTime NgaySinh;

        public DateTime pNgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        protected string GioiTinh;
        public string pGioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        protected string MatKhau;
        public string pMatKhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
        protected dalNhanVien dalnv = new dalNhanVien();
        public bool DangNhap(string email, string mk)
        {
            bool thanhCong = dalnv.DangNhap(email, mk);
            if (thanhCong)
                SetNhanVien(dalnv.LayThongTinNhanVien(email));
            return thanhCong;

        }

        public void DangXuat()
        {
            throw new System.NotImplementedException();
        }

        public LoaiNhanVien LayLoaiNV()
        {
            switch (this.MaPhong)
            {
                case 1:
                    return LoaiNhanVien.GiamDoc;
                case 2:
                    return LoaiNhanVien.NhanVienDieuHanh;
                default:
                    return LoaiNhanVien.NhanVienSale;
            }
        }
        public dtoNhanVien GetDTONhanVien()
        {
            dtoNhanVien dtonv = new dtoNhanVien();
            dtonv.CMND = this.CMND;
            dtonv.DIACHI = this.DiaChi;
            dtonv.EMAIL = this.Email;
            dtonv.GIOITINH = this.GioiTinh;
            dtonv.HOTEN = this.HoTen;
            dtonv.MANHANVIEN = this.MaNhanVien;
            dtonv.MAPHONG = this.MaPhong;
            dtonv.MATKHAU = this.MatKhau;
            dtonv.NGAYSINH = this.NgaySinh;
            dtonv.QUEQUAN = this.QueQuan;
            dtonv.SODT = this.SoDT;
            return dtonv;
        }
        public void SetNhanVien(dtoNhanVien dtonv)
        {
            this.HoTen = dtonv.HOTEN;
            this.CMND = dtonv.CMND;
            this.DiaChi = dtonv.DIACHI;
            this.Email = dtonv.EMAIL;
            this.GioiTinh = dtonv.GIOITINH;
            this.MaNhanVien = dtonv.MANHANVIEN;
            this.MaPhong = dtonv.MAPHONG;
            this.MatKhau = dtonv.MATKHAU;
            this.NgaySinh = dtonv.NGAYSINH;
            this.QueQuan = dtonv.QUEQUAN;
            this.SoDT = dtonv.SODT;
        }
        public NhanVien()
        {

        }
        public NhanVien(dtoNhanVien dtonv)
        {
            this.HoTen = dtonv.HOTEN;
            this.CMND = dtonv.CMND;
            this.DiaChi = dtonv.DIACHI;
            this.Email = dtonv.EMAIL;
            this.GioiTinh = dtonv.GIOITINH;
            this.MaNhanVien = dtonv.MANHANVIEN;
            this.MaPhong = dtonv.MAPHONG;
            this.MatKhau = dtonv.MATKHAU;
            this.NgaySinh = dtonv.NGAYSINH;
            this.QueQuan = dtonv.QUEQUAN;
            this.SoDT = dtonv.SODT;
        }
        public bool CapNhat()
        {
            return dalnv.SuaThongTinNhanVien(this.GetDTONhanVien());
        }

        public bool Luu()
        {
            return dalnv.ThemNhanVien(this.GetDTONhanVien());
        }

        public bool Xoa()
        {
            return dalnv.XoaNhanVien(this.MaNhanVien);
        }

        public bool CoTonTai(int manv)
        {
            dtoNhanVien dto_nhanvien = new dtoNhanVien();
            dto_nhanvien = LayThongTinNhanVien(manv);
            if (dto_nhanvien != null)
            {
                return true;
            }
            return false;
        }
        public List<dtoNhanVien> LayDanhSachNhanVien()
        {
            return dalnv.LayDanhSachNhanVien();
        }
        public List<dtoNhanVien> LayDanhSachNhanVien(int maPhongBan)
        {
            return dalnv.LayDanhSachNhanVien(maPhongBan);
        }

        public dtoNhanVien LayThongTinNhanVien(int manv)
        {
            return dalnv.LayThongTinNhanVien(manv);
        }

        public Tour ChonTourCanXem(int matour)
        {
            throw new System.NotImplementedException();
        }

        public DoiTac ChonDoiTacCanXem(int madoitac)
        {
            throw new System.NotImplementedException();
        }

    }
}

