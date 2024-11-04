using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CheckOTP : Form
    {
        private string sentOTP; // Biến lưu mã OTP được truyền từ FormEmail
        private string _email;

        public CheckOTP(string otp, string email)
        {
            InitializeComponent();
            sentOTP = otp; // Lưu mã OTP đã được gửi từ FormEmail++
            _email = email;
        }

        private void btn_verifyOTP_Click(object sender, EventArgs e)
        {
            string enteredOTP = txt_otp.Text; // Lấy mã OTP người dùng nhập

            if (enteredOTP == sentOTP)
            {
                MessageBox.Show("Xác thực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thực hiện các thao tác khác sau khi xác thực thành công

                Resetpass reset = new Resetpass(_email);
                reset.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng. Vui lòng thử lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}
