namespace d02_iki_sayi_topla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = Convert.ToInt32(txtSayi2.Text);

            int toplam = s1 + s2;

            lblSonuc.Text = $"Sonuç = {toplam}";
        }
    }
}
