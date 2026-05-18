using System;
using System.Collections.Generic;
using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class KhoaDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY MaKhoa");
        }

        public static DataTable Search(string keyword)
        {
            return Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa WHERE MaKhoa LIKE @search OR TenKhoa LIKE @search ORDER BY MaKhoa",
                new { search = "%" + keyword + "%" });
        }

        public static bool ThemKhoa(string maKhoa, string tenKhoa)
        {
            try
            {
                Functions.Execute(
                    "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@ma, @ten)",
                    new { ma = maKhoa, ten = tenKhoa });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SuaKhoa(string maKhoa, string tenKhoa)
        {
            try
            {
                Functions.Execute(
                    "UPDATE Khoa SET TenKhoa = @ten WHERE MaKhoa = @ma",
                    new { ma = maKhoa, ten = tenKhoa });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaKhoa(string maKhoa)
        {
            try
            {
                Functions.Execute(
                    "DELETE FROM Khoa WHERE MaKhoa = @ma",
                    new { ma = maKhoa });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool KhoaExists(string maKhoa)
        {
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @ma",
                new { ma = maKhoa });
            return count > 0;
        }
    }
}
