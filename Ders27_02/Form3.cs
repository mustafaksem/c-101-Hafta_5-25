using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders27_02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form3_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("OkulNo");
            dt.Columns.Add("TCNo");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAdi.Text == string.Empty)
                MessageBox.Show("Öğrenci adı boş geçilemez.");
            else if (txtOgrenciSoyadi.Text == string.Empty)
                MessageBox.Show("Öğrenci soyadı boş geçilemez.");
            else if (txtokulNumarasi.Text == string.Empty)
                MessageBox.Show("Öğrenci okul numarası boş geçilemez.");
            else if (txtTCKimlikNo.Text.Length !=11)
                MessageBox.Show("TC Kimlik NO 11 haneli olmalıdır..");
            else
            {
                DataRow dr = dt.NewRow();
                dr["Ad"] = txtOgrenciAdi.Text;
                dr["Soyad"] = txtOgrenciSoyadi.Text;
                dr["OkulNo"] = txtokulNumarasi.Text;
                dr["TCNo"] = txtTCKimlikNo.Text;
                dt.Rows.Add(dr);
                dgOgrenciler.DataSource = dt;
            }
        }
    }
}
