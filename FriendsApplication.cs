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
             
            int[] count = new int[SQLSeverConnect.SearchFriendsApplication(UserInfo.getUserName()).Length];
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
    }
}
