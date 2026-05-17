using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    class QLGiangvienBLL
    {
        public static DataTable GetAll() => DAL.QLGiangvienDAL.GetAll();

        public static string Them(string maGV, string hoTen, string email, string maKhoa)
        {
            if (string.IsNullOrWhiteSpace(maGV)) return "Vui long nhap ma giang vien";
            if (string.IsNullOrWhiteSpace(hoTen)) return "Vui long nhap ho ten";
            if (string.IsNullOrWhiteSpace(email)) return "Vui long nhap email";
            if (string.IsNullOrWhiteSpace(maKhoa)) return "Vui long chon khoa";
            if (DAL.QLGiangvienDAL.KiemTraTrung(maGV.Trim()))
                return "Ma giang vien da ton tai";
            if (!Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email khong hop le";

            DAL.QLGiangvienDAL.Them(maGV.Trim(), hoTen.Trim(), email.Trim(), maKhoa);
            return "";
        }

        public static string Sua(string maGV, string hoTen, string email, string maKhoa)
        {
            if (string.IsNullOrWhiteSpace(hoTen)) return "Vui long nhap ho ten";
            if (string.IsNullOrWhiteSpace(email)) return "Vui long nhap email";
            if (string.IsNullOrWhiteSpace(maKhoa)) return "Vui long chon khoa";
            if (!Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email khong hop le";

            DAL.QLGiangvienDAL.Sua(maGV.Trim(), hoTen.Trim(), email.Trim(), maKhoa);
            return "";
        }

        public static string Xoa(string maGV)
        {
            if (string.IsNullOrWhiteSpace(maGV))
                return "Vui long chon giang vien can xoa";
            if (DAL.QLGiangvienDAL.DangChuNhiemLop(maGV))
                return "Giang vien dang la chu nhiem lop, khong the xoa!";
            if (DAL.QLGiangvienDAL.DangDayHocPhan(maGV))
                return "Giang vien dang day hoc phan, khong the xoa!";
            if (DAL.QLGiangvienDAL.DangXuLyPhucKhao(maGV))
                return "Giang vien co ket qua phuc khao, khong the xoa!";

            DAL.QLGiangvienDAL.Xoa(maGV);
            return "";
        }
    }
}
