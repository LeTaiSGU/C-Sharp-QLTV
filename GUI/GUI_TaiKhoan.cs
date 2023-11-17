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
    public partial class GUI_TaiKhoan : Form
    {
        public GUI_TaiKhoan()
        {
            InitializeComponent();
            iconButton3.Click += IconButton3_Click;
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
        }

        private void GUI_TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
