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

namespace qldsv.Forms.Sinhvien
{
    public partial class FrmMainSinhVien : Form
    {
        public FrmMainSinhVien()
        {
            InitializeComponent();
        }

        private void FrmMainSinhVien_Load(object sender, EventArgs e)
        {
            lblSvien.Text = CurrentUser.TenDangNhap;
        }
        private void LoadForm(Form form)
        {
            pnlndung.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlndung.Controls.Add(form);
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

        private void btnKQHT_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Sinhvien.FrmKQhoctap());
        }
    }
}
