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

            //diyalog penceresinden gelen cevabý kontrol et (Evet,Tamam,Ýptal)
            if(cevap == DialogResult.OK)
            {
                //kullanýcýnýn seçtiði dosyanýn adý 
                string dosyaAdi = openFileDialog1.FileName;
                string icerik = File.ReadAllText(dosyaAdi);

                txtEditor.Text = icerik;
            }
        }
    }
}
