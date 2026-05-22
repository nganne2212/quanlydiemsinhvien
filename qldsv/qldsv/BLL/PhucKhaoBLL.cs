using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qldsv.DAL;
using System.Data;

namespace qldsv.BLL
{
    public class PhucKhaoBLL
    {
        public static DataTable GetAll(int maHocKy = 0, string trangThai = "")
        {
            return PhucKhaoDAL.GetAll(maHocKy, trangThai);
        }

        public static DataTable GetHocKyCoDon()
        {
            return PhucKhaoDAL.GetHocKyCoDon();
        }

        public static string XuLy(int maPhucKhao, int maDangKy, string maGiangVien,
                                  double diemCu, double diemMoi,
                                  string nhanXet, string ketLuan, string ngayXuLy)
        {
            // Validate
            if (string.IsNullOrEmpty(ketLuan))
                return "Vui lòng chọn kết luận!";

            if (ketLuan == "Thay Đổi")
            {
                if (diemMoi < 0 || diemMoi > 10)
                    return "Điểm mới phải nằm trong khoảng 0 - 10!";
            }

            PhucKhaoDAL.XuLy(maPhucKhao, maDangKy, maGiangVien,
                              diemCu, diemMoi, nhanXet, ketLuan, ngayXuLy);
            return "";
        }
    }
}
