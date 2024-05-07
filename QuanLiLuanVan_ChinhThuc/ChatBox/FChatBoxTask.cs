using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiLuanVan_ChinhThuc.ChatBox;
using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class FChatBoxTask : Form
    {
        Timer timer;
        int thuTuNow;
        int idNhan, idTask, idGroup;
        NhomDAO nhomDAO = new NhomDAO();
        ChatDao chatDao = new ChatDao();
        GiaoVienDAO giaoVienDao = new GiaoVienDAO();
        public FChatBoxTask(int idNhan, int idTask)
        {
            InitializeComponent();
            thuTuNow = 0;
            this.idNhan = idNhan;
            this.idTask = idTask;
            idGroup = nhomDAO.GetIDGroupByMemBerID(idNhan);
            loadChats();
            createTimer();
            this.FormClosed += FChatBoxTask_FormClosed;
        }

        private void FChatBoxTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        public void createTimer()
        {
            timer = new Timer();
            timer.Interval = 7000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void loadChats()
        {
            List<Chat> list = chatDao.getChats(idTask, idGroup);
            foreach (Chat chat in list)
            {
                if (chat.ThuTu > thuTuNow)
                {
                    int idGui = -1;
                    if (UserInfo.user == "Hoc Sinh")
                    {
                        idGui = 5;
                    }
                    else if (UserInfo.user == "Giao Vien")
                    {
                        idGui = 10;

                    }
                    thuTuNow = chat.ThuTu;
                    string nd = chat.NoiDung;
                    if (chat.NguoiGui==idGui)
                    {
                        if (nd.EndsWith("@[1IMG2]@"))
                        {
                            byte[] bytes = Convert.FromBase64String(nd.Substring(0, nd.Length - 9));
                            Image img = chatDao.convertBytesToImage(bytes);
                            chatBoxPanel.Controls.Add(new ucImgRight(img));
                            continue;
                        }
                        chatBoxPanel.Controls.Add(new ucMessageRight(toLines(nd)));
                    }
                    else
                    {
                        if (nd.EndsWith("@[1IMG2]@"))
                        {
                            byte[] bytes = Convert.FromBase64String(nd.Substring(0, nd.Length - 9));
                           
                            Image img = chatDao.convertBytesToImage(bytes);
                            chatBoxPanel.Controls.Add(new ucImgLeft(img));
                            continue;
                        }
                        chatBoxPanel.Controls.Add(new ucMessageLeft(toLines(nd)));

                    }
                }
            }
        }

        public string[] toLines(string nd)
        {
            string[] splits = nd.Split('\n');
            return splits;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opf.FileName);
                byte[] bytes = chatDao.convertImageToBytes(img);
                chatBoxPanel.Controls.Add(new ucImgRight(img));
                int idGui = -1;
                if (UserInfo.user == "Hoc Sinh")
                {
                    idGui = 5;
                    idNhan = giaoVienDao.GetGiaoVienByName(DataStorage.luanVan.GiangVien).Id;
                }
                else if (UserInfo.user == "Giao Vien")
                {
                    idGui = 10;

                }
                string encode = Convert.ToBase64String(bytes);
                Chat chat = new Chat(idTask, idGroup, thuTuNow + 1, idGui, idNhan, encode+"@[1IMG2]@");
                chatDao.add(chat);
                thuTuNow++;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            loadChats();    
        }

        public void send()
        {
            chatBoxPanel.Controls.Add(new ucMessageRight(txtChat.Lines));
            int idGui = -1;
            
            if (UserInfo.user == "Hoc Sinh")
            {
                idGui = 5;
                idNhan = giaoVienDao.GetGiaoVienByName(DataStorage.luanVan.GiangVien).Id;
            }
            else if (UserInfo.user == "Giao Vien")
            {
                idGui = 10;

            }
            string s = "";
            foreach (string ss in txtChat.Lines)
            {
                s += "\n" + ss;
            }
            Chat chat = new Chat(idTask, idGroup, thuTuNow + 1, idGui, idNhan, s);
            chatDao.add(chat);
            thuTuNow++;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
            txtChat.Clear();
        }
    }
}
