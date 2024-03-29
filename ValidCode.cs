﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTChat
{
    public class ValidCode//验证码生成类
    {
        #region Private Fields
        private const double PI = 3.1415926535897932384626433832795;
        private int length;
        private CodeType codetype;
        private readonly Single width = (float)18.0;
        private readonly Single height = (float)24.0;
        private string CheckCodes;
        #endregion
        #region Public Property
        public string CheckCode
        {
            get
            {
                return CheckCodes;
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
            this.length = len;
            this.codetype = ctype;
        }
        #endregion
        #region Public Field
        public enum CodeType { Words, Numbers, Characters, Alphas }//枚举存储验证码的类型
        #endregion
        #region Private Methods
        private string GenerateNumbers()//随机数生成
        {
            string strOut = "";
            System.Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                string num = Convert.ToString(random.Next(10000) % 10);
                strOut += num;
            }
            return strOut.Trim();
        }
        private string GenerateCharacters()//随机字母生成
        {
            string strOut = "";
            System.Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                string num = Convert.ToString((char)(65 + random.Next(10000) % 26));
                strOut += num;
            }
            return strOut.Trim();
        }
        //
        private string GenerateAlphas()//随机生成数字加字母
        {
            string strOut = "";
            string num = "";
            System.Random random = new Random();
            for (int i = 0; i < length; i++)
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
        private System.Drawing.Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)//扭曲图片，增加验证码识别难度
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
            switch (codetype)
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
            this.CheckCodes = checkCode;
            MemoryStream ms = null;
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return null;
            Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * width)), (int)height);
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
                if (codetype != CodeType.Words)
                {
                    for (int i = 0; i < checkCode.Length; i++)//将验证码绘入图片
                    {
                        g.DrawString(checkCode.Substring(i, 1), font, brush, 2 + i * width, 1);
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
                if (codetype != CodeType.Words)
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
}
