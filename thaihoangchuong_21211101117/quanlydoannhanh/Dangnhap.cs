using quanlydoannhanh.TK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydoannhanh
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            bool isvalif = TaiKhoan.KiemTraTaiKhoanVaMatKhau(taikhoan, matkhau);
            if(isvalif )
            {
                Form form = new Admin();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("tài Khoản mật Khẩu sai");
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            Form form = new Dangky();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new QuenTaiKhoan();
            form.ShowDialog();
        }
    }
}
