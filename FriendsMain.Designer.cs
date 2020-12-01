
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
            this.FriendsHead = new System.Windows.Forms.PictureBox();
            this.FriendsNickName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UserState = new System.Windows.Forms.Label();
            this.ShowInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsHead)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendsAccountInput
            // 
            this.FriendsAccountInput.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsAccountInput.Location = new System.Drawing.Point(18, 99);
            this.FriendsAccountInput.Name = "FriendsAccountInput";
            this.FriendsAccountInput.Size = new System.Drawing.Size(311, 44);
            this.FriendsAccountInput.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(18, 194);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 43);
            this.Search.TabIndex = 1;
            this.Search.Text = "搜索";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // FriendsHead
            // 
            this.FriendsHead.Location = new System.Drawing.Point(760, 25);
            this.FriendsHead.Name = "FriendsHead";
            this.FriendsHead.Size = new System.Drawing.Size(300, 300);
            this.FriendsHead.TabIndex = 2;
            this.FriendsHead.TabStop = false;
            // 
            // FriendsNickName
            // 
            this.FriendsNickName.AutoSize = true;
            this.FriendsNickName.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsNickName.Location = new System.Drawing.Point(522, 12);
            this.FriendsNickName.Name = "FriendsNickName";
            this.FriendsNickName.Size = new System.Drawing.Size(207, 33);
            this.FriendsNickName.TabIndex = 3;
            this.FriendsNickName.Text = "这里显示昵称";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(176, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "添加好友";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserState
            // 
            this.UserState.AutoSize = true;
            this.UserState.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserState.Location = new System.Drawing.Point(757, 390);
            this.UserState.Name = "UserState";
            this.UserState.Size = new System.Drawing.Size(236, 28);
            this.UserState.TabIndex = 5;
            this.UserState.Text = "这里显示在线状态";
            // 
            // ShowInfoLabel
            // 
            this.ShowInfoLabel.AutoSize = true;
            this.ShowInfoLabel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowInfoLabel.Location = new System.Drawing.Point(12, 12);
            this.ShowInfoLabel.Name = "ShowInfoLabel";
            this.ShowInfoLabel.Size = new System.Drawing.Size(303, 33);
            this.ShowInfoLabel.TabIndex = 6;
            this.ShowInfoLabel.Text = "请输入要搜索的账号";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 194);
            this.label1.TabIndex = 7;
            this.label1.Text = "好友功能为直接添加，无需同意，但需要对方打开你的聊天窗口才能接收你的消息";
            // 
            // FriendsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowInfoLabel);
            this.Controls.Add(this.UserState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FriendsNickName);
            this.Controls.Add(this.FriendsHead);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.FriendsAccountInput);
            this.Name = "FriendsMain";
            this.Text = "FriendsMain";
            ((System.ComponentModel.ISupportInitialize)(this.FriendsHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FriendsAccountInput;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox FriendsHead;
        private System.Windows.Forms.Label FriendsNickName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label UserState;
        private System.Windows.Forms.Label ShowInfoLabel;
        private System.Windows.Forms.Label label1;
    }
}