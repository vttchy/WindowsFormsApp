using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class Book_ticket : Form
    {
        KetNoi db = new KetNoi(); // Khởi tạo đối tượng kết nối

        public Book_ticket()
        {
            InitializeComponent();
        }

        private void Book_ticket_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã để tải dữ liệu khi form được tải
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_ten.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            // Kiểm tra xem email có bị trùng không
            string checkEmail = string.Format("SELECT * FROM DatVe WHERE email = '{0}'", txt_email.Text);
            DataSet ds = db.LayDuLieu(checkEmail, "DatVe");

            // Nếu email đã tồn tại, thông báo và không thực hiện thêm
            if (ds.Tables["DatVe"].Rows.Count >= 1)
            {
                MessageBox.Show("Email đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm thông tin người dùng vào cơ sở dữ liệu
            string query = string.Format("INSERT INTO DatVe (ten, email, sdt, trangthai) VALUES (N'{0}', '{1}', '{2}', N'{3}')",
                                          txt_ten.Text,
                                          txt_email.Text,
                                          txt_sdt.Text,
                                          txt_trangthai.Text);

            bool result = db.ThucThi(query);

            if (result)
            {
                MessageBox.Show("Thêm người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm người dùng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_ten.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            // Kiểm tra xem email có tồn tại không
            string checkEmail = string.Format("SELECT * FROM DatVe WHERE email = '{0}'", txt_email.Text);
            DataSet ds = db.LayDuLieu(checkEmail, "DatVe");

            if (ds.Tables["DatVe"].Rows.Count == 1)
            {
                // Cập nhật thông tin người dùng
                string query = string.Format("UPDATE DatVe SET ten = N'{0}', sdt = '{1}', trangthai = N'{2}' WHERE email = '{3}'",
                                              txt_ten.Text,
                                              txt_sdt.Text,
                                              txt_trangthai.Text,
                                              txt_email.Text);

                bool result = db.ThucThi(query);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng với email này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_ten.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            // Kiểm tra xem email có tồn tại không
            string checkEmail = string.Format("SELECT * FROM DatVe WHERE email = '{0}'", txt_email.Text);
            DataSet ds = db.LayDuLieu(checkEmail, "DatVe");

            if (ds.Tables["DatVe"].Rows.Count == 1)
            {
                // Xóa người dùng khỏi cơ sở dữ liệu
                string query = string.Format("DELETE FROM DatVe WHERE email = '{0}'", txt_email.Text);
                bool result = db.ThucThi(query);
                if (result)
                {
                    MessageBox.Show("Xóa người dùng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa người dùng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng với email này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            // Tìm kiếm người dùng theo email
            string checkEmail = string.Format("SELECT * FROM DatVe WHERE email = '{0}'", txt_search.Text);
            DataSet ds = db.LayDuLieu(checkEmail, "DatVe");

            if (ds.Tables["DatVe"].Rows.Count == 1)
            {
                // Hiển thị thông tin người dùng lên các TextBox
                txt_ten.Text = ds.Tables["DatVe"].Rows[0]["ten"].ToString();
                txt_sdt.Text = ds.Tables["DatVe"].Rows[0]["sdt"].ToString();
                txt_trangthai.Text = ds.Tables["DatVe"].Rows[0]["trangthai"].ToString();
                MessageBox.Show("Tìm thấy thông tin người dùng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            // Có thể thêm mã xử lý nếu cần khi text của txt_ten thay đổi
        }

        private void Book_ticket_Load_1(object sender, EventArgs e)
        {
            // Có thể thêm mã để tải dữ liệu khi form được tải
        }
    }
}
