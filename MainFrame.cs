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
        static  SQLSeverConnect  connect = new SQLSeverConnect();

        string[] s = new string[MainFrame.connect.SearchFriends(LoginFrame.username).Length];
        private void MainFrame_Load(object sender, EventArgs e)
        {

            this.UserState.SelectedItem = LoginFrame.LoginState.SelectedItem.ToString().Replace("\\s*", "");
            this.MainShowHead.Image = LoginFrame.Image;
            this.WelcomeLabel.Text = "欢迎！" +connect.SearchNickname(LoginFrame.username).Replace("\\s*", "") + "用户";
            int[] count = new int[connect.SearchFriends(LoginFrame.username).Length];
            for(int i = 0; i <connect.SearchFriends(LoginFrame.username).Length; i++)
            {
                if (connect.SearchFriends(LoginFrame.username)[i] != null)
                {
                    
                    s[i] = connect.SearchFriends(LoginFrame.username)[i];
                    this.FriendsList.Items.Add(connect.SearchNickname(s[i]).Replace("\\s*", "") + "("+s[i]+")");
                }
                else {
                    s[i] = "";
                    break;
                }
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
            FriendsName = s[this.FriendsList.SelectedIndex];
            var frm = new Chatting();
            frm.Show();
        }
    }
}
