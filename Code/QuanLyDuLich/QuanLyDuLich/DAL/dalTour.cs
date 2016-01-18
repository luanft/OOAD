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
    public class dalTour : dalObject
    {
        public bool ThemTour(dtoTour tour)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[TOUR]([MANHANVIEN],[MAKHACHHANG],[NHAXE],[HUONGDANVIEN],[TENTOUR],[THOIGIAN],[NGAYDI],[TONGGIATOUR],[TRANGTHAI],[UUDAI],[GHICHU],[NgayLapTour])VALUES('" +
                tour.MANHANVIEN + "','" + tour.MAKHACHHANG + "','" + tour.NHAXE + "','" + tour.HUONGDANVIEN + "',N'" + tour.TENTOUR + "','" + tour.THOIGIAN + "','" + tour.NGAYDI.ToShortDateString() + "','" +
                tour.TONGGIATOUR + "','" + tour.TRANGTHAI + "',N'" + tour.UUDAI + "',N'" + tour.GHICHU + "','" + tour.NgayLapTour.ToShortDateString() + "')";
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



        public bool CapNhatTour(int maTour, bool trangThai, string giaTour, string ghiChu)
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
              "',[THOIGIAN] = '" + tour.THOIGIAN +
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

