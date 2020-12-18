
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class Chatting : Form
    {
        UserInfo UserInfo = new UserInfo();
        UserInfo FriendsInfo = new UserInfo();
        public Chatting()
        {
            InitializeComponent();
        }
        public Chatting(UserInfo userInfo, UserInfo FriendsInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
            this.FriendsInfo = FriendsInfo;

        }
        int max;
        SQLSeverConnect connect = new SQLSeverConnect();
        private void ReciveMessage_Tick(object sender, EventArgs e)
        {
            int[] ReceviverNumber = connect.SearchNumbers(FriendsInfo.GetUserName(), UserInfo.GetUserName());
            Array.Sort(ReceviverNumber);
            for (int i = 0; i < ReceviverNumber.Length; i++)
            {
                if (ReceviverNumber[i] > max)
                {
                    ShowMessage.SelectionAlignment = HorizontalAlignment.Left;
                    string s = "";
                    s += connect.SearchNickname(connect.SearchSenDerByNumber(ReceviverNumber[i].ToString())) + "(" + connect.SearchSenDerByNumber(ReceviverNumber[i].ToString()) + ")" + connect.SearchSendTimeByNumber(ReceviverNumber[i].ToString()) + "\r\n";
                    s += connect.SearchMessageByNumber(ReceviverNumber[i].ToString()) + "\r\n";
                    //this.ShowMessage.Text += s;
                    this.ShowMessage.AppendText(s);
                    max = ReceviverNumber[i];
                }
            }
        }
        
        private void Chatting_Load(object sender, EventArgs e)
        {
            this.Text = "正在与" + connect.SearchNickname(FriendsInfo.GetUserName()) + "(" + FriendsInfo.GetUserName() + ")" + "聊天";
            int[] ReceviverNumber = connect.SearchNumbers(FriendsInfo.GetUserName(), UserInfo.GetUserName());
            max = ReceviverNumber.Max();
            int[] SendNumber = connect.SearchNumbers(UserInfo.GetUserName(), FriendsInfo.GetUserName());
            int[] MainNumber = SendNumber.Concat(ReceviverNumber).ToArray();
            Array.Sort(MainNumber);
            for (int i = 0; i < MainNumber.Length; i++)
            {
                if (MainNumber[i] != 0)
                {
                    if (connect.SearchSenDerByNumber(MainNumber[i].ToString()) == UserInfo.GetUserName())
                    {
                        ShowMessage.SelectionAlignment = HorizontalAlignment.Right;
                        string s = "";
                        s += connect.SearchNickname(connect.SearchSenDerByNumber(MainNumber[i].ToString())) + "(" + connect.SearchSenDerByNumber(MainNumber[i].ToString()) + ")" + connect.SearchSendTimeByNumber(MainNumber[i].ToString()) + "\r\n";
                        s += connect.SearchMessageByNumber(MainNumber[i].ToString()) + "\r\n";

                        //this.ShowMessage.Text += s;
                        this.ShowMessage.AppendText(s);
                    }
                    else
                    {
                        ShowMessage.SelectionAlignment = HorizontalAlignment.Left;
                        string s = "";
                        s += connect.SearchNickname(connect.SearchSenDerByNumber(MainNumber[i].ToString())) + "(" + connect.SearchSenDerByNumber(MainNumber[i].ToString()) + ")" + connect.SearchSendTimeByNumber(MainNumber[i].ToString()) + "\r\n";
                        s += connect.SearchMessageByNumber(MainNumber[i].ToString()) + "\r\n";

                        //this.ShowMessage.Text += s;
                        this.ShowMessage.AppendText(s);
                    }

                }
                this.ShowMessage.Refresh();
                ShowMessage.SelectionStart = ShowMessage.TextLength;
                ShowMessage.ScrollToCaret();
            }
        }

        private void SengButton_Click(object sender, EventArgs e)
        {
            if (this.MessageInput.Text == "")
            {
                MessageBox.Show("发送内容不能为空", "提示");
                MessageInput.Focus();

            }
            else
            {
                ShowMessage.SelectionAlignment = HorizontalAlignment.Right;
                //MessageBox.Show(this.MessageInput.Text.Contains("\n").ToString());
                Thread.Sleep(200);
                connect.SendMessage(UserInfo.GetUserName(), this.MessageInput.Text, FriendsInfo.GetUserName());
                string s= connect.SearchNickname(UserInfo.GetUserName()) + "(" + UserInfo.GetUserName() + ")" + DateTime.Now + "\r\n" + this.MessageInput.Text + "\r\n";
                this.ShowMessage.AppendText(s);
                this.MessageInput.Text = "";
                MessageInput.Focus();             
            }

        }
        private void DropButton_Click(object sender, EventArgs e)
        {
            this.MessageInput.Text = "";
            MessageInput.Focus();
        }

        private void Chatting_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFrame.dc.Remove(FriendsInfo.GetUserName());
            
        }

        private void ShowMessage_TextChanged(object sender, EventArgs e)
        {
            ShowMessage.SelectionStart = ShowMessage.TextLength;
            ShowMessage.ScrollToCaret();
        }
    }
}
