namespace qldsv.Forms.Sinhvien
{
    partial class FrmPhucKhaoSV
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDiemHienTai = new System.Windows.Forms.Label();
            this.txtDiemHienTai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhucKhao = new System.Windows.Forms.DataGridView();
            this.colMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 Phúc khảo";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.cboHocKy);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1400, 74);
            this.pnlTop.TabIndex = 1;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHocKy.Location = new System.Drawing.Point(30, 25);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(81, 30);
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
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(130, 20);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(260, 36);
            this.cboHocKy.TabIndex = 1;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblMonHoc);
            this.pnlMain.Controls.Add(this.cboMonHoc);
            this.pnlMain.Controls.Add(this.lblDiemHienTai);
            this.pnlMain.Controls.Add(this.txtDiemHienTai);
            this.pnlMain.Controls.Add(this.lblLyDo);
            this.pnlMain.Controls.Add(this.txtLyDo);
            this.pnlMain.Controls.Add(this.btnGui);
            this.pnlMain.Controls.Add(this.btnLamMoi);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 124);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 270);
            this.pnlMain.TabIndex = 2;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMonHoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMonHoc.Location = new System.Drawing.Point(35, 16);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(101, 30);
            this.lblMonHoc.TabIndex = 0;
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
            this.cboMonHoc.Location = new System.Drawing.Point(180, 10);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(420, 36);
            this.cboMonHoc.TabIndex = 1;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // lblDiemHienTai
            // 
            this.lblDiemHienTai.AutoSize = true;
            this.lblDiemHienTai.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDiemHienTai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiemHienTai.Location = new System.Drawing.Point(35, 74);
            this.lblDiemHienTai.Name = "lblDiemHienTai";
            this.lblDiemHienTai.Size = new System.Drawing.Size(144, 30);
            this.lblDiemHienTai.TabIndex = 4;
            this.lblDiemHienTai.Text = "Điểm hiện tại";
            // 
            // txtDiemHienTai
            // 
            this.txtDiemHienTai.BorderRadius = 8;
            this.txtDiemHienTai.DefaultText = "";
            this.txtDiemHienTai.Enabled = false;
            this.txtDiemHienTai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiemHienTai.Location = new System.Drawing.Point(186, 64);
            this.txtDiemHienTai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiemHienTai.Name = "txtDiemHienTai";
            this.txtDiemHienTai.PlaceholderText = "";
            this.txtDiemHienTai.SelectedText = "";
            this.txtDiemHienTai.Size = new System.Drawing.Size(150, 40);
            this.txtDiemHienTai.TabIndex = 5;
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLyDo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLyDo.Location = new System.Drawing.Point(35, 131);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(176, 30);
            this.lblLyDo.TabIndex = 6;
            this.lblLyDo.Text = "Lý do phúc khảo";
            // 
            // txtLyDo
            // 
            this.txtLyDo.BorderRadius = 8;
            this.txtLyDo.DefaultText = "";
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLyDo.Location = new System.Drawing.Point(40, 167);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.PlaceholderText = "Nhập lý do muốn phúc khảo...";
            this.txtLyDo.SelectedText = "";
            this.txtLyDo.Size = new System.Drawing.Size(560, 75);
            this.txtLyDo.TabIndex = 7;
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 8;
            this.btnGui.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(636, 195);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(180, 45);
            this.btnGui.TabIndex = 8;
            this.btnGui.Text = "📤 Gửi đơn";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.FillColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(836, 195);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(170, 45);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "↻ Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvPhucKhao
            // 
            this.dgvPhucKhao.AllowUserToAddRows = false;
            this.dgvPhucKhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhucKhao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhucKhao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvPhucKhao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhucKhao.ColumnHeadersHeight = 40;
            this.dgvPhucKhao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonHoc,
            this.colDiemCu,
            this.colNgayGui,
            this.colTrangThai});
            this.dgvPhucKhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhucKhao.EnableHeadersVisualStyles = false;
            this.dgvPhucKhao.Location = new System.Drawing.Point(0, 394);
            this.dgvPhucKhao.Name = "dgvPhucKhao";
            this.dgvPhucKhao.RowHeadersVisible = false;
            this.dgvPhucKhao.RowHeadersWidth = 62;
            this.dgvPhucKhao.RowTemplate.Height = 35;
            this.dgvPhucKhao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhucKhao.Size = new System.Drawing.Size(1400, 406);
            this.dgvPhucKhao.TabIndex = 3;
            this.dgvPhucKhao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhucKhao_CellFormatting);
            // 
            // colMonHoc
            // 
            this.colMonHoc.HeaderText = "Môn học";
            this.colMonHoc.MinimumWidth = 8;
            this.colMonHoc.Name = "colMonHoc";
            // 
            // colDiemCu
            // 
            this.colDiemCu.HeaderText = "Điểm hiện tại";
            this.colDiemCu.MinimumWidth = 8;
            this.colDiemCu.Name = "colDiemCu";
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
            // FrmPhucKhaoSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.dgvPhucKhao);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhucKhaoSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phúc khảo";
            this.Load += new System.EventHandler(this.FrmPhucKhaoSV_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhucKhao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.Label lblMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;

        private System.Windows.Forms.Label lblDiemHienTai;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemHienTai;

        private System.Windows.Forms.Label lblLyDo;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDo;

        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvPhucKhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}