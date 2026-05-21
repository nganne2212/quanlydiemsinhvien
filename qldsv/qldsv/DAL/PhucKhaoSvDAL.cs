using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qldsv.DAL
{
    internal class PhucKhaoSvDAL
    {
        /// <summary>
        /// Chỉ lấy học kỳ đang diễn ra.
        /// </summary>
        public static DataTable GetHocKyDangDienRa()
        {
            return Functions.GetDataToTable(@"
                SELECT MaHocKy, TenHocKy + ' - ' + NamHoc AS TenHK
                FROM HocKy
                WHERE Trangthai = N'DangDienRa'
                ORDER BY MaHocKy DESC");
        }

        /// <summary>
        /// Lấy môn học SV có thể gửi phúc khảo:
        ///   - Điểm đã xác nhận (DaXacNhan)
        ///   - Không phải điểm từ phúc khảo (NguonGoc != 'PhucKhao')
        ///   - Chưa có đơn phúc khảo nào cho môn đó
        /// Trả về MaDangKy, TenMonHoc, CuoiKy.
        /// </summary>
        public static DataTable GetMonHocCoThePKhao(string maSV, int maHocKy)
        {
            return Functions.GetDataToTable(@"
                SELECT dk.MaDangKy,
                       mh.TenMon + ' (' + lhp.MaLHP + ')' AS TenMonHoc,
                       d.CuoiKy
                FROM DangKyHP   dk
                INNER JOIN LopHocPhan lhp ON lhp.MaLHP   = dk.MaLHP
                INNER JOIN MonHoc     mh  ON mh.MaMonHoc  = lhp.MaMonHoc
                INNER JOIN Diem       d   ON d.MaDangKy   = dk.MaDangKy
                WHERE dk.MaSinhVien = @maSV
                  AND lhp.MaHocKy  = @maHocKy
                  AND d.TrangThai  = N'DaXacNhan'
                  AND d.NguonGoc  != N'PhucKhao'
                  AND NOT EXISTS (
                        SELECT 1 FROM PhucKhao pk
                        WHERE pk.MaDangKy = dk.MaDangKy
                  )
                ORDER BY mh.TenMon",
                new { maSV, maHocKy });
        }

        /// <summary>
        /// Lấy tất cả đơn phúc khảo của SV mọi kỳ.
        /// </summary>
        public static DataTable GetDanhSachPhucKhao(string maSV)
        {
            return Functions.GetDataToTable(@"
                SELECT mh.TenMon          AS MonHoc,
                       d.CuoiKy           AS DiemCuoiKy,
                       pk.NgayGui,
                       pk.TrangThai
                FROM PhucKhao  pk
                INNER JOIN DangKyHP   dk  ON dk.MaDangKy  = pk.MaDangKy
                INNER JOIN LopHocPhan lhp ON lhp.MaLHP    = dk.MaLHP
                INNER JOIN MonHoc     mh  ON mh.MaMonHoc  = lhp.MaMonHoc
                INNER JOIN Diem       d   ON d.MaDangKy   = dk.MaDangKy
                WHERE dk.MaSinhVien = @maSV
                ORDER BY pk.NgayGui DESC",
                new { maSV });
        }

        /// <summary>
        /// Insert đơn phúc khảo mới.
        /// </summary>
        public static void GuiPhucKhao(int maDangKy, string lyDo)
        {
            Functions.Execute(@"
        INSERT INTO PhucKhao (MaPhucKhao, MaDangKy, LyDo, NgayGui, TrangThai)
        VALUES (
            (SELECT ISNULL(MAX(MaPhucKhao), 0) + 1 FROM PhucKhao),
            @maDangKy, @lyDo, CAST(GETDATE() AS date), N'ChuaXuLy'
        )",
                new { maDangKy, lyDo });
        }
    }
}
