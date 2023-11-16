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
    public partial class Dangky : Form
    {
    
        public Dangky()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string taikhoan = txtDKTaikhoan.Text.Trim();
            string matkhau = txtDKMatkhau.Text.Trim();

            bool emailTonTai = TaiKhoan.KiemTraEmailTonTai(email);

            if (emailTonTai)
            {
                MessageBox.Show("Email đã được sử dụng. Vui lòng sử dụng địa chỉ email khác.");
            }
            else
            {
                // Thêm tài khoản mới vào cơ sở dữ liệu
                TaiKhoan taiKhoanMoi = new TaiKhoan
                {
                    Email = email,
                    taiKhoan1 = taikhoan,
                    MatKhau = matkhau
                };

                using (var context = new QLDOAN())
                {
                    context.TaiKhoans.Add(taiKhoanMoi);
                    context.SaveChanges();
                }

                MessageBox.Show("Đăng ký thành công!");
            }
        }
    }
}
