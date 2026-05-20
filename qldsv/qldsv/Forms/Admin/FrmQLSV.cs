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
    public partial class FrmQLSV : Form
    {
        public FrmQLSV()
        {
            InitializeComponent();
        }
        DataTable tblSV;

        private void FrmQLSV_Load(object sender, EventArgs e)
        {

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMSV.Enabled = false;
         

            LoadLop();
            LoadTrangThai();
            Load_DataGridView();
        }
        private void LoadLop()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaLop, TenLop FROM Lop ORDER BY TenLop");

            cboLop.DataSource = dt.Copy();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndex = -1;


        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.AddRange(new string[] { "Đang Học", "Thôi Học", "Tốt Nghiệp" });
            cboTrangThai.SelectedIndex = -1;
        }

        private void Load_DataGridView()
        {
            tblSV = SinhVienBLL.GetAll();
            dgvSinhVien.AutoGenerateColumns = false;

            colMSV.DataPropertyName = "MaSinhVien";
            colHoTen.DataPropertyName = "HoTen";
            colNgaySinh.DataPropertyName = "NgaySinh";
            colGioiTinh.DataPropertyName = "GioiTinh";
            colLop.DataPropertyName = "TenLop";
            colEmail.DataPropertyName = "Email";
            colSDT.DataPropertyName = "SoDienThoai";
            colTrangThai.DataPropertyName = "TrangThai";

            dgvSinhVien.DataSource = tblSV;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvSinhVien.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ResetValues()
        {
            txtMSV.Text = "";
            txtHoten.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            cboLop.SelectedIndex = -1;
            txtEmail.Text = "";
            mskSDT.Text = "";
            cboTrangThai.SelectedIndex = 0;
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSV.Focus();
                return;
            }
            if (tblSV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
         

            txtMSV.Text = dgvSinhVien.CurrentRow.Cells["colMSV"].Value.ToString();
            txtHoten.Text = dgvSinhVien.CurrentRow.Cells["colHoTen"].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.CurrentRow.Cells["colNgaySinh"].Value);

            string gioiTinh = dgvSinhVien.CurrentRow.Cells["colGioiTinh"].Value.ToString();
            if (gioiTinh == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            string maLop = dgvSinhVien.CurrentRow.Cells["colLop"].Value.ToString();
            cboLop.Text = Functions.GetFieldValues(
                "SELECT TenLop FROM Lop WHERE MaLop = '" + maLop + "'");

            txtEmail.Text = dgvSinhVien.CurrentRow.Cells["colEmail"].Value?.ToString();
            mskSDT.Text = dgvSinhVien.CurrentRow.Cells["colSDT"].Value?.ToString();
            cboTrangThai.Text = dgvSinhVien.CurrentRow.Cells["colTrangthai"].Value.ToString();

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
            txtMSV.Enabled = true;
            ResetValues();
            txtMSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblSV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMSV.Enabled = false;
            txtHoten.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
      
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMSV.Enabled = false;
            txtMSV.Text = "";
            txtHoten.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            cboLop.SelectedIndex = -1;
            txtEmail.Text = "";
            mskSDT.Text = "";
            cboTrangThai.SelectedIndex = -1;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (tblSV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMSV.Text.Trim();
            string hoTen = txtHoten.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                "Xác nhận xóa sinh viên [" + maSV + "] " + hoTen + "?\nTài khoản đăng nhập cũng sẽ bị xóa!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string loi = SinhVienBLL.Xoa(maSV);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            ResetValues();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }
        private void LocDanhSach()
        {
            if (tblSV == null) return;

            string keyword = txtTimKiem.Text.Trim().ToLower();

            DataView dv = tblSV.DefaultView;

            if (string.IsNullOrEmpty(keyword))
                dv.RowFilter = "";
            else
                dv.RowFilter = $"MaSinhVien LIKE '%{keyword}%' " +
                               $"OR HoTen LIKE '%{keyword}%' " +
                               $"OR TenLop LIKE '%{keyword}%'";

            dgvSinhVien.DataSource = dv.ToTable();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nu";
            string trangThai = cboTrangThai.SelectedItem?.ToString() ?? "";
            string loi = "";

            if (txtMSV.Enabled)
                loi = SinhVienBLL.Them(txtMSV.Text, txtHoten.Text,
                    dtpNgaySinh.Value.ToString("yyyy-MM-dd"), gioiTinh,
                    txtEmail.Text, mskSDT.Text, maLop, trangThai);
            else
                loi = SinhVienBLL.Sua(txtMSV.Text, txtHoten.Text,
                    dtpNgaySinh.Value.ToString("yyyy-MM-dd"), gioiTinh,
                    txtEmail.Text, mskSDT.Text, maLop, trangThai);

            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(txtMSV.Enabled ? "Thêm thành công!" : "Cập nhật thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMSV.Enabled = false;
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSinhVien.Rows.Count == 0 && !string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
