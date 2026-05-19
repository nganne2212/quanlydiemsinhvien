using qldsv.BLL;
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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        DataTable tblMonHoc;

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            // Ẩn Lưu & Bỏ qua lúc mở form — giống File 1
            txtMonHoc.Enabled = false;
            gbtnLuu.Enabled = false;
            gbtnBoqua.Enabled = false;
            gbtnSua.Enabled = false;
            gbtnXoa.Enabled = false;

            LoadGrid();

            txtCC.KeyPress += HeSo_KeyPress;
            txtKT1.KeyPress += HeSo_KeyPress;
            txtKT2.KeyPress += HeSo_KeyPress;
            txtCK.KeyPress += HeSo_KeyPress;
            txtSotinchi.KeyPress += SoNguyen_KeyPress;
        }

        private void LoadGrid()
        {
            tblMonHoc = MonHocBLL.GetAll();
            dgvMH.AutoGenerateColumns = false;

            if (dgvMH.Columns.Count >= 8)
            {
                dgvMH.Columns[0].DataPropertyName = "STT";
                dgvMH.Columns[1].DataPropertyName = "MaMonHoc";
                dgvMH.Columns[2].DataPropertyName = "TenMon";
                dgvMH.Columns[3].DataPropertyName = "SoTinChi";
                dgvMH.Columns[4].DataPropertyName = "HeSoChuyenCan";
                dgvMH.Columns[5].DataPropertyName = "HeSoKT1";
                dgvMH.Columns[6].DataPropertyName = "HeSoKT2";
                dgvMH.Columns[7].DataPropertyName = "HeSoCuoiKy";
            }

            dgvMH.DataSource = tblMonHoc;
            dgvMH.AllowUserToAddRows = false;
            dgvMH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetInputs()
        {
            txtMonHoc.Text = "";
            txtTenHoc.Text = "";
            txtSotinchi.Text = "";
            txtCC.Text = "";
            txtKT1.Text = "";
            txtKT2.Text = "";
            txtCK.Text = "";
        }

        // Trạng thái bình thường — giống btnBoQua File 1
        private void SetNormalMode()
        {
            gbtnThem.Enabled = true;
            gbtnSua.Enabled = true;
            gbtnXoa.Enabled = true;
            gbtnLuu.Enabled = false;
            gbtnBoqua.Enabled = false;
            txtMonHoc.Enabled = false;
        }

        private void HeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            var tb = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (tb != null && (e.KeyChar == '.' || e.KeyChar == ','))
                if (tb.Text.Contains(".") || tb.Text.Contains(","))
                    e.Handled = true;
        }

        private void SoNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // Click vào dòng chỉ điền dữ liệu lên, KHÔNG bật Bỏ qua
        private void dgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gbtnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0) return;
            if (e.RowIndex < 0 || e.RowIndex >= tblMonHoc.Rows.Count) return;

            DataRow row = tblMonHoc.Rows[e.RowIndex];
            txtMonHoc.Text = row["MaMonHoc"]?.ToString() ?? "";
            txtTenHoc.Text = row["TenMon"]?.ToString() ?? "";
            txtSotinchi.Text = row["SoTinChi"]?.ToString() ?? "";
            txtCC.Text = row["HeSoChuyenCan"]?.ToString() ?? "";
            txtKT1.Text = row["HeSoKT1"]?.ToString() ?? "";
            txtKT2.Text = row["HeSoKT2"]?.ToString() ?? "";
            txtCK.Text = row["HeSoCuoiKy"]?.ToString() ?? "";

            // Chỉ bật Sửa & Xóa, KHÔNG bật Lưu/Bỏ qua
            gbtnSua.Enabled = true;
            gbtnXoa.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            tblMonHoc = string.IsNullOrWhiteSpace(kw)
                ? MonHocBLL.GetAll()
                : MonHocBLL.Search(kw);
            dgvMH.DataSource = tblMonHoc;
        }

        // Thêm: chuyển chế độ, chưa lưu — giống btnThem File 1
        private void gbtnThem_Click(object sender, EventArgs e)
        {
            gbtnThem.Enabled = false;
            gbtnSua.Enabled = false;
            gbtnXoa.Enabled = false;
            gbtnLuu.Enabled = true;
            gbtnBoqua.Enabled = true;
            txtMonHoc.Enabled = true;
            ResetInputs();
            txtMonHoc.Focus();
        }

        // Sửa: chuyển chế độ, chưa lưu — giống btnSua File 1
        private void gbtnSua_Click(object sender, EventArgs e)
        {
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvMH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gbtnThem.Enabled = false;
            gbtnSua.Enabled = false;
            gbtnXoa.Enabled = false;
            gbtnLuu.Enabled = true;
            gbtnBoqua.Enabled = true;
            txtMonHoc.Enabled = false; // Không cho sửa mã
            txtTenHoc.Focus();
        }

        // Lưu: phân biệt Thêm/Sửa qua txtMonHoc.Enabled — giống btnLuu File 1
        private void gbtnLuu_Click(object sender, EventArgs e)
        {
            string err;

            if (txtMonHoc.Enabled) // Đang ở chế độ Thêm
            {
                err = MonHocBLL.Them(
                    txtMonHoc.Text.Trim(),
                    txtTenHoc.Text.Trim(),
                    txtSotinchi.Text.Trim(),
                    txtCC.Text.Trim(),
                    txtKT1.Text.Trim(),
                    txtKT2.Text.Trim(),
                    txtCK.Text.Trim());
            }
            else // Đang ở chế độ Sửa
            {
                err = MonHocBLL.Sua(
                    txtMonHoc.Text.Trim(),
                    txtTenHoc.Text.Trim(),
                    txtSotinchi.Text.Trim(),
                    txtCC.Text.Trim(),
                    txtKT1.Text.Trim(),
                    txtKT2.Text.Trim(),
                    txtCK.Text.Trim());
            }

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (err.Contains("mã")) { txtMonHoc.Text = ""; txtMonHoc.Focus(); }
                else if (err.Contains("tên")) txtTenHoc.Focus();
                else if (err.Contains("tín")) txtSotinchi.Focus();
                else if (err.Contains("chuyên")) txtCC.Focus();
                else if (err.Contains("tra 1")) txtKT1.Focus();
                else if (err.Contains("tra 2")) txtKT2.Focus();
                else if (err.Contains("cuối")) txtCK.Focus();
                return;
            }

            MessageBox.Show(txtMonHoc.Enabled ? "Thêm môn học thành công!" : "Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadGrid();
            ResetInputs();
            SetNormalMode();
        }

        private void gbtnXoa_Click(object sender, EventArgs e)
        {
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvMH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string err = MonHocBLL.KiemTraXoa(txtMonHoc.Text.Trim());
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                    "Bạn có muốn xóa môn học [" + txtMonHoc.Text.Trim() + "] " + txtTenHoc.Text.Trim() + "?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            MonHocBLL.Xoa(txtMonHoc.Text.Trim());
            MessageBox.Show("Xóa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadGrid();
            ResetInputs();
            SetNormalMode();
        }

        private void gbtnBoqua_Click(object sender, EventArgs e)
        {
            ResetInputs();
            SetNormalMode();
        }
    }
}