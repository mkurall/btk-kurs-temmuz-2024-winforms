namespace d07_metin_editoru
{
    public partial class Form1 : Form
    {
        string? acikOlanDosya = null;//null yok demek

        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiAc_Click(object sender, EventArgs e)
        {
            DialogResult cevap = openFileDialog1.ShowDialog();

            //diyalog penceresinden gelen cevabý kontrol et (Evet,Tamam,Ýptal)
            if (cevap == DialogResult.OK)
            {
                //kullanýcýnýn seçtiði dosyanýn adý 
                string dosyaAdi = openFileDialog1.FileName;
                string icerik = File.ReadAllText(dosyaAdi);

                acikOlanDosya = dosyaAdi;//sakla daHA SONRA kullan

                Text = Path.GetFileName(dosyaAdi);

                txtEditor.Text = icerik;
            }
        }

        private void tsmiYeni_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "";
            Text = "Yeni Dosya";
            acikOlanDosya = null;//artýk kayýtlý olan açýk dosya yok
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikOlanDosya == null) //dosya adý boþ mu
            {
                //SaveFileDialog sýnýfýndan bir örnek oluþtur
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Metin Dosyalarý(*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
                dialog.DefaultExt = "*.txt";

                DialogResult cevap = dialog.ShowDialog();

                if (cevap == DialogResult.OK)
                {
                    string dosyaAdi = dialog.FileName;
                    //*******Artýk dosya Açýk
                    acikOlanDosya = dosyaAdi;

                    File.WriteAllText(dosyaAdi, txtEditor.Text);
                }
            }
            else //Dosya daha önce kayýtlý ise
            {
                File.WriteAllText(acikOlanDosya, txtEditor.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Uygulama kapatýlýyor....");
            //MessageBox.Show("Uygulama kapatýlýyor....","Dikkat");
            //MessageBox.Show("Uygulama kapatýlýyor....","Dikkat",MessageBoxButtons.YesNo);
            //MessageBox.Show("Uygulama kapatýlýyor....","Dikkat",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            DialogResult cevap = MessageBox.Show("Deðiþiklikleri kayýt etmek ister misiniz?", "Dikkat",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kaydetToolStripMenuItem_Click(sender, EventArgs.Empty);
            }
            else if (cevap == DialogResult.Cancel)
            {
                e.Cancel = true;//formu kapatmaktan vazgeçtim diye windows'a söylüyorum
            }
        }

        private void hakkýndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formun yeni bir örneðini oluþturdum
            FrmHakkinda form = new FrmHakkinda();

            //form.Show(); //arkada kalan forma týklanabilir
            form.ShowDialog();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void renkAyarlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFontVeRenk form = new FrmFontVeRenk(txtEditor);
            form.ShowDialog();
            //tamama basýldý 

            txtEditor.Font = form.SeciliFont;
            txtEditor.BackColor = form.SeciliArkaplanRengi;
            txtEditor.ForeColor = form.SeciliYaziRengi;



        }
    }
}
