using qldsv.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qldsv.Forms.Giangvien
{
    public partial class FrmDanhSachLHP : Form
    {
        private DataTable _tblGoc;
        public FrmDanhSachLHP()
        {
            InitializeComponent();
        }
        private void FrmDanhSachLHP_Load(object sender, EventArgs e)
        {
            // Cột STT tự đếm
            dgvLopHocPhan.CellFormatting += (s, ev) => {
                if (ev.ColumnIndex == colSTT.Index && ev.RowIndex >= 0)
                    ev.Value = ev.RowIndex + 1;
            };

            LoadHocKy();
            LoadThuHoc();
            LoadDanhSach();

            cboHocKy.SelectedIndexChanged += (s, ev) => LocDanhSach();
            cboThuHoc.SelectedIndexChanged += (s, ev) => LocDanhSach();
            txtSearch.TextChanged += (s, ev) => LocDanhSach();
        }

        
        private void LoadHocKy()
        {
            DataTable dt = BLL.DSLHocPhanBLL.GetHocKyByGiangVien(CurrentUser.MaDoiTuong);

           
            DataRow rowAll = dt.NewRow();
            rowAll["MaHocKy"] = -1;
            rowAll["TenHocKy"] = "-- Tất cả học kỳ --";
            dt.Rows.InsertAt(rowAll, 0);

            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = 0;
        }

        private void LoadThuHoc()
        {
            cboThuHoc.Items.Clear();
            cboThuHoc.Items.Add("-- Tất cả thứ --");
            for (int thu = 2; thu <= 7; thu++)
                cboThuHoc.Items.Add("Thứ " + thu);

            cboThuHoc.SelectedIndex = 0;
        }

        
        private void LoadDanhSach()
        {
            _tblGoc = BLL.DSLHocPhanBLL.GetByGiangVien(CurrentUser.MaDoiTuong);

            CauHinhCot();
            HienThiDuLieu(_tblGoc);
        }

       
        private void CauHinhCot()
        {
            dgvLopHocPhan.AutoGenerateColumns = false;

            colMaLHP.DataPropertyName = "MaLHP";
            colTenMonHoc.DataPropertyName = "TenMonHoc";
            colSoTinChi.DataPropertyName = "SoTinChi";
            colThuHoc.DataPropertyName = "ThuHoc";
            colPhongHoc.DataPropertyName = "PhongHoc";
            colSiSo.DataPropertyName = "SiSo";

            dgvLopHocPhan.AllowUserToAddRows = false;
            dgvLopHocPhan.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvLopHocPhan.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        
        private void HienThiDuLieu(DataTable dt)
        {
            dgvLopHocPhan.DataSource = dt;

            
            for (int i = 0; i < dgvLopHocPhan.Rows.Count; i++)
                dgvLopHocPhan.Rows[i].Cells["colSTT"].Value = i + 1;

            
            bool coData = dt != null && dt.Rows.Count > 0;
            lblEmpty.Visible = !coData;
            dgvLopHocPhan.Visible = coData;

            
            lblThongKe.Text = $"Tổng lớp học phần: {(coData ? dt.Rows.Count : 0)}";
        }


        private void LocDanhSach()
        {
            if (_tblGoc == null) return;

            // ✅ Kiểm tra -1 thay vì DBNull hay ""
            object selectedVal = cboHocKy.SelectedValue;
            string maHocKy = (selectedVal != null && selectedVal.ToString() != "-1")
                             ? selectedVal.ToString() : "";

            string thuChon = cboThuHoc.SelectedIndex > 0
                                  ? (cboThuHoc.SelectedIndex + 1).ToString()
                                  : "";
            string keyword = txtSearch.Text.Trim().Replace("'", "''");

            string filter = "";

            if (!string.IsNullOrEmpty(maHocKy))
                filter = AppendFilter(filter, $"MaHocKy = {maHocKy}"); // không cần nháy đơn vì Int

            if (!string.IsNullOrEmpty(thuChon))
                filter = AppendFilter(filter, $"ThuHoc = {thuChon}");

            if (!string.IsNullOrEmpty(keyword))
                filter = AppendFilter(filter,
                    $"(MaLHP LIKE '%{keyword}%' OR TenMonHoc LIKE '%{keyword}%' OR PhongHoc LIKE '%{keyword}%')");

            DataView dv = _tblGoc.DefaultView;
            dv.RowFilter = filter;

            HienThiDuLieu(dv.ToTable());
        }


        private static string AppendFilter(string current, string condition)
            => string.IsNullOrEmpty(current) ? condition : $"({current}) AND ({condition})";
    }
}
