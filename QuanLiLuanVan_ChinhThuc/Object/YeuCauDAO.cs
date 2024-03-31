using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiLuanVan_ChinhThuc.GV;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class YeuCauDAO
    {
        DBConnection dBConn = new DBConnection();
        public void add(string IDGroup,int IDluanvan,string noidung,int tinhtrang)
        {
            string query = String.Format("INSERT INTO YeuCau VALUES ('{0}','{1}','{2}','{3}')", IDGroup, IDluanvan,noidung,tinhtrang); 
            dBConn.runSql(query);
        }
        public void delete(string IDGroup, int IDluanvan)
        {
            string query = String.Format("DELETE FROM YeuCau WHERE IDGroup ='{0}' AND IDLuanVan='{1}'", IDGroup, IDluanvan);
            dBConn.runSql(query);
        }
        public void update(int tinhtrang,string IDGroup, int idluanvan,string noidung)
        {
            string query = String.Format("UPDATE dbo.YeuCau SET TinhTrang = '{0}' WHERE IDGroup = '{1}' AND IDLuanVan = '{2}'AND YeuCau='{3}'", tinhtrang, IDGroup, idluanvan,noidung);
            dBConn.runSql(query);
        }
        public List<YeuCau> getYeuCau(string id)
        {
            List<YeuCau> ycs= new List<YeuCau>();       
            string query = String.Format("SELECT IDGroup,IDLuanVan,YeuCau,TinhTrang FROM YeuCau WHERE IDGroup = {0}", id);
            DataTable data = dBConn.Excute(query);
            if (data == null)
            {
                MessageBox.Show("Error, cannot find id " + id);
                return null;
            }
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    YeuCau yeucau = new YeuCau();
                    yeucau.IdGroup = row["IDGroup"].ToString();
                    yeucau.IdLuanVan = Convert.ToInt32(row["IDluanVan"]);
                    yeucau.NoiDungYeuCau = row["YeuCau"].ToString();
                    yeucau.TinhTrang = Convert.ToInt32(row["TinhTrang"]);
                    ycs.Add(yeucau);   
                   
                }
                return ycs;     
            }
            else return null;
        }

    }
}
