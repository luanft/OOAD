﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace BLL
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Tour
	{
		protected int MaTour;

		protected string TenTour;

		protected string TongGiaTour;

		protected DateTime NgayDi;

		protected string TenKhachHang;

		protected string ThoiGian;

		protected string GhiChu;

		protected string TrangThai;

		protected string UuDai;

		protected DateTime NgayLapTour
		{
			get;
			set;
		}

		public IEnumerable<LichTrinh> ChiTietTour;

		public KhachHang KhachHang;

		public DoiTac NhaXe;

		public DoiTac HuongDanVien;

		public bool CapNhat()
		{
			throw new System.NotImplementedException();
		}

		public bool Luu()
		{
			throw new System.NotImplementedException();
		}

		public dtoTour LayThongTinTour()
		{
			throw new System.NotImplementedException();
		}

	}
}
