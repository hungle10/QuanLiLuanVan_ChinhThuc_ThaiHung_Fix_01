using QuanLiLuanVan_ChinhThuc.Object;
using QuanLiLuanVan_ChinhThuc.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormQuanLyDuyet : Form
    {
        DBConnection dBConn = new DBConnection();
        LuanVanDao lvd = new LuanVanDao();
        DangKyDao dkd = new DangKyDao();

        public FormQuanLyDuyet()
        {
            InitializeComponent();
        }

        public void loadPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = string.Format("SELECT * FROM LuanVan WHERE (LuanVan.IDLuanVan IN (SELECT IDLuanVan FROM DangKi) AND LuanVan.IDLuanVan IN (SELECT IDLuanVan FROM Duyet)) and GiangVien='{0}'", UserInfo.giaoVien.HoTen);
            DataTable dt = dBConn.Excute(query);
            foreach (DataRow dr in dt.Rows)
            {
                LuanVan luanVan = lvd.convert(dr);
                UCDuyet uc = new UCDuyet(luanVan);
                uc.Guna2Button3.Click += Guna2Button3_Click; ;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            loadPanel();
        }

        private void FormDuyet_Load(object sender, EventArgs e)
        {
            loadPanel();
        }
    }
}
