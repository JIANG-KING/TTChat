using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTChat
{
    public partial class ShowHead : Form
    {
        public ShowHead()
        {
            InitializeComponent();
        }
        public Action<Image> ChangeHead;
        public Action<string> ChangeText;
        public Image Image;
        public string HeadName;
        private void Head1_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._1;
            HeadName = "head1";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }

        }

        private void Head2_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._2;
            HeadName = "head2";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }

        private void Head3_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._3;
            HeadName = "head3";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }

        private void Head4_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._4;
            HeadName = "head4";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }

        private void Head5_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._5;
            HeadName = "head5";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }

        private void Head6_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._6;
            HeadName = "head6";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }

        private void Head7_Click(object sender, EventArgs e)
        {
            Image = global::TTChat.Properties.Resources._7;
            HeadName = "head7";
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeHead(Image);
                ChangeText(HeadName);//执行委托实例
                this.Close();
            }
        }



    }
}
