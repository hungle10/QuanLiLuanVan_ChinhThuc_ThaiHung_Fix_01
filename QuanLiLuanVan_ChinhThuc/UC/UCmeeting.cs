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

namespace QuanLiLuanVan_ChinhThuc.UC
{
    public partial class UCmeeting : UserControl
    {
        private Meeting mt;
        public Meeting Mt 
        { get { return mt; }
          set { mt = value; } 
        }     
        public Label lbGroup
        {
            get { return lbIDgroup; }
            set { lbIDgroup = value; }     
        }
        public Label lbThoiGian
        {
            get { return lbLichHen; }
            set { lbLichHen = value; }
        }
        public CheckBox checkbox
        {
            get { return ckbMeeting; }
        }

        public UCmeeting(Meeting meeting)
        {
            InitializeComponent();
            this.mt = meeting;
        }

        private void UCmeeting_Load(object sender, EventArgs e)
        {

        }
    }
}
