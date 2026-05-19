namespace qldsv.Forms.Giangvien
{
    partial class FrmCanhBaoHocVu
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMuc = new System.Windows.Forms.Label();
            this.cboMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCanhBao = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTBTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTCTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMucCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTong = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1280, 55);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚠ Cảnh báo học vụ";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblHocKy);
            this.pnlFilter.Controls.Add(this.cboHocKy);
            this.pnlFilter.Controls.Add(this.lblLop);
            this.pnlFilter.Controls.Add(this.cboLop);
            this.pnlFilter.Controls.Add(this.lblMuc);
            this.pnlFilter.Controls.Add(this.cboMuc);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.btnExport);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 55);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1280, 100);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(20, 7);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(71, 25);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 6;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(20, 35);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(220, 36);
            this.cboHocKy.TabIndex = 1;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLop.Location = new System.Drawing.Point(255, 7);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(43, 25);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 6;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.Empty;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(260, 35);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(220, 36);
            this.cboLop.TabIndex = 3;
            // 
            // lblMuc
            // 
            this.lblMuc.AutoSize = true;
            this.lblMuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMuc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMuc.Location = new System.Drawing.Point(495, 7);
            this.lblMuc.Name = "lblMuc";
            this.lblMuc.Size = new System.Drawing.Size(133, 25);
            this.lblMuc.TabIndex = 4;
            this.lblMuc.Text = "Mức cảnh báo";
            // 
            // cboMuc
            // 
            this.cboMuc.BackColor = System.Drawing.Color.Transparent;
            this.cboMuc.BorderRadius = 6;
            this.cboMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMuc.FocusedColor = System.Drawing.Color.Empty;
            this.cboMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMuc.ItemHeight = 30;
            this.cboMuc.Location = new System.Drawing.Point(500, 35);
            this.cboMuc.Name = "cboMuc";
            this.cboMuc.Size = new System.Drawing.Size(220, 36);
            this.cboMuc.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(740, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm MSSV hoặc họ tên...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(260, 36);
            this.txtSearch.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 6;
            this.btnExport.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1020, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 36);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất Excel";
            // 
            // dgvCanhBao
            // 
            this.dgvCanhBao.AllowUserToAddRows = false;
            this.dgvCanhBao.AllowUserToDeleteRows = false;
            this.dgvCanhBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanhBao.BackgroundColor = System.Drawing.Color.White;
            this.dgvCanhBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvCanhBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCanhBao.ColumnHeadersHeight = 38;
            this.dgvCanhBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSSV,
            this.colHoTen,
            this.colLop,
            this.colHocKy,
            this.colDiemHK,
            this.colTBTL,
            this.colTCTL,
            this.colSoKy,
            this.colMucCB,
            this.colLyDo});
            this.dgvCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanhBao.EnableHeadersVisualStyles = false;
            this.dgvCanhBao.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCanhBao.Location = new System.Drawing.Point(0, 155);
            this.dgvCanhBao.Name = "dgvCanhBao";
            this.dgvCanhBao.RowHeadersVisible = false;
            this.dgvCanhBao.RowHeadersWidth = 62;
            this.dgvCanhBao.RowTemplate.Height = 32;
            this.dgvCanhBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanhBao.Size = new System.Drawing.Size(1280, 525);
            this.dgvCanhBao.TabIndex = 0;
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
            // colLop
            // 
            this.colLop.HeaderText = "Lớp";
            this.colLop.MinimumWidth = 8;
            this.colLop.Name = "colLop";
            // 
            // colHocKy
            // 
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.MinimumWidth = 8;
            this.colHocKy.Name = "colHocKy";
            // 
            // colDiemHK
            // 
            this.colDiemHK.HeaderText = "Điểm HK";
            this.colDiemHK.MinimumWidth = 8;
            this.colDiemHK.Name = "colDiemHK";
            // 
            // colTBTL
            // 
            this.colTBTL.HeaderText = "TBTL";
            this.colTBTL.MinimumWidth = 8;
            this.colTBTL.Name = "colTBTL";
            // 
            // colTCTL
            // 
            this.colTCTL.HeaderText = "TCTL";
            this.colTCTL.MinimumWidth = 8;
            this.colTCTL.Name = "colTCTL";
            // 
            // colSoKy
            // 
            this.colSoKy.HeaderText = "Số kỳ";
            this.colSoKy.MinimumWidth = 8;
            this.colSoKy.Name = "colSoKy";
            // 
            // colMucCB
            // 
            this.colMucCB.HeaderText = "Mức CB";
            this.colMucCB.MinimumWidth = 8;
            this.colMucCB.Name = "colMucCB";
            // 
            // colLyDo
            // 
            this.colLyDo.FillWeight = 180F;
            this.colLyDo.HeaderText = "Lý do";
            this.colLyDo.MinimumWidth = 8;
            this.colLyDo.Name = "colLyDo";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.lblTong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 680);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1280, 50);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTong.Location = new System.Drawing.Point(20, 15);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(240, 25);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "Tổng sinh viên cảnh báo: 0";
            // 
            // FrmCanhBaoHocVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 730);
            this.Controls.Add(this.dgvCanhBao);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FrmCanhBaoHocVu";
            this.Text = "Cảnh báo học vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanhBao)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFilter;

        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;

        private System.Windows.Forms.Label lblLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;

        private System.Windows.Forms.Label lblMuc;
        private Guna.UI2.WinForms.Guna2ComboBox cboMuc;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnExport;

        private System.Windows.Forms.DataGridView dgvCanhBao;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTBTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMucCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTong;
    }
}