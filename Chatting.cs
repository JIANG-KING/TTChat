using java.lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class Chatting : Form
    {
        public Chatting()
        {
            InitializeComponent();
        }
        int max;
        SQLSeverConnect connect = new SQLSeverConnect();
        private void ReciveMessage_Tick(object sender, EventArgs e)
        {
            int[] ReceviverNumber = connect.SearchNumbers(MainFrame.FriendsName, LoginFrame.username);
            Array.Sort(ReceviverNumber);
            for(int i = 0; i <ReceviverNumber.Length; i++)
            {
                if (ReceviverNumber[i] > max)
                {
                    string s = "";
                    s += connect.SearchNickname(connect.SearchSenDerByNumber(ReceviverNumber[i].ToString())) + "(" + connect.SearchSenDerByNumber(ReceviverNumber[i].ToString()) + ")" + DateTime.Now + "\r\n";
                    s += connect.SearchMessageByNumber(ReceviverNumber[i].ToString()) + "\r\n";
                    this.ShowMessage.Text += s;
                    max = ReceviverNumber[i];
                }
            }



        }

        private void Chatting_Load(object sender, EventArgs e)
        {
            this.Text = "正在与" + MainFrame.Friends+"聊天";
            string[] ReceiverMessage = connect.SearchMessage(MainFrame.FriendsName,LoginFrame.username);
            int[] ReceviverNumber = connect.SearchNumbers(MainFrame.FriendsName, LoginFrame.username);
            max = ReceviverNumber.Max();
            string[] SendMessage = connect.SearchMessage(LoginFrame.username, MainFrame.FriendsName);
            int[] SendNumber = connect.SearchNumbers(LoginFrame.username, MainFrame.FriendsName);
            int[] MainNumber = SendNumber.Concat(ReceviverNumber).ToArray();
            Array.Sort(MainNumber);
            for (int i = 0; i<MainNumber.Length; i++)
            {
                if (MainNumber[i] != 0)
                {
                    string s="";
                    s += connect.SearchNickname(connect.SearchSenDerByNumber(MainNumber[i].ToString()))+"("+ connect.SearchSenDerByNumber(MainNumber[i].ToString()) + ")"+ DateTime.Now + "\r\n";
                    s += connect.SearchMessageByNumber(MainNumber[i].ToString())+  "\r\n";

                    this.ShowMessage.Text += s;
                }
                ShowMessage.SelectionStart = ShowMessage.TextLength;
                ShowMessage.ScrollToCaret();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowMessage.SelectionStart = ShowMessage.TextLength;
            ShowMessage.ScrollToCaret();
        }

        private void SengButton_Click(object sender, EventArgs e)
        {

            Thread.sleep(500);
            connect.SendMessage(LoginFrame.username,  this.MessageInput.Text,MainFrame.FriendsName);
            this.ShowMessage.Text += connect.SearchNickname(LoginFrame.username) +"(" +LoginFrame.username +")"+ DateTime.Now + "\r\n" + this.MessageInput.Text+ "\r\n";
            this.MessageInput.Text = " ";
        }
    }
}
