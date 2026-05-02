namespace qldsv.Forms.Sinhvien
{
    partial class FrmMainSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainSinhVien));
            this.pnlside = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLichhoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhuckhao = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoimatkhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnKQHT = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSV = new System.Windows.Forms.Label();
            this.lblSvien = new System.Windows.Forms.Label();
            this.picAva = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlndung = new System.Windows.Forms.Panel();
            this.pnlside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlside
            // 
            this.pnlside.BackColor = System.Drawing.Color.Indigo;
            this.pnlside.Controls.Add(this.btnLichhoc);
            this.pnlside.Controls.Add(this.btnPhuckhao);
            this.pnlside.Controls.Add(this.btnDangxuat);
            this.pnlside.Controls.Add(this.btnDoimatkhau);
            this.pnlside.Controls.Add(this.btnKQHT);
            this.pnlside.Controls.Add(this.lblStatus);
            this.pnlside.Controls.Add(this.lblSV);
            this.pnlside.Controls.Add(this.lblSvien);
            this.pnlside.Controls.Add(this.picAva);
            this.pnlside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlside.Location = new System.Drawing.Point(0, 0);
            this.pnlside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlside.Name = "pnlside";
            this.pnlside.Size = new System.Drawing.Size(230, 705);
            this.pnlside.TabIndex = 0;
            // 
            // btnLichhoc
            // 
            this.btnLichhoc.Animated = true;
            this.btnLichhoc.BackColor = System.Drawing.Color.Indigo;
            this.btnLichhoc.BorderRadius = 8;
            this.btnLichhoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLichhoc.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnLichhoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichhoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichhoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichhoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichhoc.FillColor = System.Drawing.Color.Transparent;
            this.btnLichhoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLichhoc.ForeColor = System.Drawing.Color.White;
            this.btnLichhoc.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnLichhoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichhoc.ImageSize = new System.Drawing.Size(18, 18);
            this.btnLichhoc.Location = new System.Drawing.Point(0, 220);
            this.btnLichhoc.Name = "btnLichhoc";
            this.btnLichhoc.Size = new System.Drawing.Size(230, 42);
            this.btnLichhoc.TabIndex = 8;
            this.btnLichhoc.Text = "📖 Lịch học";
            this.btnLichhoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPhuckhao
            // 
            this.btnPhuckhao.Animated = true;
            this.btnPhuckhao.BorderRadius = 8;
            this.btnPhuckhao.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhuckhao.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnPhuckhao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuckhao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhuckhao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhuckhao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhuckhao.FillColor = System.Drawing.Color.Transparent;
            this.btnPhuckhao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhuckhao.ForeColor = System.Drawing.Color.White;
            this.btnPhuckhao.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnPhuckhao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhuckhao.ImageSize = new System.Drawing.Size(18, 18);
            this.btnPhuckhao.Location = new System.Drawing.Point(0, 290);
            this.btnPhuckhao.Name = "btnPhuckhao";
            this.btnPhuckhao.Size = new System.Drawing.Size(230, 42);
            this.btnPhuckhao.TabIndex = 7;
            this.btnPhuckhao.Text = "📋 Phúc khảo";
            this.btnPhuckhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Animated = true;
            this.btnDangxuat.BorderRadius = 8;
            this.btnDangxuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangxuat.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnDangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangxuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnDangxuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangxuat.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDangxuat.Location = new System.Drawing.Point(0, 430);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(230, 42);
            this.btnDangxuat.TabIndex = 6;
            this.btnDangxuat.Text = "🚪 Đăng xuất";
            this.btnDangxuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Animated = true;
            this.btnDoimatkhau.BorderRadius = 8;
            this.btnDoimatkhau.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDoimatkhau.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnDoimatkhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoimatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoimatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoimatkhau.FillColor = System.Drawing.Color.Transparent;
            this.btnDoimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btnDoimatkhau.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnDoimatkhau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoimatkhau.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDoimatkhau.Location = new System.Drawing.Point(0, 360);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(230, 42);
            this.btnDoimatkhau.TabIndex = 5;
            this.btnDoimatkhau.Text = "🔑 Đổi mật khẩu";
            this.btnDoimatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKQHT
            // 
            this.btnKQHT.Animated = true;
            this.btnKQHT.BorderRadius = 8;
            this.btnKQHT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKQHT.CheckedState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnKQHT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKQHT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKQHT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKQHT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKQHT.FillColor = System.Drawing.Color.Transparent;
            this.btnKQHT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKQHT.ForeColor = System.Drawing.Color.White;
            this.btnKQHT.HoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnKQHT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKQHT.ImageSize = new System.Drawing.Size(18, 18);
            this.btnKQHT.Location = new System.Drawing.Point(0, 150);
            this.btnKQHT.Name = "btnKQHT";
            this.btnKQHT.Size = new System.Drawing.Size(230, 42);
            this.btnKQHT.TabIndex = 4;
            this.btnKQHT.Text = "📊 Kết quả học tập";
            this.btnKQHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Location = new System.Drawing.Point(75, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "● Online";
            // 
            // lblSV
            // 
            this.lblSV.AutoSize = true;
            this.lblSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSV.Location = new System.Drawing.Point(75, 42);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(85, 25);
            this.lblSV.TabIndex = 2;
            this.lblSV.Text = "Sinh Viên";
            // 
            // lblSvien
            // 
            this.lblSvien.AutoSize = true;
            this.lblSvien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvien.ForeColor = System.Drawing.Color.White;
            this.lblSvien.Location = new System.Drawing.Point(75, 18);
            this.lblSvien.Name = "lblSvien";
            this.lblSvien.Size = new System.Drawing.Size(140, 28);
            this.lblSvien.TabIndex = 1;
            this.lblSvien.Text = "Ten Sinh Vien";
            // 
            // picAva
            // 
            this.picAva.BackColor = System.Drawing.Color.Transparent;
            this.picAva.Image = global::qldsv.Properties.Resources.avatar;
            this.picAva.ImageRotate = 0F;
            this.picAva.Location = new System.Drawing.Point(15, 15);
            this.picAva.Name = "picAva";
            this.picAva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAva.Size = new System.Drawing.Size(60, 60);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 0;
            this.picAva.TabStop = false;
            this.picAva.UseTransparentBackground = true;
            // 
            // pnlndung
            // 
            this.pnlndung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlndung.Location = new System.Drawing.Point(230, 0);
            this.pnlndung.Name = "pnlndung";
            this.pnlndung.Size = new System.Drawing.Size(1004, 705);
            this.pnlndung.TabIndex = 1;
            // 
            // FrmMainSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 705);
            this.Controls.Add(this.pnlndung);
            this.Controls.Add(this.pnlside);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainSInhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlside.ResumeLayout(false);
            this.pnlside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlside;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAva;
        private System.Windows.Forms.Label lblSvien;
        private System.Windows.Forms.Label lblSV;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnKQHT;
        private Guna.UI2.WinForms.Guna2Button btnLichhoc;
        private Guna.UI2.WinForms.Guna2Button btnPhuckhao;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnDoimatkhau;
        private System.Windows.Forms.Panel pnlndung;
    }
}