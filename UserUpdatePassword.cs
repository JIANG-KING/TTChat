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
    public partial class UserUpdatePassword : Form
    {
        UserInfo UserInfo;
        public UserUpdatePassword()
        {
            InitializeComponent();
        }
        public UserUpdatePassword(UserInfo UserInfo)
        {
            InitializeComponent();
            this.UserInfo = UserInfo;
        }
        SQLSeverConnect connect = new SQLSeverConnect();
        public string GetNumberAlpha(string source)//确保字符串中不含非法字符
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
        private void OldPasswordInput_TextChanged(object sender, System.EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = OldPasswordInput.Text.Trim();
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
                OldPasswordInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                OldPasswordInput.SelectionStart = OldPasswordInput.Text.Length;
            }
        }

        private void OldPasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            OldPasswordInput.ImeMode = ImeMode.Close;
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

        private void NewPasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NewPasswordInput.ImeMode = ImeMode.Close;
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

        private void NewPasswordInput_TextChanged(object sender, System.EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = NewPasswordInput.Text.Trim();
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
                NewPasswordInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                NewPasswordInput.SelectionStart = NewPasswordInput.Text.Length;
            }
        }

        private void ConfirmPasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmPasswordInput.ImeMode = ImeMode.Close;
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

        private void ConfirmPasswordInput_TextChanged(object sender, System.EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = ConfirmPasswordInput.Text.Trim();
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
                ConfirmPasswordInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                ConfirmPasswordInput.SelectionStart = ConfirmPasswordInput.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            if (this.OldPasswordInput.Text == null || this.NewPasswordInput.Text == null || this.ConfirmPasswordInput.Text == null)
            {
                if (this.OldPasswordInput.Text == null)
                {
                    MessageBox.Show("旧密码不能为空", "提示");
                    OldPasswordInput.Focus();
                }
                if (this.NewPasswordInput.Text == null)
                {
                    MessageBox.Show("新密码不能为空", "提示");
                    NewPasswordInput.Focus();
                }
                if (this.ConfirmPasswordInput.Text == null)
                {
                    MessageBox.Show("确认密码不能为空", "提示");
                    ConfirmPasswordInput.Focus();
                }
            }
            else
            {
                if (UserInfo.GetPassword() == this.OldPasswordInput.Text)

                {
                    if (this.OldPasswordInput.Text != this.NewPasswordInput.Text)
                    {
                        if (this.NewPasswordInput.Text == this.ConfirmPasswordInput.Text)
                        {
                            if(connect.UpdatePassword(this.UserInfo.GetUserName(), this.ConfirmPasswordInput.Text) == 1)
                            {
                            MessageBox.Show("修改成功", "提示");
                            this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("两次输入的密码不一样", "提示");
                            ConfirmPasswordInput.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("新密码不能与旧密码相同", "提示");
                        NewPasswordInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误", "提示");
                    OldPasswordInput.Focus();
                }
            }
        }
    }
}
