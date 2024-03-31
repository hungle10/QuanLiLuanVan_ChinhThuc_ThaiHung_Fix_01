using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class YeuCau
    {
        private string idGroup;
        private string idSinhVien;
        private int idLuanVan;
        private string noiDungYeuCau;
        private int tinhTrang;
        public string IdSinhVien
        {
            get { return idSinhVien; }      
            set { idSinhVien = value;}      
        }
        public string IdGroup
        {
            get { return idGroup; }
            set { idGroup = value; }
        }
        public int IdLuanVan
        {
            get { return idLuanVan; }
            set { idLuanVan = value; }
        }
        public string NoiDungYeuCau
        {
            get { return noiDungYeuCau; }
            set { noiDungYeuCau = value; }
        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public YeuCau()
        {

        }
        public YeuCau(string idGroup, int idLuanVan, string yeuCau, int tinhTrang)
        {
            this.IdGroup = idGroup;
            this.IdLuanVan = idLuanVan;
            this.NoiDungYeuCau = yeuCau;
            this.TinhTrang = tinhTrang;
        }       
    }
}
