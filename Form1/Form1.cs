using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Ekrana bir şey yazmak istediğimizde console.write yazıyordk. Artık farklı.
        //    // 1 - Herhangi bir elemente yazdırabilirz.
        //    // 2 - MessageBox
        //    MessageBox.Show("Butona tıklandı.");
        //    toplaMesaji.Text = "merhaba";
        //    int sayi1 = Convert.ToInt32(sayiBilgisi1.Text);
        //    int sayi2 = Convert.ToInt32(sayiBilgisi2.Text);
        //    int toplam = sayi1 + sayi2;
        //    toplaMesaji.Text = toplam.ToString();
            
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {   
            int sayi1 = Convert.ToInt32(sayiBilgisi1.Text);
            int sayi2 = Convert.ToInt32(sayiBilgisi2.Text);
            int toplam = sayi1 + sayi2;
            sonucBilgisi.Text = toplam.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayiBilgisi1.Text);
            int sayi2 = Convert.ToInt32(sayiBilgisi2.Text);
            if (sayi1>sayi2)
            {
                int cikart = sayi1 - sayi2;
                sonucBilgisi.Text = cikart.ToString();
            }
            else
            {
                int cikart = sayi2 - sayi1;
                sonucBilgisi.Text = cikart.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayiBilgisi1.Text);
            int sayi2 = Convert.ToInt32(sayiBilgisi2.Text);
            sonucBilgisi.Text = (sayi1 * sayi2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayiBilgisi1.Text);
            int sayi2 = Convert.ToInt32(sayiBilgisi2.Text);
            int bol = sayi1 / sayi2;
            sonucBilgisi.Text = bol.ToString();
        }
    }
}
