using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiLuanVan_ChinhThuc.GV;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc
{
    internal class AdminDAO
    {
        public void Add(Admin ad)
        {
            string query = string.Format("insert into Admin(HoTen,DiaChi,NgaySinh,Sdt,Email) values ('{0}','{1}','{2}','{3}','{4}')", ad.HoTen, ad.DiaChi, ad.FormatNgaySinh(), ad.Sdt, ad.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Them thanh cong !");
            }
            else
                MessageBox.Show("Them that bai !");
        }
    }
}
