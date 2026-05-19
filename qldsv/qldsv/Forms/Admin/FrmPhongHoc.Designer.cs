namespace qldsv.Forms.Admin
{
    partial class FrmPhongHoc
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
            this.dgvPhonghoc = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSectionInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtMaphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtTenphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.BtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBoqua = new Guna.UI2.WinForms.Guna2Button();
            this.BtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghoc)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(239, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⊟  Quản lý phòng học";
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
            this.pnlRight.Controls.Add(this.dgvPhonghoc);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(331, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlRight.Size = new System.Drawing.Size(769, 650);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvPhonghoc
            // 
            this.dgvPhonghoc.AllowUserToAddRows = false;
            this.dgvPhonghoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhonghoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhonghoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.dgvPhonghoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhonghoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhonghoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaphong,
            this.colTenphong});
            this.dgvPhonghoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhonghoc.EnableHeadersVisualStyles = false;
            this.dgvPhonghoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPhonghoc.Location = new System.Drawing.Point(20, 76);
            this.dgvPhonghoc.Name = "dgvPhonghoc";
            this.dgvPhonghoc.ReadOnly = true;
            this.dgvPhonghoc.RowHeadersVisible = false;
            this.dgvPhonghoc.RowHeadersWidth = 62;
            this.dgvPhonghoc.RowTemplate.Height = 34;
            this.dgvPhonghoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhonghoc.Size = new System.Drawing.Size(729, 558);
            this.dgvPhonghoc.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colMaphong
            // 
            this.colMaphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaphong.HeaderText = "Mã phòng";
            this.colMaphong.MinimumWidth = 8;
            this.colMaphong.Name = "colMaphong";
            this.colMaphong.ReadOnly = true;
            this.colMaphong.Width = 110;
            // 
            // colTenphong
            // 
            this.colTenphong.HeaderText = "Tên phòng";
            this.colTenphong.MinimumWidth = 8;
            this.colTenphong.Name = "colTenphong";
            this.colTenphong.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.TxtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearch.Size = new System.Drawing.Size(729, 60);
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
            this.TxtSearch.PlaceholderText = "🔍  Tìm theo tên phòng...";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(400, 46);
            this.TxtSearch.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLeft.Controls.Add(this.lblSectionInfo);
            this.pnlLeft.Controls.Add(this.lblMaPhong);
            this.pnlLeft.Controls.Add(this.TxtMaphong);
            this.pnlLeft.Controls.Add(this.lblTenPhong);
            this.pnlLeft.Controls.Add(this.TxtTenphong);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20, 24, 20, 16);
            this.pnlLeft.Size = new System.Drawing.Size(331, 650);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblSectionInfo
            // 
            this.lblSectionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSectionInfo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSectionInfo.Location = new System.Drawing.Point(20, 24);
            this.lblSectionInfo.Name = "lblSectionInfo";
            this.lblSectionInfo.Size = new System.Drawing.Size(191, 23);
            this.lblSectionInfo.TabIndex = 0;
            this.lblSectionInfo.Text = "THÔNG TIN PHÒNG HỌC";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMaPhong.Location = new System.Drawing.Point(20, 58);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(90, 27);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // TxtMaphong
            // 
            this.TxtMaphong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMaphong.BorderRadius = 8;
            this.TxtMaphong.BorderThickness = 2;
            this.TxtMaphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaphong.DefaultText = "";
            this.TxtMaphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMaphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.TxtMaphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.TxtMaphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.TxtMaphong.Enabled = false;
            this.TxtMaphong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TxtMaphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.TxtMaphong.Location = new System.Drawing.Point(20, 78);
            this.TxtMaphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMaphong.Name = "TxtMaphong";
            this.TxtMaphong.PlaceholderText = "Tự động";
            this.TxtMaphong.SelectedText = "";
            this.TxtMaphong.Size = new System.Drawing.Size(240, 46);
            this.TxtMaphong.TabIndex = 2;
            this.TxtMaphong.TabStop = false;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblTenPhong.Location = new System.Drawing.Point(20, 132);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(108, 27);
            this.lblTenPhong.TabIndex = 3;
            this.lblTenPhong.Text = "Tên phòng *";
            // 
            // TxtTenphong
            // 
            this.TxtTenphong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.TxtTenphong.BorderRadius = 8;
            this.TxtTenphong.BorderThickness = 2;
            this.TxtTenphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenphong.DefaultText = "";
            this.TxtTenphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTenphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTenphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTenphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTenphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTenphong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TxtTenphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.TxtTenphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTenphong.Location = new System.Drawing.Point(20, 154);
            this.TxtTenphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTenphong.Name = "TxtTenphong";
            this.TxtTenphong.PlaceholderText = "VD: D6.206";
            this.TxtTenphong.SelectedText = "";
            this.TxtTenphong.Size = new System.Drawing.Size(240, 46);
            this.TxtTenphong.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.BtnThem);
            this.pnlButtons.Controls.Add(this.BtnSua);
            this.pnlButtons.Controls.Add(this.BtnLuu);
            this.pnlButtons.Controls.Add(this.BtnBoqua);
            this.pnlButtons.Controls.Add(this.BtnXoa);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(20, 474);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
            this.pnlButtons.Size = new System.Drawing.Size(291, 160);
            this.pnlButtons.TabIndex = 6;
            // 
            // BtnThem
            // 
            this.BtnThem.BorderRadius = 8;
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Location = new System.Drawing.Point(20, 12);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(110, 36);
            this.BtnThem.TabIndex = 0;
            this.BtnThem.Text = "+ Thêm";
            // 
            // BtnSua
            // 
            this.BtnSua.BorderRadius = 8;
            this.BtnSua.FillColor = System.Drawing.Color.Goldenrod;
            this.BtnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSua.ForeColor = System.Drawing.Color.White;
            this.BtnSua.Location = new System.Drawing.Point(150, 12);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(110, 36);
            this.BtnSua.TabIndex = 1;
            this.BtnSua.Text = "✏ Sửa";
            // 
            // BtnLuu
            // 
            this.BtnLuu.BorderRadius = 8;
            this.BtnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLuu.ForeColor = System.Drawing.Color.White;
            this.BtnLuu.Location = new System.Drawing.Point(20, 58);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(110, 36);
            this.BtnLuu.TabIndex = 2;
            this.BtnLuu.Text = "💾 Lưu";
            // 
            // BtnBoqua
            // 
            this.BtnBoqua.BorderRadius = 8;
            this.BtnBoqua.FillColor = System.Drawing.Color.SlateGray;
            this.BtnBoqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBoqua.ForeColor = System.Drawing.Color.White;
            this.BtnBoqua.Location = new System.Drawing.Point(55, 105);
            this.BtnBoqua.Name = "BtnBoqua";
            this.BtnBoqua.Size = new System.Drawing.Size(148, 36);
            this.BtnBoqua.TabIndex = 3;
            this.BtnBoqua.Text = "✕ Bỏ qua";
            // 
            // BtnXoa
            // 
            this.BtnXoa.BorderRadius = 8;
            this.BtnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(150, 58);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(110, 36);
            this.BtnXoa.TabIndex = 4;
            this.BtnXoa.Text = "🗑 Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // FrmPhongHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPhongHoc";
            this.Text = "Quản lý phòng học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghoc)).EndInit();
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaPhong;
        private Guna.UI2.WinForms.Guna2TextBox TxtMaphong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhong;
        private Guna.UI2.WinForms.Guna2TextBox TxtTenphong;
        private System.Windows.Forms.Panel pnlButtons;
        public Guna.UI2.WinForms.Guna2Button BtnThem;
        public Guna.UI2.WinForms.Guna2Button BtnSua;
        public Guna.UI2.WinForms.Guna2Button BtnLuu;
        public Guna.UI2.WinForms.Guna2Button BtnBoqua;
        public Guna.UI2.WinForms.Guna2Button BtnXoa;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private System.Windows.Forms.DataGridView dgvPhonghoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenphong;
    }
}