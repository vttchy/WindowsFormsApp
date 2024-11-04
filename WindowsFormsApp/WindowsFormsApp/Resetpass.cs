using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp
{
    public partial class Resetpass : Form
    {
        private string email;

        public Resetpass(string email) // Constructor nhận email
        {
            InitializeComponent();
            this.email = email;
        }

        public Resetpass()
        {
            InitializeComponent();
            btn_reset.Enabled = false; // Vô hiệu hóa nút btn_reset ban đầu

            // Gắn sự kiện TextChanged cho các TextBox
            txt_newpass.TextChanged += new EventHandler(Resetpass_TextChanged);
            txt_resetpass.TextChanged += new EventHandler(Resetpass_TextChanged);
        }

        private void Resetpass_TextChanged(object sender, EventArgs e)

        {
            

            if (!string.IsNullOrWhiteSpace(txt_newpass.Text) &&
                !string.IsNullOrWhiteSpace(txt_resetpass.Text))
            {
                btn_reset.Enabled = true;  // Kích hoạt nút btn_reset
            }
            else
            {
                btn_reset.Enabled = false; // Vô hiệu hóa nút btn_reset
            }
        }

        public bool CheckTxtNull()
        {
            return !string.IsNullOrWhiteSpace(txt_newpass.Text) && !string.IsNullOrWhiteSpace(txt_resetpass.Text);
        }

        private void btn_repass_Click(object sender, EventArgs e)
            
        {
            MessageBox.Show(email, "Giá trị của email trước khi truyền vào");
            bool check = CheckTxtNull();
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_newpass.Text != txt_resetpass.Text)
            {
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string con_str = @"Data Source=CHYY;Initial Catalog=Quanlytaikhoan;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(con_str))
            {
                conn.Open();

                // Truy vấn kiểm tra sự tồn tại của tài khoản với email
                string querykt = "SELECT * FROM Taikhoan WHERE email=@Email";
                using (SqlCommand cmd = new SqlCommand(querykt, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Đóng reader trước khi thực hiện truy vấn cập nhật
                        reader.Close();

                        // Bắt đầu cập nhật mật khẩu
                        string newPassword = txt_newpass.Text;
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);  // Mã hóa mật khẩu mới

                        string updateQuery = "UPDATE Taikhoan SET passWord=@HashedPassword WHERE email=@Email";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            // Thêm tham số cho câu lệnh UPDATE
                            updateCmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@Email", email);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mật khẩu đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản với email này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
