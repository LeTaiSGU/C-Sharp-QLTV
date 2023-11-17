using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GUI
{
    partial class UI_ThuThu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_ThuThu));
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.btnPhanQuyen = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnDocGia = new FontAwesome.Sharp.IconButton();
            this.btnNCC = new FontAwesome.Sharp.IconButton();
            this.btnTrasach = new FontAwesome.Sharp.IconButton();
            this.btnPhieumuon = new FontAwesome.Sharp.IconButton();
            this.btnSach = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.hideBtn = new FontAwesome.Sharp.IconButton();
            this.maximumBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.lbIconChild = new System.Windows.Forms.Label();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.panelLogo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.ForeColor = System.Drawing.Color.Blue;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(285, 913);
            this.panelControl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnNhapHang);
            this.panel2.Controls.Add(this.btnPhanQuyen);
            this.panel2.Controls.Add(this.btnTaiKhoan);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnDocGia);
            this.panel2.Controls.Add(this.btnNCC);
            this.panel2.Controls.Add(this.btnTrasach);
            this.panel2.Controls.Add(this.btnPhieumuon);
            this.panel2.Controls.Add(this.btnSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 634);
            this.panel2.TabIndex = 1;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnNhapHang.IconColor = System.Drawing.Color.White;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 560);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhapHang.Size = new System.Drawing.Size(285, 70);
            this.btnNhapHang.TabIndex = 31;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanQuyen.FlatAppearance.BorderSize = 0;
            this.btnPhanQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanQuyen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.btnPhanQuyen.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnPhanQuyen.IconColor = System.Drawing.Color.White;
            this.btnPhanQuyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhanQuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanQuyen.Location = new System.Drawing.Point(0, 490);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPhanQuyen.Size = new System.Drawing.Size(285, 70);
            this.btnPhanQuyen.TabIndex = 30;
            this.btnPhanQuyen.Text = "Phân Quyền";
            this.btnPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanQuyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhanQuyen.UseVisualStyleBackColor = true;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 420);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(285, 70);
            this.btnTaiKhoan.TabIndex = 29;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 350);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(285, 70);
            this.btnNhanVien.TabIndex = 28;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnDocGia.IconColor = System.Drawing.Color.White;
            this.btnDocGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.Location = new System.Drawing.Point(0, 280);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDocGia.Size = new System.Drawing.Size(285, 70);
            this.btnDocGia.TabIndex = 27;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnNCC.IconColor = System.Drawing.Color.White;
            this.btnNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(0, 210);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNCC.Size = new System.Drawing.Size(285, 70);
            this.btnNCC.TabIndex = 26;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnTrasach
            // 
            this.btnTrasach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrasach.FlatAppearance.BorderSize = 0;
            this.btnTrasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasach.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnTrasach.ForeColor = System.Drawing.Color.White;
            this.btnTrasach.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnTrasach.IconColor = System.Drawing.Color.White;
            this.btnTrasach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrasach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasach.Location = new System.Drawing.Point(0, 140);
            this.btnTrasach.Name = "btnTrasach";
            this.btnTrasach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrasach.Size = new System.Drawing.Size(285, 70);
            this.btnTrasach.TabIndex = 12;
            this.btnTrasach.Text = "Trả Sách";
            this.btnTrasach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrasach.UseVisualStyleBackColor = true;
            this.btnTrasach.Click += new System.EventHandler(this.btnTrasach_Click);
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
            this.btnPhieumuon.Location = new System.Drawing.Point(0, 70);
            this.btnPhieumuon.Name = "btnPhieumuon";
            this.btnPhieumuon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPhieumuon.Size = new System.Drawing.Size(285, 70);
            this.btnPhieumuon.TabIndex = 11;
            this.btnPhieumuon.Text = "Mượn Sách";
            this.btnPhieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieumuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieumuon.UseVisualStyleBackColor = true;
            this.btnPhieumuon.Click += new System.EventHandler(this.btnPhieumuon_Click);
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
            this.btnSach.Location = new System.Drawing.Point(0, 0);
            this.btnSach.Name = "btnSach";
            this.btnSach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSach.Size = new System.Drawing.Size(285, 70);
            this.btnSach.TabIndex = 10;
            this.btnSach.Text = "Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.panel3);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(285, 279);
            this.panelLogo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(285, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.hideBtn);
            this.panel1.Controls.Add(this.maximumBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.lbIconChild);
            this.panel1.Controls.Add(this.iconCurrentChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(285, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 80);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 35;
            this.btnInfo.Location = new System.Drawing.Point(18, 21);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // hideBtn
            // 
            this.hideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.hideBtn.FlatAppearance.BorderSize = 0;
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.hideBtn.IconColor = System.Drawing.SystemColors.Control;
            this.hideBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hideBtn.IconSize = 25;
            this.hideBtn.Location = new System.Drawing.Point(1227, 0);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(36, 33);
            this.hideBtn.TabIndex = 4;
            this.hideBtn.UseVisualStyleBackColor = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // maximumBtn
            // 
            this.maximumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.maximumBtn.FlatAppearance.BorderSize = 0;
            this.maximumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximumBtn.IconColor = System.Drawing.SystemColors.Control;
            this.maximumBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximumBtn.IconSize = 25;
            this.maximumBtn.Location = new System.Drawing.Point(1269, 0);
            this.maximumBtn.Name = "maximumBtn";
            this.maximumBtn.Size = new System.Drawing.Size(36, 33);
            this.maximumBtn.TabIndex = 4;
            this.maximumBtn.UseVisualStyleBackColor = false;
            this.maximumBtn.Click += new System.EventHandler(this.maximumBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeBtn.IconColor = System.Drawing.SystemColors.Control;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 25;
            this.closeBtn.Location = new System.Drawing.Point(1311, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 33);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbIconChild
            // 
            this.lbIconChild.AutoSize = true;
            this.lbIconChild.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIconChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbIconChild.Location = new System.Drawing.Point(126, 28);
            this.lbIconChild.Name = "lbIconChild";
            this.lbIconChild.Size = new System.Drawing.Size(54, 23);
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
            this.iconCurrentChild.Location = new System.Drawing.Point(79, 21);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(41, 40);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(285, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1347, 10);
            this.panelShadow.TabIndex = 5;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.lblTime);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(285, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1347, 823);
            this.panelDesktop.TabIndex = 6;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(469, 657);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(427, 58);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Thurday, December 19st,2023";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(466, 599);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(427, 58);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(411, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(545, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_ThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 913);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1350, 840);
            this.Name = "UI_ThuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UI_ThuThu_Load);
            this.panelControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIconChild;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton hideBtn;
        private FontAwesome.Sharp.IconButton maximumBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTrasach;
        private FontAwesome.Sharp.IconButton btnPhieumuon;
        private FontAwesome.Sharp.IconButton btnSach;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private FontAwesome.Sharp.IconButton btnPhanQuyen;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnDocGia;
        private FontAwesome.Sharp.IconButton btnNCC;
    }
}