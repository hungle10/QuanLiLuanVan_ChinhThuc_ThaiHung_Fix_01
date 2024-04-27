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
            string query = String.Format("SELECT * FROM DangKi inner join Nhom on Nhom.IdGroup=DangKi.IdGroup inner join GiaoVien on GiaoVien.ID = DangKi.IDGiangVien inner join LuanVan on LuanVan.IDLuanVan=DangKi.IDLuanVan where MemberName={0}", id);
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
