using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc
{
    public class DataStorage
    {
        static DBConnection dBConn = new DBConnection();
        public static LuanVan luanVan { get; set; }
        public static Nhom nhom { get; set; }
        public static DiemLV diemLV { get; set ;}
        public static FormWatchDetailOfDeTai fDetailDeTai { get; set; }
        public static fDSNhom fDSNhom { get; set; }
        public static int? getIDGroupByIDSinhVien()
        {
           string query = String.Format("SELECT IDGroup FROM DangKi WHERE IDSinhVien='{0}'", UserInfo.sinhVien.Id.ToString());
           DataTable data = dBConn.ExcuteQuery(query);
            if (data!=null)
            {
                foreach (DataRow row in data.Rows)
                {
                     return Int32.Parse(row["IDGroup"].ToString());
                }
            }
            return null;
        }
    }
}
