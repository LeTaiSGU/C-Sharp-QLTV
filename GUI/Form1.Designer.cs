namespace GUI
{
    partial class Form1
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIconChild = new System.Windows.Forms.Label();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.btnNhapsach = new FontAwesome.Sharp.IconButton();
            this.btnThethuvien = new FontAwesome.Sharp.IconButton();
            this.btnNhacc = new FontAwesome.Sharp.IconButton();
            this.btnPhieumuon = new FontAwesome.Sharp.IconButton();
            this.btnTacgia = new FontAwesome.Sharp.IconButton();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.AutoScroll = true;
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelControl.Controls.Add(this.btnNhapsach);
            this.panelControl.Controls.Add(this.btnThethuvien);
            this.panelControl.Controls.Add(this.btnNhacc);
            this.panelControl.Controls.Add(this.btnPhieumuon);
            this.panelControl.Controls.Add(this.btnTacgia);
            this.panelControl.Controls.Add(this.btnSach);
            this.panelControl.Controls.Add(this.panelLogo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.ForeColor = System.Drawing.Color.Blue;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(285, 913);
            this.panelControl.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(285, 215);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lbIconChild);
            this.panel1.Controls.Add(this.iconCurrentChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(285, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 80);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbIconChild
            // 
            this.lbIconChild.AutoSize = true;
            this.lbIconChild.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIconChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbIconChild.Location = new System.Drawing.Point(71, 32);
            this.lbIconChild.Name = "lbIconChild";
            this.lbIconChild.Size = new System.Drawing.Size(59, 21);
            this.lbIconChild.TabIndex = 2;
            this.lbIconChild.Text = "Home";
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 40;
            this.iconCurrentChild.Location = new System.Drawing.Point(24, 21);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(41, 40);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            // 
            // btnNhapsach
            // 
            this.btnNhapsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapsach.FlatAppearance.BorderSize = 0;
            this.btnNhapsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapsach.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhapsach.ForeColor = System.Drawing.Color.White;
            this.btnNhapsach.IconChar = FontAwesome.Sharp.IconChar.TruckFieldUn;
            this.btnNhapsach.IconColor = System.Drawing.Color.White;
            this.btnNhapsach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapsach.Location = new System.Drawing.Point(0, 565);
            this.btnNhapsach.Name = "btnNhapsach";
            this.btnNhapsach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhapsach.Size = new System.Drawing.Size(285, 70);
            this.btnNhapsach.TabIndex = 8;
            this.btnNhapsach.Text = "Nhập Sách";
            this.btnNhapsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapsach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapsach.UseVisualStyleBackColor = true;
            this.btnNhapsach.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnThethuvien
            // 
            this.btnThethuvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThethuvien.FlatAppearance.BorderSize = 0;
            this.btnThethuvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThethuvien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnThethuvien.ForeColor = System.Drawing.Color.White;
            this.btnThethuvien.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnThethuvien.IconColor = System.Drawing.Color.White;
            this.btnThethuvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThethuvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThethuvien.Location = new System.Drawing.Point(0, 495);
            this.btnThethuvien.Name = "btnThethuvien";
            this.btnThethuvien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThethuvien.Size = new System.Drawing.Size(285, 70);
            this.btnThethuvien.TabIndex = 7;
            this.btnThethuvien.Text = "Thẻ Thư Viện";
            this.btnThethuvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThethuvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThethuvien.UseVisualStyleBackColor = true;
            this.btnThethuvien.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnNhacc
            // 
            this.btnNhacc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhacc.FlatAppearance.BorderSize = 0;
            this.btnNhacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhacc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhacc.ForeColor = System.Drawing.Color.White;
            this.btnNhacc.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnNhacc.IconColor = System.Drawing.Color.White;
            this.btnNhacc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacc.Location = new System.Drawing.Point(0, 425);
            this.btnNhacc.Name = "btnNhacc";
            this.btnNhacc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhacc.Size = new System.Drawing.Size(285, 70);
            this.btnNhacc.TabIndex = 6;
            this.btnNhacc.Text = "Nhà Cung Cấp";
            this.btnNhacc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhacc.UseVisualStyleBackColor = true;
            this.btnNhacc.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnPhieumuon
            // 
            this.btnPhieumuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieumuon.FlatAppearance.BorderSize = 0;
            this.btnPhieumuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieumuon.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnPhieumuon.ForeColor = System.Drawing.Color.White;
            this.btnPhieumuon.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnPhieumuon.IconColor = System.Drawing.Color.White;
            this.btnPhieumuon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhieumuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieumuon.Location = new System.Drawing.Point(0, 355);
            this.btnPhieumuon.Name = "btnPhieumuon";
            this.btnPhieumuon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPhieumuon.Size = new System.Drawing.Size(285, 70);
            this.btnPhieumuon.TabIndex = 5;
            this.btnPhieumuon.Text = "Mượn Sách";
            this.btnPhieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieumuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieumuon.UseVisualStyleBackColor = true;
            this.btnPhieumuon.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnTacgia
            // 
            this.btnTacgia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTacgia.FlatAppearance.BorderSize = 0;
            this.btnTacgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacgia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnTacgia.ForeColor = System.Drawing.Color.White;
            this.btnTacgia.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.btnTacgia.IconColor = System.Drawing.Color.White;
            this.btnTacgia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTacgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTacgia.Location = new System.Drawing.Point(0, 285);
            this.btnTacgia.Name = "btnTacgia";
            this.btnTacgia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTacgia.Size = new System.Drawing.Size(285, 70);
            this.btnTacgia.TabIndex = 4;
            this.btnTacgia.Text = "Tác Giả";
            this.btnTacgia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTacgia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTacgia.UseVisualStyleBackColor = true;
            this.btnTacgia.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnSach
            // 
            this.btnSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnSach.IconColor = System.Drawing.Color.White;
            this.btnSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Location = new System.Drawing.Point(0, 215);
            this.btnSach.Name = "btnSach";
            this.btnSach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSach.Size = new System.Drawing.Size(285, 70);
            this.btnSach.TabIndex = 3;
            this.btnSach.Text = "Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1632, 913);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControl.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnNhacc;
        private FontAwesome.Sharp.IconButton btnPhieumuon;
        private FontAwesome.Sharp.IconButton btnTacgia;
        private FontAwesome.Sharp.IconButton btnSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnNhapsach;
        private FontAwesome.Sharp.IconButton btnThethuvien;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label lbIconChild;
    }
}

