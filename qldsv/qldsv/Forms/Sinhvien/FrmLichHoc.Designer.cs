namespace qldsv.Forms.Sinhvien
{
    partial class FrmLichHoc
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

            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();

            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();

            this.dgvLichHoc = new System.Windows.Forms.DataGridView();

            this.colThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();

            // =====================================================
            // pnlHeader
            // =====================================================
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 55);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 Lịch học";

            // =====================================================
            // pnlTop
            // =====================================================
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Controls.Add(this.btnXem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 55);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1400, 75);
            this.pnlTop.TabIndex = 1;

            // lblHocKy
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHocKy.Location = new System.Drawing.Point(30, 24);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(74, 28);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ";

            // cboHocKy
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 8;
            this.cboHocKy.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.cboHocKy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(120, 18);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(250, 36);
            this.cboHocKy.TabIndex = 1;

            // btnXem
            this.btnXem.BorderRadius = 8;
            this.btnXem.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnXem.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(410, 17);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(160, 40);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "📄 Xem lịch";

            // =====================================================
            // pnlInfo
            // =====================================================
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlInfo.Controls.Add(this.lblMSSV);
            this.pnlInfo.Controls.Add(this.lblHoTen);
            this.pnlInfo.Controls.Add(this.lblLop);

            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 130);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1400, 80);
            this.pnlInfo.TabIndex = 2;

            // lblMSSV
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMSSV.Location = new System.Drawing.Point(30, 18);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(67, 28);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHoTen.Location = new System.Drawing.Point(250, 18);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(99, 28);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";

            // lblLop
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLop.Location = new System.Drawing.Point(700, 18);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(47, 28);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";

            // =====================================================
            // dgvLichHoc
            // =====================================================
            this.dgvLichHoc.AllowUserToAddRows = false;

            this.dgvLichHoc.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvLichHoc.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvLichHoc.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            dataGridViewCellStyle1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.dgvLichHoc.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvLichHoc.ColumnHeadersHeight = 40;

            this.dgvLichHoc.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colThu,
                    this.colCaHoc,
                    this.colMaHP,
                    this.colTenMon,
                    this.colPhong,
                    this.colGiangVien,
                    this.colNgayBD,
                    this.colNgayKT
                });

            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dgvLichHoc.EnableHeadersVisualStyles = false;

            this.dgvLichHoc.Location =
                new System.Drawing.Point(0, 210);

            this.dgvLichHoc.Name = "dgvLichHoc";

            this.dgvLichHoc.RowHeadersVisible = false;

            this.dgvLichHoc.RowTemplate.Height = 35;

            this.dgvLichHoc.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvLichHoc.Size =
                new System.Drawing.Size(1400, 590);

            this.dgvLichHoc.TabIndex = 3;

            // =====================================================
            // Columns
            // =====================================================

            this.colThu.HeaderText = "Thứ";
            this.colThu.MinimumWidth = 6;
            this.colThu.Name = "colThu";

            this.colCaHoc.HeaderText = "Ca học";
            this.colCaHoc.MinimumWidth = 6;
            this.colCaHoc.Name = "colCaHoc";

            this.colMaHP.HeaderText = "Mã HP";
            this.colMaHP.MinimumWidth = 6;
            this.colMaHP.Name = "colMaHP";

            this.colTenMon.HeaderText = "Tên môn học";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";

            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";

            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.MinimumWidth = 6;
            this.colGiangVien.Name = "colGiangVien";

            this.colNgayBD.HeaderText = "Ngày bắt đầu";
            this.colNgayBD.MinimumWidth = 6;
            this.colNgayBD.Name = "colNgayBD";

            this.colNgayKT.HeaderText = "Ngày kết thúc";
            this.colNgayKT.MinimumWidth = 6;
            this.colNgayKT.Name = "colNgayKT";

            // =====================================================
            // FrmLichHoc
            // =====================================================

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 242, 245);

            this.ClientSize = new System.Drawing.Size(1400, 800);

            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.None;

            this.Name = "FrmLichHoc";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Lịch học";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();

            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLichHoc)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2Button btnXem;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;

        private System.Windows.Forms.DataGridView dgvLichHoc;

        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKT;
    }
}