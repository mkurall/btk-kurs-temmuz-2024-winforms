namespace d03_askerlik_durumu
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
            label1 = new Label();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            cbCinsiyet = new ComboBox();
            chkSaglik = new CheckBox();
            label3 = new Label();
            txtYas = new TextBox();
            rdTecilEvet = new RadioButton();
            rdTecilHayir = new RadioButton();
            lblDurum = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnKontrolEt = new Button();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Adınız ve Soyadınız";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(42, 56);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(276, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 156);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Cinsiyetiniz";
            // 
            // cbCinsiyet
            // 
            cbCinsiyet.FormattingEnabled = true;
            cbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cbCinsiyet.Location = new Point(42, 179);
            cbCinsiyet.Name = "cbCinsiyet";
            cbCinsiyet.Size = new Size(138, 28);
            cbCinsiyet.TabIndex = 3;
            // 
            // chkSaglik
            // 
            chkSaglik.AutoSize = true;
            chkSaglik.Location = new Point(42, 225);
            chkSaglik.Name = "chkSaglik";
            chkSaglik.Size = new Size(179, 24);
            chkSaglik.TabIndex = 4;
            chkSaglik.Text = "Sağlık özrünüz var mı?";
            chkSaglik.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 93);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 0;
            label3.Text = "Yaş";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(42, 116);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(138, 27);
            txtYas.TabIndex = 1;
            // 
            // rdTecilEvet
            // 
            rdTecilEvet.AutoSize = true;
            rdTecilEvet.Location = new Point(42, 286);
            rdTecilEvet.Name = "rdTecilEvet";
            rdTecilEvet.Size = new Size(58, 24);
            rdTecilEvet.TabIndex = 5;
            rdTecilEvet.TabStop = true;
            rdTecilEvet.Text = "Evet";
            rdTecilEvet.UseVisualStyleBackColor = true;
            // 
            // rdTecilHayir
            // 
            rdTecilHayir.AutoSize = true;
            rdTecilHayir.Location = new Point(115, 286);
            rdTecilHayir.Name = "rdTecilHayir";
            rdTecilHayir.Size = new Size(65, 24);
            rdTecilHayir.TabIndex = 6;
            rdTecilHayir.TabStop = true;
            rdTecilHayir.Text = "Hayır";
            rdTecilHayir.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(55, 90);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(161, 20);
            lblDurum.TabIndex = 7;
            lblDurum.Text = "Durum Burada Yazacak";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(324, 56);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 0;
            label5.Text = "TextBox, txtAdSoyad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(186, 119);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 0;
            label6.Text = "TextBox, txtYas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(186, 182);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 0;
            label7.Text = "ComboBox, cbCinsiyet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(227, 225);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 0;
            label8.Text = "CheckBox, chkSaglik";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(139, 263);
            label9.Name = "label9";
            label9.Size = new Size(257, 20);
            label9.TabIndex = 0;
            label9.Text = "RadioButton, rdTecilEvet, rdTecilHayir";
            // 
            // btnKontrolEt
            // 
            btnKontrolEt.Location = new Point(151, 331);
            btnKontrolEt.Name = "btnKontrolEt";
            btnKontrolEt.Size = new Size(167, 35);
            btnKontrolEt.TabIndex = 8;
            btnKontrolEt.Text = "Kontrol Et";
            btnKontrolEt.UseVisualStyleBackColor = true;
            btnKontrolEt.Click += btnKontrolEt_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(252, 364);
            label10.Name = "label10";
            label10.Size = new Size(144, 20);
            label10.TabIndex = 0;
            label10.Text = "Button, btnKontrolEt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDurum);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(419, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 265);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Durum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(130, 63);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 0;
            label4.Text = "lblDurum";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(560, 70);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 0;
            label11.Text = "GroupBox";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 263);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 7;
            label12.Text = "Tecil var mı?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 393);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(btnKontrolEt);
            Controls.Add(rdTecilHayir);
            Controls.Add(rdTecilEvet);
            Controls.Add(chkSaglik);
            Controls.Add(cbCinsiyet);
            Controls.Add(label2);
            Controls.Add(txtYas);
            Controls.Add(label3);
            Controls.Add(txtAdSoyad);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private Label label2;
        private ComboBox cbCinsiyet;
        private CheckBox chkSaglik;
        private Label label3;
        private TextBox txtYas;
        private RadioButton rdTecilEvet;
        private RadioButton rdTecilHayir;
        private Label lblDurum;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnKontrolEt;
        private Label label10;
        private GroupBox groupBox1;
        private Label label11;
        private Label label12;
        private Label label4;
    }
}
