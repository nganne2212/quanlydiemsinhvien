using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmLopHocPhan : Form
    {
        public FrmLopHocPhan()
        {
            InitializeComponent();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (dgvLopHocPhan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học phần trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maLHP = dgvLopHocPhan.CurrentRow.Cells["colMaLHP"].Value.ToString();
            var popup = new Admin.FrmChonSinhVien(maLHP);
            //if (popup.ShowDialog() == DialogResult.OK)
              //  LoadDanhSachSV(maLHP); // load lai bang SV
        }
    }
}
