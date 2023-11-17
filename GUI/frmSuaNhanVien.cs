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
    public partial class frmSuaNhanVien : Form
    {
        string imgPath;
        //NhanVienBUS bus= new NhanVienBUS();
        public frmSuaNhanVien()
        {
            InitializeComponent();

        }
        //public void setThongTin(string maNV)
        //{
        //    NhanVienDTO a = new NhanVienDTO();
        //    NhanVienDTO nv = a.get1NhanVienByMa(maNV); // Use correct method name
        //    DateTime ngaySinh = DateTime.Now;
        //    pictureBox1.Image = new Bitmap(nv.Img);
        //    txt_ma.Text = nv.MaNhanVien;
        //    txt_ten.Text = nv.TenNhanVien;
        //    txt_sdt.Text = nv.Sdt;
        //    txt_diachi.Text = nv.DiaChi;
        //    txt_chucvu.Text = nv.ChucVu;
        //    dp_ngaysinh.Value = ngaySinh;
        //    if (nv.GioiTinh == true)
        //    {
        //        rd_nam.Checked = true;
        //    }
        //    else rd_nu.Checked = true;
        //    if (nv.TrangThai == true)
        //    {
        //        rd_dang.Checked = true;
        //    }
        //    else rd_nu.Checked = true;

        //}
        private void thongTinChiTiet_Load(object sender, EventArgs e)
        {
               
        }

        private void rd_dang_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        public event EventHandler btn_CapNhat_Clicked;

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            //if (checkValidForm())
            //{
            //    NhanVienDTO nv = getModel();
            //    if (bus.updateNhanVien(nv) > 0)
            //    {
            //        MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Onbtn_CapNhat_Clicked();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }
        private void Onbtn_CapNhat_Clicked()
        {
            btn_CapNhat_Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgPath = openFileDialog.FileName;
                    pictureBox1.Image = new Bitmap(imgPath);
                }
            }
        }
        //public void setThongTin(NhanVienDTO nv)
        //{
        //    txt_ma.Text = nv.MaNhanVien;
        //    txt_ma.ReadOnly = true;
        //    txt_ten.Text = nv.TenNhanVien;
        //    if (nv.GioiTinh)
        //    {
        //        rd_nam.Checked= true;
        //    }
        //    else
        //    {
        //        rd_nu.Checked = true;
        //    }
        //    dp_ngaysinh.Value = nv.NgaySinh;
        //    txt_diachi.Text = nv.DiaChi;
        //    txt_sdt.Text = nv.Sdt;
        //   // txt_chucvu.Text = nv.ChucVu;
        //    if (nv.TrangThai)
        //    {
        //        rd_dang.Checked = true;
        //    }else { rd_nghi.Checked = true;}
        //    pictureBox1.Image = new Bitmap(nv.Img);
        //    imgPath = nv.Img;
        //    string chucVu = nv.ChucVu.ToLower();
        //    int indexChucVu=-1;
        //    if(chucVu=="nhân viên")
        //    {
        //        indexChucVu = 0;
        //    }
        //    else if(chucVu=="quản lý")
        //    {
        //        indexChucVu = 1;

        //    }
        //    else if (chucVu == "thủ thư")
        //    {
        //        indexChucVu = 2;

        //    }
        //    else if (chucVu == "quản lý kho")
        //    {
        //        indexChucVu = 3;

        //    }
        //    cb_role.SelectedIndex = indexChucVu;
        //}
        //public NhanVienDTO getModel()
        //{
        //    NhanVienDTO nv = new NhanVienDTO();
        //    string ten = txt_ten.Text;
        //    string diaChi = txt_diachi.Text;
        //    string sdt = txt_sdt.Text;
        //  //  string chucVu = txt_chucvu.Text;
        //    ten = ten.Trim();
        //    diaChi = diaChi.Trim();
        //    sdt = sdt.Trim();
        //  //  chucVu = chucVu.Trim();
        //    ten = Regex.Replace(ten, @"\s+", " ");
        //    diaChi = Regex.Replace(diaChi, @"\s+", " ");
        //    sdt = Regex.Replace(sdt, @"\s+", " ");
        //   // chucVu = Regex.Replace(chucVu, @"\s+", " ");

        //    nv.MaNhanVien = txt_ma.Text;
        //    nv.TenNhanVien = ten;
        //    if (rd_nam.Checked)
        //    {
        //        nv.GioiTinh = true;
        //    }
        //    else
        //    {
        //        nv.GioiTinh = false;
        //    }
        //    nv.NgaySinh = dp_ngaysinh.Value;
        //    nv.DiaChi = diaChi;
        //    if (rd_dang.Checked)
        //    {
        //        nv.TrangThai = true;
        //    }
        //    else
        //    {
        //        nv.TrangThai = false;
        //    }
        //    nv.ChucVu = cb_role.SelectedItem.ToString();
        //    nv.Img = imgPath ;
        //    nv.Sdt = sdt;
        //    return nv;
        //}
        public bool checkValidForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || txt_diachi.Text.Trim().Length == 0 ||/* txt_chucvu.Text.Trim().Length == 0 ||*/ txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text))
            {
                MessageBox.Show("Tên chỉ được chứa chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsOnlyDigits(txt_sdt.Text))
            {
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
        static bool IsRoleValid(string str)
        {
            string lowercaseStr = str.ToLower();

            return lowercaseStr == "nhân viên" || lowercaseStr == "quản lý" || lowercaseStr == "thủ thư" || lowercaseStr == "quản lý kho";
        }
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
