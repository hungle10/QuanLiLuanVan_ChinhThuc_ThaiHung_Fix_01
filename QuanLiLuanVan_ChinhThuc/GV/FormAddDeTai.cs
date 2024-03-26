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
    public partial class fThemDeTai : Form
    {
        LuanVanDao lvd = new LuanVanDao();
        public fThemDeTai()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LuanVan lv = new LuanVan(9999, t2.Text, t1.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text);
            lvd.add(lv);
            this.Close();
            
        }

        private void t6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
