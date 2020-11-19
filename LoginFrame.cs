using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class LoginFrame : Form
    {
        public static string username = "";//暂存用户名，让其他窗体能检测到用户名，减少数据库查询次数
        public static Image Image = global::SqlSeverFrame.Properties.Resources.empty;//设定登录页面的初始用户头像
        public LoginFrame()
        {
            InitializeComponent();
        }
        SQLSeverConnect SQLSeverConnect = new SQLSeverConnect();//新建数据库连接对象
        public void SQLConnectPackage()
        {
            string Account=this.AccountInput.Text;
            string Password = this.PasswordInput.Text;
            DataSet ds = new DataSet();
            int n = SQLSeverConnect.SqlLogin(Account,Password).Fill(ds, "LoginInfo");
            if (this.CodeInput.Text.ToUpper() == CheckNumberText)//判断验证码是否正确，验证码不分大小写，统一转换为大写对比
            {
                if (SQLSeverConnect.SearchIsAlive(username)==0)//判断账号是否登录，为0时代表账号未登录
                {


                    if (n != 0)//n!=0,代表数据库中有该账户，登录成功。转移到主界面
                    {
                        MessageBox.Show("登录成功！", "提示");
                        SQLSeverConnect.UpdateState(username, LoginState.Text);

                        MainFrame mainFrame = new MainFrame();
                        this.Visible = false;
                        mainFrame.ShowDialog(this);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
                        PasswordInput.Text = "";
                        AccountInput.Text = "";
                        AccountInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("账号已登录,请退出其他地点的登录后重新登陆。若其他设备登录，请修改密码后登录", "提示");
                }
            }
            else
            {
                MessageBox.Show("验证码错误", "提示");
                CodeInput.Text = null;
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
            private const double PI2 = 6.283185307179586476925286766559;
            //private readonly int _wordsLen = 4;
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
                        dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
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
            username = this.AccountInput.Text;
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
    }
}
