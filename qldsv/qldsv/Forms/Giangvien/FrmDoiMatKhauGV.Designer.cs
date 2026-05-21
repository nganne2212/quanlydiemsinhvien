namespace qldsv.Forms.Giangvien
{
    partial class FrmDoiMatKhauGV
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.txtNhapLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkHienThi = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔑 Đổi mật khẩu";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblSection);
            this.pnlMain.Controls.Add(this.lblMatKhauCu);
            this.pnlMain.Controls.Add(this.txtMatKhauCu);
            this.pnlMain.Controls.Add(this.lblMatKhauMoi);
            this.pnlMain.Controls.Add(this.txtMatKhauMoi);
            this.pnlMain.Controls.Add(this.lblNhapLai);
            this.pnlMain.Controls.Add(this.txtNhapLai);
            this.pnlMain.Controls.Add(this.chkHienThi);
            this.pnlMain.Controls.Add(this.pnlButton);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(40);
            this.pnlMain.Size = new System.Drawing.Size(1400, 745);
            this.pnlMain.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSection.Location = new System.Drawing.Point(45, 35);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(306, 36);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "THÔNG TIN MẬT KHẨU";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMatKhauCu.Location = new System.Drawing.Point(50, 110);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(131, 30);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderRadius = 8;
            this.txtMatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauCu.DefaultText = "";
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhauCu.Location = new System.Drawing.Point(55, 150);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '●';
            this.txtMatKhauCu.PlaceholderText = "Nhập mật khẩu hiện tại";
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.Size = new System.Drawing.Size(520, 45);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(50, 235);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(146, 30);
            this.lblMatKhauMoi.TabIndex = 2;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderRadius = 8;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(55, 275);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PlaceholderText = "Nhập mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(520, 45);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNhapLai.Location = new System.Drawing.Point(50, 360);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(187, 30);
            this.lblNhapLai.TabIndex = 3;
            this.lblNhapLai.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BorderRadius = 8;
            this.txtNhapLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLai.DefaultText = "";
            this.txtNhapLai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNhapLai.Location = new System.Drawing.Point(55, 400);
            this.txtNhapLai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '●';
            this.txtNhapLai.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNhapLai.SelectedText = "";
            this.txtNhapLai.Size = new System.Drawing.Size(520, 45);
            this.txtNhapLai.TabIndex = 3;
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.CheckedState.BorderRadius = 0;
            this.chkHienThi.CheckedState.BorderThickness = 0;
            this.chkHienThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHienThi.Location = new System.Drawing.Point(55, 470);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(164, 32);
            this.chkHienThi.TabIndex = 4;
            this.chkHienThi.Text = "Hiện mật khẩu";
            this.chkHienThi.UncheckedState.BorderRadius = 0;
            this.chkHienThi.UncheckedState.BorderThickness = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnDoiMatKhau);
            this.pnlButton.Controls.Add(this.btnHuy);
            this.pnlButton.Location = new System.Drawing.Point(55, 540);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(520, 60);
            this.pnlButton.TabIndex = 5;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderRadius = 8;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(210, 8);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(310, 42);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "🔄 Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(0, 8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 42);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "✖ Hủy";
            // 
            // FrmDoiMatKhauGV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiMatKhauGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu giảng viên";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Label lblMatKhauCu;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauCu;

        private System.Windows.Forms.Label lblMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;

        private System.Windows.Forms.Label lblNhapLai;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLai;

        private Guna.UI2.WinForms.Guna2CheckBox chkHienThi;

        private System.Windows.Forms.Panel pnlButton;

        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}