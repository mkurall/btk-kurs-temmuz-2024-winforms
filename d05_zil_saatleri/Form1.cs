namespace d05_zil_saatleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var saat = DateTime.Now;
            //lblSaat.Text = $"{saat:T}";
            lblSaat.Text = saat.ToString("T");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {    //         1
            //[14:30, 14:50, 16:40]

            for (int i = 0; i < lbSaatler.Items.Count; i++) {

                string saat = lbSaatler.Items[i].ToString();

                DateTime oncekiSaat = DateTime.Parse(saat);
                DateTime yeniSaat = DateTime.Parse(txtSaat.Text);

                // 14:45 < 14:50 

                if (yeniSaat < oncekiSaat)
                {
                    lbSaatler.Items.Insert(i, txtSaat.Text);
                    return;//kenidnden sontraki hiç bir kod çalýþmaz
                }
            }

            
            lbSaatler.Items.Add(txtSaat.Text);
        }
    }
}
