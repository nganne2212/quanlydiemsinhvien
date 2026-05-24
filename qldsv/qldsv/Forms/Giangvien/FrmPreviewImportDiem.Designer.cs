using System.Windows.Forms;

namespace qldsv.Forms.Giangvien
{
    partial class FrmPreviewImportDiem
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
        private void InitializeComponent()
        {
            this.lblThongKe = new System.Windows.Forms.Label();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKe
            // 
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblThongKe.Location = new System.Drawing.Point(12, 12);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(860, 28);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Đang tải...";
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreview.ColumnHeadersHeight = 36;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSSV,
            this.colHoTen,
            this.colCC,
            this.colKT1,
            this.colKT2,
            this.colCK,
            this.colTrangThai,
            this.colLyDo});
            this.dgvPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPreview.Location = new System.Drawing.Point(12, 48);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersVisible = false;
            this.dgvPreview.RowHeadersWidth = 62;
            this.dgvPreview.Size = new System.Drawing.Size(860, 460);
            this.dgvPreview.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 45;
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 8;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            // 
            // colCC
            // 
            this.colCC.DataPropertyName = "CC";
            this.colCC.HeaderText = "CC";
            this.colCC.MinimumWidth = 8;
            this.colCC.Name = "colCC";
            // 
            // colKT1
            // 
            this.colKT1.DataPropertyName = "KT1";
            this.colKT1.HeaderText = "KT1";
            this.colKT1.MinimumWidth = 8;
            this.colKT1.Name = "colKT1";
            // 
            // colKT2
            // 
            this.colKT2.DataPropertyName = "KT2";
            this.colKT2.HeaderText = "KT2";
            this.colKT2.MinimumWidth = 8;
            this.colKT2.Name = "colKT2";
            // 
            // colCK
            // 
            this.colCK.DataPropertyName = "CK";
            this.colCK.HeaderText = "CK";
            this.colCK.MinimumWidth = 8;
            this.colCK.Name = "colCK";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colLyDo
            // 
            this.colLyDo.DataPropertyName = "LyDo";
            this.colLyDo.HeaderText = "Lý do lỗi";
            this.colLyDo.MinimumWidth = 8;
            this.colLyDo.Name = "colLyDo";
            // 
            // btnDong
            // 
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = System.Drawing.Color.SlateGray;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(12, 520);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 38);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPreviewImportDiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 572);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreviewImportDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết quả kiểm tra file import điểm";
            this.Load += new System.EventHandler(this.FrmPreviewImportDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion 
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private Guna.UI2.WinForms.Guna2Button btnDong;
    }
}

  