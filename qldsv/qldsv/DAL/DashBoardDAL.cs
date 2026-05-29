using qldsv.Class;
using System.Data;

namespace qldsv.DAL
{
    internal class DashBoardDAL
    {
        // ── Tab 1: Tổng quan ────────────────────────────────────────────────

        public static DataRow GetTongQuan(int maHocKy, string maKhoa, string maLop)
        {
            DataTable dt = Functions.GetDataToTable(@"
        SELECT
            COUNT(DISTINCT dk.MaSinhVien) AS TongSinhVien,
            (SELECT COUNT(DISTINCT cb.MaSinhVien)
             FROM CanhBaoHocVu cb
             INNER JOIN SinhVien sv2 ON cb.MaSinhVien = sv2.MaSinhVien
             INNER JOIN Lop l2 ON sv2.MaLop = l2.MaLop
             WHERE cb.MaHocKy = @maHocKy
               AND (@maKhoa IS NULL OR @maKhoa = '' OR l2.MaKhoa = @maKhoa)
               AND (@maLop  IS NULL OR @maLop  = '' OR sv2.MaLop = @maLop)
            ) AS SoCanhBao,
            ISNULL(ROUND(
                100.0 * SUM(CASE WHEN d.TongKet >= 5 THEN 1 ELSE 0 END)
                      / NULLIF(COUNT(d.MaDiem), 0)
            , 1), 0) AS TyLeDau,
            ISNULL(ROUND(
                100.0 * SUM(CASE WHEN d.TongKet < 5 THEN 1 ELSE 0 END)
                      / NULLIF(COUNT(d.MaDiem), 0)
            , 1), 0) AS TyLeRot
        FROM LopHocPhan lhp
        INNER JOIN MonHoc   mh ON lhp.MaMonHoc  = mh.MaMonHoc
        INNER JOIN DangKyHP dk ON lhp.MaLHP     = dk.MaLHP
        INNER JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
        INNER JOIN Lop       l ON sv.MaLop      = l.MaLop
        LEFT  JOIN Diem      d ON dk.MaDangKy   = d.MaDangKy
                              AND d.TrangThai = N'DaXacNhan'
        WHERE lhp.MaHocKy = @maHocKy
          AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
          AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)",
                new { maHocKy, maKhoa, maLop });
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static DataTable GetDiemTBTheoHocKy(string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    hk.TenHocKy + ' ' + hk.NamHoc AS TenHK,
                    ISNULL(ROUND(
                        SUM(d.TongKet * mh.SoTinChi) / NULLIF(SUM(mh.SoTinChi), 0)
                    , 2), 0) AS DiemTB
                FROM HocKy hk
                INNER JOIN LopHocPhan lhp ON lhp.MaHocKy   = hk.MaHocKy
                INNER JOIN MonHoc     mh  ON lhp.MaMonHoc  = mh.MaMonHoc
                INNER JOIN DangKyHP   dk  ON lhp.MaLHP     = dk.MaLHP
                INNER JOIN SinhVien   sv  ON dk.MaSinhVien = sv.MaSinhVien
                INNER JOIN Lop         l  ON sv.MaLop      = l.MaLop
                INNER JOIN Diem        d  ON dk.MaDangKy   = d.MaDangKy
                                         AND d.TrangThai = N'DaXacNhan'
                WHERE (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                  AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                GROUP BY hk.MaHocKy, hk.TenHocKy, hk.NamHoc
                ORDER BY hk.MaHocKy",
                new { maKhoa, maLop });
        }

        // ── Tab 2: Học lực ──────────────────────────────────────────────────

