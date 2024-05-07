using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class ChatDao
    {
        Context context;

        public ChatDao()
        {
            context = new Context();
            context.Database.CreateIfNotExists();
        }

        public void add(Chat chat)
        {
            context.chatTable.Add(chat);
            context.SaveChanges();
        }

        public byte[] convertImageToBytes(Image img)
        {
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            return arr;
        }

        public Image convertBytesToImage(byte[] arr)
        {
            using (MemoryStream ms = new MemoryStream(arr))
            {
                return Bitmap.FromStream(ms);
            }
        }

        public List<Chat> getChats(int idTask, int idGroup)
        {
            List<Chat> chats = context.chatTable
            .Where(c => c.IdTask == idTask && c.IdGroup == idGroup)
            .ToList();
            return chats;
        }

        public string[] formatLines(string[] lines)
        {
            List<string> list = new List<string>(lines);
            int n = list.Count;
            int i = 0;
            while (i < n)
            {
                string line = list[i];
                if (line.Trim() == "")
                {
                    list.RemoveAt(i);
                    n--;
                    continue;
                }
                float sizeLine = getTextSize(line);
                if (sizeLine > 540.7206)
                {
                    string[] split = split2Line(line);
                    list.Remove(line);
                    list.Insert(i, split[0]);
                    list.Insert(i + 1, split[1]);
                    n++;
                }
                i++;
            }
            return list.ToArray();
        }

        public string[] split2Line(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                string s = line.Substring(0, i + 1).Trim();
                if (getTextSize(s) > 540.7206)
                {
                    string[] newlines = new string[2];
                    for (int j = i - 1; j >= i - 15; j--)
                    {
                        if (line[j] == ' ')
                        {
                            i = j;
                            break;
                        }
                    }
                    newlines[0] = line.Substring(0, i).Trim();
                    newlines[1] = line.Substring(i).Trim();
                    return newlines;
                }
            }
            return null;
        }

        private float getTextSize(string text)
        {
            Font font = new Font("Segoe UI", 9.0F);
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(text, font);
            return size.Width;
        }
    }
}
