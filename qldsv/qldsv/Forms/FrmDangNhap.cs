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
            picowl.Image = Properties.Resources.conowldep;
            picowl.SizeMode = PictureBoxSizeMode.Zoom;
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
            string sql = "Select * from NguoiDung Where TenDangNhap =N'" + txtdangnhap.Text.Trim() + "' AND MatKhau =N'" + matkhaumahoa + "'";

            DataTable tblUser = Class.Functions.GetDataToTable(sql);
            if (tblUser.Rows.Count == 0)
            {
                soLanSai++;
                if (soLanSai > 5)
                {
                    string sqlKhoa = "Update NguoiDung Set TrangThai = 'BiKhoa' Where TenDangNhap = N'" + txtdangnhap.Text.Trim() + "'";
                    Class.Functions.RunSql(sqlKhoa);
                    MessageBox.Show("Tài khoản bị khóa do nhập sai quá 5 lần!\nLiên hệ Admin.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDangNhap.Enabled = false;
                    return;

                }
                MessageBox.Show("Sai tài khoản hoặc mật khẩu! Còn " + (5 - soLanSai) + " lần thử.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kiểm tra tài khoản bị khóa
            if (tblUser.Rows[0]["TrangThai"].ToString() == "BiKhoa")
            {
                MessageBox.Show("Tài khoản đã bị khóa!\nLiên hệ Admin.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            soLanSai = 0;
            Class.CurrentUser.MaNguoiDung = Convert.ToInt32(tblUser.Rows[0]["MaNguoiDung"]);
            Class.CurrentUser.TenDangNhap = tblUser.Rows[0]["TenDangNhap"].ToString();
            Class.CurrentUser.VaiTro = tblUser.Rows[0]["VaiTro"].ToString();
            if(Class.CurrentUser.VaiTro == "SinhVien")
            {
                string sqlSV = "Select MaSinhVien FROM SinhVien WHERE MaNguoiDung = "   + Class.CurrentUser.MaNguoiDung;
                DataTable tblSV = Class.Functions.GetDataToTable(sqlSV);
                if (tblSV.Rows.Count > 0)
                    Class.CurrentUser.MaDoiTuong = tblSV.Rows[0]["MaSinhVien"].ToString();
            }
            else if (CurrentUser.VaiTro == "GiangVien")
            {
                string sqlGV = "SELECT MaGiangVien FROM GiangVien WHERE MaNguoiDung = "
                    + CurrentUser.MaNguoiDung;
                DataTable tblGV = Functions.GetDataToTable(sqlGV);
                if (tblGV.Rows.Count > 0)
                    CurrentUser.MaDoiTuong = tblGV.Rows[0]["MaGiangVien"].ToString();
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

