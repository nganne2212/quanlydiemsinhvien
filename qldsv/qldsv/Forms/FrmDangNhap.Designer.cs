namespace qldsv.Forms
{
    partial class FrmDangNhap
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paneline);
            this.panel1.Controls.Add(this.picmainDN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 702);
            this.panel1.TabIndex = 0;
            // 
            // paneline
            // 
            this.paneline.BackColor = System.Drawing.Color.DodgerBlue;
            this.paneline.Location = new System.Drawing.Point(418, 115);
            this.paneline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneline.Name = "paneline";
            this.paneline.Size = new System.Drawing.Size(120, 6);
            this.paneline.TabIndex = 2;
            // 
            // picmainDN
            // 
            this.picmainDN.Location = new System.Drawing.Point(16, 166);
            this.picmainDN.Name = "picmainDN";
            this.picmainDN.Size = new System.Drawing.Size(850, 500);
            this.picmainDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmainDN.TabIndex = 1;
            this.picmainDN.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // panellogin
            // 
            this.panellogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panellogin.BackColor = System.Drawing.Color.AliceBlue;
            this.panellogin.Controls.Add(this.btnDangNhap);
            this.panellogin.Controls.Add(this.txtmatkhau);
            this.panellogin.Controls.Add(this.txtdangnhap);
            this.panellogin.Controls.Add(this.picowl);
            this.panellogin.Location = new System.Drawing.Point(885, 17);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(375, 663);
            this.panellogin.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 12;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(54, 403);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(270, 69);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.White;
            this.txtmatkhau.BorderRadius = 12;
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.DefaultText = "";
            this.txtmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtmatkhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtmatkhau.IconRight = global::qldsv.Properties.Resources.matdong;
            this.txtmatkhau.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtmatkhau.Location = new System.Drawing.Point(22, 297);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '.';
            this.txtmatkhau.PlaceholderText = "Mật khẩu";
            this.txtmatkhau.SelectedText = "";
            this.txtmatkhau.Size = new System.Drawing.Size(330, 69);
            this.txtmatkhau.TabIndex = 2;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.IconRightClick += new System.EventHandler(this.txtmatkhau_IconRightClick);
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.BackColor = System.Drawing.Color.White;
            this.txtdangnhap.BorderRadius = 12;
            this.txtdangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdangnhap.DefaultText = "";
            this.txtdangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdangnhap.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtdangnhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdangnhap.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtdangnhap.Location = new System.Drawing.Point(24, 189);
            this.txtdangnhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.PlaceholderText = "Tên đăng nhập";
            this.txtdangnhap.SelectedText = "";
            this.txtdangnhap.Size = new System.Drawing.Size(330, 69);
            this.txtdangnhap.TabIndex = 1;
            // 
            // picowl
            // 
            this.picowl.Location = new System.Drawing.Point(142, 34);
            this.picowl.Name = "picowl";
            this.picowl.Size = new System.Drawing.Size(100, 100);
            this.picowl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picowl.TabIndex = 0;
            this.picowl.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2Button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentScore - Hệ thống quản lý điểm sinh viên";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmainDN)).EndInit();
            this.panellogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picowl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}