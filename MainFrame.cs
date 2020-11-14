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

        private void MainFrame_Load(object sender, EventArgs e)
        {
            SQLSeverConnect connect = new SQLSeverConnect();
            DataSet ds = new DataSet();
            connect.sqlDataReader().Fill(ds, "个人信息表");
            this.Table1.DataSource = ds;
            this.Table1.DataMember = "个人信息表";
        }


    }
}
