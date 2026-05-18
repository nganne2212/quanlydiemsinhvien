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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.dgvNhapDiem =
                new System.Windows.Forms.DataGridView();

            this.colMaDangKy =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colSTT =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMSSV =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colHoTen =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCC =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colKT1 =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colKT2 =
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

            this.pnlFilter =
                new System.Windows.Forms.Panel();

            this.cboHocKy =
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

            this.btnTaiMau =
                new Guna.UI2.WinForms.Guna2Button();

            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvNhapDiem)).BeginInit();

            this.pnlFooter.SuspendLayout();
            this.pnlFilter.SuspendLayout();

            this.SuspendLayout();

            // =========================
            // pnlHeader
            // =========================

            this.pnlHeader.BackColor =
                System.Drawing.Color.MidnightBlue;

            this.pnlHeader.Controls.Add(this.lblTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name = "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(1400, 55);

            // =========================
            // lblTitle
            // =========================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(20, 12);

            this.lblTitle.Text =
                "📝 Nhập điểm lớp học phần";

            // =========================
            // pnlMain
            // =========================

            this.pnlMain.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.pnlMain.Controls.Add(this.dgvNhapDiem);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlFilter);

            this.pnlMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMain.Padding =
                new System.Windows.Forms.Padding(20);

            // =========================
            // pnlFilter
            // =========================

            this.pnlFilter.BackColor =
                System.Drawing.Color.White;

            this.pnlFilter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFilter.Controls.Add(this.cboHocKy);
            this.pnlFilter.Controls.Add(this.cboLopHP);
            this.pnlFilter.Controls.Add(this.txtSearch);

            this.pnlFilter.Controls.Add(this.btnLuuTam);
            this.pnlFilter.Controls.Add(this.btnXacNhan);
            this.pnlFilter.Controls.Add(this.btnImport);
            this.pnlFilter.Controls.Add(this.btnExport);
            this.pnlFilter.Controls.Add(this.btnTaiMau);

            this.pnlFilter.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlFilter.Location =
                new System.Drawing.Point(20, 20);

            this.pnlFilter.Name = "pnlFilter";

            this.pnlFilter.Size =
                new System.Drawing.Size(1360, 140);

            // =========================
            // cboHocKy
            // =========================

            this.cboHocKy.BackColor =
                System.Drawing.Color.Transparent;

            this.cboHocKy.BorderRadius = 8;

            this.cboHocKy.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.cboHocKy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboHocKy.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboHocKy.ItemHeight = 30;

            this.cboHocKy.Location =
                new System.Drawing.Point(20, 20);

            this.cboHocKy.Size =
                new System.Drawing.Size(220, 36);

            // =========================
            // cboLopHP
            // =========================

            this.cboLopHP.BackColor =
                System.Drawing.Color.Transparent;

            this.cboLopHP.BorderRadius = 8;

            this.cboLopHP.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.cboLopHP.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLopHP.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboLopHP.ItemHeight = 30;

            this.cboLopHP.Location =
                new System.Drawing.Point(260, 20);

            this.cboLopHP.Size =
                new System.Drawing.Size(420, 36);

            // =========================
            // txtSearch
            // =========================

            this.txtSearch.BorderRadius = 8;

            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.txtSearch.Location =
                new System.Drawing.Point(700, 20);

            this.txtSearch.PlaceholderText =
                "🔍 Tìm MSSV hoặc họ tên...";

            this.txtSearch.Size =
                new System.Drawing.Size(300, 36);

            // =========================
            // Buttons
            // =========================

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

            // =========================

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
                new System.Drawing.Size(170, 38);

            this.btnXacNhan.Text =
                "✔ Xác nhận điểm";

            // =========================

            this.btnImport.BorderRadius = 8;

            this.btnImport.BorderThickness = 1;

            this.btnImport.FillColor =
                System.Drawing.Color.White;

            this.btnImport.ForeColor =
                System.Drawing.Color.Black;

            this.btnImport.Location =
                new System.Drawing.Point(370, 80);

            this.btnImport.Size =
                new System.Drawing.Size(140, 38);

            this.btnImport.Text =
                "📥 Import Excel";

            // =========================

            this.btnExport.BorderRadius = 8;

            this.btnExport.BorderThickness = 1;

            this.btnExport.FillColor =
                System.Drawing.Color.White;

            this.btnExport.ForeColor =
                System.Drawing.Color.Black;

            this.btnExport.Location =
                new System.Drawing.Point(530, 80);

            this.btnExport.Size =
                new System.Drawing.Size(140, 38);

            this.btnExport.Text =
                "📤 Export Excel";

            // =========================

            this.btnTaiMau.BorderRadius = 8;

            this.btnTaiMau.BorderThickness = 1;

            this.btnTaiMau.FillColor =
                System.Drawing.Color.White;

            this.btnTaiMau.ForeColor =
                System.Drawing.Color.Black;

            this.btnTaiMau.Location =
                new System.Drawing.Point(690, 80);

            this.btnTaiMau.Size =
                new System.Drawing.Size(150, 38);

            this.btnTaiMau.Text =
                "📄 Tải mẫu Excel";

            // =========================
            // dgvNhapDiem
            // =========================

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

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            dataGridViewCellStyle1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            dataGridViewCellStyle1.ForeColor =
                System.Drawing.Color.MidnightBlue;

            this.dgvNhapDiem.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvNhapDiem.ColumnHeadersHeight = 42;

            this.dgvNhapDiem.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMaDangKy,
                    this.colSTT,
                    this.colMSSV,
                    this.colHoTen,
                    this.colCC,
                    this.colKT1,
                    this.colKT2,
                    this.colCK,
                    this.colTongKet,
                    this.colDiemChu,
                    this.colTrangThai
                });

            this.dgvNhapDiem.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvNhapDiem.EnableHeadersVisualStyles = false;

            this.dgvNhapDiem.EditMode =
                System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;

            this.dgvNhapDiem.GridColor =
                System.Drawing.Color.Gainsboro;

            this.dgvNhapDiem.Location =
                new System.Drawing.Point(20, 160);

            this.dgvNhapDiem.RowHeadersVisible = false;

            this.dgvNhapDiem.RowTemplate.Height = 38;

            this.dgvNhapDiem.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // =========================
            // Columns
            // =========================

            this.colMaDangKy.HeaderText = "MaDangKy";
            this.colMaDangKy.Name = "colMaDangKy";
            this.colMaDangKy.Visible = false;

            this.colSTT.HeaderText = "STT";
            this.colSTT.FillWeight = 40F;
            this.colSTT.ReadOnly = true;

            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.FillWeight = 80F;
            this.colMSSV.ReadOnly = true;

            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.FillWeight = 180F;
            this.colHoTen.ReadOnly = true;

            this.colCC.HeaderText = "CC";
            this.colCC.FillWeight = 60F;

            this.colKT1.HeaderText = "KT1";
            this.colKT1.FillWeight = 60F;

            this.colKT2.HeaderText = "KT2";
            this.colKT2.FillWeight = 60F;

            this.colCK.HeaderText = "CK";
            this.colCK.FillWeight = 60F;

            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.FillWeight = 70F;
            this.colTongKet.ReadOnly = true;

            this.colDiemChu.HeaderText = "Điểm chữ";
            this.colDiemChu.FillWeight = 70F;
            this.colDiemChu.ReadOnly = true;

            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.ReadOnly = true;

            // =========================
            // pnlFooter
            // =========================

            this.pnlFooter.BackColor =
                System.Drawing.Color.White;

            this.pnlFooter.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlFooter.Controls.Add(this.lblThongKe);

            this.pnlFooter.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.pnlFooter.Location =
                new System.Drawing.Point(20, 675);

            this.pnlFooter.Size =
                new System.Drawing.Size(1360, 50);

            // =========================
            // lblThongKe
            // =========================

            this.lblThongKe.AutoSize = true;

            this.lblThongKe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblThongKe.ForeColor =
                System.Drawing.Color.DimGray;

            this.lblThongKe.Location =
                new System.Drawing.Point(20, 14);

            this.lblThongKe.Text =
                "Tổng SV: 0   |   Đã nhập: 0   |   Chưa nhập: 0";

            // =========================
            // FrmNhapDiem
            // =========================

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

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlMain.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvNhapDiem)).EndInit();

            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();

            this.pnlFilter.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlFooter;

        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHP;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private Guna.UI2.WinForms.Guna2Button btnLuuTam;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnTaiMau;

        private System.Windows.Forms.DataGridView dgvNhapDiem;

        private System.Windows.Forms.Label lblThongKe;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}