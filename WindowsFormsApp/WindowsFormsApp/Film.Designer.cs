namespace WindowsFormsApp
{
    partial class Film
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.txt_tenphim = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_anh = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(238, 190);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(423, 22);
            this.txt_trangthai.TabIndex = 49;
            this.txt_trangthai.TextChanged += new System.EventHandler(this.txt_trangthai_TextChanged);
            // 
            // txt_ngay
            // 
            this.txt_ngay.Location = new System.Drawing.Point(238, 140);
            this.txt_ngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(423, 22);
            this.txt_ngay.TabIndex = 48;
            this.txt_ngay.TextChanged += new System.EventHandler(this.txt_ngay_TextChanged);
            // 
            // txt_tenphim
            // 
            this.txt_tenphim.Location = new System.Drawing.Point(238, 94);
            this.txt_tenphim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenphim.Name = "txt_tenphim";
            this.txt_tenphim.Size = new System.Drawing.Size(423, 22);
            this.txt_tenphim.TabIndex = 47;
            this.txt_tenphim.TextChanged += new System.EventHandler(this.txt_tenphim_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Blue;
            this.txt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_search.Location = new System.Drawing.Point(539, 338);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 31);
            this.txt_search.TabIndex = 46;
            this.txt_search.Text = "Tìm kiếm";
            this.txt_search.UseVisualStyleBackColor = false;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(396, 338);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 31);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Trạng thái:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày công chiếu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên phim:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Thông tin phim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(234, 338);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 31);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(83, 338);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 39;
            this.btn_add.Text = "Thêm ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_anh
            // 
            this.txt_anh.Location = new System.Drawing.Point(238, 278);
            this.txt_anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_anh.Name = "txt_anh";
            this.txt_anh.Size = new System.Drawing.Size(423, 22);
            this.txt_anh.TabIndex = 54;
            this.txt_anh.TextChanged += new System.EventHandler(this.txt_anh_TextChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(238, 234);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(423, 22);
            this.txt_mota.TabIndex = 53;
            this.txt_mota.TextChanged += new System.EventHandler(this.txt_mota_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ảnh:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mô tả:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 442);
            this.Controls.Add(this.txt_anh);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.txt_ngay);
            this.Controls.Add(this.txt_tenphim);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.TextBox txt_ngay;
        private System.Windows.Forms.TextBox txt_tenphim;
        private System.Windows.Forms.Button txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_anh;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}