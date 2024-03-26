using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class LuanVan
    {
        int iDLuanVan;
        string tenLuanVan, giangVien, nenTang, linhVuc, congNghe, yeuCau, chiTiet;
        public LuanVan()
        { 
        }

        public LuanVan(int iDLuanVan, string tenLuanVan, string giangVien, string nenTang, string linhVuc, string congNghe, string yeuCau, string chiTiet)
        {
            this.iDLuanVan = iDLuanVan;
            this.tenLuanVan = tenLuanVan;
            this.giangVien = giangVien;
            this.nenTang = nenTang;
            this.linhVuc = linhVuc;
            this.congNghe = congNghe;
            this.yeuCau = yeuCau;
            this.chiTiet = chiTiet;
        }

        public int IDLuanVan { get => iDLuanVan; set => iDLuanVan = value; }
        public string TenLuanVan { get => tenLuanVan; set => tenLuanVan = value; }
        public string GiangVien { get => giangVien; set => giangVien = value; }
        public string NenTang { get => nenTang; set => nenTang = value; }

        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string CongNghe { get => congNghe; set => congNghe = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string ChiTiet { get => chiTiet; set => chiTiet = value; }
    }
}
