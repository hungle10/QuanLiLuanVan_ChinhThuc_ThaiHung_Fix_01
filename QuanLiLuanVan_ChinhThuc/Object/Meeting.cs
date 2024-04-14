using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class Meeting
    {
        private int maMeeting;
        private string idGiaoVien;
        private string idGroup;
        private DateTime thoiGian;
        private string chiTiet;

        public Meeting(string idGiaoVien, string idGroup, DateTime thoiGian, string chiTiet)
        {
            this.idGiaoVien = idGiaoVien;
            this.idGroup = idGroup;
            this.thoiGian = thoiGian;
            this.chiTiet = chiTiet;
        }
        public Meeting() { }        

        public int MaMeeting { get => maMeeting; set => maMeeting = value; }
        public string IdGiaoVien { get => idGiaoVien; set => idGiaoVien = value; }
        public string IdGroup { get => idGroup; set => idGroup = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string ChiTiet { get => chiTiet; set => chiTiet = value; }
    }
}
