﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DataAccessLayer
{
    using DataTranferObject;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    
	public class dalChiTietLichTrinh : dalObject
	{
		public bool ThemCTLT(dtoChiTietLichTrinh ctlt)
		{
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[CHITIETLICHTRINH]([MALICHTRINH],[MADOITAC],[NOIDUNG],[THOIGIAN])VALUES('"+
                ctlt.MALICHTRINH + "','" + ctlt.MADOITAC + "','" + ctlt.NOIDUNG + "','"+ctlt.THOIGIAN+"')";
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

		public bool SuaCTLT(dtoChiTietLichTrinh ctlt)
		{
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE[dbo].[CHITIETLICHTRINH]SET[MALICHTRINH]='" + ctlt.MALICHTRINH +
                "',[MADOITAC]='" + ctlt.MADOITAC + "',[NOIDUNG]='" + ctlt.NOIDUNG + "',[THOIGIAN]='" +
                ctlt.THOIGIAN + "' where [[MACHITIETLICHTRINH]]='"+ctlt.MACHITIETLICHTRINH+"'";
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

		public bool XoaCTLT(int mactlt)
		{
            if (!this.Connect())
            {
                return false;
            }
            string sql = "DELETE FROM [dbo].[CHITIETLICHTRINH] WHERE [MACHITIETLICHTRINH]='" + mactlt + "'";
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

		public bool ThemDanhSachCTLT(List<dtoChiTietLichTrinh> dsctlt)
		{
            foreach (dtoChiTietLichTrinh i in dsctlt) 
            {
                ThemCTLT(i);
            }
            return true;
		}

		public List<dtoChiTietLichTrinh> LayDanhSachCTLT(int maLichTrinh)
		{
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[CHITIETLICHTRINH]";
            DataTable dtChiTietLichTrinh = this.Read(sql);
            dtoChiTietLichTrinh dtochitietlichtrinh= new dtoChiTietLichTrinh();
            List<dtoChiTietLichTrinh> lDtoChiTietLichTrinh= new List<dtoChiTietLichTrinh>();
            foreach (DataRow dr in dtChiTietLichTrinh.Rows)
            {
                dtochitietlichtrinh.MACHITIETLICHTRINH=Int32.Parse(dr[0].ToString());
                dtochitietlichtrinh.MALICHTRINH=Int32.Parse(dr[1].ToString());
                dtochitietlichtrinh.MADOITAC=Int32.Parse(dr[2].ToString());
                dtochitietlichtrinh.NOIDUNG=dr[3].ToString();
                dtochitietlichtrinh.THOIGIAN=dr[4].ToString();
                lDtoChiTietLichTrinh.Add(dtochitietlichtrinh);
            }
            return lDtoChiTietLichTrinh;
            
		}

	}
}
