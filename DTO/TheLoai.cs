using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TheLoai
    {
        private String MaTheLoai;
        private String TenTheLoai;
        private String MoTa;
        private Boolean TrangThai;

        public TheLoai()
        {

        }

        public TheLoai(string maTheLoai, string tenTheLoai, string moTa, bool trangThai)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
            MoTa = moTa;
            TrangThai = trangThai;
        }

        public string SGMaTheLoai { get => MaTheLoai; set => MaTheLoai = value; }
        public string SGTenTheLoai { get => TenTheLoai; set => TenTheLoai = value; }
        public string SGMoTa { get => MoTa; set => MoTa = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
