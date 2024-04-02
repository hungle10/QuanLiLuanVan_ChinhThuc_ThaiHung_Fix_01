using Guna.UI2.WinForms;
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

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class UCdetai : UserControl
    {
        LuanVan LVan;
        SinhVien sinhVien;
        SinhVienDao sinhVienDao = new SinhVienDao();
        LuanVanDao luanVanDao = new LuanVanDao();

        public UCdetai(LuanVan LVan)
        {
            InitializeComponent();
            this.LVan = LVan;
            loadInfomation();
        }

        public void loadInfomation()
        {
           
            label2.Text = LVan.GiangVien;
            bunifuCustomLabel4.Text = LVan.TenLuanVan;
        }
        public void changeColorTextBox(int r, int g, int b)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            label2.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            changeColorTextBox(192, 192, 255);
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            changeColorTextBox(148, 148, 235);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            luanVanDao.remove(LVan);
        }

        public Guna2Button Guna2Button3 { get => guna2Button3; set => guna2Button3 = value; }
        private void ucBtnChiTiet_Click(object sender, EventArgs e)
        {
            /*FormWatchDetailOfDeTai frm = new FormWatchDetailOfDeTai();
            LuanVanDao dao = new LuanVanDao();
            LuanVan lvan = dao.GetLVByTenLV(LVan.TenLuanVan);
            if (lvan == null)
            {
                MessageBox.Show("Khong tim thay luan van");
                return;
            }
            DataStorage.luanVan = lvan;
            frm.ShowDialog();*/
        }

        private void UCdetai_Load(object sender, EventArgs e)
        {

        }
    }
}
