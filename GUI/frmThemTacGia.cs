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
    public partial class frmThemTacGia : Form
    {
        string imgPath = "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\1995571.png";
        //TacGiaBus bus=new TacGiaBus();
        public frmThemTacGia()
        {
            InitializeComponent();
            //setCungMaTacGia();
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
        //public void setCungMaTacGia()
        //{
        //    int sl = bus.getSLTG();
        //    sl = sl + 1;
        //    if(sl < 10 )
        //    {
        //        txt_ma.Text = "TG0" + sl.ToString();
        //    }
        //    else
        //    {
        //        txt_ma.Text = "TG" + sl.ToString();

        //    }
        //    txt_ma.ReadOnly = true;
        //}
        public bool checkValidateForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || richtxt_moTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text))
            {
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
        //    if (rd_dang.Checked)
        //    {
        //        tg.TinhTrang = true;
        //    }
        //    else
        //    {
        //        tg.TinhTrang = false;
        //    }
        //    return tg;
        //}
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-z ]*$";
            return Regex.IsMatch(str, pattern);
        }
        public event EventHandler resetGUIadd;
        public void OnresetGUIadd()
        {
            resetGUIadd?.Invoke(this, EventArgs.Empty);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
