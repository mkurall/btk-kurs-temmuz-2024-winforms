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

        private void btn00_Click(object sender, EventArgs e)
        {
            //

            if(siraKimde==0)
            {
                siraKimde = 1;
            }
            else
            {
                siraKimde = 0;
            }

            SiraGoster();
        }
    }
}
