using System;
using System.Data;
using System.Windows.Forms;
using qldsv.BLL;
using qldsv.DAL;
using qldsv.Class;

namespace qldsv.Forms.Admin
{
    public partial class FrmQLLop : Form
    {
        private DataTable dtLop = new DataTable();
        private bool dangSua = false;
        private bool dangThem = false;
        private bool dangLoad = false;

        public FrmQLLop()
        {
            InitializeComponent();
            this.Load += FrmQLLop_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnLuu.Click += btnLuu_Click;
            btnBoQua.Click += btnBoQua_Click;
            btnXoa.Click += btnXoa_Click;
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.KeyPress += txtTimKiem_KeyPress;
            cboLocKhoa.SelectedIndexChanged += cboLocKhoa_SelectedIndexChanged;
            dgvLop.CellClick += dgvLop_CellClick;
        }

        
        private void FrmQLLop_Load(object sender, EventArgs e)
        {
            dangLoad = true;

            Functions.Connect();
            LoadKhoa_Internal();
            LoadLocKhoa_Internal();
            LoadDanhSachLop_Internal();
            Functions.Disconnect();

            dangLoad = false;
            SetTrangThaiForm(false);
            XoaForm();
        }

        private void LoadDanhSachLop_Internal()
        {
            string sql = @"
                SELECT ROW_NUMBER() OVER (ORDER BY l.MaLop) AS STT,
                       l.MaLop, l.TenLop, k.TenKhoa,
                       gv.HoTen AS CoVanHocTap,
                       COUNT(sv.MaSinhVien) AS SiSo
                FROM Lop l
                JOIN      Khoa      k  ON l.MaKhoa     = k.MaKhoa
                JOIN      GiangVien gv ON l.MaGiangVien = gv.MaGiangVien
                LEFT JOIN SinhVien  sv ON l.MaLop       = sv.MaLop
                GROUP BY l.MaLop, l.TenLop, k.TenKhoa, gv.HoTen
                ORDER BY l.MaLop";
            dtLop = Functions.GetDataToTable(sql);
            BindGrid(dtLop);
        }

        private void LoadKhoa_Internal()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
            cboKhoa.DataSource = dt;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;
        }

