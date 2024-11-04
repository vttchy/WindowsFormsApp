using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private void Date_Load(object sender, EventArgs e)
        {
            // Mã thực thi khi form được tải lên
            this.Text = "Quản lý ngày";  // Ví dụ: Đặt tiêu đề cho form
        }
        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem tất cả các trường có được điền đầy đủ hay không
        //    if (string.IsNullOrWhiteSpace(txt_tenphim.Text) ||
        //        string.IsNullOrWhiteSpace(txt_tenphong.Text) ||
        //        string.IsNullOrWhiteSpace(txt_ngaychieu.Text) ||
        //        string.IsNullOrWhiteSpace(txt_ngaytao.Text) ||
        //        string.IsNullOrWhiteSpace(txt_sove.Text) ||
        //        string.IsNullOrWhiteSpace(txt_trangthai.Text))
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return; // Kết thúc sự kiện nếu có trường bị thiếu
        //    }
        //    string checkLich = string.Format("SELECT * FROM LichChieu WHERE tenPhim = N'{0}'", txt_tenphim.Text);
        //    DataSet ds = db.LayDuLieu(checkLich, "Phim");

        //    if (ds.Tables["Phim"].Rows.Count >= 1)
        //    {
        //        MessageBox.Show("Trùng tên phim !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return; // Kết thúc nếu trùng tên phòng
        //    }

        //    string query = string.Format("insert into LichChieu(tenPhim, ngaycongchieu,trangthai, mota) values ('{0}', '{1}', '{2}', '{3}')", txt_tenphim.Text, DateTime.Parse(txt_ngay.Text).ToString("yyyy-MM-dd"), txt_trangthai.Text, txt_mota.Text);
        //    bool kt = db.ThucThi(query);

        //    if (kt == true)
        //    {
        //        MessageBox.Show("Thêm phim thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm phim không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void txt_tencum_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi người dùng nhập dữ liệu vào TextBox txt_tencum
            string tencum = txt_tenphim.Text;
            if (!string.IsNullOrWhiteSpace(tencum))
            {
                // Ví dụ: Nếu không rỗng, thực hiện hành động nào đó
                MessageBox.Show($"Tên cụm bạn nhập là: {tencum}", "Thông báo");
            }
        }

        private void txt_thuocphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
