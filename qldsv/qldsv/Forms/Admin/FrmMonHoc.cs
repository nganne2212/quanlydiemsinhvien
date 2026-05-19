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



        private void LoadGrid()
        {
            tblMonHoc = MonHocBLL.GetAll();
            dgvMH.AutoGenerateColumns = false;
            dgvMH.DataSource = tblMonHoc;

            if (dgvMH.Columns.Count >= 8)
            {
                dgvMH.Columns[0].HeaderText = "STT";
                dgvMH.Columns[1].HeaderText = "Mã môn";
                dgvMH.Columns[2].HeaderText = "Tên môn";
                dgvMH.Columns[3].HeaderText = "Số tín chỉ";
                dgvMH.Columns[4].HeaderText = "Chuyên cần";
                dgvMH.Columns[5].HeaderText = "Kiểm tra 1";
                dgvMH.Columns[6].HeaderText = "Kiểm tra 2";
                dgvMH.Columns[7].HeaderText = "Cuối kỳ";
            }

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

        private void dgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gbtnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0) return;
            if (e.RowIndex < 0) return;

            txtMonHoc.Text = dgvMH.CurrentRow.Cells["MaMonHoc"].Value?.ToString() ?? "";
            txtTenHoc.Text = dgvMH.CurrentRow.Cells["TenMon"].Value?.ToString() ?? "";
            txtSotinchi.Text = dgvMH.CurrentRow.Cells["SoTinChi"].Value?.ToString() ?? "";
            txtCC.Text = dgvMH.CurrentRow.Cells["HeSoChuyenCan"].Value?.ToString() ?? "";
            txtKT1.Text = dgvMH.CurrentRow.Cells["HeSoKT1"].Value?.ToString() ?? "";
            txtKT2.Text = dgvMH.CurrentRow.Cells["HeSoKT2"].Value?.ToString() ?? "";
            txtCK.Text = dgvMH.CurrentRow.Cells["HeSoCuoiKy"].Value?.ToString() ?? "";

            gbtnSua.Enabled = true;
            gbtnXoa.Enabled = true;
            gbtnBoqua.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            tblMonHoc = string.IsNullOrWhiteSpace(kw)
                ? MonHocBLL.GetAll()
                : MonHocBLL.Search(kw);
            dgvMH.DataSource = tblMonHoc;
        }

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
        private void gbtnLuu_Click(object sender, EventArgs e)
        {
            string err = MonHocBLL.Them(
                txtMonHoc.Text.Trim(),
                txtTenHoc.Text.Trim(),
                txtSotinchi.Text.Trim(),
                txtCC.Text.Trim(),
                txtKT1.Text.Trim(),
                txtKT2.Text.Trim(),
                txtCK.Text.Trim());

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (err.Contains("mã")) { txtMonHoc.Text = ""; txtMonHoc.Focus(); }
                else if (err.Contains("tên")) txtTenHoc.Focus();
                else if (err.Contains("tín")) txtSotinchi.Focus();
                else if (err.Contains("chuyên")) txtCC.Focus();
                else if (err.Contains("tra 1")) txtKT1.Focus();
                else if (err.Contains("tra 2")) txtKT2.Focus();
                else if (err.Contains("cuối")) txtCK.Focus();
                return;
            }

            MessageBox.Show("Thêm môn học thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
            gbtnThem.Enabled = true;
            gbtnSua.Enabled = true;
            gbtnXoa.Enabled = true;
            gbtnLuu.Enabled = false;
            gbtnBoqua.Enabled = false;
            txtMonHoc.Enabled = false;
            ResetInputs();
        }


        private void gbtnSua_Click(object sender, EventArgs e)
        {
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string err = MonHocBLL.Sua(
                txtMonHoc.Text.Trim(),
                txtTenHoc.Text.Trim(),
                txtSotinchi.Text.Trim(),
                txtCC.Text.Trim(),
                txtKT1.Text.Trim(),
                txtKT2.Text.Trim(),
                txtCK.Text.Trim());

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (err.Contains("tên")) txtTenHoc.Focus();
                else if (err.Contains("tín")) txtSotinchi.Focus();
                else if (err.Contains("chuyên")) txtCC.Focus();
                else if (err.Contains("tra 1")) txtKT1.Focus();
                else if (err.Contains("tra 2")) txtKT2.Focus();
                else if (err.Contains("cuối")) txtCK.Focus();
                return;
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
            ResetInputs();
            gbtnBoqua.Enabled = false;
        }

        private void gbtnXoa_Click(object sender, EventArgs e)
        {
            if (tblMonHoc == null || tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string err = MonHocBLL.KiemTraXoa(txtMonHoc.Text.Trim());
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa môn học này không?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            MonHocBLL.Xoa(txtMonHoc.Text.Trim());
            MessageBox.Show("Xóa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
            ResetInputs();
            gbtnBoqua.Enabled = false;
        }

        private void gbtnBoqua_Click(object sender, EventArgs e)
        {
            gbtnBoqua.Enabled = false;
            gbtnThem.Enabled = true;
            gbtnSua.Enabled = true;
            gbtnXoa.Enabled = true;
            gbtnLuu.Enabled = false;
            txtMonHoc.Enabled = false;
            ResetInputs();
        }

        private void FrmMonHoc_Load_1(object sender, EventArgs e)
        {
            txtMonHoc.Enabled = false;
            gbtnLuu.Enabled = false;
            gbtnBoqua.Enabled = false;
            LoadGrid();

            txtCC.KeyPress += HeSo_KeyPress;
            txtKT1.KeyPress += HeSo_KeyPress;
            txtKT2.KeyPress += HeSo_KeyPress;
            txtCK.KeyPress += HeSo_KeyPress;
            txtSotinchi.KeyPress += SoNguyen_KeyPress;
        }
    }
}
