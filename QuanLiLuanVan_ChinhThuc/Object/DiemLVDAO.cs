﻿using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class DiemLVDAO
    {
        public DiemLVDAO() { }
        public void Add(DiemLV diemLV)
        {
            string query = string.Format("Insert into DiemLV values({0},{1},'{2}')", diemLV.IDLuanVan, diemLV.Diem, diemLV.NhanXet);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
            {
                MessageBox.Show("Cham diem that bai !");
                return;
            }
            else
                MessageBox.Show("Cham diem thanh cong !");
        }
        public bool CheckDiem(LuanVan lv)
        {
            string query = string.Format("Select * from DiemLV where IDLuanVan={0}", lv.IDLuanVan);
            DataTable dt=DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return true;
            else return false;
        }
        public float GetDiemByLV(LuanVan lv)
        {
            string query = string.Format("Select * from DiemLV where IDLuanVan={0}", lv.IDLuanVan);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            float diem = float.Parse(dt.Rows[0]["Diem"].ToString());
            return diem;
        }

    }
}