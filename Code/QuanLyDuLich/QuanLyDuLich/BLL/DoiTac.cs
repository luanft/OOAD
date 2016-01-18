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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

	public class DoiTac
	{
        private string tenDoiTac;

        public string TenDoiTac
        {
            get { return tenDoiTac; }
            set { tenDoiTac = value; }
        }

        private string nguoiLienHe;

        public string NguoiLienHe
        {
            get { return nguoiLienHe; }
            set { nguoiLienHe = value; }
        }

        private string soDT;

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int maDoiTac = -1;

        public int MaDoiTac
        {
            get { return maDoiTac; }
            set { maDoiTac = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string danhGiaDoiTac;

        public string DanhGiaDoiTac
        {
            get { return danhGiaDoiTac; }
            set { danhGiaDoiTac = value; }
        }

        private string loaiDoiTac;

        public string LoaiDoiTac
        {
            get { return loaiDoiTac; }
            set { loaiDoiTac = value; }
        }
       
        private int maNhanVien;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private dalDoiTac dal_DoiTac;

        public DoiTac()
        {
            dal_DoiTac = new dalDoiTac();
        }

        public DoiTac(dtoDoiTac dto)
        {
            dal_DoiTac = new dalDoiTac();
            MaDoiTac = dto.MADOITAC;
            LoaiDoiTac = dto.LOAIDOITAC;
            Email = dto.EMAIL;
            DiaChi = dto.DIACHI;
            DanhGiaDoiTac = dto.DANHGIADOITAC;
            NguoiLienHe = dto.NGUOILIENHE;
            SoDT = dto.DIENTHOAI;
            TenDoiTac = dto.TENDOITAC;
            MaNhanVien = dto.MANHANVIEN;
        }

        public bool CapNhat()
        {
            return dal_DoiTac.SuaThongTinDoiTac(LayThongTinDoiTac());
        }

        public bool Luu()
        {
            return dal_DoiTac.ThemDoiTac(LayThongTinDoiTac());
        }

        public bool Xoa()
        {
            return dal_DoiTac.XoaDoiTac(MaDoiTac);
        }

        public dtoDoiTac LayThongTinDoiTac()
        {
            dtoDoiTac dt = new dtoDoiTac();
            dt.MANHANVIEN = MaNhanVien;
            dt.MADOITAC = MaDoiTac;
            dt.LOAIDOITAC = LoaiDoiTac;
            dt.NGUOILIENHE = NguoiLienHe;
            dt.EMAIL = Email;
            dt.DIENTHOAI = SoDT;
            dt.DIACHI = DiaChi;
            dt.TENDOITAC = TenDoiTac;
            dt.DANHGIADOITAC = DanhGiaDoiTac;
            return dt;
        }

    }
}

