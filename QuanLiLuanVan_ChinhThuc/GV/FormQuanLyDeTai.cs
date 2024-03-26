using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Management;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormQuanLyDeTai : Form
    {
        DBConnection dBConn = new DBConnection();
        LuanVanDao luanVanDao = new LuanVanDao();
        public FormQuanLyDeTai()
        {
            InitializeComponent();
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormQuanLyDeTai_Load(object sender, EventArgs e)
        {
            loadPanel();    
        }

        public void loadPanel(string key="")
        {
            flowLayoutPanel1.Controls.Clear();
            string query = string.Format("SELECT * FROM LuanVan WHERE (LuanVan.IDLuanVan NOT IN (SELECT IDLuanVan FROM Duyet)) and GiangVien like '%{0}%' and TenLuanVan like '%{1}%' ", UserInfo.giaoVien.HoTen,key);
            DataTable dt = dBConn.Excute(query);
            if(dt==null || dt.Rows.Count == 0 ) 
            {
                MessageBox.Show("khong the tim thay thong tin !");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                LuanVan luanVan = luanVanDao.convert(dr);
                UCdetai uc = new UCdetai(luanVan);
                uc.Guna2Button3.Click += Guna2Button3_Click;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            loadPanel();
        }

        private void detaiClick(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fThemDeTai fdetai = new fThemDeTai();
            fdetai.FormClosed += Fdetai_FormClosed;
            fdetai.ShowDialog();
            
        }

     
        public void Fdetai_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadPanel();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadPanel(tbTimKiem.Text);
        }

    }
}
