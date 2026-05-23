using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qldsv.Class;

using System.Data;
using Dapper;
using ClosedXML.Excel;

namespace qldsv.DAL
{
    class DiemDAL
    {


        public static DataTable GetSVVaDiem(string maLHP)
        {
            return Functions.GetDataToTable(@"
                SELECT dk.MaDangKy,
                       sv.MaSinhVien,
                       sv.HoTen,
                       d.ChuyenCan,
                       d.Kiemtra1,
                       d.Kiemtra2,
                       d.CuoiKy,
                       d.TongKet,
                       d.TrangThai
                FROM DangKyHP dk
                JOIN SinhVien sv ON dk.MaSinhVien = sv.MaSinhVien
                LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
                WHERE dk.MaLHP = @maLHP
                ORDER BY sv.HoTen",
                new { maLHP });
        }



        public static bool DaXacNhan(string maLHP)
        {
            return Functions.QuerySingle<int>(@"
                SELECT COUNT(*)
                FROM Diem d
                JOIN DangKyHP dk ON d.MaDangKy = dk.MaDangKy
                WHERE dk.MaLHP = @maLHP
                AND d.TrangThai = N'DaXacNhan'",
                new { maLHP }) > 0;
        }



        public static DataRow GetHeSo(string maLHP)
        {
            DataTable dt = Functions.GetDataToTable(@"
                SELECT mh.HeSoChuyenCan, mh.HeSoKT1, mh.HeSoKT2, mh.HeSoCuoiKy
                FROM LopHocPhan lhp
                JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                WHERE lhp.MaLHP = @maLHP",
                new { maLHP });
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }


        //  XÁC ĐỊNH LOẠI HỌC


        public static string XacDinhLoaiHoc(string maSV, string maLHP)
        {
            double diemCao = Functions.QuerySingle<double>(@"
                SELECT ISNULL(MAX(d.TongKet), -1)
                FROM DangKyHP dk
                JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                JOIN Diem d ON dk.MaDangKy = d.MaDangKy
                WHERE dk.MaSinhVien = @sv
                AND lhp.MaMonHoc = (SELECT MaMonHoc FROM LopHocPhan WHERE MaLHP = @lhp)
                AND dk.MaLHP != @lhp
                AND d.TrangThai = N'DaXacNhan'",
                new { sv = maSV, lhp = maLHP });

            if (diemCao < 0) return "LanDau";
            if (diemCao < 4.0) return "HocLai";
            return "CaiThien";
        }

        public static int XacDinhLanHoc(string maSV, string maLHP)
        {
            return Functions.QuerySingle<int>(@"
                SELECT COUNT(*) + 1
                FROM DangKyHP dk
                JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                WHERE dk.MaSinhVien = @sv
                AND lhp.MaMonHoc = (SELECT MaMonHoc FROM LopHocPhan WHERE MaLHP = @lhp)
                AND dk.MaLHP != @lhp",
                new { sv = maSV, lhp = maLHP });
        }


        //  LƯU TẠM — INSERT hoặc UPDATE từng hàng
    

        public static void LuuTam(int maDangKy, string maSV, string maLHP,
            double? cc, double? kt1, double? kt2, double? ck,
            double? tongKet, string nguonGoc)
        {
            // Kiểm tra đã có Diem chưa
            int maDiem = Functions.QuerySingle<int>(
                "SELECT ISNULL(MaDiem, 0) FROM Diem WHERE MaDangKy = @ma",
                new { ma = maDangKy });

            if (maDiem == 0)
            {
                // INSERT mới
                string loaiHoc = XacDinhLoaiHoc(maSV, maLHP);
                int lanHoc = XacDinhLanHoc(maSV, maLHP);

                Functions.Execute(@"
                    INSERT INTO Diem
                        (MaDangKy, ChuyenCan, Kiemtra1, Kiemtra2, CuoiKy,
                         TongKet, TrangThai, LanHoc, Loaihoc, NguonGoc)
                    VALUES
                        (@maDangKy, @cc, @kt1, @kt2, @ck,
                         @tongKet, N'ChuaXacNhan', @lanHoc, @loaiHoc, @nguonGoc)",
                    new { maDangKy, cc, kt1, kt2, ck, tongKet, lanHoc, loaiHoc, nguonGoc });
            }
            else
            {
                // UPDATE nếu chưa xác nhận
                Functions.Execute(@"
                    UPDATE Diem
                    SET ChuyenCan = @cc, Kiemtra1 = @kt1, Kiemtra2 = @kt2,
                        CuoiKy = @ck, TongKet = @tongKet, NguonGoc = @nguonGoc
                    WHERE MaDangKy = @maDangKy
                    AND TrangThai = N'ChuaXacNhan'",
                    new { maDangKy, cc, kt1, kt2, ck, tongKet, nguonGoc });
            }
        }

      
        //  XÁC NHẬN — lock toàn bộ LHP
     

