using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using QuanLiLuanVan_ChinhThuc.GV;

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class fAdmin : Form
    {
        private string connectionStr = @"Data Source=LEHUNG\THAIHUNG;Initial Catalog=Window;Integrated Security=True;Encrypt=False";
        SqlConnection conn = new SqlConnection(@"Data Source=LEHUNG\THAIHUNG;Initial Catalog=Window;Integrated Security=True;Encrypt=False");
        public fAdmin()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            LoadTK("");
            LoadGV("");
            LoadSV("");
            LoadAdmin("");
        }
        public bool CheckInputTK()
        {
            if (tbHoTenTK.Text == "" || tbEmailTK.Text == "" || tbMatKhauTK.Text == "" || cbChucVuTK.Text == "")
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public bool CheckInputGV()
        {
            if(tbHoTenGV.Text==""||tbDiaChiGV.Text==""||tbKhoaGV.Text==""||dtpNgaySinhGV.Value.Year-DateTime.Now.Year>18||tbSdtGV.Text==""||tbEmailGV.Text=="")
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public bool CheckInputSV()
        {
            if (tbHoTenSV.Text == "" || tbDiaChiSV.Text == "" || tbKhoaSV.Text == "" || dtpSV.Value.Year - DateTime.Now.Year > 18 || tbSdtSV.Text == "" || tbEmailSV.Text == ""||tbChuyenNganhSV.Text==""||tbLopSV.Text==""||tbKhoaHocSV.Text=="")
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        public bool CheckInputAdmin()
        {
            if (tbHoTenAdmin.Text == "" || tbDiaChiAdmin.Text == "" || dtpNgaySinhAdmin.Value.Year - DateTime.Now.Year > 18 || tbSdtAdmin.Text == "" || tbEmailAdmin.Text == "" )
            {
                MessageBox.Show("Input information incorrect");
                return false;
            }
            return true;
        }
        void LoadTK(string key)
        {
            flpTaiKhoan.Controls.Clear();
            //DataTable dt = DataProvider.Instance.GetTable("TaiKhoan");
            DataTable dt = DataProvider.Instance.GetTableWithKey("TaiKhoan", "HoTen", key);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Khong tim thay tai khoan !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan tk = new TaiKhoan(row["HoTen"].ToString(), row["Email"].ToString(), row["MatKhau"].ToString(), row["LoaiTK"].ToString());
                ucTaiKhoan uc = new ucTaiKhoan();
                uc.lbTen.Text = tk.HoTen;
                uc.lbEmail.Text = tk.Email;
                uc.lbChucVu.Text = tk.LoaiTK;
                flpTaiKhoan.Controls.Add(uc);
                uc.Click += new EventHandler(ucTK_Click);
            }
        }
        public void LoadGV(string key)
        {
            flpGiaoVien.Controls.Clear();
            //DataTable dt = DataProvider.Instance.GetTable("GiaoVien");
            DataTable dt = DataProvider.Instance.GetTableWithKey("GiaoVien", "HoTen", key);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan tk = new TaiKhoan(row["HoTen"].ToString(), row["Email"].ToString());
                ucTaiKhoan uc = new ucTaiKhoan();
                uc.lbTen.Text = tk.HoTen;
                uc.lbEmail.Text = tk.Email;
                uc.lbChucVu.Text = "Giáo Viên";
                flpGiaoVien.Controls.Add(uc);
                uc.Click += new EventHandler(ucGV_Click);
            }
        }
        public void LoadSV(string key)
        {
            flpSinhVien.Controls.Clear();
            //DataTable dt = DataProvider.Instance.GetTable("SinhVien");
            DataTable dt = DataProvider.Instance.GetTableWithKey("SinhVien", "HoTen", key);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan tk = new TaiKhoan(row["HoTen"].ToString(), row["Email"].ToString());
                ucTaiKhoan uc = new ucTaiKhoan();
                uc.lbTen.Text = tk.HoTen;
                uc.lbEmail.Text = tk.Email;
                uc.lbChucVu.Text = "Học sinh";
                flpSinhVien.Controls.Add(uc);
                uc.Click += new EventHandler(ucSV_Click);
            }
        }
        public void LoadAdmin(string key)
        {
            flpAdmin.Controls.Clear();
            //DataTable dt = DataProvider.Instance.GetTable("Admin");
            DataTable dt = DataProvider.Instance.GetTableWithKey("Admin", "HoTen", key);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan tk = new TaiKhoan(row["HoTen"].ToString(), row["Email"].ToString());
                ucTaiKhoan uc = new ucTaiKhoan();
                uc.lbTen.Text = tk.HoTen;
                uc.lbEmail.Text = tk.Email;
                uc.lbChucVu.Text = "Admin";
                flpAdmin.Controls.Add(uc);
                uc.Click += new EventHandler(ucAdmin_Click);
            }
        }
        private void ucTK_Click(object sender, EventArgs e)
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            TaiKhoan tk= dao.GetTKByEmail(((ucTaiKhoan)sender).lbEmail.Text);
            tbHoTenTK.Text = tk.HoTen;
            cbChucVuTK.Text = tk.LoaiTK;
            tbEmailTK.Text=tk.Email;
        }
        private void ucGV_Click(object sender, EventArgs e)
        {
            GiaoVienDAO dao = new GiaoVienDAO();
            GiaoVien gv = dao.GetGVByEmail(((ucTaiKhoan)sender).lbEmail.Text);
            tbHoTenGV.Text = gv.HoTen;
            tbDiaChiGV.Text = gv.DiaChi;
            tbEmailGV.Text = gv.Email;
            tbKhoaGV.Text = gv.Khoa;
            tbSdtGV.Text = gv.Sdt;
            dtpNgaySinhGV.Value = gv.NgaySinh;
        }
        private void ucSV_Click(object sender, EventArgs e)
        {
            SinhVienDao dao = new SinhVienDao();
            SinhVien sv = dao.GetSVByEmail(((ucTaiKhoan)sender).lbEmail.Text);
            tbHoTenSV.Text = sv.HoTen;
            tbDiaChiSV.Text = sv.DiaChi;
            tbEmailSV.Text = sv.Email;
            tbKhoaSV.Text = sv.Khoa;
            tbSdtSV.Text = sv.Sdt;
            dtpSV.Value = sv.NgaySinh;
            tbLopSV.Text = sv.Lop;
            tbKhoaHocSV.Text = sv.KhoaHoc.ToString();
            tbChuyenNganhSV.Text = sv.ChuyenNganh;
        }
        private void ucAdmin_Click(object sender, EventArgs e)
        {
            /*AdminDAO dao = new AdminDAO();
            SinhVienDao dao = new SinhVienDao();
            SinhVien sv = dao.GetSVByEmail(((ucTaiKhoan)sender).lbEmail.Text);
            tbHoTenSV.Text = sv.HoTen;
            tbDiaChiSV.Text = sv.DiaChi;
            tbEmailSV.Text = sv.Email;
            tbKhoaSV.Text = sv.Khoa;
            tbSdtSV.Text = sv.Sdt;
            dtpSV.Text = sv.Sdt;
            tbLopSV.Text = sv.Lop;
            tbKhoaHocSV.Text = sv.KhoaHoc.ToString();
            tbChuyenNganhSV.Text = sv.ChuyenNganh;*/
        }
        private void btnThemTk_Click(object sender, EventArgs e)
        {
            if (!CheckInputTK() || tbMatKhauTK.Text != tbNhapLaiMkTK.Text) return;
            TaiKhoan tk = new TaiKhoan(tbHoTenTK.Text, tbEmailTK.Text, tbMatKhauTK.Text, cbChucVuTK.Text);
            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            tkDAO.Add(tk);
            LoadTK("");
            MessageBox.Show("Them tai khoan thanh cong!");
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (!CheckInputGV())
                return;
            GiaoVien gv=new GiaoVien(tbHoTenGV.Text,tbDiaChiGV.Text,tbKhoaGV.Text,dtpNgaySinhGV.Value,tbSdtGV.Text,tbEmailGV.Text);
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            giaoVienDAO.Add(gv);
            LoadGV("");
            MessageBox.Show("Them tai khoan thanh cong!");
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (!CheckInputSV()) return;
            SinhVien sv = new SinhVien(tbHoTenSV.Text, tbDiaChiSV.Text, tbKhoaSV.Text, dtpSV.Value, tbSdtSV.Text, tbEmailSV.Text, tbChuyenNganhSV.Text, tbLopSV.Text, int.Parse(tbKhoaHocSV.Text));
            SinhVienDao dao = new SinhVienDao();
            dao.Add(sv);
            LoadSV("");
        }
        private void btnThemAdmin_Click(object sender, EventArgs e)
        {
            if (!CheckInputAdmin()) return;
            Admin ad = new Admin(tbHoTenAdmin.Text, tbDiaChiAdmin.Text, dtpNgaySinhAdmin.Value, tbSdtAdmin.Text, tbEmailAdmin.Text);
            AdminDAO dao=new AdminDAO();
            dao.Add(ad);
            LoadAdmin("");
        }
        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            if(!CheckInputTK() || tbMatKhauTK.Text != tbNhapLaiMkTK.Text) return;
            TaiKhoan tk=new TaiKhoan(tbHoTenTK.Text,tbEmailTK.Text,tbMatKhauTK.Text,cbChucVuTK.Text);
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.Update(tk);
            LoadTK("");
        }
        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (!CheckInputTK()) return;
            GiaoVien gv = new GiaoVien(tbHoTenGV.Text, tbDiaChiGV.Text, tbKhoaGV.Text, dtpNgaySinhGV.Value, tbSdtGV.Text, tbEmailGV.Text);
            GiaoVienDAO dao = new GiaoVienDAO();
            dao.Update(gv);
            LoadGV("");
        }
        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (!CheckInputSV()) return;
            SinhVien sv = new SinhVien(tbHoTenSV.Text, tbDiaChiSV.Text, tbKhoaSV.Text, dtpSV.Value, tbSdtSV.Text, tbEmailSV.Text, tbChuyenNganhSV.Text, tbLopSV.Text, int.Parse(tbKhoaHocSV.Text));
            SinhVienDao dao = new SinhVienDao();
            dao.Update(sv);
            LoadSV("");
        }
        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if(!CheckInputTK()) return;
            TaiKhoan tk = new TaiKhoan(tbHoTenTK.Text, tbEmailTK.Text, tbMatKhauTK.Text, cbChucVuTK.Text);
            TaiKhoanDAO dao = new TaiKhoanDAO();
            dao.Delelte(tk);
            LoadTK("");
        }
        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (!CheckInputTK()) return;
            GiaoVien gv = new GiaoVien(tbHoTenGV.Text, tbDiaChiGV.Text, tbKhoaGV.Text, dtpNgaySinhGV.Value, tbSdtGV.Text, tbEmailGV.Text);
            GiaoVienDAO dao = new GiaoVienDAO();
            dao.Delete(gv);
            LoadGV("");
        }
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (!CheckInputSV()) return;
            SinhVien sv = new SinhVien(tbHoTenSV.Text, tbDiaChiSV.Text, tbKhoaSV.Text, dtpSV.Value, tbSdtSV.Text, tbEmailSV.Text, tbChuyenNganhSV.Text, tbLopSV.Text, int.Parse(tbKhoaHocSV.Text));
            SinhVienDao dao = new SinhVienDao();
            dao.Delete(sv);
            LoadSV("");
        }
        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            LoadTK(tbTimKiemTK.Text);
        }
        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            LoadGV(tbTimKiemGV.Text);
        }
        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            LoadSV(tbTimKiemSV.Text);
        }
        private void btnTimKiemAdmin_Click(object sender, EventArgs e)
        {
            LoadAdmin(tbTimKiemAdmin.Text);
        }
        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
