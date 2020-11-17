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
            this.UserState.SelectedItem = LoginFrame.LoginState.SelectedItem.ToString();
            this.MainShowHead.Image = LoginFrame.Image;
            this.WelcomeLabel.Text = "欢迎！" +LoginFrame.username+"用户";
        }


        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.UpdateState(LoginFrame.username, "离线");
        }
    }
}
