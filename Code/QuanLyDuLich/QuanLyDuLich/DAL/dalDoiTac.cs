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
	public class dalDoiTac : dalObject
	{
		public bool ThemDoiTac(dtoDoiTac doiTac)
		{			
            if(!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[DOITAC]([MANHANVIEN],[TENDOITAC],[NGUOILIENHE],[DIENTHOAI],[DANHGIADOITAC],[DIACHI],[EMAIL],[LOAIDOITAC],[TRANGTHAI])VALUES('"+
                 doiTac.MANHANVIEN + "','" + doiTac.TENDOITAC + "','" + doiTac.NGUOILIENHE + "','" + doiTac.DIENTHOAI + "','" + doiTac.DANHGIADOITAC + "','" + doiTac.DIACHI + "','" + doiTac.EMAIL + "','" + doiTac.LOAIDOITAC + "','1')";
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

		public bool SuaThongTinDoiTac(dtoDoiTac doiTac)
		{
			if(!this.Connect())
            {
                return false;
            }            
            string sql = "UPDATE[dbo].[DOITAC]SET[MANHANVIEN]='"+doiTac.MANHANVIEN+
                "',[TENDOITAC]='"+doiTac.TENDOITAC+"',[NGUOILIENHE]='"+doiTac.NGUOILIENHE+"',[DIENTHOAI]='"+
                doiTac.DIENTHOAI+"',[DANHGIADOITAC]='"+doiTac.DANHGIADOITAC+"',[DIACHI]='"+doiTac.DIACHI+"',[EMAIL]='"+doiTac.EMAIL+
                "',[LOAIDOITAC]='"+doiTac.LOAIDOITAC+"' where [MADOITAC]='"+doiTac.MADOITAC+"'";
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

		public bool XoaDoiTac(int maDoiTac)
		{
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[DOITAC] SET [TRANGTHAI] = 0 WHERE [MADOITAC]='" + maDoiTac+"'";      
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

		public List<dtoDoiTac> LayDanhSachDoiTac(int maNhanVien)
		{
			if(!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[DOITAC] where [MANHANVIEN]='"+maNhanVien+"' and [TRANGTHAI] = 1";
            DataTable dtDoiTac = this.Read(sql);
            
            List<dtoDoiTac> lDtoDoiTac = new List<dtoDoiTac>();
            foreach(DataRow dr in dtDoiTac.Rows)
            {
                dtoDoiTac dtoDoiTac = new dtoDoiTac();
                dtoDoiTac.MADOITAC=Int32.Parse(dr[0].ToString());
                dtoDoiTac.MANHANVIEN=Int32.Parse(dr[1].ToString());
                dtoDoiTac.TENDOITAC=dr[2].ToString();
                dtoDoiTac.NGUOILIENHE=dr[3].ToString();
                dtoDoiTac.DIENTHOAI=dr[4].ToString();
                dtoDoiTac.DANHGIADOITAC=dr[5].ToString();
                dtoDoiTac.DIACHI=dr[6].ToString();
                dtoDoiTac.EMAIL=dr[7].ToString();
                dtoDoiTac.LOAIDOITAC = dr[8].ToString();
                lDtoDoiTac.Add(dtoDoiTac);
            }
            this.Close();
            return lDtoDoiTac;
		}

        public dtoDoiTac LayDoiTac(int maDoiTac)
        {
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[DOITAC] where [TRANGTHAI] = 1 and [MADOITAC] = " + maDoiTac;
            DataTable dtDoiTac = this.Read(sql);
            dtoDoiTac dtoDoiTac = new dtoDoiTac();
            foreach (DataRow dr in dtDoiTac.Rows)
            {                
                dtoDoiTac.MADOITAC = Int32.Parse(dr[0].ToString());
                dtoDoiTac.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dtoDoiTac.TENDOITAC = dr[2].ToString();
                dtoDoiTac.NGUOILIENHE = dr[3].ToString();
                dtoDoiTac.DIENTHOAI = dr[4].ToString();
                dtoDoiTac.DANHGIADOITAC = dr[5].ToString();
                dtoDoiTac.DIACHI = dr[6].ToString();
                dtoDoiTac.EMAIL = dr[7].ToString();
                dtoDoiTac.LOAIDOITAC = dr[8].ToString();                
            }
            this.Close();
            return dtoDoiTac;
        }

		public List<dtoDoiTac> LayDanhSachDoiTac()
		{
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[DOITAC] where [TRANGTHAI] = 1";
            DataTable dtDoiTac = this.Read(sql);
            
            List<dtoDoiTac> lDtoDoiTac = new List<dtoDoiTac>();
            foreach (DataRow dr in dtDoiTac.Rows)
            {
                dtoDoiTac dtoDoiTac = new dtoDoiTac();
                dtoDoiTac.MADOITAC = Int32.Parse(dr[0].ToString());
                dtoDoiTac.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dtoDoiTac.TENDOITAC = dr[2].ToString();
                dtoDoiTac.NGUOILIENHE = dr[3].ToString();
                dtoDoiTac.DIENTHOAI = dr[4].ToString();
                dtoDoiTac.DANHGIADOITAC = dr[5].ToString();
                dtoDoiTac.DIACHI = dr[6].ToString();
                dtoDoiTac.EMAIL = dr[7].ToString();
                dtoDoiTac.LOAIDOITAC = dr[8].ToString();
                lDtoDoiTac.Add(dtoDoiTac);
            }
            this.Close();
            return lDtoDoiTac;
		}

        public List<dtoDoiTac> LayDanhSachDoiTac(string loai)
        {
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với CSDL");
                return null;
            }
            string sql = "select * from [dbo].[DOITAC] where LOAIDOITAC='"+loai+"' and [TRANGTHAI] = 1";
            DataTable dtDoiTac = this.Read(sql);
            
            List<dtoDoiTac> lDtoDoiTac = new List<dtoDoiTac>();
            foreach (DataRow dr in dtDoiTac.Rows)
            {
                dtoDoiTac dtoDoiTac = new dtoDoiTac();
                dtoDoiTac.MADOITAC = Int32.Parse(dr[0].ToString());
                dtoDoiTac.MANHANVIEN = Int32.Parse(dr[1].ToString());
                dtoDoiTac.TENDOITAC = dr[2].ToString();
                dtoDoiTac.NGUOILIENHE = dr[3].ToString();
                dtoDoiTac.DIENTHOAI = dr[4].ToString();
                dtoDoiTac.DANHGIADOITAC = dr[5].ToString();
                dtoDoiTac.DIACHI = dr[6].ToString();
                dtoDoiTac.EMAIL = dr[7].ToString();
                dtoDoiTac.LOAIDOITAC = dr[8].ToString();
                lDtoDoiTac.Add(dtoDoiTac);
            }
            this.Close();
            return lDtoDoiTac;
        }

	}
}

