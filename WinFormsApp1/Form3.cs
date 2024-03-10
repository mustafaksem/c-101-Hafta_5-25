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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            if (chTopla.Checked)
            {
                int toplam = Convert.ToInt32(tbSayi1.Text) + Convert.ToInt32(tbSayi2.Text);
                lBox.Items.Add((Convert.ToInt32(tbSayi1.Text) + "+" + Convert.ToInt32(tbSayi2.Text) + "=" + toplam));
            }
            if (chCarp.Checked)
            {
                int carpim = Convert.ToInt32(tbSayi1.Text) * Convert.ToInt32(tbSayi2.Text);
                lBox.Items.Add((Convert.ToInt32(tbSayi1.Text) + "*" + Convert.ToInt32(tbSayi2.Text) + "=" + carpim));
            }
            if (chCikar.Checked)
            {
                int cikar = Convert.ToInt32(tbSayi1.Text) - Convert.ToInt32(tbSayi2.Text);
                lBox.Items.Add((Convert.ToInt32(tbSayi1.Text) + "-" + Convert.ToInt32(tbSayi2.Text) + "=" + cikar));
            }
            if (chBol.Checked)
            {

                double bol = Convert.ToInt32(tbSayi1.Text) / Convert.ToInt32(tbSayi2.Text);
                lBox.Items.Add((Convert.ToInt32(tbSayi1.Text) + "+" + Convert.ToInt32(tbSayi2.Text) + "=" + bol));
            }

        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            lBox.Items.Clear();
            chBol.Checked = false;
            chCarp.Checked = false;
            chCikar.Checked = false;
            chTopla.Checked = false;
           
        }
    }
}
