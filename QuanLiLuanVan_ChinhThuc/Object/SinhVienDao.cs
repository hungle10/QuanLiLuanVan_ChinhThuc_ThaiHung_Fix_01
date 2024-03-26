using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class SinhVienDao
    {
        DBConnection dBConn = new DBConnection();
        public SinhVien getSinhVien(string id)
        {
            string query = String.Format("SELECT * FROM SinhVien WHERE ID='{0}'", id);
            SqlDataReader data = dBConn.runSqlReturn(query);
            if (data == null)
            {
                MessageBox.Show("Error, cannot find id " + id);
                return null;
            }
            SinhVien sinhVien = new SinhVien(
                int.Parse(data.GetString(0)),
                data.GetString(1),
                data.GetString(2),
                data.GetString(3),
                data.GetDateTime(4),
                data.GetString(5),
                data.GetString(6),
                data.GetString(7),
                data.GetString(8),
                int.Parse(data.GetString(9))
                );
            return sinhVien;
        }
        public SinhVien GetSVByEmail(string email)
        {
            string query = string.Format("select * from SinhVien where Email='{0}'", email);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.Email = email;
                MessageBox.Show("Lay thong tin sinh vien that bai !");
                return sinhVien;
            }
            DataRow row = dt.Rows[0];
            SinhVien sv = new SinhVien(int.Parse(row["ID"].ToString()), row["HoTen"].ToString(), row["DiaChi"].ToString(), row["Khoa"].ToString(), DateTime.Parse(row["NgaySinh"].ToString()), row["Sdt"].ToString(), row["Email"].ToString(), row["ChuyenNganh"].ToString(), row["Lop"].ToString(),int.Parse(row["KhoaHoc"].ToString()));
            return sv;
        }
        public void Add(SinhVien sv) 
        {
            string query = string.Format("insert into SinhVien(HoTen,DiaChi,Khoa,NgaySinh,Sdt,Email,ChuyenNganh,Lop,KhoaHoc) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8})", sv.HoTen, sv.DiaChi, sv.Khoa, sv.FormatNgaySinh(), sv.Sdt, sv.Email,sv.ChuyenNganh,sv.Lop,sv.KhoaHoc);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Them thanh cong !");
            }
            else
                MessageBox.Show("Them that bai !");
        }
        public bool Update(SinhVien sv) 
        {
            string query = string.Format("Update SinhVien Set HoTen='{0}',DiaChi='{1}',NgaySinh='{2}',Sdt='{3}',ChuyenNganh='{4}' where Email='{5}'", sv.HoTen, sv.DiaChi, sv.FormatNgaySinh(), sv.Sdt,sv.ChuyenNganh, sv.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
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
        public void Delete(SinhVien sv)
        {
            string query = string.Format("Delete SinhVien where Email='{5}'",sv.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                MessageBox.Show("Xoa thanh cong !");
            else
                MessageBox.Show("Xoa khong thanh cong !");
        }
    }
}
