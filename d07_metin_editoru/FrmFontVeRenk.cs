using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d07_metin_editoru
{
    public partial class FrmFontVeRenk : Form
    {
        public FrmFontVeRenk(TextBox editor)
        {
            InitializeComponent();

            label1.Font = editor.Font;
            label1.BackColor = editor.BackColor;
            label1.ForeColor = editor.ForeColor;

            SeciliFont = editor.Font;
            SeciliArkaplanRengi = editor.BackColor;
            SeciliYaziRengi = editor.ForeColor;

        }

        //public void VerileriGonder(TextBox editor)
        //{

        //}

        public Font SeciliFont { get; set; }
        public Color SeciliArkaplanRengi { get; set; }
        public Color SeciliYaziRengi { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = label1.Font;
            DialogResult cevap = dialog.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                label1.Font = dialog.Font;
                SeciliFont = dialog.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            dialog.Color = label1.BackColor;
            DialogResult cevap = dialog.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                label1.BackColor = dialog.Color;
                SeciliArkaplanRengi = dialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            dialog.Color = label1.ForeColor;
            DialogResult cevap = dialog.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                label1.ForeColor = dialog.Color;
                SeciliYaziRengi = dialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
