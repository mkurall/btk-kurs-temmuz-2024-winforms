namespace d06_bilgi_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bilgiler bilgiler = new Bilgiler();

            bilgiler.Ad = txtAd.Text;
            bilgiler.Soyad = txtSoyad.Text;
            bilgiler.Cinsiyet = cbCinsiyet.SelectedIndex;
            bilgiler.DogumTarihi = dtDogumTarihi.Value;
            bilgiler.EgitimDurumu = cbEgitim.SelectedIndex;
            bilgiler.Telefon = mtxtTelefon.Text;
            bilgiler.Adres = txtAdres.Text;


            string data = System.Text.Json.JsonSerializer.Serialize<Bilgiler>(bilgiler);

            File.WriteAllText("bilgiler.txt", data);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = File.ReadAllText("bilgiler.txt");

            Bilgiler bilgiler = System.Text.Json.JsonSerializer.Deserialize<Bilgiler>(str);

            txtAd.Text = bilgiler.Ad;
            txtSoyad.Text = bilgiler.Soyad;
            cbCinsiyet.SelectedIndex = bilgiler.Cinsiyet;
            dtDogumTarihi.Value = bilgiler.DogumTarihi;
            cbEgitim.SelectedIndex = bilgiler.EgitimDurumu;
            mtxtTelefon.Text = bilgiler.Telefon;
            txtAdres.Text = bilgiler.Adres;

        }
    }
}
