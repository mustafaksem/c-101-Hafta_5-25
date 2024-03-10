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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            switch (listBox1.SelectedItem.ToString())
            {
                case "İstanbul":
                    pictureBox1.Image = Image.FromFile("resim/istanbul.jpg");
                    break;
                case "Ankara":               
                    pictureBox1.Image = Image.FromFile("resim/ankara.jpg");
                    break;
                case "İzmir":
                    pictureBox1.Image = Image.FromFile("resim/izmir.jpg");
                    break;
                case "Antalya":
                    pictureBox1.Image = Image.FromFile("resim/Antalya.jpeg");
                    break;
                case "Aydın":
                    pictureBox1.Image = Image.FromFile("resim/aydın.jpeg");
                    break;

            }


        }
    }
}
