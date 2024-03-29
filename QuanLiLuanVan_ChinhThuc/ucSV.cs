using QuanLiLuanVan_ChinhThuc.GV;
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
    public partial class ucSV : UserControl
    {
        public ucSV()
        {
            InitializeComponent();
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbHoTen
        {
            get { return ucLbHoTen; }
            set { ucLbHoTen = value; }
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbLop
        {
            get { return ucLbLop; }
            set { ucLbLop = value; }
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbIdDangKi
        {
            get { return ucLbIdDangKi; }
            set { ucLbIdDangKi = value; }
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbTenDeTai
        {
            get { return ucLbTenDeTai; }
            set { ucLbTenDeTai = value; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormWatchDetailOfDeTai frm = new FormWatchDetailOfDeTai();
            LuanVanDao dao = new LuanVanDao();
            LuanVan lvan = dao.GetLVByIDLV(lbIdDangKi.Text);
            if (lvan == null)
            {
                MessageBox.Show("Khong tim thay luan van");
                return;
            }
            DataStorage.luanVan = lvan;
            frm.ShowDialog();
        }
    }
}
