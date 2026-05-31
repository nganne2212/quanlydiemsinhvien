using ClosedXML.Excel;

using qldsv.BLL;
using qldsv.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace qldsv.Forms.Admin
{
    public partial class FrmDashBoard : Form
    {
        // ========================= CHART =========================

        private Chart chartTrendLine;
        private Chart chartPie;
        private Chart chartBar;
        private Chart chartColumn;
        private Chart chartHocLucRight;

        // ========================= FILTER =========================

        private int _maHocKy = 0;
        private string _maKhoa = "";
        private string _maLop = "";

        public FrmDashBoard()
        {
            InitializeComponent();

            FixLayout();

            this.Load += FrmDashBoard_Load;
        }

        // =========================================================
        // FIX LAYOUT
        // =========================================================

        private void FixLayout()
        {
            pnlChartLeft.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            pnlChartRight.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            pnlPieChart.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvHocLuc.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvHocLai.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            pnlDiemLeft.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            pnlDiemRight.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvThangDiem.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            pnlColumnChart.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvLichSu.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            InitCharts();
            LoadComboHocKy();
            LoadComboKhoa();
            SetDefaultHocKy();
            InitTab5();
            FormatPercentColumn(dgvHocLuc);
            FormatPercentColumn(dgvHocLai);
            FormatPercentColumn(dgvThangDiem);
            FormatPercentColumn(dgvLichSu);
           

        }

        // =========================================================
        // INIT CHART
        // =========================================================

        private void InitCharts()
        {
            chartTrendLine =
                CreateChartInPanel(pnlChartLeft);

            chartHocLucRight =
                CreateChartInPanel(pnlChartRight);

            chartPie =
                CreateChartInPanel(pnlPieChart);

            chartBar =
                CreateChartInPanel(pnlBarChart);

            chartColumn =
                CreateChartInPanel(pnlColumnChart);
        }

        private Chart CreateChartInPanel(Panel parent)
        {
            Chart chart = new Chart();

            chart.Left = 5;
            chart.Top = 40;

            chart.Width = parent.Width - 10;
            chart.Height = parent.Height - 45;

            chart.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            chart.BackColor = System.Drawing.Color.White;

            ChartArea area = new ChartArea();

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;

            chart.ChartAreas.Add(area);

            Legend legend = new Legend();
            chart.Legends.Add(legend);

            parent.Controls.Add(chart);

            return chart;
        }

        // =========================================================
        // COMBOBOX
        // =========================================================

        private void LoadComboHocKy()
        {
            DataTable dt = DashBoardBLL.GetAllHocKy();

            DataRow dr = dt.NewRow();

            dr["MaHocKy"] = 0;
            dr["TenHK"] = "-- Tất cả --";

            dt.Rows.InsertAt(dr, 0);

            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHocKy";

            if (dt.Rows.Count > 1)
                cboHocKy.SelectedIndex = 1;
        }

        private void LoadComboKhoa()
        {
            DataTable dt = DashBoardBLL.GetAllKhoa();

            DataRow dr = dt.NewRow();

            dr["MaKhoa"] = "";
            dr["TenKhoa"] = "-- Tất cả --";

            dt.Rows.InsertAt(dr, 0);

            cboKhoa.DataSource = dt;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            cboKhoa.SelectedIndex = 0;
        }

        private void SetDefaultHocKy()
        {
            if (cboHocKy.SelectedValue != null)
                _maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
            if (cboKhoa.SelectedValue != null)
                _maKhoa = cboKhoa.SelectedValue.ToString();
            _maLop = "";
            LoadAllTabs();
        }

        // =========================================================
        // BUTTON FILTER
        // =========================================================

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _maHocKy = cboHocKy.SelectedValue != null
         ? Convert.ToInt32(cboHocKy.SelectedValue) : 0;
            _maKhoa = cboKhoa.SelectedValue?.ToString() ?? "";
            _maLop = cboLop.SelectedValue?.ToString() ?? "";
            LoadAllTabs();
        }

        // =========================================================
        // LOAD ALL TAB
        // =========================================================

        private void LoadAllTabs()
        {
            LoadTab1();

            LoadTab2();

            LoadTab3();

            LoadTab4();
        }

        // =========================================================
        // TAB 1 – TỔNG QUAN
        // =========================================================

        private void LoadTab1()
        {
            DataRow dr = DashBoardBLL.GetTongQuan(_maHocKy, _maKhoa, _maLop);

            if (dr != null)
            {
                lblCard1Value.Text = dr["TongSinhVien"].ToString();
                lblCard3Value.Text = Convert.ToDouble(dr["TyLeDau"]).ToString("0.0") + "%";
                lblCard4Value.Text = Convert.ToDouble(dr["TyLeRot"]).ToString("0.0") + "%";
            }

            // Kiểm tra trạng thái HK độc lập, không phụ thuộc dr
            lblCard2Label.Text = "SV CẢNH BÁO";

            string trangThaiHK = Functions.GetFieldValues(
                "SELECT Trangthai FROM HocKy WHERE MaHocKy = @ma",
                new { ma = _maHocKy });

            if (trangThaiHK == "DangDienRa")
            {
                lblCard2Value.Text = "---";
                lblCard2Value.ForeColor = Color.Gray;
                lblCard2Value.Size = new Size(280, 45);
                lblCard2Value.Location = new Point(14, 28);

                lblCard2Note.Text = "⚠ Chưa đóng học kỳ";
                lblCard2Note.Location = new Point(14, 75);
                lblCard2Note.BringToFront();
                lblCard2Note.Visible = true;
            }
            else
            {
                lblCard2Value.Size = new Size(280, 78);
                lblCard2Value.Text = dr != null ? dr["SoCanhBao"].ToString() : "---";
                lblCard2Value.ForeColor = Color.FromArgb(74, 20, 140);
                lblCard2Note.Visible = false;
            }

            LoadChartTrend();
            LoadChartHocLucRight();
        }
        private void FormatPercentColumn(DataGridView dgv)
        {
            dgv.DataBindingComplete += (s, e) =>
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.HeaderText.Contains("%") ||
                        col.HeaderText.Contains("Tỉ lệ") ||
                        col.HeaderText.Contains("Tỷ lệ"))
                    {
                        col.DefaultCellStyle.Format = "0.0";
                    }
                }
            };
        }

        private void LoadChartTrend()
        {
            chartTrendLine.Series.Clear();

            DataTable dt = DashBoardBLL.GetDiemTBTheoHocKy(_maKhoa, _maLop);

            Series series = new Series("Điểm TB");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["TenHK"].ToString(),
                    Convert.ToDouble(row["DiemTB"])
                );
            }

            chartTrendLine.Series.Add(series);
        }

        private void LoadChartHocLucRight()
        {
            chartHocLucRight.Series.Clear();

            DataTable dt =
                DashBoardBLL.GetPhanBoHocLuc(_maHocKy, _maKhoa, _maLop);

            Series series =
                new Series("Số lượng");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["HocLuc"].ToString(),
                    Convert.ToInt32(row["SoLuong"])
                );
            }

            chartHocLucRight.Series.Add(series);
        }

        // =========================================================
        // TAB 2 – HỌC LỰC
        // =========================================================

        private void LoadTab2()
        {
            LoadPieChart();

            dgvHocLuc.DataSource =
               DashBoardBLL.GetHocLucTheoKhoa(_maHocKy, _maKhoa, _maLop);
        }

        private void LoadPieChart()
        {
            chartPie.Series.Clear();

            DataTable dt =
                DashBoardBLL.GetPhanBoHocLuc(
                    _maHocKy,
                    _maKhoa
                , _maLop);

            Series series =
                new Series("Học lực");

            series.ChartType =
                SeriesChartType.Pie;

            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["HocLuc"].ToString(),
                    Convert.ToInt32(row["SoLuong"])
                );
            }

            chartPie.Series.Add(series);
        }

        // =========================================================
        // TAB 3 – MÔN HỌC
        // =========================================================

        private void LoadTab3()
        {
            LoadChartMonTruot();

            dgvHocLai.DataSource =
                DashBoardBLL.GetHocLaiTheoMon(_maHocKy, _maKhoa, _maLop);
        }

        private void LoadChartMonTruot()
        {
            chartBar.Series.Clear();

            DataTable dt = DashBoardBLL.GetTop10MonTruot(_maHocKy, _maKhoa, _maLop);

            Series series = new Series("Tỷ lệ trượt");
            series.ChartType = SeriesChartType.Bar;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["Môn học"].ToString(),        // ← sửa từ "TenMon"
                    row["TyLeTruot"]  // ← sửa từ "TyLeTruot"
                );
            }

            chartBar.Series.Add(series);
        }

        // =========================================================
        // TAB 4 – THỐNG KÊ ĐIỂM
        // =========================================================

        private void LoadTab4()
        {
            dgvThangDiem.DataSource =
                DashBoardBLL.GetThongKeThangDiem(_maHocKy, _maKhoa, _maLop); // bang diem chu

            LoadChartPhanBoDiem(); // chart dung GetPhanBoDiemThang10
        }

        private void LoadChartPhanBoDiem()
        {
            chartColumn.Series.Clear();

            DataTable dt = DashBoardBLL.GetPhanBoDiemThang10(_maHocKy, _maKhoa, _maLop);

            if (dt == null || dt.Rows.Count == 0) return;

            Series series = new Series("Số SV");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["KhoangDiem"].ToString(),
                    Convert.ToInt32(row["SoSinhVien"])
                );
            }

            chartColumn.Series.Add(series);
        }
        private void InitTab5()
        {
            cboBaoCao.Items.Clear();
            cboBaoCao.Items.Add("Thống kê tổng quan");
            cboBaoCao.Items.Add("Học lực theo khoa");
            cboBaoCao.Items.Add("Học lại / cải thiện theo môn");
            cboBaoCao.Items.Add("Thống kê điểm chữ (A/B/C/D/F)");
            cboBaoCao.SelectedIndex = 0;

            btnExportExcel.Click += btnExportExcel_Click;

            lblLichSuTitle.Values.Text = "Xem trước dữ liệu";

            cboBaoCao.SelectedIndexChanged += (s, e) => LoadPreview();

            LoadPreview();
        }
        private void LoadPreview()
        {
            dgvLichSu.DataSource = GetDataByLoai(cboBaoCao.SelectedIndex);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (cboBaoCao.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string tenBaoCao = cboBaoCao.SelectedItem.ToString();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";      
                sfd.DefaultExt = "xlsx";                
                sfd.AddExtension = true;
                sfd.FileName = tenBaoCao
                    .Replace("/", "-")
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace(":", "")
                    + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    ExportExcel(cboBaoCao.SelectedIndex, tenBaoCao, sfd.FileName);

                    MessageBox.Show("Xuất Excel thành công!\n" + sfd.FileName,
                                    "Thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void ExportExcel(int loai, string tenBaoCao, string duongDan)
        {
            using (var wb = new XLWorkbook())
            {
                IXLWorksheet ws = wb.Worksheets.Add("Báo cáo");

                ws.Cell(1, 1).Value = tenBaoCao.ToUpper();
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Font.FontSize = 14;
                ws.Cell(1, 1).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                ws.Cell(2, 1).Value =
                    "Học kỳ: " + cboHocKy.Text +
                    "   |   Khoa: " + cboKhoa.Text +
                    (cboLop.SelectedIndex > 0 ? "   |   Lớp: " + cboLop.Text : "");  // ← thêm dòng này

                ws.Cell(3, 1).Value =
                    "Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                DataTable dt = GetDataByLoai(loai);

                if (dt == null || dt.Rows.Count == 0)
                {
                    ws.Cell(5, 1).Value = "Không có dữ liệu.";
                    wb.SaveAs(duongDan);
                    return;
                }

                int startRow = 5;

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    IXLCell cell = ws.Cell(startRow, c + 1);
                    cell.Value = dt.Columns[c].ColumnName;
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor =
                        XLColor.FromArgb(25, 47, 97);
                    cell.Style.Font.FontColor = XLColor.White;
                    cell.Style.Border.OutsideBorder =
                        XLBorderStyleValues.Thin;
                    cell.Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center;
                }

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        IXLCell cell = ws.Cell(startRow + r + 1, c + 1);
                        cell.Value = dt.Rows[r][c]?.ToString() ?? "";
                        cell.Style.Border.OutsideBorder =
                            XLBorderStyleValues.Thin;

                        if (r % 2 == 1)
                            cell.Style.Fill.BackgroundColor =
                                XLColor.FromArgb(245, 247, 250);
                    }
                }

                ws.Range(1, 1, 1, dt.Columns.Count).Merge();
                ws.Range(2, 1, 2, dt.Columns.Count).Merge();
                ws.Range(3, 1, 3, dt.Columns.Count).Merge();

                ws.Columns().AdjustToContents();

                wb.SaveAs(duongDan);
            }
        }

        private DataTable GetDataByLoai(int loai)
        {
            switch (loai)
            {
                case 0:
                    DataRow dr = DashBoardBLL.GetTongQuan(_maHocKy, _maKhoa, _maLop);
                    if (dr == null) return null;

                    DataTable dtTQ = new DataTable();
                    dtTQ.Columns.Add("Chỉ số");
                    dtTQ.Columns.Add("Giá trị");
                    dtTQ.Rows.Add("Tổng sinh viên", dr["TongSinhVien"]);
                    dtTQ.Rows.Add("SV cảnh báo", dr["SoCanhBao"]);
                    dtTQ.Rows.Add("Tỷ lệ đậu (%)", Convert.ToDouble(dr["TyLeDau"]).ToString("0.0"));  // ← thêm
                    dtTQ.Rows.Add("Tỷ lệ rớt (%)", Convert.ToDouble(dr["TyLeRot"]).ToString("0.0"));  // ← thêm
                    return dtTQ;

                case 1:
                    return DashBoardBLL.GetHocLucTheoKhoa(_maHocKy, _maKhoa, _maLop);

                case 2:
                    return DashBoardBLL.GetHocLaiTheoMon(_maHocKy, _maKhoa, _maLop);

                case 3:
                    return DashBoardBLL.GetThongKeThangDiem(_maHocKy, _maKhoa, _maLop);

                default:
                    return null;
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboKhoa.SelectedValue?.ToString() ?? "";
            LoadComboLop(maKhoa);
        }
        private void LoadComboLop(string maKhoa)
        {
            DataTable dt = DashBoardBLL.GetLopByKhoa(maKhoa);

            DataRow dr = dt.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "-- Tất cả --";
            dt.Rows.InsertAt(dr, 0);

            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndex = 0;
        }
    }
}