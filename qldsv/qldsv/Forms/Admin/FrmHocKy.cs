using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using qldsv.BLL;

namespace qldsv.Forms.Admin
{
    public partial class FrmHocKy : Form
    {
        private bool dangSua = false;

        public FrmHocKy()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════
        //  LOAD
        // ════════════════════════════════════════════════════════


        private void LoadData()
        {
            DataTable dt = HocKyBLL.GetAll();

            dt.Columns.Add("STT", typeof(int));
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;

            // Tắt AutoGenerateColumns để không sinh cột tự động trùng với Designer
            dgvQuanlyhocky.AutoGenerateColumns = true;
            dgvQuanlyhocky.DataSource = null;
            dgvQuanlyhocky.Columns.Clear();
            dgvQuanlyhocky.DataSource = dt;

            dgvQuanlyhocky.Columns["MaHocKy"].Visible = false;
            dgvQuanlyhocky.Columns["STT"].DisplayIndex = 0;
            dgvQuanlyhocky.Columns["STT"].Width = 50;
            dgvQuanlyhocky.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvQuanlyhocky.Columns["TenHocKy"].HeaderText = "Tên học kỳ";
            dgvQuanlyhocky.Columns["NamHoc"].HeaderText = "Năm học";
            dgvQuanlyhocky.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvQuanlyhocky.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvQuanlyhocky.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewRow row in dgvQuanlyhocky.Rows)
            {
                string tt = row.Cells["TrangThai"]?.Value?.ToString();
                switch (tt)
                {
                    case "DangDienRa":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220);
                        row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                        break;
                    case "DaKetThuc":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                }
            }

