namespace SqlSeverFrame
{
    partial class CheckNumber
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.InputInfo = new System.Windows.Forms.Label();
            this.CheckNumberShow = new System.Windows.Forms.Label();
            this.TextBoxCheck = new System.Windows.Forms.PictureBox();
            this.CheckInformation = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextInput.Location = new System.Drawing.Point(295, 102);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(318, 44);
            this.TextInput.TabIndex = 0;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged_1);
            this.TextInput.Enter += new System.EventHandler(this.TextInput_Enter);
            this.TextInput.Leave += new System.EventHandler(this.TextInput_Leave);
            // 
            // InputInfo
            // 
            this.InputInfo.AutoSize = true;
            this.InputInfo.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputInfo.Location = new System.Drawing.Point(44, 105);
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(207, 33);
            this.InputInfo.TabIndex = 1;
            this.InputInfo.Text = "请输入验证码";
            // 
            // CheckNumberShow
            // 
            this.CheckNumberShow.AutoSize = true;
            this.CheckNumberShow.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckNumberShow.Location = new System.Drawing.Point(295, 346);
            this.CheckNumberShow.Name = "CheckNumberShow";
            this.CheckNumberShow.Size = new System.Drawing.Size(111, 33);
            this.CheckNumberShow.TabIndex = 3;
            this.CheckNumberShow.Text = "label1";
            // 
            // TextBoxCheck
            // 
            this.TextBoxCheck.Location = new System.Drawing.Point(295, 231);
            this.TextBoxCheck.Name = "TextBoxCheck";
            this.TextBoxCheck.Size = new System.Drawing.Size(318, 69);
            this.TextBoxCheck.TabIndex = 2;
            this.TextBoxCheck.TabStop = false;
            // 
            // CheckInformation
            // 
            this.CheckInformation.AutoSize = true;
            this.CheckInformation.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckInformation.Location = new System.Drawing.Point(632, 105);
            this.CheckInformation.Name = "CheckInformation";
            this.CheckInformation.Size = new System.Drawing.Size(47, 33);
            this.CheckInformation.TabIndex = 4;
            this.CheckInformation.Text = "×";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.Location = new System.Drawing.Point(519, 331);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(199, 75);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CheckNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CheckInformation);
            this.Controls.Add(this.CheckNumberShow);
            this.Controls.Add(this.TextBoxCheck);
            this.Controls.Add(this.InputInfo);
            this.Controls.Add(this.TextInput);
            this.Name = "CheckNumber";
            this.Load += new System.EventHandler(this.CheckNumber_Load);
            this.Enter += new System.EventHandler(this.CheckNumber_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label InputInfo;
        private System.Windows.Forms.PictureBox TextBoxCheck;
        private System.Windows.Forms.Label CheckNumberShow;
        private System.Windows.Forms.Label CheckInformation;
        private System.Windows.Forms.Button SubmitButton;
    }
}