using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace qldsv.Forms.Admin
{
    partial class FrmLopHocPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSVGrid = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSVButtons = new System.Windows.Forms.Panel();
            this.btnThemSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnImportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSV = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSVTop = new System.Windows.Forms.Panel();
            this.pnlSearchSV = new System.Windows.Forms.Panel();
            this.txtSearchSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSV = new System.Windows.Forms.Label();
            this.pnlLHPGrid = new System.Windows.Forms.Panel();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.colMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchLHP = new System.Windows.Forms.Panel();
            this.txtSearchLHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSection = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaLHP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaLHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMonHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGiangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboGiangVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayBD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayKT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBoQua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSVGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.pnlSVButtons.SuspendLayout();
            this.pnlSVTop.SuspendLayout();
            this.pnlSearchSV.SuspendLayout();
            this.pnlLHPGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.pnlSearchLHP.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1200, 52);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1200, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 Quản lý lớp học phần";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 52);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 698);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlSVGrid);
            this.pnlRight.Controls.Add(this.pnlSVButtons);
            this.pnlRight.Controls.Add(this.pnlSVTop);
            this.pnlRight.Controls.Add(this.pnlLHPGrid);
            this.pnlRight.Controls.Add(this.pnlSearchLHP);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlRight.Size = new System.Drawing.Size(900, 698);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlSVGrid
            // 
            this.pnlSVGrid.Controls.Add(this.dgvSinhVien);
            this.pnlSVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSVGrid.Location = new System.Drawing.Point(10, 329);
            this.pnlSVGrid.Name = "pnlSVGrid";
            this.pnlSVGrid.Size = new System.Drawing.Size(880, 314);
            this.pnlSVGrid.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSinhVien.ColumnHeadersHeight = 34;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colLop,
            this.colEmail});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSinhVien.EnableHeadersVisualStyles = false;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(880, 314);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 8;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            // 
            // colLop
            // 
            this.colLop.HeaderText = "Lớp";
            this.colLop.MinimumWidth = 8;
            this.colLop.Name = "colLop";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            // 
            // pnlSVButtons
            // 
            this.pnlSVButtons.Controls.Add(this.btnThemSV);
            this.pnlSVButtons.Controls.Add(this.btnImportExcel);
            this.pnlSVButtons.Controls.Add(this.btnXoaSV);
            this.pnlSVButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSVButtons.Location = new System.Drawing.Point(10, 643);
            this.pnlSVButtons.Name = "pnlSVButtons";
            this.pnlSVButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSVButtons.Size = new System.Drawing.Size(880, 50);
            this.pnlSVButtons.TabIndex = 1;
            // 
            // btnThemSV
            // 
            this.btnThemSV.BorderRadius = 8;
            this.btnThemSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemSV.ForeColor = System.Drawing.Color.White;
            this.btnThemSV.Location = new System.Drawing.Point(0, 0);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(129, 40);
            this.btnThemSV.TabIndex = 0;
            this.btnThemSV.Text = "+ Thêm SV";
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BorderRadius = 8;
            this.btnImportExcel.FillColor = System.Drawing.Color.SeaGreen;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(155, 0);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(145, 40);
            this.btnImportExcel.TabIndex = 1;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BorderRadius = 8;
            this.btnXoaSV.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaSV.ForeColor = System.Drawing.Color.White;
            this.btnXoaSV.Location = new System.Drawing.Point(326, 0);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(120, 40);
            this.btnXoaSV.TabIndex = 2;
            this.btnXoaSV.Text = "Xóa SV";
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // pnlSVTop
            // 
            this.pnlSVTop.Controls.Add(this.pnlSearchSV);
            this.pnlSVTop.Controls.Add(this.lblSV);
            this.pnlSVTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSVTop.Location = new System.Drawing.Point(10, 253);
            this.pnlSVTop.Name = "pnlSVTop";
            this.pnlSVTop.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlSVTop.Size = new System.Drawing.Size(880, 76);
            this.pnlSVTop.TabIndex = 2;
            // 
            // pnlSearchSV
            // 
            this.pnlSearchSV.Controls.Add(this.txtSearchSV);
            this.pnlSearchSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchSV.Location = new System.Drawing.Point(0, 36);
            this.pnlSearchSV.Name = "pnlSearchSV";
            this.pnlSearchSV.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlSearchSV.Size = new System.Drawing.Size(880, 42);
            this.pnlSearchSV.TabIndex = 0;
            // 
            // txtSearchSV
            // 
            this.txtSearchSV.BorderRadius = 8;
            this.txtSearchSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSV.DefaultText = "";
            this.txtSearchSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchSV.Location = new System.Drawing.Point(0, 4);
            this.txtSearchSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchSV.Name = "txtSearchSV";
            this.txtSearchSV.PlaceholderText = "Tìm MSSV / ho ten sinh vien";
            this.txtSearchSV.SelectedText = "";
            this.txtSearchSV.Size = new System.Drawing.Size(320, 38);
            this.txtSearchSV.TabIndex = 0;
            this.txtSearchSV.TextChanged += new System.EventHandler(this.txtSearchSV_TextChanged);
            this.txtSearchSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSV_KeyDown);
            // 
            // lblSV
            // 
            this.lblSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSV.Location = new System.Drawing.Point(0, 8);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(880, 28);
            this.lblSV.TabIndex = 1;
            this.lblSV.Text = "DANH SÁCH SINH VIÊN";
            // 
            // pnlLHPGrid
            // 
            this.pnlLHPGrid.Controls.Add(this.dgvLopHocPhan);
            this.pnlLHPGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLHPGrid.Location = new System.Drawing.Point(10, 53);
            this.pnlLHPGrid.Name = "pnlLHPGrid";
            this.pnlLHPGrid.Size = new System.Drawing.Size(880, 200);
            this.pnlLHPGrid.TabIndex = 3;
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AllowUserToAddRows = false;
            this.dgvLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvLopHocPhan.ColumnHeadersHeight = 34;
            this.dgvLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLHP,
            this.colMonHoc,
            this.colGiangVien,
            this.colHocKy,
            this.colSoSV});
            this.dgvLopHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHocPhan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLopHocPhan.EnableHeadersVisualStyles = false;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(0, 0);
            this.dgvLopHocPhan.MultiSelect = false;
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.RowHeadersVisible = false;
            this.dgvLopHocPhan.RowHeadersWidth = 62;
            this.dgvLopHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(880, 200);
            this.dgvLopHocPhan.TabIndex = 0;
            this.dgvLopHocPhan.Click += new System.EventHandler(this.dgvLopHocPhan_Click);
            // 
            // colMaLHP
            // 
            this.colMaLHP.HeaderText = "Mã LHP";
            this.colMaLHP.MinimumWidth = 8;
            this.colMaLHP.Name = "colMaLHP";
            // 
            // colMonHoc
            // 
            this.colMonHoc.HeaderText = "Môn hoc";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            // 
            // colGiangVien
            // 
            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.MinimumWidth = 8;
            this.colGiangVien.Name = "colGiangVien";
            // 
            // colHocKy
            // 
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.MinimumWidth = 8;
            this.colHocKy.Name = "colHocKy";
            // 
            // colSoSV
            // 
            this.colSoSV.HeaderText = "Số SV";
            this.colSoSV.MinimumWidth = 8;
            this.colSoSV.Name = "colSoSV";
            // 
            // pnlSearchLHP
            // 
            this.pnlSearchLHP.Controls.Add(this.txtSearchLHP);
            this.pnlSearchLHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchLHP.Location = new System.Drawing.Point(10, 5);
            this.pnlSearchLHP.Name = "pnlSearchLHP";
            this.pnlSearchLHP.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlSearchLHP.Size = new System.Drawing.Size(880, 48);
            this.pnlSearchLHP.TabIndex = 4;
            // 
            // txtSearchLHP
            // 
            this.txtSearchLHP.BorderRadius = 8;
            this.txtSearchLHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchLHP.DefaultText = "";
            this.txtSearchLHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchLHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchLHP.Location = new System.Drawing.Point(0, 6);
            this.txtSearchLHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchLHP.Name = "txtSearchLHP";
            this.txtSearchLHP.PlaceholderText = "Tìm lớp học phần theo môn / giảng viên / học kỳ";
            this.txtSearchLHP.SelectedText = "";
            this.txtSearchLHP.Size = new System.Drawing.Size(880, 36);
            this.txtSearchLHP.TabIndex = 0;
            this.txtSearchLHP.TextChanged += new System.EventHandler(this.txtSearchLHP_TextChanged);
            this.txtSearchLHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchLHP_KeyDown);
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlLeft.Controls.Add(this.lblSection);
            this.pnlLeft.Controls.Add(this.lblMaLHP);
            this.pnlLeft.Controls.Add(this.txtMaLHP);
            this.pnlLeft.Controls.Add(this.lblMonHoc);
            this.pnlLeft.Controls.Add(this.cboMonHoc);
            this.pnlLeft.Controls.Add(this.lblGiangVien);
            this.pnlLeft.Controls.Add(this.cboGiangVien);
            this.pnlLeft.Controls.Add(this.lblHocKy);
            this.pnlLeft.Controls.Add(this.cboHocKy);
            this.pnlLeft.Controls.Add(this.lblNgayBD);
            this.pnlLeft.Controls.Add(this.dtpNgayBatDau);
            this.pnlLeft.Controls.Add(this.lblNgayKT);
            this.pnlLeft.Controls.Add(this.dtpNgayKetThuc);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(16);
            this.pnlLeft.Size = new System.Drawing.Size(300, 698);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSection.Location = new System.Drawing.Point(16, 12);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(257, 27);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "THÔNG TIN LỚP HỌC PHẦN";
            // 
            // lblMaLHP
            // 
            this.lblMaLHP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaLHP.Location = new System.Drawing.Point(16, 42);
            this.lblMaLHP.Name = "lblMaLHP";
            this.lblMaLHP.Size = new System.Drawing.Size(120, 22);
            this.lblMaLHP.TabIndex = 1;
            this.lblMaLHP.Text = "Mã lớp học phần";
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.BorderRadius = 8;
            this.txtMaLHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLHP.DefaultText = "";
            this.txtMaLHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLHP.Location = new System.Drawing.Point(16, 60);
            this.txtMaLHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.PlaceholderText = "Nhap ma lop hoc phan";
            this.txtMaLHP.SelectedText = "";
            this.txtMaLHP.Size = new System.Drawing.Size(255, 36);
            this.txtMaLHP.TabIndex = 2;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblMonHoc.Location = new System.Drawing.Point(16, 106);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(64, 22);
            this.lblMonHoc.TabIndex = 3;
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
            this.cboMonHoc.Location = new System.Drawing.Point(16, 124);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(255, 36);
            this.cboMonHoc.TabIndex = 4;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiangVien.Location = new System.Drawing.Point(16, 170);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(78, 22);
            this.lblGiangVien.TabIndex = 5;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.cboGiangVien.BorderRadius = 8;
            this.cboGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiangVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboGiangVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGiangVien.ItemHeight = 30;
            this.cboGiangVien.Location = new System.Drawing.Point(16, 188);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(255, 36);
            this.cboGiangVien.TabIndex = 6;
            // 
            // lblHocKy
            // 
            this.lblHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKy.Location = new System.Drawing.Point(16, 234);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(51, 22);
            this.lblHocKy.TabIndex = 7;
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
            this.cboHocKy.Location = new System.Drawing.Point(16, 252);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(255, 36);
            this.cboHocKy.TabIndex = 8;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayBD.Location = new System.Drawing.Point(16, 298);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(97, 22);
            this.lblNgayBD.TabIndex = 9;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.BorderRadius = 8;
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(16, 316);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(255, 36);
            this.dtpNgayBatDau.TabIndex = 10;
            this.dtpNgayBatDau.Value = new System.DateTime(2026, 5, 16, 11, 24, 26, 873);
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayKT.Location = new System.Drawing.Point(16, 362);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(100, 22);
            this.lblNgayKT.TabIndex = 11;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.BorderRadius = 8;
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(16, 380);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(255, 36);
            this.dtpNgayKetThuc.TabIndex = 12;
            this.dtpNgayKetThuc.Value = new System.DateTime(2026, 5, 16, 11, 24, 26, 963);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnLuu);
            this.pnlButtons.Controls.Add(this.btnBoQua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Location = new System.Drawing.Point(16, 430);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(255, 150);
            this.pnlButtons.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
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
            this.btnSua.Location = new System.Drawing.Point(128, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(0, 48);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BorderRadius = 8;
            this.btnBoQua.FillColor = System.Drawing.Color.SlateGray;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(128, 48);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(120, 40);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(0, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(255, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa lớp học phần";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmLopHocPhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmLopHocPhan";
            this.Text = "Quan ly lop hoc phan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLopHocPhan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlSVGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.pnlSVButtons.ResumeLayout(false);
            this.pnlSVTop.ResumeLayout(false);
            this.pnlSearchSV.ResumeLayout(false);
            this.pnlLHPGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.pnlSearchLHP.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlMain;
        private Panel pnlLeft;
        private Panel pnlRight;

        private Guna2HtmlLabel lblSection;
        private Guna2HtmlLabel lblMaLHP;
        private Guna2TextBox txtMaLHP;
        private Guna2HtmlLabel lblMonHoc;
        private Guna2ComboBox cboMonHoc;
        private Guna2HtmlLabel lblGiangVien;
        private Guna2ComboBox cboGiangVien;
        private Guna2HtmlLabel lblHocKy;
        private Guna2ComboBox cboHocKy;
        private Guna2HtmlLabel lblNgayBD;
        private Guna2DateTimePicker dtpNgayBatDau;
        private Guna2HtmlLabel lblNgayKT;
        private Guna2DateTimePicker dtpNgayKetThuc;
        private Panel pnlButtons;
        public Guna2Button btnThem;
        public Guna2Button btnSua;
        public Guna2Button btnLuu;
        public Guna2Button btnBoQua;
        public Guna2Button btnXoa;

        private Panel pnlSearchLHP;
        private Guna2TextBox txtSearchLHP;
        private Panel pnlLHPGrid;
        private DataGridView dgvLopHocPhan;

        private Panel pnlSVTop;
        private Label lblSV;
        private Panel pnlSearchSV;
        private Guna2TextBox txtSearchSV;
        private Panel pnlSVGrid;
        private DataGridView dgvSinhVien;
        private Panel pnlSVButtons;
        public Guna2Button btnThemSV;
        public Guna2Button btnImportExcel;
        public Guna2Button btnXoaSV;
        private DataGridViewTextBoxColumn colMSSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colLop;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colMaLHP;
        private DataGridViewTextBoxColumn colMonHoc;
        private DataGridViewTextBoxColumn colGiangVien;
        private DataGridViewTextBoxColumn colHocKy;
        private DataGridViewTextBoxColumn colSoSV;
    }
}