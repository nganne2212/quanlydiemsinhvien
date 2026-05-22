using ClosedXML.Excel;
using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void ExportExcel(DataTable dt, string filePath)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("CanhBaoHocVu");

                // Header
                ws.Cell(1, 1).Value = "STT";
                ws.Cell(1, 2).Value = "MSSV";
                ws.Cell(1, 3).Value = "Họ tên";
                ws.Cell(1, 4).Value = "Lớp";
                ws.Cell(1, 5).Value = "Học kỳ";
                ws.Cell(1, 6).Value = "Điểm HK";
                ws.Cell(1, 7).Value = "TBTL";
                ws.Cell(1, 8).Value = "TCTL";
                ws.Cell(1, 9).Value = "Số kỳ CB";
                ws.Cell(1, 10).Value = "Mức cảnh báo";
                ws.Cell(1, 11).Value = "Lý do";

                var header = ws.Range(1, 1, 1, 11);

                header.Style.Font.Bold = true;
                header.Style.Fill.BackgroundColor =
                    XLColor.FromArgb(232, 234, 246);

                // Data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];

                    int r = i + 2;

                    ws.Cell(r, 1).Value = i + 1;
                    ws.Cell(r, 2).Value = row["MaSinhVien"].ToString();
                    ws.Cell(r, 3).Value = row["HoTen"].ToString();
                    ws.Cell(r, 4).Value = row["TenLop"].ToString();
                    ws.Cell(r, 5).Value = row["TenHocKy"].ToString();
                    ws.Cell(r, 6).Value = Convert.ToDouble(row["DiemHK"]);
                    ws.Cell(r, 7).Value = Convert.ToDouble(row["TBTL"]);
                    ws.Cell(r, 8).Value = Convert.ToInt32(row["TCTL"]);
                    ws.Cell(r, 9).Value = Convert.ToInt32(row["SoKyDaBiCB"]);
                    ws.Cell(r, 10).Value = row["MucCanhBao"].ToString();
                    ws.Cell(r, 11).Value = row["LyDo"].ToString();
                }

                ws.Columns().AdjustToContents();

                wb.SaveAs(filePath);
            }
        }
    }
}
