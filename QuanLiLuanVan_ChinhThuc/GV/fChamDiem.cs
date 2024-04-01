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

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class fChamDiem : Form
    {
        public fChamDiem()
        {
            InitializeComponent();
            LoadLuanVan();
        }
        public void LoadLuanVan()
        {
            lbTenDeTai.Text = DataStorage.luanVan.TenLuanVan;
        }
        public bool checkInput()
        {
            float s;
            if (tbDiem.Text == "" || tbNhanXet.Text ==""|| float.TryParse(tbDiem.Text, out s) == false)
            {
                MessageBox.Show("Hay dien day du thong tin va thu lai !");
                return false;
            }
            else return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;
            DiemLV d=new DiemLV(DataStorage.luanVan.IDLuanVan,float.Parse(tbDiem.Text),tbNhanXet.Text);
            DiemLVDAO dao = new DiemLVDAO();
            dao.Add(d);
        }
    }
}
