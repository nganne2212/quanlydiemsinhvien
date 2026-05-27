using qldsv.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            dgvSinhVien.Columns.Clear(); // xoa cot cu truoc

            // Them cot checkbox
            var colChon = new DataGridViewCheckBoxColumn();
            colChon.Name = "colChon";
            colChon.HeaderText = "Chon";
            colChon.Width = 55;
            colChon.FalseValue = false;
            colChon.TrueValue = true;
            dgvSinhVien.Columns.Add(colChon);

            // Them cac cot du lieu
            dgvSinhVien.AutoGenerateColumns = false;

            var colMaSV = new DataGridViewTextBoxColumn();
            colMaSV.Name = "colMaSV";
            colMaSV.HeaderText = "MSSV";
            colMaSV.DataPropertyName = "MaSinhVien";
            colMaSV.Width = 100;
            colMaSV.ReadOnly = true;
            dgvSinhVien.Columns.Add(colMaSV);

            var colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.Name = "colHoTen";
            colHoTen.HeaderText = "Họ tên";
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 200;
            colHoTen.ReadOnly = true;
            dgvSinhVien.Columns.Add(colHoTen);

            var colLop = new DataGridViewTextBoxColumn();
            colLop.Name = "colLop";
            colLop.HeaderText = "Lớp";
            colLop.DataPropertyName = "TenLop";
            colLop.Width = 120;
            colLop.ReadOnly = true;
            dgvSinhVien.Columns.Add(colLop);

            dgvSinhVien.DataSource = tblSV;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvSinhVien.MultiSelect = false;
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
                $"MaSinhVien LIKE '%{kw}%' OR HoTen LIKE '%{kw}%' OR TenLop LIKE '%{kw}%'";
            dgvSinhVien.DataSource = dv.ToTable();
            // Reset checkbox sau khi loc
            foreach (DataGridViewRow r in dgvSinhVien.Rows)
                r.Cells["colChon"].Value = false;
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

        
            var dsChon = dgvSinhVien.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["colChon"].Value ?? false))
                .ToList();

            if (dsChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sinh viên!",
                    "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuongThem = 0;
            var dsLoi = new List<string>();

            foreach (DataGridViewRow row in dsChon)
            {
                string maSV = row.Cells["colMaSV"].Value.ToString();
                string hoTen = row.Cells["colHoTen"].Value.ToString();
                string loi = LopHocPhanBLL.ThemSVVaoLHP(maSV, _maLHP);

                if (loi == "")
                    soLuongThem++;
                else
                    dsLoi.Add($"- {maSV} ({hoTen}): {loi}");
            }

            if (soLuongThem > 0 && dsLoi.Count == 0)
            {
                MessageBox.Show($"Đã thêm {soLuongThem} sinh viên vào lớp học phần!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (soLuongThem > 0 && dsLoi.Count > 0)
            {
                string thongBao = $"Đã thêm {soLuongThem} sinh viên.\n\n"
                                + $"Các sinh viên không thể thêm ({dsLoi.Count}):\n"
                                + string.Join("\n", dsLoi);
                MessageBox.Show(thongBao, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                string thongBao = "Không thể thêm sinh viên nào:\n\n"
                                + string.Join("\n", dsLoi);
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load_DgvSV();
            }
        }
        

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Click bat ky cot nao cung toggle checkbox
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            bool current = Convert.ToBoolean(row.Cells["colChon"].Value ?? false);
            row.Cells["colChon"].Value = !current;
        }
    }
}
