using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc
{
    internal class Admin : Nguoi
    {
        public Admin(int id, string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email) : base(id, hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
        }
        public Admin(string hoTen, string diaChi, DateTime ngaySinh, string sdt, string email) : base(hoTen, diaChi, ngaySinh, sdt, email)
        {
        }
    }
}
