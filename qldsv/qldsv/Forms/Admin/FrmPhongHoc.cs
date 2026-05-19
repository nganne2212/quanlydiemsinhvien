using qldsv.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmPhongHoc : Form
    {
        private DataTable tblPH;

        public FrmPhongHoc()
        {
            InitializeComponent();

            dgvPhonghoc.AutoGenerateColumns = false;
            colSTT.DataPropertyName = "STT";
            colMaphong.DataPropertyName = "MaPhong";
            colTenphong.DataPropertyName = "TenPhong";

            BtnThem.Click += BtnThem_Click;
            BtnSua.Click += BtnSua_Click;
            BtnLuu.Click += BtnLuu_Click;
            BtnXoa.Click += BtnXoa_Click;
            BtnBoqua.Click += BtnBoqua_Click;
            dgvPhonghoc.CellClick += dgvPhonghoc_CellClick;
            TxtTenphong.KeyPress += TxtTenphong_KeyPress;
            TxtTenphong.KeyUp += TxtTenphong_KeyUp;
            TxtSearch.TextChanged += TxtSearch_TextChanged;

            FrmPhongHoc_Load();
        }

        // ── Load: Thêm/Sửa/Xóa bật, Lưu/Bỏ qua tắt ────────────────────
        private void FrmPhongHoc_Load()
        {
          
            BtnLuu.Enabled = false;
            BtnBoqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            tblPH = PhongHocBLL.GetAll();
            dgvPhonghoc.DataSource = tblPH;
        }

        private void ResetValues()
        {
            TxtMaphong.Text = "";
            TxtTenphong.Text = "";
        }

        // ── Tìm kiếm real-time ───────────────────────────────────────────
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = TxtSearch.Text.Trim();
            tblPH = PhongHocBLL.Search(keyword);
            dgvPhonghoc.DataSource = tblPH;

            if (!string.IsNullOrEmpty(keyword) && tblPH.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"Không tìm thấy phòng học nào có tên chứa \"{keyword}\".",
                    "Không có kết quả",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtSearch.Focus();
            }
        }

        // ── Click dòng DataGridView ──────────────────────────────────────
        private void dgvPhonghoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đang ở chế độ thêm mới
            if (BtnThem.Enabled == false)
            {
                MessageBox.Show(
                    "Đang ở chế độ thêm mới!\nVui lòng nhập tên phòng hoặc bấm Bỏ qua.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTenphong.Focus();
                return;
            }

            // Không có dữ liệu
            if (tblPH == null || tblPH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex < 0) return;
            var row = dgvPhonghoc.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;

            TxtMaphong.Text = row["MaPhong"].ToString();
            TxtTenphong.Text = row["TenPhong"].ToString();
            TxtTenphong.Enabled = true;
            BtnBoqua.Enabled = true;
        }

        // ── Validate ký tự lạ khi gõ ────────────────────────────────────
        private void TxtTenphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            bool hopLe = char.IsLetterOrDigit(e.KeyChar)
                      || e.KeyChar == ' '
                      || e.KeyChar == '.'
                      || e.KeyChar == '-'
                      || (int)e.KeyChar > 127;

            if (!hopLe)
            {
                e.Handled = true;
                MessageBox.Show(
                    $"Ký tự '{e.KeyChar}' không được phép nhập!\n\n" +
                    "Tên phòng chỉ chấp nhận:\n" +
                    "   • Chữ cái (kể cả tiếng Việt)\n" +
                    "   • Chữ số (0 - 9)\n" +
                    "   • Dấu chấm ( . )\n" +
                    "   • Dấu gạch ngang ( - )\n\n" +
                    "Ví dụ hợp lệ: D6.207, A1.101, B2.301",
                    "Ký tự không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Enter thay Tab ───────────────────────────────────────────────
        private void TxtTenphong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        // ── Nút Thêm ────────────────────────────────────────────────────
        private void BtnThem_Click(object sender, EventArgs e)
        {
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnLuu.Enabled = true;
            BtnBoqua.Enabled = true;
            BtnThem.Enabled = false;

            ResetValues();
            TxtTenphong.Enabled = true;
            TxtTenphong.Focus();
            dgvPhonghoc.ClearSelection();
        }

        // ── Nút Sửa: chỉ mở chế độ chỉnh sửa, CHƯA lưu ─────────────────
        private void BtnSua_Click(object sender, EventArgs e)
        {
            // Không còn dữ liệu
            if (tblPH == null || tblPH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chưa chọn bản ghi
            if (string.IsNullOrWhiteSpace(TxtMaphong.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở chế độ sửa — giống Thêm nhưng giữ nguyên dữ liệu đang chọn
            BtnThem.Enabled = false;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnLuu.Enabled = true;
            BtnBoqua.Enabled = true;
            TxtTenphong.Enabled = true;
            TxtTenphong.Focus();
        }

        // ── Nút Lưu: INSERT nếu đang Thêm, UPDATE nếu đang Sửa ──────────
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            // Tên phòng không được rỗng
            if (TxtTenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTenphong.Focus();
                return;
            }

            string err;
            string thongBao;

            // TxtMaphong rỗng → đang Thêm mới (INSERT)
            // TxtMaphong có giá trị → đang Sửa (UPDATE)
            if (string.IsNullOrWhiteSpace(TxtMaphong.Text))
            {
                err = PhongHocBLL.Add(TxtTenphong.Text);
                thongBao = "Thêm phòng học thành công!";
            }
            else
            {
                int maPhong = Convert.ToInt32(TxtMaphong.Text);
                err = PhongHocBLL.Update(maPhong, TxtTenphong.Text);
                thongBao = "Cập nhật phòng học thành công!";
            }

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTenphong.Focus();
                return;
            }

            MessageBox.Show(thongBao, "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();

            // Trả về trạng thái ban đầu
            BtnThem.Enabled = true;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnLuu.Enabled = false;
            BtnBoqua.Enabled = false;
            TxtTenphong.Enabled = false;
        }

        // ── Nút Xóa (DELETE) ────────────────────────────────────────────
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Không còn dữ liệu
            if (tblPH == null || tblPH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chưa chọn bản ghi
            if (string.IsNullOrWhiteSpace(TxtMaphong.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có muốn xóa phòng [{TxtTenphong.Text}] không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            int maPhong = Convert.ToInt32(TxtMaphong.Text);
            string err = PhongHocBLL.Delete(maPhong);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Không thể xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa phòng học thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            TxtTenphong.Enabled = false;
            BtnBoqua.Enabled = false;
        }

        // ── Nút Bỏ qua ──────────────────────────────────────────────────
        private void BtnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            BtnBoqua.Enabled = false;
            BtnThem.Enabled = true;
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnLuu.Enabled = false;
            TxtTenphong.Enabled = false;
        }
    }
}