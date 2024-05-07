using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class Duyet
    {
        int idLuanVan;
        string idSinhVien;
        public Duyet()
        {
        }

        public Duyet(int idLuanVan, string idSinhVien)
        {
            this.idLuanVan = idLuanVan;
            this.idSinhVien = idSinhVien;
        }
        [Key, Column(Order = 0)]
        public int IdLuanVan { get => idLuanVan; set => idLuanVan = value; }
        [Key, Column(Order = 1)]
        public string IdSinhVien { get => idSinhVien; set => idSinhVien = value; }
    }
}
