using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TTChat
{
    public partial class Register : Form
    {
        public static Image HeadImage = global::TTChat.Properties.Resources.empty;
        public static string HeadName = "emty";
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            NickNameInput.Focus();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将返回主页面", "提示");
            this.Owner.Visible = true;
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SQLSeverConnect connect = new SQLSeverConnect();
            if (this.NickNameInput.Text!="")
            {
                if (this.UserName.Text != "")
                {
                    if (this.Password.Text != "")
                    {
                        if (this.ConfirmPassword.Text != "")
                        {
                            if (this.ConfirmPassword.Text == this.Password.Text)
                            {
                                if (connect.SqlSearch(this.UserName.Text) == 0)
                                {
                                    if (connect.SqlInsert(this.UserName.Text, this.Password.Text, HeadName, this.NickNameInput.Text) != 0)
                                    {
                                        MessageBox.Show("注册成功，即将返回主页面", "提示");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("服务错误，稍后再试", "提示");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("用户名已存在，请重新输入");
                                    this.UserName.Text = "";
                                    this.Password.Text = "";
                                    this.ConfirmPassword.Text = "";
                                    UserName.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("两次输入的密码不一样", "提示");
                                Password.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("确认密码不能为空", "提示");
                            ConfirmPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码不能为空", "提示");
                        Password.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("用户名不能为空", "提示");
                    UserName.Focus();
                } 
            }
            else
            {
                MessageBox.Show("昵称不能为空", "提示");
                this.NickNameInput.Focus();
            }

        }

        private void SelectHead_Click(object sender, EventArgs e)//生成选择头像窗口
        {


            //用lambda表达式实现
            ShowHead showHead = new ShowHead();
            showHead.ChangeText = (str) => HeadName = str;
            showHead.ChangeHead = (imagehead) => HeadImage = imagehead;
            showHead.ShowDialog(this);
            
            this.imagehead.Image = HeadImage;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = UserName.Text.Trim();
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
                UserName.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                UserName.SelectionStart = UserName.Text.Length;
            }
        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserName.ImeMode = ImeMode.Close;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
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

        private void Password_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = Password.Text.Trim();
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
                Password.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                Password.SelectionStart = Password.Text.Length;
            }
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = ConfirmPassword.Text.Trim();
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
                ConfirmPassword.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                ConfirmPassword.SelectionStart = ConfirmPassword.Text.Length;
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Password.ImeMode = ImeMode.Close;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
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

        private void ConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmPassword.ImeMode = ImeMode.Close;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
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

        private void NickNameInput_Enter(object sender, EventArgs e)
        {
            this.NIckNameTips.Visible = true;
        }

        private void NickNameInput_Leave(object sender, EventArgs e)
        {
            this.NIckNameTips.Visible = false;
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            this.UsernameTips.Visible = true;

        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            this.UsernameTips.Visible = false;

        }

        private void Password_Enter(object sender, EventArgs e)
        {
            this.PasswordTips.Visible = true;

        }

        private void Password_Leave(object sender, EventArgs e)
        {
            this.PasswordTips.Visible = false;
        }

        private void ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(this.ConfirmPassword.Text!=this.Password.Text)
            {
this.ConfirmPasswordTips.Visible = true;
            this.PasswordTips.Visible = true;
            }
            else
            {
                this.ConfirmPasswordTips.Visible = true;
                this.ConfirmPasswordTips.Visible = false;
            }
            

        }

        private void ConfirmPassword_Enter(object sender, EventArgs e)
        {
            this.ConfirmPasswordTips.Visible = true;
            this.PasswordTips.Visible = true;
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
