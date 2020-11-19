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
    public partial class Chatting : Form
    {
        public Chatting()
        {
            InitializeComponent();
        }

        SQLSeverConnect connect = new SQLSeverConnect();
        private void ReciveMessage_Tick(object sender, EventArgs e)
        {
            
            

        }

        private void Chatting_Load(object sender, EventArgs e)
        {
            MessageBox.Show(connect.SearchNUmbers(LoginFrame.username,MainFrame.FriendsName)[1].ToString(),"提示");
            this.Text = "正在与" + MainFrame.Friends+"聊天";
            string[] ReceiverMessage = connect.SearchMessage(MainFrame.FriendsName,LoginFrame.username);
            string[] SendMessage = connect.SearchMessage(LoginFrame.username, MainFrame.FriendsName); 
            for (int i = 0; i < SendMessage.Length; i++)
            {
                this.textBox1.Text += MainFrame.Friends + DateTime.Now + "\r\n" + "\r\n" + ReceiverMessage[i] + "\r\n";
                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.ScrollToCaret();
            }
        }
    }
}
