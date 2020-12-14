using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class LoginFrame : Form
    {
        public UserInfo UserInfo = new UserInfo();
        public static Image Image = global::SqlSeverFrame.Properties.Resources.empty;//设定登录页面的初始用户头像
        public LoginFrame()
        {
            InitializeComponent();
        }
        SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();//新建数据库连接对象
        public void SQLConnectPackage()
        {
            string Account = this.AccountInput.Text;
            string Password = this.PasswordInput.Text;
            DataSet ds = new DataSet();
            int n = SQLSeverConnect.SqlLogin(Account, Password).Fill(ds, "LoginInfo");

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
                                UserInfo.setPassword(Account);
                                UserInfo.setUserName(Password);
                                UserInfo.setUserState(LoginState.Text);
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
                MessageBox.Show("服务异常，请重试！", "提示");
                this.CodeInput.Text = "";
                CodeInput.Focus();
            }

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SQLConnectPackage();

        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register Reg = new Register();
            Reg.ShowDialog(this);
        }
        public class ValidCode//验证码生成类
        {
            #region Private Fields
            private const double PI = 3.1415926535897932384626433832795;
            private int _len;
            private CodeType _codetype;
            private readonly Single _jianju = (float)18.0;
            private readonly Single _height = (float)24.0;
            private string _checkCode;
            #endregion
            #region Public Property
            public string CheckCode
            {
                get
                {
                    return _checkCode;
                }
            }
            #endregion
            #region Constructors
            /// <summary>
            /// public constructors
            /// </summary>
            /// <param name="len"> 验证码长度 </param>
            /// <param name="ctype"> 验证码类型：字母、数字、字母+ 数字 </param>
            public ValidCode(int len, CodeType ctype)
            {
                this._len = len;
                this._codetype = ctype;
            }
            #endregion
            #region Public Field
            public enum CodeType { Words, Numbers, Characters, Alphas }
            #endregion
            #region Private Methods
            private string GenerateNumbers()
            {
                string strOut = "";
                System.Random random = new Random();
                for (int i = 0; i < _len; i++)
                {
                    string num = Convert.ToString(random.Next(10000) % 10);
                    strOut += num;
                }
                return strOut.Trim();
            }
            private string GenerateCharacters()
            {
                string strOut = "";
                System.Random random = new Random();
                for (int i = 0; i < _len; i++)
                {
                    string num = Convert.ToString((char)(65 + random.Next(10000) % 26));
                    strOut += num;
                }
                return strOut.Trim();
            }
            //
            private string GenerateAlphas()
            {
                string strOut = "";
                string num = "";
                System.Random random = new Random();
                for (int i = 0; i < _len; i++)
                {
                    if (random.Next(500) % 2 == 0)
                    {
                        num = Convert.ToString(random.Next(10000) % 10);
                    }
                    else
                    {
                        num = Convert.ToString((char)(65 + random.Next(10000) % 26));
                    }
                    strOut += num;
                }
                return strOut.Trim();
            }
            private System.Drawing.Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)
            {
                System.Drawing.Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);
                // 将位图背景填充为白色
                System.Drawing.Graphics graph = System.Drawing.Graphics.FromImage(destBmp);
                graph.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, destBmp.Width, destBmp.Height);
                graph.Dispose();
                double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;
                for (int i = 0; i < destBmp.Width; i++)
                {
                    for (int j = 0; j < destBmp.Height; j++)
                    {
                        double dx = 0;
                        dx = bXDir ? (PI * (double)j) / dBaseAxisLen : (PI * (double)i) / dBaseAxisLen;
                        dx += dPhase;
                        double dy = Math.Sin(dx);
                        // 取得当前点的颜色
                        int nOldX = 0, nOldY = 0;
                        nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                        nOldY = bXDir ? j : j + (int)(dy * dMultValue);
                        System.Drawing.Color color = srcBmp.GetPixel(i, j);
                        if (nOldX >= 0 && nOldX < destBmp.Width
                         && nOldY >= 0 && nOldY < destBmp.Height)
                        {
                            destBmp.SetPixel(nOldX, nOldY, color);
                        }
                    }
                }
                return destBmp;
            }
            #endregion
            #region Public Methods
            public Stream CreateCheckCodeImage()
            {
                string checkCode;
                switch (_codetype)
                {
                    case CodeType.Alphas:
                        checkCode = GenerateAlphas();
                        break;
                    case CodeType.Numbers:
                        checkCode = GenerateNumbers();
                        break;
                    case CodeType.Characters:
                        checkCode = GenerateCharacters();
                        break;
                    default:
                        checkCode = GenerateAlphas();
                        break;
                }
                this._checkCode = checkCode;
                MemoryStream ms = null;
                //
                if (checkCode == null || checkCode.Trim() == String.Empty)
                    return null;
                Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * _jianju)), (int)_height);
                Graphics g = Graphics.FromImage(image);
                try
                {
                    Random random = new Random();
                    g.Clear(Color.White);
                    // 画图片的背景噪音线
                    for (int i = 0; i < 18; i++)
                    {
                        int x1 = random.Next(image.Width);
                        int x2 = random.Next(image.Width);
                        int y1 = random.Next(image.Height);
                        int y2 = random.Next(image.Height);
                        g.DrawLine(new Pen(Color.FromArgb(random.Next()), 1), x1, y1, x2, y2);
                    }
                    Font font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold);
                    LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
                    if (_codetype != CodeType.Words)
                    {
                        for (int i = 0; i < checkCode.Length; i++)
                        {
                            g.DrawString(checkCode.Substring(i, 1), font, brush, 2 + i * _jianju, 1);
                        }
                    }
                    else
                    {
                        g.DrawString(checkCode, font, brush, 2, 2);
                    }
                    // 画图片的前景噪音点
                    for (int i = 0; i < 150; i++)
                    {
                        int x = random.Next(image.Width);
                        int y = random.Next(image.Height);
                        image.SetPixel(x, y, Color.FromArgb(random.Next()));
                    }
                    // 画图片的波形滤镜效果
                    if (_codetype != CodeType.Words)
                    {
                        image = TwistImage(image, true, 3, 1);
                    }
                    // 画图片的边框线
                    g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                    ms = new System.IO.MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                }
                finally
                {
                    g.Dispose();
                    image.Dispose();
                }
                return ms;
            }
            #endregion
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
            LoginState.SelectedItem="在线";
            CreatCode();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            PictureBoxTest pictureBoxTest = new PictureBoxTest();
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog(this);
        }

        private void RefreshButton_Click(object sender, EventArgs e)//刷新验证码
        {
            CreatCode();
        }
        public static string GetNumberAlpha(string source)//去除数据库中查询数据中的空格，防止无法匹配头像
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
        private void AccountInput_TextChanged(object sender, EventArgs e)//用户输入框的值改变时自动匹配用户头像
        {

            if (this.AccountInput.Text != "") { 
            string s = GetNumberAlpha(SQLSeverConnect.SearchImage(this.AccountInput.Text));
                if (s != "")
                {

                    switch (s)
                    {
                        case "head1": Image = global::SqlSeverFrame.Properties.Resources._1; break;
                        case "head2": Image = global::SqlSeverFrame.Properties.Resources._2; break;
                        case "head3": Image = global::SqlSeverFrame.Properties.Resources._3; break;
                        case "head4": Image = global::SqlSeverFrame.Properties.Resources._4; break;
                        case "head5": Image = global::SqlSeverFrame.Properties.Resources._5; break;
                        case "head6": Image = global::SqlSeverFrame.Properties.Resources._6; break;
                        case "head7": Image = global::SqlSeverFrame.Properties.Resources._7; break;
                        default: Image = global::SqlSeverFrame.Properties.Resources.empty; break;
                    }
                }
                else{
                    Image = global::SqlSeverFrame.Properties.Resources.empty;
                }
            }
            this.ShowHead.Image = Image;
        }

        private void AccountInput_KeyPress(object sender, KeyPressEventArgs e)//处理用户输入，防止SQL注入
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }
    }
}
