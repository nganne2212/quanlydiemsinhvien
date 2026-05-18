using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class LopDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(
                @"SELECT l.MaLop, l.TenLop,
                         k.TenKhoa,
                         gv.HoTen AS CoVanHocTap
                  FROM Lop l
                  JOIN Khoa      k  ON l.MaKhoa      = k.MaKhoa
                  JOIN GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                  ORDER BY l.MaLop");
        }

        // Tìm theo mã lớp hoặc tên lớp
        public static DataTable Search(string keyword)
        {
            return Functions.GetDataToTable(
                @"SELECT l.MaLop, l.TenLop,
                         k.TenKhoa,
                         gv.HoTen AS CoVanHocTap
                  FROM Lop l
                  JOIN Khoa      k  ON l.MaKhoa      = k.MaKhoa
                  JOIN GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                  WHERE l.MaLop  LIKE @kw
                     OR l.TenLop LIKE @kw
                  ORDER BY l.MaLop",
                new { kw = "%" + keyword + "%" });
        }

        // Lọc theo Khoa
        public static DataTable SearchByKhoa(string keyword, string maKhoa)
        {
            return Functions.GetDataToTable(
                @"SELECT l.MaLop, l.TenLop,
                         k.TenKhoa,
                         gv.HoTen AS CoVanHocTap
                  FROM Lop l
                  JOIN Khoa      k  ON l.MaKhoa      = k.MaKhoa
                  JOIN GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                  WHERE l.MaKhoa = @khoa
                    AND (l.MaLop  LIKE @kw OR l.TenLop LIKE @kw)
                  ORDER BY l.MaLop",
                new { khoa = maKhoa, kw = "%" + keyword + "%" });
        }

        // Load ComboBox Khoa
        public static DataTable GetAllKhoa()
        {
            return Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
        }

        // Load ComboBox CVHT (GiangVien) theo Khoa
        public static DataTable GetGiangVienByKhoa(string maKhoa)
        {
            return Functions.GetDataToTable(
                @"SELECT MaGiangVien, HoTen
                  FROM GiangVien
                  WHERE MaKhoa = @ma
                  ORDER BY HoTen",
                new { ma = maKhoa });
        }

        public static bool KiemTraTrung(string maLop)
        {
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Lop WHERE MaLop = @ma",
                new { ma = maLop });
            return count > 0;
        }

        public static bool DangCoDanhSinhVien(string maLop)
        {
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM SinhVien WHERE MaLop = @ma",
                new { ma = maLop });
            return count > 0;
        }

        public static void Add(string maLop, string tenLop,
                               string maKhoa, string maGiangVien)
        {
            Functions.Execute(
                @"INSERT INTO Lop (MaLop, TenLop, MaKhoa, MaGiangVien)
                  VALUES (@ma, @ten, @khoa, @gv)",
                new
                {
                    ma = maLop,
                    ten = tenLop,
                    khoa = maKhoa,
                    gv = maGiangVien
                });
        }

        public static void Update(string maLop, string tenLop,
                                  string maKhoa, string maGiangVien)
        {
            Functions.Execute(
                @"UPDATE Lop
                  SET TenLop = @ten, MaKhoa = @khoa, MaGiangVien = @gv
                  WHERE MaLop = @ma",
                new
                {
                    ten = tenLop,
                    khoa = maKhoa,
                    gv = maGiangVien,
                    ma = maLop
                });
        }

        public static void Delete(string maLop)
        {
            Functions.Execute(
                "DELETE FROM Lop WHERE MaLop = @ma",
                new { ma = maLop });
        }
    }
}