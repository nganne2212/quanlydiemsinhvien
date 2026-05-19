namespace qldsv.Forms.Admin
{
    partial class FrmQLLichHoc
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
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.colMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSection = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLHP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLopHocPhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboPhongHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblThu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboThu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboCaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBoqua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 Quản lý lịch học";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 700);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvLichHoc);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(340, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRight.Size = new System.Drawing.Size(860, 700);
            this.pnlRight.TabIndex = 0;
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.AllowUserToAddRows = false;
            this.dgvLichHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvLichHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichHoc.ColumnHeadersHeight = 38;
            this.dgvLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLHP,
            this.colMonHoc,
            this.colGiangVien,
            this.colPhong,
            this.colThu,
            this.colCaHoc});
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.EnableHeadersVisualStyles = false;
            this.dgvLichHoc.Location = new System.Drawing.Point(20, 80);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.ReadOnly = true;
            this.dgvLichHoc.RowHeadersVisible = false;
            this.dgvLichHoc.RowHeadersWidth = 62;
            this.dgvLichHoc.RowTemplate.Height = 34;
            this.dgvLichHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHoc.Size = new System.Drawing.Size(820, 600);
            this.dgvLichHoc.TabIndex = 0;
            // 
            // colMaLHP
            // 
            this.colMaLHP.HeaderText = "Mã LHP";
            this.colMaLHP.MinimumWidth = 8;
            this.colMaLHP.Name = "colMaLHP";
            this.colMaLHP.ReadOnly = true;
            // 
            // colMonHoc
            // 
            this.colMonHoc.HeaderText = "Môn học";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            this.colMonHoc.ReadOnly = true;
            // 
            // colGiangVien
            // 
            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.MinimumWidth = 8;
            this.colGiangVien.Name = "colGiangVien";
            this.colGiangVien.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 8;
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colThu
            // 
            this.colThu.HeaderText = "Thứ";
            this.colThu.MinimumWidth = 8;
            this.colThu.Name = "colThu";
            this.colThu.ReadOnly = true;
            // 
            // colCaHoc
            // 
            this.colCaHoc.HeaderText = "Ca";
            this.colCaHoc.MinimumWidth = 8;
            this.colCaHoc.Name = "colCaHoc";
            this.colCaHoc.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(820, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(0, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Tìm theo môn học, phòng, lớp học phần...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 42);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLeft.Controls.Add(this.lblSection);
            this.pnlLeft.Controls.Add(this.lblLHP);
            this.pnlLeft.Controls.Add(this.cboLopHocPhan);
            this.pnlLeft.Controls.Add(this.lblPhong);
            this.pnlLeft.Controls.Add(this.cboPhongHoc);
            this.pnlLeft.Controls.Add(this.lblThu);
            this.pnlLeft.Controls.Add(this.cboThu);
            this.pnlLeft.Controls.Add(this.lblCa);
            this.pnlLeft.Controls.Add(this.cboCaHoc);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(340, 700);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblSection
            // 
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSection.Location = new System.Drawing.Point(20, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(194, 27);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "THÔNG TIN LỊCH HỌC";
            // 
            // lblLHP
            // 
            this.lblLHP.BackColor = System.Drawing.Color.Transparent;
            this.lblLHP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLHP.Location = new System.Drawing.Point(20, 65);
            this.lblLHP.Name = "lblLHP";
            this.lblLHP.Size = new System.Drawing.Size(118, 27);
            this.lblLHP.TabIndex = 1;
            this.lblLHP.Text = "Lớp học phần";
            // 
            // cboLopHocPhan
            // 
            this.cboLopHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHocPhan.BorderRadius = 8;
            this.cboLopHocPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHocPhan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHocPhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHocPhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHocPhan.ItemHeight = 30;
            this.cboLopHocPhan.Location = new System.Drawing.Point(20, 90);
            this.cboLopHocPhan.Name = "cboLopHocPhan";
            this.cboLopHocPhan.Size = new System.Drawing.Size(270, 36);
            this.cboLopHocPhan.TabIndex = 1;
            // 
            // lblPhong
            // 
            this.lblPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhong.Location = new System.Drawing.Point(20, 145);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(94, 27);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng học";
            // 
            // cboPhongHoc
            // 
            this.cboPhongHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboPhongHoc.BorderRadius = 8;
            this.cboPhongHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboPhongHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhongHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhongHoc.ItemHeight = 30;
            this.cboPhongHoc.Location = new System.Drawing.Point(20, 170);
            this.cboPhongHoc.Name = "cboPhongHoc";
            this.cboPhongHoc.Size = new System.Drawing.Size(270, 36);
            this.cboPhongHoc.TabIndex = 2;
            // 
            // lblThu
            // 
            this.lblThu.BackColor = System.Drawing.Color.Transparent;
            this.lblThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThu.Location = new System.Drawing.Point(20, 225);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(37, 27);
            this.lblThu.TabIndex = 3;
            this.lblThu.Text = "Thứ";
            // 
            // cboThu
            // 
            this.cboThu.BackColor = System.Drawing.Color.Transparent;
            this.cboThu.BorderRadius = 8;
            this.cboThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThu.FocusedColor = System.Drawing.Color.Empty;
            this.cboThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThu.ItemHeight = 30;
            this.cboThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.cboThu.Location = new System.Drawing.Point(20, 250);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(270, 36);
            this.cboThu.TabIndex = 3;
            // 
            // lblCa
            // 
            this.lblCa.BackColor = System.Drawing.Color.Transparent;
            this.lblCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCa.Location = new System.Drawing.Point(20, 305);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(60, 27);
            this.lblCa.TabIndex = 4;
            this.lblCa.Text = "Ca học";
            // 
            // cboCaHoc
            // 
            this.cboCaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboCaHoc.BorderRadius = 8;
            this.cboCaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboCaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCaHoc.ItemHeight = 30;
            this.cboCaHoc.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4"});
            this.cboCaHoc.Location = new System.Drawing.Point(20, 330);
            this.cboCaHoc.Name = "cboCaHoc";
            this.cboCaHoc.Size = new System.Drawing.Size(270, 36);
            this.cboCaHoc.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnBoqua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(20, 496);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(300, 184);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(150, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏ Sửa";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(10, 65);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "💾 Lưu";
            // 
            // btnBoqua
            // 
            this.btnBoqua.BorderRadius = 8;
            this.btnBoqua.FillColor = System.Drawing.Color.SlateGray;
            this.btnBoqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoqua.ForeColor = System.Drawing.Color.White;
            this.btnBoqua.Location = new System.Drawing.Point(52, 125);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(142, 40);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "✖ Bỏ qua";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(150, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "🗑 Xóa";
            // 
            // FrmQLLichHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmQLLichHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch học";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
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
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlButtons;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSection;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLHP;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHocPhan;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhongHoc;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblThu;
        private Guna.UI2.WinForms.Guna2ComboBox cboThu;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCa;
        private Guna.UI2.WinForms.Guna2ComboBox cboCaHoc;

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnBoqua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private System.Windows.Forms.DataGridView dgvLichHoc;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaHoc;
    }
}