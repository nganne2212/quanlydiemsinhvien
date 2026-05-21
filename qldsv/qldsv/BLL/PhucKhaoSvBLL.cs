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
                Functions.Execute(@"
            INSERT INTO PhucKhao (MaPhucKhao, MaDangKy, LyDo, NgayGui, TrangThai)
            VALUES (
                (SELECT ISNULL(MAX(MaPhucKhao), 0) + 1 FROM PhucKhao),
                @maDangKy, @lyDo, CAST(GETDATE() AS date), N'ChuaXuLy'
            )",
                    new { maDangKy, lyDo });

                return ""; // thành công
            }
            catch (Exception ex)
            {
                return ex.Message; // lỗi
            }
        }
    }
}