        public static DataTable GetPhanBoHocLuc(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    CASE
                        WHEN avg_diem >= 9.0 THEN N'Xuất sắc'
                        WHEN avg_diem >= 8.0 THEN N'Giỏi'
                        WHEN avg_diem >= 7.0 THEN N'Khá'
                        WHEN avg_diem >= 5.0 THEN N'Trung bình'
                        ELSE N'Yếu/Kém'
                    END      AS HocLuc,
                    COUNT(*) AS SoLuong
                FROM (
                    SELECT
                        sv.MaSinhVien,
                        ROUND(
                            SUM(d.TongKet * mh.SoTinChi) / NULLIF(SUM(mh.SoTinChi), 0)
                        , 2) AS avg_diem
                    FROM DangKyHP   dk
                    INNER JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                    INNER JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                    INNER JOIN SinhVien   sv  ON dk.MaSinhVien = sv.MaSinhVien
                    INNER JOIN Lop         l  ON sv.MaLop     = l.MaLop
                    INNER JOIN Diem        d  ON dk.MaDangKy  = d.MaDangKy
                                             AND d.TrangThai = N'DaXacNhan'
                    WHERE lhp.MaHocKy = @maHocKy
                      AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                      AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                    GROUP BY sv.MaSinhVien
                ) AS sub
                GROUP BY
                    CASE
                        WHEN avg_diem >= 9.0 THEN N'Xuất sắc'
                        WHEN avg_diem >= 8.0 THEN N'Giỏi'
                        WHEN avg_diem >= 7.0 THEN N'Khá'
                        WHEN avg_diem >= 5.0 THEN N'Trung bình'
                        ELSE N'Yếu/Kém'
                    END
                ORDER BY MIN(avg_diem) DESC",
                new { maHocKy, maKhoa, maLop });
        }

