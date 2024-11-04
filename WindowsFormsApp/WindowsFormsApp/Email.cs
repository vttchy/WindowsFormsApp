using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WindowsFormsApp
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        public bool CheckTxtNull()
        {
            if (txt_resetemail.Text == "")
            {
                return false;
            }
            return true;
        }
        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Mã OTP gồm 6 chữ số
        }
        private void SendOTPEmail(string toEmail, string otp)
        {
            string fromEmail = "thuychi251004@gmail.com";
            string subject = "Mã xác thực đặt lại mật khẩu";
            string body = $"Mã xác thực của bạn là: {otp}";

            MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("thuychi251004@gmail.com", "lisz ocxo jqtm xmcb"),
                EnableSsl = true,
            };

            client.Send(mail);
        }
        private string currentOTP;

        private void btn_lg_Click(object sender, EventArgs e)
        {
            bool checkNull = CheckTxtNull();
            if (!checkNull)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string con_str = @"Data Source=CHYY;Initial Catalog=Quanlytaikhoan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con_str);
            conn.Open();
            string email = txt_resetemail.Text;
            string querykt = "select * from Taikhoan where email=@Email";
            using (SqlCommand cmd = new SqlCommand(querykt, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int idUser = (int)reader["idUser"];  // Lấy idUser từ kết quả truy vấn
                    reader.Close();
                }

            }
            

            // Tạo mã OTP
            currentOTP = GenerateOTP();

            // Gửi mã OTP qua email
            SendOTPEmail(email, currentOTP);

            MessageBox.Show("Mã xác thực đã được gửi tới email của bạn. Vui lòng kiểm tra email.", "Thông báo");
            CheckOTP formOTP = new CheckOTP(currentOTP,email); // Truyền mã OTP tại đây
            formOTP.Show();
            this.Hide(); // Ẩn FormEmail
          
        }

    }
}
