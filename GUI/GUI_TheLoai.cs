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
using System.Windows.Markup;

namespace GUI
{
    public partial class GUI_TheLoai : Form
    {
        
        public GUI_TheLoai()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-z ]*$";
            return Regex.IsMatch(str, pattern);
        }
        public bool checkValidForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || rt_moTa.Text.Trim().Length == 0 || (!rd_dang.Checked && !rd_ngung.Checked))
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


        private void btn_them_Click(object sender, EventArgs e)
        {

        }



        private void btn_lamMoi_Click(object sender, EventArgs e)
        {

        }
        public void setModel()
        {

        }

        private void GUI_TheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
