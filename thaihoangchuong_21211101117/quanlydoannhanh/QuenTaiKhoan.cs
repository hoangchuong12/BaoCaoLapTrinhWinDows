using quanlydoannhanh.TK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydoannhanh
{
    public partial class QuenTaiKhoan : Form
    {
        private string generatedCode;
        public QuenTaiKhoan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TxtFgCode_GotFocus(object sender, EventArgs e)
        {
            if (txtMa.Text == "Type code from your email here!!!")
            {
                txtMa.Text = "";
                txtMa.ForeColor = Color.Black;
            }
        }

        private void TxtFgCode_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                txtMa.Text = "Type code from your email here!!!";
                txtMa.ForeColor = Color.Gray;
            }
        }

        private async void btnTaoMa_ClickAsync(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (TaiKhoan.KiemTraEmailTonTai(email))
            {
                // Thay đổi thông tin email tùy theo nhu cầu của bạn
                string from = "phamngoxuanhoangloc@gmail.com";
                string to = email;
                generatedCode = GenerateRandomCode();
                string title = "Your Code is:";

                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("chuong12072003@gmail.com", "wepu xjtf xpso smox"),
                    EnableSsl = true,
                };

                // Gọi phương thức SendMail
                bool send = await MailUtils.MailUtils.SendMail(from, to, title, generatedCode, client);
                if (send)
                {
                    txtMa.Visible = true;
                    txtMa.Text = "Type code from your email here!!!";
                    txtMa.ForeColor = Color.Gray;
                    txtMa.GotFocus += TxtFgCode_GotFocus;
                    txtMa.LostFocus += TxtFgCode_LostFocus;
                }
                else
                {
                    MessageBox.Show("Email does not exist, please try again!");
                }
            }
            else
            {
                MessageBox.Show("Email does not exist, please try again!");
            }
        }
        private string GenerateRandomCode()
        {
            Random random = new Random();
            int code = random.Next(10000000, 99999999);
            return code.ToString();
        }

        private void tbnXacNhanma_Click(object sender, EventArgs e)
        {
            string code = txtMa.Text.Trim();
            if (code == generatedCode)
            {
                txtMatKhau.Visible = true;
                btnXacNhanMK.Visible = true;
                lbKHoanMoi.Visible = true;
            }
        }

        private void btnXacNhanMK_Click(object sender, EventArgs e)
        {
            string Npass = txtMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (Npass.Length >= 8 && Npass.Any(char.IsUpper) && ContainsSpecialCharacter(Npass))
            {
                TaiKhoan.CapNhatMatKhau(email, Npass);
                generatedCode = null;
                MessageBox.Show("Change Success!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password must contain at least 8 characters, 1 uppercase letter, and 1 special character!");
            }

        }
        private bool ContainsSpecialCharacter(string input)
        {
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '-', '[', ']', '{', '}', '|', ';', ':', '\'', '\"', '<', '>', ',', '.', '?', '/' };
            foreach (char character in input)
            {
                if (specialCharacters.Contains(character))
                {
                    return true;
                }
            }
            return false;
        }

        private void QuenTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