        public static void XacNhan(string maLHP)
        {
            Functions.Execute(@"
                UPDATE Diem
                SET TrangThai = N'DaXacNhan'
                FROM Diem d
                JOIN DangKyHP dk ON d.MaDangKy = dk.MaDangKy
                WHERE dk.MaLHP = @maLHP
                AND d.TrangThai = N'ChuaXacNhan'",
                new { maLHP });
        }

        //  EXPORT / TẢI MẪU EXCEL
  

        public static void ExportExcel(string maLHP, string filePath)
        {
            DataTable dt = GetSVVaDiem(maLHP);

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Diem");

                // Header
                ws.Cell(1, 1).Value = "MSSV";
                ws.Cell(1, 2).Value = "Họ tên";
                ws.Cell(1, 3).Value = "CC";
                ws.Cell(1, 4).Value = "KT1";
                ws.Cell(1, 5).Value = "KT2";
                ws.Cell(1, 6).Value = "CK";
                ws.Cell(1, 7).Value = "Tổng kết";

                var headerRange = ws.Range(1, 1, 1, 7);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(232, 234, 246);

                // Data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    int r = i + 2;
                    ws.Cell(r, 1).Value = row["MaSinhVien"].ToString();
                    ws.Cell(r, 2).Value = row["HoTen"].ToString();
                    ws.Cell(r, 3).Value = row["ChuyenCan"] == DBNull.Value ? "" : row["ChuyenCan"].ToString();
                    ws.Cell(r, 4).Value = row["Kiemtra1"] == DBNull.Value ? "" : row["Kiemtra1"].ToString();
                    ws.Cell(r, 5).Value = row["Kiemtra2"] == DBNull.Value ? "" : row["Kiemtra2"].ToString();
                    ws.Cell(r, 6).Value = row["CuoiKy"] == DBNull.Value ? "" : row["CuoiKy"].ToString();
                    ws.Cell(r, 7).Value = row["TongKet"] == DBNull.Value ? "" : row["TongKet"].ToString();
                }

                ws.Columns().AdjustToContents();
                wb.SaveAs(filePath);
            }
        }

        public static void TaiMauExcel(string maLHP, string filePath)
        {
            DataTable dt = GetSVVaDiem(maLHP);

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Diem");

                ws.Cell(1, 1).Value = "MSSV";
                ws.Cell(1, 2).Value = "Họ tên";
                ws.Cell(1, 3).Value = "CC";
                ws.Cell(1, 4).Value = "KT1";
                ws.Cell(1, 5).Value = "KT2";
                ws.Cell(1, 6).Value = "CK";

                var headerRange = ws.Range(1, 1, 1, 6);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(232, 234, 246);

                // Chỉ điền MSSV + HoTen, để trống cột điểm
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    int r = i + 2;
                    ws.Cell(r, 1).Value = row["MaSinhVien"].ToString();
                    ws.Cell(r, 2).Value = row["HoTen"].ToString();
                    // CC/KT1/KT2/CK để trống cho GV điền
                }

                // Lock cột MSSV + HoTen
                ws.Column(1).Style.Protection.Locked = true;
                ws.Column(2).Style.Protection.Locked = true;
                ws.SheetView.FreezeColumns(2);

                ws.Columns().AdjustToContents();
                wb.SaveAs(filePath);
            }
        }


        //  IMPORT EXCEL → trả về list để điền vào dgv
  

        public static Dictionary<string, double?[]> ImportExcel(string filePath)
        {
            // Key = MSSV, Value = [CC, KT1, KT2, CK]
            var result = new Dictionary<string, double?[]>();

            using (var wb = new XLWorkbook(filePath))
            {
                var ws = wb.Worksheet(1);
                foreach (var row in ws.RowsUsed())
                {
                    if (row.RowNumber() == 1) continue;

                    string maSV = row.Cell(1).GetString().Trim();
                    if (string.IsNullOrEmpty(maSV)) continue;

                    double? cc = TryParseDouble(row.Cell(3).GetString());
                    double? kt1 = TryParseDouble(row.Cell(4).GetString());
                    double? kt2 = TryParseDouble(row.Cell(5).GetString());
                    double? ck = TryParseDouble(row.Cell(6).GetString());

                    result[maSV] = new double?[] { cc, kt1, kt2, ck };
                }
            }

            return result;
        }

        private static double? TryParseDouble(string s)
        {
            s = s.Replace(",", ".");
            if (double.TryParse(s, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double d))
                return d;
            return null;
        }
    }
}
