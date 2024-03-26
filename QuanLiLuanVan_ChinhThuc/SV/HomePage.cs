using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class HomePage : Form
    {
        HomePageClassDAO homePageClassDAO = new HomePageClassDAO();
        DangKyDao dkd = new DangKyDao();

        public Panel Panel2
        {
            get { return this.panel2; }
            set { this.panel2 = value; }
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void childFromLuanVan_Load(object sender, EventArgs e)
        {
            
            HomePageClass hp = homePageClassDAO.getInfoHomePage(UserInfo.sinhVien.Id.ToString());
            if (hp != null )
            {
                DangKy dk = dkd.getFromIDSinhVien(UserInfo.sinhVien.Id.ToString());
                if (dkd.checkDKDetaiDangDuyet(dk))
                {
                    //Thêm thanh trạng thái đề tài đang duyệt + hủy đề tài dag duyệt đó + chi tiết đề tài đang gửi đi để duyệt
                    return;
                }
                UCluanvan uc = new UCluanvan(this);
                uc.tenDeTai = hp.TenDeTai;
                uc.tenGiaoVienHuongDan = hp.GiaoVien;
                panel2.Controls.Add(uc);
            }

        }
        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uCbutton1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void uCbutton1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

