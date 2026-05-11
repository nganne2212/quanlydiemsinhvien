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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlDS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlThongtin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {

        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }

        private void pnlcard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVaitro_Click(object sender, EventArgs e)
        {

        }

        private void lblTendangnhap_Click(object sender, EventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }
    }
    
}
