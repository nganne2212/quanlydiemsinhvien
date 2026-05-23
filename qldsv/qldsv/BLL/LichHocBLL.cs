using System.Data;

namespace qldsv.BLL
{
    internal class LichHocBLL
    {
        public static DataTable GetAllHocKy()
            => DAL.LichHocDAL.GetAllHocKy();

        public static DataTable GetThongTinSV(string maSV)
            => DAL.LichHocDAL.GetThongTinSV(maSV);

        public static DataTable GetLichHoc(string maSV, int maHocKy)
            => DAL.LichHocDAL.GetLichHoc(maSV, maHocKy);
    }
}