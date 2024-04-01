using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class Nhom
    {
        private int iDGroup;
        private string memberName;

        public Nhom(int iDGroup, string memberName)
        {
            this.iDGroup = iDGroup;
            this.memberName = memberName;
        }
        public Nhom(int iDGroup)
        {
            this.iDGroup = iDGroup;
        }

        public int IDGroup { get => iDGroup; set => iDGroup = value; }
        public string MemberName { get => memberName; set => memberName = value; }
    }
}
