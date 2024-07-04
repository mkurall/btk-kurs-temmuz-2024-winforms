using System.Windows.Forms.VisualStyles;

namespace d04_tic_tac_toe
{
    public partial class Form1 : Form
    {
        int siraKimde = 0; //global

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            siraKimde = 0;
            SiraGoster();
        }

        void SiraGoster()
        {
            if (siraKimde == 0)
            {
                lblOyuncu1.BackColor = Color.Red;
                lblOyuncu1.ForeColor = Color.White;

                lblOyuncu2.BackColor = Color.Silver;
                lblOyuncu2.ForeColor = Color.Black;
            }
            else
            {
                lblOyuncu2.BackColor = Color.Red;
                lblOyuncu2.ForeColor = Color.White;

                lblOyuncu1.BackColor = Color.Silver;
                lblOyuncu1.ForeColor = Color.Black;
            }
        }
       
        bool KontrolEt()
        {
            Image img = siraKimde == 0 ?  pictureBox1.Image : pictureBox2.Image;

            if (btn00.BackgroundImage == img && btn01.BackgroundImage == img && btn02.BackgroundImage == img ||
                btn00.BackgroundImage == img && btn11.BackgroundImage == img && btn22.BackgroundImage == img ||
                btn00.BackgroundImage == img && btn10.BackgroundImage == img && btn20.BackgroundImage == img ||
                btn01.BackgroundImage == img && btn11.BackgroundImage == img && btn21.BackgroundImage == img ||
                btn02.BackgroundImage == img && btn12.BackgroundImage == img && btn22.BackgroundImage == img ||
                btn10.BackgroundImage == img && btn11.BackgroundImage == img && btn12.BackgroundImage == img ||
                btn20.BackgroundImage == img && btn21.BackgroundImage == img && btn22.BackgroundImage == img ||
                btn02.BackgroundImage == img && btn11.BackgroundImage == img && btn20.BackgroundImage == img)
            return true;

            return false;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            //bütün butonlar týklandýðýndA burasý çalýþýyorsa
            //hangisi týklandý? sender
            Button btnTiklanan = (Button)sender; //int = (int)double

            if (siraKimde==0)
            {
                btnTiklanan.BackgroundImage = pictureBox1.Image;
                btnTiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                btnTiklanan.Enabled = false;//pasif
                //kazandým mý? kontrol et
                if (KontrolEt())
                    lblKazanan.Text = "1.OYUNCU KAZANDI";

                siraKimde = 1;
            }
            else
            {
                btnTiklanan.BackgroundImage = pictureBox2.Image;
                btnTiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                btnTiklanan.Enabled = false;

                if (KontrolEt())
                    lblKazanan.Text = "2.OYUNCU KAZANDI";

                siraKimde = 0;
            }



            SiraGoster();
        }
    }
}
