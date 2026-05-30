using DocumentFormat.OpenXml.Spreadsheet;
using qldsv.DAL;
using System.Data;

namespace qldsv.BLL
{
    class DashBoardBLL
    {

        public static DataTable GetAllHocKy()
        {
            return DashBoardDAL.GetAllHocKy();
        }
        public static DataTable GetAllKhoa()
        {
            return DashBoardDAL.GetAllKhoa();
        }
        public static DataTable GetLopByKhoa(string maKhoa)
        {
            return DashBoardDAL.GetLopByKhoa(maKhoa);
        }

        // ── Tab 1: Tổng quan ────────────────────────────────────────────────
        public static DataRow GetTongQuan(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetTongQuan(maHocKy, maKhoa, maLop);
        }
        public static DataTable GetDiemTBTheoHocKy(string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetDiemTBTheoHocKy(maKhoa, maLop);
        }

        // ── Tab 2: Học lực ──────────────────────────────────────────────────
        public static DataTable GetPhanBoHocLuc(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetPhanBoHocLuc(maHocKy, maKhoa, maLop);
        }
        public static DataTable GetHocLucTheoKhoa(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetHocLucTheoKhoa(maHocKy, maKhoa, maLop);
        }

        // ── Tab 3: Môn học ──────────────────────────────────────────────────
        public static DataTable GetTop10MonTruot(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetTop10MonTruot(maHocKy, maKhoa, maLop);
        }
        public static DataTable GetHocLaiTheoMon(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetHocLaiTheoMon(maHocKy, maKhoa, maLop);
        }

        // ── Tab 4: Thống kê điểm ────────────────────────────────────────────
        public static DataTable GetThongKeThangDiem(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetThongKeThangDiem(maHocKy, maKhoa, maLop);
        }
        public static DataTable GetPhanBoDiemThang10(int maHocKy, string maKhoa, string maLop = "")
        {
            return DashBoardDAL.GetPhanBoDiemThang10(maHocKy, maKhoa, maLop);
        }
    }
}