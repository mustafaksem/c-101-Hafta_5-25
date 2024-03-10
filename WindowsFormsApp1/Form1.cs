using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    // sol kutudaki veriyi sağa aktarınca soldaki veriyi sil
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem==null)
            {
                MessageBox.Show("Herhang bir öge seçilmedi !");
            }
            else
            {
                try
                {
                    string secilen = Convert.ToInt32(listBox1.SelectedItem).ToString();
                    listBox2.Items.Add(secilen);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    int toplama = 0;
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        toplama += Convert.ToInt32(listBox2.Items[i]);
                    }


                    if (listBox2.Items.Count > 1)
                    {
                        int enBuyuk = Convert.ToInt32(listBox2.Items[0]);
                        int enKucuk = Convert.ToInt32(listBox2.Items[0]);
                        //int toplam = 0;
                        foreach (var item in listBox2.Items)
                        {
                            int sayi = Convert.ToInt32(item);
                            //toplam += sayi;
                            if (sayi > enBuyuk)
                            {
                                enBuyuk = sayi;
                            }
                            if (sayi < enKucuk)
                            {
                                enKucuk = sayi;
                            }
                        }
                        lblEnBuyuk.Text = enBuyuk.ToString();
                        lblEnKucuk.Text = enKucuk.ToString();
                        double ortalama = toplama / listBox2.Items.Count;
                        lblToplam.Text = toplama.ToString();
                        lblOrtalama.Text = ortalama.ToString();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("HATA! Girilen değer sayı değil.");
                }                   
            }                         
            //listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text == "")
                MessageBox.Show("Lütfen bir değer giriniz.");
            //else if (listBox1.Items.Contains(txtMetin.Text))
            //    MessageBox.Show("Girdiğiniz değer daha önce girilmiş");
            else
            {
                bool durum = true;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (txtMetin.Text == listBox1.Items[i].ToString())
                    {
                        MessageBox.Show("Girdiğiniz değer daha önce girilmiş");
                        break;
                    }
                }
                if (durum)
                {
                    listBox1.Items.Add(txtMetin.Text);
                }
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            foreach (var item in listBox2.Items)
            {
                liste.Add(Convert.ToInt32(item)); 
            }
            liste.Sort();
            listBox2.Items.Clear();
            foreach (var item in liste)
            {
                listBox2.Items.Add(item.ToString());
            }
        }
    }
}
