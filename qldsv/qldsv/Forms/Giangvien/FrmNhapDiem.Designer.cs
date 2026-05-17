namespace qldsv.Forms.Giangvien
{
    partial class FrmNhapDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.pnlFilter = new System.Windows.Forms.Panel();

            this.cboHocKy =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.cboNamHoc =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.cboMonHoc =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.cboLopHP =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.txtSearch =
                new Guna.UI2.WinForms.Guna2TextBox();

            this.btnLuuTam =
                new Guna.UI2.WinForms.Guna2Button();

            this.btnXacNhan =
                new Guna.UI2.WinForms.Guna2Button();

            this.btnImport =
                new Guna.UI2.WinForms.Guna2Button();

            this.btnExport =
                new Guna.UI2.WinForms.Guna2Button();

            this.dgvNhapDiem =
                new System.Windows.Forms.DataGridView();

            this.colSTT =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMSSV =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colHoTen =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCC =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colGK =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCK =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTongKet =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDiemChu =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTrangThai =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFooter =
                new System.Windows.Forms.Panel();

            this.lblThongKe =
                new System.Windows.Forms.Label();

            // pnlHeader
            this.pnlHeader.BackColor =
                System.Drawing.Color.MidnightBlue;

            this.pnlHeader.Controls.Add(this.lblTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Size =
                new System.Drawing.Size(1400, 55);

            // lblTitle
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(20, 13);

            this.lblTitle.Text =
                "📝 Nhập điểm sinh viên";

            // pnlMain
            this.pnlMain.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.pnlMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMain.Padding =
                new System.Windows.Forms.Padding(20);

            this.pnlMain.Controls.Add(this.dgvNhapDiem);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlFilter);

            // pnlFilter
            this.pnlFilter.BackColor =
                System.Drawing.Color.White;

            this.pnlFilter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFilter.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlFilter.Height = 140;

            this.pnlFilter.Controls.Add(this.cboHocKy);
            this.pnlFilter.Controls.Add(this.cboNamHoc);
            this.pnlFilter.Controls.Add(this.cboMonHoc);
            this.pnlFilter.Controls.Add(this.cboLopHP);

            this.pnlFilter.Controls.Add(this.txtSearch);

            this.pnlFilter.Controls.Add(this.btnLuuTam);
            this.pnlFilter.Controls.Add(this.btnXacNhan);
            this.pnlFilter.Controls.Add(this.btnImport);
            this.pnlFilter.Controls.Add(this.btnExport);

            // cboHocKy
            this.cboHocKy.BorderRadius = 8;

            this.cboHocKy.Location =
                new System.Drawing.Point(20, 20);

            this.cboHocKy.Size =
                new System.Drawing.Size(180, 36);

            // cboNamHoc
            this.cboNamHoc.BorderRadius = 8;

            this.cboNamHoc.Location =
                new System.Drawing.Point(220, 20);

            this.cboNamHoc.Size =
                new System.Drawing.Size(180, 36);

            // cboMonHoc
            this.cboMonHoc.BorderRadius = 8;

            this.cboMonHoc.Location =
                new System.Drawing.Point(420, 20);

            this.cboMonHoc.Size =
                new System.Drawing.Size(280, 36);

            // cboLopHP
            this.cboLopHP.BorderRadius = 8;

            this.cboLopHP.Location =
                new System.Drawing.Point(720, 20);

            this.cboLopHP.Size =
                new System.Drawing.Size(260, 36);

            // txtSearch
            this.txtSearch.BorderRadius = 8;

            this.txtSearch.PlaceholderText =
                "🔍 Tìm MSSV hoặc họ tên...";

            this.txtSearch.Location =
                new System.Drawing.Point(1000, 20);

            this.txtSearch.Size =
                new System.Drawing.Size(320, 36);

            // btnLuuTam
            this.btnLuuTam.BorderRadius = 8;

            this.btnLuuTam.FillColor =
                System.Drawing.Color.RoyalBlue;

            this.btnLuuTam.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnLuuTam.ForeColor =
                System.Drawing.Color.White;

            this.btnLuuTam.Location =
                new System.Drawing.Point(20, 80);

            this.btnLuuTam.Size =
                new System.Drawing.Size(140, 38);

            this.btnLuuTam.Text =
                "💾 Lưu tạm";

            // btnXacNhan
            this.btnXacNhan.BorderRadius = 8;

            this.btnXacNhan.FillColor =
                System.Drawing.Color.SeaGreen;

            this.btnXacNhan.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnXacNhan.ForeColor =
                System.Drawing.Color.White;

            this.btnXacNhan.Location =
                new System.Drawing.Point(180, 80);

            this.btnXacNhan.Size =
                new System.Drawing.Size(160, 38);

            this.btnXacNhan.Text =
                "✔ Xác nhận điểm";

            // btnImport
            this.btnImport.BorderRadius = 8;

            this.btnImport.FillColor =
                System.Drawing.Color.White;

            this.btnImport.BorderThickness = 1;

            this.btnImport.BorderColor =
                System.Drawing.Color.Silver;

            this.btnImport.ForeColor =
                System.Drawing.Color.Black;

            this.btnImport.Location =
                new System.Drawing.Point(360, 80);

            this.btnImport.Size =
                new System.Drawing.Size(140, 38);

            this.btnImport.Text =
                "📥 Import Excel";

            // btnExport
            this.btnExport.BorderRadius = 8;

            this.btnExport.FillColor =
                System.Drawing.Color.White;

            this.btnExport.BorderThickness = 1;

            this.btnExport.BorderColor =
                System.Drawing.Color.Silver;

            this.btnExport.ForeColor =
                System.Drawing.Color.Black;

            this.btnExport.Location =
                new System.Drawing.Point(520, 80);

            this.btnExport.Size =
                new System.Drawing.Size(140, 38);

            this.btnExport.Text =
                "📤 Export Excel";

            // dgvNhapDiem
            this.dgvNhapDiem.AllowUserToAddRows = false;

            this.dgvNhapDiem.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvNhapDiem.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvNhapDiem.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvNhapDiem.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvNhapDiem.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvStyle.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            dgvStyle.ForeColor =
                System.Drawing.Color.MidnightBlue;

            dgvStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.dgvNhapDiem.ColumnHeadersDefaultCellStyle =
                dgvStyle;

            this.dgvNhapDiem.ColumnHeadersHeight = 42;

            this.dgvNhapDiem.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colSTT,
                    this.colMSSV,
                    this.colHoTen,
                    this.colCC,
                    this.colGK,
                    this.colCK,
                    this.colTongKet,
                    this.colDiemChu,
                    this.colTrangThai
                });

            this.dgvNhapDiem.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvNhapDiem.EnableHeadersVisualStyles = false;

            this.dgvNhapDiem.GridColor =
                System.Drawing.Color.Gainsboro;

            this.dgvNhapDiem.Location =
                new System.Drawing.Point(20, 160);

            this.dgvNhapDiem.RowHeadersVisible = false;

            this.dgvNhapDiem.RowTemplate.Height = 38;

            this.dgvNhapDiem.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Columns
            this.colSTT.HeaderText = "STT";
            this.colSTT.FillWeight = 40;

            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.FillWeight = 80;

            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.FillWeight = 180;

            this.colCC.HeaderText = "CC";
            this.colCC.FillWeight = 60;

            this.colGK.HeaderText = "GK";
            this.colGK.FillWeight = 60;

            this.colCK.HeaderText = "CK";
            this.colCK.FillWeight = 60;

            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.FillWeight = 70;

            this.colDiemChu.HeaderText = "Điểm chữ";
            this.colDiemChu.FillWeight = 70;

            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.FillWeight = 100;

            // pnlFooter
            this.pnlFooter.BackColor =
                System.Drawing.Color.White;

            this.pnlFooter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFooter.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlFooter.Height = 50;

            this.pnlFooter.Controls.Add(this.lblThongKe);

            // lblThongKe
            this.lblThongKe.AutoSize = true;

            this.lblThongKe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblThongKe.ForeColor =
                System.Drawing.Color.DimGray;

            this.lblThongKe.Location =
                new System.Drawing.Point(20, 15);

            this.lblThongKe.Text =
                "Tổng SV: 45   |   Đã nhập: 38   |   Chưa nhập: 7";

            // FrmNhapDiem
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(1400, 800);

            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);

            this.Name = "FrmNhapDiem";

            this.Text = "Nhập điểm";
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlFooter;

        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboNamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHP;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private Guna.UI2.WinForms.Guna2Button btnLuuTam;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnExport;

        private System.Windows.Forms.DataGridView dgvNhapDiem;

        private System.Windows.Forms.Label lblThongKe;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}