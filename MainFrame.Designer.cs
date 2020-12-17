namespace SqlSeverFrame
{
    partial class MainFrame
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserState = new System.Windows.Forms.ComboBox();
            this.FriendsList = new System.Windows.Forms.ListBox();
            this.FriendsListLabel = new System.Windows.Forms.Label();
            this.ReFreshButton = new System.Windows.Forms.Button();
            this.ReSetPasswordButton = new System.Windows.Forms.Button();
            this.AddFriendsButton = new System.Windows.Forms.Button();
            this.FriendApplication = new System.Windows.Forms.Button();
            this.newApplication = new System.Windows.Forms.PictureBox();
            this.MainShowHead = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 12);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(67, 15);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "示范文字";
            // 
            // UserState
            // 
            this.UserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserState.FormattingEnabled = true;
            this.UserState.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "离开",
            "忙碌",
            "请勿打扰",
            "q我吧"});
            this.UserState.Location = new System.Drawing.Point(668, 231);
            this.UserState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserState.Name = "UserState";
            this.UserState.Size = new System.Drawing.Size(108, 23);
            this.UserState.TabIndex = 7;
            this.UserState.SelectedIndexChanged += new System.EventHandler(this.UserState_SelectedIndexChanged);
            // 
            // FriendsList
            // 
            this.FriendsList.FormattingEnabled = true;
            this.FriendsList.ItemHeight = 15;
            this.FriendsList.Location = new System.Drawing.Point(271, 44);
            this.FriendsList.Name = "FriendsList";
            this.FriendsList.Size = new System.Drawing.Size(341, 364);
            this.FriendsList.TabIndex = 8;
            this.FriendsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FriendsList_MouseDoubleClick);
            // 
            // FriendsListLabel
            // 
            this.FriendsListLabel.AutoSize = true;
            this.FriendsListLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsListLabel.Location = new System.Drawing.Point(266, 9);
            this.FriendsListLabel.Name = "FriendsListLabel";
            this.FriendsListLabel.Size = new System.Drawing.Size(124, 28);
            this.FriendsListLabel.TabIndex = 9;
            this.FriendsListLabel.Text = "好友列表";
            // 
            // ReFreshButton
            // 
            this.ReFreshButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReFreshButton.Location = new System.Drawing.Point(396, 9);
            this.ReFreshButton.Name = "ReFreshButton";
            this.ReFreshButton.Size = new System.Drawing.Size(83, 30);
            this.ReFreshButton.TabIndex = 10;
            this.ReFreshButton.Text = "刷新";
            this.ReFreshButton.UseVisualStyleBackColor = true;
            this.ReFreshButton.Click += new System.EventHandler(this.ReFreshButton_Click);
            // 
            // ReSetPasswordButton
            // 
            this.ReSetPasswordButton.AutoSize = true;
            this.ReSetPasswordButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReSetPasswordButton.Location = new System.Drawing.Point(668, 359);
            this.ReSetPasswordButton.Name = "ReSetPasswordButton";
            this.ReSetPasswordButton.Size = new System.Drawing.Size(140, 38);
            this.ReSetPasswordButton.TabIndex = 11;
            this.ReSetPasswordButton.Text = "修改密码";
            this.ReSetPasswordButton.UseVisualStyleBackColor = true;
            // 
            // AddFriendsButton
            // 
            this.AddFriendsButton.AutoSize = true;
            this.AddFriendsButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddFriendsButton.Location = new System.Drawing.Point(41, 300);
            this.AddFriendsButton.Name = "AddFriendsButton";
            this.AddFriendsButton.Size = new System.Drawing.Size(140, 38);
            this.AddFriendsButton.TabIndex = 12;
            this.AddFriendsButton.Text = "添加好友";
            this.AddFriendsButton.UseVisualStyleBackColor = true;
            this.AddFriendsButton.Click += new System.EventHandler(this.AddFriendsButton_Click);
            // 
            // FriendApplication
            // 
            this.FriendApplication.AutoSize = true;
            this.FriendApplication.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendApplication.Location = new System.Drawing.Point(41, 369);
            this.FriendApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendApplication.Name = "FriendApplication";
            this.FriendApplication.Size = new System.Drawing.Size(140, 38);
            this.FriendApplication.TabIndex = 13;
            this.FriendApplication.Text = "好友申请";
            this.FriendApplication.UseVisualStyleBackColor = true;
            this.FriendApplication.Click += new System.EventHandler(this.FriendApplication_Click);
            // 
            // newApplication
            // 
            this.newApplication.Image = global::SqlSeverFrame.Properties.Resources.newmessage;
            this.newApplication.Location = new System.Drawing.Point(187, 369);
            this.newApplication.Name = "newApplication";
            this.newApplication.Size = new System.Drawing.Size(39, 39);
            this.newApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newApplication.TabIndex = 14;
            this.newApplication.TabStop = false;
            // 
            // MainShowHead
            // 
            this.MainShowHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainShowHead.Location = new System.Drawing.Point(668, 11);
            this.MainShowHead.Name = "MainShowHead";
            this.MainShowHead.Size = new System.Drawing.Size(200, 200);
            this.MainShowHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainShowHead.TabIndex = 5;
            this.MainShowHead.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "注销";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newApplication);
            this.Controls.Add(this.FriendApplication);
            this.Controls.Add(this.AddFriendsButton);
            this.Controls.Add(this.ReSetPasswordButton);
            this.Controls.Add(this.ReFreshButton);
            this.Controls.Add(this.FriendsListLabel);
            this.Controls.Add(this.FriendsList);
            this.Controls.Add(this.UserState);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.MainShowHead);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用TT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MainShowHead;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox UserState;
        private System.Windows.Forms.ListBox FriendsList;
        private System.Windows.Forms.Label FriendsListLabel;
        private System.Windows.Forms.Button ReFreshButton;
        private System.Windows.Forms.Button ReSetPasswordButton;
        private System.Windows.Forms.Button AddFriendsButton;
        private System.Windows.Forms.Button FriendApplication;
        private System.Windows.Forms.PictureBox newApplication;
        private System.Windows.Forms.Button button1;
    }
}