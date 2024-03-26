using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiLuanVan_ChinhThuc.GV;
using System.Windows.Forms;
using System.Web.Management;
using System.Data;
namespace QuanLiLuanVan_ChinhThuc
{
    internal class TaiKhoanDAO
    {
        public TaiKhoanDAO() { }
        public bool CheckInput(TaiKhoan tk)
        {
            if (!DBConnection.IsEmail(tk.Email) || tk.LoaiTK != "Hoc Sinh" || tk.LoaiTK != "Giao Vien" || tk.LoaiTK != "Admin")
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public void Add(TaiKhoan item)
        {
            string query = "insert into TaiKhoan values ('" + item.HoTen + "','" + item.Email + "','" + item.MatKhau + "','" + item.LoaiTK + "');";
            DBConnection dBConnection = new DBConnection();
            dBConnection.ExcuteQuery(query);
        }
        public TaiKhoan CheckLogin(TaiKhoan tk)
        {
            string query = string.Format("Select HoTen from TaiKhoan Where Email='{0}'and MatKhau='{1}' and LoaiTK='{2}'", tk.Email, tk.MatKhau, tk.LoaiTK);
            object ob = DataProvider.Instance.ExecuteScalar(query);
            if (ob != null)
            {
                string name = (string)ob;
                tk.HoTen = name;
                return tk;
            }
            else
                return null;
        }
        public void DoiMK(TaiKhoan tk,string mkMoi)
        {
            string query = string.Format("Select MatKhau from TaiKhoan Where Email='{0}'", tk.Email);
            object ob=DataProvider.Instance.ExecuteScalar(query);
            string mk="";
            if (ob != null)
                mk = (string)ob;
            else
                MessageBox.Show("Cap nhat khong thanh cong");
            if(mk != tk.MatKhau)
                MessageBox.Show("Mat khau khong dung !");
            query = string.Format("Update TaiKhoan Set MatKhau='{0}' where Email='{1}'",mkMoi,tk.Email);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                MessageBox.Show("Cap nhat thanh cong !");
            else
                MessageBox.Show("Cap nhat khong thanh cong !");
        }
        public TaiKhoan GetTKByEmail(string email)
        {
            string query = string.Format("Select * from TaiKhoan where Email='{0}'", email);
            DataRow row = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            TaiKhoan tk = new TaiKhoan(row["HoTen"].ToString(), row["Email"].ToString(), row["MatKhau"].ToString(), row["LoaiTK"].ToString());
            return tk;
        }
        public void Update(TaiKhoan tk)
        {
            string query = string.Format("Update TaiKhoan set HoTen='{0}',MatKhau='{1}',LoaiTK='{2}' where Email='{3}'", tk.HoTen, tk.MatKhau, tk.LoaiTK, tk.Email);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                MessageBox.Show("Cap nhat thanh cong !");
            else
                MessageBox.Show("Cap nhat khong thanh cong !");
        }
        public void Delelte(TaiKhoan tk)
        {
            string query = string.Format("Delete TaiKhoan where Email='{0}'", tk.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
                MessageBox.Show("Xoa thanh cong !");
            else
                MessageBox.Show("Xoa khong thanh cong !");
        }
    }
}
