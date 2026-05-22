using qldsv.BLL;
using qldsv.Utils;
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
    public partial class FrmPreviewImport : Form
    {
        public FrmPreviewImport()
        {
            InitializeComponent();
        }
        private List<ImportResult> _ketQua;
        private string _maLHP;
        public FrmPreviewImport(List<ImportResult> ketQua, string maLHP)
        {
            InitializeComponent();
            _ketQua = ketQua;
            _maLHP = maLHP;
        }

        private void FrmPreviewImport_Load(object sender, EventArgs e)
        {
            this.Text = "Xem trước import - LHP: " + _maLHP;
            HienThiKetQua();
            
            btnHuy.Click += (s, ev) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }
        private void HienThiKetQua()
        {
            // Thống kê
            int hopLe = _ketQua.Count(r => r.HopLe);
            int loi = _ketQua.Count(r => !r.HopLe);
            lblThongKe.Text = $"Tổng: {_ketQua.Count} dòng  |  Hợp lệ: {hopLe}  |  Lỗi: {loi}";

            // Bind vào DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaSV", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("TrangThai", typeof(string));
            dt.Columns.Add("LyDo", typeof(string));

            foreach (var r in _ketQua)
            {
                dt.Rows.Add(
                    r.STT,
                    r.MaSV,
                    r.HoTen,
                    r.HopLe ? "✔ Hợp lệ" : "✘ Lỗi",
                    r.LyDoLoi);
            }

            dgvPreview.AutoGenerateColumns = false;
            dgvPreview.DataSource = dt;
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Tô màu hàng lỗi
            foreach (DataGridViewRow row in dgvPreview.Rows)
            {
                bool hl = _ketQua[row.Index].HopLe;
                row.DefaultCellStyle.BackColor = hl
                    ? Color.FromArgb(232, 245, 233)   // xanh nhạt
                    : Color.FromArgb(255, 235, 238);   // đỏ nhạt
            }

            btnXacNhan.Enabled = hopLe > 0;
            btnXacNhan.Text = $"Thêm {hopLe} sinh viên hợp lệ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var dsMaSV = _ketQua.Where(r => r.HopLe).Select(r => r.MaSV).ToList();

            string loi = LopHocPhanBLL.ThemNhieuSVVaoLHP(dsMaSV, _maLHP);
            if (loi != "")
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Đã thêm thành công {dsMaSV.Count} sinh viên vào lớp học phần!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
