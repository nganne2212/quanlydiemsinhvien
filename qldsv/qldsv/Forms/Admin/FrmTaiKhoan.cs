using qldsv.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            cboVaiTro.Items.AddRange(new string[] { "Tất cả", "Admin", "GiangVien", "SinhVien" });
            cboVaiTro.SelectedIndex = 0;

            cboTrangthai.Items.AddRange(new string[] { "Tất cả", "Active", "BiKhoa" });
            cboTrangthai.SelectedIndex = 0;

            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            DataTable dt = TaiKhoanBLL.GetAll();

            dt.Columns.Add("STT", typeof(int));
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;

            dgvTaikhoan.DataSource = dt;
            dgvTaikhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            dgvTaikhoan.Columns["VaiTro"].HeaderText = "Vai Trò";
            dgvTaikhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvTaikhoan.Columns["MatKhau"].Visible = false;
            dgvTaikhoan.Columns["MaNguoiDung"].Visible = false;
            dgvTaikhoan.Columns["STT"].DisplayIndex = 0;
            dgvTaikhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvTaikhoan.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTaikhoan.Columns["STT"].Width = 50;
            dgvTaikhoan.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void dgvTaikhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaikhoan.CurrentRow == null) return;
            lblTendangnhap.Text = dgvTaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            lblVaitro.Text = dgvTaikhoan.CurrentRow.Cells["VaiTro"].Value.ToString();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (dgvTaikhoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ten = dgvTaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            string loi = TaiKhoanBLL.KhoaTaiKhoan(ten);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã khóa tài khoản " + ten);
            LoadDanhSach();
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (dgvTaikhoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ten = dgvTaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            string loi = TaiKhoanBLL.MoKhoaTaiKhoan(ten);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã mở khóa tài khoản " + ten);
            LoadDanhSach();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (dgvTaikhoan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ten = dgvTaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            var confirm = MessageBox.Show(
                "Reset mật khẩu về mặc định (" + ten + ")?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string loi = TaiKhoanBLL.ResetMatKhau(ten);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã reset mật khẩu về mặc định");
            LoadDanhSach();
        }
        private void LocDanhSach()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string vaiTro = cboVaiTro.SelectedItem?.ToString() ?? "Tất cả";
            string trangThai = cboTrangthai.SelectedItem?.ToString() ?? "Tất cả";

            DataTable dt = TaiKhoanBLL.GetAll();

            // Lọc
            DataView dv = dt.DefaultView;
            string filter = $"TenDangNhap LIKE '%{keyword}%'";
            if (vaiTro != "Tất cả") filter += $" AND VaiTro = '{vaiTro}'";
            if (trangThai != "Tất cả") filter += $" AND TrangThai = '{trangThai}'";
            dv.RowFilter = filter;

            DataTable dtFilter = dv.ToTable();
            dtFilter.Columns.Add("STT", typeof(int));
            for (int i = 0; i < dtFilter.Rows.Count; i++)
                dtFilter.Rows[i]["STT"] = i + 1;

            dgvTaikhoan.DataSource = dtFilter;
            dgvTaikhoan.Columns["MatKhau"].Visible = false;
            dgvTaikhoan.Columns["MaNguoiDung"].Visible = false;
            dgvTaikhoan.Columns["STT"].DisplayIndex = 0;
            dgvTaikhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            dgvTaikhoan.Columns["VaiTro"].HeaderText = "Vai Trò";
            dgvTaikhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvTaikhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvTaikhoan.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTaikhoan.Columns["STT"].Width = 50;
            dgvTaikhoan.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void cboTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
            !char.IsControl(e.KeyChar) &&
            e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        
    }

}
