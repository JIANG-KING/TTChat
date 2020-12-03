using Microsoft.VisualBasic;
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
    public partial class FriendsMain : Form
    {
        public UserInfo UserInfo;
        public FriendsMain()
        {
            InitializeComponent();
        }
        public FriendsMain(UserInfo userInfo )
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
        SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();
        private void Search_Click(object sender, EventArgs e)
        {
            if (SQLSeverConnect.SqlSearch(this.FriendsAccountInput.Text) == 1)
            {
                Image Image;
                this.FriendsNickName.BorderStyle = (BorderStyle)2;
                this.FriendsNickName.Text = SQLSeverConnect.SearchNickname(this.FriendsAccountInput.Text);
                this.UserState.BorderStyle = (BorderStyle)2;
                this.UserState.Text = SQLSeverConnect.SearchUserState(this.FriendsAccountInput.Text);
                string s = LoginFrame.GetNumberAlpha(SQLSeverConnect.SearchImage(this.FriendsAccountInput.Text));
                if (s != "")
                {

                    switch (s)
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
                this.FriendsHead.BorderStyle = (BorderStyle)2;
                this.FriendsHead.Image = Image;
            }
            else
            {
                MessageBox.Show("查找失败，用户不存在", "提示");
            }
        }

        private void FriendsMain_Load(object sender, EventArgs e)
        {
            this.FriendsNickName.Text = "";
            this.UserState.Text = "";
        }



        private void SendFriendsApplication_Click(object sender, EventArgs e)
        {
            if (SQLSeverConnect.IsFriends(UserInfo.getUserName(), this.FriendsAccountInput.Text) != 1)
            {

                if (SQLSeverConnect.IsSendApplication(UserInfo.getUserName(), this.FriendsAccountInput.Text) == 0)
                { 
                    if (this.FriendsAccountInput.Text != UserInfo.getUserName()) 
                    {                
                string Message = Interaction.InputBox("请输入验证消息", "提示", "", 100, 100);
                SQLSeverConnect.SendFriendApplication(UserInfo.getUserName(), Message, this.FriendsAccountInput.Text);
                MessageBox.Show("发送成功", "提示");
            }
            else
            {
                MessageBox.Show("你不能添加自己为好友", "提示");
            }
                }
                else
                {
                    DialogResult r1=MessageBox.Show(" 已经发送过好友申请了，继续发送将覆盖好友申请 "," 提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (r1.ToString() == "yes")
                    {
                        SQLSeverConnect.DeleteApplication(UserInfo.getUserName());
                        string Message = Interaction.InputBox("请输入验证消息", "提示", "", 100, 100);
                        SQLSeverConnect.SendFriendApplication(UserInfo.getUserName(), Message, this.FriendsAccountInput.Text);
                        MessageBox.Show("发送成功", "提示");
                    }
                }
                

            }
            else
            {
                MessageBox.Show("你们已经是好友了", "提示");
            }
            
            
        }
    }
}