        public static DataTable GetHocLucTheoKhoa(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    k.TenKhoa                                                             AS N'Khoa',
                    COUNT(DISTINCT sub.MaSinhVien)                                        AS N'Tổng SV',
                    SUM(CASE WHEN avg_diem >= 9.0 THEN 1 ELSE 0 END)                     AS N'Xuất sắc',
                    SUM(CASE WHEN avg_diem >= 8.0 AND avg_diem < 9.0 THEN 1 ELSE 0 END)  AS N'Giỏi',
                    SUM(CASE WHEN avg_diem >= 7.0 AND avg_diem < 8.0 THEN 1 ELSE 0 END)  AS N'Khá',
                    SUM(CASE WHEN avg_diem >= 5.0 AND avg_diem < 7.0 THEN 1 ELSE 0 END)  AS N'Trung bình',
                    SUM(CASE WHEN avg_diem < 5.0 THEN 1 ELSE 0 END)                      AS N'Yếu/Kém'
                FROM (
                    SELECT
                        sv.MaSinhVien,
                        l.MaKhoa,
                        ROUND(
                            SUM(d.TongKet * mh.SoTinChi) / NULLIF(SUM(mh.SoTinChi), 0)
                        , 2) AS avg_diem
                    FROM DangKyHP   dk
                    INNER JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                    INNER JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                    INNER JOIN SinhVien   sv  ON dk.MaSinhVien = sv.MaSinhVien
                    INNER JOIN Lop         l  ON sv.MaLop     = l.MaLop
                    INNER JOIN Diem        d  ON dk.MaDangKy  = d.MaDangKy
                                             AND d.TrangThai = N'DaXacNhan'
                    WHERE lhp.MaHocKy = @maHocKy
                      AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                      AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                    GROUP BY sv.MaSinhVien, l.MaKhoa
                ) AS sub
                INNER JOIN Khoa k ON sub.MaKhoa = k.MaKhoa
                GROUP BY k.TenKhoa
                ORDER BY k.TenKhoa",
                new { maHocKy, maKhoa, maLop });
        }

        // ── Tab 3: Môn học ──────────────────────────────────────────────────

        public static DataTable GetTop10MonTruot(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT TOP 10
                    mh.TenMon                                                       AS N'Môn học',
                    COUNT(d.MaDiem)                                                 AS N'Tổng SV',
                    SUM(CASE WHEN d.TongKet < 5 THEN 1 ELSE 0 END)                 AS N'Số trượt',
                    ROUND(
                        100.0 * SUM(CASE WHEN d.TongKet < 5 THEN 1 ELSE 0 END)
                              / NULLIF(COUNT(d.MaDiem), 0)
                    , 1)                                                            AS TyLeTruot
                FROM LopHocPhan lhp
                INNER JOIN MonHoc   mh ON lhp.MaMonHoc  = mh.MaMonHoc
                INNER JOIN DangKyHP dk ON lhp.MaLHP     = dk.MaLHP
                INNER JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                INNER JOIN Lop       l ON sv.MaLop      = l.MaLop
                INNER JOIN Diem      d ON dk.MaDangKy   = d.MaDangKy
                                      AND d.TrangThai = N'DaXacNhan'
                WHERE lhp.MaHocKy = @maHocKy
                  AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                  AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                GROUP BY mh.MaMonHoc, mh.TenMon
                HAVING COUNT(d.MaDiem) > 0
                ORDER BY TyLeTruot DESC",
                new { maHocKy, maKhoa, maLop });
        }

        public static DataTable GetHocLaiTheoMon(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    mh.TenMon                                                     AS N'Môn học',
                    mh.SoTinChi                                                   AS N'Tín chỉ',
                    COUNT(dk.MaDangKy)                                            AS N'Tổng đăng ký',
                    SUM(CASE WHEN d.LoaiHoc = N'HocLai'   THEN 1 ELSE 0 END)     AS N'Học lại',
                    SUM(CASE WHEN d.LoaiHoc = N'CaiThien' THEN 1 ELSE 0 END)     AS N'Cải thiện',
                    SUM(CASE WHEN d.LoaiHoc = N'LanDau'   THEN 1 ELSE 0 END)     AS N'Lần đầu'
                FROM LopHocPhan lhp
                INNER JOIN MonHoc   mh ON lhp.MaMonHoc  = mh.MaMonHoc
                INNER JOIN DangKyHP dk ON lhp.MaLHP     = dk.MaLHP
                INNER JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                INNER JOIN Lop       l ON sv.MaLop      = l.MaLop
                LEFT  JOIN Diem      d ON dk.MaDangKy   = d.MaDangKy
                WHERE lhp.MaHocKy = @maHocKy
                  AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                  AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                GROUP BY mh.MaMonHoc, mh.TenMon, mh.SoTinChi
                ORDER BY mh.TenMon",
                new { maHocKy, maKhoa, maLop });
        }

        // ── Tab 4: Thống kê điểm ────────────────────────────────────────────

        public static DataTable GetThongKeThangDiem(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    CASE
                        WHEN d.TongKet >= 9.5 THEN 'A+'
                        WHEN d.TongKet >= 8.5 THEN 'A'
                        WHEN d.TongKet >= 8.0 THEN 'B+'
                        WHEN d.TongKet >= 7.0 THEN 'B'
                        WHEN d.TongKet >= 6.5 THEN 'C+'
                        WHEN d.TongKet >= 5.5 THEN 'C'
                        WHEN d.TongKet >= 5.0 THEN 'D+'
                        WHEN d.TongKet >= 4.0 THEN 'D'
                        ELSE 'F'
                    END          AS N'Điểm chữ',
                    COUNT(*)     AS N'Số lượng',
                    ROUND(
                        100.0 * COUNT(*) / NULLIF(SUM(COUNT(*)) OVER(), 0)
                    , 1)         AS N'Tỉ lệ (%)'
                FROM LopHocPhan lhp
                INNER JOIN DangKyHP dk ON lhp.MaLHP     = dk.MaLHP
                INNER JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                INNER JOIN Lop       l ON sv.MaLop      = l.MaLop
                INNER JOIN Diem      d ON dk.MaDangKy   = d.MaDangKy
                                      AND d.TrangThai = N'DaXacNhan'
                WHERE lhp.MaHocKy = @maHocKy
                  AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                  AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                GROUP BY
                    CASE
                        WHEN d.TongKet >= 9.5 THEN 'A+'
                        WHEN d.TongKet >= 8.5 THEN 'A'
                        WHEN d.TongKet >= 8.0 THEN 'B+'
                        WHEN d.TongKet >= 7.0 THEN 'B'
                        WHEN d.TongKet >= 6.5 THEN 'C+'
                        WHEN d.TongKet >= 5.5 THEN 'C'
                        WHEN d.TongKet >= 5.0 THEN 'D+'
                        WHEN d.TongKet >= 4.0 THEN 'D'
                        ELSE 'F'
                    END
                ORDER BY MIN(d.TongKet) DESC",
                new { maHocKy, maKhoa, maLop });
        }

        public static DataTable GetPhanBoDiemThang10(int maHocKy, string maKhoa, string maLop)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    CASE
                        WHEN d.TongKet >= 9 THEN '9-10'
                        WHEN d.TongKet >= 8 THEN '8-9'
                        WHEN d.TongKet >= 7 THEN '7-8'
                        WHEN d.TongKet >= 6 THEN '6-7'
                        WHEN d.TongKet >= 5 THEN '5-6'
                        WHEN d.TongKet >= 4 THEN '4-5'
                        WHEN d.TongKet >= 3 THEN '3-4'
                        WHEN d.TongKet >= 2 THEN '2-3'
                        WHEN d.TongKet >= 1 THEN '1-2'
                        ELSE '0-1'
                    END      AS KhoangDiem,
                    COUNT(*) AS SoSinhVien
                FROM LopHocPhan lhp
                INNER JOIN DangKyHP dk ON lhp.MaLHP     = dk.MaLHP
                INNER JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                INNER JOIN Lop       l ON sv.MaLop      = l.MaLop
                INNER JOIN Diem      d ON dk.MaDangKy   = d.MaDangKy
                                      AND d.TrangThai = N'DaXacNhan'
                WHERE lhp.MaHocKy = @maHocKy
                  AND (@maKhoa IS NULL OR @maKhoa = '' OR l.MaKhoa = @maKhoa)
                  AND (@maLop  IS NULL OR @maLop  = '' OR sv.MaLop = @maLop)
                GROUP BY
                    CASE
                        WHEN d.TongKet >= 9 THEN '9-10'
                        WHEN d.TongKet >= 8 THEN '8-9'
                        WHEN d.TongKet >= 7 THEN '7-8'
                        WHEN d.TongKet >= 6 THEN '6-7'
                        WHEN d.TongKet >= 5 THEN '5-6'
                        WHEN d.TongKet >= 4 THEN '4-5'
                        WHEN d.TongKet >= 3 THEN '3-4'
                        WHEN d.TongKet >= 2 THEN '2-3'
                        WHEN d.TongKet >= 1 THEN '1-2'
                        ELSE '0-1'
                    END
                ORDER BY MIN(d.TongKet) DESC",
                new { maHocKy, maKhoa, maLop });
        }

        // ── ComboBoxes ──────────────────────────────────────────────────────

        public static DataTable GetAllHocKy()
        {
            return Functions.GetDataToTable(@"
                SELECT MaHocKy, TenHocKy + ' - ' + NamHoc AS TenHK
                FROM HocKy
                ORDER BY MaHocKy DESC");
        }

        public static DataTable GetAllKhoa()
        {
            return Functions.GetDataToTable(@"
                SELECT MaKhoa, TenKhoa
                FROM Khoa
                ORDER BY TenKhoa");
        }

        public static DataTable GetLopByKhoa(string maKhoa)
        {
            return Functions.GetDataToTable(@"
                SELECT MaLop, TenLop
                FROM Lop
                WHERE (@maKhoa IS NULL OR @maKhoa = '' OR MaKhoa = @maKhoa)
                ORDER BY TenLop",
                new { maKhoa });
        }
    }
}