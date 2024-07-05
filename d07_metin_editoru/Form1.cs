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

            //diyalog penceresinden gelen cevab� kontrol et (Evet,Tamam,�ptal)
            if (cevap == DialogResult.OK)
            {
                //kullan�c�n�n se�ti�i dosyan�n ad� 
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
            acikOlanDosya = null;//art�k kay�tl� olan a��k dosya yok
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(acikOlanDosya == null) //dosya ad� bo� mu
            {
                //SaveFileDialog s�n�f�ndan bir �rnek olu�tur
                SaveFileDialog dialog = new SaveFileDialog();

                DialogResult cevap = dialog.ShowDialog();

                if (cevap == DialogResult.OK)
                {
                    string dosyaAdi = dialog.FileName;
                    //*******Art�k dosya A��k
                    acikOlanDosya = dosyaAdi;

                    File.WriteAllText(dosyaAdi, txtEditor.Text);
                }
            }
            else //Dosya daha �nce kay�tl� ise
            {
                File.WriteAllText(acikOlanDosya, txtEditor.Text);
            }
        }
    }
}
