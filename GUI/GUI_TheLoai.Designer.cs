namespace GUI
{
    partial class GUI_TheLoai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.rt_moTa = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_ngung = new System.Windows.Forms.RadioButton();
            this.rd_dang = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_trangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_moTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.cb_timKiem = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(451, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ THỂ LOẠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(629, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(348, 159);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(176, 22);
            this.txt_ten.TabIndex = 8;
            // 
            // rt_moTa
            // 
            this.rt_moTa.Location = new System.Drawing.Point(723, 111);
            this.rt_moTa.Name = "rt_moTa";
            this.rt_moTa.Size = new System.Drawing.Size(321, 148);
            this.rt_moTa.TabIndex = 9;
            this.rt_moTa.Text = "";
            this.rt_moTa.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_ngung);
            this.panel1.Controls.Add(this.rd_dang);
            this.panel1.Location = new System.Drawing.Point(348, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 56);
            this.panel1.TabIndex = 10;
            // 
            // rd_ngung
            // 
            this.rd_ngung.AutoSize = true;
            this.rd_ngung.ForeColor = System.Drawing.Color.White;
            this.rd_ngung.Location = new System.Drawing.Point(124, 17);
            this.rd_ngung.Name = "rd_ngung";
            this.rd_ngung.Size = new System.Drawing.Size(131, 20);
            this.rd_ngung.TabIndex = 11;
            this.rd_ngung.TabStop = true;
            this.rd_ngung.Text = "Ngừng hoạt động";
            this.rd_ngung.UseVisualStyleBackColor = true;
            // 
            // rd_dang
            // 
            this.rd_dang.AutoSize = true;
            this.rd_dang.ForeColor = System.Drawing.Color.White;
            this.rd_dang.Location = new System.Drawing.Point(13, 17);
            this.rd_dang.Name = "rd_dang";
            this.rd_dang.Size = new System.Drawing.Size(91, 20);
            this.rd_dang.TabIndex = 0;
            this.rd_dang.TabStop = true;
            this.rd_dang.Text = "Hoạt động";
            this.rd_dang.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ma,
            this.col_ten,
            this.col_trangThai,
            this.col_moTa});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(219, 357);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(825, 213);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_ma
            // 
            this.col_ma.Text = "Mã thể loại";
            this.col_ma.Width = 89;
            // 
            // col_ten
            // 
            this.col_ten.Text = "Tên thể loại";
            this.col_ten.Width = 96;
            // 
            // col_trangThai
            // 
            this.col_trangThai.Text = "Trạng thái";
            this.col_trangThai.Width = 92;
            // 
            // col_moTa
            // 
            this.col_moTa.Text = "Mô tả";
            this.col_moTa.Width = 238;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(1105, 96);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(114, 36);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_capNhat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.ForeColor = System.Drawing.Color.White;
            this.btn_capNhat.Location = new System.Drawing.Point(1105, 181);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(114, 36);
            this.btn_capNhat.TabIndex = 14;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            // 
            // cb_timKiem
            // 
            this.cb_timKiem.FormattingEnabled = true;
            this.cb_timKiem.Items.AddRange(new object[] {
            "Tên",
            "Mã"});
            this.cb_timKiem.Location = new System.Drawing.Point(219, 303);
            this.cb_timKiem.Name = "cb_timKiem";
            this.cb_timKiem.Size = new System.Drawing.Size(95, 24);
            this.cb_timKiem.TabIndex = 15;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(352, 303);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(172, 22);
            this.txt_timKiem.TabIndex = 16;
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang hoạt động",
            "Ngừng hoạt động"});
            this.cb_trangThai.Location = new System.Drawing.Point(704, 303);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(121, 24);
            this.cb_trangThai.TabIndex = 17;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(348, 107);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(176, 22);
            this.txt_ma.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_lamMoi.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_lamMoi.Location = new System.Drawing.Point(1105, 263);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(114, 36);
            this.btn_lamMoi.TabIndex = 20;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            // 
            // GUI_TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1329, 572);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_trangThai);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.cb_timKiem);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rt_moTa);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GUI_TheLoai";
            this.Text = "GUI_TheLoai";
            this.Load += new System.EventHandler(this.GUI_TheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.RichTextBox rt_moTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_ngung;
        private System.Windows.Forms.RadioButton rd_dang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_ma;
        private System.Windows.Forms.ColumnHeader col_ten;
        private System.Windows.Forms.ColumnHeader col_trangThai;
        private System.Windows.Forms.ColumnHeader col_moTa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.ComboBox cb_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}