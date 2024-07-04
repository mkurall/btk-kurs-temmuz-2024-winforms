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
            Baslat();
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
        void Baslat()
        {
            siraKimde = 0;
            SiraGoster();

            btn00.Enabled = btn01.Enabled = btn02.Enabled =
            btn10.Enabled = btn11.Enabled = btn12.Enabled =
            btn20.Enabled = btn21.Enabled = btn22.Enabled = true;

            btn00.BackgroundImage = btn01.BackgroundImage = btn02.BackgroundImage =
            btn10.BackgroundImage = btn11.BackgroundImage = btn12.BackgroundImage =
            btn20.BackgroundImage = btn21.BackgroundImage = btn22.BackgroundImage = null;
        }
        void Bitir()
        {
            lblOyuncu1.BackColor = Color.Transparent;
            lblOyuncu1.ForeColor = Color.Black;
            lblOyuncu2.BackColor = Color.Transparent;
            lblOyuncu2.ForeColor = Color.Black;

            btn00.Enabled = btn01.Enabled = btn02.Enabled =
            btn10.Enabled = btn11.Enabled = btn12.Enabled =
            btn20.Enabled = btn21.Enabled = btn22.Enabled = false;
        }

        bool BittiMi()
        {
            if (btn00.Enabled == false && btn01.Enabled == false && btn02.Enabled == false &&
            btn10.Enabled == false && btn11.Enabled == false && btn12.Enabled == false &&
            btn20.Enabled == false && btn21.Enabled == false && btn22.Enabled == false)
                return true;
            else
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
                {
                    lblKazanan.Text = "1.OYUNCU KAZANDI";
                    Bitir();
                    return;
                }

                siraKimde = 1;//sonraki oyuncuya sýra geçti
            }
            else
            {
                btnTiklanan.BackgroundImage = pictureBox2.Image;
                btnTiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                btnTiklanan.Enabled = false;

                if (KontrolEt())
                {
                    lblKazanan.Text = "2.OYUNCU KAZANDI";
                    Bitir();
                    return;
                }

                siraKimde = 0;//sonraki oyuncuya sýra geçti
            }

            if(BittiMi())
            {
                lblKazanan.Text = "BERABERE";
                Bitir();
                return;
            }


            SiraGoster();
        }
    }
}
