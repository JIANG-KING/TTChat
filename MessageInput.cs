using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTChat
{
    public partial class MessageInput : Form
    {
        public MessageInput()
        {
            InitializeComponent();
        }
        public Action<string> ChangeText;
        public Action<string> ChangeApplicationText;
        public string ApplicationMessage;
        string text="Close";
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ChangeApplicationText != null)//判断事件是否为空
            {
                ApplicationMessage = this.ApplicationInput.Text;
                ChangeApplicationText(ApplicationMessage);//执行委托实例
                text = "Open";
                ChangeText(text);
                this.Close();
            }
        }

        private void CancelApplicationButton_Click(object sender, EventArgs e)
        {
            if (ChangeText != null)//判断事件是否为空
            {
                text = "Close";
                ChangeText(text);//执行委托实例
                this.Close();
            }
        }
    }
}
