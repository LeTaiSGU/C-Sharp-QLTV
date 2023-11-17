using BUS;
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
    public partial class GUI_TacGia : Form
    {
        //TacGiaBus bus = new TacGiaBus();
        public GUI_TacGia()
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
            cb_trangThai.SelectedIndex= 0; 
            
        }
        public void resetGUI(object sender, EventArgs e)
        {

        }
        private void GUI_TacGia_Load(object sender, EventArgs e)
        {
            //generateItems();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThem = new frmThemTacGia();
            //frmThem.resetGUIadd += resetGUIadd;
            frmThem.ShowDialog();
        }
        public void executeSearch()
        {
            
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void cb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_TacGia_Load_1(object sender, EventArgs e)
        {

        }
    }
}