            lblSectionInfo.Text = $"Tổng: {dt.Rows.Count} học kỳ";
        }

        // ════════════════════════════════════════════════════════
        //  SetTrangThaiForm — bật/tắt controls theo trạng thái
        // ════════════════════════════════════════════════════════
        private void SetTrangThaiForm(bool enable)
        {
            txtTenhocky.Enabled = !enable;
            txtNamhoc.Enabled = !enable;
            btnLuu.Enabled = enable;
            btnBoqua.Enabled = enable;

            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
            btnMohocky.Enabled = !enable;
            btnDonghocky.Enabled = !enable;
            dgvQuanlyhocky.Enabled = !enable;
            TxtSearch.Enabled = !enable;
        }

        private void ClearForm()
        {
            txtTenhocky.Text = "";
            txtNamhoc.Text = "";
            txtTenhocky.BackColor = Color.White;
            txtNamhoc.BackColor = Color.White;
        }

        private void FillForm(DataGridViewRow row)
        {
            if (row == null) return;
            txtTenhocky.Text = row.Cells["TenHocKy"]?.Value?.ToString() ?? "";
            txtNamhoc.Text = row.Cells["NamHoc"]?.Value?.ToString() ?? "";
        }

        // ════════════════════════════════════════════════════════
        //  dgv SelectionChanged → FillForm
        // ════════════════════════════════════════════════════════
        private void dgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                FillForm(dgvQuanlyhocky.Rows[e.RowIndex]);
        }

        // ════════════════════════════════════════════════════════
        //  TÌM KIẾM — realtime
        // ════════════════════════════════════════════════════════
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = TxtSearch.Text.Trim().ToLower();
            DataTable dt = HocKyBLL.GetAll();
            DataView dv = dt.DefaultView;

            string filter = $"TenHocKy LIKE '%{keyword}%'"
                          + $" OR NamHoc LIKE '%{keyword}%'"
                          + $" OR TrangThai LIKE '%{keyword}%'"
                          + $" OR CONVERT(MaHocKy, 'System.String') LIKE '%{keyword}%'";

            dv.RowFilter = keyword == "" ? "" : filter;

            DataTable dtFilter = dv.ToTable();
            dtFilter.Columns.Add("STT", typeof(int));
            for (int i = 0; i < dtFilter.Rows.Count; i++)
                dtFilter.Rows[i]["STT"] = i + 1;

            dgvQuanlyhocky.AutoGenerateColumns = true;
            dgvQuanlyhocky.DataSource = null;
            dgvQuanlyhocky.Columns.Clear();
            dgvQuanlyhocky.DataSource = dtFilter;
            dgvQuanlyhocky.Columns["MaHocKy"].Visible = false;
            dgvQuanlyhocky.Columns["STT"].DisplayIndex = 0;
            dgvQuanlyhocky.Columns["STT"].Width = 50;
            dgvQuanlyhocky.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvQuanlyhocky.Columns["TenHocKy"].HeaderText = "Tên học kỳ";
            dgvQuanlyhocky.Columns["NamHoc"].HeaderText = "Năm học";
            dgvQuanlyhocky.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvQuanlyhocky.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvQuanlyhocky.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            lblSectionInfo.Text = $"Tổng: {dtFilter.Rows.Count} học kỳ";
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && !char.IsControl(c) && c != ' ' && c != '-')
            {
                e.Handled = true;
                FlashWarning($"Ký tự '{c}' không được phép trong ô tìm kiếm.");
            }
        }

        // ════════════════════════════════════════════════════════
        //  VALIDATE KÝ TỰ REALTIME KHI GÕ
        // ════════════════════════════════════════════════════════
        private void txtTenhocky_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsControl(c) && Regex.IsMatch(c.ToString(), @"[!@#$%^&*()_+={}\[\]|\\:;""'<>?/~`]"))
            {
                e.Handled = true;
                FlashWarning($"Tên học kỳ không được chứa ký tự '{c}'.");
            }
        }

        private void txtNamhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsControl(c) && !char.IsDigit(c) && c != '-')
            {
                e.Handled = true;
                FlashWarning("Năm học chỉ được nhập số và dấu '-'. VD: 2024-2025.");
            }
        }

        private void txtTenhocky_Leave(object sender, EventArgs e)
        {
            string loi = HocKyBLL.ValidateTenHocKy(txtTenhocky.Text);
            if (loi != "")
            {
                txtTenhocky.BackColor = Color.FromArgb(255, 230, 230);
                MessageBox.Show(loi, "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else txtTenhocky.BackColor = Color.White;
        }

        private void txtNamhoc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamhoc.Text)) return;
            string loi = HocKyBLL.ValidateNamHoc(txtNamhoc.Text);
            if (loi != "")
            {
                txtNamhoc.BackColor = Color.FromArgb(255, 230, 230);
                MessageBox.Show(loi, "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else txtNamhoc.BackColor = Color.White;
        }

        private void txtTenhocky_TextChanged(object sender, EventArgs e) { txtTenhocky.BackColor = Color.White; }
        private void txtNamhoc_TextChanged(object sender, EventArgs e) { txtNamhoc.BackColor = Color.White; }

        // ════════════════════════════════════════════════════════
        //  btnThem → ClearForm + SetTrangThaiForm(true) + dangSua=false
        // ════════════════════════════════════════════════════════
        private void btnThem_Click(object sender, EventArgs e)
        {
            dangSua = false;
            ClearForm();
            SetTrangThaiForm(true);
            txtTenhocky.Focus();
        }

        // ════════════════════════════════════════════════════════
        //  btnSua → FillForm + SetTrangThaiForm(true) + dangSua=true
        // ════════════════════════════════════════════════════════
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dangSua = true;
            FillForm(dgvQuanlyhocky.CurrentRow);
            SetTrangThaiForm(true);
            txtTenhocky.Focus();
        }

        // ════════════════════════════════════════════════════════
        //  btnLuu → BLL.Them/Sua() → LoadData + SetTrangThaiForm(false)
        // ════════════════════════════════════════════════════════
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string loi;

            if (!dangSua)
            {
                loi = HocKyBLL.Them(txtTenhocky.Text, txtNamhoc.Text);
            }
            else
            {
                if (dgvQuanlyhocky.CurrentRow == null) return;
                int maHocKy = Convert.ToInt32(dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value);
                loi = HocKyBLL.Sua(maHocKy, txtTenhocky.Text, txtNamhoc.Text);
            }

            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(dangSua ? "Sửa thành công!" : "Thêm thành công!");
            LoadData();
            ClearForm();
            SetTrangThaiForm(false);
        }

        // ════════════════════════════════════════════════════════
        //  btnXoa → Confirm → BLL.Xoa() → LoadData + ClearForm
        // ════════════════════════════════════════════════════════
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maHocKy = Convert.ToInt32(dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value);

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs != DialogResult.Yes) return;

            string loi = HocKyBLL.Xoa(maHocKy);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa thành công!");
            LoadData();
            ClearForm();
        }

        // ════════════════════════════════════════════════════════
        //  btnBoqua → FillForm/ClearForm + SetTrangThaiForm(false)
        // ════════════════════════════════════════════════════════
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow != null)
                FillForm(dgvQuanlyhocky.CurrentRow);
            else
                ClearForm();

            SetTrangThaiForm(false);
        }

        // ════════════════════════════════════════════════════════
        //  MỞ HỌC KỲ
        // ════════════════════════════════════════════════════════
        private void btnMoHocKy_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maHocKy = Convert.ToInt32(dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value);

            string loi = HocKyBLL.MoHocKy(maHocKy);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Mở học kỳ thành công!");
            LoadData();
        }

        // ════════════════════════════════════════════════════════
        //  ĐÓNG HỌC KỲ
        // ════════════════════════════════════════════════════════
        private void btnDongHocKy_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maHocKy = Convert.ToInt32(dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value);

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn đóng học kỳ này?\n⚠ Sau khi đóng sẽ không thể mở lại.",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rs != DialogResult.Yes) return;

            string loi = HocKyBLL.DongHocKy(maHocKy);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đóng học kỳ thành công!");
            LoadData();
        }

        // ════════════════════════════════════════════════════════
        //  FlashWarning — hiện cảnh báo qua lblSectionInfo
        // ════════════════════════════════════════════════════════
        private Timer _flashTimer;

        private void FlashWarning(string msg)
        {
            lblSectionInfo.Text = "⚠ " + msg;
            lblSectionInfo.ForeColor = Color.OrangeRed;

            _flashTimer?.Stop();
            _flashTimer?.Dispose();
            _flashTimer = new Timer { Interval = 2500 };
            _flashTimer.Tick += (s, ev) =>
            {
                lblSectionInfo.Text = $"Tổng: {dgvQuanlyhocky.Rows.Count} học kỳ";
                lblSectionInfo.ForeColor = Color.DimGray;
                _flashTimer.Stop();
                _flashTimer.Dispose();
            };
            _flashTimer.Start();
        }

        private void FrmHocKy_Load_1(object sender, EventArgs e)
        {
            LoadData();
            SetTrangThaiForm(false);
        }
    }
}