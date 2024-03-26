using Bunifu.Framework.UI;
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
    public partial class UCRowGiaoVien : UserControl
    {
        public BunifuCustomLabel BunifuCustomLabel3
        { get { return bunifuCustomLabel3; }
          set { bunifuCustomLabel3=value; }
        }
        public BunifuCustomLabel BunifuCustomLabel4
        {
            get { return bunifuCustomLabel4; }
            set { bunifuCustomLabel4 = value; }
        }
        public UCRowGiaoVien()
        {

            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
