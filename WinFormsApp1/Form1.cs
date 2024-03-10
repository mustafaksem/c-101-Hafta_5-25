namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Soru 1: 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = (Convert.ToInt32(button1.Text) + 1).ToString();

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int girilenSayi = Convert.ToInt32(txtSayi.Text);
                int toplam = 0;
                if (girilenSayi < 0)
                {
                    for (int i = girilenSayi; i < 0; i++)
                    {
                        toplam += i;
                    }
                }
                else
                {
                    for (int i = 1; i <= girilenSayi; i++)
                    {
                        toplam += i;
                    }
                }
                txtSonuc.Text = toplam.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA! Lütfen numerik bir ifade giriniz.");
            }                      
        }
    }
}
