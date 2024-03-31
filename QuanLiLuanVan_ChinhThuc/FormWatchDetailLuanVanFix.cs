using Guna.UI2.WinForms;
using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
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
    public partial class FormWatchDetailLuanVanFix : Form
    {
        private HomePage hp;
        private UCluanvan uc;
        public Guna2ProgressBar gn2
        {
            get { return this.guna2ProgressBar1; }
            set { this.guna2ProgressBar1= value; }
        }
        public FlowLayoutPanel flp
        {
            get { return this.flowLayoutPanel1; }
            set { this.flowLayoutPanel1 = value; }
        }
        public FormWatchDetailLuanVanFix(HomePage hp, UCluanvan uc)
        {
            InitializeComponent();
            this.hp = hp;
            this.uc = uc;
        }

        private void FormWatchDetailLuanVanFix_Load(object sender, EventArgs e)
        {
           this.guna2ProgressBar1.Minimum = 0;  
           this.guna2ProgressBar1.Maximum = 100;
            double tongUC = 0;
            double tongUChoanthanh = 0; 
            YeuCauDAO yeucauDAO = new YeuCauDAO();
            //gửi id sinh viên vào đây 
           List<YeuCau> ycs =  yeucauDAO.getYeuCau(DataStorage.getIDGroupByIDSinhVien().ToString());
            foreach(YeuCau yc in ycs) 
            {
                    UCnoidungCheck uc = new UCnoidungCheck();       
                    uc.noiDung=yc.NoiDungYeuCau.ToString();       
                    uc.tinhTrang=yc.TinhTrang;
                    uc.idLuanVan = yc.IdLuanVan;
                    this.flowLayoutPanel1.Controls.Add(uc);
                if (uc.tinhTrang == 1)
                    tongUChoanthanh++;
                tongUC++;
            }

            double currentValue = (double)tongUChoanthanh *100 / tongUC;
            int intValue = (int)(currentValue * guna2ProgressBar1.Maximum / 100.0);
            this.guna2ProgressBar1.Value = intValue;    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormAddYeuCau frm = new FormAddYeuCau(this,uc);
            frm.ShowDialog();
        }
        //nut cap nhat
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.guna2ProgressBar1.Minimum = 0;
            this.guna2ProgressBar1.Maximum = 100;
            double tongUC = 0;
            double tongUChoanthanh = 0;
            YeuCauDAO ycd = new YeuCauDAO();
            foreach ( UCnoidungCheck uc in flowLayoutPanel1.Controls.OfType<UCnoidungCheck>())
            {
                if (uc.checkbox.Checked == true)
                    ycd.update(1,DataStorage.getIDGroupByIDSinhVien().ToString(),uc.idLuanVan, uc.noiDung);
                if(uc.checkbox.Checked == false)
                    ycd.update(0, DataStorage.getIDGroupByIDSinhVien().ToString(), uc.idLuanVan, uc.noiDung);
            }
            List<YeuCau> ycs = ycd.getYeuCau(DataStorage.getIDGroupByIDSinhVien().ToString());
            foreach (YeuCau yc in ycs)
            {
                UCnoidungCheck uc = new UCnoidungCheck();
                uc.noiDung = yc.NoiDungYeuCau.ToString();
                uc.tinhTrang = yc.TinhTrang;
                uc.idLuanVan = yc.IdLuanVan;
                if (uc.tinhTrang == 1)
                    tongUChoanthanh++;
                tongUC++;
            }

            double currentValue = (double)tongUChoanthanh * 100 / tongUC;
            int intValue = (int)(currentValue * guna2ProgressBar1.Maximum / 100.0);
            this.guna2ProgressBar1.Value = intValue;

            hp.Panel2.Controls.Clear();
            HomePageClassDAO homePageClassDAO = new HomePageClassDAO();
            HomePageClass hpg = homePageClassDAO.getInfoHomePage(UserInfo.sinhVien.Id.ToString());
            if (hp != null)
            {
                UCluanvan uc = new UCluanvan(hp);
                uc.tenDeTai = hpg.TenDeTai;
                uc.tenGiaoVienHuongDan = hpg.GiaoVien;
                hp.Panel2.Controls.Add(uc);
            }
        }
    }
}
