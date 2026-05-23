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

        private DataTable _tblPreview;

        public FrmPreviewImportDiem(DataTable tblPreview)
        {
            InitializeComponent();
            _tblPreview = tblPreview;
        }

        private void FrmPreviewImportDiem_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            int hopLe = 0, loi = 0;
            foreach (DataRow row in _tblPreview.Rows)
            {
                if (row["HopLe"].ToString() == "True") hopLe++;
                else loi++;
            }

            lblThongKe.Text = $"Tổng: {_tblPreview.Rows.Count}  |  Hợp lệ: {hopLe}  |  Lỗi: {loi}";

            dgvPreview.AutoGenerateColumns = false;
            colSTT.DataPropertyName = "STT";
            colMSSV.DataPropertyName = "MSSV";
            colHoTen.DataPropertyName = "HoTen";
            colCC.DataPropertyName = "CC";
            colKT1.DataPropertyName = "KT1";
            colKT2.DataPropertyName = "KT2";
            colCK.DataPropertyName = "CK";
            colTrangThai.DataPropertyName = "TrangThai";
            colLyDo.DataPropertyName = "LyDo";

            dgvPreview.DataSource = _tblPreview;
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.EditMode = DataGridViewEditMode.EditProgrammatically;

            foreach (DataGridViewColumn col in dgvPreview.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Tô màu
            foreach (DataGridViewRow row in dgvPreview.Rows)
            {
                bool hl = _tblPreview.Rows[row.Index]["HopLe"].ToString() == "True";
                row.DefaultCellStyle.BackColor = hl
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
