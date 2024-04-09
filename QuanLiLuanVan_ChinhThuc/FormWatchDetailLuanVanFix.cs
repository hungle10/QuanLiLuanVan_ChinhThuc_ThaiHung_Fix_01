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
              
            }

       
        }
    }
}
