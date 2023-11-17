using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TacGia
    {
        private String MaTacGia;
        private String TenTacGia;
        private String MoTa;
        private String Image;
        private Boolean TrangThai;

        public TacGia()
        {

        }

        public TacGia(string maTacGia, string tenTacGia, string moTa, string image ,bool trangThai)
        {
            MaTacGia = maTacGia;
            TenTacGia = tenTacGia;
            MoTa = moTa;
            Image = image;
            TrangThai = trangThai;
        }

        public string SGMaTacGia { get => MaTacGia; set => MaTacGia = value; }
        public string SGTenTacGia { get => TenTacGia; set => TenTacGia = value; }
        public string SGMoTa { get => MoTa; set => MoTa = value; }
        public String SGImage { get => Image; set => Image = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
