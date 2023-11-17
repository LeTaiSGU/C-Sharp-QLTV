using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_NCC : Form
    {
        public GUI_NCC()
        {
            InitializeComponent();
            iconButton2.Click += IconButton2_Click;
           /* textBox2.KeyDown += TextBox.KeyDown;
            textBox3.KeyDown += TextBox.KeyDown;
            textBox3.KeyDown += TextBox.KeyDown;
            textBox3.KeyDown += TextBox.KeyDown;*/

        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            //lấy giá trị từ textbox
            string dataToAdd = textBox1.Text;
            string dataToAdd2 = textBox2.Text;
            string dataToAdd3 = textBox3.Text;
            string dataToAdd4 = textBox4.Text;
            //Kiểm tra nếu textbox không trống
            if (!string.IsNullOrEmpty(dataToAdd) && !string.IsNullOrEmpty(dataToAdd2) && !string.IsNullOrEmpty(dataToAdd3) && !string.IsNullOrEmpty(dataToAdd4))
            {
                if(IsValidEmail(dataToAdd4)){
                    //Thêm dữ liệu vào dataGridView
                    dataGridView1.Rows.Add(dataToAdd);
                    dataGridView1.Rows.Add(dataToAdd2);
                    dataGridView1.Rows.Add(dataToAdd3);
                    dataGridView1.Rows.Add(dataToAdd4);
                    //xóa nội dung của texbox sau khi lấy dữ liệu
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("vui lòng nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }  
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

        }

        private static bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra xem email có phù hợp với biểu thức chính quy không
            return Regex.IsMatch(email, pattern);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
