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
    public partial class FormWatchDetailOfDeTai : Form
    {
        private string tenDeTai;
        private string tenGiaoVien;
        private string noiDungs;
        private List<string> noiDung;  
        
        public FormWatchDetailOfDeTai(string tenDeTai,string tenGiaoVien,string noiDungs)
        {
            this.tenDeTai = tenDeTai;     
            this.tenGiaoVien = tenGiaoVien;     
            this.noiDungs = noiDungs;
         
                
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormWatchDetailOfDeTai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.label2.Text = tenDeTai;
           this.label4.Text= tenGiaoVien;
            string[] mangChuoi = noiDungs.Split(new string[] { "\n" }, StringSplitOptions.None);
            // Chuyển đổi mảng thành danh sách List<string>
            noiDung = new List<string>(mangChuoi);
            foreach (string chuoi in noiDung)
            {
                UCnoidungBB uc = new UCnoidungBB(chuoi);
                this.flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void uCnoidungBB2_Load(object sender, EventArgs e)
        {

        }

        private void uCnoidungBB1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
