using qldsv.BLL;
using qldsv.Class;
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
    public partial class FrmQLGV : Form
    {
        public FrmQLGV()
        {
            InitializeComponent();
        }
        DataTable tblGV;

        private void FrmQLGV_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaGV.Enabled = false;

            LoadKhoa();
            Load_DataGridView();
        }
        private void LoadKhoa()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");

            cboKhoa.DataSource = dt.Copy();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;

        }

        private void Load_DataGridView()
        {
            

            dgvGiangVien.AutoGenerateColumns = false;

            colMaGV.DataPropertyName = "MaGiangVien";
            colHoTen.DataPropertyName = "HoTen";
            colEmailGV.DataPropertyName = "Email";
            colKhoa.DataPropertyName = "MaKhoa";
            tblGV = QLGiangvienBLL.GetAll();
            dgvGiangVien.DataSource = tblGV;
            dgvGiangVien.AllowUserToAddRows = false;
            dgvGiangVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvGiangVien.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void ResetValues()
        {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            cboKhoa.SelectedIndex = -1;
        }

        private void dgvGiangVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGV.Focus();
                return;
            }
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiện thị", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaGV.Text = dgvGiangVien.CurrentRow.Cells["colMaGV"].Value.ToString();
            txtHoTen.Text = dgvGiangVien.CurrentRow.Cells["colHoTen"].Value.ToString();
            txtEmail.Text = dgvGiangVien.CurrentRow.Cells["colEmailGV"].Value?.ToString();

            string maKhoa = dgvGiangVien.CurrentRow.Cells["colKhoa"].Value.ToString();
            
            cboKhoa.Text = Functions.QuerySingle<string>(
                "SELECT TenKhoa FROM Khoa WHERE MaKhoa = @ma",
                new { ma = maKhoa });

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaGV.Enabled = true;
            ResetValues();
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiện thị", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaGV.Enabled = false;
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKhoa = cboKhoa.SelectedValue?.ToString() ?? "";
            string loi = "";

            if (txtMaGV.Enabled)
                loi = QLGiangvienBLL .Them(txtMaGV.Text, txtHoTen.Text, txtEmail.Text, maKhoa);
            else
                loi = QLGiangvienBLL.Sua(txtMaGV.Text, txtHoTen.Text, txtEmail.Text, maKhoa);

            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(txtMaGV.Enabled ? "Thêm thành công!" : "Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaGV.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaGV.Enabled = false;
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiện thị", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGV = txtMaGV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                "Xác nhận xóa giảng viên [" + maGV + "] " + hoTen + "?\nTài khoản đăng nhập cũng sẽ bị xóa!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string loi = QLGiangvienBLL.Xoa(maGV);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa giảng viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            ResetValues();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }
        private void LocDanhSach()
        {
            if (tblGV == null) return;

            string keyword = txtTimKiem.Text.Trim().Replace("'", "''"); 

            DataView dv = tblGV.DefaultView;
            dv.RowFilter = $"(MaGiangVien LIKE '%{keyword}%' OR HoTen LIKE '%{keyword}%' OR MaKhoa LIKE '%{keyword}%')";

            DataTable dtFilter = dv.ToTable();

        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvGiangVien.Rows.Count == 0 && !string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
                    MessageBox.Show("Không tìm thấy giảng viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
