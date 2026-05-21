using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    internal class DSLHocPhanBLL
    {
        
        public static DataTable GetByGiangVien(string maGV)
            => DAL.DSLHocPhanDAL.GetByGiangVien(maGV);

        
        public static DataTable GetHocKyByGiangVien(string maGV)
            => DAL.DSLHocPhanDAL.GetHocKyByGiangVien(maGV);
    }
}
