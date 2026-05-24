using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    public class KQHocTapBLL
    {

        public static DataTable GetNamHoc()
        {
            return DAL.KQHocTapDAL.GetNamHoc();
        }


        public static DataTable GetHocKyByNam(string namHoc)
        {
            return DAL.KQHocTapDAL.GetHocKyByNam(namHoc);
        }


        public static DataRow GetThongTinSinhVien(string maSV)
        {
            return DAL.KQHocTapDAL.GetThongTinSinhVien(maSV);
        }


        public static DataTable GetKetQuaHocTap(string maSV, int maHocKy)
        {
            DataTable dt = DAL.KQHocTapDAL.GetKetQuaHocTap(maSV, maHocKy);

            // Thêm cột tính toán cho từng dòng
            if (dt.Columns.Count == dt.Columns.Cast<DataColumn>().Count(c => new[] 
                { "MaLHP", "TenMon", "SoTinChi", "ChuyenCan", "Kiemtra1", "Kiemtra2", "CuoiKy", "TongKet" }
                .Contains(c.ColumnName)))
            {
                dt.Columns.Add("He4", typeof(string));
                dt.Columns.Add("DiemChu", typeof(string));
            }

            // Tính từng hàng
            foreach (DataRow row in dt.Rows)
            {
                double tongKet = row["TongKet"] == DBNull.Value ? 0 : Convert.ToDouble(row["TongKet"]);

                // Tính hệ chữ
                string he4 = XepDiemChu(tongKet);
                row["He4"] = he4;

                // Tính xếp loại (giống He4)
                double? tongKetNullable = tongKet > 0 ? (double?)tongKet : null;
                string diemChu = DiemBLL.XepDiemChu(tongKetNullable);
                row["DiemChu"] = diemChu;
            }

            return dt;
        }

        // Xếp loại điểm hệ chữ
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


        public static Dictionary<string, object> GetThongKeTongKetHocKy(string maSV, int maHocKy)
        {
            double tb10 = DAL.KQHocTapDAL.TinhTrungBinhHocKy(maSV, maHocKy);
            double tb4 = DAL.KQHocTapDAL.TinhGPA4HocKy(maSV, maHocKy);
            int tongTC = DAL.KQHocTapDAL.TinhTongTinChiHocKy(maSV, maHocKy);

            return new Dictionary<string, object>
            {
                { "TB10", Math.Round(tb10, 2) },
                { "TB4", Math.Round(tb4, 2) },
                { "TongTC", tongTC }
            };
        }

        public static Dictionary<string, object> GetThongKeTongKetTichLuy(string maSV)
        {
            double tb10 = DAL.KQHocTapDAL.TinhTrungBinhTichLuy(maSV);
            double tb4 = DAL.KQHocTapDAL.TinhGPA4TichLuy(maSV);
            int tongTC = DAL.KQHocTapDAL.TinhTongTinChiTichLuy(maSV);

            return new Dictionary<string, object>
            {
                { "TB10", Math.Round(tb10, 2) },
                { "TB4", Math.Round(tb4, 2) },
                { "TongTC", tongTC }
            };
        }
    }
}
