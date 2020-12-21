
namespace TTChat
{
    partial class Contact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.GitHubSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(100, 79);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(188, 15);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "邮箱：1019878449@qq.com";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(100, 135);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(164, 15);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "电话：+86176****1234";
            // 
            // GitHubSite
            // 
            this.GitHubSite.AutoSize = true;
            this.GitHubSite.Location = new System.Drawing.Point(81, 213);
            this.GitHubSite.Name = "GitHubSite";
            this.GitHubSite.Size = new System.Drawing.Size(239, 15);
            this.GitHubSite.TabIndex = 2;
            this.GitHubSite.TabStop = true;
            this.GitHubSite.Text = "https://github.com/JIANG-KING";
            this.GitHubSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubSite_LinkClicked);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 296);
            this.Controls.Add(this.GitHubSite);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "联系支持";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.LinkLabel GitHubSite;
    }
}