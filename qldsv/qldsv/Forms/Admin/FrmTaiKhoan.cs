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
            dgvTaikhoan.Columns["MatKhau"].Visible = false;
            dgvTaikhoan.Columns["MaNguoiDung"].Visible = false;
            dgvTaikhoan.Columns["STT"].DisplayIndex = 0;
            dgvTaikhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvTaikhoan.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvTaikhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaikhoan.CurrentRow == null) return;
            lblTendangnhap.Text = dgvTaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            lblVaitro.Text = dgvTaikhoan.CurrentRow.Cells["VaiTro"].Value.ToString();
        }
    }
    
}
