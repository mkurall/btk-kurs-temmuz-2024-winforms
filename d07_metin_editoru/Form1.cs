namespace d07_metin_editoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiAc_Click(object sender, EventArgs e)
        {
            DialogResult cevap = openFileDialog1.ShowDialog();

            //diyalog penceresinden gelen cevab� kontrol et (Evet,Tamam,�ptal)
            if(cevap == DialogResult.OK)
            {
                //kullan�c�n�n se�ti�i dosyan�n ad� 
                string dosyaAdi = openFileDialog1.FileName;
                string icerik = File.ReadAllText(dosyaAdi);

                txtEditor.Text = icerik;
            }
        }
    }
}
