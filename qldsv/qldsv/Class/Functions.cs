using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Text;
using System.Windows.Forms;
using Dapper;

namespace qldsv.Class
{
    class Functions
    {
        public static SqlConnection Conn;
        public static string connString = ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString;

        public static void Connect()
        {
            Conn = new SqlConnection(connString);
            Conn.Open();
            //MessageBox.Show("tc","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static void Disconnect()
        {
            if (Conn != null && Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static T QuerySingle<T>(string sql, object param = null)
        {
            return Conn.QueryFirstOrDefault<T>(sql, param);
        }

        public static IEnumerable<T> QueryList<T>(string sql, object param = null)
        {
            return Conn.Query<T>(sql, param);
        }

        public static int Execute(string sql, object param = null)
        {
            return Conn.Execute(sql, param);
        }


    }
}