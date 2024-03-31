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
        YeuCauDAO ycd = new YeuCauDAO();
        DangKy dk;
        public FormDuyet(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            //dk = dkd.getFromIDSinhVien(UserInfo.sinhVien.Id.ToString());
            dk=dkd.getFromIDSinhVien(dkd.GetIDSvienByLV(lv).ToString());
            loadInfo();
        }

        public void loadInfo()
        {
            t1.Text = lv.GiangVien;
            t2.Text = lv.NenTang;
            t3.Text = lv.LinhVuc;
            t4.Text = lv.CongNghe;
            t6.Text = lv.ChiTiet;
            tnhom.Text = dkd.getMemberNhom(dk);
        }

        public bool isYeuCauEmpty()
        {
            if (t5.Text.Length <= 0)
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
            lv.YeuCau = t5.Text;
            lvd.updateYeuCau(lv);
            foreach (string line in t5.Lines)
                ycd.add(DataStorage.getIDGroupByIDSinhVien().ToString(), dk.IDLuanVan, line, 0);

            dkd.removeDuyet(dk);
            this.Close();

        }
    }
}
