using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class room_manage : Form
    {
        public room_manage()
        {
            InitializeComponent();
        }
        KetNoi db= new KetNoi();
        private void btn_add_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
                if (string.IsNullOrWhiteSpace(txt_tenphong.Text) ||
                    string.IsNullOrWhiteSpace(txt_soghe.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc sự kiện nếu có trường bị thiếu
                }
            }
            int soGhe;
            if (!int.TryParse(txt_soghe.Text, out soGhe) || soGhe <= 0 || soGhe >= 200)
            {
                MessageBox.Show("Số lượng ghế phải là số lớn hơn 0 và nhỏ hơn 200!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu số ghế không hợp lệ
            }

            string checktenPhong = string.Format("SELECT * FROM Phong WHERE ten_phong = N'{0}'", txt_tenphong.Text); // Sửa tên cột đúng "ten_phong"
            DataSet ds = db.LayDuLieu(checktenPhong, "Phong");

            if (ds.Tables["Phong"].Rows.Count >= 1)
            {
                MessageBox.Show("Trùng tên phòng !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc nếu trùng tên phòng
            }

            string query = string.Format("INSERT INTO Phong(ten_phong, so_LuongGhe) VALUES (N'{0}', '{1}')", txt_tenphong.Text, txt_soghe.Text);
            bool kt = db.ThucThi(query);

            if (kt==true)
            {
                MessageBox.Show("Thêm phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



            private void btn_update_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
                if (string.IsNullOrWhiteSpace(txt_tenphong.Text) ||
                    string.IsNullOrWhiteSpace(txt_soghe.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc sự kiện nếu có trường bị thiếu
                }
            }
            int soGhe;
            if (!int.TryParse(txt_soghe.Text, out soGhe) || soGhe <= 0 || soGhe >= 200)
            {
                MessageBox.Show("Số lượng ghế phải là số lớn hơn 0 và nhỏ hơn 200!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu số ghế không hợp lệ
            }
            string checkidPhong = string.Format("SELECT id_Phong FROM Phong WHERE ten_phong = N'{0}'", txt_tenphong.Text);
            DataSet ds = db.LayDuLieu(checkidPhong, "Phong");

            if (ds.Tables["Phong"].Rows.Count == 1)
            {
                int idPhong = (int)ds.Tables["Phong"].Rows[0]["id_Phong"];

                // Cập nhật thông tin phim
                string query = string.Format("UPDATE Phong SET ten_phong = N'{0}',so_LuongGhe= N'{1}' WHERE id_Phong = '{2}'",
                                             txt_tenphong.Text,
                                             txt_soghe.Text,
                                             idPhong);

                bool kt = db.ThucThi(query);
                if (kt)
                {
                    MessageBox.Show("Cập nhật phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không tìm thấy bản ghi
                MessageBox.Show("Không tìm thấy thông tin phòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
                if (string.IsNullOrWhiteSpace(txt_tenphong.Text) ||
                    string.IsNullOrWhiteSpace(txt_soghe.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc sự kiện nếu có trường bị thiếu
                }
            }

            string checkidPhong = string.Format("SELECT id_Phong FROM Phong WHERE ten_phong = N'{0}'", txt_tenphong.Text);
            DataSet ds = db.LayDuLieu(checkidPhong, "Phong");
            if (ds.Tables["Phong"].Rows.Count == 1)
            {
                int idPhong = (int)ds.Tables["Phong"].Rows[0]["id_Phong"];  // Lấy id_Phim từ kết quả truy vấn

                // Xoa thông tin phong
                // Xoa thông tin phong
                string query = string.Format("Delete Phong where ten_phong='{0}'", txt_tenphong.Text);

                bool kt = db.ThucThi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không tìm thấy bản ghi
                MessageBox.Show("Không tìm thấy thông tin phòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_tenphong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
