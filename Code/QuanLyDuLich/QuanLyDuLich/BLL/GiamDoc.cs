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

	public class GiamDoc : NhanVien
	{
		//public IEnumerable<NhanVien> NhanVien;
      
		public NhanVien ChonNhanVien(int manv)
		{
            dalNhanVien dalnv = new dalNhanVien();
            dtoNhanVien dtonv = dalnv.LayThongTinNhanVien(manv);
            NhanVien nhanvien = new NhanVien();
            nhanvien.SetNhanVien(dtonv);
            return nhanvien;
		}

		public bool CapNhatThongTinNhanVien(NhanVien nv, dtoNhanVien data)
		{
			nv.SetNhanVien(data);
            return nv.CapNhat();
		}

		public bool ThemNhanVien(dtoNhanVien data)
		{
			NhanVien nhanvien = new NhanVien();
            SetNhanVien(data);
            return nhanvien.Luu();
		}

		public Tour ChonTourCanDuyet(int matour)
		{
			throw new System.NotImplementedException();
		}

		public void NhapGiaTour(Tour tour)
		{
			throw new System.NotImplementedException();
		}

	}
}

