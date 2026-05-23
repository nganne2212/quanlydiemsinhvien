using qldsv.Class;
using System.Data;

namespace qldsv.DAL
{
    internal class LichHocDAL
    {
        public static DataTable GetAllHocKy()
        {
            return Functions.GetDataToTable(@"
                SELECT MaHocKy,
                       TenHocKy + N' - ' + NamHoc AS TenHK
                FROM HocKy
                ORDER BY MaHocKy DESC");
        }

        public static DataTable GetThongTinSV(string maSV)
        {
            return Functions.GetDataToTable(@"
                SELECT sv.MaSinhVien,
                       sv.HoTen,
                       l.TenLop
                FROM SinhVien sv
                INNER JOIN Lop l ON l.MaLop = sv.MaLop
                WHERE sv.MaSinhVien = @maSV",
                new { maSV });
        }

        public static DataTable GetLichHoc(string maSV, int maHocKy)
        {
            return Functions.GetDataToTable(@"
                SELECT N'Thứ ' + CAST(lh.Thu   AS nvarchar) AS TenThu,
                       N'Ca '  + CAST(lh.CaHoc AS nvarchar) AS TenCa,
                       lhp.MaLHP,
                       mh.TenMon,
                       ph.TenPhong                           AS TenPhong,
                       gv.HoTen                              AS GiangVien,
                       lhp.NgayBatDau,
                       lhp.NgayKetThuc
                FROM DangKyHP      dk
                INNER JOIN LopHocPhan lhp ON lhp.MaLHP      = dk.MaLHP
                INNER JOIN MonHoc      mh  ON mh.MaMonHoc    = lhp.MaMonHoc
                INNER JOIN LichHoc     lh  ON lh.MaLHP       = lhp.MaLHP
                INNER JOIN PhongHoc    ph  ON ph.MaPhong      = lh.MaPhong
                INNER JOIN GiangVien   gv  ON gv.MaGiangVien = lhp.MaGiangVien
                WHERE dk.MaSinhVien = @maSV
                  AND lhp.MaHocKy  = @maHocKy
                ORDER BY lh.Thu, lh.CaHoc",
                new { maSV, maHocKy });
        }
    }
}