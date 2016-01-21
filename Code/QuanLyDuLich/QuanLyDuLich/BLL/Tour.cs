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
    using QuanLyDuLich.GUI;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

	public class Tour
	{
       
        private int maNhanVien;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private int maTour;

        public int MaTour
        {
            get { return maTour; }
            set { maTour = value; }
        }

        private string tenTour;

        public string TenTour
        {
            get { return tenTour; }
            set { tenTour = value; }
        }

        private string tongGiaTour;

        public string TongGiaTour
        {
            get { return tongGiaTour; }
            set { tongGiaTour = value; }
        }

        private DateTime ngayDi;

        public DateTime NgayDi
        {
            get { return ngayDi; }
            set { ngayDi = value; }
        }

        private string tenKhachHang;

        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }

        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private string uuDai;

        public string UuDai
        {
            get { return uuDai; }
            set { uuDai = value; }
        }

        private DateTime ngayLapTour;

        public DateTime NgayLapTour
        {
            get { return ngayLapTour; }
            set { ngayLapTour = value; }
        }

        private string thongTinTour = "";

        public string ThongTinTour
        {
            get { return thongTinTour; }
            set { thongTinTour = value; }
        }

        private List<LichTrinh> lichTrinh = new List<LichTrinh>();

        public List<LichTrinh> LichTrinh
        {
            get { return lichTrinh; }
            set { lichTrinh = value; }
        }

        private KhachHang khachHang = new KhachHang();

        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        private DoiTac nhaXe = new DoiTac();

        public DoiTac NhaXe
        {
            get { return nhaXe; }
            set { nhaXe = value; }
        }

        private DoiTac huongDanVien = new DoiTac();

        public DoiTac HuongDanVien
        {
            get { return huongDanVien; }
            set { huongDanVien = value; }
        }        

        public Tour() { }

        public Tour(dtoTour dto)
        {
            this.MaTour = dto.MATOUR;
            this.NgayDi = dto.NGAYDI;
            this.NgayLapTour = dto.NGAYLAPTOUR;
            this.TenTour = dto.TENTOUR;
            this.ThoiGian = dto.THOIGIAN;
            this.TongGiaTour = dto.TONGGIATOUR.ToString();
            this.TrangThai = dto.TRANGTHAI;
            this.UuDai = dto.UUDAI;
            this.GhiChu = dto.GHICHU;
            this.MaNhanVien = dto.MANHANVIEN;
            this.ThongTinTour = dto.THONGTINTOUR;

            dalDoiTac dal_DoiTac = new dalDoiTac();
            this.NhaXe = new DoiTac(dal_DoiTac.LayDoiTac(dto.NHAXE));
            this.HuongDanVien = new DoiTac(dal_DoiTac.LayDoiTac(dto.HUONGDANVIEN));

            dalKhachHang dal_KhachHang = new dalKhachHang();
            this.KhachHang = new KhachHang(dal_KhachHang.LayKhachHang(dto.MAKHACHHANG));

            dalLichTrinh dal_LichTrinh = new dalLichTrinh();
            List<dtoLichTrinh> ldtoLT = dal_LichTrinh.LayDanhSachLichTrinh(dto.MATOUR);
            foreach (dtoLichTrinh lt in ldtoLT)
            {
                this.lichTrinh.Add(new LichTrinh(lt));
            }
        }

		public bool CapNhat()
		{
            dalTour dal_Tour = new dalTour();
            
            return dal_Tour.CapNhatTour(this.maTour, this.trangThai, this.ghiChu);            
		}
        public bool CapNhatLanCuoi()
        {
            dalTour dal_Tour = new dalTour();

            return dal_Tour.CapNhatTour(this.maTour, this.trangThai, this.tongGiaTour, this.ghiChu);  
        }
        public bool ChinhSuaTour()
        {
            dalTour dal_Tour = new dalTour();

            dtoTour dto = new dtoTour();
            dto.TENTOUR = tenTour;
            dto.MATOUR = maTour;
            dto.MANHANVIEN = MaNhanVien;
            dto.NGAYDI = ngayDi;
            dto.NGAYLAPTOUR = NgayLapTour;
            dto.THOIGIAN = thoiGian;
            dto.TONGGIATOUR = int.Parse(tongGiaTour);
            dto.TRANGTHAI = "MOI_LAP";
            dto.UUDAI = uuDai;
            dto.GHICHU = ghiChu;
            dto.HUONGDANVIEN = huongDanVien.MaDoiTac;
            dto.NHAXE = nhaXe.MaDoiTac;
            dto.MAKHACHHANG = khachHang.pMaKhachHang;
            dto.THONGTINTOUR = thongTinTour;
            foreach(LichTrinh i in LichTrinh)
            {
                i.MaTour = maTour;                
                if (i.MaLichTrinh <= 0)
                    i.MaLichTrinh = i.Luu();
                foreach(ChiTietLichTrinh c in i.pChiTietLichTrinh)
                {

                    if(c.MaChiTietLichTrinh <= 0)
                    {
                        c.MaLichTrinh = i.MaLichTrinh;
                        c.Luu();
                    }
                }
            }
            return dal_Tour.CapNhatTour(dto);
        }

		public bool Luu()
		{
            DataAccessLayer.dalTour dal = new DataAccessLayer.dalTour();


            dtoTour dto = new dtoTour();
            dto.MAKHACHHANG = khachHang.pMaKhachHang;
            dto.MANHANVIEN = maNhanVien;
            dto.NGAYDI = ngayDi;
            dto.NGAYLAPTOUR = this.ngayLapTour ;
            dto.TENTOUR = tenTour;
            dto.TRANGTHAI = trangThai;
            dto.UUDAI = uuDai;
            dto.GHICHU = ghiChu;
            dto.HUONGDANVIEN = huongDanVien.MaDoiTac;
            dto.NHAXE = nhaXe.MaDoiTac;
            dto.TONGGIATOUR = 0;
            dto.THOIGIAN = thoiGian;
            dto.THONGTINTOUR = thongTinTour;
            bool rs = dal.ThemTour(dto);
            if (rs)
            {
                int ma = dal.LayTourMoiLap(dto.MANHANVIEN);
                foreach(LichTrinh i in LichTrinh)
                {
                    i.MaTour = ma;
                    int lt = i.Luu();
                    foreach (ChiTietLichTrinh c in i.pChiTietLichTrinh)
                    {
                        c.MaLichTrinh = lt;
                        c.Luu();                        
                    }
                }
            }
            return rs;
            
		}

		public dtoTour LayThongTinTour()
		{
			throw new System.NotImplementedException();
		}               
	}
}

