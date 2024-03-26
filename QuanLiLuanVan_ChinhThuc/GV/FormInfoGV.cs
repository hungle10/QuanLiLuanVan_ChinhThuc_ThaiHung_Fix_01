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
    public partial class FormInfoGV : Form
    {
        public FormInfoGV()
        {
            InitializeComponent();
            LoadInforGV();
        }
        public bool CheckInPutGV()
        {
            if (tbHoTenGV2.Text==""|| tbDiaChiGV2.Text==""|| tbKhoaGV2.Text==""|| tbSdtGV2.Text==""||DateTime.Now.Year-dtpNgaySinhGV2.Value.Year<18)
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public void LoadInforGV()
        {
            GiaoVien gv = UserInfo.giaoVien;
            //MessageBox.Show(gv.ToString());
            tbHoTenGV1.Text = gv.HoTen;
            tbDiaChiGV1.Text = gv.DiaChi;
            tbKhoaGV1.Text = gv.Khoa;
            tbNgaySinhGV1.Text = gv.FormatNgaySinh();
            tbEmailGV1.Text = gv.Email;
            tbSdtGV1.Text = gv.Sdt;
        }
        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhatGV_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(tbHoTenGV2.Text, tbDiaChiGV2.Text, tbKhoaGV2.Text, dtpNgaySinhGV2.Value, tbSdtGV2.Text, UserInfo.giaoVien.Email);
            GiaoVienDAO dao = new GiaoVienDAO();
            if(dao.Update(gv))
                UserInfo.giaoVien=gv;
        }

        private void btnCapNhatMK_Click(object sender, EventArgs e)
        {
            if(!CheckInPutGV()|| tbMatKhauMoi1.Text!=tbMatKhauMoi2.Text)
            {
                MessageBox.Show("Mat Khau moi khong trung nhau !");
                return;
            }
            TaiKhoan tk = new TaiKhoan(UserInfo.giaoVien.HoTen, UserInfo.giaoVien.Email,tbMatKhau.Text,"Giao Vien");
            TaiKhoanDAO dao=new TaiKhoanDAO();
            dao.DoiMK(tk, tbMatKhauMoi2.Text);
        }
    }
}
