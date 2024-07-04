namespace d01_merhaba_dunya
{
    public partial class Form1 : Form
    {
        public Form1() //Yapýcý metot
        {
            InitializeComponent();//formun tasarýmýný oluþturur
        }

        //bu metot designer tarafýndan oluþtruldu
        //ve button1 click olayý ile iliþkilendirildi
        //event(olay)
        private void button1_Click(object sender, EventArgs e)
        {
            //windows senin bu butonun týklandý diye bize bildiriyor
            //string ad = Console.ReadLine();
            string ad = textBox1.Text;
            //Console.WriteLine($"Merhaba, {ad}");
            label2.Text = $"Merhaba, {ad}";
        }
    }
}
