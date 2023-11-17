namespace GUI
{
    partial class GUI_Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Sach));
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTacGia = new FontAwesome.Sharp.IconButton();
            this.btnTheLoai = new FontAwesome.Sharp.IconButton();
            this.btnNhaXuatBan = new FontAwesome.Sharp.IconButton();
            this.flowpanelSach = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lableName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowpanelSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 120;
            this.iconButton1.Location = new System.Drawing.Point(26, 39);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(300, 200);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Sách";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTacGia.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTacGia.FlatAppearance.BorderSize = 0;
            this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.ForeColor = System.Drawing.Color.White;
            this.btnTacGia.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.btnTacGia.IconColor = System.Drawing.Color.White;
            this.btnTacGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTacGia.IconSize = 120;
            this.btnTacGia.Location = new System.Drawing.Point(353, 39);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(300, 200);
            this.btnTacGia.TabIndex = 4;
            this.btnTacGia.Text = "Tác Giả";
            this.btnTacGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTacGia.UseVisualStyleBackColor = false;
            this.btnTacGia.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTheLoai.FlatAppearance.BorderSize = 0;
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.btnTheLoai.IconColor = System.Drawing.Color.White;
            this.btnTheLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheLoai.IconSize = 120;
            this.btnTheLoai.Location = new System.Drawing.Point(677, 39);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(300, 200);
            this.btnTheLoai.TabIndex = 5;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTheLoai.UseVisualStyleBackColor = false;
            // 
            // btnNhaXuatBan
            // 
            this.btnNhaXuatBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhaXuatBan.BackColor = System.Drawing.Color.Red;
            this.btnNhaXuatBan.FlatAppearance.BorderSize = 0;
            this.btnNhaXuatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaXuatBan.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btnNhaXuatBan.IconColor = System.Drawing.Color.White;
            this.btnNhaXuatBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhaXuatBan.IconSize = 120;
            this.btnNhaXuatBan.Location = new System.Drawing.Point(1001, 39);
            this.btnNhaXuatBan.Name = "btnNhaXuatBan";
            this.btnNhaXuatBan.Size = new System.Drawing.Size(300, 200);
            this.btnNhaXuatBan.TabIndex = 6;
            this.btnNhaXuatBan.Text = "Nhà Xuất Bản";
            this.btnNhaXuatBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhaXuatBan.UseVisualStyleBackColor = false;
            // 
            // flowpanelSach
            // 
            this.flowpanelSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowpanelSach.AutoScroll = true;
            this.flowpanelSach.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.flowpanelSach.BackColor = System.Drawing.Color.Transparent;
            this.flowpanelSach.Controls.Add(this.panel1);
            this.flowpanelSach.Location = new System.Drawing.Point(26, 273);
            this.flowpanelSach.Name = "flowpanelSach";
            this.flowpanelSach.Size = new System.Drawing.Size(1119, 520);
            this.flowpanelSach.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.status);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 385);
            this.panel1.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.White;
            this.panelName.Controls.Add(this.button1);
            this.panelName.Controls.Add(this.lableName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 274);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(268, 111);
            this.panelName.TabIndex = 3;
            this.panelName.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.panelName.MouseLeave += new System.EventHandler(this.leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(92, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lableName
            // 
            this.lableName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.ForeColor = System.Drawing.Color.Black;
            this.lableName.Location = new System.Drawing.Point(3, 13);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(262, 28);
            this.lableName.TabIndex = 0;
            this.lableName.Text = "Chiến tranh thế giới 0000000";
            this.lableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lableName.MouseEnter += new System.EventHandler(this.lableName_MouseEnter);
            this.lableName.MouseLeave += new System.EventHandler(this.lb_leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.leave);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.status.Dock = System.Windows.Forms.DockStyle.Top;
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(268, 7);
            this.status.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1171, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thêm Sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1171, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GUI_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 815);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowpanelSach);
            this.Controls.Add(this.btnNhaXuatBan);
            this.Controls.Add(this.btnTheLoai);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.iconButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GUI_Sach";
            this.flowpanelSach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTacGia;
        private FontAwesome.Sharp.IconButton btnTheLoai;
        private FontAwesome.Sharp.IconButton btnNhaXuatBan;
        private System.Windows.Forms.FlowLayoutPanel flowpanelSach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel status;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Button button3;
    }
}