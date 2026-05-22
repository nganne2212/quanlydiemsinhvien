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
    public partial class FrmPhucKhao : Form
    {
        public FrmPhucKhao()
        {
            InitializeComponent();
        }

        private void FrmPhucKhao_Load(object sender, EventArgs e)
        {
            splitMain.SplitterDistance = 480;
            LoadHocKy();
            LoadTrangThai();
            LoadData();
            ResetThongTin();
        }
        private void LoadHocKy()
        {
            DataTable dt = PhucKhaoBLL.GetHocKyCoDon();

            DataRow r = dt.NewRow();
            r["MaHocKy"] = 0;
            r["TenHocKy"] = "-- Tất cả --";

            dt.Rows.InsertAt(r, 0);

            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = 0;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("-- Tất cả --");
            cboTrangThai.Items.Add("Chưa Xử Lý");
            cboTrangThai.Items.Add("Đã Xử Lý");

            cboTrangThai.SelectedIndex = 0;
        }

       
        DataTable tblPhucKhao;
        private void LoadData()
        {
            int maHK = 0;

            if (cboHocKy.SelectedValue != null
                && !(cboHocKy.SelectedValue is DataRowView))
            {
                maHK = Convert.ToInt32(cboHocKy.SelectedValue);
            }

            string trangThai = cboTrangThai.SelectedIndex > 0
                ? cboTrangThai.SelectedItem.ToString()
                : "";

            tblPhucKhao = PhucKhaoBLL.GetAll(maHK, trangThai);

            string kw = txtSearch.Text.Trim().Replace("'", "''");

            DataView dv = tblPhucKhao.DefaultView;

            dv.RowFilter = string.IsNullOrEmpty(kw)
                ? ""
                : $"TenSinhVien LIKE '%{kw}%' OR TenMon LIKE '%{kw}%'";

            dgvPhucKhao.AutoGenerateColumns = false;

            colMaPhucKhaoHidden.DataPropertyName = "MaPhucKhao";
            colMaDangKy.DataPropertyName = "MaDangKyRef";

            colMaPhucKhao.DataPropertyName = "MaPhucKhao";
            colSinhVien.DataPropertyName = "TenSinhVien";
            colMonHoc.DataPropertyName = "TenMon";
            colNgayGui.DataPropertyName = "NgayGui";
            colTrangThai.DataPropertyName = "TrangThai";

            dgvPhucKhao.DataSource = dv.ToTable();

            dgvPhucKhao.AllowUserToAddRows = false;

            for (int i = 0; i < dgvPhucKhao.Rows.Count; i++)
            {
                dgvPhucKhao.Rows[i].Cells["colSTT"].Value = i + 1;

                string tt = dgvPhucKhao.Rows[i]
                    .Cells["colTrangThai"].Value?.ToString();

                if (tt == "DaXuLy")
                {
                    dgvPhucKhao.Rows[i].DefaultCellStyle.BackColor =
                        Color.FromArgb(240, 240, 240);

                    dgvPhucKhao.Rows[i].DefaultCellStyle.ForeColor =
                        Color.Gray;
                }
                else
                {
                    dgvPhucKhao.Rows[i].DefaultCellStyle.BackColor =
                        Color.White;

                    dgvPhucKhao.Rows[i].DefaultCellStyle.ForeColor =
                        Color.Black;
                }
            }
        }
        private void ResetThongTin()
        {
            lblMaDon.Text = "Mã đơn:";
            lblSinhVienInfo.Text = "Sinh viên:";
            lblMonHocInfo.Text = "Môn học:";
            lblNgayGuiInfo.Text = "Ngày gửi:";
            lblGVXuLy.Text = "Giảng viên xử lý:";

            txtLyDo.Text = "";
            txtDiemCu.Text = "";
            txtDiemMoi.Text = "";
            txtNhanXet.Text = "";

            cboKetLuan.SelectedIndex = -1;

            dtpNgayXuLy.Value = DateTime.Now;

            txtDiemMoi.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedValue == null)
                return;

            if (cboHocKy.SelectedValue is DataRowView)
                return;

            LoadData();
            ResetThongTin();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.SelectedIndex < 0)
                return;

            LoadData();
            ResetThongTin();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPhucKhao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPhucKhao.CurrentRow == null)
                return;

            var row = dgvPhucKhao.CurrentRow;

            int maPhucKhao = Convert.ToInt32(
                row.Cells["colMaPhucKhaoHidden"].Value);

            string trangThai =
                row.Cells["colTrangThai"].Value?.ToString();

            DataRow[] rows =
                tblPhucKhao.Select($"MaPhucKhao = {maPhucKhao}");

            string lyDo = rows.Length > 0
                ? rows[0]["LyDo"]?.ToString() ?? ""
                : "";

            string diemCu = rows.Length > 0
                ? rows[0]["DiemCu"]?.ToString() ?? ""
                : "";

            string tenGV = rows.Length > 0
                ? rows[0]["TenGiangVien"]?.ToString() ?? ""
                : "";

            lblMaDon.Text =
                $"Mã đơn: {row.Cells["colMaPhucKhao"].Value}";

            lblSinhVienInfo.Text =
                $"Sinh viên: {row.Cells["colSinhVien"].Value}";

            lblMonHocInfo.Text =
                $"Môn học: {row.Cells["colMonHoc"].Value}";

            lblNgayGuiInfo.Text =
                $"Ngày gửi: {Convert.ToDateTime(row.Cells["colNgayGui"].Value):dd/MM/yyyy}";

            lblGVXuLy.Text =
                $"Giảng viên xử lý: {tenGV}";

            txtLyDo.Text = lyDo;
            txtDiemCu.Text = diemCu;

            txtDiemMoi.Text = "";
            txtNhanXet.Text = "";

            cboKetLuan.SelectedIndex = -1;

            dtpNgayXuLy.Value = DateTime.Now;

            txtDiemMoi.Enabled = false;

            btnCapNhat.Enabled = trangThai == "Chưa Xử Lý";
        }

        private void cboKetLuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool thayDoi =
                cboKetLuan.SelectedItem?.ToString() == "Thay Đổi";

            txtDiemMoi.Enabled = thayDoi;

            if (!thayDoi)
                txtDiemMoi.Text = txtDiemCu.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvPhucKhao.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn phúc khảo!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var row = dgvPhucKhao.CurrentRow;

            int maPhucKhao = Convert.ToInt32(
                row.Cells["colMaPhucKhaoHidden"].Value);

            int maDangKy = Convert.ToInt32(
                row.Cells["colMaDangKy"].Value);

            DataRow[] rows =
                tblPhucKhao.Select($"MaPhucKhao = {maPhucKhao}");

            string maGV = rows.Length > 0
                ? rows[0]["MaGiangVien"]?.ToString() ?? ""
                : "";

            if (!double.TryParse(txtDiemCu.Text, out double diemCu))
            {
                MessageBox.Show(
                    "Điểm hiện tại không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            double diemMoi = diemCu;

            string ketLuan =
                cboKetLuan.SelectedItem?.ToString() ?? "";

            if (ketLuan == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn kết luận!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (ketLuan == "Thay Đổi")
            {
                if (!double.TryParse(txtDiemMoi.Text, out diemMoi))
                {
                    MessageBox.Show(
                        "Điểm mới không hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                if (diemMoi < 0 || diemMoi > 10)
                {
                    MessageBox.Show(
                        "Điểm phải từ 0 đến 10!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }

            DialogResult rs = MessageBox.Show(
                $"Xác nhận xử lý đơn #{maPhucKhao}?\n\n" +
                $"Kết luận: {ketLuan}\n" +
                (ketLuan == "Thay Đổi"
                    ? $"Điểm mới: {diemMoi}"
                    : "Giữ nguyên điểm"),
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs != DialogResult.Yes)
                return;

            string loi = PhucKhaoBLL.XuLy(
                maPhucKhao,
                maDangKy,
                maGV,
                diemCu,
                diemMoi,
                txtNhanXet.Text.Trim(),
                ketLuan,
                dtpNgayXuLy.Value.ToString("yyyy-MM-dd"));

            if (loi != "")
            {
                MessageBox.Show(
                    loi,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            MessageBox.Show(
                "Xử lý phúc khảo thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadData();
            ResetThongTin();
        
    }
    }
}
