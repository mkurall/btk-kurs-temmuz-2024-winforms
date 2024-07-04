namespace d06_bilgi_formu
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            cbCinsiyet = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbEgitim = new ComboBox();
            label6 = new Label();
            dtDogumTarihi = new DateTimePicker();
            label7 = new Label();
            mtxtTelefon = new MaskedTextBox();
            label8 = new Label();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 98);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user__1_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(104, 17);
            label1.Name = "label1";
            label1.Size = new Size(389, 54);
            label1.TabIndex = 0;
            label1.Text = "Kişisel Bilgiler Formu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(25, 134);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 27);
            txtAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 165);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(25, 188);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 27);
            txtSoyad.TabIndex = 2;
            // 
            // cbCinsiyet
            // 
            cbCinsiyet.FormattingEnabled = true;
            cbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cbCinsiyet.Location = new Point(25, 245);
            cbCinsiyet.Name = "cbCinsiyet";
            cbCinsiyet.Size = new Size(151, 28);
            cbCinsiyet.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 331);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 1;
            label5.Text = "Eğitim Durumu";
            // 
            // cbEgitim
            // 
            cbEgitim.FormattingEnabled = true;
            cbEgitim.Items.AddRange(new object[] { "İlkokul", "Ortaokul", "Lise", "Ön Lisans", "Lisans", "Yüksek Lisans" });
            cbEgitim.Location = new Point(25, 354);
            cbEgitim.Name = "cbEgitim";
            cbEgitim.Size = new Size(151, 28);
            cbEgitim.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 276);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 1;
            label6.Text = "Doğum Tarihi";
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(25, 299);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(250, 27);
            dtDogumTarihi.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 386);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 1;
            label7.Text = "Telefon";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(25, 409);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(250, 27);
            mtxtTelefon.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 437);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 1;
            label8.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(25, 460);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(547, 79);
            txtAdres.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LightSkyBlue;
            btnKaydet.Location = new Point(422, 554);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 51);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 617);
            Controls.Add(btnKaydet);
            Controls.Add(mtxtTelefon);
            Controls.Add(dtDogumTarihi);
            Controls.Add(cbEgitim);
            Controls.Add(cbCinsiyet);
            Controls.Add(label5);
            Controls.Add(txtAdres);
            Controls.Add(txtSoyad);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private ComboBox cbCinsiyet;
        private Label label4;
        private Label label5;
        private ComboBox cbEgitim;
        private Label label6;
        private DateTimePicker dtDogumTarihi;
        private Label label7;
        private MaskedTextBox mtxtTelefon;
        private Label label8;
        private TextBox txtAdres;
        private Button btnKaydet;
    }
}
