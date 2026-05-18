using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.DAL
{
    internal class MonHocDAL
    {
        public static DataTable GetAll()
        {
            string sql = @"SELECT ROW_NUMBER() OVER (ORDER BY MaMonHoc) AS STT,
                                  MaMonHoc, TenMon, SoTinChi,
                                  HeSoChuyenCan, HeSoKT1, HeSoKT2, HeSoCuoiKy
                           FROM MonHoc";
            return Functions.GetDataToTable(sql);
        }

        public static DataTable Search(string keyword)
        {
            string sql = @"SELECT ROW_NUMBER() OVER (ORDER BY MaMonHoc) AS STT,
                                  MaMonHoc, TenMon, SoTinChi,
                                  HeSoChuyenCan, HeSoKT1, HeSoKT2, HeSoCuoiKy
                           FROM MonHoc
                           WHERE MaMonHoc LIKE N'%" + keyword + @"%'
                              OR TenMon   LIKE N'%" + keyword + @"%'";
            return Functions.GetDataToTable(sql);
        }

        public static bool CheckTrungMa(string maMonHoc)
        {
            string sql = "SELECT MaMonHoc FROM MonHoc WHERE MaMonHoc = N'" + maMonHoc + "'";
            return Functions.CheckKey(sql);
        }

        public static bool CheckDangDung(string maMonHoc)
        {
            string sql = "SELECT COUNT(*) FROM LopHocPhan WHERE MaMonHoc = N'" + maMonHoc + "'";
            DataTable dt = Functions.GetDataToTable(sql);
            return dt.Rows.Count > 0 && System.Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public static void Insert(string maMonHoc, string tenMon, int soTinChi,
            double heSoCC, double heSoKT1, double heSoKT2, double heSoCuoiKy)
        {
            var cult = System.Globalization.CultureInfo.InvariantCulture;
            string sql = $@"INSERT INTO MonHoc (MaMonHoc, TenMon, SoTinChi, HeSoChuyenCan, HeSoKT1, HeSoKT2, HeSoCuoiKy)
                            VALUES (N'{maMonHoc}', N'{tenMon}', {soTinChi},
                                    {heSoCC.ToString(cult)}, {heSoKT1.ToString(cult)},
                                    {heSoKT2.ToString(cult)}, {heSoCuoiKy.ToString(cult)})";
            Functions.RunSql(sql);
        }

        public static void Update(string maMonHoc, string tenMon, int soTinChi,
            double heSoCC, double heSoKT1, double heSoKT2, double heSoCuoiKy)
        {
            var cult = System.Globalization.CultureInfo.InvariantCulture;
            string sql = $@"UPDATE MonHoc SET
                                TenMon        = N'{tenMon}',
                                SoTinChi      = {soTinChi},
                                HeSoChuyenCan = {heSoCC.ToString(cult)},
                                HeSoKT1       = {heSoKT1.ToString(cult)},
                                HeSoKT2       = {heSoKT2.ToString(cult)},
                                HeSoCuoiKy    = {heSoCuoiKy.ToString(cult)}
                            WHERE MaMonHoc = N'{maMonHoc}'";
            Functions.RunSql(sql);
        }

        public static void Delete(string maMonHoc)
        {
            string sql = "DELETE FROM MonHoc WHERE MaMonHoc = N'" + maMonHoc + "'";
            Functions.RunSqldel(sql);
        }
    }
}
