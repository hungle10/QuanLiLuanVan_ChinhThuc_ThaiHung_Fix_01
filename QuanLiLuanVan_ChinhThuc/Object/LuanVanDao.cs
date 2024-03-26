﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}