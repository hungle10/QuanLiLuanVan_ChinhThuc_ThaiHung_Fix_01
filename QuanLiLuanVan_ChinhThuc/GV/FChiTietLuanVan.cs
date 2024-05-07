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
    public partial class FChiTietLuanVan : Form
    {
        public FChiTietLuanVan(LuanVan lv)
        {
            InitializeComponent();
            LoadChiTienLV(lv);
        }
        public void LoadChiTienLV(LuanVan lv)
        {
            tbGiaoVien.Text =lv.GiangVien;
            tbNenTang.Text =lv.NenTang;
            tbLinhVuc.Text = lv.LinhVuc;
            tbCongNghe.Text = lv.CongNghe;
            tbYeuCau.Text = lv.YeuCau;
            tbNoiDung.Text = lv.ChiTiet;

        }
    }
}
