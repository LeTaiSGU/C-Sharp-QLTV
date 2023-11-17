using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class GUI_Sach : Form
    {
        string name = "Muon sach";
        public GUI_Sach()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
           
               
                
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            Panel panel = new Panel();
            panel.Size = new Size(268, 385);
            panel.BackColor = Color.Yellow;

            Panel status = new Panel();

            status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            status.Dock = System.Windows.Forms.DockStyle.Top;
            status.Size = new System.Drawing.Size(268, 7);
            

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(268, 267);
            pictureBox.BackColor = Color.Green;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            };
            pictureBox.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };


            Panel panel2 = new Panel();
            panel2.Size = new Size(268, 118);
            panel2.Dock = DockStyle.Top;
            panel2.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            }; 

            panel2.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };

            Label lbname = new Label();
            lbname.AutoSize = true;
            lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbname.ForeColor = System.Drawing.Color.Black;
            lbname.Location = new System.Drawing.Point(49, 12);
            lbname.Size = new System.Drawing.Size(166, 22);
            lbname.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            };
            lbname.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };


            lbname.Text = "Chiến tranh thế giới";
            lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            Button btnXem = new Button();
            btnXem.BackColor = System.Drawing.Color.Red;
            btnXem.FlatAppearance.BorderSize = 0;
            btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXem.ForeColor = System.Drawing.Color.Black;
            btnXem.Location = new System.Drawing.Point(92, 58);
            btnXem.Size = new System.Drawing.Size(81, 39);
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;

            panel2.Controls.Add(btnXem);
            panel2.Controls.Add(lbname);

            
            panel.Controls.Add(panel2);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(status);
            flowpanelSach.Controls.Add(panel);

            
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            // Xử lý khi chuột vào bất kỳ PictureBox nào
            PictureBox enteredPictureBox = sender as PictureBox;
            if (enteredPictureBox != null)
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            }
        }
        private void mouse_enter(object sender, System.EventArgs e)
        {
            Panel enteredPanel = sender as Panel;
            if (enteredPanel != null)
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            }
            //Control control = (Control)sender;
            
        }

        private void leave(object sender, System.EventArgs e)
        {
            status.BackColor = Color.FromArgb(26, 25, 62);
        }
        

        private void lb_leave(object sender, System.EventArgs e)
        {
            status.BackColor = Color.FromArgb(26, 25, 62);
            lableName.ForeColor = Color.Black;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form w = new GUI_TacGia();
            w.ShowDialog();
            
            
        }

        private void lableName_MouseEnter(object sender, EventArgs e)
        {
            status.BackColor = Color.FromArgb(228, 18, 109);
            lableName.ForeColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ThemTuaSach().Show();
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            flowpanelSach.Controls.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Quanlysach ql = new Quanlysach();
            ql.ShowDialog();
           
        }
    }
}
