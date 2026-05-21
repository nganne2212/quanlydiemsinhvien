using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;

namespace qldsv.BLL
{
    class DiemBLL
    {
        public static DataTable GetSVVaDiem(string maLHP) =>
            DAL.DiemDAL.GetSVVaDiem(maLHP);

        public static bool DaXacNhan(string maLHP) =>
            DAL.DiemDAL.DaXacNhan(maLHP);

        public static DataRow GetHeSo(string maLHP) =>
            DAL.DiemDAL.GetHeSo(maLHP);

        // ════════════════════════════════════════════════════════
        //  TÍNH TỔNG KẾT
        // ════════════════════════════════════════════════════════

        public static double? TinhTongKet(double? cc, double? kt1, double? kt2, double? ck, DataRow heSo)
        {
            if (heSo == null) return null;
            if (cc == null && kt1 == null && kt2 == null && ck == null) return null;

            double h1 = Convert.ToDouble(heSo["HeSoChuyenCan"]);
            double h2 = Convert.ToDouble(heSo["HeSoKT1"]);
            double h3 = Convert.ToDouble(heSo["HeSoKT2"]);
            double h4 = Convert.ToDouble(heSo["HeSoCuoiKy"]);

            double tong = (cc ?? 0) * h1 + (kt1 ?? 0) * h2
                        + (kt2 ?? 0) * h3 + (ck ?? 0) * h4;

            return Math.Round(tong, 2);
        }

        // ════════════════════════════════════════════════════════
        //  XẾP ĐIỂM CHỮ
        // ════════════════════════════════════════════════════════

        public static string XepDiemChu(double? tongKet)
        {
            if (tongKet == null) return "";
            double d = tongKet.Value;
            if (d >= 9.5) return "A+";
            if (d >= 8.5) return "A";
            if (d >= 8.0) return "B+";
            if (d >= 7.0) return "B";
            if (d >= 6.5) return "C+";
            if (d >= 5.5) return "C";
            if (d >= 5.0) return "D+";
            if (d >= 4.0) return "D";
            return "F";
        }

        public static string ValidateDiem(string gia_tri, string tenCot)
        {
            if (string.IsNullOrWhiteSpace(gia_tri))
                return "";

            if (!double.TryParse(gia_tri, out double d))
                return $"{tenCot} phải là số";

            if (double.IsNaN(d) || double.IsInfinity(d))
                return $"{tenCot} không hợp lệ";

            if (d < 0 || d > 10)
                return $"{tenCot} phải từ 0 đến 10";

            return "";
        }

        // ════════════════════════════════════════════════════════
        //  LƯU TẠM
        // ════════════════════════════════════════════════════════

        public static string LuuTam(DataTable tblDiem, string maLHP, DataRow heSo)
        {
            int soLoi = 0;

            foreach (DataRow row in tblDiem.Rows)
            {
                int maDangKy = Convert.ToInt32(row["MaDangKy"]);
                string maSV = row["MaSinhVien"].ToString();
                string nguonGoc = "GiangVien";

                double? cc = row["ChuyenCan"] == DBNull.Value ? (double?)null : Convert.ToDouble(row["ChuyenCan"]);
                double? kt1 = row["Kiemtra1"] == DBNull.Value ? (double?)null : Convert.ToDouble(row["Kiemtra1"]);
                double? kt2 = row["Kiemtra2"] == DBNull.Value ? (double?)null : Convert.ToDouble(row["Kiemtra2"]);
                double? ck = row["CuoiKy"] == DBNull.Value ? (double?)null : Convert.ToDouble(row["CuoiKy"]);

                // Bỏ qua hàng chưa nhập gì
                if (cc == null && kt1 == null && kt2 == null && ck == null) continue;

                double? tongKet = TinhTongKet(cc, kt1, kt2, ck, heSo);

                try
                {
                    DAL.DiemDAL.LuuTam(maDangKy, maSV, maLHP, cc, kt1, kt2, ck, tongKet, nguonGoc);
                }
                catch
                {
                    soLoi++;
                }
            }

            return soLoi > 0 ? $"Có {soLoi} dòng lưu thất bại!" : "";
        }


        public static string XacNhan(string maLHP, int soSVChuaNhap)
        {
            if (soSVChuaNhap > 0)
                return $"WARN:{soSVChuaNhap}"; // Form xử lý cảnh báo riêng

            DAL.DiemDAL.XacNhan(maLHP);
            return "";
        }

        public static void XacNhanForce(string maLHP)
        {
            DAL.DiemDAL.XacNhan(maLHP);
        }



        public static void ExportExcel(string maLHP, string filePath) =>
            DAL.DiemDAL.ExportExcel(maLHP, filePath);

        public static void TaiMauExcel(string maLHP, string filePath) =>
            DAL.DiemDAL.TaiMauExcel(maLHP, filePath);

        public static Dictionary<string, double?[]> ImportExcel(string filePath) =>
            DAL.DiemDAL.ImportExcel(filePath);
    }
}
