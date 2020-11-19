
namespace SqlSeverFrame
{
    partial class Chatting
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.ReciveMessage = new System.Windows.Forms.Timer(this.components);
            this.SengButton = new System.Windows.Forms.Button();
            this.DropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(841, 285);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 316);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(841, 122);
            this.textBox2.TabIndex = 0;
            // 
            // ReciveMessage
            // 
            this.ReciveMessage.Enabled = true;
            this.ReciveMessage.Interval = 1000;
            this.ReciveMessage.Tick += new System.EventHandler(this.ReciveMessage_Tick);
            // 
            // SengButton
            // 
            this.SengButton.AutoSize = true;
            this.SengButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SengButton.Location = new System.Drawing.Point(24, 464);
            this.SengButton.Name = "SengButton";
            this.SengButton.Size = new System.Drawing.Size(126, 38);
            this.SengButton.TabIndex = 2;
            this.SengButton.Text = "发送";
            this.SengButton.UseVisualStyleBackColor = true;
            // 
            // DropButton
            // 
            this.DropButton.AutoSize = true;
            this.DropButton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DropButton.Location = new System.Drawing.Point(745, 464);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(120, 38);
            this.DropButton.TabIndex = 3;
            this.DropButton.Text = "清除";
            this.DropButton.UseVisualStyleBackColor = true;
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 532);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.SengButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Chatting";
            this.Text = "Chatting";
            this.Load += new System.EventHandler(this.Chatting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.Timer ReciveMessage;
        private System.Windows.Forms.Button SengButton;
        private System.Windows.Forms.Button DropButton;
    }
}