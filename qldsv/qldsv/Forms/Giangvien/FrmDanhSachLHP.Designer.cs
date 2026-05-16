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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.pnlSearch = new System.Windows.Forms.Panel();

            this.cboHocKy =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.cboThuHoc =
                new Guna.UI2.WinForms.Guna2ComboBox();

            this.txtSearch =
                new Guna.UI2.WinForms.Guna2TextBox();

            this.lblEmpty =
                new System.Windows.Forms.Label();

            this.dgvLopHocPhan =
                new System.Windows.Forms.DataGridView();

            this.colSTT =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMaLHP =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTenMonHoc =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colSoTinChi =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colThuHoc =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colPhongHoc =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colSiSo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            // pnlHeader
            this.pnlHeader.BackColor =
                System.Drawing.Color.MidnightBlue;

            this.pnlHeader.Controls.Add(this.lblTitle);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Location =
                new System.Drawing.Point(0, 0);

            this.pnlHeader.Name = "pnlHeader";

            this.pnlHeader.Size =
                new System.Drawing.Size(1100, 56);

            // lblTitle
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(20, 14);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Text =
                "📚  Danh sách lớp học phần giảng dạy";

            // pnlMain
            this.pnlMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlMain.Padding =
                new System.Windows.Forms.Padding(20, 16, 20, 16);

            this.pnlMain.Controls.Add(this.dgvLopHocPhan);
            this.pnlMain.Controls.Add(this.lblEmpty);
            this.pnlMain.Controls.Add(this.pnlSearch);

            // pnlSearch
            this.pnlSearch.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlSearch.Height = 60;

            this.pnlSearch.Padding =
                new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.pnlSearch.Controls.Add(this.cboHocKy);
            this.pnlSearch.Controls.Add(this.cboThuHoc);
            this.pnlSearch.Controls.Add(this.txtSearch);

            // cboHocKy
            this.cboHocKy.BackColor =
                System.Drawing.Color.Transparent;

            this.cboHocKy.BorderRadius = 8;

            this.cboHocKy.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.cboHocKy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboHocKy.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboHocKy.ItemHeight = 30;

            this.cboHocKy.Location =
                new System.Drawing.Point(0, 0);

            this.cboHocKy.Name = "cboHocKy";

            this.cboHocKy.Size =
                new System.Drawing.Size(220, 36);

            // cboThuHoc
            this.cboThuHoc.BackColor =
                System.Drawing.Color.Transparent;

            this.cboThuHoc.BorderRadius = 8;

            this.cboThuHoc.DrawMode =
                System.Windows.Forms.DrawMode.OwnerDrawFixed;

            this.cboThuHoc.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboThuHoc.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cboThuHoc.ItemHeight = 30;

            this.cboThuHoc.Location =
                new System.Drawing.Point(240, 0);

            this.cboThuHoc.Name = "cboThuHoc";

            this.cboThuHoc.Size =
                new System.Drawing.Size(180, 36);

            // txtSearch
            this.txtSearch.BorderColor =
                System.Drawing.Color.FromArgb(224, 224, 224);

            this.txtSearch.BorderRadius = 8;

            this.txtSearch.BorderThickness = 2;

            this.txtSearch.Cursor =
                System.Windows.Forms.Cursors.IBeam;

            this.txtSearch.DefaultText = "";

            this.txtSearch.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            this.txtSearch.Location =
                new System.Drawing.Point(440, 0);

            this.txtSearch.Name = "txtSearch";

            this.txtSearch.PlaceholderText =
                "🔍  Tìm mã lớp học phần, môn học hoặc phòng học...";

            this.txtSearch.SelectedText = "";

            this.txtSearch.Size =
                new System.Drawing.Size(420, 36);

            // lblEmpty
            this.lblEmpty.AutoSize = true;

            this.lblEmpty.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Italic);

            this.lblEmpty.ForeColor =
                System.Drawing.Color.Gray;

            this.lblEmpty.Location =
                new System.Drawing.Point(24, 72);

            this.lblEmpty.Name = "lblEmpty";

            this.lblEmpty.Size =
                new System.Drawing.Size(260, 25);

            this.lblEmpty.Text =
                "Không tìm thấy lớp học phần phù hợp";

            this.lblEmpty.Visible = false;

            // dgvLopHocPhan
            this.dgvLopHocPhan.AllowUserToAddRows = false;

            this.dgvLopHocPhan.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvLopHocPhan.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvLopHocPhan.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvLopHocPhan.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvLopHocPhan.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle1.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            dataGridViewCellStyle1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold);

            dataGridViewCellStyle1.ForeColor =
                System.Drawing.Color.FromArgb(57, 73, 171);

            dataGridViewCellStyle1.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 234, 246);

            dataGridViewCellStyle1.SelectionForeColor =
                System.Drawing.Color.FromArgb(57, 73, 171);

            dataGridViewCellStyle1.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvLopHocPhan.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvLopHocPhan.ColumnHeadersHeight = 42;

            this.dgvLopHocPhan.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colSTT,
                    this.colMaLHP,
                    this.colTenMonHoc,
                    this.colSoTinChi,
                    this.colThuHoc,
                    this.colPhongHoc,
                    this.colSiSo
                });

            this.dgvLopHocPhan.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvLopHocPhan.EnableHeadersVisualStyles = false;

            this.dgvLopHocPhan.GridColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.dgvLopHocPhan.Location =
                new System.Drawing.Point(20, 76);

            this.dgvLopHocPhan.MultiSelect = false;

            this.dgvLopHocPhan.Name =
                "dgvLopHocPhan";

            this.dgvLopHocPhan.ReadOnly = true;

            this.dgvLopHocPhan.RowHeadersVisible = false;

            this.dgvLopHocPhan.RowTemplate.Height = 36;

            this.dgvLopHocPhan.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // colSTT
            this.colSTT.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colSTT.HeaderText = "STT";

            this.colSTT.Width = 60;

            // colMaLHP
            this.colMaLHP.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colMaLHP.HeaderText = "Mã LHP";

            this.colMaLHP.Width = 120;

            // colTenMonHoc
            this.colTenMonHoc.HeaderText =
                "Tên môn học";

            // colSoTinChi
            this.colSoTinChi.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colSoTinChi.HeaderText = "Số TC";

            this.colSoTinChi.Width = 90;

            // colThuHoc
            this.colThuHoc.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colThuHoc.HeaderText = "Thứ học";

            this.colThuHoc.Width = 90;

            // colPhongHoc
            this.colPhongHoc.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colPhongHoc.HeaderText = "Phòng";

            this.colPhongHoc.Width = 110;

            // colSiSo
            this.colSiSo.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;

            this.colSiSo.HeaderText = "Sĩ số";

            this.colSiSo.Width = 90;

            // FrmDanhSachLopHP
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(1100, 700);

            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);

            this.Name =
                "FrmDanhSachLopHP";

            this.Text =
                "Danh sách lớp học phần";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;
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
    }
}