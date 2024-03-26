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
    public partial class UCluanvan : UserControl
    {
        private HomePage hp;
        public string tenDeTai;
        public string tenDoAn;
        public string tenGiaoVienHuongDan;
        public string tienDo;
        public UCluanvan(HomePage hp)
        {
            InitializeComponent();
            this.hp = hp;       
        }
        public Label Lable1 {
            get { return this.label1; }
            set { this.label1 = value; } }       
        private void UCluanvan_Load(object sender, EventArgs e)
        {
            this.bunifuCustomLabel4.Text = tenDeTai;
            this.bunifuCustomLabel6.Text = tenGiaoVienHuongDan;

            double tongUC = 0;
            double tongUChoanthanh = 0;
            YeuCauDAO yeucauDAO = new YeuCauDAO();
            //gửi id sinh viên vào đây 
            List<YeuCau> ycs = yeucauDAO.getYeuCau("10000");
            if (ycs!=null)
            {
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
                int intValue = (int)(currentValue * 100 / 100.0);
                this.label1.Text = intValue.ToString();
            }
        }
         
       
        public void changeColorTextBox(int r, int g, int b)
        {
            bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            label1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            guna2Button1.BorderColor = System.Drawing.Color.FromArgb(r, g, b);
            guna2Button1.BackColor = System.Drawing.Color.FromArgb(r, g, b);

            guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            changeColorTextBox(148, 148, 235);
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            changeColorTextBox(192, 192, 255);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormWatchDetailLuanVanFix frm = new FormWatchDetailLuanVanFix(hp,this);
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
