using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                int sayilar = rndm.Next(1, 50);
                lBoxSayilar.Items.Add(sayilar);
                //toplam += sayilar;
            }
            //lblSonuc.Text = "Toplam  : " + toplam.ToString();
            for (int i = 0; i < lBoxSayilar.Items.Count; i++)
            {
                toplam += Convert.ToInt32(lBoxSayilar.Items[i]);

            }
            lblSonuc.Text = "Toplam  : " + toplam.ToString();
        }

        private void btnEnBuyukSayi_Click(object sender, EventArgs e)
        {
            int enBuyuk = Convert.ToInt32(lBoxSayilar.Items[0]);
            for (int i = 0; i < lBoxSayilar.Items.Count; i++)
            {
                if (Convert.ToInt32(lBoxSayilar.Items[i])> enBuyuk )
                {
                    enBuyuk = Convert.ToInt32(lBoxSayilar.Items[i]);
                }
                
            }
            label1.Text = enBuyuk.ToString();
        }
    }
}
