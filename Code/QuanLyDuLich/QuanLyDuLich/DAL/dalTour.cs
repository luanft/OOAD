﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DataTranferObject;
    using System.Data;
    using System.Windows.Forms;
    using BLL;
    public class dalTour : dalObject
    {
        public bool ThemTour(dtoTour tour)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[TOUR]([MANHANVIEN],[MAKHACHHANG],[NHAXE],[HUONGDANVIEN],[TENTOUR],[THOIGIAN],[NGAYDI],[TONGGIATOUR],[TRANGTHAI],[UUDAI],[GHICHU],[NgayLapTour])VALUES('" +
                tour.MANHANVIEN + "','" + tour.MAKHACHHANG + "','" + tour.NHAXE + "','" + tour.HUONGDANVIEN + "',N'" + tour.TENTOUR + "',N'" + tour.THOIGIAN + "','" + tour.NGAYDI.ToShortDateString() + "','" +
                tour.TONGGIATOUR + "','" + tour.TRANGTHAI + "',N'" + tour.UUDAI + "',N'" + tour.GHICHU + "','" + tour.NGAYLAPTOUR.ToShortDateString() + "')";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }

        public int LayTourMoiLap(int maNhanVien)
        {
            string sql = "select max(MATOUR) as MATOUR from TOUR where MANHANVIEN = " + maNhanVien;
            int ma = 0;
            if (this.Connect())
            {
                DataTable data = this.Read(sql);

                ma = int.Parse(data.Rows[0]["MATOUR"].ToString());
                this.Close();
            }
            return ma;
        }

        public List<dtoTour> LayDanhSachTourCanDuyet()
        {
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[TOUR] where [TRANGTHAI] = 'CHO_DIEU_HANH_DUYET'";
            DataTable dtDoiTac = this.Read(sql);

            List<dtoTour> listTour = new List<dtoTour>();
            foreach (DataRow dr in dtDoiTac.Rows)
            {
                dtoTour dto = new dtoTour();
                dto.MATOUR = int.Parse(dr["MATOUR"].ToString());
                dto.HUONGDANVIEN = int.Parse(dr["HUONGDANVIEN"].ToString());
                dto.MAKHACHHANG = int.Parse(dr["MAKHACHHANG"].ToString());
                dto.NHAXE = int.Parse(dr["NHAXE"].ToString());
                dto.MANHANVIEN = int.Parse(dr["MANHANVIEN"].ToString());
                dto.TENTOUR = dr["TENTOUR"].ToString();
                dto.THOIGIAN = dr["THOIGIAN"].ToString();
                dto.NGAYDI = DateTime.Parse(dr["NGAYDI"].ToString());
                dto.TRANGTHAI = dr["TRANGTHAI"].ToString();
                dto.UUDAI = dr["UUDAI"].ToString();
                dto.GHICHU = dr["GHICHU"].ToString();
                dto.TONGGIATOUR = int.Parse(dr["TONGGIATOUR"].ToString());
                dto.NGAYLAPTOUR = DateTime.Parse(dr["NGAYLAPTOUR"].ToString());
                listTour.Add(dto);
            }
            return listTour;
        }

        public Tour LoadTour(int maTour)
        {
            Tour t = new Tour();
            dalLichTrinh dalLt = new dalLichTrinh();
            if(this.Connect())
            {
                string sql = "select * from [dbo].[TOUR] where [MATOUR] = " + maTour;
                DataTable data = this.Read(sql);
                DataRow dr = data.Rows[0];
                t.MaTour = int.Parse(dr["MATOUR"].ToString());
                t.HuongDanVien = new DoiTac();
                t.HuongDanVien.MaDoiTac = int.Parse(dr["HUONGDANVIEN"].ToString());
                t.KhachHang = new KhachHang();
                t.KhachHang.pMaKhachHang = int.Parse(dr["MAKHACHHANG"].ToString());
                t.NhaXe = new DoiTac();
                t.NhaXe.MaDoiTac = int.Parse(dr["NHAXE"].ToString());
                t.MaNhanVien = int.Parse(dr["MANHANVIEN"].ToString());
                t.TenTour = dr["TENTOUR"].ToString();
                t.ThoiGian = dr["THOIGIAN"].ToString();
                t.NgayDi = DateTime.Parse(dr["NGAYDI"].ToString());
                t.TrangThai = dr["TRANGTHAI"].ToString();
                t.UuDai = dr["UUDAI"].ToString();
                t.GhiChu = dr["GHICHU"].ToString();
                t.TongGiaTour = dr["TONGGIATOUR"].ToString();
                t.NgayLapTour = DateTime.Parse(dr["NGAYLAPTOUR"].ToString());
                t.LichTrinh = dalLt.LoadLichTrinh(t.MaTour);
                this.Close();
            }
            return t;
        }

        public List<dtoTour> LayDanhSachTour(int maNhanVien)
        {
            List<dtoTour> listTour = new List<dtoTour>();
            if (this.Connect())
            {


                string sql = "select * from [dbo].[TOUR] where [MANHANVIEN] =" + maNhanVien + " order by MATOUR desc";
                DataTable dtDoiTac = this.Read(sql);

                
                foreach (DataRow dr in dtDoiTac.Rows)
                {
                    dtoTour dto = new dtoTour();
                    dto.MATOUR = int.Parse(dr["MATOUR"].ToString());
                    dto.HUONGDANVIEN = int.Parse(dr["HUONGDANVIEN"].ToString());
                    dto.MAKHACHHANG = int.Parse(dr["MAKHACHHANG"].ToString());
                    dto.NHAXE = int.Parse(dr["NHAXE"].ToString());
                    dto.MANHANVIEN = int.Parse(dr["MANHANVIEN"].ToString());
                    dto.TENTOUR = dr["TENTOUR"].ToString();
                    dto.THOIGIAN = dr["THOIGIAN"].ToString();
                    dto.NGAYDI = DateTime.Parse(dr["NGAYDI"].ToString());
                    dto.TRANGTHAI = dr["TRANGTHAI"].ToString();
                    dto.UUDAI = dr["UUDAI"].ToString();
                    dto.GHICHU = dr["GHICHU"].ToString();
                    dto.TONGGIATOUR = int.Parse(dr["TONGGIATOUR"].ToString());
                    dto.NGAYLAPTOUR = DateTime.Parse(dr["NGAYLAPTOUR"].ToString());
                    listTour.Add(dto);
                }
                this.Close();
            }
            return listTour;
        }

        public bool XoaTour(int maTour)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "DELETE FROM [dbo].[TOUR] WHERE [MATOUR]='" + maTour + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }



        public bool CapNhatTour(int maTour, string trangThai, string giaTour, string ghiChu)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[TOUR]" +
              "SET [TRANGTHAI] = '" + trangThai +
              "' ,[TONGGIATOUR] = '" + giaTour +
              "',[GHICHU] = N'" + ghiChu +
              "'WHERE [MATOUR]='" + maTour + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }

        public bool CapNhatTour(int maTour, bool trangThai, string ghiChu)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[TOUR]" +
              "SET [TRANGTHAI] = '" + trangThai +
              "',[GHICHU] = '" + ghiChu +
              "'WHERE [MATOUR]='" + maTour + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }

        public bool CapNhatTour(dtoTour tour)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[TOUR]" +
              "SET [MANHANVIEN] = '" + tour.MANHANVIEN +
              " ',[MAKHACHHANG] = '" + tour.MAKHACHHANG +
              "',[NHAXE] = '" + tour.NHAXE +
              "',[HUONGDANVIEN] = '" + tour.HUONGDANVIEN +
              "',[TENTOUR] = N'" + tour.TENTOUR +
              "',[THOIGIAN] = N'" + tour.THOIGIAN +
              "',[NGAYDI] = '" + tour.NGAYDI +
              "',[TONGGIATOUR] = '" + tour.TONGGIATOUR +
              "',[TRANGTHAI] = '" + tour.TRANGTHAI +
              "',[UUDAI] = N'" + tour.UUDAI +
              "',[GHICHU] = N'" + tour.GHICHU +
              "'WHERE [MATOUR]='" + tour.MATOUR + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }

        public bool CapNhatTour(int maTour, int maDoiTac)
        {
            throw new System.NotImplementedException();
        }

        
    }
}

