using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class FriendsApplication : Form
    {
        UserInfo UserInfo = new UserInfo();
        public FriendsApplication()
        {
            InitializeComponent();
        }
        public FriendsApplication(UserInfo userInfo )
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
         SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();
        private void FriendsApplication_Load(object sender, EventArgs e)
        {
            string [] s = new string[SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName()).Length];
            for (int i = 0; i < SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName()).Length; i++)
            {
                if (SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[i] != null)
                {

                    s[i] = SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[i];
                    this.ShowFriends.Items.Add(SQLSeverConnect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")"+"验证消息:"+SQLSeverConnect.SearchFriendsApplicationMessage(s[i], UserInfo.GetUserName()));
                }
                else
                {
                    s[i] = "";
                    break;
                }
            }
        }

        private void Agree_Click(object sender, EventArgs e)
        {
            if (this.ShowFriends.SelectedItem != null)
            {
                SQLSeverConnect.AddFriends(UserInfo.GetUserName(), SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex]);
                SQLSeverConnect.AddFriends(SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex], UserInfo.GetUserName());
                SQLSeverConnect.DeleteApplication(SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex], UserInfo.GetUserName());
                Refresh_Click(sender, e);
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("请选择要同意的好友申请","提示");
            }

        }

        private void ShowFriends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ShowFriends.SelectedItem != null)
            {
                SQLSeverConnect.AddFriends(UserInfo.GetUserName(), SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex]);
                SQLSeverConnect.AddFriends(SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex], UserInfo.GetUserName());
                SQLSeverConnect.DeleteApplication(SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[this.ShowFriends.SelectedIndex], UserInfo.GetUserName());
                Refresh_Click(sender, e);
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("请选择要同意的好友申请", "提示");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.ShowFriends.Items.Clear();
            string[] s = new string[SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName()).Length];
            for (int i = 0; i < SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName()).Length; i++)
            {
                if (SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[i] != null)
                {

                    s[i] = SQLSeverConnect.SearchFriendsApplication(UserInfo.GetUserName())[i];
                    this.ShowFriends.Items.Add(SQLSeverConnect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")" + "验证消息:" + SQLSeverConnect.SearchFriendsApplicationMessage(s[i], UserInfo.GetUserName()));
                }
                else
                {
                    s[i] = "";
                    break;
                }
            }
        }
    }
}
