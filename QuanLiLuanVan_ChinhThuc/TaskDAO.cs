using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc
{
    internal class TaskDAO
    {
        public TaskDAO() { }
        public void add(TaskLV task) 
        {
            string query = string.Format("insert into Task(IDLuanVan,NoiDung,ThoiHan,TrangThai) values ({0},'{1}','{2}',{3})", task.IdLuanVan, task.NoiDung, task.FormatNgay(),task.TrangThai);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Them that bai!");
            else
                MessageBox.Show("Them thanh cong!");
        }
        public void Update(TaskLV task) 
        {
            string query = string.Format("Update Task set TrangThai={0} where MaTask={1}",task.TrangThai,task.MaTask);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Cap nhat that bai!");
            else
                MessageBox.Show("Cap nhat thanh cong!");
        }
        public void Delete(TaskLV task)
        {
            string query = string.Format("Delete Task where MaTask={0}",task.MaTask);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Xoa that bai!");
            else
                MessageBox.Show("Xoa thanh cong!");
        }
    }
}
