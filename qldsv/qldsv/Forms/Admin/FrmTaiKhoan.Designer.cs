namespace qldsv.Forms.Admin
{
    partial class FrmTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDS = new System.Windows.Forms.Panel();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlThongtin = new System.Windows.Forms.Panel();
            this.btnDoimatkhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoKhoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoa = new Guna.UI2.WinForms.Guna2Button();
            this.pnlcard = new System.Windows.Forms.Panel();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblTendangnhap = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlThongtin.SuspendLayout();
            this.pnlcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "👤 Quản lý tài khoản";
            // 
            // pnlDS
            // 
            this.pnlDS.BackColor = System.Drawing.Color.White;
            this.pnlDS.Controls.Add(this.dgvTaikhoan);
            this.pnlDS.Controls.Add(this.pnlFilter);
            this.pnlDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDS.Location = new System.Drawing.Point(0, 50);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(982, 599);
            this.pnlDS.TabIndex = 1;
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.AllowUserToAddRows = false;
            this.dgvTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaikhoan.Location = new System.Drawing.Point(0, 90);
            this.dgvTaikhoan.MultiSelect = false;
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.ReadOnly = true;
            this.dgvTaikhoan.RowHeadersVisible = false;
            this.dgvTaikhoan.RowHeadersWidth = 62;
            this.dgvTaikhoan.RowTemplate.Height = 28;
            this.dgvTaikhoan.Size = new System.Drawing.Size(982, 509);
            this.dgvTaikhoan.TabIndex = 6;
            //this.dgvTaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaikhoan_CellContentClick);
            this.dgvTaikhoan.SelectionChanged += new System.EventHandler(this.dgvTaikhoan_SelectionChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.cboVaiTro);
            this.pnlFilter.Controls.Add(this.cboTrangthai);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(982, 90);
            this.pnlFilter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vai trò :";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(24, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(250, 32);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(85, 10);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(140, 28);
            this.cboVaiTro.TabIndex = 1;
            this.cboVaiTro.SelectedIndexChanged += new System.EventHandler(this.cboVaiTro_SelectedIndexChanged);
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(492, 12);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(140, 28);
            this.cboTrangthai.TabIndex = 3;
            this.cboTrangthai.SelectedIndexChanged += new System.EventHandler(this.cboTrangthai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái :";
            // 
            // pnlThongtin
            // 
            this.pnlThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongtin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongtin.Controls.Add(this.btnDoimatkhau);
            this.pnlThongtin.Controls.Add(this.btnMoKhoa);
            this.pnlThongtin.Controls.Add(this.btnKhoa);
            this.pnlThongtin.Controls.Add(this.pnlcard);
            this.pnlThongtin.Location = new System.Drawing.Point(769, 50);
            this.pnlThongtin.Name = "pnlThongtin";
            this.pnlThongtin.Size = new System.Drawing.Size(213, 599);
            this.pnlThongtin.TabIndex = 2;
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.BorderRadius = 8;
            this.btnDoimatkhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoimatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btnDoimatkhau.Location = new System.Drawing.Point(34, 420);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(145, 32);
            this.btnDoimatkhau.TabIndex = 3;
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.Click += new System.EventHandler(this.btnDoimatkhau_Click);
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.BorderRadius = 8;
            this.btnMoKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoKhoa.FillColor = System.Drawing.Color.SeaGreen;
            this.btnMoKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoKhoa.ForeColor = System.Drawing.Color.White;
            this.btnMoKhoa.Location = new System.Drawing.Point(34, 345);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(145, 32);
            this.btnMoKhoa.TabIndex = 2;
            this.btnMoKhoa.Text = "Mở Khóa";
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.White;
            this.btnKhoa.BorderRadius = 8;
            this.btnKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoa.FillColor = System.Drawing.Color.Goldenrod;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.Location = new System.Drawing.Point(34, 268);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(145, 32);
            this.btnKhoa.TabIndex = 1;
            this.btnKhoa.Text = "Khóa";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // pnlcard
            // 
            this.pnlcard.Controls.Add(this.lblVaitro);
            this.pnlcard.Controls.Add(this.lblTendangnhap);
            this.pnlcard.Controls.Add(this.picAvatar);
            this.pnlcard.Location = new System.Drawing.Point(3, 0);
            this.pnlcard.Name = "pnlcard";
            this.pnlcard.Size = new System.Drawing.Size(210, 242);
            this.pnlcard.TabIndex = 0;
            // 
            // lblVaitro
            // 
            this.lblVaitro.AutoSize = true;
            this.lblVaitro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaitro.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblVaitro.Location = new System.Drawing.Point(69, 131);
            this.lblVaitro.Name = "lblVaitro";
            this.lblVaitro.Size = new System.Drawing.Size(69, 28);
            this.lblVaitro.TabIndex = 2;
            this.lblVaitro.Text = "Vai trò";
            // 
            // lblTendangnhap
            // 
            this.lblTendangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendangnhap.Location = new System.Drawing.Point(25, 88);
            this.lblTendangnhap.Name = "lblTendangnhap";
            this.lblTendangnhap.Size = new System.Drawing.Size(169, 32);
            this.lblTendangnhap.TabIndex = 1;
            this.lblTendangnhap.Text = "Tendangnhap";
            this.lblTendangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::qldsv.Properties.Resources.avatar;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(73, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            this.picAvatar.UseTransparentBackground = true;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 649);
            this.Controls.Add(this.pnlThongtin);
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlThongtin.ResumeLayout(false);
            this.pnlcard.ResumeLayout(false);
            this.pnlcard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDS;
        private System.Windows.Forms.Panel pnlThongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private System.Windows.Forms.Panel pnlcard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Label lblVaitro;
        private System.Windows.Forms.Label lblTendangnhap;
        private Guna.UI2.WinForms.Guna2Button btnKhoa;
        private Guna.UI2.WinForms.Guna2Button btnDoimatkhau;
        private Guna.UI2.WinForms.Guna2Button btnMoKhoa;
    }
}