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
    using System.Windows.Forms;
    using System.Data;
    using BLL;
    public class dalKhachHang : dalObject
    {
        public bool ThemKhachHang(dtoKhachHang khachHang)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[KHACHHANG]([MANHANVIEN],[TENDONVI],[NGUOIDAIDIEN],[GIOITINH],[EMAIL],[DIENTHOAI],[SONGUOI],[DIACHI],[LOAIKHACHHANG],[TRANGTHAI])VALUES(" + khachHang.MANHANVIEN + ",N'" +
                khachHang.TENDONVI + "',N'" + khachHang.NGUOIDAIDIEN + "',N'" + khachHang.GIOITINH + "','" + khachHang.EMAIL + "','" + khachHang.DIENTHOAI +
                "'," + khachHang.SONGUOI + ",N'" + khachHang.DIACHI + "','" + khachHang.LOAIKHACHHANG +"',"+1+ ")";
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

        public bool SuaThongTinKhachHang(dtoKhachHang khachHang)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[KHACHHANG]SET[TENDONVI] = N'" + khachHang.TENDONVI +
      "',[NGUOIDAIDIEN] = N'" + khachHang.NGUOIDAIDIEN +
      "',[GIOITINH] = N'" + khachHang.GIOITINH +
      "',[EMAIL] = '" + khachHang.EMAIL +
      "',[DIENTHOAI] = '" + khachHang.DIENTHOAI +
      "',[SONGUOI] = " + khachHang.SONGUOI +
      ",[DIACHI] = N'" + khachHang.DIACHI +
      "',[LOAIKHACHHANG] = N'" + khachHang.LOAIKHACHHANG +
      "'WHERE [MAKHACHHANG] = " + khachHang.MAKHACHHANG ;
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

        public bool XoaKhachHang(int maKH)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[KHACHHANG]SET[TRANGTHAI] = 0 WHERE [MAKHACHHANG]=" + maKH ;
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

        public dtoKhachHang LayKhachHang(int maKH)
        {
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[KHACHHANG] where MAKHACHHANG = " + maKH;
            DataTable dtKhachHang = this.Read(sql);

            dtoKhachHang dto = new dtoKhachHang();
            foreach (DataRow dr in dtKhachHang.Rows)
            {
                dto.MAKHACHHANG = Int32.Parse(dr[0].ToString());
                dto.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dto.TENDONVI = dr[2].ToString();
                dto.NGUOIDAIDIEN = dr[3].ToString();
                dto.GIOITINH = dr[4].ToString();
                dto.EMAIL = dr[5].ToString();
                dto.DIENTHOAI = dr[6].ToString();
                dto.SONGUOI = Int32.Parse(dr[7].ToString());
                dto.DIACHI = dr[8].ToString();
                dto.LOAIKHACHHANG = dr[9].ToString();
            }
            this.Close();
            return dto;
        }


        public KhachHang LoadKH(int maKH)
        {
            KhachHang kh = new KhachHang();
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[KHACHHANG] where MAKHACHHANG = " + maKH;
            DataTable dtKhachHang = this.Read(sql);


            DataRow dr = dtKhachHang.Rows[0];

            kh.pMaKhachHang = Int32.Parse(dr[0].ToString());
            kh.pMaNhanVien = Int32.Parse(dr[1].ToString());
            kh.pTenDonVi = dr[2].ToString();
            kh.pNguoiDaiDien = dr[3].ToString();
            kh.pGioiTinh = dr[4].ToString();
            kh.pEmail = dr[5].ToString();
            kh.pSoDT = dr[6].ToString();
            kh.pSoNguoi = Int32.Parse(dr[7].ToString());
            kh.pDiaChi = dr[8].ToString();
            kh.pLoaiKhachHang = dr[9].ToString();

            this.Close();
            return kh;
        }

        public List<dtoKhachHang> LayDanhSachKhachHang(int maNhanVien)
        {
            List<dtoKhachHang> ldtoKhachHang = new List<dtoKhachHang>();
            if (this.Connect())
            {
                string sql = "select * from [dbo].[KHACHHANG] where MANHANVIEN=" + maNhanVien + "AND TRANGTHAI=1";
                DataTable dtKhachHang = this.Read(sql);


                foreach (DataRow dr in dtKhachHang.Rows)
                {
                    dtoKhachHang dtoKhachHang = new dtoKhachHang();
                    dtoKhachHang.MAKHACHHANG = Int32.Parse(dr[0].ToString());
                    dtoKhachHang.MANHANVIEN = Int32.Parse(dr[1].ToString());
                    dtoKhachHang.TENDONVI = dr[2].ToString();
                    dtoKhachHang.NGUOIDAIDIEN = dr[3].ToString();
                    dtoKhachHang.GIOITINH = dr[4].ToString();
                    dtoKhachHang.EMAIL = dr[5].ToString();
                    dtoKhachHang.DIENTHOAI = dr[6].ToString();
                    dtoKhachHang.SONGUOI = Int32.Parse(dr[7].ToString());
                    dtoKhachHang.DIACHI = dr[8].ToString();
                    dtoKhachHang.LOAIKHACHHANG = dr[9].ToString();
                    ldtoKhachHang.Add(dtoKhachHang);
                }
                this.Close();

            }
            return ldtoKhachHang;

        }
        //khi dang nhap duoc se xoa ham nay
        public List<dtoKhachHang> LayDanhSachKhachHang()
        {
            List<dtoKhachHang> ldtoKhachHang = new List<dtoKhachHang>();
            if (this.Connect())
            {
                string sql = "select * from [dbo].[KHACHHANG]";
                DataTable dtKhachHang = this.Read(sql);


                foreach (DataRow dr in dtKhachHang.Rows)
                {
                    dtoKhachHang dtoKhachHang = new dtoKhachHang();
                    dtoKhachHang.MAKHACHHANG = Int32.Parse(dr[0].ToString());
                    dtoKhachHang.MANHANVIEN = Int32.Parse(dr[1].ToString());
                    dtoKhachHang.TENDONVI = dr[2].ToString();
                    dtoKhachHang.NGUOIDAIDIEN = dr[3].ToString();
                    dtoKhachHang.GIOITINH = dr[4].ToString();
                    dtoKhachHang.EMAIL = dr[5].ToString();
                    dtoKhachHang.DIENTHOAI = dr[6].ToString();
                    dtoKhachHang.SONGUOI = Int32.Parse(dr[7].ToString());
                    dtoKhachHang.DIACHI = dr[8].ToString();
                    dtoKhachHang.LOAIKHACHHANG = dr[9].ToString();
                    ldtoKhachHang.Add(dtoKhachHang);
                }
                this.Close();

            }
            return ldtoKhachHang;

        }
        public List<dtoKhachHang> LayDanhSachKhachHang2(int manv)
        {
            List<dtoKhachHang> ldtoKhachHang = new List<dtoKhachHang>();
            if (this.Connect())
            {
                string sql = "select MAKHACHHANG,NGUOIDAIDIEN from [dbo].[KHACHHANG]where MANHAVVIEN="+manv+"AND TRANGTHAI=1";
                DataTable dtKhachHang = this.Read(sql);


                foreach (DataRow dr in dtKhachHang.Rows)
                {
                    dtoKhachHang dtoKhachHang = new dtoKhachHang();
                    dtoKhachHang.MAKHACHHANG = Int32.Parse(dr[0].ToString());                    
                    dtoKhachHang.NGUOIDAIDIEN = dr[1].ToString();                    
                    ldtoKhachHang.Add(dtoKhachHang);
                }
                this.Close();

            }
            return ldtoKhachHang;

        }

    }
}

