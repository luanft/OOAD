﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace BLL
{
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
		public bool DangNhap(string maNv, string mk)
		{
			throw new System.NotImplementedException();
		}

		public void DangXuat()
		{
			throw new System.NotImplementedException();
		}

		public LoaiNhanVien LayLoaiNV()
		{
			throw new System.NotImplementedException();
		}

		public bool CapNhat()
		{
			throw new System.NotImplementedException();
		}

		public bool Luu()
		{
			throw new System.NotImplementedException();
		}

		public bool Xoa()
		{
			throw new System.NotImplementedException();
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

