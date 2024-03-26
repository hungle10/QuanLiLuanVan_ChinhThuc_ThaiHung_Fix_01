using System;
using System.Data;
using System.Data.SqlClient;
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

        public void loadPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = dBConn.Excute("SELECT * FROM LuanVan WHERE LuanVan.IDLuanVan NOT IN (SELECT IDLuanVan FROM Duyet) ");
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
    }
}
