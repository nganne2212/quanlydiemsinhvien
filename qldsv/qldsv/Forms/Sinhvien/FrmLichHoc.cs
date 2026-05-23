using qldsv.BLL;
using qldsv.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace qldsv.Forms.Sinhvien
{
    public partial class FrmLichHoc : Form
    {
        public FrmLichHoc()
        {
            InitializeComponent();
            btnXem.Click += btnXem_Click;
            dgvLichHoc.CellFormatting += dgvLichHoc_CellFormatting;
            LoadThongTinSV();
            LoadHocKy();
        }

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

        private void Load_DgvLichHoc(int maHocKy)
        {
            dgvLichHoc.AutoGenerateColumns = false;
            colThu.DataPropertyName = "TenThu";
            colCaHoc.DataPropertyName = "TenCa";
            colMaHP.DataPropertyName = "MaLHP";
            colTenMon.DataPropertyName = "TenMon";
            colPhong.DataPropertyName = "TenPhong";
            colGiangVien.DataPropertyName = "GiangVien";
            colNgayBD.DataPropertyName = "NgayBatDau";
            colNgayKT.DataPropertyName = "NgayKetThuc";

            DataTable dt = LichHocBLL.GetLichHoc(CurrentUser.MaDoiTuong, maHocKy);
            dgvLichHoc.DataSource = dt;
            dgvLichHoc.AllowUserToAddRows = false;
            dgvLichHoc.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvLichHoc.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            if (dt == null || dt.Rows.Count == 0)
                MessageBox.Show("Bạn không có lịch học trong " + cboHocKy.Text,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedIndex < 0 || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ trước khi xem lịch!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cboHocKy.SelectedValue.ToString(), out int maHocKy))
                return;
            Load_DgvLichHoc(maHocKy);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e) { }
        private void FrmLichHoc_Load(object sender, EventArgs e) { }

        private void dgvLichHoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string tenMon = dgvLichHoc.Rows[e.RowIndex]
                                      .Cells["colTenMon"].Value?.ToString() ?? "";
            int hash = Math.Abs(tenMon.GetHashCode()) % 5;
            Color[] palette =
            {
                Color.FromArgb(232, 240, 255),
                Color.FromArgb(232, 255, 240),
                Color.FromArgb(255, 248, 220),
                Color.FromArgb(255, 235, 235),
                Color.FromArgb(242, 232, 255),
            };
            dgvLichHoc.Rows[e.RowIndex].DefaultCellStyle.BackColor = palette[hash];
        }
    }
}