using Guna.UI2.WinForms;
using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using QuanLiLuanVan_ChinhThuc.SV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Management;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.UC
{
    public partial class UCdetaidk : UserControl
    {
        LuanVan lv;
        DangKyDao dkd = new DangKyDao();
        YeuCauDAO ycd = new YeuCauDAO();
        DangKy dk;
        FormXacNhan FXacNhan;
        bool check;

        public UCdetaidk(LuanVan lv)
        {
            InitializeComponent();
            this.lv = lv;
            dk = new DangKy(UserInfo.sinhVien.Id.ToString(), lv.IDLuanVan, lv.GiangVien);
            FXacNhan = new FormXacNhan(lv);
            loadInfomation();
        }

        public void loadInfomation()
        {

            tendt.Text = lv.TenLuanVan;
            tengv.Text = lv.GiangVien;
            if (dkd.checkDK(dk))
            {
                guna2Button3.Text = "Hủy đăng ký";
                status.Text = "Đã đăng ký";
                status.ForeColor = Color.Green;
                check = true;
            }
            else
            {
                guna2Button3.Text = "Đăng ký";
                status.Text = "Chưa đăng ký";
                status.ForeColor = Color.Red;
                check = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //chỗ 100000 sẽ là id sinh viên 
            //lv.GiangVien se la id giang vien , sai cho nay
            if (!check && dkd.checkDKDetaiDangDuyet(dk))
            {
                MessageBox.Show("Bạn đã có đề tài đang chờ duyệt rồi!");
                return;
            }
            if (dkd.daDK(dk) && !check)
            {
                MessageBox.Show("Bạn đã đăng ký đề tài rồi!");
                return;
            }
            if (dkd.nguoiKhacDaDK(dk) && !check)
            {
                MessageBox.Show("Người khác đã đăng ký đề tài này rồi!");
                return;
            }
            if (!dkd.checkDK(dk))
            {
                FXacNhan.ShowDialog();
            }
            else
            {
                ycd.delete(UserInfo.sinhVien.Id.ToString(), lv.IDLuanVan);
                dkd.remove(dkd.getFromIDSinhVien(UserInfo.sinhVien.Id.ToString()));
            }
            loadInfomation();


        }

        public Guna2Button Guna2Button3 { get => guna2Button3; set => guna2Button3 = value; }

        private void tendt_Click(object sender, EventArgs e)
        {

        }

        private void UCdetaidk_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormWatchDetailOfDeTai frm = new FormWatchDetailOfDeTai(lv.TenLuanVan, lv.GiangVien, lv.ChiTiet);
            LuanVanDao dao = new LuanVanDao();
            LuanVan lvan= dao.GetLVByTenLV(lv.TenLuanVan);
            if(lvan==null)
            {
                MessageBox.Show("Khong tim thay luan van");
                return;
            }
            DataStorage.luanVan = lvan;
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
