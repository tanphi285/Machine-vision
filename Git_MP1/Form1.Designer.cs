namespace XLA_MP1_v2
{
    partial class MP1_v2
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.imageBoxR = new Emgu.CV.UI.ImageBox();
            this.labelG = new System.Windows.Forms.Label();
            this.imageBoxG = new Emgu.CV.UI.ImageBox();
            this.labelB = new System.Windows.Forms.Label();
            this.imageBoxB = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(52, 70);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(401, 401);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ảnh gốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cao Tần Phi - 20146513";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(520, 48);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(120, 19);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "Kênh màu RED:";
            this.labelR.Click += new System.EventHandler(this.label3_Click);
            // 
            // imageBoxR
            // 
            this.imageBoxR.Location = new System.Drawing.Point(524, 70);
            this.imageBoxR.Name = "imageBoxR";
            this.imageBoxR.Size = new System.Drawing.Size(401, 401);
            this.imageBoxR.TabIndex = 5;
            this.imageBoxR.TabStop = false;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.Location = new System.Drawing.Point(48, 499);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(137, 19);
            this.labelG.TabIndex = 8;
            this.labelG.Text = "Kênh màu GREEN";
            this.labelG.Click += new System.EventHandler(this.label4_Click);
            // 
            // imageBoxG
            // 
            this.imageBoxG.Location = new System.Drawing.Point(52, 521);
            this.imageBoxG.Name = "imageBoxG";
            this.imageBoxG.Size = new System.Drawing.Size(401, 401);
            this.imageBoxG.TabIndex = 7;
            this.imageBoxG.TabStop = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(520, 499);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(123, 19);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "Kênh màu BLUE";
            this.labelB.Click += new System.EventHandler(this.label5_Click);
            // 
            // imageBoxB
            // 
            this.imageBoxB.Location = new System.Drawing.Point(524, 521);
            this.imageBoxB.Name = "imageBoxB";
            this.imageBoxB.Size = new System.Drawing.Size(401, 401);
            this.imageBoxB.TabIndex = 9;
            this.imageBoxB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 401);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(524, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 401);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(52, 521);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(401, 401);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(524, 521);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(401, 401);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // MP1_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.imageBoxB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.imageBoxG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.imageBoxR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Name = "MP1_v2";
            this.Text = "Tách ảnh màu RBG - v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelR;
        private Emgu.CV.UI.ImageBox imageBoxR;
        private System.Windows.Forms.Label labelG;
        private Emgu.CV.UI.ImageBox imageBoxG;
        private System.Windows.Forms.Label labelB;
        private Emgu.CV.UI.ImageBox imageBoxB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

