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
            if(acikOlanDosya == null) //dosya adý boþ mu
            {
                //SaveFileDialog sýnýfýndan bir örnek oluþtur
                SaveFileDialog dialog = new SaveFileDialog();

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
    }
}
