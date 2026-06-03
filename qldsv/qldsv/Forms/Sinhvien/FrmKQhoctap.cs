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
    public partial class FrmKQhoctap : Form
    {
        private DataRow _thongTinSV;

        public FrmKQhoctap()
        {
            InitializeComponent();
        }

       
        

        private void LoadThongTinSinhVien()
        {
            _thongTinSV = KQHocTapBLL.GetThongTinSinhVien(CurrentUser.MaDoiTuong);
            if (_thongTinSV != null)
            {
                lblMSSV.Text = "MSSV: " + _thongTinSV["MaSinhVien"].ToString();
                lblHoTen.Text = "Họ tên: " + _thongTinSV["HoTen"].ToString();
                lblLop.Text = "Lớp: " + _thongTinSV["TenLop"].ToString();
                lblKhoa.Text = "Khoa: " + _thongTinSV["TenKhoa"].ToString();
            }
        }

        private void LoadNamHoc()
        {
            cboNamHoc.SelectedIndexChanged -= cboNamHoc_SelectedIndexChanged_1;

            DataTable dt = KQHocTapBLL.GetNamHoc();
            cboNamHoc.DataSource = dt;
            cboNamHoc.DisplayMember = "NamHoc";
            cboNamHoc.ValueMember = "NamHoc";
            cboNamHoc.SelectedIndex = -1;

            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged_1;
        }

        private void LoadHocKy(string namHoc)
        {
            cboHocKy.SelectedIndexChanged -= cboHocKy_SelectedIndexChanged_1;

            if (string.IsNullOrEmpty(namHoc))
            {
                cboHocKy.DataSource = null;
                cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged_1;
                return;
            }

            DataTable dt = KQHocTapBLL.GetHocKyByNam(namHoc);
            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHocKy";
            cboHocKy.SelectedIndex = -1;

            cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged_1;
        }

        private void LoadDgvStructure()
        {
            dgvKQ.AutoGenerateColumns = false;
            dgvKQ.AllowUserToAddRows = false;
            dgvKQ.EditMode = DataGridViewEditMode.EditProgrammatically;

            colSTT.DataPropertyName = "STT";
            colMaHP.DataPropertyName = "MaLHP";
            colTenHP.DataPropertyName = "TenMon";
            colHeSoCC.DataPropertyName = "HeSoChuyenCan";
            colHeSoKT1.DataPropertyName = "HeSoKT1";
            colHeSoKT2.DataPropertyName = "HeSoKT2";
            colHeSoCK.DataPropertyName = "HeSoCuoiKy";
            colTC.DataPropertyName = "SoTinChi";
            colCC.DataPropertyName = "ChuyenCan";
            colKT1.DataPropertyName = "Kiemtra1";
            colKT2.DataPropertyName = "Kiemtra2";
            colCK.DataPropertyName = "CuoiKy";
            colHe10.DataPropertyName = "TongKet";
            colHe4.DataPropertyName = "He4";
            colChu.DataPropertyName = "DiemChu";

            foreach (DataGridViewColumn col in dgvKQ.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            
        }

       

        private void LoadKetQuaHocTap(int maHocKy)
        {
            DataTable dt = KQHocTapBLL.GetKetQuaHocTap(CurrentUser.MaDoiTuong, maHocKy);
            if (dt.Rows.Count == 0)
            {
                dgvKQ.DataSource = null;
                ResetSummary();

                MessageBox.Show(
                    "Chưa có dữ liệu điểm cho học kỳ này!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Thêm cột STT
            if (!dt.Columns.Contains("STT"))
                dt.Columns.Add("STT", typeof(int));

            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["STT"] = i + 1;

            dgvKQ.DataSource = dt;

            // Định dạng grid
            FormatGrid();

            // Tính tổng kết
            CalculateSummary(maHocKy);
        }

        private void FormatGrid()
        {
            // Định dạng số thập phân bằng Format, không ghi vào cell
            string[] decimalCols = { "colCC", "colKT1", "colKT2", "colCK", "colHe10", "colHe4" };
            foreach (string colName in decimalCols)
            {
                if (dgvKQ.Columns[colName] != null)
                    dgvKQ.Columns[colName].DefaultCellStyle.Format = "0.##";
            }

            // Tô màu theo điểm chữ
            foreach (DataGridViewRow row in dgvKQ.Rows)
            {
                string diemChu = row.Cells["colChu"].Value?.ToString() ?? "";
                row.Cells["colChu"].Style.BackColor = GetColorByGrade(diemChu);
            }
        }

        private Color GetColorByGrade(string diemChu)
        {
            switch (diemChu)
            {
                case "A+": return Color.LimeGreen;
                case "A": return Color.Green;
                case "B+": return Color.LightGreen;
                case "B": return Color.YellowGreen;
                case "C+": return Color.Khaki;
                case "C": return Color.Gold;
                case "D+": return Color.Orange;
                case "D": return Color.OrangeRed;
                case "F": return Color.Red;
                default: return Color.White;
            }
        }

        private void CalculateSummary(int maHocKy)
        {
            var tgtk = KQHocTapBLL.GetThongKeTongKetHocKy(CurrentUser.MaDoiTuong, maHocKy);
            var tgtl = KQHocTapBLL.GetThongKeTongKetTichLuy(CurrentUser.MaDoiTuong, maHocKy); // ← thêm maHocKy

            lblTB10.Text = "TB (10): " + tgtk["TB10"].ToString();
            lblTB4.Text = "TB (4.0): " + tgtk["TB4"].ToString();
            lblTinChi.Text = "Tín chỉ: " + tgtk["TongTC"].ToString();

            lblTBTL10.Text = "TB TL (10): " + tgtl["TB10"].ToString();
            lblTBTL4.Text = "TB TL (4.0): " + tgtl["TB4"].ToString();
            lblTinChiTL.Text = "TC TL: " + tgtl["TongTC"].ToString();

            double tb10 = Convert.ToDouble(tgtk["TB10"]);
            lblXepLoai.Text = "Xếp loại: " + XepLoai(tb10);
        }
        private string XepLoai(double tb10)
        {
            if (tb10 >= 9.0) return "Xuất sắc";
            if (tb10 >= 8.0) return "Giỏi";
            if (tb10 >= 7.0) return "Khá";
            if (tb10 >= 5.0) return "Trung bình";
            if (tb10 >= 4.0) return "Yếu";
            return "Kém";
        }

        private void ResetSummary()
        {
            lblTB10.Text = "TB (10): 0.00";
            lblTB4.Text = "TB (4.0): 0.00";
            lblTinChi.Text = "Tín chỉ: 0";
            lblTBTL10.Text = "TB TL (10): 0.00";
            lblTBTL4.Text = "TB TL (4.0): 0.00";
            lblTinChiTL.Text = "TC TL: 0";
            lblXepLoai.Text = "Xếp loại: ";
        }

        private void cboHocKy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvKQ.DataSource = null;
            ResetSummary();
            if (cboHocKy.SelectedIndex < 0 || cboHocKy.SelectedValue == null) return;
            int maHocKy = int.Parse(cboHocKy.SelectedValue.ToString());
            LoadKetQuaHocTap(maHocKy);
        }

        private void cboNamHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboHocKy.SelectedIndex = -1;
            dgvKQ.DataSource = null;
            ResetSummary();

            if (cboNamHoc.SelectedIndex < 0 || cboNamHoc.SelectedValue == null)
                return;

            string namHoc = cboNamHoc.SelectedValue.ToString();
            LoadHocKy(namHoc);
        }

        private void FrmKQhoctap_Load_1(object sender, EventArgs e)
        {
            LoadThongTinSinhVien();
            LoadNamHoc();
            LoadDgvStructure();
        }
    }
}
