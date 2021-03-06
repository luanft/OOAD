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
using BLL;
    public class dalLichTrinh : dalObject
    {
        public List<LichTrinh > LoadLichTrinh(int maTour)
        {
            List<LichTrinh> lt = new List<LichTrinh>();
            dalChiTietLichTrinh dal = new dalChiTietLichTrinh();
            if(Connect())
            {
                string sql = "select * from LICHTRINH where MATOUR = " + maTour;
                DataTable lts = Read(sql);
                foreach (DataRow dr in lts.Rows)
                {
                    LichTrinh l = new LichTrinh();
                    lt.Add(l);
                    l.MaTour = maTour;
                    l.Ngay = dr["NGAY"].ToString();
                    l.MaLichTrinh = int.Parse(dr["MALICHTRINH"].ToString());
                    l.TenLichTrinh = dr["TENLICHTRINH"].ToString();
                    l.pChiTietLichTrinh = dal.LayDanhSachChiTiet(l.MaLichTrinh);
                }
                Close();
            }

            return lt;
        }
        public int ThemLichTrinh(dtoLichTrinh lichTrinh)
        {
            int maLichTrinh = -1;
            if (this.Connect())
            {

                string sql = "INSERT INTO [dbo].[LICHTRINH] ([MATOUR],[TENLICHTRINH],[NGAY])"
                + "VALUES('" + lichTrinh.MATOUR + "',N'" + lichTrinh.TENLICHTRINH + "','" + lichTrinh.NGAY + "')";
                if (this.Write(sql))
                {
                    DataTable dt = this.Read("select max(MALICHTRINH) as MALICHTRINH from LICHTRINH where LICHTRINH.MATOUR = " + lichTrinh.MATOUR);
                    maLichTrinh = int.Parse(dt.Rows[0]["MALICHTRINH"].ToString());
                }

            }
            this.Close();
            return maLichTrinh;
        }

        public bool SuaLichTrinh(dtoLichTrinh lichTrinh)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[LICHTRINH] SET [TENLICHTRINH] = N'" + lichTrinh.TENLICHTRINH + "',[MATOUR]='" + lichTrinh.MATOUR + "',[NGAY]='" + lichTrinh.NGAY + "' WHERE [MALICHTRINH] ='" + lichTrinh.MALICHTRINH + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }

        public bool XoaLichTrinh(int malt)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "DELETE FROM [dbo].[LICHTRINH] WHERE [MALICHTRINH]='" + malt + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }

        public bool ThemDanhSachLichTrinh(List<dtoLichTrinh> dslt)
        {
            if (!this.Connect())
            {
                return false;
            }
            for (int i = 0; i < dslt.Count - 1; i++)
            {
                string sql = "INSERT INTO [dbo].[LICHTRINH] ([MATOUR],[TENLICHTRINH],[NGAY])"
                     + "VALUES('" + dslt[i].MATOUR + "',N'" + dslt[i].TENLICHTRINH + "','" + dslt[i].NGAY + "')";
                this.Write(sql);
            }
            this.Close();
            return true;
        }

        public List<dtoLichTrinh> LayDanhSachLichTrinh(int maTour)
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MALICHTRINH],[MATOUR],[TENLICHTRINH],[NGAY] FROM [dbo].[LICHTRINH] WHERE MATOUR = '" + maTour + "'";
            DataTable dtLichTrinh = this.Read(sql);
            this.Close();

            List<dtoLichTrinh> lDtoLichTrinh = new List<dtoLichTrinh>();
            foreach (DataRow dr in dtLichTrinh.Rows)
            {
                dtoLichTrinh dto_LichTrinh = new dtoLichTrinh();
                dto_LichTrinh.MALICHTRINH = Int32.Parse(dr[0].ToString());
                dto_LichTrinh.MATOUR = Int32.Parse(dr[1].ToString());
                dto_LichTrinh.TENLICHTRINH = dr[2].ToString();
                dto_LichTrinh.NGAY = Int32.Parse(dr[3].ToString());
                lDtoLichTrinh.Add(dto_LichTrinh);
            }
            return lDtoLichTrinh;
        }

    }
}

