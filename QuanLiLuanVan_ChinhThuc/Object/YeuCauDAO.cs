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
        public void add(string IDsinhvien,int IDluanvan,string noidung,int tinhtrang)
        {
            string query = String.Format("INSERT INTO YeuCau VALUES ('{0}','{1}','{2}','{3}')",IDsinhvien,IDluanvan,noidung,tinhtrang); 
            dBConn.runSql(query);
        }
        public void delete(string IDsinhvien,int IDluanvan)
        {
            string query = String.Format("DELETE FROM YeuCau WHERE IDSinhVien ='{0}' AND IDLuanVan='{1}'", IDsinhvien, IDluanvan);
            dBConn.runSql(query);
        }
        public void update(int tinhtrang,string idsinhvien,int idluanvan,string noidung)
        {
            string query = String.Format("UPDATE dbo.YeuCau SET TinhTrang = '{0}' WHERE IDSinhVien = '{1}' AND IDLuanVan = '{2}'AND YeuCau='{3}'",tinhtrang,idsinhvien,idluanvan,noidung);
            dBConn.runSql(query);
        }
        public List<YeuCau> getYeuCau(string id)
        {
            List<YeuCau> ycs= new List<YeuCau>();       
            string query = String.Format("SELECT IDSinhVien,IDLuanVan,YeuCau,TinhTrang FROM YeuCau WHERE IDSinhVien = {0}", id);
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
                    yeucau.IdSinhVien = row["IDSinhVien"].ToString();
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
