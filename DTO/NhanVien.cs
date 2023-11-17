using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien
    {
        private String MaNhanVien;
        private String TenNV;
        private Boolean GioiTinh;
        private DateTime NgaySinh;
        private String DiaChi;
        private String ChucVu;
        private String SDT;
        private String Image;
        private Boolean TrangThai;

        public NhanVien()
        {

        }

        public NhanVien(string maNhanVien, string tenNV, bool gioiTinh, DateTime ngaySinh, string diaChi, string chucVu, string sDT, string image, bool trangThai)
        {
            MaNhanVien = maNhanVien;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            ChucVu = chucVu;
            SDT = sDT;
            Image = image;
            TrangThai = trangThai;
        }

        public string SGMaNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public string SGTenNV { get => TenNV; set => TenNV = value; }
        public DateTime SGNgaySinh { get => NgaySinh; set => NgaySinh = value; }
        public bool SGGioiTinh { get => GioiTinh; set => GioiTinh = value; }
        public string SGDiaChi { get => DiaChi; set => DiaChi = value; }
        public string SGChucVu { get => ChucVu; set => ChucVu = value; }
        public string SGSDT { get => SDT; set => SDT = value; }
        public string SGImage { get => Image; set => Image = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
