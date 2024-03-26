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

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormInforStudent : Form
    {
        public FormInforStudent()
        {
            InitializeComponent();
            LoadInforSV();
        }
        public bool CheckInPutSV()
        {
            if (tbHoTenSV2.Text == "" || tbDiaChiSV2.Text == "" || tbChuyenNganhSV2.Text == "" || tbSdtSV2.Text == "" || DateTime.Now.Year - dtpSV2.Value.Year < 18)
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public void LoadInforSV()
        {
            tbIdSV.Text = UserInfo.sinhVien.Id.ToString();
            tbNameSV.Text = UserInfo.sinhVien.HoTen;
            tbHoTenSV.Text=UserInfo.sinhVien.HoTen;
            tbDiaChiSV.Text=UserInfo.sinhVien.DiaChi;
            tbKhoaSV.Text = UserInfo.sinhVien.Khoa;
            tbNgaySinhSV.Text = UserInfo.sinhVien.FormatNgaySinh();
            tbSdtSV.Text = UserInfo.sinhVien.Sdt;
            tbEmailSV.Text = UserInfo.sinhVien.Email;
            tbChuyenNganhSV.Text = UserInfo.sinhVien.ChuyenNganh;
            tbLopSV.Text = UserInfo.sinhVien.Lop;
            tbKhoaHocSV.Text = UserInfo.sinhVien.KhoaHoc.ToString();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(tbHoTenSV2.Text, tbDiaChiSV2.Text, UserInfo.sinhVien.Khoa, dtpSV2.Value, tbSdtSV2.Text, UserInfo.sinhVien.Email, tbChuyenNganhSV2.Text, UserInfo.sinhVien.Lop, UserInfo.sinhVien.KhoaHoc);
            SinhVienDao dao = new SinhVienDao();
            if (dao.Update(sv))
                UserInfo.sinhVien = sv;
        }
        private void btnCapNhatMK_Click(object sender, EventArgs e)
        {
            if (tbMatKhauMoi1.Text != tbMatKhauMoi2.Text)
            {
                MessageBox.Show("Mat Khau moi khong trung nhau !");
                return;
            }
            TaiKhoan tk = new TaiKhoan(UserInfo.sinhVien.HoTen, UserInfo.sinhVien.Email, tbMatKhau.Text, "Hoc Sinh");
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.DoiMK(tk, tbMatKhauMoi2.Text);
        }
        private void btnCapNhatInfor_Click(object sender, EventArgs e)
        {

        }
        private void FormInforStudent_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
