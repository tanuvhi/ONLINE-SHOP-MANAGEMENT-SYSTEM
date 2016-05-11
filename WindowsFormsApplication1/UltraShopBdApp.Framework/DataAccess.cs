using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace UltraShopBd.FrameWork
{
    public class DataAccess
    {
        const String connectionString = "Data Source=;Initial Catalog=ultrashopbd;Persist Security Info=True;User ID=;Password=";
        public DataTable GetData(SqlCommand cmd)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            cmd.Connection = connection;
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Connection.Close();

            return dt;
        }
        public bool Execute(SqlCommand cmd)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            cmd.Connection = connection;
            connection.Open();
            int value = cmd.ExecuteNonQuery();
            connection.Close();

            return value > 0;
        }

    }
}
