namespace SqlSeverFrame
{
    partial class LoginFrame
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordText = new System.Windows.Forms.Label();
            this.AccountInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.CheckNumberLabel = new System.Windows.Forms.Label();
            this.CodeInput = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AccountText = new System.Windows.Forms.Label();
            this.ShowHead = new System.Windows.Forms.PictureBox();
            this.CheckNumber = new System.Windows.Forms.PictureBox();
            LoginState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordText.Location = new System.Drawing.Point(66, 180);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(96, 28);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.Text = "密  码";
            // 
            // AccountInput
            // 
            this.AccountInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountInput.Location = new System.Drawing.Point(181, 98);
            this.AccountInput.Name = "AccountInput";
            this.AccountInput.Size = new System.Drawing.Size(240, 38);
            this.AccountInput.TabIndex = 2;
            this.AccountInput.TextChanged += new System.EventHandler(this.AccountInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordInput.Location = new System.Drawing.Point(181, 177);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(240, 38);
            this.PasswordInput.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(181, 329);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 43);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(370, 329);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(159, 42);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(586, 329);
            this.NewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(140, 42);
            this.NewButton.TabIndex = 7;
            this.NewButton.Text = "验证";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // CheckNumberLabel
            // 
            this.CheckNumberLabel.AutoSize = true;
            this.CheckNumberLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckNumberLabel.Location = new System.Drawing.Point(66, 261);
            this.CheckNumberLabel.Name = "CheckNumberLabel";
            this.CheckNumberLabel.Size = new System.Drawing.Size(96, 28);
            this.CheckNumberLabel.TabIndex = 8;
            this.CheckNumberLabel.Text = "验证码";
            // 
            // CodeInput
            // 
            this.CodeInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeInput.Location = new System.Drawing.Point(181, 252);
            this.CodeInput.Name = "CodeInput";
            this.CodeInput.Size = new System.Drawing.Size(100, 38);
            this.CodeInput.TabIndex = 9;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Location = new System.Drawing.Point(427, 266);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(144, 25);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "看不清？换一个！";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AccountText
            // 
            this.AccountText.AutoSize = true;
            this.AccountText.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountText.Location = new System.Drawing.Point(66, 98);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(96, 28);
            this.AccountText.TabIndex = 0;
            this.AccountText.Text = "账  号";
            // 
            // ShowHead
            // 
            this.ShowHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowHead.Image = global::SqlSeverFrame.Properties.Resources.empty;
            this.ShowHead.Location = new System.Drawing.Point(561, 15);
            this.ShowHead.Name = "ShowHead";
            this.ShowHead.Size = new System.Drawing.Size(200, 200);
            this.ShowHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowHead.TabIndex = 13;
            this.ShowHead.TabStop = false;
            // 
            // CheckNumber
            // 
            this.CheckNumber.Location = new System.Drawing.Point(315, 252);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(106, 38);
            this.CheckNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.TabStop = false;
            // 
            // LoginState
            // 
            LoginState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LoginState.FormattingEnabled = true;
            LoginState.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "离开",
            "忙碌",
            "请勿打扰",
            "q我吧"});
            LoginState.Location = new System.Drawing.Point(561, 237);
            LoginState.Name = "LoginState";
            LoginState.Size = new System.Drawing.Size(121, 23);
            LoginState.TabIndex = 14;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(LoginState);
            this.Controls.Add(this.ShowHead);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CodeInput);
            this.Controls.Add(this.CheckNumberLabel);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.CheckNumber);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.AccountInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.AccountText);
            this.Name = "LoginFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗口";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox AccountInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.PictureBox CheckNumber;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label CheckNumberLabel;
        private System.Windows.Forms.TextBox CodeInput;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox ShowHead;
        private System.Windows.Forms.Label AccountText;
        public static System.Windows.Forms.ComboBox LoginState;
    }
}

