using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SqlSeverFrame.LoginFrame;

namespace SqlSeverFrame
{
    public partial class CheckNumber : Form
    {
        public CheckNumber()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckNumber_Enter(object sender, EventArgs e)
        {

        }
        private string Notes = "看不请？点击图片更换！";
        private void TextInput_Enter(object sender, EventArgs e)
        {
            if (this.TextInput.Text == Notes)
            {
                TextInput.ForeColor = Color.Black;
                this.TextInput = null;
            }
        }

        private void TextInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextInput.Text))
            {
                TextInput.ForeColor = Color.DarkGray;
                this.TextInput.Text = Notes;
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }
        string CheckNumberText;
        public void CreatCode() {
            ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Alphas); 
            this.TextBoxCheck.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            this.CheckNumberShow.Text = validCode.CheckCode;
            CheckNumberText =validCode.CheckCode;
        }
        public void CheckNumber_Load(object sender, EventArgs e)
        {
            CreatCode();
        }

        private void TextInput_TextChanged_1(object sender, EventArgs e)
        {
            if (this.TextInput.Text == CheckNumberText)
            {
                this.CheckInformation.Text = "√";
            }
            else
            {
                this.CheckInformation.Text = "×";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.TextInput.Text == CheckNumberText)
            {
                MessageBox.Show("验证码正确！", "提示");
                CreatCode();
                this.TextInput.Text = null;
            }
            else
            {
                MessageBox.Show("验证码错误！", "提示");
                this.TextInput.Text = null;
            }
        }
    }
}
