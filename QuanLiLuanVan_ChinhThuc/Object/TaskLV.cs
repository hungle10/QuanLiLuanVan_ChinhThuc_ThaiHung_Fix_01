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
        private int trangThai;
        public TaskLV(int maTask)
        {
            this.maTask = maTask;
        }

        public TaskLV(int maTask,int trangThai)
        {
            this.maTask=maTask;
            this.trangThai=trangThai;
        }
        public TaskLV(int iDGroup,int idLuanVan, string noiDung, DateTime thoiHan, int trangThai)
        {
            this.iDGroup=iDGroup;  
            this.idLuanVan= idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.trangThai = trangThai;
        }

        public TaskLV(int maTask, int iDGroup, int idLuanVan, string noiDung, DateTime thoiHan, int trangThai)
        {
            this.maTask = maTask;
            this.iDGroup = iDGroup;
            this.idLuanVan = idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.trangThai = trangThai;
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
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public int IDGroup { get => iDGroup; set => iDGroup = value; }
    }
}
