using System;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class MainFrame : Form
    {
        public UserInfo UserInfo;
        public MainFrame()
        {
            InitializeComponent();
        }
        public MainFrame(UserInfo userInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
        public static string Friends;
        public static string FriendsName;
        static  SQLSeverConnect  connect = new SQLSeverConnect();

        string[] s;
        private void MainFrame_Load(object sender, EventArgs e)
        {
            s = new string[connect.SearchFriends(UserInfo.getUserName()).Length];
            this.UserState.SelectedItem = UserInfo.getUserState();
            this.MainShowHead.Image = LoginFrame.Image;
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

        
        

        private void FriendsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.FriendsList.SelectedItem != null) {
            Friends = this.FriendsList.SelectedItem.ToString();
            FriendsName = s[this.FriendsList.SelectedIndex];
            var frm = new Chatting(UserInfo);
            frm.Show(); 
            }
            
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            s = new string[connect.SearchFriends(UserInfo.getUserName()).Length];
            this.UserState.SelectedItem = UserInfo.getUserState();
            this.MainShowHead.Image = LoginFrame.Image;
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
    }
}
