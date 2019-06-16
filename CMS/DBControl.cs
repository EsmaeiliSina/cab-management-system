using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CMS
{
    class DBControl
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;

        public DBControl()
        {
            con = new SqlConnection();
            com = new SqlCommand();
            da = new SqlDataAdapter();
            com.Connection = con;
            da.SelectCommand = com;
        }
        public void Connect()
        {
            string strcs = @"Data Source=.;Initial Catalog=TaxiDB;Integrated Security=True";
            con.ConnectionString = strcs;
            con.Open();
        }

        public void Disconnect()
        {
            con.Close();
        }

        public DataTable Select(string strct)
        {
            DataTable dt = new DataTable();
            com.CommandText = strct;
            da.Fill(dt);
            return dt;
        }

        public void DoCommand(string strct)
        {
            com.CommandText = strct;
            com.ExecuteNonQuery();
        }
    }
}
