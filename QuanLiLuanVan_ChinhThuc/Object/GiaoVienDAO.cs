﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    internal class GiaoVienDAO
    {
        static DBConnection dBConn = new DBConnection();
        public GiaoVien GetGVByEmail(string email)
        {
            string query = string.Format("select * from GiaoVien where Email='{0}'", email);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count==0)
            {
                GiaoVien giaovien = new GiaoVien();
                giaovien.Email = email;
                MessageBox.Show("Khong tim thay thong tin giao vien");
                return giaovien;
            }
            DataRow row = dt.Rows[0];
            //GiaoVien gv = new GiaoVien(int.Parse(row["ID"].ToString()), row["HoTen"].ToString(), row["DiaChi"].ToString(), row["Khoa"].ToString(), DateTime.Parse(row["NgaySinh"].ToString()), row["Sdt"].ToString(),row["Email"].ToString());
            GiaoVien gv = new GiaoVien(row);
            return gv;
        }
        public GiaoVien GetGiaoVienByName(string name) 
        {
            string query = string.Format("select * from GiaoVien where HoTen='{0}'", name);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                /*GiaoVien giaovien = new GiaoVien();
                giaovien.HoTen = name;*/
                MessageBox.Show("Khong tim thay thong tin giao vien");
                return null;
            }
            DataRow row = dt.Rows[0];
            //GiaoVien gv = new GiaoVien(int.Parse(row["ID"].ToString()), row["HoTen"].ToString(), row["DiaChi"].ToString(), row["Khoa"].ToString(), DateTime.Parse(row["NgaySinh"].ToString()), row["Sdt"].ToString(),row["Email"].ToString());
            GiaoVien gv = new GiaoVien(row);
            return gv;
        }
        public void Add(GiaoVien item)
        {
            string query =string.Format("insert into GiaoVien(HoTen,DiaChi,Khoa,NgaySinh,Sdt,Email) values ('{0}','{1}','{2}','{3}','{4}','{5}')", item.HoTen, item.DiaChi, item.Khoa,item.FormatNgaySinh(),item.Sdt, item.Email);
            DBConnection dBConnection = new DBConnection();
            dBConnection.ExcuteQuery(query);
        }
        public bool Update(GiaoVien item) 
        {
            string query = string.Format("Update GiaoVien Set HoTen='{0}',DiaChi='{1}',Khoa='{2}',NgaySinh='{3}',Sdt='{4}' where Email='{5}'", item.HoTen, item.DiaChi, item.Khoa, item.FormatNgaySinh(), item.Sdt, item.Email);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Cap nhat thanh cong !");
                return true;
            }
            else
            {
                MessageBox.Show("Cap nhat khong thanh cong !");
                return false;
            }
        }
        public void Delete(GiaoVien item) 
        {
            string query = string.Format("Deleta GiaoVien where Email='{0}'",item.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                MessageBox.Show("Xoa thanh cong !");
            else
                MessageBox.Show("Xoa khong thanh cong !");
        }
        public static List<GiaoVien> getYeuCau(string key="")
        {
            List<GiaoVien> gvs = new List<GiaoVien>();
            string query = String.Format("SELECT * FROM GiaoVien where HoTen like '%{0}%'",key);
            DataTable data = dBConn.Excute(query);
            if (data == null)
            {
                MessageBox.Show("Error");
                return null;
            }
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                   GiaoVien gvien = new GiaoVien();
                    gvien.Id = Convert.ToInt32(row["ID"]);
                    gvien.HoTen = row["HoTen"].ToString();
                    gvien.DiaChi = row["DiaChi"].ToString() ;
                    gvien.Khoa = row["Khoa"].ToString();
                    gvien.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    gvien.Sdt = row["Sdt"].ToString();
                    gvien.Email = row["Email"].ToString();
                    gvs.Add(gvien);     
                }
                return gvs;
            }
            return null;
        }
        public List<GiaoVien> getListGiaoVien()
        {
            List<GiaoVien> gvs = new List<GiaoVien>();
            string query = String.Format("SELECT * FROM GiaoVien");
            DataTable data = dBConn.Excute(query);
            if (data == null)
            {
                MessageBox.Show("Error");
                return null;
            }
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    GiaoVien gvien = new GiaoVien();
                    gvien.Id = Convert.ToInt32(row["ID"]);
                    gvien.HoTen = row["HoTen"].ToString();
                    gvien.DiaChi = row["DiaChi"].ToString();
                    gvien.Khoa = row["Khoa"].ToString();
                    gvien.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    gvien.Sdt = row["Sdt"].ToString();
                    gvien.Email = row["Email"].ToString();
                    gvs.Add(gvien);
                }
                return gvs;
            }
            return null;
        }
    }
}
