
namespace SqlSeverFrame
{
    partial class Loading
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
            this.LoadImage = new System.Windows.Forms.PictureBox();
            this.LoadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImage
            // 
            this.LoadImage.Image = global::SqlSeverFrame.Properties.Resources.Load;
            this.LoadImage.Location = new System.Drawing.Point(30, 30);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(400, 400);
            this.LoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadImage.TabIndex = 0;
            this.LoadImage.TabStop = false;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadLabel.Location = new System.Drawing.Point(172, 477);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(131, 38);
            this.LoadLabel.TabIndex = 1;
            this.LoadLabel.Text = "加载中";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.LoadLabel);
            this.Controls.Add(this.LoadImage);
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadImage;
        private System.Windows.Forms.Label LoadLabel;
    }
}