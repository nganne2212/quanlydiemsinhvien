namespace qldsv.Forms
{
    partial class FrmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdmin));
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnPK = new Guna.UI2.WinForms.Guna2Button();
            this.QLLH = new Guna.UI2.WinForms.Guna2Button();
            this.QLLHP = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLPH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLHK = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLL = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLK = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLM = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLGV = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLSV = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblOnline = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlcontent
            // 
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(230, 0);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1004, 705);
            this.pnlcontent.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(85, 18);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(81, 30);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Admin";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRole.Location = new System.Drawing.Point(85, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(133, 21);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Quản trị hệ thống";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSidebar.Controls.Add(this.btnDangxuat);
            this.pnlSidebar.Controls.Add(this.btnPK);
            this.pnlSidebar.Controls.Add(this.QLLH);
            this.pnlSidebar.Controls.Add(this.QLLHP);
            this.pnlSidebar.Controls.Add(this.btnQLPH);
            this.pnlSidebar.Controls.Add(this.btnQLHK);
            this.pnlSidebar.Controls.Add(this.btnQLL);
            this.pnlSidebar.Controls.Add(this.btnQLK);
            this.pnlSidebar.Controls.Add(this.btnQLM);
            this.pnlSidebar.Controls.Add(this.btnQLGV);
            this.pnlSidebar.Controls.Add(this.btnQLSV);
            this.pnlSidebar.Controls.Add(this.btnQLTK);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblOnline);
            this.pnlSidebar.Controls.Add(this.lblRole);
            this.pnlSidebar.Controls.Add(this.lblTen);
            this.pnlSidebar.Controls.Add(this.picAvatar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 705);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Animated = true;
            this.btnDangxuat.BorderRadius = 8;
            this.btnDangxuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangxuat.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangxuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangxuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangxuat.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDangxuat.Location = new System.Drawing.Point(0, 580);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(230, 42);
            this.btnDangxuat.TabIndex = 16;
            this.btnDangxuat.Text = "🚪 Đăng xuất";
            this.btnDangxuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnPK
            // 
            this.btnPK.Animated = true;
            this.btnPK.BorderRadius = 8;
            this.btnPK.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPK.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPK.FillColor = System.Drawing.Color.Transparent;
            this.btnPK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPK.ForeColor = System.Drawing.Color.White;
            this.btnPK.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnPK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPK.ImageSize = new System.Drawing.Size(18, 18);
            this.btnPK.Location = new System.Drawing.Point(0, 540);
            this.btnPK.Name = "btnPK";
            this.btnPK.Size = new System.Drawing.Size(230, 42);
            this.btnPK.TabIndex = 15;
            this.btnPK.Text = "📝 Phúc khảo";
            this.btnPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QLLH
            // 
            this.QLLH.Animated = true;
            this.QLLH.BorderRadius = 8;
            this.QLLH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.QLLH.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.QLLH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QLLH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QLLH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QLLH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QLLH.FillColor = System.Drawing.Color.Transparent;
            this.QLLH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QLLH.ForeColor = System.Drawing.Color.White;
            this.QLLH.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.QLLH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QLLH.ImageSize = new System.Drawing.Size(18, 18);
            this.QLLH.Location = new System.Drawing.Point(0, 500);
            this.QLLH.Name = "QLLH";
            this.QLLH.Size = new System.Drawing.Size(230, 42);
            this.QLLH.TabIndex = 14;
            this.QLLH.Text = "📅 Quản lý lịch học";
            this.QLLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QLLHP
            // 
            this.QLLHP.Animated = true;
            this.QLLHP.BorderRadius = 8;
            this.QLLHP.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.QLLHP.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.QLLHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QLLHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QLLHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QLLHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QLLHP.FillColor = System.Drawing.Color.Transparent;
            this.QLLHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QLLHP.ForeColor = System.Drawing.Color.White;
            this.QLLHP.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.QLLHP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QLLHP.ImageSize = new System.Drawing.Size(18, 18);
            this.QLLHP.Location = new System.Drawing.Point(0, 460);
            this.QLLHP.Name = "QLLHP";
            this.QLLHP.Size = new System.Drawing.Size(230, 42);
            this.QLLHP.TabIndex = 13;
            this.QLLHP.Text = "📚 Quản lý LHP";
            this.QLLHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLPH
            // 
            this.btnQLPH.Animated = true;
            this.btnQLPH.BorderRadius = 8;
            this.btnQLPH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLPH.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLPH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLPH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLPH.FillColor = System.Drawing.Color.Transparent;
            this.btnQLPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLPH.ForeColor = System.Drawing.Color.White;
            this.btnQLPH.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLPH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLPH.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLPH.Location = new System.Drawing.Point(0, 420);
            this.btnQLPH.Name = "btnQLPH";
            this.btnQLPH.Size = new System.Drawing.Size(230, 42);
            this.btnQLPH.TabIndex = 12;
            this.btnQLPH.Text = "🏢 Quản lý phòng học";
            this.btnQLPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLHK
            // 
            this.btnQLHK.Animated = true;
            this.btnQLHK.BorderRadius = 8;
            this.btnQLHK.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLHK.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLHK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLHK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLHK.FillColor = System.Drawing.Color.Transparent;
            this.btnQLHK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLHK.ForeColor = System.Drawing.Color.White;
            this.btnQLHK.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLHK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHK.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLHK.Location = new System.Drawing.Point(0, 380);
            this.btnQLHK.Name = "btnQLHK";
            this.btnQLHK.Size = new System.Drawing.Size(230, 42);
            this.btnQLHK.TabIndex = 11;
            this.btnQLHK.Text = "🗓️ Quản lý học kỳ";
            this.btnQLHK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLL
            // 
            this.btnQLL.Animated = true;
            this.btnQLL.BorderRadius = 8;
            this.btnQLL.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLL.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLL.FillColor = System.Drawing.Color.Transparent;
            this.btnQLL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLL.ForeColor = System.Drawing.Color.White;
            this.btnQLL.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLL.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLL.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLL.Location = new System.Drawing.Point(0, 340);
            this.btnQLL.Name = "btnQLL";
            this.btnQLL.Size = new System.Drawing.Size(230, 42);
            this.btnQLL.TabIndex = 10;
            this.btnQLL.Text = "📋 Quản lý lớp học";
            this.btnQLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLK
            // 
            this.btnQLK.Animated = true;
            this.btnQLK.BorderRadius = 8;
            this.btnQLK.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLK.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLK.FillColor = System.Drawing.Color.Transparent;
            this.btnQLK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLK.ForeColor = System.Drawing.Color.White;
            this.btnQLK.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLK.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLK.Location = new System.Drawing.Point(0, 260);
            this.btnQLK.Name = "btnQLK";
            this.btnQLK.Size = new System.Drawing.Size(230, 42);
            this.btnQLK.TabIndex = 9;
            this.btnQLK.Text = "🏢 Quản lý Khoa";
            this.btnQLK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLK.Click += new System.EventHandler(this.btnQLK_Click);
            // 
            // btnQLM
            // 
            this.btnQLM.Animated = true;
            this.btnQLM.BorderRadius = 8;
            this.btnQLM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLM.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLM.FillColor = System.Drawing.Color.Transparent;
            this.btnQLM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLM.ForeColor = System.Drawing.Color.White;
            this.btnQLM.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLM.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLM.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLM.Location = new System.Drawing.Point(0, 300);
            this.btnQLM.Name = "btnQLM";
            this.btnQLM.Size = new System.Drawing.Size(230, 42);
            this.btnQLM.TabIndex = 8;
            this.btnQLM.Text = "📚 Quản lý môn học";
            this.btnQLM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLGV
            // 
            this.btnQLGV.Animated = true;
            this.btnQLGV.BorderRadius = 8;
            this.btnQLGV.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLGV.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLGV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLGV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLGV.FillColor = System.Drawing.Color.Transparent;
            this.btnQLGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLGV.ForeColor = System.Drawing.Color.White;
            this.btnQLGV.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLGV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLGV.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLGV.Location = new System.Drawing.Point(0, 220);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(230, 42);
            this.btnQLGV.TabIndex = 7;
            this.btnQLGV.Text = "👨‍🏫 Quản lý giảng viên";
            this.btnQLGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLSV
            // 
            this.btnQLSV.Animated = true;
            this.btnQLSV.BorderRadius = 8;
            this.btnQLSV.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLSV.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLSV.FillColor = System.Drawing.Color.Transparent;
            this.btnQLSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLSV.ForeColor = System.Drawing.Color.White;
            this.btnQLSV.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLSV.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLSV.Location = new System.Drawing.Point(0, 180);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(230, 42);
            this.btnQLSV.TabIndex = 6;
            this.btnQLSV.Text = "🎓Quản lý sinh viên";
            this.btnQLSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnQLTK
            // 
            this.btnQLTK.Animated = true;
            this.btnQLTK.BorderRadius = 8;
            this.btnQLTK.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLTK.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQLTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLTK.FillColor = System.Drawing.Color.Transparent;
            this.btnQLTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLTK.ForeColor = System.Drawing.Color.White;
            this.btnQLTK.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLTK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLTK.ImageSize = new System.Drawing.Size(18, 18);
            this.btnQLTK.Location = new System.Drawing.Point(0, 140);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(230, 42);
            this.btnQLTK.TabIndex = 5;
            this.btnQLTK.Text = "👤 Quản lý tài khoản";
            this.btnQLTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(18, 18);
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 42);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Lime;
            this.lblOnline.Location = new System.Drawing.Point(85, 62);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(75, 21);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "● Online";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::qldsv.Properties.Resources.avatar;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(15, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            this.picAvatar.UseTransparentBackground = true;
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 705);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý điểm sinh viên - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainAdmin_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlcontent;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private System.Windows.Forms.Label lblOnline;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnQLTK;
        private Guna.UI2.WinForms.Guna2Button btnQLL;
        private Guna.UI2.WinForms.Guna2Button btnQLK;
        private Guna.UI2.WinForms.Guna2Button btnQLM;
        private Guna.UI2.WinForms.Guna2Button btnQLGV;
        private Guna.UI2.WinForms.Guna2Button btnQLSV;
        private Guna.UI2.WinForms.Guna2Button QLLHP;
        private Guna.UI2.WinForms.Guna2Button btnQLPH;
        private Guna.UI2.WinForms.Guna2Button btnQLHK;
        private Guna.UI2.WinForms.Guna2Button QLLH;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnPK;
    }
}