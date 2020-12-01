using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class PictureBoxTest : Form
    {
        public PictureBoxTest()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 执行下载并保存到本地
        /// </summary>
        /// <param name="url">图片地址</param>
        /// <param name="dtnow">保存的文件名</param>

        private void PictureBoxTest_Load(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync("https://imgchr.com/i/DNdc40");
        }


        private void button1_Click(object sender, EventArgs e)

        {

        }


        //给PictureBox加上LoadProgressChanged事件，LoadAsync方法将会触发此事件，当前的进度可以从e.ProgressPercentage中取得


         private void pictureBox1_LoadProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                pictureBox1.WaitOnLoad = false;
                pictureBox1.LoadAsync("https://s3.ax1x.com/2020/11/24/DNdc40.jpg");

            }
            catch
            {

                MessageBox.Show("网络连接失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.WaitOnLoad = false;
                pictureBox1.LoadAsync("https://s3.ax1x.com/2020/11/24/DNDRo9.jpg");

            }
            catch
            {

                MessageBox.Show("网络连接失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                pictureBox1.WaitOnLoad = false;
                pictureBox1.LoadAsync(this.textBox1.Text);


            }
            catch
            {

                MessageBox.Show("网络连接失败");
            }
        }
    }
}
