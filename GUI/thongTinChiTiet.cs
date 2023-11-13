using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class thongTinChiTiet : Form
    {
        public thongTinChiTiet()
        {
            InitializeComponent();
        }
        public void setThongTin(string maNV)
        {
            NhanVien a = new NhanVien();
            NhanVien nv = a.get1NhanVienByMa(maNV); // Use correct method name
            DateTime ngaySinh = DateTime.Now;
            pictureBox1.Image = new Bitmap(nv.Img);
            txt_ma.Text = nv.MaNhanVien;
            txt_ten.Text = nv.TenNhanVien;
            txt_sdt.Text = nv.Sdt;
            txt_diachi.Text = nv.DiaChi;
            txt_chucvu.Text = nv.ChucVu;
            dp_ngaysinh.Value = ngaySinh;
            if (nv.GioiTinh == true)
            {
                rd_nam.Checked = true;
            }
            else rd_nu.Checked = true;
            if (nv.TrangThai == true)
            {
                rd_dang.Checked = true;
            }
            else rd_nu.Checked = true;

        }
        private void thongTinChiTiet_Load(object sender, EventArgs e)
        {
               
        }

        private void rd_dang_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        public event EventHandler btn_CapNhat_Clicked;

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            Onbtn_CapNhat_Clicked();
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
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBox1.Image= new Bitmap(selectedImagePath);
                }
            }
        }
    }
}
