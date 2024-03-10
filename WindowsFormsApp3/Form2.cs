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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList istanbul = new ArrayList { "Beşiktaş", "Kadıköy", "Üsküdar" };          
            ArrayList ankara= new ArrayList { "Çankaya", "Kızılay", "Mamak" };
            string[] izmir = new string[3] { "Konak", "Karşıyaka", "Bornova" };    

            string seciliSehir = cbSehirler.SelectedItem.ToString();
            if (seciliSehir == "İstanbul")
            {
                lblPlaka.Text = ("34");
                for (int i = 0; i < istanbul.Count; i++)
                    lbIlceler.Items.Add(istanbul[i]);
            }               
            else if (seciliSehir == "Ankara")
            {
                lbIlceler.DataSource = ankara;
                lblPlaka.Text = ("06");
            }
                
            else if (seciliSehir == "İzmir")
            {
                lblPlaka.Text = ("35");
                for (int i = 0; i < 3; i++)
                    lbIlceler.DataSource = izmir;
            }

        }
    }
}
