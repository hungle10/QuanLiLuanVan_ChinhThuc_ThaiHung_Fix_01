using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class DangKy
    {
        string iDSinhVien;
        int iDLuanVan, iDGroup;
        string iDGiangVien;

        public DangKy(string iDSinhVien, int iDLuanVan, string iDGiangVien, int iDGroup)
        {
            this.iDSinhVien = iDSinhVien;
            this.iDLuanVan = iDLuanVan;
            this.iDGiangVien = iDGiangVien;
            this.iDGroup = iDGroup;
        }

        public DangKy(string iDSinhVien, int iDLuanVan, string iDGiangVien)
        {
            this.iDSinhVien = iDSinhVien;
            this.iDLuanVan = iDLuanVan;
            this.iDGiangVien = iDGiangVien;
        }

        public DangKy()
        {
            
        }

        public string IDSinhVien { get => iDSinhVien; set => iDSinhVien = value; }
        public int IDLuanVan { get => iDLuanVan; set => iDLuanVan = value; }
        public string IDGiangVien { get => iDGiangVien; set => iDGiangVien = value; }
        public int IDGroup { get => iDGroup; set => iDGroup = value; }
    }
}
