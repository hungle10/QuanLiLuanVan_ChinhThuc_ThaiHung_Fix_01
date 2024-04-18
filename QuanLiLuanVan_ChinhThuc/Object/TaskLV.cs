using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc
{
    public class TaskLV
    {
        private int maTask;
        private int iDGroup;
        private int idLuanVan;
        private string noiDung;
        private DateTime thoiHan;
        private int tienDo;
        private int iDSinhVien;
        public TaskLV(int maTask)
        {
            this.maTask = maTask;
        }

        public TaskLV(int maTask,int tienDo,int iDSinhVien)
        {
            this.maTask=maTask;
            this.tienDo=tienDo;
            this.iDSinhVien=iDSinhVien;
        }
        public TaskLV(int iDGroup,int idLuanVan, string noiDung, DateTime thoiHan, int tienDo)
        {
            this.iDGroup=iDGroup;  
            this.idLuanVan= idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.tienDo = tienDo;
        }

        public TaskLV(int maTask, int iDGroup, int idLuanVan, string noiDung, DateTime thoiHan, int tienDo,int iDSinhVien)
        {
            this.maTask = maTask;
            this.iDGroup = iDGroup;
            this.idLuanVan = idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.tienDo = tienDo;
            this.iDSinhVien= iDSinhVien;
        }
        public TaskLV(int maTask, int iDGroup, int idLuanVan, string noiDung, DateTime thoiHan, int tienDo)
        {
            this.maTask = maTask;
            this.iDGroup = iDGroup;
            this.idLuanVan = idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.tienDo = tienDo;
        }

        public string FormatNgay()
        {
            string s;
            s = thoiHan.Year.ToString() + "-" + thoiHan.Month.ToString() + "-" + thoiHan.Day.ToString();
            return s;
        }
        public int MaTask { get => maTask; set => maTask = value; }
        public int IdLuanVan { get => idLuanVan; set => idLuanVan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime ThoiHan { get => thoiHan; set => thoiHan = value; }
        public int TienDo { get => tienDo; set => tienDo= value; }
        public int IDGroup { get => iDGroup; set => iDGroup = value; }
        public int IDSinhVien { get => iDSinhVien; set => iDSinhVien = value; }
    }
}
