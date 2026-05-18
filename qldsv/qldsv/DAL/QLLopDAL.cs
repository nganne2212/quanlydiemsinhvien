using qldsv.Class;
using System;
using System.Data;

namespace qldsv.DAL
{
    public class LopDTO
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string MaGiangVien { get; set; }
        public string HoTenGV { get; set; }
        public int SiSo { get; set; }
    }

    public static class QLLopDAL
    {
        public static DataTable GetAllLop()
        {
            string sql = @"
                SELECT ROW_NUMBER() OVER (ORDER BY l.MaLop) AS STT,
                       l.MaLop, l.TenLop, k.TenKhoa,
                       gv.HoTen AS CoVanHocTap,
                       COUNT(sv.MaSinhVien) AS SiSo
                FROM Lop l
                JOIN      Khoa      k  ON l.MaKhoa     = k.MaKhoa
                JOIN      GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                LEFT JOIN SinhVien  sv ON l.MaLop       = sv.MaLop
                GROUP BY l.MaLop, l.TenLop, k.TenKhoa, gv.HoTen
                ORDER BY l.MaLop";

            Functions.Connect();
            DataTable dt = Functions.GetDataToTable(sql);
            Functions.Disconnect();
            return dt;
        }

        public static LopDTO GetLopByMa(string maLop)
        {
            string sql = @"
                SELECT l.MaLop, l.TenLop, l.MaKhoa, k.TenKhoa,
                       l.MaGiangVien, gv.HoTen AS HoTenGV
                FROM   Lop l
                JOIN   Khoa      k  ON l.MaKhoa     = k.MaKhoa
                JOIN   GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                WHERE  l.MaLop = @MaLop";

            Functions.Connect();
            LopDTO lop = Functions.QuerySingle<LopDTO>(sql, new { MaLop = maLop });
            Functions.Disconnect();
            return lop;
        }

        public static bool KiemTraTrung(string maLop)
        {
            Functions.Connect();
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop",
                new { MaLop = maLop });
            Functions.Disconnect();
            return count > 0;
        }

        public static bool DangCoDanhSinhVien(string maLop)
        {
            Functions.Connect();
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM SinhVien WHERE MaLop = @MaLop",
                new { MaLop = maLop });
            Functions.Disconnect();
            return count > 0;
        }

        public static void Them(LopDTO lop)
        {
            string sql = @"INSERT INTO Lop (MaLop, TenLop, MaKhoa, MaGiangVien)
                           VALUES (@MaLop, @TenLop, @MaKhoa, @MaGiangVien)";
            Functions.Connect();
            Functions.Execute(sql, new { lop.MaLop, lop.TenLop, lop.MaKhoa, lop.MaGiangVien });
            Functions.Disconnect();
        }

        public static void Sua(LopDTO lop)
        {
            string sql = @"UPDATE Lop
                           SET TenLop = @TenLop, MaKhoa = @MaKhoa, MaGiangVien = @MaGiangVien
                           WHERE MaLop = @MaLop";
            Functions.Connect();
            Functions.Execute(sql, new { lop.TenLop, lop.MaKhoa, lop.MaGiangVien, lop.MaLop });
            Functions.Disconnect();
        }

        public static void Xoa(string maLop)
        {
            Functions.Connect();
            Functions.Execute("DELETE FROM Lop WHERE MaLop = @MaLop", new { MaLop = maLop });
            Functions.Disconnect();
        }

        public static DataTable GetAllKhoa()
        {
            Functions.Connect();
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
            Functions.Disconnect();
            return dt;
        }

        public static DataTable GetGiangVienTheoKhoa(string maKhoa)
        {
            Functions.Connect();
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaGiangVien, HoTen FROM GiangVien WHERE MaKhoa = @MaKhoa ORDER BY HoTen",
                new { MaKhoa = maKhoa });
            Functions.Disconnect();
            return dt;
        }
    }
}