using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class Chat
    {
        int idTask;
        int idGroup;
        int thuTu;
        int nguoiGui;
        int nguoiNhan;
        string noiDung;

        [Key, Column("IdTask", Order = 0)]
        public int IdTask { get => idTask; set => idTask = value; }
        [Key, Column("IdGroup", Order = 1)]
        public int IdGroup { get => idGroup; set => idGroup = value; }
        [Key, Column("ThuTu", Order = 2)]
        public int ThuTu { get => thuTu; set => thuTu = value; }
        public int NguoiGui { get => nguoiGui; set => nguoiGui = value; }
        public int NguoiNhan { get => nguoiNhan; set => nguoiNhan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }

        public Chat(int idTask, int idGroup, int thuTu, int nguoiGui, int nguoiNhan, string noiDung)
        {
            this.idTask = idTask;
            this.idGroup = idGroup;
            this.thuTu = thuTu;
            this.nguoiGui = nguoiGui;
            this.nguoiNhan = nguoiNhan;
            this.noiDung = noiDung;
        }
        public Chat()
        {

        }
    }
}
