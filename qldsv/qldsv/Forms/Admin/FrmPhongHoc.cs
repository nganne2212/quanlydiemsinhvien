using qldsv.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmPhongHoc : Form
    {
        private enum Mode { NoSelection, View, Add, Edit }
        private Mode _mode = Mode.NoSelection;
        private int _maPhongDang = 0;

        public FrmPhongHoc()
        {
            InitializeComponent();

            // Gắn cột với tên cột DataTable
            dgvPhonghoc.AutoGenerateColumns = false;
            colSTT.DataPropertyName = "STT";
            colMaphong.DataPropertyName = "MaPhong";
            colTenphong.DataPropertyName = "TenPhong";

            // Đăng ký sự kiện
            BtnThem.Click += BtnThem_Click;
            BtnSua.Click += BtnSua_Click;
            BtnLuu.Click += BtnLuu_Click;
            BtnBoqua.Click += BtnBoqua_Click;
            dgvPhonghoc.CellClick += dgvPhonghoc_CellClick;
            TxtTenphong.KeyPress += TxtTenphong_KeyPress;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.KeyDown += TxtSearch_KeyDown;

            LoadData();
            SetMode(Mode.NoSelection);
        }

        // ── Load dữ liệu ────────────────────────────────────────────────
        private void LoadData()
        {
            dgvPhonghoc.DataSource = PhongHocBLL.Search(TxtSearch.Text.Trim());
        }

        // ── Tìm kiếm nâng cao real-time ─────────────────────────────────
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = TxtSearch.Text.Trim();
            var dt = PhongHocBLL.Search(keyword);
            dgvPhonghoc.DataSource = dt;
            SetMode(Mode.NoSelection);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string keyword = TxtSearch.Text.Trim();
            var dt = PhongHocBLL.Search(keyword);

            if (!string.IsNullOrEmpty(keyword) && dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"Không tìm thấy phòng học nào có tên chứa \"{keyword}\".",
                    "Không có kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TxtSearch.Focus();
            }
        }
        // ── Validate ký tự lạ ngay khi gõ ───────────────────────────────
        private void TxtTenphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            bool hopLe = char.IsLetterOrDigit(e.KeyChar)
                      || e.KeyChar == ' '
                      || e.KeyChar == '.'
                      || e.KeyChar == '-'
                      || (int)e.KeyChar > 127; // Unicode tiếng Việt

            if (!hopLe)
            {
                e.Handled = true;
                MessageBox.Show(
                    $"Ký tự '{e.KeyChar}' không được phép nhập!\n\n" +
                    "Tên phòng chỉ chấp nhận:\n" +
                    "   • Chữ cái (kể cả tiếng Việt)\n" +
                    "   • Chữ số (0 - 9)\n" +
                    "   • Khoảng trắng\n" +
                    "   • Dấu chấm ( . )\n" +
                    "   • Dấu gạch ngang ( - )",
                    "Ký tự không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ── Quản lý trạng thái 5 nút ────────────────────────────────────
        private void SetMode(Mode mode)
        {
            _mode = mode;
            switch (mode)
            {
                case Mode.NoSelection:
                    TxtMaphong.Text = "";
                    TxtTenphong.Text = "";
                    TxtTenphong.Enabled = false;
                    BtnThem.Enabled = true;
                    BtnSua.Enabled = false;
                    BtnLuu.Enabled = false;
                    BtnXoa.Enabled = false;
                    BtnBoqua.Enabled = false;
                    _maPhongDang = 0;
                    break;

                case Mode.View:
                    TxtTenphong.Enabled = false;
                    BtnThem.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnLuu.Enabled = false;
                    BtnXoa.Enabled = true;
                    BtnBoqua.Enabled = false;
                    break;

                case Mode.Add:
                    TxtMaphong.Text = "";
                    TxtTenphong.Text = "";
                    TxtTenphong.Enabled = true;
                    TxtTenphong.Focus();
                    BtnThem.Enabled = false;
                    BtnSua.Enabled = false;
                    BtnLuu.Enabled = true;
                    BtnXoa.Enabled = false;
                    BtnBoqua.Enabled = true;
                    _maPhongDang = 0;
                    break;

                case Mode.Edit:
                    TxtTenphong.Enabled = true;
                    TxtTenphong.Focus();
                    BtnThem.Enabled = false;
                    BtnSua.Enabled = false;
                    BtnLuu.Enabled = true;
                    BtnXoa.Enabled = false;
                    BtnBoqua.Enabled = true;
                    break;
            }
        }

        // ── Click dòng trong DataGridView ────────────────────────────────
        private void dgvPhonghoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_mode == Mode.Add) return;

            var row = dgvPhonghoc.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;

            _maPhongDang = Convert.ToInt32(row["MaPhong"]);
            TxtMaphong.Text = _maPhongDang.ToString();
            TxtTenphong.Text = row["TenPhong"].ToString();

            if (_mode != Mode.Edit)
                SetMode(Mode.View);
        }

        // ── Nút Thêm ────────────────────────────────────────────────────
        private void BtnThem_Click(object sender, EventArgs e)
        {
            dgvPhonghoc.ClearSelection();
            SetMode(Mode.Add);
        }

        // ── Nút Sửa ─────────────────────────────────────────────────────
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (_maPhongDang <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetMode(Mode.Edit);
        }

        // ── Nút Lưu ─────────────────────────────────────────────────────
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string err = _mode == Mode.Add
                ? PhongHocBLL.Add(TxtTenphong.Text)
                : PhongHocBLL.Update(_maPhongDang, TxtTenphong.Text);

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTenphong.Focus();
                return;
            }

            MessageBox.Show(
                _mode == Mode.Add
                    ? "Thêm phòng học thành công!"
                    : "Cập nhật phòng học thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            SetMode(Mode.NoSelection);
        }

        // ── Nút Xóa ─────────────────────────────────────────────────────
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_maPhongDang <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận xóa phòng [{TxtTenphong.Text}]?\nThao tác này không thể hoàn tác.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string err = PhongHocBLL.Delete(_maPhongDang);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Không thể xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa phòng học thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            SetMode(Mode.NoSelection);
        }

        // ── Nút Bỏ qua ──────────────────────────────────────────────────
        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            LoadData();
            SetMode(Mode.NoSelection);
        }
    }
}