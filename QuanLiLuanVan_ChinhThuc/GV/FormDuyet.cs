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

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormDuyet : Form
    {
        LuanVan lv;
        DangKyDao dkd = new DangKyDao();
        LuanVanDao lvd = new LuanVanDao();
        DangKy dk;
        public FormDuyet(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            dk=dkd.getFromIDSinhVien(dkd.GetIDSvienByLV(lv).ToString());
            loadInfo();
        }
        public void loadInfo()
        {
            tbGiaoVien.Text = lv.GiangVien;
            tbNenTang.Text = lv.NenTang;
            tbLinhVuc.Text = lv.LinhVuc;
            tbCongNghe.Text = lv.CongNghe;
            tbNoiDung.Text = lv.ChiTiet;
            tbNhom.Text = dkd.getMemberNhom(dk);
        }
        public bool isYeuCauEmpty()
        {
            if (tbYeuCau.Text.Length <= 0)
                return true;
            return false;
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            dkd.remove(dk);
            dkd.removeDuyet(dk);
            lvd.remove(lv);
            this.Close();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (isYeuCauEmpty())
            {
                MessageBox.Show("Vui lòng điền các yêu cầu cho đề tài này");
                return;
            }
            lv.YeuCau = tbYeuCau.Text;
            lvd.updateYeuCau(lv);
            dkd.removeDuyet(dk);
            this.Close();
        }
    }
}
