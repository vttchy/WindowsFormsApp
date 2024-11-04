namespace WindowsFormsApp
{
    partial class room_manage
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
            this.txt_soghe = new System.Windows.Forms.TextBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_soghe
            // 
            this.txt_soghe.Location = new System.Drawing.Point(238, 190);
            this.txt_soghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soghe.Name = "txt_soghe";
            this.txt_soghe.Size = new System.Drawing.Size(423, 22);
            this.txt_soghe.TabIndex = 64;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(238, 120);
            this.txt_tenphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(423, 22);
            this.txt_tenphong.TabIndex = 63;
            this.txt_tenphong.TextChanged += new System.EventHandler(this.txt_tenphong_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Blue;
            this.txt_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_search.Location = new System.Drawing.Point(541, 308);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 31);
            this.txt_search.TabIndex = 62;
            this.txt_search.Text = "Tìm kiếm";
            this.txt_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(398, 308);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 31);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Số lượng ghế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 57;
            this.label2.Text = "Thông tin phòng";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(236, 308);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 31);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(85, 308);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 55;
            this.btn_add.Text = "Thêm ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // room_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 396);
            this.Controls.Add(this.txt_soghe);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "room_manage";
            this.Text = "room_manage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_soghe;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Button txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
    }
}