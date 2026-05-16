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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvPhucKhao = new System.Windows.Forms.DataGridView();
            this.colMaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSection = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaPK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaPK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSinhVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboSinhVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMonHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLyDo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLyDo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiemCu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDiemCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiemMoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDiemMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBoqua = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1280, 55);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📝 Quản lý phúc khảo";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1280, 665);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvPhucKhao);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(340, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRight.Size = new System.Drawing.Size(940, 665);
            this.pnlRight.TabIndex = 0;
            // 
            // dgvPhucKhao
            // 
            this.dgvPhucKhao.AllowUserToAddRows = false;
            this.dgvPhucKhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhucKhao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhucKhao.ColumnHeadersHeight = 35;
            this.dgvPhucKhao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPK,
            this.colSinhVien,
            this.colMonHoc,
            this.colDiemCu,
            this.colDiemMoi,
            this.colKetLuan,
            this.colTrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhucKhao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhucKhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhucKhao.EnableHeadersVisualStyles = false;
            this.dgvPhucKhao.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPhucKhao.Location = new System.Drawing.Point(20, 75);
            this.dgvPhucKhao.Name = "dgvPhucKhao";
            this.dgvPhucKhao.ReadOnly = true;
            this.dgvPhucKhao.RowHeadersVisible = false;
            this.dgvPhucKhao.RowHeadersWidth = 62;
            this.dgvPhucKhao.RowTemplate.Height = 32;
            this.dgvPhucKhao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhucKhao.Size = new System.Drawing.Size(900, 570);
            this.dgvPhucKhao.TabIndex = 0;
            // 
            // colMaPK
            // 
            this.colMaPK.HeaderText = "Mã PK";
            this.colMaPK.MinimumWidth = 8;
            this.colMaPK.Name = "colMaPK";
            this.colMaPK.ReadOnly = true;
            // 
            // colSinhVien
            // 
            this.colSinhVien.HeaderText = "Sinh viên";
            this.colSinhVien.MinimumWidth = 8;
            this.colSinhVien.Name = "colSinhVien";
            this.colSinhVien.ReadOnly = true;
            // 
            // colMonHoc
            // 
            this.colMonHoc.HeaderText = "Môn học";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            this.colMonHoc.ReadOnly = true;
            // 
            // colDiemCu
            // 
            this.colDiemCu.HeaderText = "Điểm cũ";
            this.colDiemCu.MinimumWidth = 8;
            this.colDiemCu.Name = "colDiemCu";
            this.colDiemCu.ReadOnly = true;
            // 
            // colDiemMoi
            // 
            this.colDiemMoi.HeaderText = "Điểm mới";
            this.colDiemMoi.MinimumWidth = 8;
            this.colDiemMoi.Name = "colDiemMoi";
            this.colDiemMoi.ReadOnly = true;
            // 
            // colKetLuan
            // 
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.MinimumWidth = 8;
            this.colKetLuan.Name = "colKetLuan";
            this.colKetLuan.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(900, 55);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Tìm kiếm sinh viên, môn học...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(380, 38);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLeft.Controls.Add(this.lblSection);
            this.pnlLeft.Controls.Add(this.lblMaPK);
            this.pnlLeft.Controls.Add(this.txtMaPK);
            this.pnlLeft.Controls.Add(this.lblSinhVien);
            this.pnlLeft.Controls.Add(this.cboSinhVien);
            this.pnlLeft.Controls.Add(this.lblMonHoc);
            this.pnlLeft.Controls.Add(this.cboMonHoc);
            this.pnlLeft.Controls.Add(this.lblLyDo);
            this.pnlLeft.Controls.Add(this.txtLyDo);
            this.pnlLeft.Controls.Add(this.lblDiemCu);
            this.pnlLeft.Controls.Add(this.txtDiemCu);
            this.pnlLeft.Controls.Add(this.lblDiemMoi);
            this.pnlLeft.Controls.Add(this.txtDiemMoi);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(340, 665);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSection.Location = new System.Drawing.Point(20, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(217, 27);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "THÔNG TIN PHÚC KHẢO";
            // 
            // lblMaPK
            // 
            this.lblMaPK.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPK.Location = new System.Drawing.Point(20, 55);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(103, 22);
            this.lblMaPK.TabIndex = 1;
            this.lblMaPK.Text = "Mã phúc khảo";
            // 
            // txtMaPK
            // 
            this.txtMaPK.BorderRadius = 8;
            this.txtMaPK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPK.DefaultText = "";
            this.txtMaPK.Enabled = false;
            this.txtMaPK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPK.Location = new System.Drawing.Point(20, 75);
            this.txtMaPK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.PlaceholderText = "Tự động";
            this.txtMaPK.SelectedText = "";
            this.txtMaPK.Size = new System.Drawing.Size(270, 38);
            this.txtMaPK.TabIndex = 2;
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.lblSinhVien.Location = new System.Drawing.Point(20, 125);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(67, 22);
            this.lblSinhVien.TabIndex = 3;
            this.lblSinhVien.Text = "Sinh viên";
            // 
            // cboSinhVien
            // 
            this.cboSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.cboSinhVien.BorderRadius = 8;
            this.cboSinhVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinhVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSinhVien.ItemHeight = 30;
            this.cboSinhVien.Location = new System.Drawing.Point(20, 145);
            this.cboSinhVien.Name = "cboSinhVien";
            this.cboSinhVien.Size = new System.Drawing.Size(270, 36);
            this.cboSinhVien.TabIndex = 4;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblMonHoc.Location = new System.Drawing.Point(20, 195);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(64, 22);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboMonHoc.BorderRadius = 8;
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMonHoc.ItemHeight = 30;
            this.cboMonHoc.Location = new System.Drawing.Point(20, 215);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(270, 36);
            this.cboMonHoc.TabIndex = 6;
            // 
            // lblLyDo
            // 
            this.lblLyDo.BackColor = System.Drawing.Color.Transparent;
            this.lblLyDo.Location = new System.Drawing.Point(20, 265);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(119, 22);
            this.lblLyDo.TabIndex = 7;
            this.lblLyDo.Text = "Lý do phúc khảo";
            // 
            // txtLyDo
            // 
            this.txtLyDo.BorderRadius = 8;
            this.txtLyDo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLyDo.DefaultText = "";
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLyDo.Location = new System.Drawing.Point(20, 285);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.PlaceholderText = "";
            this.txtLyDo.SelectedText = "";
            this.txtLyDo.Size = new System.Drawing.Size(270, 80);
            this.txtLyDo.TabIndex = 8;
            // 
            // lblDiemCu
            // 
            this.lblDiemCu.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemCu.Location = new System.Drawing.Point(20, 380);
            this.lblDiemCu.Name = "lblDiemCu";
            this.lblDiemCu.Size = new System.Drawing.Size(61, 22);
            this.lblDiemCu.TabIndex = 9;
            this.lblDiemCu.Text = "Điểm cũ";
            // 
            // txtDiemCu
            // 
            this.txtDiemCu.BorderRadius = 8;
            this.txtDiemCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemCu.DefaultText = "";
            this.txtDiemCu.Enabled = false;
            this.txtDiemCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemCu.Location = new System.Drawing.Point(20, 400);
            this.txtDiemCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemCu.Name = "txtDiemCu";
            this.txtDiemCu.PlaceholderText = "";
            this.txtDiemCu.SelectedText = "";
            this.txtDiemCu.Size = new System.Drawing.Size(120, 38);
            this.txtDiemCu.TabIndex = 10;
            // 
            // lblDiemMoi
            // 
            this.lblDiemMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemMoi.Location = new System.Drawing.Point(170, 380);
            this.lblDiemMoi.Name = "lblDiemMoi";
            this.lblDiemMoi.Size = new System.Drawing.Size(69, 22);
            this.lblDiemMoi.TabIndex = 11;
            this.lblDiemMoi.Text = "Điểm mới";
            // 
            // txtDiemMoi
            // 
            this.txtDiemMoi.BorderRadius = 8;
            this.txtDiemMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemMoi.DefaultText = "";
            this.txtDiemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiemMoi.Location = new System.Drawing.Point(170, 400);
            this.txtDiemMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemMoi.Name = "txtDiemMoi";
            this.txtDiemMoi.PlaceholderText = "";
            this.txtDiemMoi.SelectedText = "";
            this.txtDiemMoi.Size = new System.Drawing.Size(120, 38);
            this.txtDiemMoi.TabIndex = 12;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnDuyet);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnBoqua);
            this.pnlButtons.Location = new System.Drawing.Point(10, 502);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(280, 110);
            this.pnlButtons.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Thêm";
            // 
            // btnDuyet
            // 
            this.btnDuyet.BorderRadius = 8;
            this.btnDuyet.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(140, 0);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(120, 38);
            this.btnDuyet.TabIndex = 1;
            this.btnDuyet.Text = "✔ Duyệt";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(0, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 38);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "💾 Lưu";
            // 
            // btnBoqua
            // 
            this.btnBoqua.BorderRadius = 8;
            this.btnBoqua.FillColor = System.Drawing.Color.Gray;
            this.btnBoqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoqua.ForeColor = System.Drawing.Color.White;
            this.btnBoqua.Location = new System.Drawing.Point(140, 55);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(120, 38);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "✖ Bỏ qua";
            // 
            // FrmPhucKhao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPhucKhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phúc khảo";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).EndInit();
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

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSection;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaPK;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPK;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSinhVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboSinhVien;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblLyDo;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDo;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiemCu;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemCu;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemMoi;

        private System.Windows.Forms.Panel pnlButtons;

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnDuyet;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnBoqua;

        private System.Windows.Forms.Panel pnlRight;

        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private System.Windows.Forms.DataGridView dgvPhucKhao;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}