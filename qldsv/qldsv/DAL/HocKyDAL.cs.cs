using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.DAL
{
    public class HocKyDAL
    {
        public static DataTable GetAll()
        {
            Functions.Connect();

            string sql = "SELECT MaHocKy, TenHocKy, NamHoc, TrangThai FROM HocKy ORDER BY MaHocKy DESC";

            DataTable dt = Functions.GetDataToTable(sql);

            Functions.Disconnect();

            return dt;
        }

        public static bool KiemTraTrung(string tenHocKy, string namHoc, int maHocKy = 0)
        {
            return false;
        }

        public static bool DangDuocDung(int maHocKy)
        {
            return false;
        }

        public static void Them(string tenHocKy, string namHoc)
        {

        }

        public static void Sua(int maHocKy, string tenHocKy, string namHoc)
        {

        }

        public static void Xoa(int maHocKy)
        {

        }

        public static void MoHocKy(int maHocKy)
        {

        }

        public static void DongHocKy(int maHocKy)
        {

        }
    }
}