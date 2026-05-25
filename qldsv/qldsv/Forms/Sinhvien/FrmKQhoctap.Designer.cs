namespace qldsv.Forms.Sinhvien
{
    partial class FrmKQhoctap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dgvKQ = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSoCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSoKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSoKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSoCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHe10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHe4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTB10 = new System.Windows.Forms.Label();
            this.lblTB4 = new System.Windows.Forms.Label();
            this.lblTinChi = new System.Windows.Forms.Label();
            this.lblTinChiTL = new System.Windows.Forms.Label();
            this.lblTBTL10 = new System.Windows.Forms.Label();
            this.lblTBTL4 = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 50);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 Kết quả học tập";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblNamHoc);
            this.pnlTop.Controls.Add(this.cboNamHoc);
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 85);
            this.pnlTop.TabIndex = 3;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.Location = new System.Drawing.Point(30, 28);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(97, 28);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm học";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.BorderRadius = 8;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(130, 20);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(220, 36);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged_1);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.Location = new System.Drawing.Point(390, 28);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(77, 28);
            this.lblHocKy.TabIndex = 2;
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
            this.cboHocKy.Location = new System.Drawing.Point(480, 20);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(180, 36);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged_1);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblMSSV);
            this.pnlInfo.Controls.Add(this.lblHoTen);
            this.pnlInfo.Controls.Add(this.lblLop);
            this.pnlInfo.Controls.Add(this.lblKhoa);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 135);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1280, 90);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMSSV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMSSV.Location = new System.Drawing.Point(30, 18);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(77, 30);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoTen.Location = new System.Drawing.Point(30, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(114, 30);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLop.Location = new System.Drawing.Point(500, 18);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(56, 30);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblKhoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKhoa.Location = new System.Drawing.Point(500, 50);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(70, 30);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa:";
            // 
            // dgvKQ
            // 
            this.dgvKQ.AllowUserToAddRows = false;
            this.dgvKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKQ.BackgroundColor = System.Drawing.Color.White;
            this.dgvKQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvKQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKQ.ColumnHeadersHeight = 40;
            this.dgvKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaHP,
            this.colTenHP,
            this.colTC,
            this.colHeSoCC,
            this.colHeSoKT1,
            this.colHeSoKT2,
            this.colHeSoCK,
            this.colCC,
            this.colKT1,
            this.colKT2,
            this.colCK,
            this.colHe10,
            this.colHe4,
            this.colChu});
            this.dgvKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKQ.EnableHeadersVisualStyles = false;
            this.dgvKQ.Location = new System.Drawing.Point(0, 225);
            this.dgvKQ.Name = "dgvKQ";
            this.dgvKQ.RowHeadersVisible = false;
            this.dgvKQ.RowHeadersWidth = 62;
            this.dgvKQ.RowTemplate.Height = 35;
            this.dgvKQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKQ.Size = new System.Drawing.Size(1280, 385);
            this.dgvKQ.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            // 
            // colMaHP
            // 
            this.colMaHP.FillWeight = 80F;
            this.colMaHP.HeaderText = "Mã HP";
            this.colMaHP.MinimumWidth = 8;
            this.colMaHP.Name = "colMaHP";
            // 
            // colTenHP
            // 
            this.colTenHP.FillWeight = 180F;
            this.colTenHP.HeaderText = "Tên học phần";
            this.colTenHP.MinimumWidth = 8;
            this.colTenHP.Name = "colTenHP";
            // 
            // colTC
            // 
            this.colTC.FillWeight = 40F;
            this.colTC.HeaderText = "TC";
            this.colTC.MinimumWidth = 8;
            this.colTC.Name = "colTC";
            // 
            // colHeSoCC
            // 
            this.colHeSoCC.FillWeight = 60F;
            this.colHeSoCC.HeaderText = "HS CC";
            this.colHeSoCC.MinimumWidth = 8;
            this.colHeSoCC.Name = "colHeSoCC";
            // 
            // colHeSoKT1
            // 
            this.colHeSoKT1.FillWeight = 60F;
            this.colHeSoKT1.HeaderText = "HS KT1";
            this.colHeSoKT1.MinimumWidth = 8;
            this.colHeSoKT1.Name = "colHeSoKT1";
            // 
            // colHeSoKT2
            // 
            this.colHeSoKT2.FillWeight = 60F;
            this.colHeSoKT2.HeaderText = "HS KT2";
            this.colHeSoKT2.MinimumWidth = 8;
            this.colHeSoKT2.Name = "colHeSoKT2";
            // 
            // colHeSoCK
            // 
            this.colHeSoCK.FillWeight = 60F;
            this.colHeSoCK.HeaderText = "HS CK";
            this.colHeSoCK.MinimumWidth = 8;
            this.colHeSoCK.Name = "colHeSoCK";
            // 
            // colCC
            // 
            this.colCC.FillWeight = 50F;
            this.colCC.HeaderText = "CC";
            this.colCC.MinimumWidth = 8;
            this.colCC.Name = "colCC";
            // 
            // colKT1
            // 
            this.colKT1.FillWeight = 50F;
            this.colKT1.HeaderText = "KT1";
            this.colKT1.MinimumWidth = 8;
            this.colKT1.Name = "colKT1";
            // 
            // colKT2
            // 
            this.colKT2.FillWeight = 50F;
            this.colKT2.HeaderText = "KT2";
            this.colKT2.MinimumWidth = 8;
            this.colKT2.Name = "colKT2";
            // 
            // colCK
            // 
            this.colCK.FillWeight = 50F;
            this.colCK.HeaderText = "CK";
            this.colCK.MinimumWidth = 8;
            this.colCK.Name = "colCK";
            // 
            // colHe10
            // 
            this.colHe10.FillWeight = 60F;
            this.colHe10.HeaderText = "Hệ 10";
            this.colHe10.MinimumWidth = 8;
            this.colHe10.Name = "colHe10";
            // 
            // colHe4
            // 
            this.colHe4.FillWeight = 55F;
            this.colHe4.HeaderText = "Hệ 4";
            this.colHe4.MinimumWidth = 8;
            this.colHe4.Name = "colHe4";
            // 
            // colChu
            // 
            this.colChu.FillWeight = 70F;
            this.colChu.HeaderText = "Điểm chữ";
            this.colChu.MinimumWidth = 8;
            this.colChu.Name = "colChu";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblTB10);
            this.pnlBottom.Controls.Add(this.lblTB4);
            this.pnlBottom.Controls.Add(this.lblTinChi);
            this.pnlBottom.Controls.Add(this.lblTinChiTL);
            this.pnlBottom.Controls.Add(this.lblTBTL10);
            this.pnlBottom.Controls.Add(this.lblTBTL4);
            this.pnlBottom.Controls.Add(this.lblXepLoai);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 610);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1280, 110);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblTB10
            // 
            this.lblTB10.AutoSize = true;
            this.lblTB10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTB10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTB10.Location = new System.Drawing.Point(30, 18);
            this.lblTB10.Name = "lblTB10";
            this.lblTB10.Size = new System.Drawing.Size(157, 28);
            this.lblTB10.TabIndex = 0;
            this.lblTB10.Text = "Điểm TB hệ 10:";
            // 
            // lblTB4
            // 
            this.lblTB4.AutoSize = true;
            this.lblTB4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTB4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTB4.Location = new System.Drawing.Point(30, 60);
            this.lblTB4.Name = "lblTB4";
            this.lblTB4.Size = new System.Drawing.Size(145, 28);
            this.lblTB4.TabIndex = 1;
            this.lblTB4.Text = "Điểm TB hệ 4:";
            // 
            // lblTinChi
            // 
            this.lblTinChi.AutoSize = true;
            this.lblTinChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTinChi.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTinChi.Location = new System.Drawing.Point(249, 18);
            this.lblTinChi.Name = "lblTinChi";
            this.lblTinChi.Size = new System.Drawing.Size(169, 28);
            this.lblTinChi.TabIndex = 2;
            this.lblTinChi.Text = "Tổng tín chỉ đạt:";
            // 
            // lblTinChiTL
            // 
            this.lblTinChiTL.AutoSize = true;
            this.lblTinChiTL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTinChiTL.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTinChiTL.Location = new System.Drawing.Point(249, 60);
            this.lblTinChiTL.Name = "lblTinChiTL";
            this.lblTinChiTL.Size = new System.Drawing.Size(158, 28);
            this.lblTinChiTL.TabIndex = 3;
            this.lblTinChiTL.Text = "Tín chỉ tích lũy:";
            // 
            // lblTBTL10
            // 
            this.lblTBTL10.AutoSize = true;
            this.lblTBTL10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTBTL10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTBTL10.Location = new System.Drawing.Point(500, 18);
            this.lblTBTL10.Name = "lblTBTL10";
            this.lblTBTL10.Size = new System.Drawing.Size(179, 28);
            this.lblTBTL10.TabIndex = 4;
            this.lblTBTL10.Text = "Điểm TBTL hệ 10:";
            // 
            // lblTBTL4
            // 
            this.lblTBTL4.AutoSize = true;
            this.lblTBTL4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTBTL4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTBTL4.Location = new System.Drawing.Point(500, 60);
            this.lblTBTL4.Name = "lblTBTL4";
            this.lblTBTL4.Size = new System.Drawing.Size(167, 28);
            this.lblTBTL4.TabIndex = 5;
            this.lblTBTL4.Text = "Điểm TBTL hệ 4:";
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblXepLoai.ForeColor = System.Drawing.Color.DarkRed;
            this.lblXepLoai.Location = new System.Drawing.Point(704, 37);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(102, 30);
            this.lblXepLoai.TabIndex = 6;
            this.lblXepLoai.Text = "Xếp loại:";
            // 
            // FrmKQhoctap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dgvKQ);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKQhoctap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.FrmKQhoctap_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboNamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblKhoa;

        private System.Windows.Forms.DataGridView dgvKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSoCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSoKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSoKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSoCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHe10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHe4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChu;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTB10;
        private System.Windows.Forms.Label lblTB4;
        private System.Windows.Forms.Label lblTinChi;
        private System.Windows.Forms.Label lblTinChiTL;
        private System.Windows.Forms.Label lblTBTL10;
        private System.Windows.Forms.Label lblTBTL4;
        private System.Windows.Forms.Label lblXepLoai;
    }
}