namespace qldsv.Forms.Admin
{
    partial class FrmMonHoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuoiki = new System.Windows.Forms.TextBox();
            this.txtKT2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgridMonhoc = new System.Windows.Forms.DataGridView();
            this.txtKT1 = new System.Windows.Forms.TextBox();
            this.txtChuyencan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSotinchi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.pnlDS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridMonhoc)).BeginInit();
            this.pnlDS.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn:";
            // 
            // dgvTaikhoan
            // 
            this.dgvTaikhoan.AllowUserToAddRows = false;
            this.dgvTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaikhoan.Location = new System.Drawing.Point(0, 753);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersVisible = false;
            this.dgvTaikhoan.RowHeadersWidth = 62;
            this.dgvTaikhoan.RowTemplate.Height = 28;
            this.dgvTaikhoan.Size = new System.Drawing.Size(1374, 0);
            this.dgvTaikhoan.TabIndex = 6;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnThem);
            this.pnlFilter.Controls.Add(this.btnSua);
            this.pnlFilter.Controls.Add(this.btnLuu);
            this.pnlFilter.Controls.Add(this.btnXoa);
            this.pnlFilter.Controls.Add(this.btnBoqua);
            this.pnlFilter.Controls.Add(this.label8);
            this.pnlFilter.Controls.Add(this.txtCuoiki);
            this.pnlFilter.Controls.Add(this.txtKT2);
            this.pnlFilter.Controls.Add(this.label9);
            this.pnlFilter.Controls.Add(this.label7);
            this.pnlFilter.Controls.Add(this.DgridMonhoc);
            this.pnlFilter.Controls.Add(this.txtKT1);
            this.pnlFilter.Controls.Add(this.txtChuyencan);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.label5);
            this.pnlFilter.Controls.Add(this.txtTenmon);
            this.pnlFilter.Controls.Add(this.label4);
            this.pnlFilter.Controls.Add(this.txtSotinchi);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.txtMamon);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1374, 753);
            this.pnlFilter.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(271, 629);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 55);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Gold;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(451, 629);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 55);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(621, 629);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 55);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "💾  Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(790, 629);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 55);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoqua.Location = new System.Drawing.Point(956, 629);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(114, 55);
            this.btnBoqua.TabIndex = 12;
            this.btnBoqua.Text = "✖️ Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(866, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cuối kì:";
            // 
            // txtCuoiki
            // 
            this.txtCuoiki.Location = new System.Drawing.Point(926, 125);
            this.txtCuoiki.Name = "txtCuoiki";
            this.txtCuoiki.Size = new System.Drawing.Size(62, 26);
            this.txtCuoiki.TabIndex = 17;
            // 
            // txtKT2
            // 
            this.txtKT2.Location = new System.Drawing.Point(790, 125);
            this.txtKT2.Name = "txtKT2";
            this.txtKT2.Size = new System.Drawing.Size(62, 26);
            this.txtKT2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(708, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kiểm tra 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kiểm tra 1:";
            // 
            // DgridMonhoc
            // 
            this.DgridMonhoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgridMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridMonhoc.Location = new System.Drawing.Point(111, 197);
            this.DgridMonhoc.Name = "DgridMonhoc";
            this.DgridMonhoc.RowHeadersWidth = 62;
            this.DgridMonhoc.RowTemplate.Height = 28;
            this.DgridMonhoc.Size = new System.Drawing.Size(1110, 407);
            this.DgridMonhoc.TabIndex = 7;
            // 
            // txtKT1
            // 
            this.txtKT1.Location = new System.Drawing.Point(636, 122);
            this.txtKT1.Name = "txtKT1";
            this.txtKT1.Size = new System.Drawing.Size(62, 26);
            this.txtKT1.TabIndex = 13;
            // 
            // txtChuyencan
            // 
            this.txtChuyencan.Location = new System.Drawing.Point(484, 122);
            this.txtChuyencan.Name = "txtChuyencan";
            this.txtChuyencan.Size = new System.Drawing.Size(62, 26);
            this.txtChuyencan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chuyên cần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hệ số:";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(384, 76);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(601, 26);
            this.txtTenmon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên môn:";
            // 
            // txtSotinchi
            // 
            this.txtSotinchi.Location = new System.Drawing.Point(805, 24);
            this.txtSotinchi.Name = "txtSotinchi";
            this.txtSotinchi.Size = new System.Drawing.Size(180, 26);
            this.txtSotinchi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số tín chỉ:";
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(384, 24);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(241, 26);
            this.txtMamon.TabIndex = 5;
            // 
            // pnlDS
            // 
            this.pnlDS.BackColor = System.Drawing.Color.White;
            this.pnlDS.Controls.Add(this.dgvTaikhoan);
            this.pnlDS.Controls.Add(this.pnlFilter);
            this.pnlDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDS.Location = new System.Drawing.Point(0, 50);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(1374, 753);
            this.pnlDS.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "📚 Quản lý môn học";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1374, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 803);
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmMonHoc";
            this.Text = "FrmMonHoc";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridMonhoc)).EndInit();
            this.pnlDS.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTaikhoan;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSotinchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKT1;
        private System.Windows.Forms.TextBox txtChuyencan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuoiki;
        private System.Windows.Forms.TextBox txtKT2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DgridMonhoc;
    }
}