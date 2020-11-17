namespace SqlSeverFrame
{
    partial class MainFrame
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
            this.MainShowHead = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserState = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).BeginInit();
            this.SuspendLayout();
            // 
            // MainShowHead
            // 
            this.MainShowHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainShowHead.Location = new System.Drawing.Point(668, 11);
            this.MainShowHead.Name = "MainShowHead";
            this.MainShowHead.Size = new System.Drawing.Size(200, 200);
            this.MainShowHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainShowHead.TabIndex = 5;
            this.MainShowHead.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 12);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(67, 15);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "示范文字";
            // 
            // UserState
            // 
            this.UserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserState.FormattingEnabled = true;
            this.UserState.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "离开",
            "忙碌",
            "请勿打扰",
            "q我吧"});
            this.UserState.Location = new System.Drawing.Point(668, 231);
            this.UserState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserState.Name = "UserState";
            this.UserState.Size = new System.Drawing.Size(108, 23);
            this.UserState.TabIndex = 7;
            this.UserState.SelectedIndexChanged += new System.EventHandler(this.UserState_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "qq",
            "ww",
            "123456"});
            this.listBox1.Location = new System.Drawing.Point(148, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 259);
            this.listBox1.TabIndex = 8;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UserState);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.MainShowHead);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MainShowHead;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox UserState;
        private System.Windows.Forms.ListBox listBox1;
    }
}