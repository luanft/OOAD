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

	public class ChiTietLichTrinh
	{
        private int maLichTrinh;

        public int MaLichTrinh
        {
            get { return maLichTrinh; }
            set { maLichTrinh = value; }
        }


        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        private string noiDung;

        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }

        private DoiTac doiTac;

        public DoiTac DoiTac
        {
            get { return doiTac; }
            set { doiTac = value; }
        }


        public void Luu()
        {
            DataAccessLayer.dalChiTietLichTrinh dal = new DataAccessLayer.dalChiTietLichTrinh();
            DataTranferObject.dtoChiTietLichTrinh dto = new DataTranferObject.dtoChiTietLichTrinh();

            dto.MADOITAC = doiTac.MaDoiTac;
            dto.NOIDUNG = noiDung;
            dto.THOIGIAN = thoiGian;
            dto.MALICHTRINH = maLichTrinh;

            dal.ThemCTLT(dto);
        }
	}
}

