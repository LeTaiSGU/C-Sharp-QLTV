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
    public partial class thongtin2 : UserControl
    {
        public thongtin2()
        {
            InitializeComponent();
            
        }
        #region Properties
        NhanVien nv;

        public NhanVien Nv { get => nv; set => nv = value; }
        public void setThongTin()
        {
            DateTime ngaySinh = DateTime.Now;

             nv = new NhanVien("NV01", "Phuc", true, ngaySinh, "SaiGon", "111", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg");

            pictureBox1.Image = new Bitmap(nv.Img);
            txt_ma.Text = nv.MaNhanVien;
            txt_ten.Text = nv.TenNhanVien;
            txt_sdt.Text = nv.Sdt;
            txt_diachi.Text = nv.DiaChi;
            txt_chucvu.Text = nv.ChucVu;
            dp_ngaysinh.Value= ngaySinh;
            if (nv.GioiTinh == true)
            {
                rd_nam.Checked = true;
            }else rd_nu.Checked = true;
            if (nv.TrangThai == true)
            {
                rd_dang.Checked = true;
            }else rd_nu.Checked=true;
        
        }

        #endregion

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                pictureBox1.Image=new Bitmap(filePath);
            }
        }

        private void thongtin2_Load(object sender, EventArgs e)
        {

        }

    }
}
