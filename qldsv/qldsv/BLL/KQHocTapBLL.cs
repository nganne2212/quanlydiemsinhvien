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

            if (!dt.Columns.Contains("He4"))
                dt.Columns.Add("He4", typeof(double));
            if (!dt.Columns.Contains("DiemChu"))
                dt.Columns.Add("DiemChu", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                double tongKet = row["TongKet"] == DBNull.Value ? 0 : Convert.ToDouble(row["TongKet"]);
                row["He4"] = QuyDoiHe4(tongKet);
                row["DiemChu"] = XepDiemChu(tongKet > 0 ? (double?)tongKet : null);
            }
            return dt;
        }

        public static double QuyDoiHe4(double diem10)
        {
            if (diem10 >= 8.5) return 4.0;
            if (diem10 >= 8.0) return 3.5;
            if (diem10 >= 7.0) return 3.0;
            if (diem10 >= 6.5) return 2.5;
            if (diem10 >= 5.5) return 2.0;
            if (diem10 >= 5.0) return 1.5;
            if (diem10 >= 4.0) return 1.0;
            return 0.0;
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
                { "TB10", Math.Round(tb10, 1) },
                { "TB4", Math.Round(tb4, 2) },
                { "TongTC", tongTC }
            };
        }

        public static Dictionary<string, object> GetThongKeTongKetTichLuy(string maSV, int maHocKy)
        {
            double tb10 = DAL.KQHocTapDAL.TinhTrungBinhTichLuy(maSV, maHocKy);
            double tb4 = DAL.KQHocTapDAL.TinhGPA4TichLuy(maSV, maHocKy);
            int tongTC = DAL.KQHocTapDAL.TinhTongTinChiTichLuy(maSV, maHocKy);
            return new Dictionary<string, object>
    {
        { "TB10", Math.Round(tb10, 1) },
        { "TB4",  Math.Round(tb4, 2) },
        { "TongTC", tongTC }
    };
        }
    }
}
