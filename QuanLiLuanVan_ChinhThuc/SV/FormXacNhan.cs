using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormXacNhan : Form
    {
        LuanVan lv;
        DangKyDao dkd = new DangKyDao();
//YeuCauDAO ycd = new YeuCauDAO();
        DangKy dk;

        List<string> noiDungs;
        public FormXacNhan(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            GiaoVienDAO dao = new GiaoVienDAO();
            GiaoVien gv = dao.GetGiaoVienByName(lv.GiangVien);
            if (gv == null)
                return;
            dk = new DangKy(UserInfo.sinhVien.Id.ToString(), lv.IDLuanVan, gv.Id.ToString());
            loadInfo();
        }
        public void loadGiaoVien()
        {
            GiaoVienDAO gvd = new GiaoVienDAO();
            DataTable dt = DataProvider.Instance.GetTable("GiaoVien");
            cbbGiaoVien.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //tMessageBox.Show(cbbGiaoVien.Items.Add(r["HoTen"]).ToString());
                cbbGiaoVien.Items.Add(r["HoTen"]);
                //cbbGiaoVien.Items.Add(r);
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void loadInfo()
        {
            cbbGiaoVien.Text = lv.GiangVien;
            t2.Text = lv.NenTang;
            t3.Text = lv.LinhVuc;
            t4.Text = lv.CongNghe;
            t5.Text = lv.YeuCau;
            t6.Text = lv.ChiTiet;
        }

        public bool isEmptyNhom()
        {
            return tnhom.Text.Length == 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isEmptyNhom())
            {
                MessageBox.Show("Vui lòng điền thành viên nhóm");
                return;
            }
            dkd.add(dk);
            dkd.addMemberNhom(tnhom.Lines, dk.IDSinhVien);
            this.Close();
        }
        public DangKy Dk { get => dk; set => dk = value; }
        public List<string> NoiDungs { get => noiDungs; set => noiDungs = value; }

        private void FormXacNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
