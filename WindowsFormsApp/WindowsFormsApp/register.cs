using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;
using BCrypt.Net;
namespace WindowsFormsApp
{

    public partial class register : Form
    {

        public register()
        {
            InitializeComponent();

            btn_register.Enabled = false;
            txt_email.TextChanged += new EventHandler(register_TextChanged);
            txt_mk.TextChanged += new EventHandler(register_TextChanged);
            txt_repass.TextChanged += new EventHandler(register_TextChanged);
            txt_sdt.TextChanged += new EventHandler(register_TextChanged);
            txt_tk.TextChanged += new EventHandler(register_TextChanged);
            txt_roleid.TextChanged += new EventHandler(register_TextChanged);
        }
        private void register_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_email.Text) &&
                !string.IsNullOrWhiteSpace(txt_mk.Text) &&
                !string.IsNullOrWhiteSpace(txt_repass.Text) &&
                !string.IsNullOrWhiteSpace(txt_sdt.Text) &&
                !string.IsNullOrWhiteSpace(txt_tk.Text) &&
                !string.IsNullOrWhiteSpace(txt_roleid.Text))
            {
                btn_register.Enabled = true;  // Kích hoạt nút btn_lg
            }
            else
            {
                btn_register.Enabled = false; // Vô hiệu hóa nút btn_lg
            }
        }

        KetNoi db = new KetNoi();
        public static string HashPassword(string password)
        {
            // Sử dụng BCrypt để tạo một salt ngẫu nhiên và mã hóa mật khẩu
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Sử dụng BCrypt để kiểm tra tính hợp lệ của mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string hashedPassword = HashPassword(txt_mk.Text);
            string email = txt_email.Text;

            // Biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện nếu email không hợp lệ
            }
            if (txt_repass.Text != txt_mk.Text)
            {
                MessageBox.Show("Mật khẩu xác thực không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = string.Format("insert into TaiKhoan(userName,passWord, SDT ,email, role_id ) values ('{0}','{1}','{2}','{3}', '{4}')",
             txt_tk.Text, hashedPassword, txt_sdt.Text, txt_email.Text, txt_roleid.Text);
            string check = string.Format("select * from TaiKhoan where email= '{0}' ", txt_email.Text);
            DataSet ds = db.LayDuLieu(check, "Taikhoan");
            if (ds.Tables["TaiKhoan"].Rows.Count >= 1)
            {
                MessageBox.Show("Trùng tài khoản gmail !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool kt = db.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login dangnhap = new Login();
                this.Hide();
                dangnhap.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký k thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
