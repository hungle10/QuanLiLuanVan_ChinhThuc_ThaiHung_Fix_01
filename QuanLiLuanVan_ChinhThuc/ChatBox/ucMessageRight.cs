using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiLuanVan_ChinhThuc.Object;


namespace QuanLiLuanVan_ChinhThuc.ChatBox
{
    public partial class ucMessageRight : UserControl
    {
        ChatDao messageDao = new ChatDao();
        public ucMessageRight(string[] lines)
        {
            
            InitializeComponent();
            txtMessage.Lines = messageDao.formatLines(lines);
            int n = txtMessage.Lines.Length;
            txtMessage.Height = txtMessage.Height + 21 * (n - 1);
            this.Height = this.Height + 21 * (n - 1);
            txtMessage.BorderRadius = 10;

        }

        

       
    }
}
