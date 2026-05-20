using System;
using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    public class QLLichHocDAL
    {
        // ── GetAll: JOIN để lấy tên môn, tên GV, tên phòng, tên thứ/ca ──
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(@"
                SELECT 
                    lh.MaLHP,
                    mh.TenMon        AS TenMonHoc,
                    gv.HoTen         AS TenGiangVien,
                    ph.TenPhong      AS TenPhong,
                    N'Thứ ' + CAST(lh.Thu    AS nvarchar) AS TenThu,
                    N'Ca '  + CAST(lh.CaHoc  AS nvarchar) AS TenCa,
                    lh.Thu,
                    lh.CaHoc,
                    lh.MaPhong
                FROM LichHoc lh
                JOIN LopHocPhan lhp ON lh.MaLHP       = lhp.MaLHP
                JOIN MonHoc     mh  ON lhp.MaMonHoc   = mh.MaMonHoc
                JOIN GiangVien  gv  ON lhp.MaGiangVien = gv.MaGiangVien
                JOIN PhongHoc   ph  ON lh.MaPhong     = ph.MaPhong
                ORDER BY lh.MaLHP, lh.Thu, lh.CaHoc");
        }

        // ── Search theo từ khóa ──────────────────────────────────────────
        public static DataTable Search(string keyword)
        {
            return Functions.GetDataToTable(@"
                SELECT 
                    lh.MaLHP,
                    mh.TenMon        AS TenMonHoc,
                    gv.HoTen         AS TenGiangVien,
                    ph.TenPhong      AS TenPhong,
                    N'Thứ ' + CAST(lh.Thu    AS nvarchar) AS TenThu,
                    N'Ca '  + CAST(lh.CaHoc  AS nvarchar) AS TenCa,
                    lh.Thu,
                    lh.CaHoc,
                    lh.MaPhong
                FROM LichHoc lh
                JOIN LopHocPhan lhp ON lh.MaLHP       = lhp.MaLHP
                JOIN MonHoc     mh  ON lhp.MaMonHoc   = mh.MaMonHoc
                JOIN GiangVien  gv  ON lhp.MaGiangVien = gv.MaGiangVien
                JOIN PhongHoc   ph  ON lh.MaPhong     = ph.MaPhong
                WHERE mh.TenMon   LIKE @kw
                   OR ph.TenPhong LIKE @kw
                   OR lh.MaLHP    LIKE @kw
                ORDER BY lh.MaLHP, lh.Thu, lh.CaHoc",
                new { kw = "%" + keyword + "%" });
        }

        // ── GetAllLopHocPhan: cho ComboBox ───────────────────────────────
        public static DataTable GetAllLopHocPhan()
        {
            return Functions.GetDataToTable(@"
                SELECT lhp.MaLHP,
                       mh.TenMon + N' (' + lhp.MaLHP + ')' AS TenHienThi
                FROM LopHocPhan lhp
                JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                ORDER BY lhp.MaLHP");
        }

        // ── GetAllPhongHoc: cho ComboBox ─────────────────────────────────
        public static DataTable GetAllPhongHoc()
        {
            return Functions.GetDataToTable(
                "SELECT MaPhong, TenPhong FROM PhongHoc ORDER BY TenPhong");
        }

        // ── Kiểm tra phòng+thứ+ca đã tồn tại chưa ──────────────────────
        public static bool PhongThuCaExists(int maPhong, int thu, int caHoc,
                                             string excludeMaLHP = null,
                                             int excludeThu = 0, int excludeCa = 0)
        {
            if (excludeMaLHP != null)
            {
                int c = Functions.QuerySingle<int>(@"
                    SELECT COUNT(1) FROM LichHoc
                    WHERE MaPhong = @ma AND Thu = @thu AND CaHoc = @ca
                      AND NOT (MaLHP = @lhp AND Thu = @thuCu AND CaHoc = @caCu)",
                    new
                    {
                        ma = maPhong,
                        thu,
                        ca = caHoc,
                        lhp = excludeMaLHP,
                        thuCu = excludeThu,
                        caCu = excludeCa
                    });
                return c > 0;
            }
            int count = Functions.QuerySingle<int>(@"
                SELECT COUNT(1) FROM LichHoc
                WHERE MaPhong = @ma AND Thu = @thu AND CaHoc = @ca",
                new { ma = maPhong, thu, ca = caHoc });
            return count > 0;
        }

        // ── Kiểm tra MaLHP+thứ+ca đã tồn tại chưa ──────────────────────
        public static bool LhpThuCaExists(string maLHP, int thu, int caHoc)
        {
            int c = Functions.QuerySingle<int>(@"
                SELECT COUNT(1) FROM LichHoc
                WHERE MaLHP = @lhp AND Thu = @thu AND CaHoc = @ca",
                new { lhp = maLHP, thu, ca = caHoc });
            return c > 0;
        }

        // ── Kiểm tra LHP đã có SV đăng ký chưa ──────────────────────────
        public static int SoSVDangKy(string maLHP)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(1) FROM DangKyHP WHERE MaLHP = @lhp",
                new { lhp = maLHP });
        }

        // ── Kiểm tra LHP đã kết thúc chưa ───────────────────────────────
        public static DateTime? GetNgayKetThuc(string maLHP)
        {
            object obj = Functions.QuerySingle<object>(
                "SELECT NgayKetThuc FROM LopHocPhan WHERE MaLHP = @lhp",
                new { lhp = maLHP });
            if (obj == null || obj == DBNull.Value) return null;
            return Convert.ToDateTime(obj);
        }

        // ── Add ──────────────────────────────────────────────────────────
        public static void Add(string maLHP, int maPhong, int thu, int caHoc)
        {
            Functions.Execute(
                "INSERT INTO LichHoc (MaLHP, MaPhong, Thu, CaHoc) VALUES (@lhp, @ma, @thu, @ca)",
                new { lhp = maLHP, ma = maPhong, thu, ca = caHoc });
        }

        // ── Update: DELETE + INSERT vì PK composite ──────────────────────
        public static void Update(string maLHP, int thuCu, int caHocCu,
                                   int maPhongMoi, int thuMoi, int caHocMoi)
        {
            Functions.Execute(@"
                DELETE FROM LichHoc
                WHERE MaLHP = @lhp AND Thu = @thuCu AND CaHoc = @caCu",
                new { lhp = maLHP, thuCu, caCu = caHocCu });

            Functions.Execute(
                "INSERT INTO LichHoc (MaLHP, MaPhong, Thu, CaHoc) VALUES (@lhp, @ma, @thu, @ca)",
                new { lhp = maLHP, ma = maPhongMoi, thu = thuMoi, ca = caHocMoi });
        }

        // ── Delete ───────────────────────────────────────────────────────
        public static void Delete(string maLHP, int thu, int caHoc)
        {
            Functions.Execute(@"
                DELETE FROM LichHoc
                WHERE MaLHP = @lhp AND Thu = @thu AND CaHoc = @ca",
                new { lhp = maLHP, thu, ca = caHoc });
        }
    }
}