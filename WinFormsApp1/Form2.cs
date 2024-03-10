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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                double not1 = Convert.ToInt32(txtNot1.Text);
                double not2 = Convert.ToInt32(txtNot2.Text);
                double not3 = Convert.ToInt32(txtNot3.Text);
                double ortalama = (not1 + not2 + not3) / 3;
                lblSonuc.Text = ortalama.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu. ");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
