namespace d07_metin_editoru
{
    partial class FrmFontVeRenk
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 12);
            button1.Name = "button1";
            button1.Size = new Size(302, 65);
            button1.TabIndex = 0;
            button1.Text = "Yazı Tipi ve Boyutu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 83);
            button2.Name = "button2";
            button2.Size = new Size(302, 65);
            button2.TabIndex = 0;
            button2.Text = "Arka plan rengi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 154);
            button3.Name = "button3";
            button3.Size = new Size(302, 65);
            button3.TabIndex = 0;
            button3.Text = "Yazı Rengi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 108);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Önizleme";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(296, 82);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.ForeColor = Color.White;
            button4.Location = new Point(187, 372);
            button4.Name = "button4";
            button4.Size = new Size(148, 42);
            button4.TabIndex = 2;
            button4.Text = "Tamam";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FrmFontVeRenk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 426);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFontVeRenk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFontVeRenk";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label label1;
        private Button button4;
    }
}