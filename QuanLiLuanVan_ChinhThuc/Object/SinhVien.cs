using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class SinhVien : Nguoi
    {
        private string chuyenNganh;
        private string lop;
        private int khoaHoc;
        public SinhVien()
        { }
        public SinhVien(int id, string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email) : base(id, hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
        }
        public SinhVien(int id, string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email, string chuyenNganh, string lop, int khoaHoc) : base(id, hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
            Id = id;
            HoTen = hoTen;
            DiaChi = diaChi;
            Khoa = khoa;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            Email = email;
            ChuyenNganh = chuyenNganh;
            Lop = lop;
            KhoaHoc = (int)khoaHoc;
        }
        public SinhVien(string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email, string chuyenNganh, string lop, int khoaHoc) : base(hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            Khoa = khoa;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            Email = email;
            ChuyenNganh = chuyenNganh;
            Lop = lop;
            KhoaHoc = (int)khoaHoc;
        }

        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public string Lop { get => lop; set => lop = value; }
        public int KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
    }
}
