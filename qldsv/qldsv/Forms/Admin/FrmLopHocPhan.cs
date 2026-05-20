using qldsv.BLL;
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

namespace qldsv.Forms.Admin
{
    public partial class FrmLopHocPhan : Form
    {
        public FrmLopHocPhan()
        {
            InitializeComponent();
        }
        DataTable tblLHP;
        DataTable tblSVTrongLHP;
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string maLHP = GetMaLHPDangChon();
            if (string.IsNullOrEmpty(maLHP))
            {
                MessageBox.Show("Vui lòng chọn lớp học phần trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmChonSinhVien frmChon = new FrmChonSinhVien(maLHP);
            if (frmChon.ShowDialog() == DialogResult.OK)
            {
                Load_DgvSinhVien(maLHP);
                Load_DgvLHP(); // Cập nhật lại số SV
            }
        }

        private void FrmLopHocPhan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaLHP.Enabled = false;

            btnThemSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnImportExcel.Enabled = false;

            LoadMonHoc();
            LoadGiangVien();
            LoadHocKy();
            Load_DgvLHP();
        }
        private void LoadMonHoc()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaMonHoc, TenMon FROM MonHoc ORDER BY TenMon");
            cboMonHoc.DataSource = dt;
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MaMonHoc";
            cboMonHoc.SelectedIndex = -1;
        }

