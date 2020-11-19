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
        public static string Friends;
        public static string FriendsName;
        SQLSeverConnect connect = new SQLSeverConnect();
        private void MainFrame_Load(object sender, EventArgs e)
        {

            string s;
            this.UserState.SelectedItem = LoginFrame.LoginState.SelectedItem.ToString().Replace("\\s*", "");
            this.MainShowHead.Image = LoginFrame.Image;
            this.WelcomeLabel.Text = "欢迎！" +connect.SearchNickname(LoginFrame.username)+"用户";
            for(int i = 0; i <connect.SearchFriends(LoginFrame.username).Length; i++)
            {
                if (connect.SearchFriends(LoginFrame.username)[i] != null)
                {
                    s = connect.SearchFriends(LoginFrame.username)[i];
                    FriendsName = s;
                    MessageBox.Show(connect.SearchFriends(LoginFrame.username)[i], "提示");
                    this.FriendsList.Items.Add(connect.SearchNickname(s)+"("+s+")");
                }
                else { break; }
            }
            connect.UpdateIsAlive(LoginFrame.username, "1");
        }


        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.UpdateState(LoginFrame.username, "离线");
            connect.UpdateIsAlive(LoginFrame.username, "0");
        }

        private void UserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.UpdateState(LoginFrame.username, this.UserState.SelectedItem.ToString());
        }

        private void FriendsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Friends = this.FriendsList.SelectedItem.ToString();
            var frm = new Chatting();
            frm.Show();
        }
    }
}
