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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblThuHoc = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboThuHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.pnlFooter.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1250, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 Danh sách lớp học phần";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.dgvLopHocPhan);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.lblEmpty);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18);
            this.pnlMain.Size = new System.Drawing.Size(1250, 695);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AllowUserToAddRows = false;
            this.dgvLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLopHocPhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLopHocPhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvLopHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvLopHocPhan.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(18, 113);
            this.dgvLopHocPhan.MultiSelect = false;
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.ReadOnly = true;
            this.dgvLopHocPhan.RowHeadersVisible = false;
            this.dgvLopHocPhan.RowHeadersWidth = 62;
            this.dgvLopHocPhan.RowTemplate.Height = 36;
            this.dgvLopHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(1214, 514);
            this.dgvLopHocPhan.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 45F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMaLHP
            // 
            this.colMaLHP.FillWeight = 90F;
            this.colMaLHP.HeaderText = "Mã LHP";
            this.colMaLHP.MinimumWidth = 8;
            this.colMaLHP.Name = "colMaLHP";
            this.colMaLHP.ReadOnly = true;
            // 
            // colTenMonHoc
            // 
            this.colTenMonHoc.FillWeight = 200F;
            this.colTenMonHoc.HeaderText = "Tên môn học";
            this.colTenMonHoc.MinimumWidth = 8;
            this.colTenMonHoc.Name = "colTenMonHoc";
            this.colTenMonHoc.ReadOnly = true;
            // 
            // colSoTinChi
            // 
            this.colSoTinChi.FillWeight = 60F;
            this.colSoTinChi.HeaderText = "Số TC";
            this.colSoTinChi.MinimumWidth = 8;
            this.colSoTinChi.Name = "colSoTinChi";
            this.colSoTinChi.ReadOnly = true;
            // 
            // colThuHoc
            // 
            this.colThuHoc.FillWeight = 60F;
            this.colThuHoc.HeaderText = "Thứ";
            this.colThuHoc.MinimumWidth = 8;
            this.colThuHoc.Name = "colThuHoc";
            this.colThuHoc.ReadOnly = true;
            // 
            // colPhongHoc
            // 
            this.colPhongHoc.FillWeight = 80F;
            this.colPhongHoc.HeaderText = "Phòng";
            this.colPhongHoc.MinimumWidth = 8;
            this.colPhongHoc.Name = "colPhongHoc";
            this.colPhongHoc.ReadOnly = true;
            // 
            // colSiSo
            // 
            this.colSiSo.FillWeight = 60F;
            this.colSiSo.HeaderText = "Sĩ số";
            this.colSiSo.MinimumWidth = 8;
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.ReadOnly = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.lblThongKe);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(18, 627);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1214, 50);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblThongKe.ForeColor = System.Drawing.Color.DimGray;
            this.lblThongKe.Location = new System.Drawing.Point(20, 14);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(186, 25);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Tổng lớp học phần: 0";
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(24, 125);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(263, 25);
            this.lblEmpty.TabIndex = 3;
            this.lblEmpty.Text = "Không tìm thấy dữ liệu phù hợp";
            this.lblEmpty.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.lblHocKy);
            this.pnlSearch.Controls.Add(this.lblThuHoc);
            this.pnlSearch.Controls.Add(this.cboHocKy);
            this.pnlSearch.Controls.Add(this.cboThuHoc);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(18, 18);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1214, 95);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(22, 14);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(77, 28);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblThuHoc
            // 
            this.lblThuHoc.AutoSize = true;
            this.lblThuHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuHoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblThuHoc.Location = new System.Drawing.Point(305, 14);
            this.lblThuHoc.Name = "lblThuHoc";
            this.lblThuHoc.Size = new System.Drawing.Size(89, 28);
            this.lblThuHoc.TabIndex = 1;
            this.lblThuHoc.Text = "Thứ học";
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
            this.cboHocKy.Location = new System.Drawing.Point(26, 45);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(240, 36);
            this.cboHocKy.TabIndex = 2;
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
            this.cboThuHoc.Location = new System.Drawing.Point(309, 45);
            this.cboThuHoc.Name = "cboThuHoc";
            this.cboThuHoc.Size = new System.Drawing.Size(210, 36);
            this.cboThuHoc.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(785, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Tìm mã lớp, môn học hoặc phòng...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 36);
            this.txtSearch.TabIndex = 4;
            // 
            // FrmDanhSachLHP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 750);
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
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblThuHoc;

        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuHoc;

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;

        private System.Windows.Forms.DataGridView dgvLopHocPhan;

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;

        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Label lblEmpty;
    }
}