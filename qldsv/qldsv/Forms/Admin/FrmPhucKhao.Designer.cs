namespace qldsv.Forms.Admin
{
    partial class FrmPhucKhao
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvPhucKhao = new System.Windows.Forms.DataGridView();
            this.colMaPhucKhaoHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhucKhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.lblSinhVienInfo = new System.Windows.Forms.Label();
            this.lblMonHocInfo = new System.Windows.Forms.Label();
            this.lblNgayGuiInfo = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.RichTextBox();
            this.lblGVXuLy = new System.Windows.Forms.Label();
            this.tblGrid = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiemCu = new System.Windows.Forms.Label();
            this.txtDiemCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiemMoi = new System.Windows.Forms.Label();
            this.txtDiemMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.cboKetLuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayXuLy = new System.Windows.Forms.Label();
            this.dtpNgayXuLy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.txtNhanXet = new System.Windows.Forms.RichTextBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.tblGrid.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1450, 55);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📄 Quản lý phúc khảo";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlMain.Controls.Add(this.splitMain);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMain.TabIndex = 0;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Name = "splitMain";
            this.splitMain.Size = new System.Drawing.Size(1418, 634);
            this.splitMain.Panel1MinSize = 100;
            this.splitMain.Panel2MinSize = 100;
            this.splitMain.SplitterDistance = 820;
            this.splitMain.TabIndex = 3;
            this.splitMain.Panel1.Controls.Add(this.dgvPhucKhao);
            this.splitMain.Panel2.Controls.Add(this.pnlRight);
            // 
            // dgvPhucKhao
            // 
            this.dgvPhucKhao.AllowUserToAddRows = false;
            this.dgvPhucKhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhucKhao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhucKhao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhucKhao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhucKhao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(232, 234, 246);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvPhucKhao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhucKhao.ColumnHeadersHeight = 42;
            this.dgvPhucKhao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaPhucKhaoHidden,
                this.colMaDangKy,
                this.colSTT,
                this.colMaPhucKhao,
                this.colSinhVien,
                this.colMonHoc,
                this.colNgayGui,
                this.colTrangThai});
            this.dgvPhucKhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhucKhao.EnableHeadersVisualStyles = false;
            this.dgvPhucKhao.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPhucKhao.Name = "dgvPhucKhao";
            this.dgvPhucKhao.RowHeadersVisible = false;
            this.dgvPhucKhao.RowHeadersWidth = 62;
            this.dgvPhucKhao.RowTemplate.Height = 36;
            this.dgvPhucKhao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhucKhao.TabIndex = 1;
            this.colMaPhucKhaoHidden.MinimumWidth = 8;
            this.colMaPhucKhaoHidden.Name = "colMaPhucKhaoHidden";
            this.colMaPhucKhaoHidden.Visible = false;
            this.colMaDangKy.MinimumWidth = 8;
            this.colMaDangKy.Name = "colMaDangKy";
            this.colMaDangKy.Visible = false;
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colMaPhucKhao.HeaderText = "Mã đơn";
            this.colMaPhucKhao.MinimumWidth = 8;
            this.colMaPhucKhao.Name = "colMaPhucKhao";
            this.colSinhVien.FillWeight = 180F;
            this.colSinhVien.HeaderText = "Sinh viên";
            this.colSinhVien.MinimumWidth = 8;
            this.colSinhVien.Name = "colSinhVien";
            this.colMonHoc.FillWeight = 150F;
            this.colMonHoc.HeaderText = "Môn học";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            this.colNgayGui.HeaderText = "Ngày gửi";
            this.colNgayGui.MinimumWidth = 8;
            this.colNgayGui.Name = "colNgayGui";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.btnCapNhat);
            this.pnlRight.Controls.Add(this.txtNhanXet);
            this.pnlRight.Controls.Add(this.lblNhanXet);
            this.pnlRight.Controls.Add(this.tblGrid);
            this.pnlRight.Controls.Add(this.lblGVXuLy);
            this.pnlRight.Controls.Add(this.txtLyDo);
            this.pnlRight.Controls.Add(this.lblLyDo);
            this.pnlRight.Controls.Add(this.lblNgayGuiInfo);
            this.pnlRight.Controls.Add(this.lblMonHocInfo);
            this.pnlRight.Controls.Add(this.lblSinhVienInfo);
            this.pnlRight.Controls.Add(this.lblMaDon);
            this.pnlRight.Controls.Add(this.lblThongTin);
            this.pnlRight.AutoScroll = true;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRight.TabIndex = 0;
            this.pnlRight.AutoScrollMinSize = new System.Drawing.Size(0, 670);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblThongTin.Location = new System.Drawing.Point(18, 16);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.TabIndex = 18;
            this.lblThongTin.Text = "Thông tin xử lý phúc khảo";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Location = new System.Drawing.Point(18, 52);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.TabIndex = 17;
            this.lblMaDon.Text = "Mã đơn:";
            // 
            // lblSinhVienInfo
            // 
            this.lblSinhVienInfo.AutoSize = true;
            this.lblSinhVienInfo.Location = new System.Drawing.Point(18, 76);
            this.lblSinhVienInfo.Name = "lblSinhVienInfo";
            this.lblSinhVienInfo.TabIndex = 16;
            this.lblSinhVienInfo.Text = "Sinh viên:";
            // 
            // lblMonHocInfo
            // 
            this.lblMonHocInfo.AutoSize = true;
            this.lblMonHocInfo.Location = new System.Drawing.Point(18, 100);
            this.lblMonHocInfo.Name = "lblMonHocInfo";
            this.lblMonHocInfo.TabIndex = 15;
            this.lblMonHocInfo.Text = "Môn học:";
            // 
            // lblNgayGuiInfo
            // 
            this.lblNgayGuiInfo.AutoSize = true;
            this.lblNgayGuiInfo.Location = new System.Drawing.Point(18, 124);
            this.lblNgayGuiInfo.Name = "lblNgayGuiInfo";
            this.lblNgayGuiInfo.TabIndex = 14;
            this.lblNgayGuiInfo.Text = "Ngày gửi:";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLyDo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLyDo.Location = new System.Drawing.Point(18, 152);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.TabIndex = 12;
            this.lblLyDo.Text = "Lý do phúc khảo";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            this.txtLyDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyDo.Location = new System.Drawing.Point(18, 175);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ReadOnly = true;
            this.txtLyDo.Size = new System.Drawing.Size(560, 75);
            this.txtLyDo.TabIndex = 13;
            this.txtLyDo.Text = "";
            // 
            // lblGVXuLy
            // 
            this.lblGVXuLy.AutoSize = true;
            this.lblGVXuLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGVXuLy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGVXuLy.Location = new System.Drawing.Point(18, 262);
            this.lblGVXuLy.Name = "lblGVXuLy";
            this.lblGVXuLy.TabIndex = 11;
            this.lblGVXuLy.Text = "Giảng viên xử lý: ";
            // 
            // tblGrid — 2 cột 50/50, tự co giãn theo pnlRight
            // 
            this.tblGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            this.tblGrid.ColumnCount = 2;
            this.tblGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrid.Controls.Add(this.lblDiemCu, 0, 0);
            this.tblGrid.Controls.Add(this.txtDiemCu, 0, 1);
            this.tblGrid.Controls.Add(this.lblDiemMoi, 1, 0);
            this.tblGrid.Controls.Add(this.txtDiemMoi, 1, 1);
            this.tblGrid.Controls.Add(this.lblKetLuan, 0, 2);
            this.tblGrid.Controls.Add(this.cboKetLuan, 0, 3);
            this.tblGrid.Controls.Add(this.lblNgayXuLy, 1, 2);
            this.tblGrid.Controls.Add(this.dtpNgayXuLy, 1, 3);
            this.tblGrid.Location = new System.Drawing.Point(18, 290);
            this.tblGrid.Name = "tblGrid";
            this.tblGrid.RowCount = 4;
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblGrid.Size = new System.Drawing.Size(560, 144);
            this.tblGrid.TabIndex = 20;
            // 
            // lblDiemCu
            // 
            this.lblDiemCu.AutoSize = true;
            this.lblDiemCu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblDiemCu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiemCu.Name = "lblDiemCu";
            this.lblDiemCu.TabIndex = 9;
            this.lblDiemCu.Text = "Điểm cũ";
            // 
            // txtDiemCu
            // 
            this.txtDiemCu.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDiemCu.BorderRadius = 8;
            this.txtDiemCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemCu.DefaultText = "";
            this.txtDiemCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemCu.Margin = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.txtDiemCu.Name = "txtDiemCu";
            this.txtDiemCu.PlaceholderText = "";
            this.txtDiemCu.ReadOnly = true;
            this.txtDiemCu.SelectedText = "";
            this.txtDiemCu.Size = new System.Drawing.Size(270, 38);
            this.txtDiemCu.TabIndex = 10;
            // 
            // lblDiemMoi
            // 
            this.lblDiemMoi.AutoSize = true;
            this.lblDiemMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblDiemMoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiemMoi.Name = "lblDiemMoi";
            this.lblDiemMoi.TabIndex = 7;
            this.lblDiemMoi.Text = "Điểm mới";
            // 
            // txtDiemMoi
            // 
            this.txtDiemMoi.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDiemMoi.BorderRadius = 8;
            this.txtDiemMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemMoi.DefaultText = "";
            this.txtDiemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemMoi.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.txtDiemMoi.Name = "txtDiemMoi";
            this.txtDiemMoi.PlaceholderText = "";
            this.txtDiemMoi.SelectedText = "";
            this.txtDiemMoi.Size = new System.Drawing.Size(270, 38);
            this.txtDiemMoi.TabIndex = 8;
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblKetLuan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.TabIndex = 5;
            this.lblKetLuan.Text = "Kết luận";
            // 
            // cboKetLuan
            // 
            this.cboKetLuan.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboKetLuan.BackColor = System.Drawing.Color.Transparent;
            this.cboKetLuan.BorderRadius = 8;
            this.cboKetLuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKetLuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKetLuan.FocusedColor = System.Drawing.Color.Empty;
            this.cboKetLuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKetLuan.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboKetLuan.ItemHeight = 30;
            this.cboKetLuan.Items.AddRange(new object[] { "Giữ Nguyên", "Thay Đổi" });
            this.cboKetLuan.Margin = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.cboKetLuan.Name = "cboKetLuan";
            this.cboKetLuan.Size = new System.Drawing.Size(270, 36);
            this.cboKetLuan.TabIndex = 6;
            // 
            // lblNgayXuLy
            // 
            this.lblNgayXuLy.AutoSize = true;
            this.lblNgayXuLy.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayXuLy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNgayXuLy.Name = "lblNgayXuLy";
            this.lblNgayXuLy.TabIndex = 3;
            this.lblNgayXuLy.Text = "Ngày xử lý";
            // 
            // dtpNgayXuLy
            // 
            this.dtpNgayXuLy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpNgayXuLy.BorderRadius = 8;
            this.dtpNgayXuLy.Checked = true;
            this.dtpNgayXuLy.FillColor = System.Drawing.Color.MidnightBlue;
            this.dtpNgayXuLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayXuLy.ForeColor = System.Drawing.Color.White;
            this.dtpNgayXuLy.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayXuLy.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.dtpNgayXuLy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayXuLy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayXuLy.Name = "dtpNgayXuLy";
            this.dtpNgayXuLy.Size = new System.Drawing.Size(270, 36);
            this.dtpNgayXuLy.TabIndex = 4;
            this.dtpNgayXuLy.Value = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanXet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNhanXet.Location = new System.Drawing.Point(18, 444);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.TabIndex = 1;
            this.lblNhanXet.Text = "Nhận xét";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            this.txtNhanXet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhanXet.Location = new System.Drawing.Point(18, 468);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(560, 80);
            this.txtNhanXet.TabIndex = 2;
            this.txtNhanXet.Text = "";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            this.btnCapNhat.BorderRadius = 8;
            this.btnCapNhat.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(18, 562);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(560, 42);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật kết quả";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Controls.Add(this.lblTrangThai);
            this.pnlTop.Controls.Add(this.cboTrangThai);
            this.pnlTop.Controls.Add(this.btnLoc);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1418, 75);
            this.pnlTop.TabIndex = 2;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(18, 14);
            this.lblHocKy.Name = "lblHocKy";
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
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(20, 34);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(220, 36);
            this.cboHocKy.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTrangThai.Location = new System.Drawing.Point(268, 14);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderRadius = 8;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] { "Tất cả", "ChoDuyet", "DangXuLy", "DaXuLy" });
            this.cboTrangThai.Location = new System.Drawing.Point(270, 34);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(220, 36);
            this.cboTrangThai.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.BorderRadius = 8;
            this.btnLoc.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(520, 34);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(120, 36);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            // 
            // FrmPhucKhao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 780);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPhucKhao";
            this.Text = "Quản lý phúc khảo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).EndInit();
            this.tblGrid.ResumeLayout(false);
            this.tblGrid.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.TableLayoutPanel tblGrid;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private System.Windows.Forms.DataGridView dgvPhucKhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhucKhaoHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhucKhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.Label lblSinhVienInfo;
        private System.Windows.Forms.Label lblMonHocInfo;
        private System.Windows.Forms.Label lblNgayGuiInfo;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.RichTextBox txtLyDo;
        private System.Windows.Forms.Label lblGVXuLy;
        private System.Windows.Forms.Label lblDiemCu;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemCu;
        private System.Windows.Forms.Label lblDiemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemMoi;
        private System.Windows.Forms.Label lblKetLuan;
        private Guna.UI2.WinForms.Guna2ComboBox cboKetLuan;
        private System.Windows.Forms.Label lblNgayXuLy;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayXuLy;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.RichTextBox txtNhanXet;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
    }
}