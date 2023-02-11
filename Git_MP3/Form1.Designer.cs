namespace XLA_MP3_v1
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
            this.SourceImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrayScale1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrayScale2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrayScale3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale3)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImg
            // 
            this.SourceImg.Location = new System.Drawing.Point(39, 80);
            this.SourceImg.Name = "SourceImg";
            this.SourceImg.Size = new System.Drawing.Size(500, 381);
            this.SourceImg.TabIndex = 1;
            this.SourceImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ảnh gốc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mức xám Lightness:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GrayScale1
            // 
            this.GrayScale1.Location = new System.Drawing.Point(628, 80);
            this.GrayScale1.Name = "GrayScale1";
            this.GrayScale1.Size = new System.Drawing.Size(500, 381);
            this.GrayScale1.TabIndex = 3;
            this.GrayScale1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mức xám Average:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GrayScale2
            // 
            this.GrayScale2.Location = new System.Drawing.Point(39, 528);
            this.GrayScale2.Name = "GrayScale2";
            this.GrayScale2.Size = new System.Drawing.Size(500, 381);
            this.GrayScale2.TabIndex = 5;
            this.GrayScale2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mức xám Luminance:";
            // 
            // GrayScale3
            // 
            this.GrayScale3.Location = new System.Drawing.Point(628, 528);
            this.GrayScale3.Name = "GrayScale3";
            this.GrayScale3.Size = new System.Drawing.Size(500, 381);
            this.GrayScale3.TabIndex = 7;
            this.GrayScale3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cao Tần Phi - 20146513";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrayScale3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrayScale2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrayScale1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceImg);
            this.Name = "Form1";
            this.Text = "Chuyển màu RBG sang GrayScale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayScale3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SourceImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox GrayScale1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox GrayScale2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox GrayScale3;
        private System.Windows.Forms.Label label5;
    }
}

