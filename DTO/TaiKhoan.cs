using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    

    public class TaiKhoan
    {
        private string TenDangNhap;
        private string MatKhau;
        private string MaQuyen;

        public TaiKhoan()
        {

        }
        public TaiKhoan(string tenDangNhap, string matKhau, string maQuyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
        }

        public string SGTenDangNhap { get => TenDangNhap; set => TenDangNhap = value; }
        public string SGMatKhau { get => MatKhau; set => MatKhau = value; }
        public string SGMaQuyen { get => MaQuyen; set => MaQuyen = value; }
    }
}
