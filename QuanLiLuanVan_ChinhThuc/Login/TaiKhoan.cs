using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc
{
    public class TaiKhoan
    {
        private int maTK;
        private string hoTen;
        private string email;
        private string matkhau;
        private string loaiTK;

        public int MaTK { get => maTK; set => maTK = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string LoaiTK { get => loaiTK; set => loaiTK = value; }
        public TaiKhoan()
        { }
        public TaiKhoan(string email, string matkhau, string loaiTK)
        {
            this.email = email;
            this.matkhau = matkhau;
            this.loaiTK = loaiTK;
        }
        public TaiKhoan(string hoTen, string email, string matkhau, string loaiTK)
        {
            this.hoTen = hoTen;
            this.email = email;
            this.matkhau = matkhau;
            this.loaiTK = loaiTK;
        }
        public TaiKhoan(string hoTen, string email)
        {
            this.hoTen = hoTen;
            this.email = email;
        }
    }
}
