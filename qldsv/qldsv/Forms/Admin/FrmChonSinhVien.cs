using qldsv.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace qldsv.Forms.Admin
{
    public partial class FrmChonSinhVien : Form
    {
        private string maLHP;
        private DataTable dtFull;

        public FrmChonSinhVien(string maLHP)
        {
            InitializeComponent();
            this.maLHP = maLHP;
        }
    }
}
