using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class fDSNhom : Form
    {
        public fDSNhom()
        {
            InitializeComponent();
            LoadMember();
        }
        public void LoadMember()
        {
            Nhom gr = new Nhom(DataStorage.nhom.IDGroup);
            NhomDAO dao = new NhomDAO();
            DataTable dt = dao.GetMember(gr);
            flpMember.Controls.Clear();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                Nhom n = new Nhom(int.Parse(row["IDGroup"].ToString()), row["MemberName"].ToString());
                UCRowStudent uc = new UCRowStudent();
                SinhVienDao sinhVienDao = new SinhVienDao();
                SinhVien sv = sinhVienDao.GetSinhVienById(n.MemberName);
                uc.lbHoTen.Text = sv.HoTen;
                flpMember.Controls.Add(uc);
            }
        }
    }
}
