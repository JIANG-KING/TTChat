using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class ReSetPassword : Form
    {
        public ReSetPassword()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
        SQLSeverConnect connect = new SQLSeverConnect();
        public  string GetNumberAlpha(string source)//去除数据库中查询数据中的空格，防止无法匹配头像
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
        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            DataSet ds=new DataSet();
            if (this.UserNameInput.Text == null || this.OldPasswordInput.Text == null || this.NewPasswordInput.Text == null || this.ConfirmPasswordInput.Text == null)
            {
                if(this.UserNameInput.Text == null)
                {
                    MessageBox.Show("用户名不能为空", "提示");
                    UserNameInput.Focus();
                }
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
                if (connect.SqlSearch(this.UserNameInput.Text) == 1)
                {
                    if(connect.SqlLogin(this.UserNameInput.Text,this.OldPasswordInput.Text).Fill(ds, "LoginInfo") != 0)
                    {
                        DataTable tbl = ds.Tables[0];
                        DataRow row = tbl.Rows[0];
                        if (GetNumberAlpha(row["Account"].ToString()) == this.UserNameInput.Text && GetNumberAlpha(row["Password"].ToString()) == this.OldPasswordInput.Text)
                        {
                            if (this.OldPasswordInput.Text != this.NewPasswordInput.Text)
                            {
                                if (this.NewPasswordInput.Text == this.ConfirmPasswordInput.Text)
                                {
                                    connect.UpdatePassword(this.UserNameInput.Text, this.ConfirmPasswordInput.Text);
                                    connect.UpdateIsAlive(this.UserNameInput.Text, "0");
                                    connect.UpdateState(this.UserNameInput.Text, "离线");
                                    MessageBox.Show("修改成功", "提示");
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
                    }
                    else
                    {
                        MessageBox.Show("旧密码错误", "提示");
                        OldPasswordInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("输入的账号不存在", "提示");
                    UserNameInput.Focus();
                }
            }
        }

        private void UserNameInput_TextChanged(object sender, System.EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = UserNameInput.Text.Trim();
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
                UserNameInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                UserNameInput.SelectionStart = UserNameInput.Text.Length;
            }
        }

        private void UserNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserNameInput.ImeMode = ImeMode.Close;
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
    }
}
