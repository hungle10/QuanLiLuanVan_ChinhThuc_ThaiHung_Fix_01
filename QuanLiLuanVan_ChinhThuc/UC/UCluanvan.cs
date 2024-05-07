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
            get { return this.lbTienDo; }
            set { this.lbTienDo = value; } }       
        private void UCluanvan_Load(object sender, EventArgs e)
        {
            NhomDAO dao = new NhomDAO();
            DataStorage.nhom = new Nhom(dao.GetIDGroupByMemBer(UserInfo.sinhVien));
            this.bunifuCustomLabel4.Text = tenDeTai;
            this.bunifuCustomLabel6.Text = tenGiaoVienHuongDan;
            string query = string.Format("Select * from Task where IDGroup ='{0}'", DataStorage.nhom.IDGroup);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            int d = 0;
            float tiendo = 0;
            foreach (DataRow row in dt.Rows)
            {
                TaskLV task = new TaskLV(int.Parse(row["MaTask"].ToString()), int.Parse(row["IDGroup"].ToString()), int.Parse(row["IDLuanVan"].ToString()), row["NoiDung"].ToString(), DateTime.Parse(row["ThoiHan"].ToString()), int.Parse(row["TienDo"].ToString()));
                tiendo += task.TienDo;
                d++;
            }
            tiendo = ((float)tiendo / d);
            int k = (int)tiendo;
            lbTienDo.Text=k.ToString();     
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
            lbTienDo.BackColor = System.Drawing.Color.FromArgb(r, g, b);
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
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            
            LuanVanDao daoLV = new LuanVanDao();
            LuanVan lv = daoLV.GetLVByGroup(DataStorage.nhom);
            FormWatchDetailOfDeTai frm = new FormWatchDetailOfDeTai(lv.TenLuanVan, lv.GiangVien, lv.ChiTiet);
            if (lv == null)
            {
                MessageBox.Show("Khong tim thay luan van");
                return;
            }
            DataStorage.luanVan = lv;
            frm.ShowDialog();
            DataStorage.homePage.LoadLuanVan();
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            NhomDAO ndao= new NhomDAO();
            Nhom n = new Nhom(ndao.GetIDGroupByMemBer(UserInfo.sinhVien));
            LuanVanDao dao = new LuanVanDao();
            DataStorage.luanVan = dao.GetLVByGroup(n);
            DataStorage.nhom = n;
            fDSNhom f = new fDSNhom();
            f.ShowDialog();
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            fListLichHen fListLichHen=new fListLichHen();
            fListLichHen.ShowDialog();
        }
    }
}
