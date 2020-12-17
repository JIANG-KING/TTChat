using System;
using System.Windows.Forms;

namespace SqlSeverFrame
{
    public partial class ShowHead : Form
    {
        public ShowHead()
        {
            InitializeComponent();
        }

        private void Head1_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._1;
            Register.HeadName = "head1";
            this.Close();
        }

        private void Head2_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._2;
            Register.HeadName = "head2";
            this.Close();
        }

        private void Head3_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._3;
            Register.HeadName = "head3";
            this.Close();
        }

        private void Head4_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._4;
            Register.HeadName = "head4";
            this.Close();
        }

        private void Head5_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._5;
            Register.HeadName = "head5";
            this.Close();
        }

        private void Head6_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._6;
            Register.HeadName = "head6";
            this.Close();
        }

        private void Head7_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._7;
            Register.HeadName = "head7";
            this.Close();
        }
    }
}
