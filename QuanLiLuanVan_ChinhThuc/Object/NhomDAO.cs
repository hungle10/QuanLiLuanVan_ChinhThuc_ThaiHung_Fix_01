using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    internal class NhomDAO
    {
        public NhomDAO() { }
        public DataTable GetMember(Nhom gr)
        {
            string query = string.Format("Select * from Nhom where IDGroup='{0}'", gr.IDGroup);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
