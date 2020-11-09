using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string con = "Server=yunking.database.windows.net;Database=LoginInfo;user id=jiangyun;pwd=Jy1019878449";  //这里是保存连接数据库的字符串  
            SqlConnection sqlCnt = new SqlConnection(con);
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("select * from 个人信息表", sqlCnt);
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "个人信息表");
            SqlDataReader reader1 = com.ExecuteReader();
            string s=" ";
            while (reader1.Read())
            {
                s = s + reader1["姓名"]+reader1["年龄"]+reader1["生日"];
            }
            this.TextOutPut.Text = s;
            this.Table1.DataSource = ds;
            this.Table1.DataMember = "个人信息表";
            sqlCnt.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeMainFrame_Tick(object sender, EventArgs e)
        {
            int i = 0;
            for(i=0; i <=100; i++)
            {
                this.LoadTime.Value = i;
                Thread.Sleep(1);
            }
            string con = "Server=yunking.database.windows.netj,;Database=LoginInfo;user id=jiangyun;pwd=Jy1019878449";  //这里是保存连接数据库的字符串  
            SqlConnection sqlCnt = new SqlConnection(con);
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("select * from 个人信息表", sqlCnt);
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "个人信息表");
            SqlDataReader reader1 = com.ExecuteReader();
            string s = "";
            while (reader1.Read())
            {
                s = s + reader1["姓名"] + reader1["年龄"] + reader1["生日"]+ Environment.NewLine;
            }
            this.TextOutPut.Text = s;
            this.Table1.DataSource = ds;
            this.Table1.DataMember = "个人信息表";
            sqlCnt.Close();
        }
    }
}
