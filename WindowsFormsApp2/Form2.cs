using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAsalSayilar_Click(object sender, EventArgs e)
        {
            if (tbSayi1.Text == string.Empty)
                MessageBox.Show("İlk sayıyı girmelisiniz");
            else if (tbSayi2.Text == string.Empty)
                MessageBox.Show("İkinci sayıyı girmelisiniz");
            int sayi1 = 0;
            int sayi2 = 0;
            try
            {
                sayi1 = Convert.ToInt32(tbSayi1.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("birinci sayı için doğru formatta veri giriniz.");
            }
            try
            {
                sayi2 = Convert.ToInt32(tbSayi2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("İkinci sayı için doğru formatta veri giriniz.");
            }
            if (sayi1 >= sayi2)
                MessageBox.Show("İlk sayı ikinci sayıdan küçük olmalıdır.");
            else
            {
                int toplam = 0;
                for (int i = sayi1+1; i < sayi2; i++)
                {
                    if (AsalSayiMi(i)==true)
                    {
                        lbSayilar.Items.Add(i);
                        toplam += i;
                    }
                }
                MessageBox.Show(lbSayilar.Items.Count.ToString() + " adet asal sayı bulunmuştur.");
                lblToplama.Text=toplam.ToString();
                lblOrtalama.Text=(Convert.ToDouble(toplam)/lbSayilar.Items.Count).ToString();
                lblEnKucuk.Text = lbSayilar.Items[0].ToString();
                lblEnBuyuk.Text = lbSayilar.Items[lbSayilar.Items.Count-1].ToString();
            }
        }
        private bool AsalSayiMi(int sayi)
        {
            bool sonuc = true;
            if (sayi==2)
            {
                sonuc = true;
            }
            else
            {
               for(int i = 2; i < sayi; i++)
                {
                    if (sayi%i==0)
                    {
                        sonuc = false;
                        break;
                    }
                }
                
            }
            return sonuc; 
        }

        private void lbSayilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lbSayilar.SelectedItem.ToString());
            progressBar1.Value = Convert.ToInt32(lbSayilar.SelectedItem.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
