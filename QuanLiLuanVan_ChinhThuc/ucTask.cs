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
    public partial class ucTask : UserControl
    {
        public ucTask()
        {
            InitializeComponent();
        }
        public Label lbThoiHan
        {
            get { return ucLbThoiHan; }
            set { ucLbThoiHan = value; }
        }
        public Label lbId
        {
            get { return ucLbId; }
            set { ucLbId = value; }
        }
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox tbNoiDung
        {
            get { return ucTbNoiDung; }
            set { ucTbNoiDung = value; }
        }
        public Guna.UI2.WinForms.Guna2CheckBox chbHoanThanh
        {
            get { return ucChbHoanThanh; }
            set {  ucChbHoanThanh = value;}

        }

        private void ucChbHoanThanh_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (chbHoanThanh.Checked == false)
                check = 0;
            else
                check = 1;
            TaskLV t = new TaskLV(int.Parse(ucLbId.Text), check);
            TaskDAO dao = new TaskDAO();
            dao.Update(t);
        }
    }
}
