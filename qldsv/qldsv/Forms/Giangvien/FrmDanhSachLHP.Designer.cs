namespace qldsv.Forms.Giangvien
{
    partial class FrmDanhSachLHP
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboThuHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(484, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚  Danh sách lớp học phần giảng dạy";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvLopHocPhan);
            this.pnlMain.Controls.Add(this.lblEmpty);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlMain.Size = new System.Drawing.Size(1100, 644);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AllowUserToAddRows = false;
            this.dgvLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLopHocPhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLopHocPhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopHocPhan.ColumnHeadersHeight = 42;
            this.dgvLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLHP,
            this.colTenMonHoc,
            this.colSoTinChi,
            this.colThuHoc,
            this.colPhongHoc,
            this.colSiSo});
            this.dgvLopHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHocPhan.EnableHeadersVisualStyles = false;
            this.dgvLopHocPhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvLopHocPhan.Location = new System.Drawing.Point(20, 76);
            this.dgvLopHocPhan.MultiSelect = false;
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.ReadOnly = true;
            this.dgvLopHocPhan.RowHeadersVisible = false;
            this.dgvLopHocPhan.RowHeadersWidth = 62;
            this.dgvLopHocPhan.RowTemplate.Height = 36;
            this.dgvLopHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(1060, 552);
            this.dgvLopHocPhan.TabIndex = 0;
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
            // colMaLHP
            // 
            this.colMaLHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaLHP.HeaderText = "Mã LHP";
            this.colMaLHP.MinimumWidth = 8;
            this.colMaLHP.Name = "colMaLHP";
            this.colMaLHP.ReadOnly = true;
            this.colMaLHP.Width = 120;
            // 
            // colTenMonHoc
            // 
            this.colTenMonHoc.HeaderText = "Tên môn học";
            this.colTenMonHoc.MinimumWidth = 8;
            this.colTenMonHoc.Name = "colTenMonHoc";
            this.colTenMonHoc.ReadOnly = true;
            // 
            // colSoTinChi
            // 
            this.colSoTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSoTinChi.HeaderText = "Số TC";
            this.colSoTinChi.MinimumWidth = 8;
            this.colSoTinChi.Name = "colSoTinChi";
            this.colSoTinChi.ReadOnly = true;
            this.colSoTinChi.Width = 90;
            // 
            // colThuHoc
            // 
            this.colThuHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colThuHoc.HeaderText = "Thứ học";
            this.colThuHoc.MinimumWidth = 8;
            this.colThuHoc.Name = "colThuHoc";
            this.colThuHoc.ReadOnly = true;
            this.colThuHoc.Width = 90;
            // 
            // colPhongHoc
            // 
            this.colPhongHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPhongHoc.HeaderText = "Phòng";
            this.colPhongHoc.MinimumWidth = 8;
            this.colPhongHoc.Name = "colPhongHoc";
            this.colPhongHoc.ReadOnly = true;
            this.colPhongHoc.Width = 110;
            // 
            // colSiSo
            // 
            this.colSiSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSiSo.HeaderText = "Sĩ số";
            this.colSiSo.MinimumWidth = 8;
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.ReadOnly = true;
            this.colSiSo.Width = 90;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(24, 72);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(312, 25);
            this.lblEmpty.TabIndex = 1;
            this.lblEmpty.Text = "Không tìm thấy lớp học phần phù hợp";
            this.lblEmpty.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.cboHocKy);
            this.pnlSearch.Controls.Add(this.cboThuHoc);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearch.Size = new System.Drawing.Size(1060, 60);
            this.pnlSearch.TabIndex = 2;
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
            this.cboHocKy.Location = new System.Drawing.Point(96, 0);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(220, 36);
            this.cboHocKy.TabIndex = 0;
            // 
            // cboThuHoc
            // 
            this.cboThuHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboThuHoc.BorderRadius = 8;
            this.cboThuHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThuHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboThuHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThuHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThuHoc.ItemHeight = 30;
            this.cboThuHoc.Location = new System.Drawing.Point(416, 0);
            this.cboThuHoc.Name = "cboThuHoc";
            this.cboThuHoc.Size = new System.Drawing.Size(180, 36);
            this.cboThuHoc.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(627, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍  Tìm mã lớp học phần, môn học hoặc phòng học...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(420, 36);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thứ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học Kì :";
            // 
            // FrmDanhSachLHP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmDanhSachLHP";
            this.Text = "Danh sách lớp học phần";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSearch;

        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuHoc;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private System.Windows.Forms.Label lblEmpty;

        private System.Windows.Forms.DataGridView dgvLopHocPhan;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}