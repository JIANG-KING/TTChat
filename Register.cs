using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SqlSeverFrame
{
    public partial class Register : Form
    {
        public static Image HeadImage=global::SqlSeverFrame.Properties.Resources.empty;
        public static string HeadName="emty";
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("即将返回主页面", "提示");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SQLSeverConnect connect = new SQLSeverConnect();
            if (this.UserName.Text != "")
            {
                if (this.Password.Text != "")
                {
                    if (this.ConfirmPassword.Text != "")
                    {
                        if (this.ConfirmPassword.Text == this.Password.Text)
                        {
                            if (connect.sqlSearch(this.UserName.Text) == 0)
                            {
                                if (connect.sqlInsert(this.UserName.Text, this.Password.Text, HeadName,this.NickNameInput.Text) != 0)
                                {
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

        private void SelectHead_Click(object sender, EventArgs e)//生成选择头像窗口
        {
            ShowHead showHead = new ShowHead();
            showHead.ShowDialog(this);
            this.imagehead.Image = HeadImage;
        }
    }
}
