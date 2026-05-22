using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qldsv.BLL;
using qldsv.Class;

namespace qldsv.Forms.Giangvien
{
    public partial class FrmNhapDiem : Form
    {
        public FrmNhapDiem()
        {
            InitializeComponent();
        }

        DataTable tblDiem;
        DataRow heSo;
        string maLHPDangChon = "";

        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
            LoadHocKy();
            SetNutTheoTrangThai(false);
        }
        private void LoadHocKy()
        {
            DataTable dt = Functions.GetDataToTable(@"
                SELECT DISTINCT hk.MaHocKy,
                       hk.TenHocKy + ' - ' + hk.NamHoc AS TenHK
                FROM LopHocPhan lhp
                JOIN HocKy hk ON lhp.MaHocKy = hk.MaHocKy
                WHERE lhp.MaGiangVien = @maGV
                ORDER BY hk.MaHocKy DESC",
                new { maGV = CurrentUser.MaDoiTuong });

            cboHocKy.DisplayMember = "TenHK";   // ← TRƯỚC
            cboHocKy.ValueMember = "MaHocKy";   // ← TRƯỚC
            cboHocKy.DataSource = dt;            // ← SAU
            cboHocKy.SelectedIndex = -1;
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedValue == null) return;
            LoadLopHP();
        }
        private void LoadLopHP()
        {
            if (cboHocKy.SelectedValue == null) return;
            int maHK = Convert.ToInt32(cboHocKy.SelectedValue);

            DataTable dt = Functions.GetDataToTable(@"
                SELECT lhp.MaLHP,
                       lhp.MaLHP + ' - ' + mh.TenMon AS TenLHP
                FROM LopHocPhan lhp
                JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                WHERE lhp.MaGiangVien = @maGV
                AND lhp.MaHocKy = @maHK
                ORDER BY lhp.MaLHP",
                new { maGV = CurrentUser.MaDoiTuong, maHK });

            cboLopHP.DisplayMember = "TenLHP";  // ← TRƯỚC
            cboLopHP.ValueMember = "MaLHP";     // ← TRƯỚC
            cboLopHP.DataSource = dt;            // ← SAU
            cboLopHP.SelectedIndex = -1;
        }

        private void cboLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHP.SelectedValue == null) return;
            maLHPDangChon = cboLopHP.SelectedValue.ToString();
            LoadDiem();
        }
        private void LoadDiem()
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            tblDiem = DiemBLL.GetSVVaDiem(maLHPDangChon);
            heSo = DiemBLL.GetHeSo(maLHPDangChon);

            // Thêm cột NguonGoc và DiemChu để dùng nội bộ
            if (!tblDiem.Columns.Contains("NguonGoc"))
                tblDiem.Columns.Add("NguonGoc", typeof(string));
            if (!tblDiem.Columns.Contains("DiemChu"))
                tblDiem.Columns.Add("DiemChu", typeof(string));
            if (!tblDiem.Columns.Contains("STT"))
                tblDiem.Columns.Add("STT", typeof(int));

            // Tính DiemChu và gán STT
            for (int i = 0; i < tblDiem.Rows.Count; i++)
            {
                tblDiem.Rows[i]["STT"] = i + 1;
                tblDiem.Rows[i]["NguonGoc"] = "GiangVien";

                double? tongKet = tblDiem.Rows[i]["TongKet"] == DBNull.Value
                    ? (double?)null
                    : Convert.ToDouble(tblDiem.Rows[i]["TongKet"]);
                tblDiem.Rows[i]["DiemChu"] = DiemBLL.XepDiemChu(tongKet);
            }

            dgvNhapDiem.AutoGenerateColumns = false;
            colMaDangKy.DataPropertyName = "MaDangKy";
            colSTT.DataPropertyName = "STT";
            colMSSV.DataPropertyName = "MaSinhVien";
            colHoTen.DataPropertyName = "HoTen";
            colCC.DataPropertyName = "ChuyenCan";
            colKT1.DataPropertyName = "Kiemtra1";
            colKT2.DataPropertyName = "Kiemtra2";
            colCK.DataPropertyName = "CuoiKy";
            colTongKet.DataPropertyName = "TongKet";
            colDiemChu.DataPropertyName = "DiemChu";

            dgvNhapDiem.DataSource = tblDiem;
            dgvNhapDiem.AllowUserToAddRows = false;

            // Kiểm tra đã xác nhận chưa để lock/unlock
            bool daXacNhan = DiemBLL.DaXacNhan(maLHPDangChon);
            SetNutTheoTrangThai(true);
            SetEditMode(!daXacNhan);

            if (daXacNhan)
                ToCauDong();

            CapNhatThongKe();
        }
        private void SetEditMode(bool coTheNhap)
        {
            colCC.ReadOnly = !coTheNhap;
            colKT1.ReadOnly = !coTheNhap;
            colKT2.ReadOnly = !coTheNhap;
            colCK.ReadOnly = !coTheNhap;
            colTongKet.ReadOnly = true;
            colDiemChu.ReadOnly = true;
            colSTT.ReadOnly = true;
            colMSSV.ReadOnly = true;
            colHoTen.ReadOnly = true;
            colMaDangKy.ReadOnly = true;

            btnLuuTam.Enabled = coTheNhap;
            btnXacNhan.Enabled = coTheNhap;
            btnImport.Enabled = coTheNhap;
            dgvNhapDiem.EditMode = coTheNhap
                ? DataGridViewEditMode.EditOnKeystrokeOrF2
                : DataGridViewEditMode.EditProgrammatically;
        }
        private void SetNutTheoTrangThai(bool daChonLHP)
        {
            btnLuuTam.Enabled = daChonLHP;
            btnXacNhan.Enabled = daChonLHP;
            btnImport.Enabled = daChonLHP;
            btnExport.Enabled = daChonLHP;
            btnTaiMau.Enabled = daChonLHP;
        }

        private void ToCauDong()
        {
            foreach (DataGridViewRow row in dgvNhapDiem.Rows)
            {
                string diemChu = row.Cells["colDiemChu"].Value?.ToString() ?? "";
                if (diemChu == "F" || diemChu == "")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                else if (diemChu == "A+" || diemChu == "A")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220);
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void CapNhatThongKe()
        {
            if (tblDiem == null) return;
            int tong = tblDiem.Rows.Count;
            int daNhap = 0;
            foreach (DataRow row in tblDiem.Rows)
                if (row["TongKet"] != DBNull.Value) daNhap++;
            int conThieu = tong - daNhap;
            lblThongKe.Text = $"Tổng SV: {tong}  |  Đã nhập: {daNhap}  |  Còn thiếu: {conThieu}";
        }

        private void dgvNhapDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (heSo == null) return;

            var row = dgvNhapDiem.Rows[e.RowIndex];

            // Validate giá trị vừa nhập
            string tenCot = dgvNhapDiem.Columns[e.ColumnIndex].Name;
            string giaTriMoi = row.Cells[e.ColumnIndex].Value?.ToString() ?? "";
            string loi = DiemBLL.ValidateDiem(giaTriMoi, tenCot);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells[e.ColumnIndex].Value = null;
                return;
            }

            // Lấy 4 giá trị điểm
            double? cc = ParseCell(row.Cells["colCC"].Value);
            double? kt1 = ParseCell(row.Cells["colKT1"].Value);
            double? kt2 = ParseCell(row.Cells["colKT2"].Value);
            double? ck = ParseCell(row.Cells["colCK"].Value);

            // Tính TongKet + DiemChu
            double? tongKet = DiemBLL.TinhTongKet(cc, kt1, kt2, ck, heSo);
            row.Cells["colTongKet"].Value = tongKet.HasValue ? (object)Math.Round(tongKet.Value, 2) : DBNull.Value;
            row.Cells["colDiemChu"].Value = DiemBLL.XepDiemChu(tongKet);

            // Cập nhật DataTable gốc
            int maDangKy = Convert.ToInt32(row.Cells["colMaDangKy"].Value);
            foreach (DataRow dr in tblDiem.Rows)
            {
                if (Convert.ToInt32(dr["MaDangKy"]) == maDangKy)
                {
                    dr["ChuyenCan"] = cc.HasValue ? (object)cc.Value : DBNull.Value;
                    dr["Kiemtra1"] = kt1.HasValue ? (object)kt1.Value : DBNull.Value;
                    dr["Kiemtra2"] = kt2.HasValue ? (object)kt2.Value : DBNull.Value;
                    dr["CuoiKy"] = ck.HasValue ? (object)ck.Value : DBNull.Value;
                    dr["TongKet"] = tongKet.HasValue ? (object)tongKet.Value : DBNull.Value;
                    dr["DiemChu"] = DiemBLL.XepDiemChu(tongKet);
                    dr["NguonGoc"] = "GiangVien";
                    break;
                }
            }

            CapNhatThongKe();
        }
        private double? ParseCell(object val)
        {
            if (val == null || val == DBNull.Value) return null;
            if (double.TryParse(val.ToString(), out double d)) return d;
            return null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tblDiem == null) return;
            string kw = txtSearch.Text.Trim().Replace("'", "''");
            DataView dv = tblDiem.DefaultView;
            dv.RowFilter = string.IsNullOrEmpty(kw) ? "" :
                $"MaSinhVien LIKE '%{kw}%' OR HoTen LIKE '%{kw}%'";
            dgvNhapDiem.DataSource = dv.ToTable();
            foreach (DataGridViewColumn col in dgvNhapDiem.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvNhapDiem.Rows.Count == 0 &&
                    !string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            string loi = DiemBLL.LuuTam(tblDiem, maLHPDangChon, heSo);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Lưu tạm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDiem();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            // Đếm SV chưa có điểm
            int soSVChuaNhap = 0;
            foreach (DataRow row in tblDiem.Rows)
                if (row["TongKet"] == DBNull.Value) soSVChuaNhap++;

            if (soSVChuaNhap > 0)
            {
                DialogResult rs = MessageBox.Show(
                    $"Còn {soSVChuaNhap} sinh viên chưa có điểm.\nVẫn xác nhận?",
                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs != DialogResult.Yes) return;
            }

            DialogResult confirm = MessageBox.Show(
                "Sau khi xác nhận sẽ KHÔNG thể sửa điểm!\nBạn chắc chắn?",
                "Xác nhận điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            // Lưu tạm trước rồi mới xác nhận
            DiemBLL.LuuTam(tblDiem, maLHPDangChon, heSo);
            DiemBLL.XacNhanForce(maLHPDangChon);

            MessageBox.Show("Xác nhận điểm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDiem();
        }

        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xlsx";
                sfd.FileName = $"Mau_Diem_{maLHPDangChon}.xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                DiemBLL.TaiMauExcel(maLHPDangChon, sfd.FileName);
                MessageBox.Show("Tải mẫu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xlsx";
                sfd.FileName = $"Diem_{maLHPDangChon}.xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                DiemBLL.ExportExcel(maLHPDangChon, sfd.FileName);
                MessageBox.Show("Export thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLHPDangChon)) return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel|*.xlsx;*.xls";
                ofd.Title = "Chọn file điểm";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                var ketQua = DiemBLL.ImportExcel(ofd.FileName);
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không đọc được dữ liệu từ file!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Điền vào DataTable + dgv
                int soDienDuoc = 0;
                foreach (DataRow row in tblDiem.Rows)
                {
                    string maSV = row["MaSinhVien"].ToString();
                    if (!ketQua.ContainsKey(maSV)) continue;

                    double?[] diem = ketQua[maSV];
                    row["ChuyenCan"] = diem[0].HasValue ? (object)diem[0].Value : DBNull.Value;
                    row["Kiemtra1"] = diem[1].HasValue ? (object)diem[1].Value : DBNull.Value;
                    row["Kiemtra2"] = diem[2].HasValue ? (object)diem[2].Value : DBNull.Value;
                    row["CuoiKy"] = diem[3].HasValue ? (object)diem[3].Value : DBNull.Value;
                    row["NguonGoc"] = "GiangVien";

                    double? tongKet = DiemBLL.TinhTongKet(diem[0], diem[1], diem[2], diem[3], heSo);
                    row["TongKet"] = tongKet.HasValue ? (object)tongKet.Value : DBNull.Value;
                    row["DiemChu"] = DiemBLL.XepDiemChu(tongKet);

                    soDienDuoc++;
                }

                // Refresh dgv
                dgvNhapDiem.DataSource = null;
                dgvNhapDiem.DataSource = tblDiem;

                CapNhatThongKe();
                MessageBox.Show($"Import thành công {soDienDuoc} sinh viên!\nKiểm tra lại rồi bấm Lưu tạm.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
