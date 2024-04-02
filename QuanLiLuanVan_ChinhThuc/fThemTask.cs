using QuanLiLuanVan_ChinhThuc.GV;
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
    public partial class fThemTask : Form
    {
        public fThemTask()
        {
            InitializeComponent();
        }

        private void btnThemTask_Click(object sender, EventArgs e)
        {
            TaskLV t=new TaskLV(DataStorage.nhom.IDGroup,DataStorage.luanVan.IDLuanVan,tbNoiDung.Text,dtpThoiHan.Value,0);
            TaskDAO dao=new TaskDAO();
            dao.add(t);
            this.Close();
        }
    }
}
