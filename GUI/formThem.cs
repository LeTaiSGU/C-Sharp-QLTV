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
    public partial class formThem : Form
    {
        public formThem()
        {
            InitializeComponent();
        }
        public event EventHandler btn_Them_Clicked;
        private void Onbtn_Them_Clicked()
        {
            btn_Them_Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Onbtn_Them_Clicked();
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
                    pictureBox1.Image = new Bitmap(selectedImagePath);
                }
            }
            // kiem tra duong dan
            //if (pictureBox1.Tag != null)
            //{
            //    string imagePath = pictureBox1.Tag.ToString();
            //    MessageBox.Show($"Image Path: {imagePath}", "Image Path Information");
            //}
            //else
            //{
            //    MessageBox.Show("No image is selected.", "Information");
            //}

        }
    }
}
