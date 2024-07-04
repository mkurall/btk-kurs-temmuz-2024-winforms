namespace d04_tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn00 = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn22 = new Button();
            lblOyuncu1 = new Label();
            lblOyuncu2 = new Label();
            btnBaslat = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn00
            // 
            btn00.Location = new Point(99, 117);
            btn00.Name = "btn00";
            btn00.Size = new Size(90, 90);
            btn00.TabIndex = 0;
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btn01
            // 
            btn01.Location = new Point(195, 117);
            btn01.Name = "btn01";
            btn01.Size = new Size(90, 90);
            btn01.TabIndex = 0;
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += btn00_Click;
            // 
            // btn02
            // 
            btn02.Location = new Point(291, 117);
            btn02.Name = "btn02";
            btn02.Size = new Size(90, 90);
            btn02.TabIndex = 0;
            btn02.UseVisualStyleBackColor = true;
            btn02.Click += btn00_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(99, 213);
            btn10.Name = "btn10";
            btn10.Size = new Size(90, 90);
            btn10.TabIndex = 0;
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn00_Click;
            // 
            // btn11
            // 
            btn11.Location = new Point(195, 213);
            btn11.Name = "btn11";
            btn11.Size = new Size(90, 90);
            btn11.TabIndex = 0;
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn00_Click;
            // 
            // btn12
            // 
            btn12.Location = new Point(291, 213);
            btn12.Name = "btn12";
            btn12.Size = new Size(90, 90);
            btn12.TabIndex = 0;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn00_Click;
            // 
            // btn20
            // 
            btn20.Location = new Point(99, 309);
            btn20.Name = "btn20";
            btn20.Size = new Size(90, 90);
            btn20.TabIndex = 0;
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += btn00_Click;
            // 
            // btn21
            // 
            btn21.Location = new Point(195, 309);
            btn21.Name = "btn21";
            btn21.Size = new Size(90, 90);
            btn21.TabIndex = 0;
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += btn00_Click;
            // 
            // btn22
            // 
            btn22.Location = new Point(291, 309);
            btn22.Name = "btn22";
            btn22.Size = new Size(90, 90);
            btn22.TabIndex = 0;
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += btn00_Click;
            // 
            // lblOyuncu1
            // 
            lblOyuncu1.AutoSize = true;
            lblOyuncu1.Font = new Font("Segoe UI", 14F);
            lblOyuncu1.Location = new Point(18, 75);
            lblOyuncu1.Name = "lblOyuncu1";
            lblOyuncu1.Size = new Size(129, 32);
            lblOyuncu1.TabIndex = 1;
            lblOyuncu1.Text = "OYUNCU 1";
            // 
            // lblOyuncu2
            // 
            lblOyuncu2.AutoSize = true;
            lblOyuncu2.Font = new Font("Segoe UI", 14F);
            lblOyuncu2.Location = new Point(335, 75);
            lblOyuncu2.Name = "lblOyuncu2";
            lblOyuncu2.Size = new Size(129, 32);
            lblOyuncu2.TabIndex = 1;
            lblOyuncu2.Text = "OYUNCU 2";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(195, 12);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.opera;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cross;
            pictureBox2.Location = new Point(371, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 420);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBaslat);
            Controls.Add(lblOyuncu2);
            Controls.Add(lblOyuncu1);
            Controls.Add(btn22);
            Controls.Add(btn12);
            Controls.Add(btn02);
            Controls.Add(btn21);
            Controls.Add(btn20);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn01);
            Controls.Add(btn00);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Label lblOyuncu1;
        private Label lblOyuncu2;
        private Button btnBaslat;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
