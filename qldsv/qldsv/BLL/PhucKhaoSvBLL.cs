using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    internal class PhucKhaoSvBLL
    {
        public static DataTable GetHocKyDangDienRa()
            => DAL.PhucKhaoSvDAL.GetHocKyDangDienRa();

        public static DataTable GetMonHocCoThePKhao(string maSV, int maHocKy)
            => DAL.PhucKhaoSvDAL.GetMonHocCoThePKhao(maSV, maHocKy);

        public static DataTable GetDanhSachPhucKhao(string maSV)
            => DAL.PhucKhaoSvDAL.GetDanhSachPhucKhao(maSV);


        public static string GuiPhucKhao(int maDangKy, string lyDo)
        {
            if (string.IsNullOrWhiteSpace(lyDo))
                return "Vui lòng nhập lý do phúc khảo!";

            try
            {
                DAL.PhucKhaoSvDAL.GuiPhucKhao(maDangKy, lyDo.Trim()); // ✅ gọi DAL
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
