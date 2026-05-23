using qldsv.BLL;
using qldsv.Class;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace qldsv.Forms.Sinhvien
{
    public partial class FrmLichHoc : Form
    {
        private DataTable _dtLichHoc = new DataTable();

        public FrmLichHoc()
        {
            InitializeComponent();
            dgvLichHoc.CellFormatting += dgvLichHoc_CellFormatting;
            cboSapXep.SelectedIndexChanged += cboSapXep_SelectedIndexChanged;
            cboLocThu.SelectedIndexChanged += cboLocThu_SelectedIndexChanged;
            cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged;
            LoadThongTinSV();
            LoadHocKy();
            InitCboSapXep();
            InitCboLocThu();
        }

        // ─── Khởi tạo combo ──────────────────────────────────────────

        private void InitCboSapXep()
        {
            cboSapXep.Items.Clear();
            cboSapXep.Items.Add("Môn học");
            cboSapXep.Items.Add("Thứ - Tiết");
            cboSapXep.SelectedIndex = 0;
        }

        private void InitCboLocThu()
        {
            cboLocThu.Items.Clear();
            cboLocThu.Items.Add("Tất cả");
            cboLocThu.Items.Add("Thứ 2");
            cboLocThu.Items.Add("Thứ 3");
            cboLocThu.Items.Add("Thứ 4");
            cboLocThu.Items.Add("Thứ 5");
            cboLocThu.Items.Add("Thứ 6");
            cboLocThu.Items.Add("Thứ 7");
            cboLocThu.Items.Add("Chủ nhật");
            cboLocThu.SelectedIndex = 0;
        }

        // ─── Load thông tin SV ───────────────────────────────────────

        private void LoadThongTinSV()
        {
            try
            {
                DataTable dt = LichHocBLL.GetThongTinSV(CurrentUser.MaDoiTuong);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    lblMSSV.Text = "MSSV: " + r["MaSinhVien"];
                    lblHoTen.Text = "Họ và tên: " + r["HoTen"];
                    lblLop.Text = "Lớp: " + r["TenLop"];
                }
                else
                {
                    lblMSSV.Text = "MSSV: " + CurrentUser.MaDoiTuong;
                    lblHoTen.Text = "Họ và tên: (không tìm thấy)";
                    lblLop.Text = "Lớp: ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin SV: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Load học kỳ ────────────────────────────────────────────

        private void LoadHocKy()
        {
            try
            {
                DataTable dt = LichHocBLL.GetAllHocKy();
                cboHocKy.DataSource = dt;
                cboHocKy.DisplayMember = "TenHK";
                cboHocKy.ValueMember = "MaHocKy";
                cboHocKy.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load học kỳ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Load datagrid ───────────────────────────────────────────

        private void Load_DgvLichHoc(int maHocKy)
        {
            DataTable dt = LichHocBLL.GetLichHoc(CurrentUser.MaDoiTuong, maHocKy);
            _dtLichHoc = dt ?? new DataTable();

            dgvLichHoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvLichHoc.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            // reset lọc thứ về "Tất cả" mà không trigger event
            cboLocThu.SelectedIndexChanged -= cboLocThu_SelectedIndexChanged;
            cboLocThu.SelectedIndex = 0;
            cboLocThu.SelectedIndexChanged += cboLocThu_SelectedIndexChanged;

            ApplyFilterAndSort();

            if (_dtLichHoc.Rows.Count == 0)
                MessageBox.Show("Bạn không có lịch học trong " + cboHocKy.Text,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── Lọc & sắp xếp ──────────────────────────────────────────

        private void ApplyFilterAndSort()
        {
            if (_dtLichHoc == null || _dtLichHoc.Columns.Count == 0) return;

            dgvLichHoc.CellFormatting -= dgvLichHoc_CellFormatting;
            try
            {
                string locThu = cboLocThu.SelectedItem?.ToString();

                // Bước 1: lọc theo thứ
                DataTable filtered;
                if (string.IsNullOrEmpty(locThu) || locThu == "Tất cả")
                    filtered = _dtLichHoc.Copy();
                else
                {
                    var rows = _dtLichHoc.AsEnumerable()
                                         .Where(r => r["TenThu"]?.ToString() == locThu);
                    filtered = rows.Any() ? rows.CopyToDataTable() : _dtLichHoc.Clone();
                }

                // Bước 2: sắp xếp
                string sortExpr = "";
                switch (cboSapXep.SelectedItem?.ToString())
                {
                    case "Môn học": sortExpr = "TenMon ASC"; break;
                    case "Thứ - Tiết": sortExpr = "TenThu ASC, TenCa ASC"; break;
                }

                DataTable result;
                if (!string.IsNullOrEmpty(sortExpr) && filtered.Rows.Count > 0)
                {
                    DataView dv = new DataView(filtered) { Sort = sortExpr };
                    result = dv.ToTable();
                }
                else
                    result = filtered;

                // Bước 3: bind
                dgvLichHoc.DataSource = null;
                dgvLichHoc.AutoGenerateColumns = false;

                colThu.DataPropertyName = "TenThu";
                colCaHoc.DataPropertyName = "TenCa";
                colMaHP.DataPropertyName = "MaLHP";
                colTenMon.DataPropertyName = "TenMon";
                colPhong.DataPropertyName = "TenPhong";
                colGiangVien.DataPropertyName = "GiangVien";
                colNgayBD.DataPropertyName = "NgayBatDau";
                colNgayKT.DataPropertyName = "NgayKetThuc";

                dgvLichHoc.DataSource = result;
                dgvLichHoc.AllowUserToAddRows = false;
            }
            finally
            {
                dgvLichHoc.CellFormatting += dgvLichHoc_CellFormatting;
                dgvLichHoc.Invalidate();
            }
        }

        // ─── Sự kiện combo ──────────────────────────────────────────

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedIndex < 0 || cboHocKy.SelectedValue == null) return;
            if (!int.TryParse(cboHocKy.SelectedValue.ToString(), out int maHocKy)) return;
            Load_DgvLichHoc(maHocKy);
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
            => ApplyFilterAndSort();

        private void cboLocThu_SelectedIndexChanged(object sender, EventArgs e)
            => ApplyFilterAndSort();

        private void FrmLichHoc_Load(object sender, EventArgs e) { }

        // ─── Tô màu theo thứ ─────────────────────────────────────────

        private void dgvLichHoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!dgvLichHoc.Columns.Contains("colThu")) return;
            object val = dgvLichHoc.Rows[e.RowIndex].Cells["colThu"].Value;
            if (val == null || val == DBNull.Value) return;

            string thu = val.ToString();
            Color mau;
            switch (thu)
            {
                case "Thứ 2": mau = Color.FromArgb(232, 240, 255); break; // xanh nhạt
                case "Thứ 3": mau = Color.FromArgb(255, 248, 220); break; // vàng nhạt
                case "Thứ 4": mau = Color.FromArgb(232, 255, 240); break; // xanh lá nhạt
                case "Thứ 5": mau = Color.FromArgb(255, 235, 235); break; // hồng nhạt
                case "Thứ 6": mau = Color.FromArgb(242, 232, 255); break; // tím nhạt
                case "Thứ 7": mau = Color.FromArgb(255, 243, 224); break; // cam nhạt
                case "Chủ nhật": mau = Color.FromArgb(224, 255, 255); break; // cyan nhạt
                default: mau = Color.White; break;
            }
            dgvLichHoc.Rows[e.RowIndex].DefaultCellStyle.BackColor = mau;
        }
    }
}