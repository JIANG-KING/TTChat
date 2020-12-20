using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TTChat
{
    public partial class LoginFrame : Form
    {
        public UserInfo UserInfo = new UserInfo();
        public static Image Image = global::TTChat.Properties.Resources.empty;//设定登录页面的初始用户头像
        public LoginFrame()
        {
            InitializeComponent();
        }
        SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();//新建数据库连接对象            
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Account = this.AccountInput.Text;
            string Password = this.PasswordInput.Text;
            DataSet ds = new DataSet();
            if (Account != "" || Password != "" || this.CodeInput.Text != "")
            {
                if (this.CodeInput.Text.ToUpper() == CheckNumberText)//判断验证码是否正确，验证码不分大小写，统一转换为大写对比
                {
                    if (SQLSeverConnect.SqlSearch(this.AccountInput.Text) != 0)
                    {
                        if (SQLSeverConnect.SearchIsAlive(this.AccountInput.Text) != 1)
                        {
                            if (SQLSeverConnect.SqlLogin(Account, Password).Fill(ds, "LoginInfo") != 0)
                            {
                                DataTable tbl = ds.Tables[0];
                                DataRow row = tbl.Rows[0];
                                if (GetNumberAlpha(row["Account"].ToString()) == this.AccountInput.Text && GetNumberAlpha(row["Password"].ToString()) == this.PasswordInput.Text)//判断查询的数据是否和输入的一致，防止sql注入
                                {
                                    MessageBox.Show("登录成功！", "提示");
                                    SQLSeverConnect.UpdateState(this.AccountInput.Text, LoginState.Text);
                                    UserInfo.SetPassword(Password);
                                    UserInfo.SetUserName(Account);
                                    UserInfo.SetUserState(LoginState.Text);
                                    MainFrame mainFrame = new MainFrame(UserInfo);
                                    this.Visible = false;
                                    mainFrame.ShowDialog(this);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("服务异常，请重试！", "提示");
                                }
                            }
                            else
                            {

                                MessageBox.Show("账号或者密码错误", "提示");
                                AccountInput.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("账号已登录，请重置密码或者寻求管理员帮助", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("账号不存在", "提示");
                        this.AccountInput.Text = "";
                        this.PasswordInput.Text = "";
                        this.CodeInput.Text = "";
                        AccountInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("验证码错误！", "提示");
                    this.CodeInput.Text = "";
                    CodeInput.Focus();
                }
            }
            else
            {
                if (this.AccountInput.Text == "")
                {
                    this.AccountInput.Focus();
                    MessageBox.Show("用户名不能为空", "提示");
                }
                if (this.PasswordInput.Text == "")
                {
                    this.PasswordInput.Focus();
                    MessageBox.Show("密码不能为空", "提示");
                }
                if (this.CodeInput.Text == "")
                {
                    this.CodeInput.Focus();
                    MessageBox.Show("验证码不能为空", "提示");
                }
            }

        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register Reg = new Register();
            Reg.Owner = this;
            this.Visible = false;
            Reg.ShowDialog(this);
        }
        string CheckNumberText;
        public void CreatCode()//将验证码加载进验证码窗体中，并且实现每次都能生成不一样的验证码
        {
            ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Alphas);
            this.CheckNumber.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            CheckNumberText = validCode.CheckCode;
        }
        private void LoginFrame_Load(object sender, EventArgs e)//加载验证码，设置默认在线状态
        {
            LoginState.SelectedItem = "在线";
            CreatCode();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ReSetPassword reSetPassword = new ReSetPassword();
            this.Visible = false;
            reSetPassword.Owner = this;
            reSetPassword.Show(this);
        }

        private void RefreshButton_Click(object sender, EventArgs e)//刷新验证码
        {
            CreatCode();
        }
        /// <summary>
        /// 去除字符串中的空格
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string GetNumberAlpha(string source)
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
        /// <summary>
        /// 用户输入框的值改变时自动匹配用户头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountInput_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = AccountInput.Text.Trim();
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
                AccountInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                AccountInput.SelectionStart = AccountInput.Text.Length;
            }
            if (this.AccountInput.Text != "")
            {
                string s = SQLSeverConnect.SearchImage(this.AccountInput.Text);
                if (s != "")
                {

                    switch (s)
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
            }
            this.ShowHead.Image = Image;
        }
        /// <summary>
        /// 阻止用户输入除了字母数字以外的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            AccountInput.ImeMode = ImeMode.Close;
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

        private void CheckNumber_Click(object sender, EventArgs e)
        {
            CreatCode();
        }
        /// <summary>
        /// 阻止用户输入除了字母数字以外的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            PasswordInput.ImeMode = ImeMode.Close;
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
        /// <summary>
        /// 阻止用户输入除了字母数字以外的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            var reg = new Regex("^^[A-Za-z0-9]*$");
            var str = PasswordInput.Text.Trim();
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
                PasswordInput.Text = sb.ToString();
                //定义输入焦点在最后一个字符
                PasswordInput.SelectionStart = PasswordInput.Text.Length;
            }
        }

        private void ContactUsMenu_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }
    }
}
