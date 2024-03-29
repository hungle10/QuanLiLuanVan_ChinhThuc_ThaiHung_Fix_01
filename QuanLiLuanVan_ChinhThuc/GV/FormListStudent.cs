using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormListStudent : Form
    {
        public FormListStudent()
        {
            InitializeComponent();
            LoadSV();
        }
        public void LoadSV(string key="")
        {
            flpSV.Controls.Clear();
            //DataTable dt = DataProvider.Instance.GetTable("TaiKhoan");
            string s = string.Format("IDGiangVien ='{0}' and HoTen", UserInfo.giaoVien.HoTen);
            DataTable dt = DataProvider.Instance.GetTableWithKey("SinhVien inner join DangKi on SinhVien.ID= DangKi.IDSinhVien", s, key);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                SinhVien sv = new SinhVien(int.Parse(row["ID"].ToString()), row["HoTen"].ToString(), row["Lop"].ToString());
                LuanVanDao dao= new LuanVanDao();
                LuanVan lv= dao.GetLVByIDLV(row["IDLuanVan"].ToString());
                ucSV uc=new ucSV();
                uc.lbHoTen.Text = sv.HoTen;
                uc.lbIdDangKi.Text = lv.IDLuanVan.ToString();
                uc.lbLop.Text=sv.Lop;
                uc.lbTenDeTai.Text = lv.TenLuanVan;
                flpSV.Controls.Add(uc);
                //uc.Click += new EventHandler(ucTK_Click);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
    
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormWatchDetailOfGiangVien frm = new FormWatchDetailOfGiangVien();
            frm.ShowDialog();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
