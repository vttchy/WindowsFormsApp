using System.Windows.Forms;
using System;

namespace WindowsFormsApp
{
    public partial class Manage : Form
    {
        private Form activeForm = null; // Biến để theo dõi form con đang hiển thị

        public Manage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;  // Đặt Manage là MDI Container
        }

        // Hàm để mở một form và ẩn form cũ
        private void OpenChildForm(Form childForm)
        {
            // Nếu có form con đang hiển thị, ẩn nó đi
            if (activeForm != null)
                activeForm.Hide();

            // Thiết lập form mới làm form con
            activeForm = childForm;
            childForm.MdiParent = this; // Đặt Manage làm cha của form con
            childForm.Show(); // Hiển thị form con
        }

        // Khi label1 (mở Film) được click
        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Film());
        }

        // Khi label2 (mở room_manage) được click
        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new room_manage());
        }

        // Khi label3 (mở seat_manage) được click
        private void label3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Book_ticket());
        }

        // Khi label4 (mở schedule_manage) được click
        private void label4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Date());
        }

        // Khi label5 (mở customer_manage) được click
        private void label5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chair_manage());
        }

     
        
    }
}
