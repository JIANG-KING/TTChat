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
            string [] s = new string[SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName()).Length];
            for (int i = 0; i < SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName()).Length; i++)
            {
                if (SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[i] != null)
                {

                    s[i] = SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[i];
                    this.ShowFriends.Items.Add(SQLSeverConnect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")"+"验证消息:"+SQLSeverConnect.SearchFriendsApplicationMessage(s[i], UserInfo.getUserName()));
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
                SQLSeverConnect.AddFriends(UserInfo.getUserName(), this.ShowFriends.SelectedItem.ToString());
                SQLSeverConnect.DeleteApplication(UserInfo.getUserName(), this.ShowFriends.SelectedItem.ToString());
                refresh_Click(sender,e);
            }
            else
            {
                MessageBox.Show("请选择要同意的好友申请","提示");
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.ShowFriends.Items.Clear();
            string[] s = new string[SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName()).Length];
            for (int i = 0; i < SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName()).Length; i++)
            {
                if (SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[i] != null)
                {

                    s[i] = SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[i];
                    this.ShowFriends.Items.Add(SQLSeverConnect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")" + "验证消息:" + SQLSeverConnect.SearchFriendsApplicationMessage(s[i], UserInfo.getUserName()));
                }
                else
                {
                    s[i] = "";
                    break;
                }
            }
        }

        private void ShowFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowFriends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ShowFriends.SelectedItem != null)
            {
                SQLSeverConnect.AddFriends(UserInfo.getUserName(), SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[this.ShowFriends.SelectedIndex]);
                SQLSeverConnect.AddFriends(SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[this.ShowFriends.SelectedIndex], UserInfo.getUserName());
                MessageBox.Show(SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[this.ShowFriends.SelectedIndex], "");
                SQLSeverConnect.DeleteApplication(SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName())[this.ShowFriends.SelectedIndex], UserInfo.getUserName());
                refresh_Click(sender, e);
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("请选择要同意的好友申请", "提示");
            }
        }
    }
}
