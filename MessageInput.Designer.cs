
namespace TTChat
{
    partial class MessageInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageInput));
            this.ApplicationInput = new System.Windows.Forms.TextBox();
            this.CancelApplicationButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplicationInput
            // 
            this.ApplicationInput.Location = new System.Drawing.Point(12, 12);
            this.ApplicationInput.Multiline = true;
            this.ApplicationInput.Name = "ApplicationInput";
            this.ApplicationInput.Size = new System.Drawing.Size(251, 174);
            this.ApplicationInput.TabIndex = 0;
            // 
            // CancelApplicationButton
            // 
            this.CancelApplicationButton.Location = new System.Drawing.Point(296, 150);
            this.CancelApplicationButton.Name = "CancelApplicationButton";
            this.CancelApplicationButton.Size = new System.Drawing.Size(75, 36);
            this.CancelApplicationButton.TabIndex = 1;
            this.CancelApplicationButton.Text = "取消";
            this.CancelApplicationButton.UseVisualStyleBackColor = true;
            this.CancelApplicationButton.Click += new System.EventHandler(this.CancelApplicationButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(296, 12);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 36);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // MessageInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CancelApplicationButton);
            this.Controls.Add(this.ApplicationInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入验证消息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageInput_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApplicationInput;
        private System.Windows.Forms.Button CancelApplicationButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}