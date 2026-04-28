namespace qldsv.Forms.Giangvien
{
    partial class FrmMainGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainGiangVien));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.blbTenGV = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnLophocphan = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContentGV = new System.Windows.Forms.Panel();
            this.btnNhapdiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnCanhbaohocvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoimatkhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.pnlMenu.Controls.Add(this.btnDangxuat);
            this.pnlMenu.Controls.Add(this.btnDoimatkhau);
            this.pnlMenu.Controls.Add(this.btnCanhbaohocvu);
            this.pnlMenu.Controls.Add(this.btnNhapdiem);
            this.pnlMenu.Controls.Add(this.btnLophocphan);
            this.pnlMenu.Controls.Add(this.picAvatar);
            this.pnlMenu.Controls.Add(this.lblOnline);
            this.pnlMenu.Controls.Add(this.lblVaitro);
            this.pnlMenu.Controls.Add(this.blbTenGV);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 653);
            this.pnlMenu.TabIndex = 0;
            // 
            // blbTenGV
            // 
            this.blbTenGV.AutoSize = true;
            this.blbTenGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbTenGV.ForeColor = System.Drawing.Color.White;
            this.blbTenGV.Location = new System.Drawing.Point(83, 42);
            this.blbTenGV.Name = "blbTenGV";
            this.blbTenGV.Size = new System.Drawing.Size(123, 23);
            this.blbTenGV.TabIndex = 1;
            this.blbTenGV.Text = "Nguyễn Văn A";
            this.blbTenGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVaitro
            // 
            this.lblVaitro.AutoSize = true;
            this.lblVaitro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblVaitro.Location = new System.Drawing.Point(83, 68);
            this.lblVaitro.Name = "lblVaitro";
            this.lblVaitro.Size = new System.Drawing.Size(79, 20);
            this.lblVaitro.TabIndex = 2;
            this.lblVaitro.Text = "Giảng viên";
            this.lblVaitro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblOnline.Location = new System.Drawing.Point(85, 90);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(57, 17);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "● Online";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(12, 43);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 14;
            this.picAvatar.TabStop = false;
            // 
            // btnLophocphan
            // 
            this.btnLophocphan.BorderRadius = 8;
            this.btnLophocphan.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnLophocphan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLophocphan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLophocphan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLophocphan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLophocphan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnLophocphan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLophocphan.ForeColor = System.Drawing.Color.White;
            this.btnLophocphan.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLophocphan.Location = new System.Drawing.Point(0, 155);
            this.btnLophocphan.Name = "btnLophocphan";
            this.btnLophocphan.Size = new System.Drawing.Size(220, 45);
            this.btnLophocphan.TabIndex = 15;
            this.btnLophocphan.Text = "📚 Lớp học phần";
            this.btnLophocphan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlContentGV
            // 
            this.pnlContentGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContentGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentGV.Location = new System.Drawing.Point(220, 0);
            this.pnlContentGV.Name = "pnlContentGV";
            this.pnlContentGV.Size = new System.Drawing.Size(962, 653);
            this.pnlContentGV.TabIndex = 1;
            // 
            // btnNhapdiem
            // 
            this.btnNhapdiem.BorderRadius = 8;
            this.btnNhapdiem.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnNhapdiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapdiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapdiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapdiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapdiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnNhapdiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapdiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapdiem.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnNhapdiem.Location = new System.Drawing.Point(0, 205);
            this.btnNhapdiem.Name = "btnNhapdiem";
            this.btnNhapdiem.Size = new System.Drawing.Size(220, 45);
            this.btnNhapdiem.TabIndex = 16;
            this.btnNhapdiem.Text = "📝 Nhập điểm";
            this.btnNhapdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCanhbaohocvu
            // 
            this.btnCanhbaohocvu.BorderRadius = 8;
            this.btnCanhbaohocvu.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnCanhbaohocvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanhbaohocvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanhbaohocvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanhbaohocvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanhbaohocvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnCanhbaohocvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanhbaohocvu.ForeColor = System.Drawing.Color.White;
            this.btnCanhbaohocvu.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCanhbaohocvu.Location = new System.Drawing.Point(0, 255);
            this.btnCanhbaohocvu.Name = "btnCanhbaohocvu";
            this.btnCanhbaohocvu.Size = new System.Drawing.Size(220, 45);
            this.btnCanhbaohocvu.TabIndex = 17;
            this.btnCanhbaohocvu.Text = "⚠️ Cảnh báo học vụ ";
            this.btnCanhbaohocvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.BorderRadius = 8;
            this.btnDoimatkhau.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnDoimatkhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoimatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoimatkhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnDoimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btnDoimatkhau.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDoimatkhau.Location = new System.Drawing.Point(0, 305);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(220, 45);
            this.btnDoimatkhau.TabIndex = 18;
            this.btnDoimatkhau.Text = "🔑 Đổi mật khẩu";
            this.btnDoimatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BorderRadius = 8;
            this.btnDangxuat.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.btnDangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangxuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDangxuat.Location = new System.Drawing.Point(3, 355);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(220, 45);
            this.btnDangxuat.TabIndex = 19;
            this.btnDangxuat.Text = "🚪 Đăng xuất";
            this.btnDangxuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmMainGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlContentGV);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmMainGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý điểm - Giảng viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label blbTenGV;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblVaitro;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnLophocphan;
        private System.Windows.Forms.Panel pnlContentGV;
        private Guna.UI2.WinForms.Guna2Button btnNhapdiem;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnDoimatkhau;
        private Guna.UI2.WinForms.Guna2Button btnCanhbaohocvu;
    }
}