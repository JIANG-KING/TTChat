using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TTChat
{
    public partial class MainFrame : Form
    {
        public UserInfo UserInfo=new UserInfo();
        public UserInfo FriendsInfo=new UserInfo();
        public UserInfo DeleteFriends=new UserInfo();
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
                head = connect.SearchImage(UserInfo.GetUserName()).Trim();
                if (head!= "")
                {

                    switch (head)
                    {
                        case "head1": Image = global::TTChat.Properties.Resources._1; break;
                        case "head2": Image = global::TTChat.Properties.Resources._2; break;
                        case "head3": Image = global::TTChat.Properties.Resources._3; break;
                        case "head4": Image = global::TTChat.Properties.Resources._4; break;
                        case "head5": Image = global::TTChat.Properties.Resources._5; break;
                        case "head6": Image = global::TTChat.Properties.Resources._6; break;
                        case "head7": Image = global::TTChat.Properties.Resources._7; break;
                        default: Image = global::TTChat.Properties.Resources.empty; break;
                    }
                }
                else
                {
                    Image = global::TTChat.Properties.Resources.empty;
                }
            
            this.MainShowHead.Image = Image;
            this.WelcomeLabel.Text = "欢迎！" +connect.SearchNickname(UserInfo.GetUserName()).Replace("\\s*", "")+"("+UserInfo.GetUserName()+")" + "用户";
            this.PersonalSignatureLabel.Text = "个性签名：" + connect.Signature(UserInfo.GetUserName());
            for (int i = 0; i <connect.SearchFriends(UserInfo.GetUserName()).Length; i++)
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
            

        }

        private void UserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.UpdateState(UserInfo.GetUserName(), this.UserState.SelectedItem.ToString());
        }


        public static Dictionary<string, Form> FormList = new Dictionary<string, Form>();
        Chatting[] chat ;
        private void FriendsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FriendsInfo.SetUserName(s[this.FriendsList.SelectedIndex]);
            chat = new Chatting[2000];
            if (this.FriendsList.SelectedItem != null) 
            {
                if (!FormList.ContainsKey(FriendsInfo.GetUserName()))
                {
                    chat[this.FriendsList.SelectedIndex] = new Chatting(UserInfo, FriendsInfo);            
                    chat[this.FriendsList.SelectedIndex].Show();
                    FormList.Add(FriendsInfo.GetUserName(), chat[this.FriendsList.SelectedIndex]);
                }
                else
                {
                    FormList[FriendsInfo.GetUserName()].TopMost = true;
                    FormList[FriendsInfo.GetUserName()].TopMost = false;
                }
            }
            
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            this.FriendsList.Items.Clear();
            s = new string[connect.SearchFriends(UserInfo.GetUserName()).Length];
            this.UserState.SelectedItem = connect.SearchUserState(UserInfo.GetUserName());
            UserInfo.SetUserState(connect.SearchUserState(UserInfo.GetUserName()));
            if(head!= connect.SearchImage(UserInfo.GetUserName().Trim()))
            {
                if (head != "")
                {
                    head = connect.SearchImage(UserInfo.GetUserName().Trim());
                    switch (head)
                    {
                        case "head1": Image = global::TTChat.Properties.Resources._1; break;
                        case "head2": Image = global::TTChat.Properties.Resources._2; break;
                        case "head3": Image = global::TTChat.Properties.Resources._3; break;
                        case "head4": Image = global::TTChat.Properties.Resources._4; break;
                        case "head5": Image = global::TTChat.Properties.Resources._5; break;
                        case "head6": Image = global::TTChat.Properties.Resources._6; break;
                        case "head7": Image = global::TTChat.Properties.Resources._7; break;
                        default: Image = global::TTChat.Properties.Resources.empty; break;
                    }
                }
                else
                {
                    Image = global::TTChat.Properties.Resources.empty;
                }

                this.MainShowHead.Image = Image;
            }
            this.WelcomeLabel.Text = "欢迎！" + connect.SearchNickname(UserInfo.GetUserName()).Replace("\\s*", "") + "(" + UserInfo.GetUserName() + ")" + "用户";
            this.PersonalSignatureLabel.Text = "个性签名：" + connect.Signature(UserInfo.GetUserName());
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
            if (connect.SearchFriendsApplication(UserInfo.GetUserName())[0] == null)
            {
                this.newApplication.Visible = false;
            }
        }
        public static Dictionary<string, Form> AddFriendsForm = new Dictionary<string, Form>();
        private void AddFriendsButton_Click(object sender, EventArgs e)
        {
            if (!AddFriendsForm.ContainsKey(UserInfo.GetUserName()))
            {
                AddFriendsMain friends = new AddFriendsMain(UserInfo);
                friends.Show();
                AddFriendsForm.Add(UserInfo.GetUserName(), friends); 
            }
            else
            {
                AddFriendsForm[UserInfo.GetUserName()].TopMost = true;
                AddFriendsForm[UserInfo.GetUserName()].TopMost = false;
            }
        }
        public static Dictionary<string, Form> FriendApplicationForm = new Dictionary<string, Form>();
        private void FriendApplication_Click(object sender, EventArgs e)
        {
            
            if (!FriendApplicationForm.ContainsKey(UserInfo.GetUserName()))
            {
                FriendsApplication application = new FriendsApplication(UserInfo);
                application.Show();
                FriendApplicationForm.Add(UserInfo.GetUserName(), application);
            }
            else
            {
                FriendApplicationForm[UserInfo.GetUserName()].TopMost = true;
                FriendApplicationForm[UserInfo.GetUserName()].TopMost = false;
            }
        }

        private void ReSetPasswordButton_Click(object sender, EventArgs e)
        {
            UserUpdatePassword updatePassword = new UserUpdatePassword(UserInfo);
            updatePassword.Owner = this;
            updatePassword.ShowDialog(this);
            
        }

        private void DeleteFriendsButton_Click(object sender, EventArgs e)
        {

            if (this.FriendsList.SelectedItem != null)
            {
                if (connect.DeleteFriends(s[this.FriendsList.SelectedIndex], UserInfo.GetUserName()) == 1)
                {
                    if (connect.DeleteFriends(UserInfo.GetUserName(), s[this.FriendsList.SelectedIndex]) == 1)
                { 
                MessageBox.Show("删除成功", "提示");
                ReFreshButton_Click(sender, e);
                }

                }

            }
            else
            {
                MessageBox.Show("请选择要删除的好友", "提示");
            }
        }

        private void UpdateUserInfo_Click(object sender, EventArgs e)
        {
            UpdateUserInfo Info = new UpdateUserInfo(UserInfo);
            Info.ShowDialog(this);
        }
    }
}
