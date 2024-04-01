using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class DiemLV
    {
        private int iDLuanVan;
        private float diem;
        private string nhanXet;

        public DiemLV(int iDLuanVan, float diem, string nhanXets)
        {
            this.iDLuanVan = iDLuanVan;
            this.diem = diem;
            this.nhanXet = nhanXet;
        }

        public int IDLuanVan { get => iDLuanVan; set => iDLuanVan = value; }
        public float Diem { get => diem; set => diem = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
    }
}
