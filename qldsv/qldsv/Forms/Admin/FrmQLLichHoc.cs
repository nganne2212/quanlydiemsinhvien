using qldsv.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmQLLichHoc : Form
    {
        private DataTable tblLichHoc;

        // Lưu key của dòng đang chọn (dùng khi UPDATE/DELETE)
        private string _maLHPCu;
        private int _thuCu;
        private int _caHocCu;

        public FrmQLLichHoc()
        {
            InitializeComponent();

            // ── Gắn cột DataGridView ──────────────────────────────────
            dgvLichHoc.AutoGenerateColumns = false;
            colMaLHP.DataPropertyName = "MaLHP";
            colMonHoc.DataPropertyName = "TenMonHoc";
            colGiangVien.DataPropertyName = "TenGiangVien";
            colPhong.DataPropertyName = "TenPhong";
            colThu.DataPropertyName = "TenThu";
            colCaHoc.DataPropertyName = "TenCa";

            // ── Đăng ký sự kiện ──────────────────────────────────────
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnBoqua.Click += btnBoqua_Click;
            dgvLichHoc.CellClick += dgvLichHoc_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;

            FrmQLLichHoc_Load();
        }

        // ── Load form ────────────────────────────────────────────────────
        private void FrmQLLichHoc_Load()
        {
            SetComboEnabled(false);
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;

            Load_Combos();
            Load_DataGridView();
        }

        // ── Load DataGridView ────────────────────────────────────────────
        private void Load_DataGridView()
        {
            tblLichHoc = QLLichHocBLL.GetAll();
            dgvLichHoc.DataSource = tblLichHoc;
        }

        // ── Load ComboBox LHP và Phòng ───────────────────────────────────
        private void Load_Combos()
        {
            // ComboBox Lớp học phần
            DataTable dtLHP = QLLichHocBLL.GetAllLopHocPhan();
            cboLopHocPhan.DataSource = dtLHP;
            cboLopHocPhan.DisplayMember = "TenHienThi";
            cboLopHocPhan.ValueMember = "MaLHP";
            cboLopHocPhan.SelectedIndex = -1;

            // ComboBox Phòng học
            DataTable dtPhong = QLLichHocBLL.GetAllPhongHoc();
            cboPhongHoc.DataSource = dtPhong;
            cboPhongHoc.DisplayMember = "TenPhong";
            cboPhongHoc.ValueMember = "MaPhong";
            cboPhongHoc.SelectedIndex = -1;

            // cboThu và cboCaHoc đã có Items từ Designer
            cboThu.SelectedIndex = -1;
            cboCaHoc.SelectedIndex = -1;
        }

        // ── Bật/tắt các ComboBox nhập liệu ──────────────────────────────
        private void SetComboEnabled(bool enabled)
        {
            cboLopHocPhan.Enabled = enabled;
            cboPhongHoc.Enabled = enabled;
            cboThu.Enabled = enabled;
            cboCaHoc.Enabled = enabled;
        }

        // ── Reset form nhập ──────────────────────────────────────────────
        private void ResetValues()
        {
            cboLopHocPhan.SelectedIndex = -1;
            cboPhongHoc.SelectedIndex = -1;
            cboThu.SelectedIndex = -1;
            cboCaHoc.SelectedIndex = -1;
            _maLHPCu = null;
            _thuCu = 0;
            _caHocCu = 0;
        }

        // ── Tìm kiếm real-time ───────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            tblLichHoc = QLLichHocBLL.Search(keyword);
            dgvLichHoc.DataSource = tblLichHoc;

            if (!string.IsNullOrEmpty(keyword) && tblLichHoc.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"Không tìm thấy lịch học nào với từ khóa \"{keyword}\".",
                    "Không có kết quả",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
            }
        }

        // ── Click dòng DataGridView ──────────────────────────────────────
        private void dgvLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đang ở chế độ thêm mới
            if (btnThem.Enabled == false)
            {
                MessageBox.Show(
                    "Đang ở chế độ thêm mới!\nVui lòng nhập dữ liệu hoặc bấm Bỏ qua.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLopHocPhan.Focus();
                return;
            }

            if (tblLichHoc == null || tblLichHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex < 0) return;
            var row = dgvLichHoc.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (row == null) return;

            // Lưu key cũ để dùng khi UPDATE/DELETE
            _maLHPCu = row["MaLHP"].ToString();
            _thuCu = Convert.ToInt32(row["Thu"]);
            _caHocCu = Convert.ToInt32(row["CaHoc"]);

            // Điền dữ liệu lên form (chỉ điền, KHÔNG thay đổi trạng thái nút)
            SelectCombo(cboLopHocPhan, "MaLHP", _maLHPCu);
            SelectComboByValue(cboPhongHoc, row["MaPhong"].ToString());
            cboThu.SelectedIndex = _thuCu - 2;   // Thứ 2=index 0 … Thứ 7=index 5
            cboCaHoc.SelectedIndex = _caHocCu - 1; // Ca 1=index 0 … Ca 4=index 3

            btnBoqua.Enabled = true;
        }

        // ── Helper: chọn ComboBox theo DisplayMember ─────────────────────
        private void SelectCombo(Guna.UI2.WinForms.Guna2ComboBox cbo,
                                  string valueMember, string value)
        {
            if (cbo.DataSource == null) return;
            DataTable dt = cbo.DataSource as DataTable;
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][valueMember].ToString() == value)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void SelectComboByValue(Guna.UI2.WinForms.Guna2ComboBox cbo, string value)
        {
            if (cbo.DataSource == null) return;
            DataTable dt = cbo.DataSource as DataTable;
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MaPhong"].ToString() == value)
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
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;

            ResetValues();
            SetComboEnabled(true);
            cboLopHocPhan.Focus();
            dgvLichHoc.ClearSelection();
        }

        // ── Nút Sửa: chỉ mở chế độ chỉnh sửa, CHƯA lưu ─────────────────
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblLichHoc == null || tblLichHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(_maLHPCu))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở chế độ sửa — giữ nguyên dữ liệu đang chọn
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;

            // Chỉ cho sửa phòng, thứ, ca — không cho đổi LHP
            cboLopHocPhan.Enabled = false;
            cboPhongHoc.Enabled = true;
            cboThu.Enabled = true;
            cboCaHoc.Enabled = true;
            cboPhongHoc.Focus();
        }

        // ── Nút Lưu: INSERT nếu đang Thêm, UPDATE nếu đang Sửa ──────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate chung
            if (cboPhongHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn phòng học!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhongHoc.Focus();
                return;
            }
            if (cboThu.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn thứ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThu.Focus();
                return;
            }
            if (cboCaHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn ca học!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaHoc.Focus();
                return;
            }

            int maPhong = Convert.ToInt32(cboPhongHoc.SelectedValue);
            int thu = cboThu.SelectedIndex + 2;    // index 0 = Thứ 2
            int caHoc = cboCaHoc.SelectedIndex + 1;  // index 0 = Ca 1

            string err;
            string thongBao;

            // _maLHPCu rỗng → đang Thêm (INSERT)
            // _maLHPCu có giá trị → đang Sửa (UPDATE)
            if (string.IsNullOrEmpty(_maLHPCu))
            {
                // Validate thêm LHP (chỉ bắt buộc khi INSERT)
                if (cboLopHocPhan.SelectedIndex < 0)
                {
                    MessageBox.Show("Bạn phải chọn lớp học phần!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboLopHocPhan.Focus();
                    return;
                }

                string maLHP = cboLopHocPhan.SelectedValue?.ToString();
                err = QLLichHocBLL.Add(maLHP, maPhong, thu, caHoc);
                thongBao = "Thêm lịch học thành công!";
            }
            else
            {
                err = QLLichHocBLL.Update(_maLHPCu, _thuCu, _caHocCu,
                                              maPhong, thu, caHoc);
                thongBao = "Cập nhật lịch học thành công!";
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
            ResetValues();
            SetStateDefault();
        }

        // ── Nút Xóa ─────────────────────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblLichHoc == null || tblLichHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(_maLHPCu))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có muốn xóa lịch học [{_maLHPCu}] Thứ {_thuCu} Ca {_caHocCu} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            string err = QLLichHocBLL.Delete(_maLHPCu, _thuCu, _caHocCu);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Không thể xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa lịch học thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            SetStateDefault();
        }

        // ── Nút Bỏ qua ──────────────────────────────────────────────────
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            SetStateDefault();
        }

        // ── Trả về trạng thái mặc định ───────────────────────────────────
        private void SetStateDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            SetComboEnabled(false);
        }
    }
}