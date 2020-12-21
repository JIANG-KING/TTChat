
namespace TTChat
{
    partial class UserUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdatePassword));
            this.OldPasswordInput = new System.Windows.Forms.TextBox();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Location = new System.Drawing.Point(197, 28);
            this.OldPasswordInput.Margin = new System.Windows.Forms.Padding(5);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.Size = new System.Drawing.Size(234, 36);
            this.OldPasswordInput.TabIndex = 0;
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Location = new System.Drawing.Point(197, 78);
            this.NewPasswordInput.Margin = new System.Windows.Forms.Padding(5);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.Size = new System.Drawing.Size(234, 36);
            this.NewPasswordInput.TabIndex = 1;
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(197, 127);
            this.ConfirmPasswordInput.Margin = new System.Windows.Forms.Padding(5);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(234, 36);
            this.ConfirmPasswordInput.TabIndex = 2;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(23, 31);
            this.OldPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(138, 25);
            this.OldPasswordLabel.TabIndex = 3;
            this.OldPasswordLabel.Text = "旧 密 码：";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(23, 78);
            this.NewPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(138, 25);
            this.NewPasswordLabel.TabIndex = 4;
            this.NewPasswordLabel.Text = "新 密 码：";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(24, 130);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(137, 25);
            this.ConfirmPasswordLabel.TabIndex = 5;
            this.ConfirmPasswordLabel.Text = "确认密码：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(29, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.NewPasswordInput);
            this.Controls.Add(this.OldPasswordInput);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "UserUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldPasswordInput;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button button1;
    }
}