using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class DiemLVDAO
    {
        public DiemLVDAO() { }
        public void Add(DiemLV diemLV)
        {
            string query = string.Format("Insert into DiemLV values({0},{1},{2},{3},'{4}')",diemLV.IDSinhVien,DataStorage.nhom.IDGroup ,diemLV.IDLuanVan, diemLV.Diem, diemLV.NhanXet );
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
            {
                MessageBox.Show("Cham diem that bai !");
                return;
            }
            else
                MessageBox.Show("Cham diem thanh cong !");
        }
        public int GetDiemBySVN(SinhVien sv,Nhom n)
        {
            string query = string.Format("Select Diem from DiemLV Where IDSinhVien={0} and IDGroup={1}", sv.Id, n.IDGroup);
            object ob=DataProvider.Instance.ExecuteScalar(query);
            if (ob != null)
                return int.Parse(ob.ToString());
            else return -1;
        }

    }
}
