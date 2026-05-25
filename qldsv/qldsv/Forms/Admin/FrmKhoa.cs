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
    public partial class FrmKhoa : Form
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }

        DataTable tblKhoa;



        private void Load_DataGridView()
        {
            tblKhoa = KhoaBLL.GetAll();
            dgvKhoa.AutoGenerateColumns = false;

            colMaKhoa.DataPropertyName = "MaKhoa";
            colTenKhoa.DataPropertyName = "TenKhoa";

            dgvKhoa.DataSource = tblKhoa;
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvKhoa.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ResetValues()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhoa.Focus();
                return;
            }
            if (tblKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells["colMaKhoa"].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["colTenKhoa"].Value.ToString();

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
            txtMaKhoa.Enabled = true;
            ResetValues();
            txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaKhoa.Enabled = false;
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong CSDL", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKhoa = txtMaKhoa.Text.Trim();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa [" + maKhoa + "]?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            string loi = KhoaBLL.Xoa(maKhoa);

            if (loi != "")
            {
                MessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoa = txtTenKhoa.Text.Trim();

            if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loi = "";

            if (txtMaKhoa.Enabled) // Đang ở chế độ thêm mới
            {
                loi = KhoaBLL.Them(maKhoa, tenKhoa);
            }
            else // Đang ở chế độ sửa
            {
                loi = KhoaBLL.Sua(maKhoa, tenKhoa);
            }

            if (loi != "")
            {
                MessageBox.Show(loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Lưu khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaKhoa.Enabled = false;
        }



        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            tblKhoa = KhoaBLL.Search(keyword);
            dgvKhoa.DataSource = tblKhoa;
        }

        private void FrmKhoa_Load_1(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaKhoa.Enabled = false;

            Load_DataGridView();
        }
    }
    }

