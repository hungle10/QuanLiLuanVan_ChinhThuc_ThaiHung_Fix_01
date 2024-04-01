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
    public partial class ucNhomLV : UserControl
    {
        public ucNhomLV()
        {
            InitializeComponent();
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbNhom
        {
            get { return ucLbIdNhom; }
            set { ucLbIdNhom = value; }
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

        private void btnNhom_Click(object sender, EventArgs e)
        {
            Nhom n= new Nhom(int.Parse(lbNhom.Text));
            DataStorage.nhom = n;   
            fDSNhom f=new fDSNhom();
            f.ShowDialog();
        }
    }
}
