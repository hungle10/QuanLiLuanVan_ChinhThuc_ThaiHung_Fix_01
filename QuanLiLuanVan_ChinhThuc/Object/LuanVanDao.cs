using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class LuanVanDao
    {
        DBConnection dBConn = new DBConnection();
        public LuanVan convert(DataRow row)
        {
            LuanVan lv = new LuanVan(
                Int32.Parse(row["IDLuanVan"].ToString()),
                row["TenLuanVan"].ToString(),
                row["GiangVien"].ToString(),
                row["NenTang"].ToString(),
                row["LinhVuc"].ToString(),
                row["CongNghe"].ToString(),
                row["YeuCau"].ToString(),
                row["ChiTiet"].ToString()
                );
            return lv;
        }

        public LuanVan getLastestLuanVan()
        {
            DataTable dt = dBConn.Excute("SELECT * FROM LuanVan WHERE LuanVan.IDLuanVan=(SELECT MAX(IDLuanVan) FROM LuanVan)");
            if(dt.Rows.Count > 0)            
                return convert(dt.Rows[0]);        
            return null;
        }

        public void add(LuanVan luanVan)
        {
            string query = String.Format("INSERT INTO LuanVan(TenLuanVan, GiangVien, NenTang, LinhVuc, CongNghe, YeuCau, ChiTiet) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                luanVan.TenLuanVan, luanVan.GiangVien, luanVan.NenTang, luanVan.LinhVuc, luanVan.CongNghe, luanVan.YeuCau, luanVan.ChiTiet);
            dBConn.runSql(query);
        }

        public void remove(LuanVan luanVan)
        {
            string query = String.Format("DELETE FROM LuanVan WHERE IDLuanVan='{0}'", luanVan.IDLuanVan);
            dBConn.runSql(query);
        }

        public void updateYeuCau(LuanVan luanVan)
        {
            string query = String.Format("UPDATE LuanVan SET YeuCau='{0}' WHERE IDLuanVan='{1}'", luanVan.YeuCau, luanVan.IDLuanVan);
            dBConn.runSql(query);
        }
        public LuanVan GetLVByTenLV(string Name)
        {
            string query = string.Format("Select * from LuanVan where TenLuanVan='{0}'", Name);
            DataTable dt= DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                LuanVan luanvan=new LuanVan();
                luanvan.TenLuanVan = Name;
                MessageBox.Show("Khong tim thay thong tin");
                return luanvan;
            }
            DataRow row = dt.Rows[0];
            LuanVan lv = new LuanVan(int.Parse(row["IDLuanVan"].ToString()), row["TenLuanVan"].ToString(), row["GiangVien"].ToString(), row["NenTang"].ToString(), row["LinhVuc"].ToString(),row["CongNghe"].ToString(), row["YeuCau"].ToString(), row["ChiTiet"].ToString());
            return lv;
        }
        public LuanVan GetLVByIDLV(string ID) 
        {
            string query = string.Format("Select * from LuanVan where IDLuanVan='{0}'", ID);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                LuanVan luanvan = new LuanVan();
                luanvan.TenLuanVan = ID;
                MessageBox.Show("Khong tim thay thong tin");
                return luanvan;
            }
            DataRow row = dt.Rows[0];
            LuanVan lv = new LuanVan(int.Parse(row["IDLuanVan"].ToString()), row["TenLuanVan"].ToString(), row["GiangVien"].ToString(), row["NenTang"].ToString(), row["LinhVuc"].ToString(), row["CongNghe"].ToString(), row["YeuCau"].ToString(), row["ChiTiet"].ToString());
            return lv;
        }
        public LuanVan GetLVByGroup(Nhom n)
        {
            string query = string.Format("Select * from LuanVan inner join DangKi on LuanVan.IDLuanVan=DangKi.IDLuanVan where IDGroup='{0}'", n.IDGroup);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                LuanVan luanvan = new LuanVan();
                MessageBox.Show("Khong tim thay thong tin");
                return luanvan;
            }
            DataRow row = dt.Rows[0];
            LuanVan lv = new LuanVan(int.Parse(row["IDLuanVan"].ToString()), row["TenLuanVan"].ToString(), row["GiangVien"].ToString(), row["NenTang"].ToString(), row["LinhVuc"].ToString(), row["CongNghe"].ToString(), row["YeuCau"].ToString(), row["ChiTiet"].ToString());
            return lv;
        }
        public DataTable GetLVByGiangVien(GiaoVien gv,string key)
        {
            string query = string.Format("SELECT * FROM LuanVan WHERE (LuanVan.IDLuanVan NOT IN (SELECT IDLuanVan FROM Duyet)) and GiangVien like '%{0}%' and TenLuanVan like '%{1}%' ", gv.HoTen,key);
            DataTable dt= DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
