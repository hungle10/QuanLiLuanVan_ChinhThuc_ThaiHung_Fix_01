using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc
{
    public class DiemLV
    {
        private int iDLuanVan;
        private float diem;
        private string nhanXet;
        private int iDGroup;
        private int iDSinhVien;

        public DiemLV(int iDLuanVan, float diem, string nhanXets)
        {
            this.iDLuanVan = iDLuanVan;
            this.diem = diem;
            this.nhanXet = nhanXet;
        }
        public DiemLV(int iDSinhVien)
        {
            this.iDSinhVien = iDSinhVien;
        }

        public DiemLV(int iDLuanVan, float diem, string nhanXet, int iDGroup, int iDSinhVien)
        {
            this.iDLuanVan = iDLuanVan;
            this.diem = diem;
            this.nhanXet = nhanXet;
            this.iDGroup = iDGroup;
            this.iDSinhVien = iDSinhVien;
        }

        public int IDLuanVan { get => iDLuanVan; set => iDLuanVan = value; }
        public float Diem { get => diem; set => diem = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
        public int IDGroup { get => iDGroup; set => iDGroup = value; }
        public int IDSinhVien { get => iDSinhVien; set => iDSinhVien = value; }
    }
}
