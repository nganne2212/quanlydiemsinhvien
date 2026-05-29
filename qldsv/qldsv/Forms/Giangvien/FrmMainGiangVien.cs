using qldsv.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qldsv.Forms.Giangvien
{
    public partial class FrmMainGiangVien : Form
    {
        public FrmMainGiangVien()
        {
            InitializeComponent();
        }

        private void FrmMainGiangVien_Load(object sender, EventArgs e)
        {
            lblTenGV.Text = CurrentUser.TenDangNhap;
            LoadForm(new Forms.Giangvien.FrmDanhSachLHP());
        }
        private void LoadForm(Form form)
        {
            pnlContentGV.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContentGV.Controls.Add(form);
            form.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                CurrentUser.Reset();
                Functions.Disconnect();
                this.Hide();
                new FrmDangNhap().Show();
            }
        }

        private void btnLophocphan_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Giangvien.FrmDanhSachLHP());
        }

        private void btnNhapdiem_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Giangvien.FrmNhapDiem());
        }

        private void btnCanhbaohocvu_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Giangvien.FrmCanhBaoHocVu());
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Giangvien.FrmDoiMatKhauGV());
        }
    }
}
