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
        SQLSeverConnect connect = new SQLSeverConnect();
        private void MainFrame_Load(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            connect.sqlDataReader().Fill(ds, "个人信息表");
            dataGridView1.DataSource = ds.Tables[0];
            //设置数据表格上显示的列标题
            dataGridView1.Columns[0].HeaderText = "姓名";
            dataGridView1.Columns[1].HeaderText = "年龄";
            dataGridView1.Columns[2].HeaderText = "出生日期";
            dataGridView1.RowHeadersVisible = false;
            //设置数据表格为只读
            dataGridView1.ReadOnly = true;
            //不允许添加行
            dataGridView1.AllowUserToAddRows = false;
            //背景为白色
            dataGridView1.BackgroundColor = Color.White;
            //只允许选中单行
            dataGridView1.MultiSelect = false;
            //整行选中
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MainShowHead.Image = LoginFrame.Image;
            this.WelcomeLabel.Text = "欢迎！" +LoginFrame.username+"用户";
        }


        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.UpdateState(LoginFrame.username, "离线");
        }
    }
}
