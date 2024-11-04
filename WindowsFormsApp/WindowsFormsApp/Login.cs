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
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btn_lg.Enabled = false;

            // Gắn sự kiện TextChanged cho các TextBox
            txt_email.TextChanged += new EventHandler(Dangnhap_TextChanged);
            txt_pass.TextChanged += new EventHandler(Dangnhap_TextChanged);
            // Cấu hình AutoComplete cho txt_email
            txt_email.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_email.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void Dangnhap_TextChanged(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(txt_email.Text) &&
                    !string.IsNullOrWhiteSpace(txt_pass.Text))
                {
                    btn_lg.Enabled = true;  // Kích hoạt nút btn_lg
                }
                else
                {
                    btn_lg.Enabled = false; // Vô hiệu hóa nút btn_lg
                }
            }

            KetNoi db = new KetNoi();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Sử dụng BCrypt để kiểm tra tính hợp lệ của mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        public bool CheckTxtNull()
        {
            if (txt_email.Text=="" || txt_pass.Text=="")
            {
                return false;
            } 
            return true;
        }
        private void btn_lg_Click(object sender, EventArgs e)
        {
            if (!CheckTxtNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sử dụng "using" để đảm bảo kết nối SQL được giải phóng tài nguyên
            string con_str = @"Data Source=CHYY;Initial Catalog=Quanlytaikhoan;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(con_str))
            {
                conn.Open();
                string email = txt_email.Text;
                string query = "SELECT role_id, passWord FROM TaiKhoan WHERE email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Chỉ cần đọc một lần

                            string hashedPassword = reader["passWord"].ToString();
                            int roleId = Convert.ToInt32(reader["role_id"]);

                            // Kiểm tra mật khẩu
                            if (VerifyPassword(txt_pass.Text, hashedPassword))
                            {
                                // Kiểm tra quyền dựa trên role_id
                                if (roleId == 0)
                                {
                                    register dangky = new register();
                                    this.Hide();
                                    dangky.Show();
                                }
                                else if (roleId == 1)
                                {
                                    Manage quanly= new Manage();
                                    this.Hide(); quanly.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Đăng nhập thành công với quyền User.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Thực hiện điều hướng đến giao diện dành cho User
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    

private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email email = new Email();
            this.Hide();
            email.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
