using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (rbSecim1.Checked)
            //{
            //    pictureBox1.Image = Image.FromFile("resim/istanbul.jpg");
            //}
            //if (rbSecim2.Checked)
            //{
            //    pictureBox1.Image = Image.FromFile("resim/ankara.jpg");
            //}
            //if (rbSecim3.Checked)
            //{
            //    pictureBox1.Image = Image.FromFile("resim/izmir.jpg");
            //}
            //if (rbSecim4.Checked)
            //{
            //    pictureBox1.Image = Image.FromFile("resim/Antalya.jpeg");
            //}
            //if (rbSecim5.Checked)
            //{
            //    pictureBox1.Image = Image.FromFile("resim/aydın.jpeg");
            //}
        }

        private void rbSecim5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSecim5.Checked)
            {
                pictureBox1.Image = Image.FromFile("resim/istanbul.jpg");
                listBox1.Items.Add("istanbul seçildi.");
            }
            else
            {
                listBox1.Items.Add("istanbul seçimi kaldırıldı.");
            }
        }

        private void rbSecim4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSecim4.Checked)
            {
                pictureBox1.Image = Image.FromFile("resim/ankara.jpg");
                listBox1.Items.Add("ankara seçildi.");
            }
            else
            {
                listBox1.Items.Add("ankara seçimi kaldırıldı.");
            }
        }

        private void rbSecim3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSecim3.Checked)
            {
                pictureBox1.Image = Image.FromFile("resim/izmir.jpg");
                listBox1.Items.Add("izmir seçildi.");
            }else
            {
                listBox1.Items.Add("izmir seçimi kaldırıldı.");
            }
        }

        private void rbSecim2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSecim2.Checked)
            {
                pictureBox1.Image = Image.FromFile("resim/Antalya.jpeg");
                listBox1.Items.Add("Antalya seçildi.");
            }
            else
            {
                listBox1.Items.Add("Antalya seçimi kaldırıldı.");
            }
        }

        private void rbSecim1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSecim1.Checked)
            {
                pictureBox1.Image = Image.FromFile("resim/aydın.jpeg");
                listBox1.Items.Add("aydın seçildi.");
            }
            else
            {
                listBox1.Items.Add("aydın seçimi kaldırıldı.");
            }
        }
    }
}
