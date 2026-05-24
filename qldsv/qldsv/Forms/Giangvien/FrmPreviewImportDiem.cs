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

namespace qldsv.Forms.Giangvien
{
    public partial class FrmPreviewImportDiem : Form
    {

        private List<ImportResult> _ketQua;

        public FrmPreviewImportDiem(List<ImportResult> ketQua)
        {
            InitializeComponent();
            _ketQua = ketQua;
        }

        private void FrmPreviewImportDiem_Load(object sender, EventArgs e)
        {
            HienThiKetQua();
        }
        private void HienThiKetQua()
        {
            int hopLe = 0, loi = 0;
            foreach (var r in _ketQua)
                if (r.HopLe) hopLe++; else loi++;

            lblThongKe.Text = $"Tổng: {_ketQua.Count}  |  Hợp lệ: {hopLe}  |  Lỗi: {loi}";

            dgvPreview.Rows.Clear();

            foreach (var r in _ketQua)
            {
                int idx = dgvPreview.Rows.Add(
                    r.STT, r.MaSV, r.HoTen,
                    r.CC, r.KT1, r.KT2, r.CK,
                    r.HopLe ? "✔ Hợp lệ" : "✘ Lỗi",
                    r.LyDoLoi);

                dgvPreview.Rows[idx].DefaultCellStyle.BackColor = r.HopLe
                    ? Color.FromArgb(220, 255, 220)
                    : Color.FromArgb(255, 235, 238);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
