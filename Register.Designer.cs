namespace SqlSeverFrame
{
    partial class Register
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectHead = new System.Windows.Forms.Button();
            this.imagehead = new System.Windows.Forms.PictureBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NickNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagehead)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginLabel.Location = new System.Drawing.Point(66, 168);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(165, 33);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "用 户 名:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.Location = new System.Drawing.Point(66, 247);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(166, 33);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "密    码:";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(66, 326);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(164, 33);
            this.ConfirmPasswordLabel.TabIndex = 2;
            this.ConfirmPasswordLabel.Text = "确认密码:";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(230, 164);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(241, 44);
            this.UserName.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(230, 244);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(241, 44);
            this.Password.TabIndex = 5;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPassword.Location = new System.Drawing.Point(230, 323);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(241, 44);
            this.ConfirmPassword.TabIndex = 6;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterButton.Location = new System.Drawing.Point(168, 440);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(242, 78);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "提交注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(557, 440);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(242, 78);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "返回";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SelectHead
            // 
            this.SelectHead.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectHead.Location = new System.Drawing.Point(648, 323);
            this.SelectHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectHead.Name = "SelectHead";
            this.SelectHead.Size = new System.Drawing.Size(120, 37);
            this.SelectHead.TabIndex = 7;
            this.SelectHead.Text = "选择头像";
            this.SelectHead.UseVisualStyleBackColor = true;
            this.SelectHead.Click += new System.EventHandler(this.SelectHead_Click);
            // 
            // imagehead
            // 
            this.imagehead.Location = new System.Drawing.Point(582, 26);
            this.imagehead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagehead.Name = "imagehead";
            this.imagehead.Size = new System.Drawing.Size(269, 288);
            this.imagehead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagehead.TabIndex = 8;
            this.imagehead.TabStop = false;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickNameLabel.Location = new System.Drawing.Point(66, 85);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(166, 33);
            this.NickNameLabel.TabIndex = 11;
            this.NickNameLabel.Text = "昵    称:";
            // 
            // NickNameInput
            // 
            this.NickNameInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickNameInput.Location = new System.Drawing.Point(230, 82);
            this.NickNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NickNameInput.Name = "NickNameInput";
            this.NickNameInput.Size = new System.Drawing.Size(240, 44);
            this.NickNameInput.TabIndex = 3;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.NickNameInput);
            this.Controls.Add(this.NickNameLabel);
            this.Controls.Add(this.SelectHead);
            this.Controls.Add(this.imagehead);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagehead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SelectHead;
        public System.Windows.Forms.PictureBox imagehead;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.TextBox NickNameInput;
    }
}