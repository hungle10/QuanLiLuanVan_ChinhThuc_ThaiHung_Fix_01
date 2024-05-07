using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class NhomDAO
    {
        public NhomDAO() { }
        public DataTable GetMember(Nhom gr)
        {
            string query = string.Format("Select * from Nhom where IDGroup='{0}'", gr.IDGroup);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public int GetIDGroupByMemBer(SinhVien sv)
        {
            string query = string.Format("Select IDGroup from Nhom where MemberName='{0}'", sv.Id.ToString());
            object ob = DataProvider.Instance.ExecuteScalar(query);
            if(ob != null) 
            {
                return Convert.ToInt32(ob);
            }
            else { return -1; }
        }

        public int GetIDGroupByMemBerID(int id)
        {
            string query = string.Format("Select IDGroup from Nhom where MemberName='{0}'", id);
            object ob = DataProvider.Instance.ExecuteScalar(query);
            if (ob != null)
            {
                return Convert.ToInt32(ob);
            }
            else { return -1; }
        }
    }
}
