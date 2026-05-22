using qldsv.Class;
using System.Data;
using Dapper;

namespace qldsv.DAL
{
    class KhoaDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(
                @"SELECT MaKhoa, TenKhoa
                  FROM Khoa");
        }

        public static DataTable Search(string keyword)
        {
            return Functions.GetDataToTable(
                @"SELECT MaKhoa, TenKhoa
                  FROM Khoa
                  WHERE MaKhoa LIKE @kw OR TenKhoa LIKE @kw",
                new { kw = "%" + keyword + "%" });
        }

        public static bool KiemTraTrung(string maKhoa)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @ma",
                new { ma = maKhoa }) > 0;
        }

        public static bool TenKhoaExists(string tenKhoa, string excludeMaKhoa = null)
        {
            if (!string.IsNullOrEmpty(excludeMaKhoa))
            {
                int c = Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM Khoa WHERE TenKhoa = @ten AND MaKhoa <> @ma",
                    new { ten = tenKhoa, ma = excludeMaKhoa });
                return c > 0;
            }
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Khoa WHERE TenKhoa = @ten",
                new { ten = tenKhoa });
            return count > 0;
        }

        public static bool DangCoLienKet(string maKhoa)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM GiangVien WHERE MaKhoa = @ma",
                new { ma = maKhoa }) > 0;
        }

        public static void Them(string maKhoa, string tenKhoa)
        {
            Functions.Execute(
                "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@ma, @ten)",
                new { ma = maKhoa, ten = tenKhoa });
        }

        public static void Sua(string maKhoa, string tenKhoa)
        {
            Functions.Execute(
                "UPDATE Khoa SET TenKhoa = @ten WHERE MaKhoa = @ma",
                new { ma = maKhoa, ten = tenKhoa });
        }

        public static void Xoa(string maKhoa)
        {
            Functions.Execute(
                "DELETE FROM Khoa WHERE MaKhoa = @ma",
                new { ma = maKhoa });
        }
    }
}
