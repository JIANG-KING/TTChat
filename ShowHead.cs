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

        private void head1_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._1;
            Register.HeadName = this.head1.Name;
            this.Close();
        }

        private void head2_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._2;
            Register.HeadName = this.head2.Name;
            this.Close();
        }

        private void hed3_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._3;
            Register.HeadName = this.head3.Name;
            this.Close();
        }

        private void head4_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._4;
            Register.HeadName = this.head4.Name;
            this.Close();
        }

        private void head5_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._5;
            Register.HeadName = this.head5.Name;
            this.Close();
        }

        private void head6_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._6;
            Register.HeadName = this.head6.Name;
            this.Close();
        }

        private void head7_Click(object sender, EventArgs e)
        {
            Register.HeadImage = global::SqlSeverFrame.Properties.Resources._7;
            Register.HeadName = this.head7.Name;
            this.Close();
        }
    }
}
