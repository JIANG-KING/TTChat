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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainShowHead = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(14, 329);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(529, 218);
            this.dataGridView1.TabIndex = 4;
            // 
            // MainShowHead
            // 
            this.MainShowHead.Location = new System.Drawing.Point(751, 13);
            this.MainShowHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainShowHead.Name = "MainShowHead";
            this.MainShowHead.Size = new System.Drawing.Size(225, 240);
            this.MainShowHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainShowHead.TabIndex = 5;
            this.MainShowHead.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(15, 14);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(80, 18);
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
            "离线",
            "q我吧",
            "请勿打扰"});
            this.UserState.Location = new System.Drawing.Point(751, 277);
            this.UserState.Name = "UserState";
            this.UserState.Size = new System.Drawing.Size(121, 26);
            this.UserState.TabIndex = 7;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 600);
            this.Controls.Add(this.UserState);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.MainShowHead);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainShowHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox MainShowHead;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox UserState;
    }
}