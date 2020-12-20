using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTChat
{
    public partial class AddFriendsMain : Form
    {
        public UserInfo UserInfo;
        public AddFriendsMain()
        {
            InitializeComponent();
        }
        public AddFriendsMain(UserInfo userInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
        SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();
        public string GetNumberAlpha(string source)//去除数据库中查询数据中的空格，防止无法匹配头像
        {
            string pattern = "[A-Za-z0-9]";
            string strRet = "";
            MatchCollection results = Regex.Matches(source, pattern);
            foreach (var v in results)
            {
                strRet += v.ToString();
            }
            return strRet;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (SQLSeverConnect.SqlSearch(this.FriendsAccountInput.Text) == 1)
            {
                Image Image;
                this.FriendsNickName.Text = "昵称：" + SQLSeverConnect.SearchNickname(this.FriendsAccountInput.Text);
                this.AccountLabel.Text = "账号：" + this.FriendsAccountInput.Text;
                this.UserState.Text = "在线状态：" + SQLSeverConnect.SearchUserState(this.FriendsAccountInput.Text);
                string s = GetNumberAlpha(SQLSeverConnect.SearchImage(this.FriendsAccountInput.Text));
                if (s != "")
                {

                    switch (s)
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
            this.AccountLabel.Text = "";
        }



        private void SendFriendsApplication_Click(object sender, EventArgs e)
        {

            if (SQLSeverConnect.SqlSearch(this.FriendsAccountInput.Text) == 1)
            {
                if (SQLSeverConnect.IsFriends(UserInfo.GetUserName(), this.FriendsAccountInput.Text) != 1)
                {
                    if (this.FriendsAccountInput.Text != UserInfo.GetUserName())
                    {
                        if (SQLSeverConnect.IsSendApplication(UserInfo.GetUserName(), this.FriendsAccountInput.Text) == 0)
                        {
                            string Message = Interaction.InputBox("请输入验证消息", "提示", "", 100, 100);
                            SQLSeverConnect.SendFriendApplication(UserInfo.GetUserName(), Message, this.FriendsAccountInput.Text);
                            MessageBox.Show("发送成功", "提示");
                        }
                        else
                        {
                            DialogResult r1 = MessageBox.Show(" 已经发送过好友申请了，继续发送将覆盖好友申请 ", " 提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (r1.ToString() == "OK")
                            {
                                SQLSeverConnect.DeleteApplication(UserInfo.GetUserName(), this.FriendsAccountInput.Text);
                                string Message = Interaction.InputBox("请输入验证消息", "提示", "", 100, 100);
                                SQLSeverConnect.SendFriendApplication(UserInfo.GetUserName(), Message, this.FriendsAccountInput.Text);
                                MessageBox.Show("发送成功", "提示");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("你不能添加自己为好友", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("你们已经是好友了", "提示");
                }


            }
            else
            {
                MessageBox.Show("用户不存在", "提示");
            }
        }

        private void FriendsAccountInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FriendsAccountInput_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = FriendsAccountInput.Text.Trim();
            var sb = new StringBuilder();
            if (!reg.IsMatch(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (reg.IsMatch(str[i].ToString()))
                    {
                        sb.Append(str[i].ToString());
                    }
                }
                FriendsAccountInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                FriendsAccountInput.SelectionStart = FriendsAccountInput.Text.Length;
            }
        }

        private void AddFriendsMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFrame.AddFriendsForm.Remove(UserInfo.GetUserName());
        }
    }
}
