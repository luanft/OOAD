using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{


    class Connection
    {        
        string strConnection;
        SqlConnection _con;        
        public Connection() {
            Init();
        }        

        private void Init()
        {
            try
            {
                strConnection = @"Data Source=" + Config.server + "; Initial Catalog="+Config.database+";Integrated Security=True";
                _con = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                _con = null;
            }            
        }

        public SqlConnection Open()
        {
            if (_con != null)
            {
                if (_con.State != System.Data.ConnectionState.Open)
                {
                    _con.Open();
                }
            }
            return _con;
        }

        private SqlConnection Close()
        {
            if (_con.State != System.Data.ConnectionState.Closed)
            {
                _con.Close();
            }
            return _con;
        }
        //ghi xuống database
        public DataTable Read(string query)
        {            
            DataTable data_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
            adapter.Fill(data_table);
            adapter.Dispose();
            return data_table;
        }

        //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"data.txt", true))
        //{
        //    file.WriteLine(sql_query);
        //}

        public bool Write(string query)
        {
            try
            {
                SqlCommand sql_cmd = new SqlCommand(query, this._con);
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Dispose();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
