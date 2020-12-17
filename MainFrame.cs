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
            s = new string[connect.SearchFriends(UserInfo.GetUserName()).Length];
            this.UserState.SelectedItem = UserInfo.GtUserState();
                head = connect.SearchImage(UserInfo.GetUserName());
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
            this.WelcomeLabel.Text = "欢迎！" +connect.SearchNickname(UserInfo.GetUserName()).Replace("\\s*", "")+"("+UserInfo.GetUserName()+")" + "用户";
            for(int i = 0; i <connect.SearchFriends(UserInfo.GetUserName()).Length; i++)
            {
                if (connect.SearchFriends(UserInfo.GetUserName())[i] != null)
                {
                    
                    s[i] = connect.SearchFriends(UserInfo.GetUserName())[i];
                    this.FriendsList.Items.Add(connect.SearchNickname(s[i]).Replace("\\s*", "") + "("+s[i]+")");
                }
                else {
                    s[i] = "";
                    break;
                }
            }
            connect.UpdateIsAlive(UserInfo.GetUserName(), "1");


            if (connect.SearchFriendsApplication(UserInfo.GetUserName())[0] != null)
            {
                this.newApplication.Visible = true;
            }
            else
            {
                this.newApplication.Visible = false;
            }

        }


        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            connect.UpdateState(UserInfo.GetUserName(), "离线");
            connect.UpdateIsAlive(UserInfo.GetUserName(), "0");
            Application.Restart();
            

        }

        private void UserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.UpdateState(UserInfo.GetUserName(), this.UserState.SelectedItem.ToString());
        }



        public static Dictionary<string, string> dc = new Dictionary<string, string>();
        private void FriendsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FriendsInfo.SetUserName(s[this.FriendsList.SelectedIndex]);
            if (this.FriendsList.SelectedItem != null) 
            {
                var frm = new Chatting(UserInfo, FriendsInfo);

                if (!dc.ContainsValue(FriendsInfo.GetUserName()))
                {
                    
                    frm.Show();
                    dc.Add(FriendsInfo.GetUserName(), FriendsInfo.GetUserName());
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
            s = new string[connect.SearchFriends(UserInfo.GetUserName()).Length];
            this.UserState.SelectedItem = connect.SearchUserState(UserInfo.GetUserName());
            UserInfo.SetUserState(connect.SearchUserState(UserInfo.GetUserName()));
            if(head!= connect.SearchImage(UserInfo.GetUserName()))
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
            this.WelcomeLabel.Text = "欢迎！" + connect.SearchNickname(UserInfo.GetUserName()).Replace("\\s*", "") + "(" + UserInfo.GetUserName() + ")" + "用户";
            for (int i = 0; i < connect.SearchFriends(UserInfo.GetUserName()).Length; i++)
            {
                if (connect.SearchFriends(UserInfo.GetUserName())[i] != null)
                {

                    s[i] = connect.SearchFriends(UserInfo.GetUserName())[i];
                    this.FriendsList.Items.Add(connect.SearchNickname(s[i]).Replace("\\s*", "") + "(" + s[i] + ")");
                }
                else
                {
                    s[i] = "";
                    break;
                }
            }
            connect.UpdateIsAlive(UserInfo.GetUserName(), "1");
            if (connect.SearchFriendsApplication(UserInfo.GetUserName())[0] != null)
            {
                this.newApplication.Visible = true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrame login = new LoginFrame();
            login.Show(this);
            this.Close();
            this.Dispose();
            this.OnClosed(e);
        }

    }
}
