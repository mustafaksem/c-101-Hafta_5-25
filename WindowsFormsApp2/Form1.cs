using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDeneme.Location = new Point(30,60);
        }

        private void btnDeneme_MouseHover(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int x = random.Next(1, 800);
            //int y = random.Next(1,400);
            //btnDeneme.Location = new Point(x, y);
            int butonGenislik = btnDeneme.Width;
            int butonYukseklik = btnDeneme.Height;
            int formGenisligi = Form1.ActiveForm.Width;
            int formYuksekligi = Form1.ActiveForm.Height;
            Random rndm = new Random();
            int x = rndm.Next(0,formGenisligi- butonGenislik);
            int y = rndm.Next(0,formYuksekligi- butonYukseklik-50);
            btnDeneme.Location = new Point(x, y);
            if (progressBar1.Value<=90)
            {
                progressBar1.Value += 10;
            }

        }
    }
}
