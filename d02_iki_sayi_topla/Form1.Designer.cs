namespace d02_iki_sayi_topla
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
            txtSayi1 = new TextBox();
            label2 = new Label();
            txtSayi2 = new TextBox();
            btnTopla = new Button();
            lblSonuc = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Sayı";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(83, 41);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 0;
            label2.Text = "2.Sayı";
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(83, 74);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 1;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(114, 117);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(94, 29);
            btnTopla.TabIndex = 2;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(35, 158);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 20);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(215, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "txtSayi1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(215, 75);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "txtSayi2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(209, 121);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "btnTopla";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(35, 178);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 4;
            label6.Text = "lblSonuc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 236);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSonuc);
            Controls.Add(btnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "İki sayıyı toplayan uygulama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private Label label2;
        private TextBox txtSayi2;
        private Button btnTopla;
        private Label lblSonuc;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
