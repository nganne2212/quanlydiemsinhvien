using qldsv.Class;
using qldsv.Forms.Giangvien;
using qldsv.Forms.Sinhvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace qldsv.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            picmainDN.Image = Properties.Resources.anhdangnhap;
            picmainDN.SizeMode = PictureBoxSizeMode.Zoom;
            picowl.Image = Properties.Resources.convat;
            txtdangnhap.IconLeft = Properties.Resources.usericon;
            txtmatkhau.IconLeft = Properties.Resources.lockicon;
            BoGoc(panellogin, 30);
            this.AcceptButton = btnDangNhap;
            Class.Functions.Connect();
        }
        private void BoGoc(Control obj, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(obj.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(obj.Width - radius, obj.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, obj.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();
            obj.Region = new Region(path);
        }
        private bool showPassword;
        private void txtmatkhau_IconRightClick(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                // Hiện mật khẩu
                txtmatkhau.UseSystemPasswordChar = false;
                txtmatkhau.PasswordChar = '\0';
                txtmatkhau.IconRight = Properties.Resources.matmo;
            }
            else
            {
                // Ẩn mật khẩu
                txtmatkhau.UseSystemPasswordChar = true;
                txtmatkhau.PasswordChar = '●';
                txtmatkhau.IconRight = Properties.Resources.matdong;
            }
        }
        private int soLanSai = 0;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtdangnhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdangnhap.Focus();
                return;
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatkhau.Focus();
                return;
            }
            string matkhaumahoa = Utils.SecurityHelper.MaHoaMD5(txtmatkhau.Text.Trim());
            var user = Functions.QuerySingle<dynamic>(
            "SELECT * FROM NguoiDung WHERE TenDangNhap = @u AND MatKhau = @p",
            new { u = txtdangnhap.Text.Trim(), p = matkhaumahoa });

            if (user == null)
            {
                soLanSai++;
                if (soLanSai >= 5)
                {
                    Functions.Execute(
                        "UPDATE NguoiDung SET TrangThai = 'BiKhoa' WHERE TenDangNhap = @u",
                        new { u = txtdangnhap.Text.Trim() });
                    MessageBox.Show("Tài khoản bị khóa do nhập sai quá 5 lần!\nLiên hệ Admin.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDangNhap.Enabled = false;
                    return;
                }
                MessageBox.Show("Sai tài khoản hoặc mật khẩu! Còn " + (5 - soLanSai) + " lần thử.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user.TrangThai == "BiKhoa")
            {
                MessageBox.Show("Tài khoản đã bị khóa!\nLiên hệ Admin.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            soLanSai = 0;
            CurrentUser.MaNguoiDung = (int)user.MaNguoiDung;
            CurrentUser.TenDangNhap = (string)user.TenDangNhap;
            CurrentUser.VaiTro = (string)user.VaiTro;

            // DAPPER #2 — lấy MaDoiTuong
            if (CurrentUser.VaiTro == "SinhVien")
            {
                CurrentUser.MaDoiTuong = Functions.QuerySingle<string>(
                    "SELECT MaSinhVien FROM SinhVien WHERE MaNguoiDung = @id",
                    new { id = CurrentUser.MaNguoiDung });
            }
            else if (CurrentUser.VaiTro == "GiangVien")
            {
                CurrentUser.MaDoiTuong = Functions.QuerySingle<string>(
                    "SELECT MaGiangVien FROM GiangVien WHERE MaNguoiDung = @id",
                    new { id = CurrentUser.MaNguoiDung });
            }
            this.Hide();
            if (CurrentUser.VaiTro == "Admin")
                new FrmMainAdmin().Show();
            else if (CurrentUser.VaiTro == "GiangVien")
                new FrmMainGiangVien().Show();
            else if (CurrentUser.VaiTro == "SinhVien")
                new FrmMainSinhVien().Show();

        }

    }
 }

