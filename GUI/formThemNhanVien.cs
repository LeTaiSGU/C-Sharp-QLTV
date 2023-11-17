using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formThemNhanVien : Form
    {
        //NhanVienBUS bus = new NhanVienBUS();
        string imgPath1 = "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg";
        public formThemNhanVien()
        {
            InitializeComponent();
            setCungMaNV();
            cb_role.SelectedIndex = 0;
            
        }
        public event EventHandler btn_Them_Clicked;
        private void Onbtn_Them_Clicked()
        {
            btn_Them_Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //if (checkValidForm())
            //{
            //    NhanVienDTO nv = getModel();
            //    if (bus.insertNhanVien(nv) > 0)
            //    {
            //        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Onbtn_Them_Clicked();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgPath1 = openFileDialog.FileName;
                    pictureBox1.Image = new Bitmap(imgPath1);
                }
            }
            // kiem tra duong dan
            //if (pictureBox1.Tag != null)
            //{
            //    string imagePath = pictureBox1.Tag.ToString();
            //    MessageBox.Show($"Image Path: {imagePath}", "Image Path Information");
            //}
            //else
            //{
            //    MessageBox.Show("No image is selected.", "Information");
            //}

        }

        private void formThemNhanVien_Load(object sender, EventArgs e)
        {

        }
        public  void setCungMaNV()
        {
            //int sl = bus.getSoLuongNhanVien();
            //sl = sl + 1;
            //if(sl < 10)
            //{
            //    txt_ma.Text = "NV0" + sl.ToString();
            //}
            //else
            //{
            //    txt_ma.Text = "NV" + sl.ToString();

            //}

            //txt_ma.ReadOnly = true;
        }
        //public NhanVienDTO getModel()
        //{
        //    NhanVienDTO nv = new NhanVienDTO();
        //    string ten = txt_ten.Text;
        //    string diaChi = txt_diachi.Text;
        //    string sdt = txt_sdt.Text;
        //    //string chucVu = txt_chucvu.Text;
        //    ten = ten.Trim();
        //    diaChi = diaChi.Trim();
        //    sdt = sdt.Trim();
        //   // chucVu = chucVu.Trim();
        //    ten = Regex.Replace(ten, @"\s+", " ");
        //    diaChi = Regex.Replace(diaChi, @"\s+", " ");
        //    sdt = Regex.Replace(sdt, @"\s+", " ");
        //   // chucVu = Regex.Replace(chucVu, @"\s+", " ");

        //    nv.MaNhanVien = txt_ma.Text;
        //    nv.TenNhanVien = ten;
        //    if(rd_nam.Checked)
        //    {
        //        nv.GioiTinh = true;
        //    }
        //    else
        //    {
        //        nv.GioiTinh=false;
        //    }
        //    nv.NgaySinh = dp_ngaysinh.Value;
        //    nv.DiaChi=diaChi;
        //    if (rd_dang.Checked)
        //    {
        //        nv.TrangThai = true;
        //    }
        //    else
        //    {
        //        nv.TrangThai = false;
        //    }
        //    nv.ChucVu=cb_role.SelectedItem.ToString();
        //    nv.Img = imgPath1;
        //    nv.Sdt=sdt;
        //    return nv;
        //}
        public bool checkValidForm() {
           if(txt_ten.Text.Trim().Length==0 || txt_diachi.Text.Trim().Length==0 || /*txt_chucvu.Text.Trim().Length == 0 ||*/ txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text))
            {
                MessageBox.Show("Tên chỉ được chứa chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsOnlyDigits(txt_sdt.Text)){
                MessageBox.Show("SDT chỉ được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /*
            if (!IsRoleValid(txt_chucvu.Text))
            {
                MessageBox.Show("Phải là 1 trong 4:Nhân viên,Quản lý, Thử thư, Quản lý kho ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */

            if (!checkNgaySinh(dp_ngaysinh.Value))
            {
                MessageBox.Show("Tuổi của NV không chính xác. Tuổi không thể <18", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
            
        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-z ]*$";
            return Regex.IsMatch(str, pattern);
        }
        static bool IsOnlyDigits(string str)
        {
            foreach (char c in str)
            {
                
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        /*
        static bool IsRoleValid(string str)
        {
            string lowercaseStr = str.ToLower();

            return lowercaseStr == "nhân viên" || lowercaseStr == "quản lý" || lowercaseStr == "thủ thư" || lowercaseStr == "quản lý kho";
        }
        */
        public bool checkNgaySinh(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dp_ngaysinh.Value.Year;
            if (dp_ngaysinh.Value.Date > today.AddYears(-age)) age--;
            if (age < 18)
            {
                return false;
            }

            return true;
        }
    }
}
