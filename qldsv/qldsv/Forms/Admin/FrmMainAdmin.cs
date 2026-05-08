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

namespace qldsv.Forms
{
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin()
        {
            InitializeComponent();
        }

        private void FrmMainAdmin_Load(object sender, EventArgs e)
        {
            lblTen.Text = CurrentUser.TenDangNhap;
        }
        private void LoadForm(Form form)
        {
            pnlcontent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlcontent.Controls.Add(form);
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

        private void btnQLK_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Admin.FrmKhoa());
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.Admin.FrmTaiKhoan());
        }
    }
}
