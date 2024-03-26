using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class Nguoi
    {
        private int id;
        private string hoTen;
        private string diaChi;
        private string khoa;
        private DateTime ngaySinh;
        private string sdt;
        private string email;
        public Nguoi() { }
        public Nguoi(int id, string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.khoa = khoa;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
        }
        public Nguoi(string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.khoa = khoa;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
        }

        public Nguoi(string hoTen, string diaChi, DateTime ngaySinh, string sdt, string email)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        
        public string FormatNgaySinh()
        {
            string s;
            s = ngaySinh.Year.ToString() + "-" + ngaySinh.Month.ToString() + "-" + ngaySinh.Day.ToString();
            return s;
        }
    }

}
