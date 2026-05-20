using qldsv.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmChonSinhVien : Form
    {
        private string _maLHP;
        DataTable tblSV;

        public FrmChonSinhVien(string maLHP)
        {
            InitializeComponent();
            _maLHP = maLHP;
        }

        private void FrmChonSinhVien_Load(object sender, EventArgs e)
        {
            this.Text = "Chọn sinh viên - LHP: " + _maLHP;
            Load_DgvSV();
            
        }
        private void Load_DgvSV()
        {
            tblSV = LopHocPhanBLL.GetSVChuaDangKy(_maLHP);
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.DataSource = tblSV;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSinhVien.MultiSelect = true;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn col in dgvSinhVien.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tblSV == null) return;
            string kw = txtSearch.Text.Trim().Replace("'", "''");
            DataView dv = tblSV.DefaultView;
            dv.RowFilter = string.IsNullOrEmpty(kw) ? "" :
                $"MaSinhVien LIKE '%{kw}%' OR HoTen LIKE '%{kw}%'";
            dgvSinhVien.DataSource = dv.ToTable();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSinhVien.Rows.Count == 0 &&
                    !string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongThem = 0;
            foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
            {
                string maSV = row.Cells[0].Value.ToString();
                string loi = LopHocPhanBLL.ThemSVVaoLHP(maSV, _maLHP);
                if (loi == "") soLuongThem++;
            }

            MessageBox.Show($"Đã thêm {soLuongThem} sinh viên vào lớp học phần!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
