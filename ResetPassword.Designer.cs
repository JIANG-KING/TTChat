
namespace TTChat
{
    partial class ReSetPassword
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
            this.UseNameLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.OldPasswordInput = new System.Windows.Forms.TextBox();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseNameLabel
            // 
            this.UseNameLabel.AutoSize = true;
            this.UseNameLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UseNameLabel.Location = new System.Drawing.Point(56, 104);
            this.UseNameLabel.Name = "UseNameLabel";
            this.UseNameLabel.Size = new System.Drawing.Size(138, 28);
            this.UseNameLabel.TabIndex = 0;
            this.UseNameLabel.Text = "用 户 名:";
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(56, 164);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(152, 28);
            this.OldPasswordLabel.TabIndex = 1;
            this.OldPasswordLabel.Text = "旧 密 码：";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(56, 224);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(152, 28);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "新 密 码：";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(56, 284);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(152, 28);
            this.ConfirmPasswordLabel.TabIndex = 3;
            this.ConfirmPasswordLabel.Text = "确认密码：";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserNameInput.Location = new System.Drawing.Point(212, 101);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(208, 38);
            this.UserNameInput.TabIndex = 4;
            this.UserNameInput.TextChanged += new System.EventHandler(this.UserNameInput_TextChanged);
            this.UserNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameInput_KeyPress);
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPasswordInput.Location = new System.Drawing.Point(212, 161);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.PasswordChar = '*';
            this.OldPasswordInput.Size = new System.Drawing.Size(208, 38);
            this.OldPasswordInput.TabIndex = 5;
            this.OldPasswordInput.TextChanged += new System.EventHandler(this.OldPasswordInput_TextChanged);
            this.OldPasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldPasswordInput_KeyPress);
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPasswordInput.Location = new System.Drawing.Point(212, 221);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.Size = new System.Drawing.Size(208, 38);
            this.NewPasswordInput.TabIndex = 6;
            this.NewPasswordInput.TextChanged += new System.EventHandler(this.NewPasswordInput_TextChanged);
            this.NewPasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPasswordInput_KeyPress);
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(212, 281);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(208, 38);
            this.ConfirmPasswordInput.TabIndex = 7;
            this.ConfirmPasswordInput.TextChanged += new System.EventHandler(this.ConfirmPasswordInput_TextChanged);
            this.ConfirmPasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPasswordInput_KeyPress);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSize = true;
            this.ConfirmButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(61, 353);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(128, 40);
            this.ConfirmButton.TabIndex = 9;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.AutoSize = true;
            this.ReturnButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.Location = new System.Drawing.Point(328, 353);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(128, 40);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "返回";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ReSetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 443);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.NewPasswordInput);
            this.Controls.Add(this.OldPasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.UseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReSetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UseNameLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox OldPasswordInput;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}