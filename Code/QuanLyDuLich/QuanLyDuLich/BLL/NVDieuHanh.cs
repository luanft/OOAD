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

    public class NVDieuHanh : NhanVien
    {
        private List<DoiTac> DanhSachDoiTac;
        private List<Tour> DanhSachTourCanDuyet;

        public List<Tour> pDanhSachTourCanDuyet
        {
            get { return DanhSachTourCanDuyet; }
            set { DanhSachTourCanDuyet = value; }
        }

        public List<DoiTac> pDanhSachDoiTac
        {
            get { return DanhSachDoiTac; }
            set { DanhSachDoiTac = value; }
        }

        public NVDieuHanh()
        {
            dalDoiTac dal_DoiTac = new dalDoiTac();
            List<dtoDoiTac> dsDoiTac;
            DanhSachDoiTac = new List<DoiTac>();
            dsDoiTac = dal_DoiTac.LayDanhSachDoiTac(1);
            foreach (dtoDoiTac dt in dsDoiTac)
            {
                DoiTac doiTac = new DoiTac(dt);
                DanhSachDoiTac.Add(doiTac);
            }

            dalTour dal_Tour = new dalTour();
            List<dtoTour> dsTour = new List<dtoTour>();
            DanhSachTourCanDuyet = new List<Tour>();
            dsTour = dal_Tour.LayDanhSachTourCanDuyet();
            foreach (dtoTour tour in dsTour)
            {
                Tour t = new Tour(tour);
                DanhSachTourCanDuyet.Add(t);
            }
        }

        public bool CapNhat(DoiTac doiTac, dtoDoiTac data)
        {
            //doiTac.pMaDoiTac = data.MADOITAC;
            //doiTac.pLoaiDoiTac = data.LOAIDOITAC;
            //doiTac.pEmail = data.EMAIL;
            //doiTac.pDiaChi = data.DIACHI;
            //doiTac.pDanhGiaDoiTac = data.DANHGIADOITAC;
            //doiTac.pNguoiLienHe = data.NGUOILIENHE;
            //doiTac.pSoDT = data.DIENTHOAI;
            //doiTac.pTenDoiTac = data.TENDOITAC;
            return doiTac.CapNhat();
        }

        public DoiTac ChonDoiTac(int ma)
        {
            foreach (DoiTac dt in DanhSachDoiTac)
            {
                if (dt.MaDoiTac.Equals(ma))
                    return dt;
            }
            return null;
        }

        public bool ThemDoiTac(dtoDoiTac data)
        {
            DoiTac doiTac = new DoiTac(data);
            DanhSachDoiTac.Add(doiTac);
            return doiTac.Luu();
        }

        public Tour ChonTourCanDuyet(int matour)
        {
            throw new System.NotImplementedException();
        }

        public bool DuyetTour(Tour tour)
        {
            throw new System.NotImplementedException();
        }

    }
}

