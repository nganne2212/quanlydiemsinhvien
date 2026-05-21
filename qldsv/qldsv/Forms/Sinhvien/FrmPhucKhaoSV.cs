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

namespace qldsv.Forms.Sinhvien
{
    public partial class FrmPhucKhaoSV : Form
    {
        public FrmPhucKhaoSV()
        {
            InitializeComponent();
        }
        DataTable tblMonHoc;

        // ─── Load form ───────────────────────────────────────────────

        private void FrmPhucKhaoSV_Load(object sender, EventArgs e)
        {
            LoadHocKy();
            Load_DgvPhucKhao();
        }

        private void LoadHocKy()
        {
            DataTable dt = PhucKhaoSvBLL.GetHocKyDangDienRa();
            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = -1;
        }

        private void Load_DgvPhucKhao()
        {
            dgvPhucKhao.AutoGenerateColumns = false;
            colMonHoc.DataPropertyName = "MonHoc";
            colDiemCu.DataPropertyName = "CuoiKy";
            colNgayGui.DataPropertyName = "NgayGui";
            colTrangThai.DataPropertyName = "TrangThai";

            dgvPhucKhao.DataSource = PhucKhaoSvBLL.GetDanhSachPhucKhao(CurrentUser.MaDoiTuong);
            dgvPhucKhao.AllowUserToAddRows = false;
            dgvPhucKhao.EditMode = DataGridViewEditMode.EditProgrammatically;
            foreach (DataGridViewColumn col in dgvPhucKhao.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ResetValues()
        {
            cboHocKy.SelectedIndex = -1;
            cboMonHoc.DataSource = null;
            txtDiemHienTai.Text = "";
            txtLyDo.Text = "";
        }

        // ─── Sự kiện combobox ────────────────────────────────────────

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonHoc.SelectedIndexChanged -= cboMonHoc_SelectedIndexChanged;

            cboMonHoc.DataSource = null;
            txtDiemHienTai.Text = "";

            if (cboHocKy.SelectedIndex < 0 || cboHocKy.SelectedValue == null)
            {
                cboMonHoc.SelectedIndexChanged += cboMonHoc_SelectedIndexChanged;
                return;
            }

            if (!int.TryParse(cboHocKy.SelectedValue.ToString(), out int maHocKy))
            {
                cboMonHoc.SelectedIndexChanged += cboMonHoc_SelectedIndexChanged;
                return;
            }

            tblMonHoc = PhucKhaoSvBLL.GetMonHocCoThePKhao(CurrentUser.MaDoiTuong, maHocKy);
            cboMonHoc.DisplayMember = "TenMonHoc";
            cboMonHoc.ValueMember = "MaDangKy";
            cboMonHoc.DataSource = tblMonHoc;
            cboMonHoc.SelectedIndex = -1;

            cboMonHoc.SelectedIndexChanged += cboMonHoc_SelectedIndexChanged;
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiemHienTai.Text = "";
            if (cboMonHoc.SelectedIndex < 0 || cboMonHoc.SelectedValue == null) return;
            if (tblMonHoc == null) return;

            int maDangKy = int.Parse(cboMonHoc.SelectedValue.ToString());
            DataRow[] rows = tblMonHoc.Select($"MaDangKy = {maDangKy}");

            if (rows.Length > 0 && rows[0]["CuoiKy"] != DBNull.Value)
                txtDiemHienTai.Text = rows[0]["CuoiKy"].ToString();
        }

        // ─── Gửi đơn ─────────────────────────────────────────────────

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMonHoc.SelectedIndex < 0 || cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn môn học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDangKy = int.Parse(cboMonHoc.SelectedValue.ToString());
            string loi = PhucKhaoSvBLL.GuiPhucKhao(maDangKy, txtLyDo.Text);

            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Gửi đơn phúc khảo thành công!\nVui lòng chờ giảng viên xử lý.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Load_DgvPhucKhao();
            ResetValues();
        }

        // ─── Làm mới ─────────────────────────────────────────────────

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        // ─── Tô màu grid ─────────────────────────────────────────────

        private void dgvPhucKhao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string tt = dgvPhucKhao.Rows[e.RowIndex]
                                   .Cells["colTrangThai"].Value?.ToString() ?? "";
            Color mau;
            if (tt == "ChuaXuLy")
                mau = Color.FromArgb(255, 255, 180); // vàng
            else if (tt == "DaXuLy")
                mau = Color.FromArgb(180, 240, 200); // xanh
            else
                mau = Color.White;

            dgvPhucKhao.Rows[e.RowIndex].DefaultCellStyle.BackColor = mau;
        }

        
    }
}
