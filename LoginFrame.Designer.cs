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
            this.AccountText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.AccountInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CheckNumber = new System.Windows.Forms.PictureBox();
            this.NewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountText
            // 
            this.AccountText.AutoSize = true;
            this.AccountText.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountText.Location = new System.Drawing.Point(117, 121);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(68, 28);
            this.AccountText.TabIndex = 0;
            this.AccountText.Text = "账号";
            this.AccountText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordText.Location = new System.Drawing.Point(117, 264);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(68, 28);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.Text = "密码";
            this.PasswordText.Click += new System.EventHandler(this.PasswordText_Click);
            // 
            // AccountInput
            // 
            this.AccountInput.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountInput.Location = new System.Drawing.Point(214, 120);
            this.AccountInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountInput.Name = "AccountInput";
            this.AccountInput.Size = new System.Drawing.Size(270, 39);
            this.AccountInput.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordInput.Location = new System.Drawing.Point(214, 262);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(270, 39);
            this.PasswordInput.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(122, 408);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(181, 52);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(408, 409);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(179, 50);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CheckNumber
            // 
            this.CheckNumber.Location = new System.Drawing.Point(564, 220);
            this.CheckNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(243, 83);
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.TabStop = false;
            this.CheckNumber.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(635, 409);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(157, 50);
            this.NewButton.TabIndex = 7;
            this.NewButton.Text = "验证";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.CheckNumber);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.AccountInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.AccountText);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginFrame";
            this.Text = "登录窗口";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox AccountInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.PictureBox CheckNumber;
        private System.Windows.Forms.Button NewButton;
    }
}

