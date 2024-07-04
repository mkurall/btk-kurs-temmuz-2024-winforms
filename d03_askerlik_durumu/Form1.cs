namespace d03_askerlik_durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            string ad = txtAdSoyad.Text;
            int yas = Convert.ToInt32(txtYas.Text);

            int cinsiyet = cbCinsiyet.SelectedIndex;//seçili indeks
            bool saglikOzru = chkSaglik.Checked;//seçili ise true
            bool tecilVarMi = rdTecilEvet.Checked;//seçili ise true

            if (cinsiyet == 0) //Erkek demek
            {
                if (yas > 20) //Yaþý uygun
                {
                    if (!saglikOzru)//saðlýk durumu uygun
                    {
                        if (!tecilVarMi)
                        {
                            lblDurum.Text = "ASKERE GÝDEBÝLÝR";
                        }
                        else lblDurum.Text = "Tecil var.";
                    }
                    else lblDurum.Text = "Saðlýk durumu uygun deðil.";
                }
                else lblDurum.Text = "Yaþ uygun deðil.";
            }
            else lblDurum.Text = "Cinsiyet Uygun Deðil.";
        }
    }
}
