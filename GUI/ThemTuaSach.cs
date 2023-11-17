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
    public partial class ThemTuaSach : Form
    {
        public ThemTuaSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của hộp thoại
            openFileDialog.Title = "Chọn hình ảnh";
            openFileDialog.Filter = "Ảnh|*.png;*.jpg;*.jpeg;*.gif|Tất cả các tệp|*.*";

            // Chỉ cho phép chọn một tệp
            openFileDialog.Multiselect = false;

            // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn hình hay chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                string selectedImagePath = openFileDialog.FileName;

                // Thực hiện các xử lý với đường dẫn hình ảnh ở đây
                // Ví dụ: hiển thị đường dẫn trong một TextBox
                pictureBox1.ImageLocation = selectedImagePath;
            }
        }
    }
}
