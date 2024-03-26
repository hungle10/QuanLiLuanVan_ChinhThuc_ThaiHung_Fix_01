using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using QuanLiLuanVan_ChinhThuc.UC;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormDangKyDeTai : Form
    {
        DBConnection dBConn = new DBConnection();
        LuanVanDao luanVanDao = new LuanVanDao();
        DangKyDao dkd = new DangKyDao();
        public FormDangKyDeTai()
        {
            InitializeComponent();
        }

        private void FormDangKyDeTai_Load(object sender, EventArgs e)
        {
            loadPanel();
        }

        

        public void loadPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = dBConn.Excute("SELECT * FROM LuanVan WHERE LuanVan.IDLuanVan NOT IN (SELECT IDLuanVan FROM Duyet)");
            foreach (DataRow dr in dt.Rows)
            {
                LuanVan luanVan = luanVanDao.convert(dr);
                UCdetaidk uc = new UCdetaidk(luanVan);
                uc.Guna2Button3.Click += guna2Button3_Click;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DangKy dk = dkd.getFromIDSinhVien("10000");
            if (dk == null)
            {
                FormAddDeTaiDuyet fadd = new FormAddDeTaiDuyet();
                fadd.ShowDialog();
                return;
            }
               
            if (!dkd.checkDKDetaiDangDuyet(dk))
            {
                
                if (dkd.daDK(dk))
                {
                    MessageBox.Show("Bạn đã đăng kí đề tài rồi, không thể thêm đề tài!");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Bạn đã có đề tài đang chờ duyệt rồi!");
            }
        }
    }
}
