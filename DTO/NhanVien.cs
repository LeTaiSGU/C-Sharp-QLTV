using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        string maNhanVien;
        string tenNhanVien;
        bool gioiTinh;
        DateTime ngaySinh;
        string diaChi;
        string sdt;
        string chucVu;
        bool trangThai;
        string img;

        public NhanVien()
        {
        }

        public NhanVien(string maNhanVien, string tenNhanVien, bool gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string chucVu, bool trangThai, string img)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.ChucVu = chucVu;
            this.TrangThai = trangThai;
            this.Img = img;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string Img { get => img; set => img = value; }
        public List<NhanVien> getAllNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            DateTime ngaySinh = DateTime.Now;
            NhanVien nv1= new NhanVien("NV01","Phuc",true,ngaySinh,"SaiGon","111","Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\download (1).jpg");
            NhanVien nv2 = new NhanVien("NV02", "Linh", true, ngaySinh, "SaiGon", "111", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\MV5BOWFiYjFkNjAtYjdhMy00NWQwLWFmOWMtMDFkZGUyMDE5NjQ4XkEyXkFqcGdeQXVyMTU3ODQxNDYz._V1_FMjpg_UX1000_.jpg");
            NhanVien nv3 = new NhanVien("NV03", "Huy", true, ngaySinh, "SaiGon", "222", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images (1).jpg");
            NhanVien nv4 = new NhanVien("NV04", "Tien", true, ngaySinh, "SaiGon", "333", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\download.jpg");
            NhanVien nv5 = new NhanVien("NV05", "Phuong", true, ngaySinh, "SaiGon", "444", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg");
            NhanVien nv6 = new NhanVien("NV06", "Bao", true, ngaySinh, "SaiGon", "555", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\991816090-56782878-2.jpg");
            NhanVien nv7 = new NhanVien("NV07", "Chau", true, ngaySinh, "SaiGon", "666", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\david-beckham-nguoi-kiem-rat-nhieu-tien-bang-thuong-hieu-ca-nhan_64e37da7ae3a9.jpg");
            NhanVien nv8 = new NhanVien("NV08", "Thanh", true, ngaySinh, "SaiGon", "77", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg");
            NhanVien nv9 = new NhanVien("NV09", "Van", true, ngaySinh, "SaiGon", "888", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg");
            NhanVien nv10 = new NhanVien("NV10", "Anh", true, ngaySinh, "SaiGon", "999", "Nhan vien", true, "C:\\Users\\defaultuser0.LAPTOP-POTNR7PE\\source\\repos\\C-Sharp-QLTV\\GUI\\Resources\\images.jpg");
            list.Add(nv1);
            list.Add(nv2);
            list.Add(nv3);
            list.Add(nv4);
            list.Add(nv5);
            list.Add(nv6);
            list.Add(nv7);
            list.Add(nv8);
            list.Add(nv9);
            list.Add(nv10);
            return list;
        } 
    public NhanVien get1NhanVienByMa(string maNV)
        {
            List<NhanVien> list = getAllNhanVien();
            NhanVien a = new NhanVien();
            for(int i = 0;i<list.Count;i++)
            {
                if (list[i].maNhanVien == maNV)
                {
                    a = list[i];
                    break;
                }
            }
            return a;
        }
    }
}
