using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class MeetingDAO
    {
        DBConnection dBConn = new DBConnection();
        public void add(Meeting mt)
        {
            string queryDK = String.Format("INSERT INTO Meeting(IDGiaoVien, IDGroup, ThoiGian , ChiTiet) VALUES('{0}', '{1}', '{2}' ,'{3}')",
               mt.IdGiaoVien, mt.IdGroup, mt.ThoiGian ,mt.ChiTiet);
            dBConn.runSql(queryDK);
        }
    }
}
