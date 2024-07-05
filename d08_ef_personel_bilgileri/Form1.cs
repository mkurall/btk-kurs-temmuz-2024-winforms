using d08_ef_personel_bilgileri.modeller;
using d08_ef_personel_bilgileri.veri;

namespace d08_ef_personel_bilgileri
{
    public partial class Form1 : Form
    {
        //baðlantýyý oluþtur
        FabrikaDbContext db = new FabrikaDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //veritabaný üzerinden personelbilgileri getir
            var liste = db.PersonelBilgileri.ToList();

            //liste kutusuna baðla
            listBox1.DataSource = liste;
            //liste kutusuna göstereceði property leri söyle
            listBox1.DisplayMember = "AdSoyad";
            //iliþkileri yöneteceðim anahtar
            listBox1.ValueMember = "Id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelBilgi yeni = new PersonelBilgi();

            yeni.Ad = textBox1.Text;
            yeni.Soyad = textBox2.Text;
            yeni.Telefon = textBox3.Text;
            yeni.Adres = textBox4.Text;

            //veritabanýna tabloya ekle (insert)
            db.PersonelBilgileri.Add(yeni);

            db.SaveChanges();//veritabanýný kaydet

            //liste kutusunu yenilemek için
            Form1_Load(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelBilgi secili = listBox1.SelectedItem as PersonelBilgi;

            if(secili!=null)
            {
                textBox1.Text = secili.Ad;
                textBox2.Text = secili.Soyad;
                textBox3.Text = secili.Telefon;
                textBox4.Text = secili.Adres;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

        }
    }
}
