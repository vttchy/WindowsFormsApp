using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp
{
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent(); // Gọi  textbox, button
        }
        KetNoi db = new KetNoi();
        private void Film_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_tenphim.Text) ||
                string.IsNullOrWhiteSpace(txt_ngay.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text) ||
                string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            string checktenPhim = string.Format("SELECT * FROM Phim WHERE tenPhim = N'{0}'", txt_tenphim.Text);
            DataSet ds = db.LayDuLieu(checktenPhim, "Phim");

            if (ds.Tables["Phim"].Rows.Count >= 1)
            {
                MessageBox.Show("Trùng tên phim !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc nếu trùng tên phòng
            }

            string query = string.Format("insert into Phim(tenPhim, ngaycongchieu,trangthai, mota) values ('{0}', '{1}', '{2}', '{3}')", txt_tenphim.Text, DateTime.Parse(txt_ngay.Text).ToString("yyyy-MM-dd"), txt_trangthai.Text, txt_mota.Text);
            bool kt = db.ThucThi(query);

            if (kt == true)
            {
                MessageBox.Show("Thêm phim thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phim không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)

        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_tenphim.Text) ||
                string.IsNullOrWhiteSpace(txt_ngay.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text) ||
                string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            string checktenPhim = string.Format("SELECT * FROM Phim WHERE tenPhim = N'{0}'", txt_tenphim.Text);
            DataSet ds = db.LayDuLieu(checktenPhim, "Phim");
            if (ds.Tables["Phim"].Rows.Count == 1)
            {
                int idPhim = (int)ds.Tables["Phim"].Rows[0]["id_Phim"];  // Lấy id_Phim từ kết quả truy vấn

                // Cập nhật thông tin phim
                string query = string.Format("UPDATE Phim SET tenPhim = N'{0}', ngaycongchieu = '{1}', trangthai = N'{2}', mota = N'{3}' WHERE id_Phim = {4}",
                                             txt_tenphim.Text,
                                             DateTime.Parse(txt_ngay.Text).ToString("yyyy-MM-dd"),
                                             txt_trangthai.Text,
                                             txt_mota.Text,
                                             idPhim);

                bool kt = db.ThucThi(query);
                if (kt)
                {
                    MessageBox.Show("Cập nhật phim thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật phim không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không tìm thấy bản ghi
                MessageBox.Show("Không tìm thấy thông tin phim này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
            if (string.IsNullOrWhiteSpace(txt_tenphim.Text) ||
                string.IsNullOrWhiteSpace(txt_ngay.Text) ||
                string.IsNullOrWhiteSpace(txt_trangthai.Text) ||
                string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sự kiện nếu có trường bị thiếu
            }
            string checkidPhim = string.Format("SELECT id_Phim FROM Phim WHERE tenPhim = N'{0}'", txt_tenphim.Text);
            DataSet ds = db.LayDuLieu(checkidPhim, "Phim");

            if (ds.Tables["Phim"].Rows.Count == 1)
            {
                int idPhim = (int)ds.Tables["Phim"].Rows[0]["id_Phim"];  // Lấy id_Phim từ kết quả truy vấn

                // Cập nhật thông tin phim
                string query = string.Format("Delete Phim where tenPhim='{0}'", txt_tenphim.Text);

                bool kt = db.ThucThi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa phim thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phim không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không tìm thấy bản ghi
                MessageBox.Show("Không tìm thấy thông tin phòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_mota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_trangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ngay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenphim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_anh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}