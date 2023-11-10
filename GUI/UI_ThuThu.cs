using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class UI_ThuThu : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        private Form currentChildForm;
        public UI_ThuThu()
        {
            InitializeComponent();
            leftBtn = new Panel();
            leftBtn.Size = new Size(7, 70);
            panel2.Controls.Add(leftBtn);

            //form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 255, 0);
            public static Color color8 = Color.FromArgb(255, 255, 0);
            public static Color color9 = Color.FromArgb(153, 51, 255);
            public static Color color10 = Color.FromArgb(255, 51, 51);
            public static Color color11 = Color.FromArgb(0, 255, 255);
            public static Color color12 = Color.FromArgb(146, 216, 0);
        }

        private void OpenFormChild(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left boder button
                leftBtn.BackColor = color;
                leftBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();

                //icon Current Child
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        

        private void UI_ThuThu_Load(object sender, EventArgs e)
        {

        }


        private void Reset()
        {
            DisableButton();
            leftBtn.Visible = false;
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.MediumPurple;
            lbIconChild.Text = "Home";
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        //drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximumBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            } else WindowState = FormWindowState.Normal;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Sách";
            ActivateButton(sender, RGBColors.color1);
            OpenFormChild(new GUI_Sach());
        }

        private void btnPhieumuon_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phiếu mượn";
            ActivateButton(sender, RGBColors.color2);
            OpenFormChild(new GUI_MuonSach());
        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phiếu trả";
            ActivateButton(sender, RGBColors.color3);
            OpenFormChild(new GUI_TraSach());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Thể Loại";
            ActivateButton(sender, RGBColors.color4);
            OpenFormChild(new GUI_TheLoai());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Tác Giả";
            ActivateButton(sender, RGBColors.color5);
            OpenFormChild(new GUI_TacGia());
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhà Xuất Bản";
            ActivateButton(sender, RGBColors.color6);
            OpenFormChild(new GUI_NXB());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Độc Giả";
            ActivateButton(sender, RGBColors.color7);
            OpenFormChild(new GUI_DocGia());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhân Viên";
            ActivateButton(sender, RGBColors.color8);
            OpenFormChild(new GUI_NhanVien());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Tài Khoản";
            ActivateButton(sender, RGBColors.color9);
            OpenFormChild(new GUI_TaiKhoan());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phân Quyền";
            ActivateButton(sender, RGBColors.color10);
            OpenFormChild(new GUI_PhanQuyen());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhập Hàng";
            ActivateButton(sender, RGBColors.color11);
            OpenFormChild(new GUI_NhapHang());
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhà Cung Cấp";
            ActivateButton(sender, RGBColors.color12);
            OpenFormChild(new GUI_NCC());
        }
    }
}
