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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblLopHP = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboLopHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuTam = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiMau = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📝 Nhập điểm học phần";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.dgvNhapDiem);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18);
            this.pnlMain.Size = new System.Drawing.Size(1400, 745);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.AllowUserToAddRows = false;
            this.dgvNhapDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapDiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvNhapDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhapDiem.ColumnHeadersHeight = 42;
            this.dgvNhapDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDangKy,
            this.colSTT,
            this.colMSSV,
            this.colHoTen,
            this.colCC,
            this.colKT1,
            this.colKT2,
            this.colCK,
            this.colTongKet,
            this.colDiemChu});
            this.dgvNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapDiem.EnableHeadersVisualStyles = false;
            this.dgvNhapDiem.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvNhapDiem.Location = new System.Drawing.Point(18, 163);
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.RowHeadersVisible = false;
            this.dgvNhapDiem.RowHeadersWidth = 62;
            this.dgvNhapDiem.RowTemplate.Height = 36;
            this.dgvNhapDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapDiem.Size = new System.Drawing.Size(1364, 514);
            this.dgvNhapDiem.TabIndex = 1;
//            this.dgvNhapDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapDiem_CellEndEdit);
            // 
            // colMaDangKy
            // 
            this.colMaDangKy.MinimumWidth = 8;
            this.colMaDangKy.Name = "colMaDangKy";
            this.colMaDangKy.Visible = false;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            // 
            // colMSSV
            // 
            this.colMSSV.FillWeight = 80F;
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 8;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.FillWeight = 180F;
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            // 
            // colCC
            // 
            this.colCC.FillWeight = 55F;
            this.colCC.HeaderText = "CC";
            this.colCC.MinimumWidth = 8;
            this.colCC.Name = "colCC";
            // 
            // colKT1
            // 
            this.colKT1.FillWeight = 55F;
            this.colKT1.HeaderText = "KT1";
            this.colKT1.MinimumWidth = 8;
            this.colKT1.Name = "colKT1";
            // 
            // colKT2
            // 
            this.colKT2.FillWeight = 55F;
            this.colKT2.HeaderText = "KT2";
            this.colKT2.MinimumWidth = 8;
            this.colKT2.Name = "colKT2";
            // 
            // colCK
            // 
            this.colCK.FillWeight = 55F;
            this.colCK.HeaderText = "CK";
            this.colCK.MinimumWidth = 8;
            this.colCK.Name = "colCK";
            // 
            // colTongKet
            // 
            this.colTongKet.FillWeight = 75F;
            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.MinimumWidth = 8;
            this.colTongKet.Name = "colTongKet";
            // 
            // colDiemChu
            // 
            this.colDiemChu.FillWeight = 70F;
            this.colDiemChu.HeaderText = "Điểm chữ";
            this.colDiemChu.MinimumWidth = 8;
            this.colDiemChu.Name = "colDiemChu";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.lblThongKe);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(18, 677);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1364, 50);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblThongKe.ForeColor = System.Drawing.Color.DimGray;
            this.lblThongKe.Location = new System.Drawing.Point(20, 14);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(338, 25);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Tổng SV: 0  |  Đã nhập: 0  |  Còn thiếu: 0";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblHocKy);
            this.pnlFilter.Controls.Add(this.lblLopHP);
            this.pnlFilter.Controls.Add(this.cboHocKy);
            this.pnlFilter.Controls.Add(this.cboLopHP);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.btnLuuTam);
            this.pnlFilter.Controls.Add(this.btnXacNhan);
            this.pnlFilter.Controls.Add(this.btnImport);
            this.pnlFilter.Controls.Add(this.btnExport);
            this.pnlFilter.Controls.Add(this.btnTaiMau);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(18, 18);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1364, 145);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(22, 18);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(77, 28);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblLopHP
            // 
            this.lblLopHP.AutoSize = true;
            this.lblLopHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopHP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLopHP.Location = new System.Drawing.Point(305, 18);
            this.lblLopHP.Name = "lblLopHP";
            this.lblLopHP.Size = new System.Drawing.Size(140, 28);
            this.lblLopHP.TabIndex = 1;
            this.lblLopHP.Text = "Lớp học phần";
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
            this.cboHocKy.Location = new System.Drawing.Point(26, 50);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(240, 36);
            this.cboHocKy.TabIndex = 2;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // cboLopHP
            // 
            this.cboLopHP.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHP.BorderRadius = 8;
            this.cboLopHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHP.FocusedColor = System.Drawing.Color.Empty;
            this.cboLopHP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHP.ItemHeight = 30;
            this.cboLopHP.Location = new System.Drawing.Point(309, 50);
            this.cboLopHP.Name = "cboLopHP";
            this.cboLopHP.Size = new System.Drawing.Size(280, 36);
            this.cboLopHP.TabIndex = 3;
            this.cboLopHP.SelectedIndexChanged += new System.EventHandler(this.cboLopHP_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(1015, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Tìm MSSV hoặc họ tên...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(320, 36);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnLuuTam
            // 
            this.btnLuuTam.BorderRadius = 8;
            this.btnLuuTam.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLuuTam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuTam.ForeColor = System.Drawing.Color.White;
            this.btnLuuTam.Location = new System.Drawing.Point(26, 100);
            this.btnLuuTam.Name = "btnLuuTam";
            this.btnLuuTam.Size = new System.Drawing.Size(150, 38);
            this.btnLuuTam.TabIndex = 5;
            this.btnLuuTam.Text = "💾 Lưu tạm";
            this.btnLuuTam.Click += new System.EventHandler(this.btnLuuTam_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.FillColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(190, 100);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(180, 38);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "✔ Xác nhận điểm";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnImport
            // 
            this.btnImport.BorderColor = System.Drawing.Color.Silver;
            this.btnImport.BorderRadius = 8;
            this.btnImport.BorderThickness = 1;
            this.btnImport.FillColor = System.Drawing.Color.White;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(390, 100);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 38);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "📥 Import Excel";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BorderColor = System.Drawing.Color.Silver;
            this.btnExport.BorderRadius = 8;
            this.btnExport.BorderThickness = 1;
            this.btnExport.FillColor = System.Drawing.Color.White;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(555, 100);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 38);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "📤 Export Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTaiMau
            // 
            this.btnTaiMau.BorderColor = System.Drawing.Color.Silver;
            this.btnTaiMau.BorderRadius = 8;
            this.btnTaiMau.BorderThickness = 1;
            this.btnTaiMau.FillColor = System.Drawing.Color.White;
            this.btnTaiMau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaiMau.ForeColor = System.Drawing.Color.Black;
            this.btnTaiMau.Location = new System.Drawing.Point(720, 100);
            this.btnTaiMau.Name = "btnTaiMau";
            this.btnTaiMau.Size = new System.Drawing.Size(160, 38);
            this.btnTaiMau.TabIndex = 9;
            this.btnTaiMau.Text = "📄 Tải mẫu Excel";
            this.btnTaiMau.Click += new System.EventHandler(this.btnTaiMau_Click);
            // 
            // FrmNhapDiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmNhapDiem";
            this.Text = "Nhập điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNhapDiem_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblLopHP;

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
    }
}