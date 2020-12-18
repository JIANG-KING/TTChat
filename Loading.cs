using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class Loading : Form
    {
        public UserInfo UserInfo;
        public UserInfo FriendsInfo;
        public Loading()
        {
            InitializeComponent();
        }
        public Loading(UserInfo userInfo,UserInfo FriendsInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
            this.FriendsInfo = FriendsInfo;

        }
        Chatting chat;
        private void Loading_Load(object sender, EventArgs e)
        {
             chat= new Chatting(UserInfo, FriendsInfo);
        
            loadThread = new Thread(new ThreadStart(LoadDataFunc));
            loadThread.IsBackground = true;
            loadThread.Start();
        }
        private Thread loadThread; //加载线程
        

        void LoadDataFunc()
        {
            //初始化完成后

            //使用委托
            this.Invoke(new Action(() => {
                chat = new Chatting(UserInfo, FriendsInfo);
                chat.Show();
                this.Visible = false;
            }));
        }
    }
}
