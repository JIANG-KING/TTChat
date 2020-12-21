namespace TTChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.PasswordText = new System.Windows.Forms.Label();
            this.AccountInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.CheckNumberLabel = new System.Windows.Forms.Label();
            this.CodeInput = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AccountText = new System.Windows.Forms.Label();
            this.LoginState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenui = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactUsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHead = new System.Windows.Forms.PictureBox();
            this.CheckNumber = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
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
            this.AccountInput.TabIndex = 1;
            this.AccountInput.TextChanged += new System.EventHandler(this.AccountInput_TextChanged);
            this.AccountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountInput_KeyPress);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordInput.Location = new System.Drawing.Point(181, 177);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(240, 38);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            this.PasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordInput_KeyPress);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(120, 329);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(161, 43);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(341, 329);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(159, 42);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.Location = new System.Drawing.Point(561, 330);
            this.UpdatePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(140, 42);
            this.UpdatePasswordButton.TabIndex = 7;
            this.UpdatePasswordButton.Text = "修改密码";
            this.UpdatePasswordButton.UseVisualStyleBackColor = true;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.NewButton_Click);
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
            this.CodeInput.Size = new System.Drawing.Size(112, 38);
            this.CodeInput.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Location = new System.Drawing.Point(443, 266);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(144, 25);
            this.RefreshButton.TabIndex = 4;
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
            // LoginState
            // 
            this.LoginState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginState.FormattingEnabled = true;
            this.LoginState.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "离开",
            "忙碌",
            "请勿打扰",
            "q我吧"});
            this.LoginState.Location = new System.Drawing.Point(561, 237);
            this.LoginState.Name = "LoginState";
            this.LoginState.Size = new System.Drawing.Size(121, 23);
            this.LoginState.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Copyright©2020 Yunking.All Rights Reserved.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenui});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutMenui
            // 
            this.AboutMenui.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactUsMenu});
            this.AboutMenui.Name = "AboutMenui";
            this.AboutMenui.Size = new System.Drawing.Size(53, 24);
            this.AboutMenui.Text = "关于";
            // 
            // ContactUsMenu
            // 
            this.ContactUsMenu.Name = "ContactUsMenu";
            this.ContactUsMenu.Size = new System.Drawing.Size(224, 26);
            this.ContactUsMenu.Text = "联系我们";
            this.ContactUsMenu.Click += new System.EventHandler(this.ContactUsMenu_Click);
            // 
            // ShowHead
            // 
            this.ShowHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowHead.Image = global::TTChat.Properties.Resources.empty;
            this.ShowHead.Location = new System.Drawing.Point(561, 15);
            this.ShowHead.Name = "ShowHead";
            this.ShowHead.Size = new System.Drawing.Size(200, 200);
            this.ShowHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowHead.TabIndex = 13;
            this.ShowHead.TabStop = false;
            // 
            // CheckNumber
            // 
            this.CheckNumber.Location = new System.Drawing.Point(299, 253);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(122, 38);
            this.CheckNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.TabStop = false;
            this.CheckNumber.Click += new System.EventHandler(this.CheckNumber_Click);
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginState);
            this.Controls.Add(this.ShowHead);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CodeInput);
            this.Controls.Add(this.CheckNumberLabel);
            this.Controls.Add(this.UpdatePasswordButton);
            this.Controls.Add(this.CheckNumber);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.AccountInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.AccountText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LoginFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickChat";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button UpdatePasswordButton;
        private System.Windows.Forms.Label CheckNumberLabel;
        private System.Windows.Forms.TextBox CodeInput;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox ShowHead;
        private System.Windows.Forms.Label AccountText;
        private System.Windows.Forms.ComboBox LoginState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenui;
        private System.Windows.Forms.ToolStripMenuItem ContactUsMenu;
    }
}

