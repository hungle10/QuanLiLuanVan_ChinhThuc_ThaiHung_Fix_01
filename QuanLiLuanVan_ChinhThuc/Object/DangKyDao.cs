using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiLuanVan_ChinhThuc.GV;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Forms;


namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class DangKyDao
    {
        DBConnection dBConn = new DBConnection();
        public int GetIDSvienByLV(LuanVan lv)
        {
            string query = string.Format("Select IDSinhVien from DangKi Where IDLuanVan={0}", lv.IDLuanVan);
            object ob = DataProvider.Instance.ExecuteScalar(query);
            if (ob == null)
            { return 0; }
            else { return Convert.ToInt32(ob); }
        }
        public void add(DangKy dk)
        {
            string queryDK = String.Format("INSERT INTO DangKi(IDSinhVien, IDLuanVan, IDGiangVien) VALUES('{0}', '{1}', '{2}')",
               dk.IDSinhVien, dk.IDLuanVan, dk.IDGiangVien);
            dBConn.runSql(queryDK);
        }

        public void addMemberNhom(string[] lines, string id)
        {
            DangKy dk = getFromIDSinhVien(id);
            foreach(string line in lines)
            {
                SinhVienDao dao=new SinhVienDao();
                SinhVien sv=dao.GetSinhVienByName(line);
                string queryDK = String.Format("INSERT INTO Nhom(IDGroup, MemberName) VALUES({0}, '{1}')", dk.IDGroup, sv.Id);
                dBConn.runSql(queryDK);
            }
        }

        public void addDuyet(DangKy dk)
        {
            string queryDK = String.Format("INSERT INTO Duyet(IDLuanVan, IDSinhVien) VALUES({0}, '{1}')",dk.IDLuanVan, dk.IDSinhVien);
            dBConn.runSql(queryDK);
        }

        public void removeDuyet(DangKy dk)
        {
            
            string queryDK = String.Format("DELETE FROM Duyet WHERE IDLuanVan={0} AND IDSinhVien='{1}'", dk.IDLuanVan, dk.IDSinhVien);
            dBConn.runSql(queryDK);
        }

        public String getMemberNhom(DangKy dk)
        {
            string queryDK = String.Format("SELECT * FROM Nhom WHERE IDGroup={0}", dk.IDGroup);
            DataTable dt =  dBConn.Excute(queryDK);
            string nhomStr = "";
            foreach(DataRow row in dt.Rows)
            {
                nhomStr = nhomStr + row["MemberName"]+"\n";
            }
            return nhomStr;
        }
        public DataTable GetDKByGV(GiaoVien gv)
        {
            string query = string.Format("Select * from DangKi Where IDGiangVien='{0}'", gv.Id);
            DataTable dt=DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count == 0 )
            {
                System.Windows.MessageBox.Show("Lay thong tin that bai !");
                return dt;
            }
            return dt;
        }
        public void remove(DangKy dk)
        {
            string query = String.Format("DELETE FROM DangKi WHERE IDSinhVien='{0}' AND IDLuanVan='{1}'", dk.IDSinhVien, dk.IDLuanVan);
            string query2 = String.Format("DELETE FROM Nhom WHERE IDGroup={0}", dk.IDGroup);
            dBConn.runSql(query);
            dBConn.runSql(query2);
        }

        public DangKy getFromIDSinhVien(string id)
        {
            string query = String.Format("SELECT * FROM DangKi WHERE IDSinhVien='{0}'", id);
            DataTable data = dBConn.Excute(query);
           
            if (data.Rows.Count > 0)
            {
                DangKy dk = new DangKy();
                foreach (DataRow row in data.Rows)
                {
                    
                    dk.IDSinhVien = row["IDSinhVien"].ToString();
                    dk.IDLuanVan = Int32.Parse(row["IDLuanVan"].ToString());
                    dk.IDGiangVien = row["IDGiangVien"].ToString();
                    dk.IDGroup = Int32.Parse(row["IDGroup"].ToString());
                }
                return dk;
            }
            return null;
        }

        public bool checkDKDetaiDangDuyet(DangKy dk)
        {
            string query = String.Format("SELECT * FROM Duyet WHERE IDSinhVien='{0}'", dk.IDSinhVien);
            SqlDataReader data = dBConn.runSqlReturn(query);
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public bool nguoiKhacDaDK(DangKy dk)
        {
            string query = String.Format("SELECT * FROM DangKi WHERE IDLuanVan='{0}'", dk.IDLuanVan);
            SqlDataReader data = dBConn.runSqlReturn(query);
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public bool daDK(DangKy dk)
        {
            string query = String.Format("SELECT * FROM DangKi WHERE IDSinhVien='{0}'", dk.IDSinhVien);
            SqlDataReader data = dBConn.runSqlReturn(query);
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public bool checkDK(DangKy dk)
        {
            string query = String.Format("SELECT * FROM DangKi WHERE IDSinhVien='{0}' AND IDLuanVan='{1}'", dk.IDSinhVien, dk.IDLuanVan);
            SqlDataReader data = dBConn.runSqlReturn(query);
            if (data!=null)
            {
                return true;
            }
            return false;
        }
    }
}
