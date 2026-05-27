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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhanXet = new System.Windows.Forms.RichTextBox();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.tblGrid = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiemCu = new System.Windows.Forms.Label();
            this.txtDiemCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiemMoi = new System.Windows.Forms.Label();
            this.txtDiemMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKetLuan = new System.Windows.Forms.Label();
            this.cboKetLuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayXuLy = new System.Windows.Forms.Label();
            this.dtpNgayXuLy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblGVXuLy = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.RichTextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.lblNgayGuiInfo = new System.Windows.Forms.Label();
            this.lblMonHocInfo = new System.Windows.Forms.Label();
            this.lblSinhVienInfo = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvPhucKhao = new System.Windows.Forms.DataGridView();
            this.colMaPhucKhaoHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhucKhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.tblGrid.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1208, 46);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📄 Quản lý phúc khảo";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.splitMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1208, 604);
            this.pnlMain.TabIndex = 1;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(10, 10);
            this.splitMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.pnlRight);
            this.splitMain.Size = new System.Drawing.Size(1188, 584);
            this.splitMain.SplitterDistance = 957;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.btnCapNhat);
            this.pnlLeft.Controls.Add(this.txtNhanXet);
            this.pnlLeft.Controls.Add(this.lblNhanXet);
            this.pnlLeft.Controls.Add(this.tblGrid);
            this.pnlLeft.Controls.Add(this.lblGVXuLy);
            this.pnlLeft.Controls.Add(this.txtLyDo);
            this.pnlLeft.Controls.Add(this.lblLyDo);
            this.pnlLeft.Controls.Add(this.lblNgayGuiInfo);
            this.pnlLeft.Controls.Add(this.lblMonHocInfo);
            this.pnlLeft.Controls.Add(this.lblSinhVienInfo);
            this.pnlLeft.Controls.Add(this.lblMaDon);
            this.pnlLeft.Controls.Add(this.lblThongTin);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(13);
            this.pnlLeft.Size = new System.Drawing.Size(957, 584);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BorderRadius = 8;
            this.btnCapNhat.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(15, 454);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(914, 35);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "✔ Cập nhật kết quả";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhanXet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhanXet.Location = new System.Drawing.Point(15, 382);
            this.txtNhanXet.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(914, 63);
            this.txtNhanXet.TabIndex = 2;
            this.txtNhanXet.Text = "";
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanXet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNhanXet.Location = new System.Drawing.Point(15, 362);
            this.lblNhanXet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(73, 20);
            this.lblNhanXet.TabIndex = 1;
            this.lblNhanXet.Text = "Nhận xét";
            // 
            // tblGrid
            // 
            this.tblGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tblGrid.Location = new System.Drawing.Point(15, 233);
            this.tblGrid.Margin = new System.Windows.Forms.Padding(2);
            this.tblGrid.Name = "tblGrid";
            this.tblGrid.RowCount = 4;
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblGrid.Size = new System.Drawing.Size(914, 120);
            this.tblGrid.TabIndex = 20;
            // 
            // lblDiemCu
            // 
            this.lblDiemCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiemCu.AutoSize = true;
            this.lblDiemCu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiemCu.Location = new System.Drawing.Point(2, 6);
            this.lblDiemCu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemCu.Name = "lblDiemCu";
            this.lblDiemCu.Size = new System.Drawing.Size(103, 16);
            this.lblDiemCu.TabIndex = 9;
            this.lblDiemCu.Text = "Điểm CK hiện tại";
            // 
            // txtDiemCu
            // 
            this.txtDiemCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemCu.BorderRadius = 8;
            this.txtDiemCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemCu.DefaultText = "";
            this.txtDiemCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemCu.Location = new System.Drawing.Point(0, 24);
            this.txtDiemCu.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.txtDiemCu.Name = "txtDiemCu";
            this.txtDiemCu.PlaceholderText = "";
            this.txtDiemCu.ReadOnly = true;
            this.txtDiemCu.SelectedText = "";
            this.txtDiemCu.Size = new System.Drawing.Size(452, 34);
            this.txtDiemCu.TabIndex = 10;
            // 
            // lblDiemMoi
            // 
            this.lblDiemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiemMoi.AutoSize = true;
            this.lblDiemMoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiemMoi.Location = new System.Drawing.Point(459, 6);
            this.lblDiemMoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemMoi.Name = "lblDiemMoi";
            this.lblDiemMoi.Size = new System.Drawing.Size(83, 16);
            this.lblDiemMoi.TabIndex = 7;
            this.lblDiemMoi.Text = "Điểm CK mới";
            // 
            // txtDiemMoi
            // 
            this.txtDiemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemMoi.BorderRadius = 8;
            this.txtDiemMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemMoi.DefaultText = "";
            this.txtDiemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemMoi.Location = new System.Drawing.Point(462, 24);
            this.txtDiemMoi.Margin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.txtDiemMoi.Name = "txtDiemMoi";
            this.txtDiemMoi.PlaceholderText = "";
            this.txtDiemMoi.SelectedText = "";
            this.txtDiemMoi.Size = new System.Drawing.Size(452, 34);
            this.txtDiemMoi.TabIndex = 8;
            // 
            // lblKetLuan
            // 
            this.lblKetLuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKetLuan.AutoSize = true;
            this.lblKetLuan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKetLuan.Location = new System.Drawing.Point(2, 66);
            this.lblKetLuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetLuan.Name = "lblKetLuan";
            this.lblKetLuan.Size = new System.Drawing.Size(54, 16);
            this.lblKetLuan.TabIndex = 5;
            this.lblKetLuan.Text = "Kết luận";
            // 
            // cboKetLuan
            // 
            this.cboKetLuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKetLuan.BackColor = System.Drawing.Color.Transparent;
            this.cboKetLuan.BorderRadius = 8;
            this.cboKetLuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKetLuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKetLuan.FocusedColor = System.Drawing.Color.Empty;
            this.cboKetLuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKetLuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKetLuan.ItemHeight = 30;
            this.cboKetLuan.Items.AddRange(new object[] {
            "Giữ Nguyên",
            "Thay Đổi"});
            this.cboKetLuan.Location = new System.Drawing.Point(0, 84);
            this.cboKetLuan.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.cboKetLuan.Name = "cboKetLuan";
            this.cboKetLuan.Size = new System.Drawing.Size(452, 36);
            this.cboKetLuan.TabIndex = 6;
            this.cboKetLuan.SelectedIndexChanged += new System.EventHandler(this.cboKetLuan_SelectedIndexChanged);
            // 
            // lblNgayXuLy
            // 
            this.lblNgayXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNgayXuLy.AutoSize = true;
            this.lblNgayXuLy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNgayXuLy.Location = new System.Drawing.Point(459, 66);
            this.lblNgayXuLy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayXuLy.Name = "lblNgayXuLy";
            this.lblNgayXuLy.Size = new System.Drawing.Size(69, 16);
            this.lblNgayXuLy.TabIndex = 3;
            this.lblNgayXuLy.Text = "Ngày xử lý";
            // 
            // dtpNgayXuLy
            // 
            this.dtpNgayXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayXuLy.BorderRadius = 8;
            this.dtpNgayXuLy.Checked = true;
            this.dtpNgayXuLy.FillColor = System.Drawing.Color.MidnightBlue;
            this.dtpNgayXuLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayXuLy.ForeColor = System.Drawing.Color.White;
            this.dtpNgayXuLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuLy.Location = new System.Drawing.Point(462, 86);
            this.dtpNgayXuLy.Margin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.dtpNgayXuLy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayXuLy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayXuLy.Name = "dtpNgayXuLy";
            this.dtpNgayXuLy.Size = new System.Drawing.Size(452, 30);
            this.dtpNgayXuLy.TabIndex = 4;
            this.dtpNgayXuLy.Value = new System.DateTime(2026, 5, 22, 9, 49, 50, 646);
            // 
            // lblGVXuLy
            // 
            this.lblGVXuLy.AutoSize = true;
            this.lblGVXuLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGVXuLy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGVXuLy.Location = new System.Drawing.Point(15, 212);
            this.lblGVXuLy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGVXuLy.Name = "lblGVXuLy";
            this.lblGVXuLy.Size = new System.Drawing.Size(129, 20);
            this.lblGVXuLy.TabIndex = 11;
            this.lblGVXuLy.Text = "Giảng viên xử lý: ";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLyDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyDo.Location = new System.Drawing.Point(15, 146);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ReadOnly = true;
            this.txtLyDo.Size = new System.Drawing.Size(914, 59);
            this.txtLyDo.TabIndex = 13;
            this.txtLyDo.Text = "";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLyDo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLyDo.Location = new System.Drawing.Point(15, 127);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(123, 20);
            this.lblLyDo.TabIndex = 12;
            this.lblLyDo.Text = "Lý do phúc khảo";
            // 
            // lblNgayGuiInfo
            // 
            this.lblNgayGuiInfo.AutoSize = true;
            this.lblNgayGuiInfo.Location = new System.Drawing.Point(15, 103);
            this.lblNgayGuiInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayGuiInfo.Name = "lblNgayGuiInfo";
            this.lblNgayGuiInfo.Size = new System.Drawing.Size(64, 16);
            this.lblNgayGuiInfo.TabIndex = 14;
            this.lblNgayGuiInfo.Text = "Ngày gửi:";
            // 
            // lblMonHocInfo
            // 
            this.lblMonHocInfo.AutoSize = true;
            this.lblMonHocInfo.Location = new System.Drawing.Point(15, 83);
            this.lblMonHocInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonHocInfo.Name = "lblMonHocInfo";
            this.lblMonHocInfo.Size = new System.Drawing.Size(61, 16);
            this.lblMonHocInfo.TabIndex = 15;
            this.lblMonHocInfo.Text = "Môn học:";
            // 
            // lblSinhVienInfo
            // 
            this.lblSinhVienInfo.AutoSize = true;
            this.lblSinhVienInfo.Location = new System.Drawing.Point(15, 63);
            this.lblSinhVienInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinhVienInfo.Name = "lblSinhVienInfo";
            this.lblSinhVienInfo.Size = new System.Drawing.Size(64, 16);
            this.lblSinhVienInfo.TabIndex = 16;
            this.lblSinhVienInfo.Text = "Sinh viên:";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Location = new System.Drawing.Point(15, 43);
            this.lblMaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(55, 16);
            this.lblMaDon.TabIndex = 17;
            this.lblMaDon.Text = "Mã đơn:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblThongTin.Location = new System.Drawing.Point(15, 13);
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(246, 25);
            this.lblThongTin.TabIndex = 18;
            this.lblThongTin.Text = "Thông tin xử lý phúc khảo";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvPhucKhao);
            this.pnlRight.Controls.Add(this.pnlFilter);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(228, 584);
            this.pnlRight.TabIndex = 0;
            // 
            // dgvPhucKhao
            // 
            this.dgvPhucKhao.AllowUserToAddRows = false;
            this.dgvPhucKhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhucKhao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhucKhao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhucKhao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhucKhao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
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
            this.dgvPhucKhao.Location = new System.Drawing.Point(0, 81);
            this.dgvPhucKhao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhucKhao.Name = "dgvPhucKhao";
            this.dgvPhucKhao.RowHeadersVisible = false;
            this.dgvPhucKhao.RowHeadersWidth = 62;
            this.dgvPhucKhao.RowTemplate.Height = 36;
            this.dgvPhucKhao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhucKhao.Size = new System.Drawing.Size(228, 503);
            this.dgvPhucKhao.TabIndex = 1;
            this.dgvPhucKhao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhucKhao_CellClick);
            // 
            // colMaPhucKhaoHidden
            // 
            this.colMaPhucKhaoHidden.MinimumWidth = 8;
            this.colMaPhucKhaoHidden.Name = "colMaPhucKhaoHidden";
            this.colMaPhucKhaoHidden.Visible = false;
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
            // colMaPhucKhao
            // 
            this.colMaPhucKhao.HeaderText = "Mã đơn";
            this.colMaPhucKhao.MinimumWidth = 8;
            this.colMaPhucKhao.Name = "colMaPhucKhao";
            // 
            // colSinhVien
            // 
            this.colSinhVien.FillWeight = 200F;
            this.colSinhVien.HeaderText = "Sinh viên";
            this.colSinhVien.MinimumWidth = 8;
            this.colSinhVien.Name = "colSinhVien";
            // 
            // colMonHoc
            // 
            this.colMonHoc.FillWeight = 160F;
            this.colMonHoc.HeaderText = "Môn học";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            // 
            // colNgayGui
            // 
            this.colNgayGui.HeaderText = "Ngày gửi";
            this.colNgayGui.MinimumWidth = 8;
            this.colNgayGui.Name = "colNgayGui";
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblHocKy);
            this.pnlFilter.Controls.Add(this.cboHocKy);
            this.pnlFilter.Controls.Add(this.lblTrangThai);
            this.pnlFilter.Controls.Add(this.cboTrangThai);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlFilter.Size = new System.Drawing.Size(228, 81);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(10, 8);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(56, 20);
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
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 28;
            this.cboHocKy.Location = new System.Drawing.Point(10, 30);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(167, 34);
            this.cboHocKy.TabIndex = 1;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTrangThai.Location = new System.Drawing.Point(188, 8);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
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
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 28;
            this.cboTrangThai.Location = new System.Drawing.Point(188, 30);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(151, 34);
            this.cboTrangThai.TabIndex = 3;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(350, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍  Tìm MSSV hoặc họ tên...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(217, 27);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmPhucKhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPhucKhao";
            this.Text = "Quản lý phúc khảo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhucKhao_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.tblGrid.ResumeLayout(false);
            this.tblGrid.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitMain;

        // LEFT
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.Label lblSinhVienInfo;
        private System.Windows.Forms.Label lblMonHocInfo;
        private System.Windows.Forms.Label lblNgayGuiInfo;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.RichTextBox txtLyDo;
        private System.Windows.Forms.Label lblGVXuLy;
        private System.Windows.Forms.TableLayoutPanel tblGrid;
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

        // RIGHT
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private System.Windows.Forms.Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPhucKhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhucKhaoHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhucKhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}