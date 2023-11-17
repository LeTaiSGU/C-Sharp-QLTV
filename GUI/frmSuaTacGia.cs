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

    public partial class frmSuaTacGia : Form
    {
        string imgPath;
        //TacGiaBus bus=new TacGiaBus();
        public frmSuaTacGia()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaTacGia_Load(object sender, EventArgs e)
        {
        }
        //public void setThongTin(TacGiaDTO tg)
        //{
            
        //    txt_ma.Text = tg.MaTG;
        //    txt_ma.ReadOnly= true;
        //    txt_ten.Text = tg.TenTG;
        //    if (tg.TinhTrang)
        //    {
        //        rd_dang.Checked= true;
        //    }
        //    else
        //    {
        //        rd_dung.Checked= true;
        //    }
        //    imgPath = tg.Img;
        //    pictureBox1.Image = new Bitmap(tg.Img);
        //    richtxt_moTa.Text = tg.MoTa;
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        public event EventHandler resetGUI;
        public void OnresetGUI()
        {
            resetGUI?.Invoke(this, EventArgs.Empty);

        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }
        public bool checkValidateForm()
        {
            if (txt_ten.Text.Trim().Length == 0|| richtxt_moTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text)){
                MessageBox.Show("Tên chỉ được chứa chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //public TacGiaDTO getModel()
        //{
        //    TacGiaDTO tg = new TacGiaDTO();
        //    string ten = txt_ten.Text;
        //    ten = ten.Trim();
        //    ten = Regex.Replace(ten, @"\s+", " ");
        //    string moTa = richtxt_moTa.Text; moTa = moTa.Trim(); moTa = Regex.Replace(moTa, @"\s+", " ");
        //    tg.MaTG = txt_ma.Text;
        //    tg.TenTG = ten;
        //    tg.MoTa = moTa;
        //    tg.Img = imgPath;
        //    if(rd_dang.Checked)
        //    {
        //        tg.TinhTrang = true;
        //    }
        //    else
        //    {
        //        tg.TinhTrang=false;
        //    }
        //    return tg;
        //}
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-z ]*$";
            return Regex.IsMatch(str, pattern);
        }

    }
}
