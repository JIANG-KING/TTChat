
namespace TTChat
{
    partial class UpdateUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserInfo));
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.NickNameInput = new System.Windows.Forms.TextBox();
            this.SignatureInput = new System.Windows.Forms.TextBox();
            this.SelectHeadButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.HeadPictureBox = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(8, 24);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(84, 15);
            this.NicknameLabel.TabIndex = 0;
            this.NicknameLabel.Text = "昵    称：";
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.Location = new System.Drawing.Point(8, 80);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(82, 15);
            this.SignatureLabel.TabIndex = 1;
            this.SignatureLabel.Text = "个性签名：";
            // 
            // NickNameInput
            // 
            this.NickNameInput.Location = new System.Drawing.Point(109, 22);
            this.NickNameInput.Name = "NickNameInput";
            this.NickNameInput.Size = new System.Drawing.Size(182, 25);
            this.NickNameInput.TabIndex = 3;
            // 
            // SignatureInput
            // 
            this.SignatureInput.Location = new System.Drawing.Point(109, 78);
            this.SignatureInput.Multiline = true;
            this.SignatureInput.Name = "SignatureInput";
            this.SignatureInput.Size = new System.Drawing.Size(182, 132);
            this.SignatureInput.TabIndex = 4;
            this.SignatureInput.TextChanged += new System.EventHandler(this.SignatureInput_TextChanged);
            // 
            // SelectHeadButton
            // 
            this.SelectHeadButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectHeadButton.Location = new System.Drawing.Point(361, 153);
            this.SelectHeadButton.Name = "SelectHeadButton";
            this.SelectHeadButton.Size = new System.Drawing.Size(140, 25);
            this.SelectHeadButton.TabIndex = 7;
            this.SelectHeadButton.Text = "选择头像";
            this.SelectHeadButton.UseVisualStyleBackColor = true;
            this.SelectHeadButton.Click += new System.EventHandler(this.SelectHeadButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(115, 219);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(65, 32);
            this.ConfirmButton.TabIndex = 9;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(309, 219);
            this.CancleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(65, 32);
            this.CancleButton.TabIndex = 10;
            this.CancleButton.Text = "取消";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // HeadPictureBox
            // 
            this.HeadPictureBox.Location = new System.Drawing.Point(361, 8);
            this.HeadPictureBox.Name = "HeadPictureBox";
            this.HeadPictureBox.Size = new System.Drawing.Size(143, 139);
            this.HeadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadPictureBox.TabIndex = 6;
            this.HeadPictureBox.TabStop = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(297, 81);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(39, 15);
            this.TextLabel.TabIndex = 11;
            this.TextLabel.Text = "0/20";
            // 
            // UpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 257);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SelectHeadButton);
            this.Controls.Add(this.HeadPictureBox);
            this.Controls.Add(this.SignatureInput);
            this.Controls.Add(this.NickNameInput);
            this.Controls.Add(this.SignatureLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改信息";
            this.Load += new System.EventHandler(this.UpdateUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label SignatureLabel;
        private System.Windows.Forms.TextBox NickNameInput;
        private System.Windows.Forms.TextBox SignatureInput;
        private System.Windows.Forms.PictureBox HeadPictureBox;
        private System.Windows.Forms.Button SelectHeadButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Label TextLabel;
    }
}