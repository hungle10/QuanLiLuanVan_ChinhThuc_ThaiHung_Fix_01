using QuanLiLuanVan_ChinhThuc.GV;
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

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void chbHocSinh_OnChange(object sender, EventArgs e)
        {
            chbHocSinh.Checked = true;
            chbAdmin.Checked = false;
            chbGiaoVien.Checked = false;
        }

        private void chbGiaoVien_OnChange(object sender, EventArgs e)
        {
            chbHocSinh.Checked = false;
            chbAdmin.Checked = false;
            chbGiaoVien.Checked = true;
        }

        private void chbAdmin_OnChange(object sender, EventArgs e)
        {
            chbHocSinh.Checked = false;
            chbAdmin.Checked = true;
            chbGiaoVien.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string chucVu = "";
            if (chbAdmin.Checked)
                chucVu = "Admin";
            else if (chbHocSinh.Checked)
                chucVu = "Hoc Sinh";
            else if (chbGiaoVien.Checked)
                chucVu = "Giao Vien";
            TaiKhoan tk = new TaiKhoan(tbEmail.Text, tbMatKhau.Text, chucVu);
            TaiKhoanDAO tkDao = new TaiKhoanDAO();
            tk = tkDao.CheckLogin(tk);
            if (tk == null)
                MessageBox.Show("Thong tin Email va mat khau khong dung !");
            else
            {
                if (tk.LoaiTK == "Hoc Sinh")
                {
                    FormMainSV f = new FormMainSV();
                    SinhVienDao dao=new SinhVienDao();
                    UserInfo.sinhVien = dao.GetSVByEmail(tk.Email);
                    UserInfo.user = "Hoc Sinh";
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (tk.LoaiTK == "Giao Vien")
                {
                    FormMainGV f = new FormMainGV();
                    GiaoVienDAO dao=new GiaoVienDAO();
                    UserInfo.giaoVien = dao.GetGVByEmail(tk.Email);
                    UserInfo.user = "Giao Vien";
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fAdmin f = new fAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
