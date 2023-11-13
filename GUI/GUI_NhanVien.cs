using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class GUI_NhanVien : Form
    {

        public GUI_NhanVien()
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            generateItems();
        }

        private void ThongTin1_Clicked(object sender, EventArgs e)
        {
            thongTinChiTiet ttct = new thongTinChiTiet();
           var thongTin1= sender as thongTin1;
            NhanVien a = thongTin1.getNVByMa();
            if (thongTin1 == null)
            {
                MessageBox.Show("NULL", "Thong bao");
            }
            else
            {
                
                string maNV = a.MaNhanVien;
                ttct.setThongTin(maNV);
            }
            ttct.btn_CapNhat_Clicked += btn_CapNhat_Clicked;
            ttct.ShowDialog();
            
           
        }
        public void btn_CapNhat_Clicked(object sender, EventArgs e)
        {
            generateItems();
            MessageBox.Show("cap nhat  thanh cong", "thong bao");
            if (sender is thongTinChiTiet)
            {
                thongTinChiTiet frmThem = (thongTinChiTiet)sender;
                frmThem.Close();
            }
        }
        public void generateItems()
        {
            NhanVien a = new NhanVien();
            List<NhanVien> list = new List<NhanVien>();
            list = a.getAllNhanVien();
            thongTin1[] items = new thongTin1[list.Count];    
            for ( int i = 0; i < list.Count; i++)
            {
                items[i]=new thongTin1();
                items[i].MaNV = list[i].MaNhanVien;
                items[i].TenNV = list[i].TenNhanVien;
                items[i].DiaChi = list[i].DiaChi;
                items[i].Sdt = list[i].Sdt;
                items[i].Icon = list[i].Img;
                items[i].setThongTin();
                flowLayoutPanel1.Controls.Add(items[i]);
                items[i].ThongTin1Clicked += ThongTin1_Clicked;
            }
        }
        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            generateItems();
            MessageBox.Show("them thanh cong", "thong bao");
            if (sender is formThem)
            {
                formThem frmThem = (formThem)sender;
                frmThem.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            formThem frmThem = new formThem();
            frmThem.btn_Them_Clicked +=btn_Them_Clicked;
            frmThem.ShowDialog();
        }
    }
}
