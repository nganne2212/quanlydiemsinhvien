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

            // Tắt tự sinh cột — dùng cột đã định nghĩa trong designer
            dgvPhonghoc.AutoGenerateColumns = false;

            // Gắn cột với tên cột trong DataTable trả về từ DB
            colSTT.DataPropertyName = "STT";
            colMaphong.DataPropertyName = "MaPhong";
            colTenphong.DataPropertyName = "TenPhong";

            // Đăng ký sự kiện cho các nút
            BtnThem.Click += BtnThem_Click;
            BtnSua.Click += BtnSua_Click;
            BtnLuu.Click += BtnLuu_Click;
            BtnBoqua.Click += BtnBoqua_Click;
            dgvPhonghoc.CellClick += dgvPhonghoc_CellClick;

            LoadData();
            SetMode(Mode.NoSelection);
        }

        // ── Load dữ liệu lên DataGridView ───────────────────────────────
        private void LoadData()
        {
            dgvPhonghoc.DataSource = PhongHocBLL.GetAll();
        }

        // ── Quản lý trạng thái 5 nút ────────────────────────────────────
        private void SetMode(Mode mode)
        {
            _mode = mode;
            switch (mode)
            {
                case Mode.NoSelection:
                    TxtTenphong.Clear();
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
                    TxtTenphong.Clear();
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
        // → Điền Textbox + chỉnh nút
        private void dgvPhonghoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  // click vào header
            if (_mode == Mode.Add) return;  // đang nhập mới, không can thiệp

            var row = dgvPhonghoc.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;

            _maPhongDang = Convert.ToInt32(row["MaPhong"]);
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
                MessageBox.Show(err, "Lỗi nhập liệu",
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
                $"Xác nhận xóa phòng [{TxtTenphong.Text}]?",
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
            SetMode(Mode.NoSelection);
        }


    }
}