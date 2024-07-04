namespace d05_zil_saatleri
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSaat = new Label();
            lbSaatler = new ListBox();
            label1 = new Label();
            txtSaat = new TextBox();
            btnEkle = new Button();
            lblEnYakinSaat = new Label();
            lblKalanSure = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 12F);
            lblSaat.Location = new Point(11, 7);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(65, 28);
            lblSaat.TabIndex = 0;
            lblSaat.Text = "label1";
            // 
            // lbSaatler
            // 
            lbSaatler.FormattingEnabled = true;
            lbSaatler.Location = new Point(11, 98);
            lbSaatler.Name = "lbSaatler";
            lbSaatler.Size = new Size(169, 224);
            lbSaatler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Zil Saatleri";
            // 
            // txtSaat
            // 
            txtSaat.Location = new Point(12, 328);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new Size(82, 27);
            txtSaat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(99, 328);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(81, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblEnYakinSaat
            // 
            lblEnYakinSaat.AutoSize = true;
            lblEnYakinSaat.Font = new Font("Segoe UI", 12F);
            lblEnYakinSaat.ForeColor = Color.Red;
            lblEnYakinSaat.Location = new Point(100, 67);
            lblEnYakinSaat.Name = "lblEnYakinSaat";
            lblEnYakinSaat.Size = new Size(65, 28);
            lblEnYakinSaat.TabIndex = 0;
            lblEnYakinSaat.Text = "label1";
            // 
            // lblKalanSure
            // 
            lblKalanSure.AutoSize = true;
            lblKalanSure.Font = new Font("Segoe UI", 12F);
            lblKalanSure.ForeColor = Color.Red;
            lblKalanSure.Location = new Point(14, 35);
            lblKalanSure.Name = "lblKalanSure";
            lblKalanSure.Size = new Size(65, 28);
            lblKalanSure.TabIndex = 0;
            lblKalanSure.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 379);
            Controls.Add(btnEkle);
            Controls.Add(txtSaat);
            Controls.Add(label1);
            Controls.Add(lbSaatler);
            Controls.Add(lblKalanSure);
            Controls.Add(lblEnYakinSaat);
            Controls.Add(lblSaat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblSaat;
        private ListBox lbSaatler;
        private Label label1;
        private TextBox txtSaat;
        private Button btnEkle;
        private Label lblEnYakinSaat;
        private Label lblKalanSure;
    }
}
