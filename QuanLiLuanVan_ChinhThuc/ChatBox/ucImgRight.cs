using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.ChatBox
{
    public partial class ucImgRight : UserControl
    {
        public ucImgRight(Image img)
        {
            InitializeComponent();
            picBox.Image = img;
        }
    }
}