        private void LoadGiangVien()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaGiangVien, HoTen FROM GiangVien ORDER BY HoTen");
            cboGiangVien.DataSource = dt;
            cboGiangVien.DisplayMember = "HoTen";
            cboGiangVien.ValueMember = "MaGiangVien";
            cboGiangVien.SelectedIndex = -1;
        }

        private void LoadHocKy()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaHocKy, TenHocKy + ' - ' + NamHoc AS TenHK FROM HocKy ORDER BY MaHocKy DESC");
            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = -1;
        }

        private void Load_DgvLHP()
        {
            tblLHP = LopHocPhanBLL.GetAll();
            dgvLopHocPhan.AutoGenerateColumns = false;

            colMaLHP.DataPropertyName = "MaLHP";
            colMonHoc.DataPropertyName = "TenMon";
            colGiangVien.DataPropertyName = "HoTen";
            colHocKy.DataPropertyName = "TenHK";
            colSoSV.DataPropertyName = "SiSo";

            dgvLopHocPhan.DataSource = tblLHP;
            dgvLopHocPhan.AllowUserToAddRows = false;
            dgvLopHocPhan.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvLopHocPhan.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Xóa danh sách SV khi load lại LHP
            dgvSinhVien.DataSource = null;
            tblSVTrongLHP = null;

            btnThemSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnImportExcel.Enabled = false;
        }
        private void Load_DgvSinhVien(string maLHP)
        {
            tblSVTrongLHP = LopHocPhanBLL.GetSVTrongLHP(maLHP);
            dgvSinhVien.AutoGenerateColumns = false;

            colMSSV.DataPropertyName = "MaSinhVien";
            colHoTen.DataPropertyName = "HoTen";
            colLop.DataPropertyName = "TenLop";
            colEmail.DataPropertyName = "Email";

            dgvSinhVien.DataSource = tblSVTrongLHP;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvSinhVien.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ResetValues()
        {
            txtMaLHP.Text = "";
            cboMonHoc.SelectedIndex = -1;
            cboGiangVien.SelectedIndex = -1;
            cboHocKy.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now.AddMonths(4);
        }
        private void SetButtonsDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaLHP.Enabled = false;
        }
        private string GetMaLHPDangChon()
        {
            if (dgvLopHocPhan.CurrentRow == null) return "";
            return dgvLopHocPhan.CurrentRow.Cells["colMaLHP"].Value?.ToString() ?? "";
        }


        private void dgvLopHocPhan_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLHP.Focus();
                return;
            }
            if (tblLHP == null || tblLHP.Rows.Count == 0) return;
            if (dgvLopHocPhan.CurrentRow == null) return;

            // Điền thông tin LHP lên form trái
            string maLHP = dgvLopHocPhan.CurrentRow.Cells["colMaLHP"].Value.ToString();
            txtMaLHP.Text = maLHP;

            string maMonHoc = Functions.GetFieldValues(
                "SELECT MaMonHoc FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP });
            cboMonHoc.SelectedValue = maMonHoc;

            string maGV = Functions.GetFieldValues(
                "SELECT MaGiangVien FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP });
            cboGiangVien.SelectedValue = maGV;

            string maHK = Functions.GetFieldValues(
                "SELECT MaHocKy FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP });
            if (int.TryParse(maHK, out int maHKInt))
                cboHocKy.SelectedValue = maHKInt;

            string ngayBD = Functions.GetFieldValues(
                "SELECT CONVERT(varchar, NgayBatDau, 23) FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP });
            if (DateTime.TryParse(ngayBD, out DateTime dtBD))
                dtpNgayBatDau.Value = dtBD;

            string ngayKT = Functions.GetFieldValues(
                "SELECT CONVERT(varchar, NgayKetThuc, 23) FROM LopHocPhan WHERE MaLHP = @ma",
                new { ma = maLHP });
            if (DateTime.TryParse(ngayKT, out DateTime dtKT))
                dtpNgayKetThuc.Value = dtKT;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;

            // Load danh sách SV của LHP này
            Load_DgvSinhVien(maLHP);

            btnThemSV.Enabled = true;
            btnXoaSV.Enabled = true;
            btnImportExcel.Enabled = true;
        }

        private void txtSearchLHP_TextChanged(object sender, EventArgs e)
        {
            LocLHP();
        }
        private void LocLHP()
        {
            if (tblLHP == null) return;
            string kw = txtSearchLHP.Text.Trim().Replace("'", "''");
            DataView dv = tblLHP.DefaultView;
            if (string.IsNullOrEmpty(kw))
                dv.RowFilter = "";
            else
                dv.RowFilter = $"MaLHP LIKE '%{kw}%' OR TenMon LIKE '%{kw}%' " +
                               $"OR HoTen LIKE '%{kw}%' OR TenHK LIKE '%{kw}%'";
            dgvLopHocPhan.DataSource = dv.ToTable();
        }

        private void txtSearchLHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvLopHocPhan.Rows.Count == 0 &&
                    !string.IsNullOrEmpty(txtSearchLHP.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy lớp học phần nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            LocSV();
        }
        private void LocSV()
        {
            if (tblSVTrongLHP == null) return;
            string kw = txtSearchSV.Text.Trim().Replace("'", "''");
            DataView dv = tblSVTrongLHP.DefaultView;
            if (string.IsNullOrEmpty(kw))
                dv.RowFilter = "";
            else
                dv.RowFilter = $"MaSinhVien LIKE '%{kw}%' OR HoTen LIKE '%{kw}%'";
            dgvSinhVien.DataSource = dv.ToTable();
        }

        private void txtSearchSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSinhVien.Rows.Count == 0 &&
                    !string.IsNullOrEmpty(txtSearchSV.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaLHP.Enabled = true;
            ResetValues();
            txtMaLHP.Focus();

            // Tắt nút SV khi đang thêm LHP mới
            btnThemSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnImportExcel.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblLHP == null || tblLHP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLHP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp học phần cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaLHP.Enabled = false;
            cboMonHoc.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvLopHocPhan.ClearSelection();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaLHP.Enabled = false;

            btnThemSV.Enabled = false;
            btnXoaSV.Enabled = false;
            btnImportExcel.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLHP = txtMaLHP.Text.Trim();
            string maMonHoc = cboMonHoc.SelectedValue?.ToString() ?? "";
            string maGV = cboGiangVien.SelectedValue?.ToString() ?? "";
            string maHKStr = cboHocKy.SelectedValue?.ToString() ?? "";
            DateTime ngayBD = dtpNgayBatDau.Value.Date;
            DateTime ngayKT = dtpNgayKetThuc.Value.Date;

            string loi;
            if (txtMaLHP.Enabled) // Thêm mới
                loi = LopHocPhanBLL.Them(maLHP, maMonHoc, maGV, maHKStr, ngayBD, ngayKT);
            else                  // Sửa
                loi = LopHocPhanBLL.Sua(maLHP, maMonHoc, maGV, maHKStr, ngayBD, ngayKT);

            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(txtMaLHP.Enabled ? "Thêm lớp học phần thành công!" : "Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DgvLHP();
            ResetValues();
            SetButtonsDefault();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblLHP == null || tblLHP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLHP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp học phần cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLHP = txtMaLHP.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                "Xác nhận xóa lớp học phần [" + maLHP + "]?\nToàn bộ đăng ký học phần liên quan cũng sẽ bị xóa!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string loi = LopHocPhanBLL.Xoa(maLHP);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa lớp học phần thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DgvLHP();
            ResetValues();
            SetButtonsDefault();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string maLHP = GetMaLHPDangChon();
            if (string.IsNullOrEmpty(maLHP)) return;

            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa khỏi lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = dgvSinhVien.CurrentRow.Cells["colMSSV"].Value.ToString();
            string hoTen = dgvSinhVien.CurrentRow.Cells["colHoTen"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Xóa sinh viên [" + maSV + "] " + hoTen + " khỏi lớp học phần [" + maLHP + "]?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string loi = LopHocPhanBLL.XoaSVKhoiLHP(maSV, maLHP);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã xóa sinh viên khỏi lớp học phần!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DgvSinhVien(maLHP);
            Load_DgvLHP();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            string maLHP = GetMaLHPDangChon();
            if (string.IsNullOrEmpty(maLHP))
            {
                MessageBox.Show("Vui lòng chọn lớp học phần trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Chọn file danh sách sinh viên";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                var ketQua = LopHocPhanBLL.ValidateImportExcel(ofd.FileName, maLHP);

                FrmPreviewImport frmPreview = new FrmPreviewImport(ketQua, maLHP);
                if (frmPreview.ShowDialog() == DialogResult.OK)
                {
                    Load_DgvSinhVien(maLHP);
                    Load_DgvLHP();
                }
            }
        }
    }
}
