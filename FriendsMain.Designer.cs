
namespace SqlSeverFrame
{
    partial class FriendsMain
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
            this.FriendsAccountInput = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.FriendsNickName = new System.Windows.Forms.Label();
            this.SendFriendsApplication = new System.Windows.Forms.Button();
            this.UserState = new System.Windows.Forms.Label();
            this.ShowInfoLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.FriendsHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsHead)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendsAccountInput
            // 
            this.FriendsAccountInput.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsAccountInput.Location = new System.Drawing.Point(16, 139);
            this.FriendsAccountInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsAccountInput.Name = "FriendsAccountInput";
            this.FriendsAccountInput.Size = new System.Drawing.Size(277, 38);
            this.FriendsAccountInput.TabIndex = 0;
            this.FriendsAccountInput.TextChanged += new System.EventHandler(this.FriendsAccountInput_TextChanged);
            this.FriendsAccountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FriendsAccountInput_KeyPress);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(16, 234);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(89, 37);
            this.Search.TabIndex = 1;
            this.Search.Text = "搜索";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FriendsNickName
            // 
            this.FriendsNickName.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsNickName.Location = new System.Drawing.Point(383, 21);
            this.FriendsNickName.Name = "FriendsNickName";
            this.FriendsNickName.Size = new System.Drawing.Size(244, 67);
            this.FriendsNickName.TabIndex = 3;
            this.FriendsNickName.Text = "这里显示昵称";
            // 
            // SendFriendsApplication
            // 
            this.SendFriendsApplication.AutoSize = true;
            this.SendFriendsApplication.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendFriendsApplication.Location = new System.Drawing.Point(139, 234);
            this.SendFriendsApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendFriendsApplication.Name = "SendFriendsApplication";
            this.SendFriendsApplication.Size = new System.Drawing.Size(184, 37);
            this.SendFriendsApplication.TabIndex = 4;
            this.SendFriendsApplication.Text = "发送好友申请";
            this.SendFriendsApplication.UseVisualStyleBackColor = true;
            this.SendFriendsApplication.Click += new System.EventHandler(this.SendFriendsApplication_Click);
            // 
            // UserState
            // 
            this.UserState.AutoSize = true;
            this.UserState.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserState.Location = new System.Drawing.Point(384, 163);
            this.UserState.Name = "UserState";
            this.UserState.Size = new System.Drawing.Size(202, 24);
            this.UserState.TabIndex = 5;
            this.UserState.Text = "这里显示在线状态";
            // 
            // ShowInfoLabel
            // 
            this.ShowInfoLabel.AutoSize = true;
            this.ShowInfoLabel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowInfoLabel.Location = new System.Drawing.Point(11, 10);
            this.ShowInfoLabel.Name = "ShowInfoLabel";
            this.ShowInfoLabel.Size = new System.Drawing.Size(255, 27);
            this.ShowInfoLabel.TabIndex = 6;
            this.ShowInfoLabel.Text = "请输入要搜索的账号";
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.AccountLabel.Location = new System.Drawing.Point(383, 88);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(174, 27);
            this.AccountLabel.TabIndex = 7;
            this.AccountLabel.Text = "这里显示账号";
            // 
            // FriendsHead
            // 
            this.FriendsHead.Location = new System.Drawing.Point(676, 21);
            this.FriendsHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsHead.Name = "FriendsHead";
            this.FriendsHead.Size = new System.Drawing.Size(267, 250);
            this.FriendsHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FriendsHead.TabIndex = 2;
            this.FriendsHead.TabStop = false;
            // 
            // FriendsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 453);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.ShowInfoLabel);
            this.Controls.Add(this.UserState);
            this.Controls.Add(this.SendFriendsApplication);
            this.Controls.Add(this.FriendsNickName);
            this.Controls.Add(this.FriendsHead);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.FriendsAccountInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FriendsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "好友添加";
            this.Load += new System.EventHandler(this.FriendsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FriendsHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FriendsAccountInput;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox FriendsHead;
        private System.Windows.Forms.Label FriendsNickName;
        private System.Windows.Forms.Button SendFriendsApplication;
        private System.Windows.Forms.Label UserState;
        private System.Windows.Forms.Label ShowInfoLabel;
        private System.Windows.Forms.Label AccountLabel;
    }
}