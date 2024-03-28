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
        public FormWatchDetailOfDeTai()
        {
            InitializeComponent();
        }
        public void LoadTask()
        {
            flpTask.Controls.Clear();
            int id = DataStorage.luanVan.IDLuanVan;
            //DataTable dt = DataProvider.Instance.GetTable("GiaoVien");
            string query = string.Format("Select * from Task where IDLuanVan ='{0}'", id.ToString());
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaskLV task = new TaskLV(int.Parse(row["MaTask"].ToString()), int.Parse(row["IDLuanVan"].ToString()), row["NoiDung"].ToString(), DateTime.Parse(row["ThoiHan"].ToString()), int.Parse(row["TrangThai"].ToString()));
                ucTask uc = new ucTask();
                uc.tbNoiDung.Text = task.NoiDung;
                uc.lbThoiHan.Text = task.FormatNgay();
                uc.lbId.Text = task.MaTask.ToString();
                if (task.TrangThai == 1)
                    uc.chbHoanThanh.Checked = true;
                else
                    uc.chbHoanThanh.Checked = false;
                flpTask.Controls.Add(uc);
            }
        }
            private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void FormWatchDetailOfDeTai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.tenDeTai = DataStorage.luanVan.TenLuanVan;
            this.tenGiaoVien = DataStorage.luanVan.GiangVien;
            this.label2.Text = tenDeTai;
            this.label4.Text = tenGiaoVien;
            if (UserInfo.user == "Hoc Sinh")
                btnThemTask.Visible = false;
            /*string[] mangChuoi = noiDungs.Split(new string[] { "\n" }, StringSplitOptions.None);
            // Chuyển đổi mảng thành danh sách List<string>
            noiDung = new List<string>(mangChuoi);
            foreach (string chuoi in noiDung)
            {
                UCnoidungBB uc = new UCnoidungBB(chuoi);
                this.flpTask.Controls.Add(uc);
            }*/
            LoadTask();
        }

        private void btnThemTask_Click(object sender, EventArgs e)
        {
            fThemTask f=new fThemTask();
            f.ShowDialog();
            LoadTask();
        }
    }
}
