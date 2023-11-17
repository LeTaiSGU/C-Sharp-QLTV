using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using Excel=Microsoft.Office.Interop.Excel;


namespace GUI
{
    public partial class GUI_NhanVien : Form
    {

        //NhanVienBUS bus = new NhanVienBUS();
        public GUI_NhanVien()
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
            cb_gioiTinh.SelectedIndex = 0;
            cb_trangThai.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void ThongTin1_Clicked(object sender, EventArgs e)
        {
            //frmSuaNhanVien frmSua = new frmSuaNhanVien();
            //var thongTin1 = sender as NhanVienUserControl;
            //string maNV = thongTin1.MaNV;
            //NhanVienDTO nv = new NhanVienDTO();
            //nv=bus.getNhanVienByMa(maNV);
            //frmSua.setThongTin(nv);
            //frmSua.btn_CapNhat_Clicked += btn_CapNhat_Clicked;
            //frmSua.ShowDialog();
        }
       
        //public void generateItems()
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    List<NhanVienDTO> list = new List<NhanVienDTO>();
        //    list = bus.getAllNhanVien();
        //    NhanVienUserControl[] items = new NhanVienUserControl[list.Count];    
        //    for ( int i = 0; i < list.Count; i++)
        //    {
        //        items[i]=new NhanVienUserControl();
        //        items[i].MaNV = list[i].MaNhanVien;
        //        items[i].TenNV = list[i].TenNhanVien;
        //        items[i].DiaChi = list[i].DiaChi;
        //        items[i].Sdt = list[i].Sdt;
        //        items[i].Icon = list[i].Img;
        //        items[i].setThongTin();
        //        flowLayoutPanel1.Controls.Add(items[i]);
        //        items[i].ThongTin1Clicked += ThongTin1_Clicked;
        //    }
        //}
        public void btn_CapNhat_Clicked(object sender, EventArgs e)
        {
            //generateItems();
            //if (sender is frmSuaNhanVien)
            //{
            //    var frmSua = sender as frmSuaNhanVien;
            //    frmSua.Close();
            //}
        }
        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            //generateItems();
            //if (sender is formThemNhanVien)
            //{
            //    var frmThem = sender as formThemNhanVien;
            //    frmThem.Close();
            //}
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            formThemNhanVien frmThem = new formThemNhanVien();
            frmThem.btn_Them_Clicked +=btn_Them_Clicked;
            frmThem.ShowDialog();
        }

        private void cb_gioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //executeSearch();
        }
        //public void generateItems(List<NhanVienDTO> list)
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    NhanVienUserControl[] items = new NhanVienUserControl[list.Count];
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        items[i] = new NhanVienUserControl();
        //        items[i].MaNV = list[i].MaNhanVien;
        //        items[i].TenNV = list[i].TenNhanVien;
        //        items[i].DiaChi = list[i].DiaChi;
        //        items[i].Sdt = list[i].Sdt;
        //        items[i].Icon = list[i].Img;
        //        items[i].setThongTin();
        //        flowLayoutPanel1.Controls.Add(items[i]);
        //        items[i].ThongTin1Clicked += ThongTin1_Clicked;
        //    }
        //}
        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            //executeSearch();
        }
        //private void cb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    executeSearch();
        //}
        //public void executeSearch()
        //{
        //    string searchText = txt_timKiem.Text.ToLower();
        //    string searchCriteria = cb_timKiem.SelectedItem.ToString();
        //    //string selectedGioiTinh = cb_gioiTinh.SelectedItem.ToString();
        //    //List<NhanVienDTO> list = bus.getAllNhanVien();
        //    list = list.Where(nv =>
        //        (searchCriteria == "Mã" && nv.MaNhanVien.ToLower().Contains(searchText.ToLower())) ||
        //        (searchCriteria == "Tên" && nv.TenNhanVien.ToLower().Contains(searchText.ToLower())) ||
        //        (searchCriteria == "Chức vụ" && nv.ChucVu.ToLower().Contains(searchText.ToLower()))
        //    ).ToList();
        //    if (cb_gioiTinh.SelectedIndex==1)
        //    {
        //        bool genderFilter = true;
        //        list = list.Where(nv => nv.GioiTinh == genderFilter).ToList();
        //    }
        //    else if (cb_gioiTinh.SelectedIndex == 2)
        //    {
        //        bool genderFilter = false;
        //        list = list.Where(nv => nv.GioiTinh == genderFilter).ToList();
        //    }
        //    if (cb_trangThai.SelectedIndex==1)
        //    {
        //        bool statusFilter = true;
        //        list = list.Where(nv => nv.TrangThai == statusFilter).ToList();
        //    }
        //    else if (cb_trangThai.SelectedIndex == 2)
        //    {
        //        bool statusFilter = false;
        //        list = list.Where(nv => nv.TrangThai == statusFilter).ToList();
        //    }
        //    generateItems(list);
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //executeSearch();
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //executeSearch();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cb_gioiTinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
