using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTChat
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void GitHubSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.GitHubSite.Text);
        }
    }
}
