using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
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
            MessageBox.Show("tc","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        public static string MaHoaMD5(string matKhau)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(matKhau);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}