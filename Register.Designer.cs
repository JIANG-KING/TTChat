namespace TTChat
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
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NickNameInput = new System.Windows.Forms.TextBox();
            this.NIckNameTips = new System.Windows.Forms.Label();
            this.UsernameTips = new System.Windows.Forms.Label();
            this.PasswordTips = new System.Windows.Forms.Label();
            this.ConfirmPasswordTips = new System.Windows.Forms.Label();
            this.imagehead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagehead)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 137);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(138, 28);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "用 户 名:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 203);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(138, 28);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "密    码:";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(12, 272);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(138, 28);
            this.ConfirmPasswordLabel.TabIndex = 2;
            this.ConfirmPasswordLabel.Text = "确认密码:";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(172, 134);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(215, 38);
            this.UserName.TabIndex = 4;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(172, 200);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(215, 38);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPassword.Location = new System.Drawing.Point(173, 264);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(215, 38);
            this.ConfirmPassword.TabIndex = 6;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword_TextChanged);
            this.ConfirmPassword.Enter += new System.EventHandler(this.ConfirmPassword_Enter);
            this.ConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPassword_KeyPress);
            this.ConfirmPassword.Leave += new System.EventHandler(this.ConfirmPassword_Leave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterButton.Location = new System.Drawing.Point(149, 367);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(215, 65);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "提交注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(495, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(215, 65);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "返回";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SelectHead
            // 
            this.SelectHead.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectHead.Location = new System.Drawing.Point(603, 264);
            this.SelectHead.Name = "SelectHead";
            this.SelectHead.Size = new System.Drawing.Size(107, 31);
            this.SelectHead.TabIndex = 7;
            this.SelectHead.Text = "选择头像";
            this.SelectHead.UseVisualStyleBackColor = true;
            this.SelectHead.Click += new System.EventHandler(this.SelectHead_Click);
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickNameLabel.Location = new System.Drawing.Point(12, 71);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(138, 28);
            this.NickNameLabel.TabIndex = 11;
            this.NickNameLabel.Text = "昵    称:";
            // 
            // NickNameInput
            // 
            this.NickNameInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickNameInput.Location = new System.Drawing.Point(173, 68);
            this.NickNameInput.Name = "NickNameInput";
            this.NickNameInput.Size = new System.Drawing.Size(214, 38);
            this.NickNameInput.TabIndex = 3;
            this.NickNameInput.Enter += new System.EventHandler(this.NickNameInput_Enter);
            this.NickNameInput.Leave += new System.EventHandler(this.NickNameInput_Leave);
            // 
            // NIckNameTips
            // 
            this.NIckNameTips.Location = new System.Drawing.Point(416, 71);
            this.NIckNameTips.Name = "NIckNameTips";
            this.NIckNameTips.Size = new System.Drawing.Size(121, 38);
            this.NIckNameTips.TabIndex = 12;
            this.NIckNameTips.Text = "中英文皆可，不能包含空格";
            this.NIckNameTips.Visible = false;
            // 
            // UsernameTips
            // 
            this.UsernameTips.Location = new System.Drawing.Point(416, 134);
            this.UsernameTips.Name = "UsernameTips";
            this.UsernameTips.Size = new System.Drawing.Size(121, 35);
            this.UsernameTips.TabIndex = 13;
            this.UsernameTips.Text = "仅支持数字加字母组合";
            this.UsernameTips.Visible = false;
            // 
            // PasswordTips
            // 
            this.PasswordTips.Location = new System.Drawing.Point(416, 196);
            this.PasswordTips.Name = "PasswordTips";
            this.PasswordTips.Size = new System.Drawing.Size(121, 56);
            this.PasswordTips.TabIndex = 14;
            this.PasswordTips.Text = "仅支持数字加字母组合，不支持符号";
            this.PasswordTips.Visible = false;
            // 
            // ConfirmPasswordTips
            // 
            this.ConfirmPasswordTips.Location = new System.Drawing.Point(416, 264);
            this.ConfirmPasswordTips.Name = "ConfirmPasswordTips";
            this.ConfirmPasswordTips.Size = new System.Drawing.Size(121, 35);
            this.ConfirmPasswordTips.TabIndex = 15;
            this.ConfirmPasswordTips.Text = "确认密码不一样";
            this.ConfirmPasswordTips.Visible = false;
            // 
            // imagehead
            // 
            this.imagehead.Location = new System.Drawing.Point(543, 12);
            this.imagehead.Name = "imagehead";
            this.imagehead.Size = new System.Drawing.Size(239, 240);
            this.imagehead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagehead.TabIndex = 8;
            this.imagehead.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(794, 462);
            this.Controls.Add(this.ConfirmPasswordTips);
            this.Controls.Add(this.PasswordTips);
            this.Controls.Add(this.UsernameTips);
            this.Controls.Add(this.NIckNameTips);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
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
        private System.Windows.Forms.Label NIckNameTips;
        private System.Windows.Forms.Label UsernameTips;
        private System.Windows.Forms.Label PasswordTips;
        private System.Windows.Forms.Label ConfirmPasswordTips;
    }
}