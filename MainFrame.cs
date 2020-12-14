using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class MainFrame : Form
    {
        public UserInfo UserInfo;
        public UserInfo FriendsInfo=new UserInfo();
        public MainFrame()
        {
            InitializeComponent();
        }
        public MainFrame(UserInfo userInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
          SQLSeverConnect  connect = new SQLSeverConnect();
        string[] s;
        Image Image;
        string head;
        private void MainFrame_Load(object sender, EventArgs e)
        {
            s = new string[connect.SearchFriends(UserInfo.getUserName()).Length];
            this.UserState.SelectedItem = UserInfo.getUserState();
                head = connect.SearchImage(UserInfo.getUserName());
                if (head!= "")
                {

                    switch (head)
                    {
                        case "head1": Image = global::SqlSeverFrame.Properties.Resources._1; break;
                        case "head2": Image = global::SqlSeverFrame.Properties.Resources._2; break;
                        case "head3": Image = global::SqlSeverFrame.Properties.Resources._3; break;
                        case "head4": Image = global::SqlSeverFrame.Properties.Resources._4; break;
                        case "head5": Image = global::SqlSeverFrame.Properties.Resources._5; break;
                        case "head6": Image = global::SqlSeverFrame.Properties.Resources._6; break;
                        case "head7": Image = global::SqlSeverFrame.Properties.Resources._7; break;
                        default: Image = global::SqlSeverFrame.Properties.Resources.empty; break;
                    }
                }
                else
                {
                    Image = global::SqlSeverFrame.Properties.Resources.empty;
                }
            
            this.MainShowHead.Image = Image;
            this.WelcomeLabel.Text = "欢迎！" +connect.SearchNickname(UserInfo.getUserName()).Replace("\\s*", "")+"("+UserInfo.getUserName()+")" + "用户";
            int[] count = new int[connect.SearchFriends(UserInfo.getUserName()).Length];
            for(int i = 0; i <connect.SearchFriends(UserInfo.getUserName()).Length; i++)
            {
                if (connect.SearchFriends(UserInfo.getUserName())[i] != null)
                {
                    
                    s[i] = connect.SearchFriends(UserInfo.getUserName())[i];
                    this.FriendsList.Items.Add(connect.SearchNickname(s[i]).Replace("\\s*", "") + "("+s[i]+")");
                }
                else {
                    s[i] = "";
                    break;
                }
            }
            connect.UpdateIsAlive(UserInfo.getUserName(), "1");
        }


        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.UpdateState(UserInfo.getUserName(), "离线");
            connect.UpdateIsAlive(UserInfo.getUserName(), "0");
        }

        private void UserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.UpdateState(UserInfo.getUserName(), this.UserState.SelectedItem.ToString());
        }



        public static Dictionary<string, string> dc = new Dictionary<string, string>();
        private void FriendsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FriendsInfo.setUserName(s[this.FriendsList.SelectedIndex]);
            if (this.FriendsList.SelectedItem != null) 
            {
                var frm = new Chatting(UserInfo, FriendsInfo);

                if (!dc.ContainsValue(FriendsInfo.getUserName()))
                {
                    
                    frm.Show();
                    dc.Add(FriendsInfo.getUserName(), FriendsInfo.getUserName());
                }
                else
                {
                    frm.TopMost = true;
                }
                

            }
            
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            this.FriendsList.Items.Clear();
            s = new string[connect.SearchFriends(UserInfo.getUserName()).Length];
            this.UserState.SelectedItem = connect.SearchUserState(UserInfo.getUserName());
            UserInfo.setUserState(connect.SearchUserState(UserInfo.getUserName()));
            if(head!= connect.SearchImage(UserInfo.getUserName()))
            {
                if (head != "")
                {
                    switch (head)
                    {
                        case "head1": Image = global::SqlSeverFrame.Properties.Resources._1; break;
                        case "head2": Image = global::SqlSeverFrame.Properties.Resources._2; break;
                        case "head3": Image = global::SqlSeverFrame.Properties.Resources._3; break;
                        case "head4": Image = global::SqlSeverFrame.Properties.Resources._4; break;
                        case "head5": Image = global::SqlSeverFrame.Properties.Resources._5; break;
                        case "head6": Image = global::SqlSeverFrame.Properties.Resources._6; break;
                        case "head7": Image = global::SqlSeverFrame.Properties.Resources._7; break;
                        default: Image = global::SqlSeverFrame.Properties.Resources.empty; break;
                    }
                }
                else
                {
                    Image = global::SqlSeverFrame.Properties.Resources.empty;
                }

                this.MainShowHead.Image = Image;
            }
            this.WelcomeLabel.Text = "欢迎！" + connect.SearchNickname(UserInfo.getUserName()).Replace("\\s*", "") + "(" + UserInfo.getUserName() + ")" + "用户";
            int[] count = new int[connect.SearchFriends(UserInfo.getUserName()).Length];
            for (int i = 0; i < connect.SearchFriends(UserInfo.getUserName()).Length; i++)
            {
                if (connect.SearchFriends(UserInfo.getUserName())[i] != null)
                {

                    s[i] = connect.SearchFriends(UserInfo.getUserName())[i];
                    this.FriendsList.Items.Add(connect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")");
                }
                else
                {
                    s[i] = "";
                    break;
                }
            }
            connect.UpdateIsAlive(UserInfo.getUserName(), "1");
        }

        private void AddFriendsButton_Click(object sender, EventArgs e)
        {
            FriendsMain friends = new FriendsMain(UserInfo);
            friends.Show(this);
        }

        private void FriendApplication_Click(object sender, EventArgs e)
        {
            FriendsApplication application = new FriendsApplication( UserInfo);
            application.Show(this);
        }
    }
}
