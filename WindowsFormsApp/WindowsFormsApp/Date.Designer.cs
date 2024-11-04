namespace WindowsFormsApp
{
    partial class Date
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
            this.txt_sove = new System.Windows.Forms.TextBox();
            this.txt_ngaychieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_ngaytao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenphim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sove
            // 
            this.txt_sove.Location = new System.Drawing.Point(238, 276);
            this.txt_sove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sove.Name = "txt_sove";
            this.txt_sove.Size = new System.Drawing.Size(423, 22);
            this.txt_sove.TabIndex = 69;
            // 
            // txt_ngaychieu
            // 
            this.txt_ngaychieu.Location = new System.Drawing.Point(238, 181);
            this.txt_ngaychieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaychieu.Name = "txt_ngaychieu";
            this.txt_ngaychieu.Size = new System.Drawing.Size(423, 22);
            this.txt_ngaychieu.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Số vé:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Ngày chiếu:";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(238, 316);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(423, 22);
            this.txt_trangthai.TabIndex = 65;
            this.txt_trangthai.TextChanged += new System.EventHandler(this.txt_thuocphong_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(550, 373);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 31);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 31);
            this.label2.TabIndex = 57;
            this.label2.Text = "Thông tin lịch chiếu";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(357, 373);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 31);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(161, 373);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 55;
            this.btn_add.Text = "Thêm ";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // txt_ngaytao
            // 
            this.txt_ngaytao.Location = new System.Drawing.Point(238, 222);
            this.txt_ngaytao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaytao.Name = "txt_ngaytao";
            this.txt_ngaytao.Size = new System.Drawing.Size(423, 22);
            this.txt_ngaytao.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ngày tạo:";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(238, 131);
            this.txt_tenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(423, 22);
            this.txt_tenphong.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tên phòng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tenphim
            // 
            this.txt_tenphim.Location = new System.Drawing.Point(238, 84);
            this.txt_tenphim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenphim.Name = "txt_tenphim";
            this.txt_tenphim.Size = new System.Drawing.Size(423, 22);
            this.txt_tenphim.TabIndex = 63;
            this.txt_tenphim.TextChanged += new System.EventHandler(this.txt_tencum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên phim:";
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.txt_ngaytao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sove);
            this.Controls.Add(this.txt_ngaychieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.txt_tenphim);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Date";
            this.Text = "Date";
            this.Load += new System.EventHandler(this.Date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sove;
        private System.Windows.Forms.TextBox txt_ngaychieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_ngaytao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenphim;
        private System.Windows.Forms.Label label3;
    }
}