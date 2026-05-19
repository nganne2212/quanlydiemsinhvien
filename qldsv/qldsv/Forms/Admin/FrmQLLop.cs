using qldsv.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmQLLop : Form
    {
        private DataTable tblLop;

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

        // ── Load form ───────────────────────────────────────────────────
        private void FrmQLLop_Load()
        {
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            Load_ComboKhoa();
            Load_DataGridView();
        }

        // ── Load DataGridView ────────────────────────────────────────────
        private void Load_DataGridView()
        {
            tblLop = LopBLL.GetAll();
            dgvLop.DataSource = tblLop;
        }

        // ── Load ComboBox Khoa (dùng cho form nhập và lọc) ───────────────
        private void Load_ComboKhoa()
        {
            DataTable dtKhoa = LopBLL.GetAllKhoa();

            // ComboBox nhập liệu
            cboKhoa.DataSource = dtKhoa;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;

            // ComboBox lọc danh sách — thêm dòng "Tất cả"
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

        // ── Khi chọn Khoa → load CVHT theo Khoa ─────────────────────────
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null) return;
            string maKhoa = cboKhoa.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maKhoa)) return;

            DataTable dtGV = LopBLL.GetGiangVienByKhoa(maKhoa);
            cboCVHT.DataSource = dtGV;
            cboCVHT.DisplayMember = "HoTen";          // hiện tên GV
            cboCVHT.ValueMember = "MaGiangVien";    // lưu mã GV
            cboCVHT.SelectedIndex = -1;
        }

        // ── Lọc grid theo Khoa ───────────────────────────────────────────
        private void cboLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        // ── Tìm kiếm + lọc kết hợp ──────────────────────────────────────
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        // ── Validate ký tự ô tìm kiếm ───────────────────────────────────
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

        // ── Validate ký tự Mã lớp ───────────────────────────────────────
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

        // ── Validate ký tự Tên lớp ──────────────────────────────────────
        private void txtTenLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            bool hopLe = char.IsLetterOrDigit(e.KeyChar)
                      || e.KeyChar == ' '
                      || e.KeyChar == '-'
                      || e.KeyChar == '.'
                      || (int)e.KeyChar > 127;
            if (!hopLe)
            {
                e.Handled = true;
                MessageBox.Show(
                    $"Ký tự '{e.KeyChar}' không được phép nhập!\n\n" +
                    "Tên lớp chỉ chấp nhận:\n" +
                    "   • Chữ cái (kể cả tiếng Việt)\n" +
                    "   • Chữ số (0 - 9)\n" +
                    "   • Khoảng trắng, dấu chấm ( . ), dấu gạch ngang ( - )",
                    "Ký tự không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Enter thay Tab ───────────────────────────────────────────────
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        // ── Reset các ô nhập ────────────────────────────────────────────
        private void ResetValues()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboKhoa.SelectedIndex = -1;
            cboCVHT.DataSource = null;
        }

        // ── Click dòng DataGridView ──────────────────────────────────────
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đang ở chế độ thêm mới
            if (btnThem.Enabled == false)
            {
                MessageBox.Show(
                    "Đang ở chế độ thêm mới!\nVui lòng nhập dữ liệu hoặc bấm Bỏ qua.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return;
            }

            if (tblLop == null || tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex < 0) return;
            var row = dgvLop.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;
            // Điền thông tin lên form
            txtMaLop.Text = row["MaLop"].ToString();
            txtTenLop.Text = row["TenLop"].ToString();
            txtTenLop.Enabled = true;

            // Chọn Khoa trong cboKhoa → tự động load cboCVHT
            SelectCombo(cboKhoa, "TenKhoa", row["TenKhoa"].ToString());

            // Sau khi cboKhoa load xong → chọn CVHT
            SelectCombo(cboCVHT, "HoTen", row["CoVanHocTap"].ToString());

            btnBoQua.Enabled = true;
        }

        // ── Helper: chọn item trong ComboBox theo DisplayMember ──────────
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

        // ── Nút Thêm ────────────────────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;

            ResetValues();
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            txtMaLop.Focus();
            dgvLop.ClearSelection();
        }

        // ── Nút Sửa: lưu thông tin đã chỉnh sửa (UPDATE) ───────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblLop == null || tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            string maKhoa = cboKhoa.SelectedValue?.ToString();
            string maGV = cboCVHT.SelectedValue?.ToString();
            string err = LopBLL.Update(txtMaLop.Text, txtTenLop.Text, maKhoa, maGV);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Cập nhật lớp thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // ── Nút Lưu: kiểm tra và thêm mới (INSERT) ──────────────────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }

            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            if (cboKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn Khoa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoa.Focus();
                return;
            }

            if (cboCVHT.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn Cố vấn học tập!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCVHT.Focus();
                return;
            }

            string maKhoa = cboKhoa.SelectedValue?.ToString();
            string maGV = cboCVHT.SelectedValue?.ToString();

            string err = LopBLL.Add(txtMaLop.Text, txtTenLop.Text, maKhoa, maGV);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }

            MessageBox.Show("Thêm lớp thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
        }

        // ── Nút Xóa ─────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblLop == null || tblLop.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("Xóa lớp thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // ── Nút Bỏ qua ──────────────────────────────────────────────────
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
        }
    }
}
