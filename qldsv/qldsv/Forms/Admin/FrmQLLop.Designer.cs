namespace qldsv.Forms.Admin
{
    partial class FrmQLLop
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBoQua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cboCVHT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCVHT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblKhoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSection = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCVHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLocKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 50);
            this.pnlHeader.TabIndex = 2;

            // ── lblTitle ───────────────────────────────
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏫 Quản lý lớp";

            // ── pnlLeft ────────────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Controls.Add(this.cboCVHT);
            this.pnlLeft.Controls.Add(this.lblCVHT);
            this.pnlLeft.Controls.Add(this.cboKhoa);
            this.pnlLeft.Controls.Add(this.lblKhoa);
            this.pnlLeft.Controls.Add(this.txtTenLop);
            this.pnlLeft.Controls.Add(this.lblTenLop);
            this.pnlLeft.Controls.Add(this.txtMaLop);
            this.pnlLeft.Controls.Add(this.lblMaLop);
            this.pnlLeft.Controls.Add(this.lblSection);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(340, 750);
            this.pnlLeft.TabIndex = 1;

            // ── pnlButtons ─────────────────────────────
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnBoQua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Location = new System.Drawing.Point(20, 430);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(290, 160);
            this.pnlButtons.TabIndex = 0;

            // ── btnThem ────────────────────────────────
            this.btnThem.BorderRadius = 8;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Thêm";

            // ── btnSua ─────────────────────────────────
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(150, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏ Sửa";

            // ── btnLuu ─────────────────────────────────
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(0, 52);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "💾 Lưu";

            // ── btnBoQua ───────────────────────────────
            this.btnBoQua.BorderRadius = 8;
            this.btnBoQua.FillColor = System.Drawing.Color.SlateGray;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(150, 52);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(130, 40);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "✖ Bỏ qua";

            // ── btnXoa ─────────────────────────────────
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(0, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(280, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "🗑 Xóa lớp";

            // ── cboCVHT ────────────────────────────────
            this.cboCVHT.BackColor = System.Drawing.Color.Transparent;
            this.cboCVHT.BorderRadius = 8;
            this.cboCVHT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCVHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVHT.FocusedColor = System.Drawing.Color.Empty;
            this.cboCVHT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCVHT.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboCVHT.ItemHeight = 30;
            this.cboCVHT.Location = new System.Drawing.Point(20, 345);
            this.cboCVHT.Name = "cboCVHT";
            this.cboCVHT.Size = new System.Drawing.Size(280, 36);
            this.cboCVHT.TabIndex = 1;

            // ── lblCVHT ────────────────────────────────
            this.lblCVHT.BackColor = System.Drawing.Color.Transparent;
            this.lblCVHT.Location = new System.Drawing.Point(20, 325);
            this.lblCVHT.Name = "lblCVHT";
            this.lblCVHT.Size = new System.Drawing.Size(120, 22);
            this.lblCVHT.TabIndex = 2;
            this.lblCVHT.Text = "Cố vấn học tập";

            // ── cboKhoa ────────────────────────────────
            this.cboKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoa.BorderRadius = 8;
            this.cboKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoa.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboKhoa.ItemHeight = 30;
            this.cboKhoa.Location = new System.Drawing.Point(20, 260);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(280, 36);
            this.cboKhoa.TabIndex = 3;

            // ── lblKhoa ────────────────────────────────
            this.lblKhoa.BackColor = System.Drawing.Color.Transparent;
            this.lblKhoa.Location = new System.Drawing.Point(20, 240);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 22);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa";

            // ── txtTenLop ──────────────────────────────
            this.txtTenLop.BorderRadius = 8;
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(20, 175);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PlaceholderText = "Nhập tên lớp";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(280, 42);
            this.txtTenLop.TabIndex = 5;

            // ── lblTenLop ──────────────────────────────
            this.lblTenLop.BackColor = System.Drawing.Color.Transparent;
            this.lblTenLop.Location = new System.Drawing.Point(20, 155);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(60, 22);
            this.lblTenLop.TabIndex = 6;
            this.lblTenLop.Text = "Tên lớp";

            // ── txtMaLop ───────────────────────────────
            this.txtMaLop.BorderRadius = 8;
            this.txtMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLop.DefaultText = "";
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLop.Location = new System.Drawing.Point(20, 90);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PlaceholderText = "Nhập mã lớp";
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.Size = new System.Drawing.Size(280, 42);
            this.txtMaLop.TabIndex = 7;

            // ── lblMaLop ───────────────────────────────
            this.lblMaLop.BackColor = System.Drawing.Color.Transparent;
            this.lblMaLop.Location = new System.Drawing.Point(20, 70);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 22);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "Mã lớp";

            // ── lblSection ─────────────────────────────
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSection.Location = new System.Drawing.Point(20, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(159, 30);
            this.lblSection.TabIndex = 9;
            this.lblSection.Text = "THÔNG TIN LỚP";

            // ── pnlRight ───────────────────────────────
            this.pnlRight.Controls.Add(this.dgvLop);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(340, 50);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlRight.Size = new System.Drawing.Size(960, 750);
            this.pnlRight.TabIndex = 0;

            // ── dgvLop ─────────────────────────────────
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(232, 234, 246);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.ColumnHeadersHeight = 34;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaLop, this.colTenLop, this.colKhoa, this.colCVHT });
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.EnableHeadersVisualStyles = false;
            this.dgvLop.Location = new System.Drawing.Point(20, 65);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.RowTemplate.Height = 32;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(920, 665);
            this.dgvLop.TabIndex = 0;

            // ── columns ────────────────────────────────
            this.colMaLop.HeaderText = "Mã lớp"; this.colMaLop.Name = "colMaLop"; this.colMaLop.MinimumWidth = 80;
            this.colTenLop.HeaderText = "Tên lớp"; this.colTenLop.Name = "colTenLop"; this.colTenLop.MinimumWidth = 120;
            this.colKhoa.HeaderText = "Khoa"; this.colKhoa.Name = "colKhoa"; this.colKhoa.MinimumWidth = 100;
            this.colCVHT.HeaderText = "Cố vấn học tập"; this.colCVHT.Name = "colCVHT"; this.colCVHT.MinimumWidth = 120;

            // ── pnlSearch ──────────────────────────────
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.cboLocKhoa);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSearch.Size = new System.Drawing.Size(920, 65);
            this.pnlSearch.TabIndex = 1;

            // ── txtTimKiem ─────────────────────────────
            this.txtTimKiem.BorderRadius = 8;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(0, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "🔍 Tìm mã lớp / tên lớp";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(400, 42);
            this.txtTimKiem.TabIndex = 0;

            // ── cboLocKhoa ─────────────────────────────
            // FIX: X = 490 thay vì 1420 (ra ngoài màn hình)
            this.cboLocKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.cboLocKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cboLocKhoa.BorderRadius = 8;
            this.cboLocKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocKhoa.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cboLocKhoa.ItemHeight = 30;
            this.cboLocKhoa.Location = new System.Drawing.Point(490, 14); // ← SỬA TỪ 1420 → 490
            this.cboLocKhoa.Name = "cboLocKhoa";
            this.cboLocKhoa.Size = new System.Drawing.Size(220, 36);
            this.cboLocKhoa.TabIndex = 1;

            // ── FrmQLLop ───────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // FIX: None → Font
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmQLLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSection;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaLop;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCVHT;
        private Guna.UI2.WinForms.Guna2ComboBox cboCVHT;
        private System.Windows.Forms.Panel pnlButtons;
        public Guna.UI2.WinForms.Guna2Button btnThem;
        public Guna.UI2.WinForms.Guna2Button btnSua;
        public Guna.UI2.WinForms.Guna2Button btnLuu;
        public Guna.UI2.WinForms.Guna2Button btnBoQua;
        public Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocKhoa;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCVHT;
    }
}