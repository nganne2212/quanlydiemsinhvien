namespace qldsv.Forms.Admin
{
    partial class FrmHocKy
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvQuanlyhocky = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMahocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSectionInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMahocky = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenhocky = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNamHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNamhoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBoqua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblDivider = new System.Windows.Forms.Label();
            this.btnMohocky = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonghocky = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyhocky)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🗓  Quản lý học kỳ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 650);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvQuanlyhocky);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(327, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlRight.Size = new System.Drawing.Size(773, 650);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvQuanlyhocky
            // 
            this.dgvQuanlyhocky.AllowUserToAddRows = false;
            this.dgvQuanlyhocky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlyhocky.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanlyhocky.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.dgvQuanlyhocky.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanlyhocky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyhocky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMahocky,
            this.colTenhocky,
            this.colNamhoc,
            this.colTrangthai});
            this.dgvQuanlyhocky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanlyhocky.EnableHeadersVisualStyles = false;
            this.dgvQuanlyhocky.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvQuanlyhocky.Location = new System.Drawing.Point(20, 76);
            this.dgvQuanlyhocky.Name = "dgvQuanlyhocky";
            this.dgvQuanlyhocky.ReadOnly = true;
            this.dgvQuanlyhocky.RowHeadersVisible = false;
            this.dgvQuanlyhocky.RowHeadersWidth = 62;
            this.dgvQuanlyhocky.RowTemplate.Height = 34;
            this.dgvQuanlyhocky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanlyhocky.Size = new System.Drawing.Size(733, 558);
            this.dgvQuanlyhocky.TabIndex = 1;
            this.dgvQuanlyhocky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlyhocky_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 55;
            // 
            // colMahocky
            // 
            this.colMahocky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMahocky.HeaderText = "Mã HK";
            this.colMahocky.MinimumWidth = 8;
            this.colMahocky.Name = "colMahocky";
            this.colMahocky.ReadOnly = true;
            this.colMahocky.Width = 80;
            // 
            // colTenhocky
            // 
            this.colTenhocky.HeaderText = "Tên học kỳ";
            this.colTenhocky.MinimumWidth = 8;
            this.colTenhocky.Name = "colTenhocky";
            this.colTenhocky.ReadOnly = true;
            // 
            // colNamhoc
            // 
            this.colNamhoc.HeaderText = "Năm học";
            this.colNamhoc.MinimumWidth = 8;
            this.colNamhoc.Name = "colNamhoc";
            this.colNamhoc.ReadOnly = true;
            // 
            // colTrangthai
            // 
            this.colTrangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTrangthai.HeaderText = "Trạng thái";
            this.colTrangthai.MinimumWidth = 8;
            this.colTrangthai.Name = "colTrangthai";
            this.colTrangthai.ReadOnly = true;
            this.colTrangthai.Width = 110;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.TxtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearch.Size = new System.Drawing.Size(733, 60);
            this.pnlSearch.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtSearch.BorderRadius = 8;
            this.TxtSearch.BorderThickness = 2;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Location = new System.Drawing.Point(0, 0);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "🔍  Tìm theo tên học kỳ, năm học...";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(420, 46);
            this.TxtSearch.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLeft.Controls.Add(this.lblSectionInfo);
            this.pnlLeft.Controls.Add(this.lblMaHocKy);
            this.pnlLeft.Controls.Add(this.txtMahocky);
            this.pnlLeft.Controls.Add(this.lblTenHocKy);
            this.pnlLeft.Controls.Add(this.txtTenhocky);
            this.pnlLeft.Controls.Add(this.lblNamHoc);
            this.pnlLeft.Controls.Add(this.txtNamhoc);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20, 24, 20, 16);
            this.pnlLeft.Size = new System.Drawing.Size(327, 650);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblSectionInfo
            // 
            this.lblSectionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSectionInfo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSectionInfo.Location = new System.Drawing.Point(20, 24);
            this.lblSectionInfo.Name = "lblSectionInfo";
            this.lblSectionInfo.Size = new System.Drawing.Size(153, 23);
            this.lblSectionInfo.TabIndex = 0;
            this.lblSectionInfo.Text = "THÔNG TIN HỌC KỲ";
            // 
            // lblMaHocKy
            // 
            this.lblMaHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMaHocKy.Location = new System.Drawing.Point(20, 56);
            this.lblMaHocKy.Name = "lblMaHocKy";
            this.lblMaHocKy.Size = new System.Drawing.Size(91, 27);
            this.lblMaHocKy.TabIndex = 1;
            this.lblMaHocKy.Text = "Mã học kỳ";
            // 
            // txtMahocky
            // 
            this.txtMahocky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMahocky.BorderRadius = 8;
            this.txtMahocky.BorderThickness = 2;
            this.txtMahocky.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMahocky.DefaultText = "";
            this.txtMahocky.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMahocky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtMahocky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.txtMahocky.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.txtMahocky.Enabled = false;
            this.txtMahocky.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMahocky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.txtMahocky.Location = new System.Drawing.Point(20, 76);
            this.txtMahocky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMahocky.Name = "txtMahocky";
            this.txtMahocky.PlaceholderText = "Tự động";
            this.txtMahocky.SelectedText = "";
            this.txtMahocky.Size = new System.Drawing.Size(250, 46);
            this.txtMahocky.TabIndex = 2;
            this.txtMahocky.TabStop = false;
            // 
            // lblTenHocKy
            // 
            this.lblTenHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblTenHocKy.Location = new System.Drawing.Point(20, 136);
            this.lblTenHocKy.Name = "lblTenHocKy";
            this.lblTenHocKy.Size = new System.Drawing.Size(109, 27);
            this.lblTenHocKy.TabIndex = 3;
            this.lblTenHocKy.Text = "Tên học kỳ *";
            // 
            // txtTenhocky
            // 
            this.txtTenhocky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.txtTenhocky.BorderRadius = 8;
            this.txtTenhocky.BorderThickness = 2;
            this.txtTenhocky.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenhocky.DefaultText = "";
            this.txtTenhocky.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenhocky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenhocky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhocky.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhocky.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhocky.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenhocky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtTenhocky.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhocky.Location = new System.Drawing.Point(20, 158);
            this.txtTenhocky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenhocky.Name = "txtTenhocky";
            this.txtTenhocky.PlaceholderText = "VD: Học kỳ 1";
            this.txtTenhocky.SelectedText = "";
            this.txtTenhocky.Size = new System.Drawing.Size(250, 46);
            this.txtTenhocky.TabIndex = 4;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblNamHoc.Location = new System.Drawing.Point(20, 218);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(92, 27);
            this.lblNamHoc.TabIndex = 5;
            this.lblNamHoc.Text = "Năm học *";
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.txtNamhoc.BorderRadius = 8;
            this.txtNamhoc.BorderThickness = 2;
            this.txtNamhoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamhoc.DefaultText = "";
            this.txtNamhoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamhoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamhoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamhoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamhoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamhoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNamhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNamhoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamhoc.Location = new System.Drawing.Point(20, 240);
            this.txtNamhoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.PlaceholderText = "VD: 2024-2025";
            this.txtNamhoc.SelectedText = "";
            this.txtNamhoc.Size = new System.Drawing.Size(250, 46);
            this.txtNamhoc.TabIndex = 6;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnBoqua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.lblDivider);
            this.pnlButtons.Controls.Add(this.btnMohocky);
            this.pnlButtons.Controls.Add(this.btnDonghocky);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(20, 368);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
            this.pnlButtons.Size = new System.Drawing.Size(287, 266);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(155, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(20, 58);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 36);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BorderRadius = 8;
            this.btnBoqua.FillColor = System.Drawing.Color.SlateGray;
            this.btnBoqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoqua.ForeColor = System.Drawing.Color.White;
            this.btnBoqua.Location = new System.Drawing.Point(78, 111);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(115, 36);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "✕ Bỏ qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(155, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDivider.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDivider.Location = new System.Drawing.Point(20, 150);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(250, 16);
            this.lblDivider.TabIndex = 5;
            this.lblDivider.Text = "TRẠNG THÁI HỌC KỲ";
            // 
            // btnMohocky
            // 
            this.btnMohocky.BorderRadius = 8;
            this.btnMohocky.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnMohocky.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMohocky.ForeColor = System.Drawing.Color.White;
            this.btnMohocky.Location = new System.Drawing.Point(20, 172);
            this.btnMohocky.Name = "btnMohocky";
            this.btnMohocky.Size = new System.Drawing.Size(244, 36);
            this.btnMohocky.TabIndex = 6;
            this.btnMohocky.Text = "🔓 Mở học kỳ";
            this.btnMohocky.Click += new System.EventHandler(this.btnMoHocKy_Click);
            // 
            // btnDonghocky
            // 
            this.btnDonghocky.BorderRadius = 8;
            this.btnDonghocky.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnDonghocky.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDonghocky.ForeColor = System.Drawing.Color.White;
            this.btnDonghocky.Location = new System.Drawing.Point(20, 214);
            this.btnDonghocky.Name = "btnDonghocky";
            this.btnDonghocky.Size = new System.Drawing.Size(244, 36);
            this.btnDonghocky.TabIndex = 7;
            this.btnDonghocky.Text = "🔒 Đóng học kỳ";
            this.btnDonghocky.Click += new System.EventHandler(this.btnDongHocKy_Click);
            // 
            // FrmHocKy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmHocKy";
            this.Text = "Quản lý học kỳ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHocKy_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyhocky)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSectionInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHocKy;
        private Guna.UI2.WinForms.Guna2TextBox txtMahocky;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenHocKy;
        private Guna.UI2.WinForms.Guna2TextBox txtTenhocky;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNamHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtNamhoc;
        private System.Windows.Forms.Panel pnlButtons;
        public Guna.UI2.WinForms.Guna2Button btnThem;
        public Guna.UI2.WinForms.Guna2Button btnSua;
        public Guna.UI2.WinForms.Guna2Button btnLuu;
        public Guna.UI2.WinForms.Guna2Button btnBoqua;
        public Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label lblDivider;
        public Guna.UI2.WinForms.Guna2Button btnMohocky;
        public Guna.UI2.WinForms.Guna2Button btnDonghocky;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dgvQuanlyhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangthai;
    }
}