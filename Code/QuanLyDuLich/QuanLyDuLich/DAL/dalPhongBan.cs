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
    using DataTranferObject;
	public class dalPhongBan : dalObject
	{
        public bool ThemPhong(dtoPhongBan phongban)
        {
            if(!this.Connect())
            {                
                return false;
            }
            string sql = "INSERT INTO [dbo].[PHONGBAN] ([TENPHONG]) VALUES "+phongban.TENPHONG;
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }
        public bool XoaPhong(dtoPhongBan phongban)
        {
          if(!this.Connect())
            {
                return false;
            }
            string sql = "DELETE FROM [dbo].[PHONGBAN] WHERE [MAPHONG]='"+phongban.MAPHONG+"'";
            bool ok = this.Write(sql);
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }
        public bool SuaThongTinPhong(dtoPhongBan phongban)
        {
            if (!this.Connect())
            {
                return false;
            }            
            string sql = "UPDATE [dbo].[PHONGBAN] SET [TENPHONG] = " +phongban.TENPHONG +" WHERE [MAPHONG] ="+phongban.MAPHONG;
            bool ok = this.Write(sql);
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;    
        }
        public List<dtoPhongBan> LayDanhSachPhong()
        {
            if (!this.Connect())
            {
                MessageBox.Show("Có lỗi trong quá trình kết nối với cơ sở dữ liệu");
                return null;
            }
            else
            {
                string sql = "SELECT [MAPHONG],[TENPHONG] FROM [dbo].[PHONGBAN]";
                DataTable dtPhongBan = this.Read(sql);
                this.Close();
                
                List<dtoPhongBan> lDtoPhongBan = new List<dtoPhongBan>();
                foreach (DataRow dr in dtPhongBan.Rows)
                {
                    dtoPhongBan dto_PhongBan = new dtoPhongBan();
                    dto_PhongBan.MAPHONG = Int32.Parse(dr[0].ToString());
                    dto_PhongBan.TENPHONG = dr[1].ToString();
                    lDtoPhongBan.Add(dto_PhongBan);
                }
                return lDtoPhongBan;
            }
           
            

         
        }
	}
}

