using qldsv.BLL;
using qldsv.Class;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qldsv.Forms.Giangvien
{
    public partial class FrmDoiMatKhauGV : Form
    {
        public FrmDoiMatKhauGV()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhauGV_Load(object sender, EventArgs e)
        {
            // Mặc định ẩn mật khẩu
            txtMatKhauCu.PasswordChar = '●';
            txtMatKhauMoi.PasswordChar = '●';
            txtNhapLai.PasswordChar = '●';
        }

        // Gắn sự kiện này vào chkHienThi.CheckedChanged trong Designer
        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            // Checked = hiện mật khẩu, Unchecked = ẩn
            char c = chkHienThi.Checked ? '\0' : '●';
            txtMatKhauCu.PasswordChar = c;
            txtMatKhauMoi.PasswordChar = c;
            txtNhapLai.PasswordChar = c;
        }

        // Gắn sự kiện này vào btnHuy.Click trong Designer
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gắn sự kiện này vào btnDoiMatKhau.Click trong Designer
        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLai = txtNhapLai.Text.Trim();

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(matKhauCu) ||
                string.IsNullOrEmpty(matKhauMoi) ||
                string.IsNullOrEmpty(nhapLai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra độ mạnh mật khẩu mới
            string kiemTraMK = KiemTraMatKhauManh(matKhauMoi);
            if (kiemTraMK != "")
            {
                MessageBox.Show(kiemTraMK, "Mật khẩu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra nhập lại
            if (matKhauMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // CurrentUser.TenDangNhap: tên đăng nhập người đang dùng
                // CurrentUser.MaDoiTuong: mã giảng viên hoặc sinh viên tuỳ VaiTro
                string tenDangNhap = CurrentUser.TenDangNhap;

                string loi = DoiMatKhauGVBLL.DoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi);
                if (loi != "")
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(
                    $"Đổi mật khẩu thành công!\nTài khoản: {tenDangNhap}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra mật khẩu đủ mạnh.
        /// Trả về "" nếu hợp lệ, trả về thông báo lỗi nếu không.
        /// Yêu cầu: tối thiểu 8 ký tự, có chữ hoa, chữ thường, số, ký tự đặc biệt.
        /// </summary>
        private string KiemTraMatKhauManh(string matKhau)
        {
            if (matKhau.Length < 8)
                return "Mật khẩu phải có ít nhất 8 ký tự!";

            if (!Regex.IsMatch(matKhau, @"[A-Z]"))
                return "Mật khẩu phải có ít nhất 1 chữ hoa (A-Z)!";

            if (!Regex.IsMatch(matKhau, @"[a-z]"))
                return "Mật khẩu phải có ít nhất 1 chữ thường (a-z)!";

            if (!Regex.IsMatch(matKhau, @"[0-9]"))
                return "Mật khẩu phải có ít nhất 1 chữ số (0-9)!";

            if (!Regex.IsMatch(matKhau, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]"))
                return "Mật khẩu phải có ít nhất 1 ký tự đặc biệt (!@#$%...)!";

            return "";
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e) { }
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e) { }
        private void txtNhapLai_TextChanged(object sender, EventArgs e) { }
    }
}