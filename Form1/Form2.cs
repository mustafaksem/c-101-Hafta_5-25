using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Soru 2 : Comboboxta seçilen sayı kadar mesaj kutusu oluşturunuz.
            // merhaba 1
            // Merhaba 2
        }

        private void comboMsjKutusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int secilenSayi= Convert.ToInt32(comboMsjKutusu.SelectedItem.ToString());
            //for (int i = 0; i < secilenSayi; i++) 
            //{ 
            //    MessageBox.Show (i + " mesaj"); 
            //}
            int secilenSayi = Convert.ToInt32(comboMsjKutusu.Text);
            for (int i = 0; i < secilenSayi; i++)
            {
                MessageBox.Show(i+1 + " mesaj");
            }

        }

        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32 (txtbSayi.Text);
            for (int i = 11;i < sayi; i++)
            {
                comboMsjKutusu.Items.Add(i);
            }

            // Bir buton ekleyip, butona tıklandığında combobox içine rastgele 5 sayı ekliyor.
            // Combobox içindeki sayıların toplammını MessageBox ile veriniz.
            // combobox eleman sayısı "comboMsjKutusu.Items.Count"
            int toplama = 0;
            for (int a = 0; a <comboMsjKutusu.Items.Count; a++)
            {
                int sayi1 = Convert.ToInt32(comboMsjKutusu.Items[a]);
                toplama += sayi1;
            }
            MessageBox.Show(toplama.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            for (int i = 0; i < 5; i++)
            {
                int rastgeleSayi = rndm.Next(1, 50);
                comboMsjKutusu.Items.Add(rastgeleSayi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
