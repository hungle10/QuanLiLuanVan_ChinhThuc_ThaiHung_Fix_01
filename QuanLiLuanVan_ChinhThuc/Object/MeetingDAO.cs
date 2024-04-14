using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

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
        public void delete(Meeting mt)
        {
            string queryDK = String.Format("DELETE FROM Meeting WHERE MaMeeting ='{0}'",mt.MaMeeting);
            dBConn.runSql(queryDK);
        }
        public List<Meeting> getListMeeting(string idGiaoVien) 
        {
            List<Meeting> mts = new List<Meeting>();
            string query = String.Format("SELECT * FROM Meeting where IDGiaoVien ='{0}'",idGiaoVien);
            DataTable data = dBConn.Excute(query);
            if (data == null)
            {
                MessageBox.Show("Error");
                return null;
            }
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    Meeting mt = new Meeting();
                    mt.MaMeeting = Convert.ToInt32(row["MaMeeting"]);
                    mt.IdGiaoVien = row["IDGiaoVien"].ToString();
                    mt.IdGroup = row["IDGroup"].ToString();
                    mt.ThoiGian = DateTime.Parse(row["ThoiGian"].ToString());
                    mt.ChiTiet= row["ChiTiet"].ToString();
                    mts.Add(mt);
                }
                return mts;
            }
            return null;
        }  

    }
}
