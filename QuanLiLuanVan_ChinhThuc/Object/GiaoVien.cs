using System;
using System.Data;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class GiaoVien : Nguoi
    {
        public GiaoVien(int id, string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email) : base(id, hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
        }
        public GiaoVien()
        {
        }
        public GiaoVien(string hoTen, string diaChi, string khoa, DateTime ngaySinh, string sdt, string email) : base(hoTen, diaChi, khoa, ngaySinh, sdt, email)
        {
        }
        public GiaoVien(DataRow row)
        {
            this.Id = int.Parse(row["ID"].ToString());
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Khoa = row["Khoa"].ToString();
            this.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.Sdt = row["Sdt"].ToString();
            this.Email = row["Email"].ToString();

        }
    }
}
