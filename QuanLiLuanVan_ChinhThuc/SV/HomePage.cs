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
            get { return this.flpLuanVan; }
            set { this.flpLuanVan = value; }
        }
        public HomePage()
        {
            InitializeComponent();
            DataStorage.homePage = this;
        }
        public void LoadLuanVan()
        {
            flpLuanVan.Controls.Clear();
            HomePageClass hp = homePageClassDAO.getInfoHomePage(UserInfo.sinhVien.Id.ToString());

            if (hp != null)
            {
                DangKy dk = dkd.getFromMember(UserInfo.sinhVien.Id.ToString());
                if (dkd.checkDKDetaiDangDuyet(dk))
                {
                    //Thêm thanh trạng thái đề tài đang duyệt + hủy đề tài dag duyệt đó + chi tiết đề tài đang gửi đi để duyệt
                    return;
                }

                UCluanvan uc = new UCluanvan(this);
                uc.tenDeTai = hp.TenDeTai;
                uc.tenGiaoVienHuongDan = hp.GiaoVien;
                flpLuanVan.Controls.Add(uc);
            }
        }
        private void childFromLuanVan_Load(object sender, EventArgs e)
        {
            LoadLuanVan();
        }
    }
}

