﻿
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
            this.refresh = new System.Windows.Forms.Button();
            this.Agree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowFriends
            // 
            this.ShowFriends.FormattingEnabled = true;
            this.ShowFriends.ItemHeight = 15;
            this.ShowFriends.Location = new System.Drawing.Point(454, 12);
            this.ShowFriends.Name = "ShowFriends";
            this.ShowFriends.Size = new System.Drawing.Size(360, 409);
            this.ShowFriends.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refresh.Location = new System.Drawing.Point(234, 35);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(106, 38);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "刷  新";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Agree.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Agree.Location = new System.Drawing.Point(234, 163);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(106, 38);
            this.Agree.TabIndex = 2;
            this.Agree.Text = "同  意";
            this.Agree.UseVisualStyleBackColor = true;
            // 
            // FriendsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 474);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.ShowFriends);
            this.Name = "FriendsApplication";
            this.Text = "FriendsApplication";
            this.Load += new System.EventHandler(this.FriendsApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShowFriends;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button Agree;
    }
}