using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormXacNhan : Form
    {
        LuanVan lv;
        DangKyDao dkd = new DangKyDao();
        YeuCauDAO ycd = new YeuCauDAO();
        DangKy dk;

        List<string> noiDungs;
        public FormXacNhan(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            dk = new DangKy(UserInfo.sinhVien.Id.ToString(), lv.IDLuanVan, lv.GiangVien);
            loadInfo();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void loadInfo()
        {
            t1.Text = lv.GiangVien;
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
            //MessageBox.Show(tnhom.Lines[0] +"");
            dkd.addMemberNhom(tnhom.Lines, dk.IDSinhVien);
            YeuCauDAO ycd = new YeuCauDAO();
            string[] mangChuoi = lv.ChiTiet.Split(new string[] { "\n" }, StringSplitOptions.None);
            // Chuyển đổi mảng thành danh sách List<string>
            noiDungs = new List<string>(mangChuoi);
            foreach (string chuoi in noiDungs)
            {
                ycd.add(DataStorage.getIDGroupByIDSinhVien().ToString(), lv.IDLuanVan, chuoi, 0);
            }
            this.Close();
           /* public void add(DangKy dk)
            {
                string queryDK = String.Format("INSERT INTO DangKi(IDSinhVien, IDLuanVan, IDGiangVien) VALUES('{0}', '{1}', '{2}')",
                   dk.IDSinhVien, dk.IDLuanVan, dk.IDGiangVien);
                dBConn.runSql(queryDK);
            }*/
        }
        public DangKy Dk { get => dk; set => dk = value; }
        public List<string> NoiDungs { get => noiDungs; set => noiDungs = value; }

        private void FormXacNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
