using System.Data;
using qldsv.DAL;

namespace qldsv.BLL
{
    public class LichHocBLL
    {
        public static DataTable GetAllHocKy()
        {
            return LichHocDAL.GetAllHocKy();
        }

        public static DataTable GetThongTinSinhVien(string maSinhVien)
        {
            return LichHocDAL.GetThongTinSinhVien(maSinhVien);
        }

        public static DataTable GetLichHocSinhVien(string maSV, int maHocKy)
        {
            return LichHocDAL.GetLichHocSinhVien(maSV, maHocKy);
        }
    }
}