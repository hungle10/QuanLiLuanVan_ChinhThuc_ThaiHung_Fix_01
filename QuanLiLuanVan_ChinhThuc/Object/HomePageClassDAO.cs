using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using QuanLiLuanVan_ChinhThuc.Object;
using System.Runtime.InteropServices.WindowsRuntime;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class HomePageClassDAO
    {
        DBConnection dBConn = new DBConnection();
        public HomePageClass getInfoHomePage(string id)
        {
            string query = String.Format("SELECT TenLuanVan, GiangVien FROM DangKi, LuanVan where DangKi.IDSinhVien = '{0}' AND DangKi.IDLuanVan = LuanVan.IDLuanVan", id);
            DataTable data = dBConn.Excute(query);
            if (data == null)
            {
                MessageBox.Show("Error, cannot find id " + id);
                return null;
            }
            if (data.Rows.Count > 0)
            {
                string tenLuanVan = data.Rows[0]["TenLuanVan"].ToString();
                string giangVien = data.Rows[0]["GiangVien"].ToString();
                HomePageClass hp = new HomePageClass("CNTT", tenLuanVan, giangVien);
                return hp;
            }
            else return null;
        }

    }
}
