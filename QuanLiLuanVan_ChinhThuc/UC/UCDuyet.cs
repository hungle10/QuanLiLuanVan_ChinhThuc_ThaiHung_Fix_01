using Guna.UI2.WinForms;
using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using QuanLiLuanVan_ChinhThuc.SV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.UC
{
    public partial class UCDuyet : UserControl
    {
        LuanVan lv;
        DangKyDao dkd = new DangKyDao();
        LuanVanDao lvd = new LuanVanDao();
        public UCDuyet(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            
        }

        public void loadInfo()
        {
            tendt.Text = lv.TenLuanVan;
            tengv.Text = lv.GiangVien;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            FormDuyet fduyet = new FormDuyet(lv); ;
            fduyet.ShowDialog();
        }
        public Guna2Button Guna2Button3 { get => btnDuyet; set => btnDuyet = value; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void UCDuyet_Load(object sender, EventArgs e)
        {
            loadInfo();
        }
    }
}
