
namespace SqlSeverFrame
{
    partial class FriendsApplication
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
            this.ShowFriends = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Agree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowFriends
            // 
            this.ShowFriends.FormattingEnabled = true;
            this.ShowFriends.ItemHeight = 15;
            this.ShowFriends.Location = new System.Drawing.Point(215, 12);
            this.ShowFriends.Name = "ShowFriends";
            this.ShowFriends.Size = new System.Drawing.Size(462, 439);
            this.ShowFriends.TabIndex = 0;
            this.ShowFriends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowFriends_MouseDoubleClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RefreshButton.Location = new System.Drawing.Point(39, 50);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(106, 38);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "刷  新";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Agree.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Agree.Location = new System.Drawing.Point(39, 156);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(106, 38);
            this.Agree.TabIndex = 2;
            this.Agree.Text = "同  意";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // FriendsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 484);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ShowFriends);
            this.Name = "FriendsApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "好友申请";
            this.Load += new System.EventHandler(this.FriendsApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShowFriends;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button Agree;
    }
}