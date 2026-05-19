using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class HocKyDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(
                "SELECT MaHocKy, TenHocKy, NamHoc, TrangThai FROM HocKy ORDER BY MaHocKy DESC");
        }

        public static bool KiemTraTrung(string tenHocKy, string namHoc, int maHocKy = 0)
        {
            int count = Functions.QuerySingle<int>(
                @"SELECT COUNT(*) FROM HocKy 
                  WHERE TenHocKy = @TenHocKy AND NamHoc = @NamHoc AND MaHocKy <> @MaHocKy",
                new { TenHocKy = tenHocKy, NamHoc = namHoc, MaHocKy = maHocKy });
            return count > 0;
        }

        public static bool DangDuocDung(int maHocKy)
        {
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM LopHocPhan WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });
            return count > 0;
        }

        public static string GetTrangThai(int maHocKy)
        {
            return Functions.QuerySingle<string>(
                "SELECT TrangThai FROM HocKy WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });
        }

        public static void Them(string tenHocKy, string namHoc)
        {
            Functions.Execute(
                "INSERT INTO HocKy (TenHocKy, NamHoc, TrangThai) VALUES (@TenHocKy, @NamHoc, 'ChuaMo')",
                new { TenHocKy = tenHocKy, NamHoc = namHoc });
        }

        public static void Sua(int maHocKy, string tenHocKy, string namHoc)
        {
            Functions.Execute(
                "UPDATE HocKy SET TenHocKy = @TenHocKy, NamHoc = @NamHoc WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy, TenHocKy = tenHocKy, NamHoc = namHoc });
        }

        public static void Xoa(int maHocKy)
        {
            Functions.Execute(
                "DELETE FROM HocKy WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });
        }

        public static void MoHocKy(int maHocKy)
        {
            Functions.Execute(
                "UPDATE HocKy SET TrangThai = 'ChuaMo' WHERE TrangThai = 'DangDienRa'");
            Functions.Execute(
                "UPDATE HocKy SET TrangThai = 'DangDienRa' WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });
        }

        public static void DongHocKy(int maHocKy)
        {
            Functions.Execute(
                "UPDATE HocKy SET TrangThai = 'DaKetThuc' WHERE MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });
        }
    }
}