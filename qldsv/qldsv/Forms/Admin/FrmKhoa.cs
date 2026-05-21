using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qldsv.BLL;

namespace qldsv.Forms.Admin
{
    public partial class FrmKhoa : Form
    {
        private bool isAdding = false;
        private bool isEditing = false;

        public FrmKhoa()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load += FrmKhoa_Load;
            this.btnThem.Click += BtnThem_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnBoQua.Click += BtnBoQua_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.dgvKhoa.CellClick += DgvKhoa_CellClick;
            this.txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void LoadData()
        {
            try
            {
                // TODO: Load data from database
                // Example: dgvKhoa.DataSource = GetKhoaList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ResetForm();
                txtMaKhoa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoa để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // TODO: Implement edit logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // TODO: Implement save logic
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            try
            {
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhoa.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoa để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // TODO: Implement delete logic
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                    txtMaKhoa.Text = row.Cells["colMaKhoa"].Value?.ToString() ?? "";
                    txtTenKhoa.Text = row.Cells["colTenKhoa"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: Implement search logic
                // Filter dgvKhoa based on txtTimKiem.Text
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            dgvKhoa.ClearSelection();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
            HideInputFields();
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnBoQua.Click += BtnBoQua_Click;
            dgvKhoa.CellClick += DgvKhoa_CellClick;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = KhoaBLL.GetAllKhoa();
                dgvKhoa.DataSource = dt;
                dgvKhoa.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideInputFields()
        {
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void ShowInputFields()
        {
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void ClearInputFields()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ShowInputFields();
            ClearInputFields();
            txtMaKhoa.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoa để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAdding = false;
            isEditing = true;
            ShowInputFields();
            txtMaKhoa.Enabled = false; // Không cho sửa mã khoa

            DataGridViewRow row = dgvKhoa.SelectedRows[0];
            txtMaKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
            txtTenKhoa.Text = row.Cells["colTenKhoa"].Value.ToString();
            txtTenKhoa.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoa để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dgvKhoa.SelectedRows[0];
                string maKhoa = row.Cells["colMaKhoa"].Value.ToString();

                if (KhoaBLL.XoaKhoa(maKhoa))
                {
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa khoa thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhoa.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhoa.Focus();
                return;
            }

            if (isAdding)
            {
                if (KhoaBLL.ThemKhoa(txtMaKhoa.Text, txtTenKhoa.Text))
                {
                    MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputFields();
                    HideInputFields();
                    isAdding = false;
                }
                else
                {
                    MessageBox.Show("Thêm khoa thất bại. Mã khoa có thể đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isEditing)
            {
                if (KhoaBLL.SuaKhoa(txtMaKhoa.Text, txtTenKhoa.Text))
                {
                    MessageBox.Show("Sửa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputFields();
                    HideInputFields();
                    isEditing = false;
                }
                else
                {
                    MessageBox.Show("Sửa khoa thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            HideInputFields();
            isAdding = false;
            isEditing = false;
        }

        private void DgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["colMaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["colTenKhoa"].Value.ToString();
            }
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = KhoaBLL.SearchKhoa(txtTimKiem.Text);
                dgvKhoa.DataSource = dt;
                dgvKhoa.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
