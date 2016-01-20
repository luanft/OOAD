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

	public class NVSale : NhanVien
	{
		public IEnumerable<Tour> Tour;

		public List<DiemDuLich> DanhSachDiemDuLich;
        public List<KhachHang> DanhSachKhachHang;
        public KhachHang khachHangDuocChon = new KhachHang();
        public DiemDuLich diemDuLichDuocChon = new DiemDuLich();
        public NVSale()
        { }
        public NVSale(int manv) 
        {
            this.SetNhanVien(this.LayThongTinNhanVien(manv));
            dalKhachHang dal_Khachhang = new dalKhachHang();
            DanhSachKhachHang = new List<KhachHang>();
            List<dtoKhachHang> ds_dtoKhachHang = new List<dtoKhachHang>();
            ds_dtoKhachHang= dal_Khachhang.LayDanhSachKhachHang(manv);            
            foreach (dtoKhachHang i in ds_dtoKhachHang) 
            {
                KhachHang tmp = new KhachHang(i);
                DanhSachKhachHang.Add(tmp);
            }


            //CapNhatDanhSachDiemDuLich(matinh);
        }
        public void CapNhatDanhSachDiemDuLich(int matinh)
        {
            dalDiemDuLich dal_DDL = new dalDiemDuLich();
            DanhSachDiemDuLich = new List<DiemDuLich>();
            List<dtoDiemDuLich> ds_dtoDiemDuLich = new List<dtoDiemDuLich>();
            ds_dtoDiemDuLich = dal_DDL.LayDanhSachDiemDuLich(matinh);
            foreach (dtoDiemDuLich i in ds_dtoDiemDuLich)
            {
                DiemDuLich tmp = new DiemDuLich(i);
                DanhSachDiemDuLich.Add(tmp);
            }
        }
		public bool CapNhatTour(Tour tour)
		{
            return tour.ChinhSuaTour();
		}

		public Tour ChonTour(int maTour)
		{
			throw new System.NotImplementedException();
		}

		public bool LapTour(Tour data)
		{
            return data.Luu();
		}

		public DiemDuLich ChonDiemDL(int ma)
		{
            foreach (DiemDuLich i in DanhSachDiemDuLich)
            {
                if (i.pMaDiemDuLich == ma)
                    return i;
            }
            return null;
		}

        public bool CapNhatDiemDuLich(DiemDuLich ddl, dtoDiemDuLich data)
		{
            ddl.CapNhat(data);
            CapNhatDanhSachDiemDuLich(ddl.pMaTinh);
            return true;    
		}

		public bool ThemDiemDuLich(dtoDiemDuLich data)
		{
            DiemDuLich ddl = new DiemDuLich(data);
            if(DanhSachDiemDuLich!=null)
                DanhSachDiemDuLich.Add(ddl);
            return ddl.Luu();
		}
        public bool XoaDiemDuLich(DiemDuLich ddl) 
        {
            DanhSachDiemDuLich.Remove(ddl);
            return ddl.Xoa(ddl.pMaDiemDuLich);
        }
		public bool CapNhatKhachHang(KhachHang kh, dtoKhachHang data)
		{
            return kh.CapNhat(data);            
		}
        public bool XoaKhachHang(KhachHang kh)
        {
            return kh.Xoa(kh.pMaKhachHang);
        }
		public KhachHang ChonKhachHang(int kh)
		{
            foreach (KhachHang i in DanhSachKhachHang)
            {
                if(i.pMaKhachHang==kh)
                {
                    return i;
                }                
            }
            return null;
		}
        public bool ThemKhachHang(dtoKhachHang KhachHang)
        {
            KhachHang kh = new KhachHang(KhachHang);
            DanhSachKhachHang.Add(kh);
            return kh.Luu();
        }

		public bool SubmitTour(Tour tour)
		{
            throw new NotImplementedException();
            
		}

		public List<Tour> ChonThoiGianXemTour(int thoiGian)
		{
			throw new System.NotImplementedException();
		}

	}
}

