using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qldsv.DAL;

namespace qldsv.Forms.Admin
{
    public partial class FrmHocKy : Form
    {
        public FrmHocKy()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvQuanlyhocky.DataSource = HocKyDAL.GetAll();
        }

        private void FrmHocKy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // THÊM HỌC KỲ
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenHocKy = txtTenhocky.Text.Trim();
            string namHoc = txtNamhoc.Text.Trim();

            // kiểm tra rỗng
            if (tenHocKy == "" || namHoc == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // kiểm tra trùng
            if (HocKyDAL.KiemTraTrung(tenHocKy, namHoc))
            {
                MessageBox.Show("Học kỳ đã tồn tại!");
                return;
            }

            // thêm vào database
            HocKyDAL.Them(tenHocKy, namHoc);

            MessageBox.Show("Thêm thành công!");

            // load lại dữ liệu
            LoadData();
        }

        private void dgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenhocky.Text = dgvQuanlyhocky.Rows[e.RowIndex].Cells["TenHocKy"].Value.ToString();
                txtNamhoc.Text = dgvQuanlyhocky.Rows[e.RowIndex].Cells["NamHoc"].Value.ToString();
            }
        }

        // SỬA HỌC KỲ
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!");
                return;
            }

            int maHocKy = Convert.ToInt32(
                dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value
            );

            string tenHocKy = txtTenhocky.Text.Trim();
            string namHoc = txtNamhoc.Text.Trim();

            // kiểm tra trùng
            if (HocKyDAL.KiemTraTrung(tenHocKy, namHoc, maHocKy))
            {
                MessageBox.Show("Học kỳ đã tồn tại!");
                return;
            }

            HocKyDAL.Sua(maHocKy, tenHocKy, namHoc);

            MessageBox.Show("Sửa thành công!");

            LoadData();
        }

        // XÓA HỌC KỲ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!");
                return;
            }

            int maHocKy = Convert.ToInt32(
                dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value
            );

            // kiểm tra đang sử dụng
            if (HocKyDAL.DangDuocDung(maHocKy))
            {
                MessageBox.Show("Học kỳ đang được sử dụng!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                HocKyDAL.Xoa(maHocKy);

                MessageBox.Show("Xóa thành công!");

                LoadData();
            }
        }

        // MỞ HỌC KỲ
        private void btnMoHocKy_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!");
                return;
            }

            int maHocKy = Convert.ToInt32(
                dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value
            );

            HocKyDAL.MoHocKy(maHocKy);

            MessageBox.Show("Mở học kỳ thành công!");

            LoadData();
        }

        // ĐÓNG HỌC KỲ
        private void btnDongHocKy_Click(object sender, EventArgs e)
        {
            if (dgvQuanlyhocky.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!");
                return;
            }

            int maHocKy = Convert.ToInt32(
                dgvQuanlyhocky.CurrentRow.Cells["MaHocKy"].Value
            );

            HocKyDAL.DongHocKy(maHocKy);

            MessageBox.Show("Đóng học kỳ thành công!");

            LoadData();
        }
    }
}