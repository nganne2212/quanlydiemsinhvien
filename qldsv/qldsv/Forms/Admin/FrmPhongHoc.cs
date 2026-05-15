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
    public partial class FrmPhongHoc : Form
    {
        public FrmPhongHoc()
        {
            InitializeComponent();
        }
        private void FrmPhonghoc_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            this.Scale(new SizeF(0.8f, 0.8f));
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

        }


    }
}
