using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections;
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
    public partial class fThemDeTai : Form
    {
        LuanVanDao lvd = new LuanVanDao();
        public fThemDeTai()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LuanVan lv = new LuanVan(9999, tbTenDeTai.Text,UserInfo.giaoVien.HoTen, tbNenTang.Text, tbLinhVuc.Text, tbCongNghe.Text, tbYeuCauChung.Text, tbNoiDung.Text);
            lvd.add(lv);
            this.Close();
        }
    }
}
