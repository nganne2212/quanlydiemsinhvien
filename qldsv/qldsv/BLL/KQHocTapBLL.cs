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
                dt.Columns.Add("He4", typeof(double));
                dt.Columns.Add("DiemChu", typeof(string));
            }

            // Tính từng hàng
            foreach (DataRow row in dt.Rows)
            {
                double? tongKet = row["TongKet"] == DBNull.Value ? null : (double?)Convert.ToDouble(row["TongKet"]);

                // Tính hệ 4.0
                double he4 = ConvertTo4Scale(tongKet);
                row["He4"] = he4;

                // Tính xếp loại
                string diemChu = DiemBLL.XepDiemChu(tongKet);
                row["DiemChu"] = diemChu;
            }

            return dt;
        }


        private static double ConvertTo4Scale(double? diem10)
        {
            if (diem10 == null) return 0;
            double d = diem10.Value;

            if (d >= 9.5) return 4.0;
            if (d >= 8.5) return 3.7;
            if (d >= 8.0) return 3.5;
            if (d >= 7.0) return 3.0;
            if (d >= 6.5) return 2.5;
            if (d >= 5.5) return 2.0;
            if (d >= 5.0) return 1.5;
            if (d >= 4.0) return 1.0;
            return 0;
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
