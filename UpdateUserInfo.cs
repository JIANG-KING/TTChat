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
    public partial class UpdateUserInfo : Form
    {
        UserInfo UserInfo;
        public UpdateUserInfo()
        {
            InitializeComponent();
        }
        public UpdateUserInfo(UserInfo userInfo)
        {
            InitializeComponent();
            this.UserInfo = userInfo;
        }
        Image Image;
        string head;
        SQLSeverConnect Connect = new SQLSeverConnect();
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Connect.UpdateUserInfo(UserInfo.GetUserName(), head, this.NickNameInput.Text, this.SignatureInput.Text) == 1)
            {
                MessageBox.Show("修改成功", "提示");
            }
        }
        private void UpdateUserInfo_Load(object sender, EventArgs e)
        {
            this.NickNameInput.Text = Connect.SearchNickname(UserInfo.GetUserName()).Trim();
            this.SignatureInput.Text = Connect.Signature(UserInfo.GetUserName());
            head = Connect.SearchImage(UserInfo.GetUserName()).Trim();
            if (head != "")
            {
                switch (head)
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
            this.HeadPictureBox.Image = Image;
        }

        private void SelectHeadButton_Click(object sender, EventArgs e)
        {
            ShowHead showHead = new ShowHead();
            showHead.ChangeText = (str) => head = str;
            showHead.ChangeHead = (imagehead) => Image = imagehead;

            showHead.ShowDialog(this);
            this.HeadPictureBox.Image = Image;
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignatureInput_TextChanged(object sender, EventArgs e)
        {
            this.TextLabel.Text = this.SignatureInput.TextLength.ToString() + "/20";
            if (this.SignatureInput.TextLength >= 20)
            {
                
                MessageBox.Show("个性签名不能大于20个字符", "提示");
                this.SignatureInput.Text = this.SignatureInput.Text.Substring(0, 20);
            }
        }
    }
}
