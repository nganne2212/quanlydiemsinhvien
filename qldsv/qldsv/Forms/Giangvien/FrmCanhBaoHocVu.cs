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

namespace qldsv.Forms.Giangvien
{
    public partial class FrmCanhBaoHocVu : Form
    {
        public FrmCanhBaoHocVu()
        {
            InitializeComponent();
        }
        DataTable tblGoc;
        string maGiangVien;

        private void FrmCanhBaoHocVu_Load(object sender, EventArgs e)
        {
            maGiangVien = CurrentUser.MaDoiTuong;

            LoadHocKy();
            LoadLop();
            LoadMuc();
            LoadData();

        }
        private void LoadHocKy()
        {
            DataTable dt = CanhBaoHocVuBLL.GetHocKyByGiangVien(maGiangVien);

            DataRow row = dt.NewRow();
            row["MaHocKy"] = 0;
            row["TenHocKy"] = "-- Tất cả học kỳ --";
            dt.Rows.InsertAt(row, 0);

            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = 0;
        }

        private void LoadLop()
        {
            DataTable dt = CanhBaoHocVuBLL.GetLopByGiangVien(maGiangVien);

            DataRow row = dt.NewRow();
            row["MaLop"] = "Tất cả lớp";
            row["TenLop"] = "Tất cả lớp";

            dt.Rows.InsertAt(row, 0);

            cboLop.DataSource = dt;
            cboLop.DisplayMember = "MaLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndex = 0;
        }

        private void LoadMuc()
        {
            cboMuc.Items.Clear();
            cboMuc.Items.Add("-- Tất cả mức --");
            cboMuc.Items.Add("Cảnh Báo 1");
            cboMuc.Items.Add("Cảnh Báo 2");
            cboMuc.Items.Add("Buộc Thôi Học");
            cboMuc.SelectedIndex = 0;
        }

        private void LoadData()
        {
            tblGoc = CanhBaoHocVuBLL.GetByGiangVien(maGiangVien);
            BindDgv(tblGoc);
        }
        private void BindDgv(DataTable dt)
        {
            dgvCanhBao.AutoGenerateColumns = false;

            colMSSV.DataPropertyName = "MaSinhVien";
            colHoTen.DataPropertyName = "HoTen";
            colLop.DataPropertyName = "TenLop";
            colHocKy.DataPropertyName = "TenHocKy";
            colDiemHK.DataPropertyName = "DiemHK";
            colTBTL.DataPropertyName = "TBTL";
            colTCTL.DataPropertyName = "TCTL";
            colSoKy.DataPropertyName = "SoKyDaBiCB";
            colMucCB.DataPropertyName = "MucCanhBao";
            colLyDo.DataPropertyName = "LyDo";

            dgvCanhBao.DataSource = dt;

            // STT
            for (int i = 0; i < dgvCanhBao.Rows.Count; i++)
                dgvCanhBao.Rows[i].Cells["colSTT"].Value = i + 1;

            ToMauDong();
            CapNhatTong(dt.Rows.Count);
        }

        private void ToMauDong()
        {
            foreach (DataGridViewRow row in dgvCanhBao.Rows)
            {
                string muc = row.Cells["colMucCB"]?.Value?.ToString();

                if (muc == "BuocThoiHoc")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.Cells["colMucCB"].Value = "Buộc Thôi Học";
                }
                else if (muc == "CanhBao2")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                    row.DefaultCellStyle.ForeColor = Color.DarkOrange;
                    row.Cells["colMucCB"].Value = "Cảnh Báo 2";
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.Cells["colMucCB"].Value = "Cảnh Báo 1";
                }
            }

        }
        private void CapNhatTong(int soLuong)
        {
            lblTong.Text = "Tổng sinh viên cảnh báo: " + soLuong;
        }



        private void LocDanhSach()
        {
            if (tblGoc == null) return;

            int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue ?? 0);
            string maLop = cboLop.SelectedValue?.ToString() ?? "";
            string muc = cboMuc.SelectedIndex > 0 ? cboMuc.SelectedItem.ToString() : "";
            string kw = txtSearch.Text.Trim().Replace("'", "''");

            DataView dv = tblGoc.DefaultView;
            string filter = "";

            if (maHocKy > 0)
                filter += $"MaHocKy = {maHocKy}";

            if (!string.IsNullOrEmpty(maLop))
                filter += (filter != "" ? " AND " : "") + $"MaLop = '{maLop}'";

            if (!string.IsNullOrEmpty(muc))
                filter += (filter != "" ? " AND " : "") + $"MucCanhBao = '{muc}'";

            if (!string.IsNullOrEmpty(kw))
                filter += (filter != "" ? " AND " : "") +
                          $"(MaSinhVien LIKE '%{kw}%' OR HoTen LIKE '%{kw}%')";

            dv.RowFilter = filter;

            DataTable dt = dv.ToTable();
            BindDgv(dt);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void cboMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LocDanhSach();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvCanhBao.Rows.Count == 0 &&
                    !string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
