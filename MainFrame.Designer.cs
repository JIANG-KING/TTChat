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
            this.TextOutPut = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.LoadTime = new System.Windows.Forms.ProgressBar();
            this.LoadText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextOutPut
            // 
            this.TextOutPut.AutoSize = true;
            this.TextOutPut.Location = new System.Drawing.Point(12, 9);
            this.TextOutPut.Name = "TextOutPut";
            this.TextOutPut.Size = new System.Drawing.Size(67, 15);
            this.TextOutPut.TabIndex = 0;
            this.TextOutPut.Text = "示范文字";
            // 
            // Table1
            // 
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.Location = new System.Drawing.Point(-2, 110);
            this.Table1.Name = "Table1";
            this.Table1.RowHeadersWidth = 51;
            this.Table1.RowTemplate.Height = 27;
            this.Table1.Size = new System.Drawing.Size(760, 355);
            this.Table1.TabIndex = 1;
            // 
            // LoadTime
            // 
            this.LoadTime.Location = new System.Drawing.Point(467, 48);
            this.LoadTime.Name = "LoadTime";
            this.LoadTime.Size = new System.Drawing.Size(291, 56);
            this.LoadTime.TabIndex = 2;
            // 
            // LoadText
            // 
            this.LoadText.AutoSize = true;
            this.LoadText.Location = new System.Drawing.Point(406, 66);
            this.LoadText.Name = "LoadText";
            this.LoadText.Size = new System.Drawing.Size(52, 15);
            this.LoadText.TabIndex = 3;
            this.LoadText.Text = "加载中";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 468);
            this.Controls.Add(this.LoadText);
            this.Controls.Add(this.LoadTime);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.TextOutPut);
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextOutPut;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.ProgressBar LoadTime;
        private System.Windows.Forms.Label LoadText;
    }
}