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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.cboSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLocThu = new System.Windows.Forms.Label();
            this.cboLocThu = new Guna.UI2.WinForms.Guna2ComboBox();
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
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📖 Lịch học";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Controls.Add(this.lblSapXep);
            this.pnlTop.Controls.Add(this.cboSapXep);
            this.pnlTop.Controls.Add(this.lblLocThu);
            this.pnlTop.Controls.Add(this.cboLocThu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1400, 75);
            this.pnlTop.TabIndex = 1;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(30, 22);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(81, 30);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 8;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(110, 18);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(260, 36);
            this.cboHocKy.TabIndex = 1;
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSapXep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSapXep.Location = new System.Drawing.Point(420, 22);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(91, 30);
            this.lblSapXep.TabIndex = 2;
            this.lblSapXep.Text = "Sắp xếp";
            // 
            // cboSapXep
            // 
            this.cboSapXep.BackColor = System.Drawing.Color.Transparent;
            this.cboSapXep.BorderRadius = 8;
            this.cboSapXep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSapXep.FocusedColor = System.Drawing.Color.Empty;
            this.cboSapXep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSapXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSapXep.ItemHeight = 30;
            this.cboSapXep.Location = new System.Drawing.Point(510, 18);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(200, 36);
            this.cboSapXep.TabIndex = 3;
            // 
            // lblLocThu
            // 
            this.lblLocThu.AutoSize = true;
            this.lblLocThu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLocThu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLocThu.Location = new System.Drawing.Point(735, 22);
            this.lblLocThu.Name = "lblLocThu";
            this.lblLocThu.Size = new System.Drawing.Size(139, 30);
            this.lblLocThu.TabIndex = 4;
            this.lblLocThu.Text = "Lọc theo thứ";
            // 
            // cboLocThu
            // 
            this.cboLocThu.BackColor = System.Drawing.Color.Transparent;
            this.cboLocThu.BorderRadius = 8;
            this.cboLocThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocThu.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocThu.ItemHeight = 30;
            this.cboLocThu.Location = new System.Drawing.Point(880, 18);
            this.cboLocThu.Name = "cboLocThu";
            this.cboLocThu.Size = new System.Drawing.Size(161, 36);
            this.cboLocThu.TabIndex = 5;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblMSSV);
            this.pnlInfo.Controls.Add(this.lblHoTen);
            this.pnlInfo.Controls.Add(this.lblLop);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 125);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1400, 45);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblMSSV.Location = new System.Drawing.Point(20, 12);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(71, 28);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblHoTen.Location = new System.Drawing.Point(280, 12);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(109, 28);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblLop.Location = new System.Drawing.Point(700, 12);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(52, 28);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            this.dgvLichHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvLichHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichHoc.ColumnHeadersHeight = 42;
            this.dgvLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThu,
            this.colCaHoc,
            this.colMaHP,
            this.colTenMon,
            this.colPhong,
            this.colGiangVien,
            this.colNgayBD,
            this.colNgayKT});
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.EnableHeadersVisualStyles = false;
            this.dgvLichHoc.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLichHoc.Location = new System.Drawing.Point(0, 170);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.RowHeadersVisible = false;
            this.dgvLichHoc.RowHeadersWidth = 82;
            this.dgvLichHoc.RowTemplate.Height = 36;
            this.dgvLichHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHoc.Size = new System.Drawing.Size(1400, 630);
            this.dgvLichHoc.TabIndex = 3;
            // 
            // colThu
            // 
            this.colThu.HeaderText = "Thứ";
            this.colThu.MinimumWidth = 6;
            this.colThu.Name = "colThu";
            // 
            // colCaHoc
            // 
            this.colCaHoc.HeaderText = "Ca học";
            this.colCaHoc.MinimumWidth = 6;
            this.colCaHoc.Name = "colCaHoc";
            // 
            // colMaHP
            // 
            this.colMaHP.HeaderText = "Mã HP";
            this.colMaHP.MinimumWidth = 6;
            this.colMaHP.Name = "colMaHP";
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên môn học";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            // 
            // colPhong
            // 
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            // 
            // colGiangVien
            // 
            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.MinimumWidth = 6;
            this.colGiangVien.Name = "colGiangVien";
            // 
            // colNgayBD
            // 
            this.colNgayBD.HeaderText = "Ngày bắt đầu";
            this.colNgayBD.MinimumWidth = 6;
            this.colNgayBD.Name = "colNgayBD";
            // 
            // colNgayKT
            // 
            this.colNgayKT.HeaderText = "Ngày kết thúc";
            this.colNgayKT.MinimumWidth = 6;
            this.colNgayKT.Name = "colNgayKT";
            // 
            // FrmLichHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLichHoc";
            this.Text = "Lịch học";
            this.Load += new System.EventHandler(this.FrmLichHoc_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private System.Windows.Forms.Label lblSapXep;
        private Guna.UI2.WinForms.Guna2ComboBox cboSapXep;
        private System.Windows.Forms.Label lblLocThu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocThu;
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