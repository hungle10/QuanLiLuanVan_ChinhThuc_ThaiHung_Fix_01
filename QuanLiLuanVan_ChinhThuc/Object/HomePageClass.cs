using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class HomePageClass
    {
        private string tenDeTai;
        private string tenDoAn;
        private string giaoVien;
        public string TenDeTai
        {
            get { return tenDeTai; } 
            set { tenDeTai = value; }       
        }
        public string TenDoAn
        {
            get { return tenDoAn; }
            set { tenDoAn = value; }
        }
        public string GiaoVien
        {
            get { return giaoVien; }
            set { giaoVien = value; }
        }
        public HomePageClass(string tenDeTai, string tenDoAn, string giaoVien)
        {
            TenDeTai = tenDeTai;
            TenDoAn = tenDoAn;
            GiaoVien = giaoVien;
        }
    }
}
