using ClosedXML.Excel;
using Dapper;
using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qldsv.Utils;

namespace qldsv.DAL
{
    class LopHocPhanDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(@"
                SELECT lhp.MaLHP,
                       mh.TenMon,
                       gv.HoTen,
                       hk.TenHocKy + ' - ' + hk.NamHoc AS TenHK,
                       lhp.NgayBatDau,
                       lhp.NgayKetThuc,
                       COUNT(dk.MaDangKy) AS SiSo
                FROM LopHocPhan lhp
                JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                JOIN GiangVien gv ON lhp.MaGiangVien = gv.MaGiangVien
                JOIN HocKy hk ON lhp.MaHocKy = hk.MaHocKy
                LEFT JOIN DangKyHP dk ON lhp.MaLHP = dk.MaLHP
                GROUP BY lhp.MaLHP, mh.TenMon, gv.HoTen,
                         hk.TenHocKy, hk.NamHoc,
                         lhp.NgayBatDau, lhp.NgayKetThuc
                ORDER BY lhp.MaLHP");
        }

        public static bool KiemTraTrung(string maLHP)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP }) > 0;
        }

        public static bool DangCoDangKy(string maLHP)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM DangKyHP WHERE MaLHP = @ma",
                new { ma = maLHP }) > 0;
        }

        public static void Them(string maLHP, string maMonHoc, string maGV,
            int maHocKy, DateTime ngayBD, DateTime ngayKT)
        {
            Functions.Execute(@"
                INSERT INTO LopHocPhan (MaLHP, MaMonHoc, MaGiangVien, MaHocKy, NgayBatDau, NgayKetThuc)
                VALUES (@maLHP, @maMH, @maGV, @maHK, @ngayBD, @ngayKT)",
                new { maLHP, maMH = maMonHoc, maGV, maHK = maHocKy, ngayBD, ngayKT });
        }

        public static void Sua(string maLHP, string maMonHoc, string maGV,
            int maHocKy, DateTime ngayBD, DateTime ngayKT)
        {
            Functions.Execute(@"
                UPDATE LopHocPhan
                SET MaMonHoc = @maMH, MaGiangVien = @maGV, MaHocKy = @maHK,
                    NgayBatDau = @ngayBD, NgayKetThuc = @ngayKT
                WHERE MaLHP = @maLHP",
                new { maLHP, maMH = maMonHoc, maGV, maHK = maHocKy, ngayBD, ngayKT });
        }

        public static void Xoa(string maLHP)
        {
            using (var tran = Functions.Conn.BeginTransaction())
            {
                try
                {
                    // Xóa Diem trước (FK Diem → DangKyHP)
                    Functions.Conn.Execute(@"
                        DELETE d FROM Diem d
                        JOIN DangKyHP dk ON d.MaDangKy = dk.MaDangKy
                        WHERE dk.MaLHP = @ma",
                        new { ma = maLHP }, tran);

                    // Xóa PhucKhao
                    Functions.Conn.Execute(@"
                        DELETE pk FROM PhucKhao pk
                        JOIN DangKyHP dk ON pk.MaDangKy = dk.MaDangKy
                        WHERE dk.MaLHP = @ma",
                        new { ma = maLHP }, tran);

                    // Xóa DangKyHP
                    Functions.Conn.Execute(
                        "DELETE FROM DangKyHP WHERE MaLHP = @ma",
                        new { ma = maLHP }, tran);

                    // Xóa LichHoc nếu có
                    Functions.Conn.Execute(
                        "DELETE FROM LichHoc WHERE MaLHP = @ma",
                        new { ma = maLHP }, tran);

                    // Xóa LopHocPhan
                    Functions.Conn.Execute(
                        "DELETE FROM LopHocPhan WHERE MaLHP = @ma",
                        new { ma = maLHP }, tran);

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // ─────────────────────────────────────────────
        // SINH VIÊN TRONG LHP
        // ─────────────────────────────────────────────

        public static DataTable GetSVTrongLHP(string maLHP)
        {
            return Functions.GetDataToTable(@"
                SELECT sv.MaSinhVien, sv.HoTen, l.TenLop, sv.Email
                FROM DangKyHP dk
                JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                JOIN Lop l ON sv.MaLop = l.MaLop
                WHERE dk.MaLHP = @ma
                ORDER BY sv.HoTen",
                new { ma = maLHP });
        }

        public static DataTable GetSVChuaDangKy(string maLHP)
        {
            return Functions.GetDataToTable(@"
                SELECT sv.MaSinhVien, sv.HoTen, l.TenLop, sv.Email
                FROM SinhVien sv
                JOIN Lop l ON sv.MaLop = l.MaLop
                WHERE sv.TrangThai = N'Đang Học'
                  AND sv.MaSinhVien NOT IN (
                      SELECT MaSinhVien FROM DangKyHP WHERE MaLHP = @ma)
                ORDER BY sv.HoTen",
                new { ma = maLHP });
        }

        public static bool DaSVTrongLHP(string maSV, string maLHP)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM DangKyHP WHERE MaSinhVien = @sv AND MaLHP = @lhp",
                new { sv = maSV, lhp = maLHP }) > 0;
        }

        public static void ThemSVVaoLHP(string maSV, string maLHP)
        {
            Functions.Execute(@"
                INSERT INTO DangKyHP (MaSinhVien, MaLHP, NgayDangKy)
                VALUES (@sv, @lhp, @ngay)",
                new { sv = maSV, lhp = maLHP, ngay = DateTime.Today });
        }

        public static bool DangCoDiem(string maSV, string maLHP)
        {
            return Functions.QuerySingle<int>(@"
                SELECT COUNT(*) FROM Diem d
                JOIN DangKyHP dk ON d.MaDangKy = dk.MaDangKy
                WHERE dk.MaSinhVien = @sv AND dk.MaLHP = @lhp",
                new { sv = maSV, lhp = maLHP }) > 0;
        }

        public static void XoaSVKhoiLHP(string maSV, string maLHP)
        {
            using (var tran = Functions.Conn.BeginTransaction())
            {
                try
                {
                    // Xóa Diem trước
                    Functions.Conn.Execute(@"
                        DELETE d FROM Diem d
                        JOIN DangKyHP dk ON d.MaDangKy = dk.MaDangKy
                        WHERE dk.MaSinhVien = @sv AND dk.MaLHP = @lhp",
                        new { sv = maSV, lhp = maLHP }, tran);

                    // Xóa DangKyHP
                    Functions.Conn.Execute(
                        "DELETE FROM DangKyHP WHERE MaSinhVien = @sv AND MaLHP = @lhp",
                        new { sv = maSV, lhp = maLHP }, tran);

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // ─────────────────────────────────────────────
        // IMPORT EXCEL
        // ─────────────────────────────────────────────

        public static List<ImportResult> ValidateImportExcel(string filePath, string maLHP)
        {
            var ketQua = new List<ImportResult>();

            using (var wb = new XLWorkbook(filePath))
            {
                var ws = wb.Worksheet(1);
                int stt = 1;

                // Bỏ qua hàng tiêu đề (hàng 1), đọc từ hàng 2
                foreach (var row in ws.RowsUsed())
                {
                    if (row.RowNumber() == 1) continue;

                    string maSV = row.Cell(1).GetString().Trim();
                    string hoTen = row.Cell(2).GetString().Trim();

                    var item = new ImportResult
                    {
                        STT = stt++,
                        MaSV = maSV,
                        HoTen = hoTen,
                        HopLe = true,
                        LyDoLoi = ""
                    };

                    if (string.IsNullOrEmpty(maSV))
                    {
                        item.HopLe = false;
                        item.LyDoLoi = "MSSV trống";
                    }
                    else if (Functions.QuerySingle<int>(
                        "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @ma",
                        new { ma = maSV }) == 0)
                    {
                        item.HopLe = false;
                        item.LyDoLoi = "MSSV không tồn tại trong hệ thống";
                    }
                    else if (DaSVTrongLHP(maSV, maLHP))
                    {
                        item.HopLe = false;
                        item.LyDoLoi = "Sinh viên đã có trong lớp học phần";
                    }

                    ketQua.Add(item);
                }
            }

            return ketQua;
        }

        public static void ThemNhieuSVVaoLHP(List<string> dsMaSV, string maLHP)
        {
            using (var tran = Functions.Conn.BeginTransaction())
            {
                try
                {
                    foreach (string maSV in dsMaSV)
                    {
                        Functions.Conn.Execute(@"
                            INSERT INTO DangKyHP (MaSinhVien, MaLHP, NgayDangKy)
                            VALUES (@sv, @lhp, @ngay)",
                            new { sv = maSV, lhp = maLHP, ngay = DateTime.Today }, tran);
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
