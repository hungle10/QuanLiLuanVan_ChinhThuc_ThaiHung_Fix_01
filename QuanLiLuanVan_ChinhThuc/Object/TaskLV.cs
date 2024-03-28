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
        private int idLuanVan;
        private string noiDung;
        private DateTime thoiHan;
        private int trangThai;

        public TaskLV(int maTask,int trangThai)
        {
            this.maTask=maTask;
            this.trangThai=trangThai;
        }
        public TaskLV(int idLuanVan, string noiDung, DateTime thoiHan, int trangThai)
        {
            this.idLuanVan= idLuanVan;
            this.noiDung = noiDung;
            this.thoiHan = thoiHan;
            this.trangThai = trangThai;
        }

        public TaskLV(int maTask, int idLuanVan, string noiDung, DateTime thoiHan, int trangThai)
        {
            this.maTask = maTask;
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
    }
}