        private void LoadLocKhoa_Internal()
        {
            DataTable dt = Functions.GetDataToTable(
                "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
            DataRow dr = dt.NewRow();
            dr["MaKhoa"] = "";
            dr["TenKhoa"] = "-- Tất cả khoa --";
            dt.Rows.InsertAt(dr, 0);
            cboLocKhoa.DataSource = dt;
            cboLocKhoa.DisplayMember = "TenKhoa";
            cboLocKhoa.ValueMember = "MaKhoa";
            cboLocKhoa.SelectedIndex = 0;
        }

        private void BindGrid(DataTable dt)
        {
            dgvLop.DataSource = dt;
            if (dgvLop.Columns.Count == 0) return;
            if (dgvLop.Columns.Contains("STT")) { dgvLop.Columns["STT"].HeaderText = "STT"; dgvLop.Columns["STT"].Width = 50; }
            if (dgvLop.Columns.Contains("MaLop")) dgvLop.Columns["MaLop"].HeaderText = "Mã lớp";
            if (dgvLop.Columns.Contains("TenLop")) dgvLop.Columns["TenLop"].HeaderText = "Tên lớp";
            if (dgvLop.Columns.Contains("TenKhoa")) dgvLop.Columns["TenKhoa"].HeaderText = "Khoa";
            if (dgvLop.Columns.Contains("CoVanHocTap")) dgvLop.Columns["CoVanHocTap"].HeaderText = "Cố vấn học tập";
            if (dgvLop.Columns.Contains("SiSo")) dgvLop.Columns["SiSo"].HeaderText = "Sĩ số";
        }

        
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangLoad) return;
            string maKhoa = cboKhoa.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maKhoa)) return;

            DataTable dt = QLLopDAL.GetGiangVienTheoKhoa(maKhoa);
            cboCVHT.DataSource = dt;
            cboCVHT.DisplayMember = "HoTen";
            cboCVHT.ValueMember = "MaGiangVien";
            cboCVHT.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dangThem = true; dangSua = false;
            XoaForm();
            SetTrangThaiForm(true);
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = dgvLop.CurrentRow.Cells["MaLop"].Value?.ToString();
            LopDTO lop = QLLopDAL.GetLopByMa(maLop);
            if (lop == null) return;

            dangLoad = true;

          
            DataTable dtGV = QLLopDAL.GetGiangVienTheoKhoa(lop.MaKhoa);
            cboCVHT.DataSource = dtGV;
            cboCVHT.DisplayMember = "HoTen";
            cboCVHT.ValueMember = "MaGiangVien";

            txtMaLop.Text = lop.MaLop;
            txtTenLop.Text = lop.TenLop;
            cboKhoa.SelectedValue = lop.MaKhoa;
            cboCVHT.SelectedValue = lop.MaGiangVien;

            dangLoad = false;

            dangSua = true; dangThem = false;
            SetTrangThaiForm(true);
            txtMaLop.Enabled = false;
        }

       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            LopDTO lop = DocDuLieuForm();
            string loi = dangThem ? QLLopBLL.Them(lop) : QLLopBLL.Sua(lop);

            if (!string.IsNullOrEmpty(loi))
            {
                MessageBox.Show(loi, "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(dangThem ? "Thêm lớp thành công!" : "Cập nhật lớp thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtLop = QLLopDAL.GetAllLop();
            BindGrid(dtLop);
            XoaForm();
            SetTrangThaiForm(false);
            dangThem = dangSua = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaForm();
            SetTrangThaiForm(false);
            dangThem = dangSua = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = dgvLop.CurrentRow.Cells["MaLop"].Value?.ToString();
            string tenLop = dgvLop.CurrentRow.Cells["TenLop"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa lớp [{maLop}] - {tenLop}?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            string loi = QLLopBLL.Xoa(maLop);
            if (!string.IsNullOrEmpty(loi))
            {
                MessageBox.Show(loi, "Không thể xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Xóa lớp thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtLop = QLLopDAL.GetAllLop();
            BindGrid(dtLop);
            XoaForm();
            SetTrangThaiForm(false);
        }

       
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangLoad) ApplyFilter();
        }

        private void ApplyFilter()
        {
            string kw = txtTimKiem.Text.Trim().Replace("'", "''");
            string maKhoa = cboLocKhoa.SelectedValue?.ToString() ?? "";

            if (!string.IsNullOrEmpty(maKhoa))
            {
                DataTable dtLoc = QLLopDAL.GetAllLop();
                DataView dv = dtLoc.DefaultView;
                string khoa = maKhoa.Replace("'", "''");
                dv.RowFilter = $"(MaLop LIKE '%{kw}%' OR TenLop LIKE '%{kw}%') AND TenKhoa = '{khoa}'";
                dgvLop.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = dtLop.DefaultView;
                dv.RowFilter = $"MaLop LIKE '%{kw}%' OR TenLop LIKE '%{kw}%'";
                dgvLop.DataSource = dv.ToTable();
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dangThem || dangSua || e.RowIndex < 0) return;
            DataGridViewRow row = dgvLop.Rows[e.RowIndex];
            txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
            txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
        }

       
        private LopDTO DocDuLieuForm() => new LopDTO
        {
            MaLop = txtMaLop.Text.Trim(),
            TenLop = txtTenLop.Text.Trim(),
            MaKhoa = cboKhoa.SelectedValue?.ToString() ?? "",
            MaGiangVien = cboCVHT.SelectedValue?.ToString() ?? ""
        };

        private void XoaForm()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboKhoa.SelectedIndex = -1;
            cboCVHT.SelectedIndex = -1;
            cboCVHT.DataSource = null;
        }

        private void SetTrangThaiForm(bool editing)
        {
            txtMaLop.Enabled = editing;
            txtTenLop.Enabled = editing;
            cboKhoa.Enabled = editing;
            cboCVHT.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnBoQua.Enabled = editing;

            dgvLop.Enabled = !editing;
            txtTimKiem.Enabled = !editing;
            cboLocKhoa.Enabled = !editing;
        }
    }
}