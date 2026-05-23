using qldsv.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmQLLop : Form
    {
        private DataTable tblLop;
        private bool dangSua = false;

        public FrmQLLop()
        {
            InitializeComponent();

            // Gắn cột với DataTable
            dgvLop.AutoGenerateColumns = false;
            colMaLop.DataPropertyName = "MaLop";
            colTenLop.DataPropertyName = "TenLop";
            colKhoa.DataPropertyName = "TenKhoa";
            colCVHT.DataPropertyName = "CoVanHocTap";

            // Đăng ký sự kiện
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnBoQua.Click += btnBoQua_Click;

            dgvLop.CellClick += dgvLop_CellClick;

            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            cboLocKhoa.SelectedIndexChanged += cboLocKhoa_SelectedIndexChanged;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.KeyPress += txtTimKiem_KeyPress;
            txtMaLop.KeyPress += txtMaLop_KeyPress;
            txtMaLop.KeyUp += txt_KeyUp;
            txtTenLop.KeyPress += txtTenLop_KeyPress;
            txtTenLop.KeyUp += txt_KeyUp;

            FrmQLLop_Load();
        }

        // ════════════════════════════════════════════════════════════════
        //  KHỞI TẠO
        // ════════════════════════════════════════════════════════════════

        private void FrmQLLop_Load()
        {
            SetIdleMode();
            Load_ComboKhoa();
            Load_DataGridView();
        }

        // ════════════════════════════════════════════════════════════════
        //  QUẢN LÝ TRẠNG THÁI NÚT  (tập trung tại đây, không set rải rác)
        // ════════════════════════════════════════════════════════════════

        /// <summary>
        /// Trạng thái mặc định: chỉ Thêm / Sửa / Xóa được bật.
        /// Lưu và Bỏ qua bị tắt.
        /// </summary>
        private void SetIdleMode()
        {
            dangSua = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;

            ResetValues();
        }

        /// <summary>
        /// Chế độ nhập liệu (Thêm hoặc Sửa):
        /// Tắt Thêm / Sửa / Xóa, bật Lưu và Bỏ qua.
        /// </summary>
        private void SetEditMode()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // ════════════════════════════════════════════════════════════════
        //  TẢI DỮ LIỆU
        // ════════════════════════════════════════════════════════════════

        private void Load_DataGridView()
        {
            tblLop = LopBLL.GetAll();
            dgvLop.DataSource = tblLop;
        }

        private void Load_ComboKhoa()
        {
            DataTable dtKhoa = LopBLL.GetAllKhoa();

            // ComboBox nhập liệu
            cboKhoa.DataSource = dtKhoa;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;

            // ComboBox lọc — thêm dòng "Tất cả"
            DataTable dtLoc = dtKhoa.Copy();
            DataRow r = dtLoc.NewRow();
            r["MaKhoa"] = "";
            r["TenKhoa"] = "-- Tất cả khoa --";
            dtLoc.Rows.InsertAt(r, 0);

            cboLocKhoa.DataSource = dtLoc;
            cboLocKhoa.DisplayMember = "TenKhoa";
            cboLocKhoa.ValueMember = "MaKhoa";
            cboLocKhoa.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════
        //  TÌM KIẾM & LỌC
        // ════════════════════════════════════════════════════════════════

        private void TimKiem()
        {
            string keyword = txtTimKiem.Text.Trim();
            string maKhoa = cboLocKhoa.SelectedValue?.ToString() ?? "";

            tblLop = LopBLL.Search(keyword, maKhoa);
            dgvLop.DataSource = tblLop;

            if (!string.IsNullOrEmpty(keyword) && tblLop.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"Không tìm thấy lớp nào với từ khóa \"{keyword}\".",
                    "Không có kết quả",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimKiem.Focus();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) => TimKiem();

        private void cboLocKhoa_SelectedIndexChanged(object sender, EventArgs e) => TimKiem();

        // Khi chọn Khoa → load danh sách CVHT theo Khoa
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null) return;
            string maKhoa = cboKhoa.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maKhoa)) return;

            DataTable dtGV = LopBLL.GetGiangVienByKhoa(maKhoa);
            cboCVHT.DataSource = dtGV;
            cboCVHT.DisplayMember = "HoTen";
            cboCVHT.ValueMember = "MaGiangVien";
            cboCVHT.SelectedIndex = -1;
        }

        // ════════════════════════════════════════════════════════════════
        //  VALIDATE KÝ TỰ
        // ════════════════════════════════════════════════════════════════

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ' &&
                (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void txtMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show(
                    $"Ký tự '{e.KeyChar}' không hợp lệ!\n\n" +
                    "Mã lớp chỉ chấp nhận chữ cái và chữ số,\n" +
                    "không có khoảng trắng hoặc ký tự đặc biệt.",
                    "Ký tự không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTenLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            bool hopLe = char.IsLetterOrDigit(e.KeyChar)
                      || e.KeyChar == ' '
                      || e.KeyChar == '-'
                      || e.KeyChar == '.'
                      || (int)e.KeyChar > 127;   // cho phép tiếng Việt
            if (!hopLe)
            {
                e.Handled = true;
                MessageBox.Show(
                    $"Ký tự '{e.KeyChar}' không được phép nhập!\n\n" +
                    "Tên lớp chỉ chấp nhận:\n" +
                    "   • Chữ cái (kể cả tiếng Việt)\n" +
                    "   • Chữ số (0 – 9)\n" +
                    "   • Khoảng trắng, dấu chấm ( . ), dấu gạch ngang ( - )",
                    "Ký tự không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Enter hoạt động như Tab
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        // ════════════════════════════════════════════════════════════════
        //  HELPER
        // ════════════════════════════════════════════════════════════════

        private void ResetValues()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboKhoa.SelectedIndex = -1;
            cboCVHT.DataSource = null;
        }

        /// <summary>Chọn đúng item trong ComboBox theo giá trị hiển thị.</summary>
        private void SelectCombo(Guna.UI2.WinForms.Guna2ComboBox cbo,
                                  string displayMember, string displayValue)
        {
            if (cbo.DataSource == null) return;
            DataTable dt = cbo.DataSource as DataTable;
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][displayMember].ToString() == displayValue)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  SỰ KIỆN GRID
        // ════════════════════════════════════════════════════════════════

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đang nhập liệu → không cho chọn dòng khác
            if (!btnThem.Enabled)
            {
                MessageBox.Show(
                    "Đang ở chế độ nhập liệu!\nVui lòng Lưu hoặc Bỏ qua trước.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblLop == null || tblLop.Rows.Count == 0 || e.RowIndex < 0) return;

            var row = dgvLop.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;

            // Chỉ điền dữ liệu lên form — KHÔNG thay đổi trạng thái nút
            txtMaLop.Text = row["MaLop"].ToString();
            txtTenLop.Text = row["TenLop"].ToString();

            SelectCombo(cboKhoa, "TenKhoa", row["TenKhoa"].ToString());
            SelectCombo(cboCVHT, "HoTen", row["CoVanHocTap"].ToString());
        }

        // ════════════════════════════════════════════════════════════════
        //  CÁC NÚT CHỨC NĂNG
        // ════════════════════════════════════════════════════════════════

        // ── Thêm ────────────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            dangSua = false;        // đánh dấu đang Thêm mới
            SetEditMode();
            ResetValues();
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            dgvLop.ClearSelection();
            txtMaLop.Focus();
        }

        // ── Sửa: CHỈ mở chế độ nhập, KHÔNG lưu ─────────────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblLop == null || tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dangSua = true;         // đánh dấu đang Sửa
            SetEditMode();
            txtMaLop.Enabled = false;  // không cho đổi mã
            txtTenLop.Enabled = true;
            txtTenLop.Focus();
        }

        // ── Lưu: INSERT nếu dangSua=false, UPDATE nếu dangSua=true ──────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // --- Validate chung ---
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Bạn phải nhập tên lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            string maKhoa = cboKhoa.SelectedValue?.ToString();
            string maGV = cboCVHT.SelectedValue?.ToString();
            string err, thongBao;

            if (!dangSua)   // ── THÊM MỚI ──
            {
                if (string.IsNullOrWhiteSpace(txtMaLop.Text))
                {
                    MessageBox.Show("Bạn phải nhập mã lớp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Focus();
                    return;
                }
                if (cboKhoa.SelectedIndex < 0)
                {
                    MessageBox.Show("Bạn phải chọn Khoa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboKhoa.Focus();
                    return;
                }
                if (cboCVHT.SelectedIndex < 0)
                {
                    MessageBox.Show("Bạn phải chọn Cố vấn học tập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCVHT.Focus();
                    return;
                }

                err = LopBLL.Add(txtMaLop.Text, txtTenLop.Text, maKhoa, maGV);
                thongBao = "Thêm lớp thành công!";
            }
            else            // ── CẬP NHẬT ──
            {
                err = LopBLL.Update(txtMaLop.Text, txtTenLop.Text, maKhoa, maGV);
                thongBao = "Cập nhật lớp thành công!";
            }

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(thongBao, "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            SetIdleMode();
        }

        // ── Xóa ─────────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblLop == null || tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có muốn xóa lớp [{txtMaLop.Text}] không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            string err = LopBLL.Delete(txtMaLop.Text);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Không thể xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa lớp thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            SetIdleMode();
        }

        // ── Bỏ qua ──────────────────────────────────────────────────────
        private void btnBoQua_Click(object sender, EventArgs e) => SetIdleMode();
    }
}