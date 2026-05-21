using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qldsv.DAL
{
    public class CanhBaoHocVuDAL
    {
        /// <summary>
        /// Lấy cảnh báo của SV thuộc lớp GV làm cố vấn.
        /// Trả về TenHocKy thay vì MaHocKy để hiển thị.
        /// </summary>
        public static DataTable GetByGiangVien(string maGiangVien)
        {
            return Functions.GetDataToTable(
                @"SELECT cb.MaCanhBao,
                         sv.MaSinhVien,
                         sv.HoTen,
                         l.MaLop,
                         l.TenLop,
                         hk.TenHocKy + ' (' + hk.NamHoc + ')' AS TenHocKy,
                         cb.DiemHK,
                         cb.TBTL,
                         cb.TCTL,
                         cb.SoKyDaBiCB,
                         cb.MucCanhBao,
                         cb.LyDo
                  FROM CanhBaoHocVu cb
                  JOIN SinhVien sv ON cb.MaSinhVien = sv.MaSinhVien
                  JOIN Lop      l  ON sv.MaLop      = l.MaLop
                  JOIN HocKy    hk ON cb.MaHocKy    = hk.MaHocKy
                  WHERE l.MaGiangVien = @MaGiangVien
                  ORDER BY cb.MaHocKy DESC, sv.MaSinhVien",
                new { MaGiangVien = maGiangVien });
        }

        /// <summary>Lấy danh sách lớp GV làm cố vấn để fill ComboBox.</summary>
        public static DataTable GetLopByGiangVien(string maGiangVien)
        {
            return Functions.GetDataToTable(
                @"SELECT MaLop, TenLop FROM Lop
                  WHERE MaGiangVien = @MaGiangVien
                  ORDER BY TenLop",
                new { MaGiangVien = maGiangVien });
        }

        /// <summary>Lấy danh sách học kỳ có cảnh báo thuộc lớp GV để fill ComboBox.</summary>
        public static DataTable GetHocKyByGiangVien(string maGiangVien)
        {
            return Functions.GetDataToTable(
                @"SELECT DISTINCT hk.MaHocKy,
                         hk.TenHocKy + ' (' + hk.NamHoc + ')' AS TenHocKy
                  FROM CanhBaoHocVu cb
                  JOIN SinhVien sv ON cb.MaSinhVien = sv.MaSinhVien
                  JOIN Lop      l  ON sv.MaLop      = l.MaLop
                  JOIN HocKy    hk ON cb.MaHocKy    = hk.MaHocKy
                  WHERE l.MaGiangVien = @MaGiangVien
                  ORDER BY hk.MaHocKy DESC",
                new { MaGiangVien = maGiangVien });
        }
    }
}
