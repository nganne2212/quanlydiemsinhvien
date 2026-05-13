namespace qldsv.Forms.Admin
{
    partial class FrmPhongHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtTenphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPhonghoc = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBoqua = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "⊟  Quản lý phòng học";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(231, 122);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(101, 30);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Tên phòng:";
            // 
            // TxtTenphong
            // 
            this.TxtTenphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTenphong.BorderColor = System.Drawing.Color.MidnightBlue;
            this.TxtTenphong.BorderRadius = 12;
            this.TxtTenphong.BorderThickness = 2;
            this.TxtTenphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenphong.DefaultText = "";
            this.TxtTenphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTenphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTenphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTenphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTenphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTenphong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTenphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(137)))), ((int)(((byte)(100)))));
            this.TxtTenphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTenphong.Location = new System.Drawing.Point(377, 122);
            this.TxtTenphong.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTenphong.Name = "TxtTenphong";
            this.TxtTenphong.PlaceholderText = "VD: D6.206";
            this.TxtTenphong.SelectedText = "";
            this.TxtTenphong.Size = new System.Drawing.Size(197, 51);
            this.TxtTenphong.TabIndex = 3;
            // 
            // dgvPhonghoc
            // 
            this.dgvPhonghoc.AllowUserToAddRows = false;
            this.dgvPhonghoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhonghoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhonghoc.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPhonghoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhonghoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhonghoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhonghoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhonghoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaphong,
            this.colTenphong});
            this.dgvPhonghoc.EnableHeadersVisualStyles = false;
            this.dgvPhonghoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.dgvPhonghoc.Location = new System.Drawing.Point(0, 222);
            this.dgvPhonghoc.Name = "dgvPhonghoc";
            this.dgvPhonghoc.ReadOnly = true;
            this.dgvPhonghoc.RowHeadersVisible = false;
            this.dgvPhonghoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPhonghoc.RowTemplate.Height = 30;
            this.dgvPhonghoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhonghoc.Size = new System.Drawing.Size(1004, 300);
            this.dgvPhonghoc.TabIndex = 4;
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSTT.FillWeight = 261.5385F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 40;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 120;
            // 
            // colMaphong
            // 
            this.colMaphong.FillWeight = 19.23077F;
            this.colMaphong.HeaderText = "Mã phòng";
            this.colMaphong.MinimumWidth = 10;
            this.colMaphong.Name = "colMaphong";
            this.colMaphong.ReadOnly = true;
            // 
            // colTenphong
            // 
            this.colTenphong.FillWeight = 19.23077F;
            this.colTenphong.HeaderText = "Tên phòng";
            this.colTenphong.MinimumWidth = 10;
            this.colTenphong.Name = "colTenphong";
            this.colTenphong.ReadOnly = true;
            // 
            // BtnThem
            // 
            this.BtnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnThem.BorderRadius = 8;
            this.BtnThem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Location = new System.Drawing.Point(19, 582);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(121, 35);
            this.BtnThem.TabIndex = 10;
            this.BtnThem.Text = "+ Thêm";
            // 
            // BtnSua
            // 
            this.BtnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSua.BorderRadius = 8;
            this.BtnSua.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSua.FillColor = System.Drawing.Color.Goldenrod;
            this.BtnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.ForeColor = System.Drawing.Color.White;
            this.BtnSua.Location = new System.Drawing.Point(208, 582);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(121, 35);
            this.BtnSua.TabIndex = 11;
            this.BtnSua.Text = "✏ Sửa";
            // 
            // BtnLuu
            // 
            this.BtnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLuu.BorderRadius = 8;
            this.BtnLuu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLuu.ForeColor = System.Drawing.Color.White;
            this.BtnLuu.Location = new System.Drawing.Point(414, 582);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(121, 35);
            this.BtnLuu.TabIndex = 12;
            this.BtnLuu.Text = "💾 Lưu";
            // 
            // BtnXoa
            // 
            this.BtnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnXoa.BorderRadius = 8;
            this.BtnXoa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(618, 582);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(121, 35);
            this.BtnXoa.TabIndex = 13;
            this.BtnXoa.Text = "🗑 Xóa";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnBoqua
            // 
            this.BtnBoqua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBoqua.BorderRadius = 8;
            this.BtnBoqua.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBoqua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBoqua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBoqua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBoqua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBoqua.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnBoqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoqua.ForeColor = System.Drawing.Color.White;
            this.BtnBoqua.Location = new System.Drawing.Point(810, 582);
            this.BtnBoqua.Name = "BtnBoqua";
            this.BtnBoqua.Size = new System.Drawing.Size(121, 35);
            this.BtnBoqua.TabIndex = 14;
            this.BtnBoqua.Text = "✕ Bỏ qua";
            // 
            // FrmPhongHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 649);
            this.Controls.Add(this.BtnBoqua);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.dgvPhonghoc);
            this.Controls.Add(this.TxtTenphong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPhongHoc";
            this.Text = "FrmPhonghoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtTenphong;
        private System.Windows.Forms.DataGridView dgvPhonghoc;
        public Guna.UI2.WinForms.Guna2Button BtnThem;
        public Guna.UI2.WinForms.Guna2Button BtnSua;
        public Guna.UI2.WinForms.Guna2Button BtnLuu;
        public Guna.UI2.WinForms.Guna2Button BtnXoa;
        public Guna.UI2.WinForms.Guna2Button BtnBoqua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenphong;
    }
}
