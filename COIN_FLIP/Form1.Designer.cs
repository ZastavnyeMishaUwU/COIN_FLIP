namespace COIN_FLIP
{
    partial class Form1
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
			this.CoinImage_1 = new System.Windows.Forms.PictureBox();
			this.CoinFlipButton_1 = new System.Windows.Forms.Button();
			this.HeadsLabel = new System.Windows.Forms.Label();
			this.TailsLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CoinImage_1)).BeginInit();
			this.SuspendLayout();
			// 
			// CoinImage_1
			// 
			this.CoinImage_1.Image = global::COIN_FLIP.Properties.Resources.Heads;
			this.CoinImage_1.Location = new System.Drawing.Point(169, 41);
			this.CoinImage_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CoinImage_1.Name = "CoinImage_1";
			this.CoinImage_1.Size = new System.Drawing.Size(194, 167);
			this.CoinImage_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CoinImage_1.TabIndex = 0;
			this.CoinImage_1.TabStop = false;
			// 
			// CoinFlipButton_1
			// 
			this.CoinFlipButton_1.BackColor = System.Drawing.Color.White;
			this.CoinFlipButton_1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CoinFlipButton_1.Location = new System.Drawing.Point(169, 232);
			this.CoinFlipButton_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CoinFlipButton_1.Name = "CoinFlipButton_1";
			this.CoinFlipButton_1.Size = new System.Drawing.Size(194, 38);
			this.CoinFlipButton_1.TabIndex = 1;
			this.CoinFlipButton_1.Text = "FLIP";
			this.CoinFlipButton_1.UseVisualStyleBackColor = false;
			this.CoinFlipButton_1.Click += new System.EventHandler(this.CoinFlipButton_1_Click_1);
			// 
			// HeadsLabel
			// 
			this.HeadsLabel.AutoSize = true;
			this.HeadsLabel.Location = new System.Drawing.Point(117, 248);
			this.HeadsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HeadsLabel.Name = "HeadsLabel";
			this.HeadsLabel.Size = new System.Drawing.Size(50, 13);
			this.HeadsLabel.TabIndex = 2;
			this.HeadsLabel.Text = "Heads: 0";
			// 
			// TailsLabel
			// 
			this.TailsLabel.AutoSize = true;
			this.TailsLabel.Location = new System.Drawing.Point(367, 248);
			this.TailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TailsLabel.Name = "TailsLabel";
			this.TailsLabel.Size = new System.Drawing.Size(41, 13);
			this.TailsLabel.TabIndex = 3;
			this.TailsLabel.Text = "Tails: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.TailsLabel);
			this.Controls.Add(this.HeadsLabel);
			this.Controls.Add(this.CoinFlipButton_1);
			this.Controls.Add(this.CoinImage_1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "PIDKIt-monetu";
			((System.ComponentModel.ISupportInitialize)(this.CoinImage_1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoinImage_1;
        private System.Windows.Forms.Button CoinFlipButton_1;
        private System.Windows.Forms.Label HeadsLabel;
        private System.Windows.Forms.Label TailsLabel;
    }
}

