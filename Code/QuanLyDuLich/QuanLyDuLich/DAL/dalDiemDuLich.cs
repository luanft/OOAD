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
    public class dalDiemDuLich : dalObject
    {
        public bool ThemDiemDuLich(dtoDiemDuLich diemDuLich)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[DIEMDULICH] ([MANHANVIEN],[TENDIEMDULICH],[MOTA])"
            + "VALUES('" + diemDuLich.MANHANVIEN + "','" + diemDuLich.TENDIEMDULICH + "','" + diemDuLich.MOTA + "')";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }

        public bool XoaDiemDuLich(int maDDL)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "DELETE FROM [dbo].[DIEMDULICH] WHERE [MADIEMDULICH]='" + maDDL + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }

        public List<dtoDiemDuLich> LayDanhSachDiemDuLich(int maNV)
        {
          if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MADIEMDULICH],[MANHANVIEN],[TENDIEMDULICH],[MOTA] FROM [dbo].[DIEMDULICH] WHERE [MANHANVIEN]='"+maNV+"'";
            DataTable dtDiemDuLich = this.Read(sql);
            this.Close();
            
            List<dtoDiemDuLich> lDtoDiemDuLich = new List<dtoDiemDuLich>();
            foreach (DataRow dr in dtDiemDuLich.Rows)
            {
                dtoDiemDuLich dto_DiemDuLich = new dtoDiemDuLich();
                dto_DiemDuLich.MADIEMDULICH = Int32.Parse(dr[0].ToString());
                dto_DiemDuLich.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dto_DiemDuLich.TENDIEMDULICH = dr[2].ToString();
                dto_DiemDuLich.MOTA = dr[3].ToString();
                lDtoDiemDuLich.Add(dto_DiemDuLich);
            }
            return lDtoDiemDuLich;
        }

        public bool SuaThongTinDiemDuLich(dtoDiemDuLich ddl)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[DIEMDULICH] SET [TENDIEMDULICH] = N'" + ddl.TENDIEMDULICH + "',[MOTA]=N'" + ddl.MOTA + "' WHERE [MADIEMDULICH] ='" + ddl.MADIEMDULICH + "'";
            if (this.Write(sql))
            {
                this.Close();
                MessageBox.Show("Đã cập nhật");
                return true;
            }
            this.Close();
            MessageBox.Show("Lỗi cập nhật");
            return false;
        }

        public List<dtoDiemDuLich> LayDanhSachDiemDuLich()
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MADIEMDULICH],[MANHANVIEN],[TENDIEMDULICH],[MOTA] FROM [dbo].[DIEMDULICH]";
            DataTable dtDiemDuLich = this.Read(sql);
            this.Close();            
            List<dtoDiemDuLich> lDtoDiemDuLich = new List<dtoDiemDuLich>();
            foreach (DataRow dr in dtDiemDuLich.Rows)
            {
                dtoDiemDuLich dto_DiemDuLich = new dtoDiemDuLich();
                dto_DiemDuLich.MADIEMDULICH = Int32.Parse(dr[0].ToString());
                dto_DiemDuLich.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dto_DiemDuLich.TENDIEMDULICH = dr[2].ToString();
                dto_DiemDuLich.MOTA = dr[3].ToString();
                lDtoDiemDuLich.Add(dto_DiemDuLich);
            }
            return lDtoDiemDuLich;
        }

    }
}

